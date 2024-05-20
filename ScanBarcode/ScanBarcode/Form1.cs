using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using AForge.Video;

namespace ScanBarcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCameraDevices();
        }

        VideoCaptureDevice videoCaptureDevice;

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

    }
}
