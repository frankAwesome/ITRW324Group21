using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;

using ChatApplication;

namespace SkypeDemo
{
    public partial class frmVideoChat : Form
    {
        int panelWidth;
        bool Hidden;
        bool bFormLoaded = false;




        public frmVideoChat()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;
            // Get host name
            String strHostName = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                txtStreamToIP.Text = ipaddress.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 10;

   


                if (PanelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 10;


                if (PanelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            axVideoChatSender.VideoDevice = (short)comboBoxVideoDevice.SelectedIndex;

            axVideoChatSender.AudioDevice = (short)comboBoxAudioDevice.SelectedIndex;


            axVideoChatSender.VideoFormat = (short)comboBoxVideoFormat.SelectedIndex;
            axVideoChatSender.FrameRate = Convert.ToInt32(txtFrameRate.Text, 10);
            axVideoChatSender.VideoBitrate = Convert.ToInt32(txtVideoBitrate.Text, 10);
            axVideoChatSender.AudioComplexity = (short)comboBoxAudioComplex.SelectedIndex;
            axVideoChatSender.AudioQuality = (short)comboBoxAudioQuality.SelectedIndex;
            axVideoChatSender.SendAudioStream = (bool)checkBoxSendAudio.Checked;
            axVideoChatSender.SendVideoStream = (bool)checkBoxSendVideo.Checked;

            axVideoChatSender.ConferenceNumber = 0;
            axVideoChatSender.ConferenceUserID = 0;

            int iResult = axVideoChatSender.Connect(txtStreamToIP.Text, Convert.ToInt32(txtPortno.Text, 10));
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
              

            int ivideodevicecount = 0;
            int iaudiodevicecount = 0;
            int i = 0;
            ivideodevicecount = axVideoChatSender.GetVideoDeviceCount();
            for (i = 0; i < ivideodevicecount; i++)
                comboBoxVideoDevice.Items.Add(axVideoChatSender.GetVideoDeviceName((short)i));

            if (comboBoxVideoDevice.Items.Count > 0)
                comboBoxVideoDevice.SelectedIndex = 0;

            iaudiodevicecount = axVideoChatSender.GetAudioDeviceCount();

            for (i = 0; i < iaudiodevicecount; i++)
                comboBoxAudioDevice.Items.Add(axVideoChatSender.GetAudioDeviceName((short)i));
            if (comboBoxAudioDevice.Items.Count > 0)
                comboBoxAudioDevice.SelectedIndex = 0;

            comboBoxVideoFormat.Items.Add("160x120");
            comboBoxVideoFormat.Items.Add("176x144");
            comboBoxVideoFormat.Items.Add("320x240");
            comboBoxVideoFormat.Items.Add("352x288");
            comboBoxVideoFormat.Items.Add("640x480");
            comboBoxVideoFormat.Items.Add("1280x720");
            comboBoxVideoFormat.SelectedIndex = 4;

            comboBoxAudioComplex.Items.Add("0");
            comboBoxAudioComplex.Items.Add("1");
            comboBoxAudioComplex.Items.Add("2");
            comboBoxAudioComplex.Items.Add("3");
            comboBoxAudioComplex.SelectedIndex = 0;

            for (i = 0; i <= 10; i++)
                comboBoxAudioQuality.Items.Add(i.ToString());

            comboBoxAudioQuality.SelectedIndex = 8;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            axVideoChatSender.Disconnect();
        }

        private void buttonDisconnectListen_Click(object sender, EventArgs e)
        {
            axVideoChatReceiver.Disconnect();
        }

        private void buttonStartListen_Click(object sender, EventArgs e)
        {
            axVideoChatReceiver.Disconnect();
            axVideoChatReceiver.Listen(txtListenIP.Text, Convert.ToInt32(txtListenPortno.Text, 10));
        }

        private void button2_Click(object sender, EventArgs e)
        {



            Client frm5 = new Client();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }

                frm5.BringToFront();

            this.Hide();



        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void frmVideoChat_Load(object sender, EventArgs e)
        {
            bFormLoaded = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm5 = new Form2();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }

                frm5.BringToFront();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frm5 = new Form4();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }


            frm5.BringToFront();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm5 = new Form3();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }


            frm5.BringToFront();

            this.Hide();
        }

        private void PanelSlide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
