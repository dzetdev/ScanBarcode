using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using ZXing.QrCode.Internal;
using ZXing.Common;
using BarcodeStandard;
namespace ScanBarcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCameraDevices();
            dataGridViewResults.Columns.Add("Time", "Thời gian");
            dataGridViewResults.Columns.Add("Barcode", "Barcode");
            label1.Font = new Font("IDAutomationHC39M", 12, FontStyle.Regular);
            tbResult.ReadOnly = true;
            tbResult.Enabled = false;
        }

        VideoCaptureDevice videoCaptureDevice;
        private Bitmap bitm;

        private void LoadCameraDevices()
        {
            try
            {
                FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No video sources found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (FilterInfo device in videoDevices)
                {
                    cbCam.Items.Add(device.Name);
                }

                if (cbCam.Items.Count > 0)
                {
                    cbCam.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCamera = cbCam.SelectedItem.ToString();
            MessageBox.Show($"You selected: {selectedCamera}", "Selected Camera", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string selectedCamera = cbCam.SelectedItem.ToString();

            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            FilterInfo selectedDevice = null;

            foreach (FilterInfo device in videoDevices)
            {
                if (device.Name == selectedCamera)
                {
                    selectedDevice = device;
                    break;
                }
            }

            if (selectedDevice != null)
            {
                videoCaptureDevice = new VideoCaptureDevice(selectedDevice.MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(bitmap);

            if (result != null)
            {
                tbResult.Invoke(new MethodInvoker(delegate ()
                {
                    tbResult.Text = result.Text;

                    bool barcodeExists = false;
                    foreach (DataGridViewRow row in dataGridViewResults.Rows)
                    {
                        if (row.Cells["Barcode"].Value != null && row.Cells["Barcode"].Value.ToString() == result.Text)
                        {
                            barcodeExists = true;
                            break;
                        }
                    }

                    if (!barcodeExists)
                    {
                        string[] newRow = new string[] { DateTime.Now.ToString("HH:mm:ss"), result.Text };
                        dataGridViewResults.Rows.Add(newRow);
                    }
                }));
            }
            pbDisplayCam.Image = bitmap;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    videoCaptureDevice = null;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    videoCaptureDevice = null;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string barcode = tbInput.Text;

            bitm = new Bitmap(barcode.Length * 45, 160);
            using (Graphics graphic = Graphics.FromImage(bitm))
            {
                Font newfont = new Font("IDAutomationHC39M", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);

                graphic.FillRectangle(white, 0, 0, bitm.Width, bitm.Height);

                graphic.DrawString("*" + barcode + "*", newfont, black, point);
            }

            MemoryStream stream = new MemoryStream();
            bitm.Save(stream, ImageFormat.Png);

            pbResult.Image = Image.FromStream(stream);
            pbResult.SizeMode = PictureBoxSizeMode.AutoSize;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bitm != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Files (*.png)|*.png|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        bitm.Save(saveFileDialog.FileName, ImageFormat.Png);

                        MessageBox.Show($"Barcode saved as {saveFileDialog.FileName}", "Barcode Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please generate the barcode first.", "Barcode Not Generated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected image
                        string imagePath = openFileDialog.FileName;
                        Bitmap image = new Bitmap(imagePath);

                        pbDisplayCam.Image = image;
                        pbDisplayCam.SizeMode = PictureBoxSizeMode.AutoSize;

                        ReadBarcodeFromImage(image);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ReadBarcodeFromImage(Bitmap image)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode(image);

            if (result != null)
            {
                tbResult.Invoke(new MethodInvoker(delegate ()
                {
                    tbResult.Text = result.Text;

                    bool barcodeExists = false;
                    foreach (DataGridViewRow row in dataGridViewResults.Rows)
                    {
                        if (row.Cells["Barcode"].Value != null && row.Cells["Barcode"].Value.ToString() == result.Text)
                        {
                            barcodeExists = true;
                            break;
                        }
                    }

                    if (!barcodeExists)
                    {
                        string[] newRow = new string[] { DateTime.Now.ToString("HH:mm:ss"), result.Text };
                        dataGridViewResults.Rows.Add(newRow);
                    }
                }));
            }
            else
            {
                MessageBox.Show("No barcode detected.", "Barcode Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
