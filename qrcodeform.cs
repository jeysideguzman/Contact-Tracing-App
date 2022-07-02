using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Contact_Tracing_App
{
    public partial class qrcodeform : Form
    {
        public qrcodeform()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice capture;

        private void qrcodeform_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filter)
                comboBox1.Items.Add(filter.Name);
            comboBox1.SelectedIndex = 0;
        }

        private void scanbtn_Click(object sender, EventArgs e)
        {
            capture = new VideoCaptureDevice(filter[comboBox1.SelectedIndex].MonikerString);
            capture.NewFrame += Capture_NewFrame;
            capture.Start();
            timer1.Start();
        }

        private void Capture_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void qrcodeform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capture.IsRunning)
                capture.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader bcreader = new BarcodeReader();
                Result result = bcreader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    scanrtb.Text = result.ToString();
                    timer1.Stop();
                    if (capture.IsRunning)
                        capture.Stop();
                }
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterForm form = new filterForm();
            form.ShowDialog();
            
        }

        private void exitbtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
