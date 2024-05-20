using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ScanBarcode
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Attempt to load available video devices
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cbCam.Items.Clear();

                foreach (FilterInfo device in filterInfoCollection)
                {
                    cbCam.Items.Add(device.Name);
                }

                if (cbCam.Items.Count > 0)
                {
                    cbCam.SelectedIndex = 0; // Select the first camera by default
                    MessageBox.Show("Cameras loaded successfully.");
                }
                else
                {
                    MessageBox.Show("No camera devices found.");
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("No local capture devices found: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading camera devices: " + ex.Message);
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a camera is selected
                if (cbCam.SelectedIndex >= 0 && cbCam.SelectedIndex < filterInfoCollection.Count)
                {
                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCam.SelectedIndex].MonikerString);
                    videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                    videoCaptureDevice.Start();
                }
                else
                {
                    MessageBox.Show("Please select a valid camera from the list.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while starting the camera: " + ex.Message);
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the video frame: " + ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopVideoCapture();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopVideoCapture();
        }

        private void StopVideoCapture()
        {
            try
            {
                if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.SignalToStop();
                    videoCaptureDevice.WaitForStop();
                    videoCaptureDevice = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while stopping the camera: " + ex.Message);
            }
        }
    }
}
