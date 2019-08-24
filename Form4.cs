using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeDemo
{
    public partial class Form4 : Form
    {
        bool bFormLoaded = false;
        int panelWidth;
        bool Hidden;

        public Form4()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            button7.Visible = false;
            label3.Visible = false;
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
            frmVideoChat frm5 = new frmVideoChat();
            if (bFormLoaded == false)
            {
                frm5.Show();
                bFormLoaded = true;
            }


            frm5.BringToFront();

            this.Hide();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            short imp3bitrate = 0;
            if (chkcapturespeaker.Checked)
            {
                axAudioCapture1.CapturePlaybackDevice = true;
                axAudioCapture1.PlaybackDevice = (short)cboplaybackdevice.SelectedIndex;

            }
            else
                axAudioCapture1.CapturePlaybackDevice = false;




            axAudioCapture1.RecordLevel = TrackBar2.Value * 0.1;


            axAudioCapture1.UsePitch = chkusepitch.Checked;


            if (chkusepitch.Checked)
                axAudioCapture1.PitchValue = (short)(TrackBar1.Value - 20);



            axAudioCapture1.AudioDevice = (short)cboaudiodevice.SelectedIndex;
            axAudioCapture1.AudioInputPin = (short)cboinputpin.SelectedIndex;
            axAudioCapture1.SetWaveWndOwner(this.axAudioCapture1.GetContainerWndHandle());

            axAudioCapture1.ShowWaveForm = chkshowwaveform.Checked;

            axAudioCapture1.SetWaveWndPopUp(chkshowpopup.Checked);
            axAudioCapture1.SetWaveWndPos(Convert.ToInt32(txtleft.Text), Convert.ToInt32(txttop.Text), Convert.ToInt32(txtwidth.Text), Convert.ToInt32(txtheight.Text));
            axAudioCapture1.SetWaveWndCaption(txtcaption.Text);

            if (optwave.Checked)
            {
                this.saveFileDialog1.Filter = "WAV File (*.wav)|*.wav";

                axAudioCapture1.OutputType = AUDIOCAPTURELib.AudioEnum.AUDIO_WAV;

                if (cboChannel.SelectedIndex == 0)
                    axAudioCapture1.WaveChannels = 1;
                else
                    axAudioCapture1.WaveChannels = 2;



                if (cboChannel.SelectedIndex == 0)
                    axAudioCapture1.WaveChannels = 1;
                else
                    axAudioCapture1.WaveChannels = 2;



                if (cbobitpersample.SelectedIndex == 0)
                    axAudioCapture1.WaveBitsPerSample = 1;
                else
                    axAudioCapture1.WaveBitsPerSample = 2;


                axAudioCapture1.WaveSamplesPerSec = Convert.ToInt32(cbofreq.Text);


            }

            if (optwma.Checked)
            {
                this.saveFileDialog1.Filter = "WMA File (*.wma)|*.wma";

                axAudioCapture1.OutputType = AUDIOCAPTURELib.AudioEnum.AUDIO_WMA;
                axAudioCapture1.WMVProfile = (short)cbowma.SelectedIndex;

            }

            if (optMP3.Checked)
            {
                this.saveFileDialog1.Filter = "MP3 File (*.mp3)|*.mp3";

                axAudioCapture1.OutputType = AUDIOCAPTURELib.AudioEnum.AUDIO_MP3;

                if (cbomp3channel.SelectedIndex == 0)
                    axAudioCapture1.MP3Channels = 1;
                else
                    axAudioCapture1.MP3Channels = 2;


                if (cbomp3freq.SelectedIndex == 0)
                    imp3bitrate = (short)Convert.ToInt32(cbomp3bitrate.Text);

                if (imp3bitrate > 160)
                {
                    MessageBox.Show("your bitrate must equal or smaller than 160");
                    return;
                }



                imp3bitrate = (short)Convert.ToInt32(cbomp3bitrate.Text);


                axAudioCapture1.MP3AudioBitrate = (short)imp3bitrate;
                axAudioCapture1.MP3SampleRate = (short)Convert.ToInt32(cbomp3freq.Text);

            }



            if (this.saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                txtfilename.Text = this.saveFileDialog1.FileName;
                axAudioCapture1.AudioFileName = this.saveFileDialog1.FileName;
                axAudioCapture1.Start();

                button1.Visible = false;
                label2.Visible = false;

                button7.Visible = true;
                label3.Visible = true;
            }

            if (chkleftdown.Checked)
                axAudioCapture1.SetWaveWndOffset(0, (short)UpDownLeft.Value);
            else
                axAudioCapture1.SetWaveWndOffset(0, (short)(UpDownLeft.Value * -1));

            if (chkrightdown.Checked)
                axAudioCapture1.SetWaveWndOffset(1, (short)UpDownRight.Value);
            else
                axAudioCapture1.SetWaveWndOffset(1, (short)(UpDownRight.Value * -1));

            btnwavebgcolor.Enabled = false;
            btnwaveleftcolor.Enabled = false;
            btnwaverightcolor.Enabled = false;
            chkshowpopup.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            axAudioCapture1.Stop();

            btnwavebgcolor.Enabled = true;
            btnwaveleftcolor.Enabled = true;
            btnwaverightcolor.Enabled = true;
            chkshowpopup.Enabled = true;

            button1.Visible = true;
            label2.Visible = true;

            button7.Visible = false;
            label3.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {


            int i = 0;

            cbomp3bitrate.Items.Add("8");
            cbomp3bitrate.Items.Add("16");
            cbomp3bitrate.Items.Add("24");
            cbomp3bitrate.Items.Add("32");
            cbomp3bitrate.Items.Add("40");
            cbomp3bitrate.Items.Add("48");
            cbomp3bitrate.Items.Add("56");
            cbomp3bitrate.Items.Add("64");
            cbomp3bitrate.Items.Add("80");
            cbomp3bitrate.Items.Add("96");
            cbomp3bitrate.Items.Add("112");
            cbomp3bitrate.Items.Add("128");
            cbomp3bitrate.Items.Add("144");
            cbomp3bitrate.Items.Add("160");
            cbomp3bitrate.Items.Add("192");
            cbomp3bitrate.Items.Add("224");
            cbomp3bitrate.Items.Add("256");
            cbomp3bitrate.Items.Add("320");
            cbomp3bitrate.SelectedIndex = 15;

            cboChannel.Items.Add("Mono");
            cboChannel.Items.Add("Stereo");
            cboChannel.SelectedIndex = 1;

            cbomp3channel.Items.Add("Mono");
            cbomp3channel.Items.Add("Stereo");
            cbomp3channel.SelectedIndex = 1;

            cbobitpersample.Items.Add("8 bit");
            cbobitpersample.Items.Add("16 bit");
            cbobitpersample.SelectedIndex = 1;


            cbofreq.Items.Add("8000");
            cbofreq.Items.Add("11025");
            cbofreq.Items.Add("22050");
            cbofreq.Items.Add("44100");
            cbofreq.SelectedIndex = 3;


            cbomp3freq.Items.Add("22050");
            cbomp3freq.Items.Add("44100");
            cbomp3freq.SelectedIndex = 1;

            TrackBar1.Minimum = 0;
            TrackBar1.Maximum = 40;
            TrackBar1.Value = 20;


            TrackBar2.Minimum = 0;
            TrackBar2.Maximum = 10;
            TrackBar2.Value = 10;



            for (i = 0; i < axAudioCapture1.GetPlaybackDeviceCount(); i++)
            {
                cboplaybackdevice.Items.Add(axAudioCapture1.GetPlaybackDeviceName((short)i));
            }

            if (cboplaybackdevice.Items.Count > 0)
                cboplaybackdevice.SelectedIndex = 0;


            for (i = 0; i < axAudioCapture1.GetAudioDeviceCount(); i++)
            {
                cboaudiodevice.Items.Add(axAudioCapture1.GetAudioDeviceName((short)i));

            }

            if (cboaudiodevice.Items.Count > 0)
                cboaudiodevice.SelectedIndex = 0;

            for (i = 0; i < axAudioCapture1.GetAudioInputPinCount(); i++)
            {
                cboinputpin.Items.Add(axAudioCapture1.GetAudioInputPinName((short)i));

            }

            if (cboinputpin.Items.Count > 0)
                cboinputpin.SelectedIndex = 0;


            for (i = 0; i < axAudioCapture1.GetWMVProfileCount(); i++)
                cbowma.Items.Add(axAudioCapture1.GetWMVProfileName((short)i));



            if (cbowma.Items.Count > 0)
                cbowma.SelectedIndex = 0;


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 20;
                pnlMain.Width = pnlMain.Width - 20;

                if (PanelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 20;
                pnlMain.Width = pnlMain.Width + 20;

                if (PanelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }
    }
}
