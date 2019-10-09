﻿using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Cloud.Speech.V1;
using Grpc.Auth;

namespace WindowsFormsApp9
{
    public partial class Speech : Form
    {

        private BufferedWaveProvider bwp;

        WaveIn waveIn;
        WaveOut waveOut;
        WaveFileWriter writer;
        WaveFileReader reader;
        string output = "audio.raw";


        public Speech()
        {
            InitializeComponent();

            waveOut = new WaveOut();
            waveIn = new WaveIn();

            waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);
            waveIn.WaveFormat = new NAudio.Wave.WaveFormat(16000, 1);
            bwp = new BufferedWaveProvider(waveIn.WaveFormat);
            bwp.DiscardOnBufferOverflow = true;

            btnRecordVoice.Enabled = true;
            btnSave.Enabled = false;
            btnSpeechInfo.Enabled = false;
        }

        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (NAudio.Wave.WaveIn.DeviceCount < 1)
                {
                    Console.WriteLine("No microphone!");
                    return;
                }

                waveIn.StartRecording();

                btnRecordVoice.Enabled = false;
                btnSave.Enabled = true;
                btnSpeechInfo.Enabled = false;
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            waveIn.StopRecording();

            if (File.Exists("audio.raw"))
                File.Delete("audio.raw");

            writer = new WaveFileWriter(output, waveIn.WaveFormat);

            btnRecordVoice.Enabled = false;
            btnSave.Enabled = false;
            btnSpeechInfo.Enabled = true;

            byte[] buffer = new byte[bwp.BufferLength];
            int offset = 0;
            int count = bwp.BufferLength;

            var read = bwp.Read(buffer, offset, count);
            if (count > 0)
            {
                writer.Write(buffer, offset, read);
            }

            waveIn.Dispose();
            waveIn = null;
            writer.Close();
            writer = null;

            reader = new WaveFileReader("audio.raw"); // (new MemoryStream(bytes));
            waveOut.Init(reader);
            waveOut.PlaybackStopped += new EventHandler<StoppedEventArgs>(waveOut_PlaybackStopped);
            waveOut.Play();
        }

        private void waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            waveOut.Stop();
            reader.Close();
            reader = null;
        }

        private void btnSpeechInfo_Click(object sender, EventArgs e)
        {
          

        }

        private void btnPlayAudio_Click(object sender, EventArgs e)
        {
            if (File.Exists("audio.raw"))
            {
                reader = new WaveFileReader("audio.raw");
                waveOut.Init(reader);
                waveOut.Play();
            }
            else
            {
                MessageBox.Show("No Audio File Found");
            }
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string credential_path = @"C:\Users\Francois\Desktop\NWU\2019\ITRW 324\Google Key\speechproject.json";
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);

            btnRecordVoice.Enabled = true;
            btnSave.Enabled = false;
            btnSpeechInfo.Enabled = false;

            if (File.Exists("audio.raw"))
            {

                var speech = SpeechClient.Create();
                var response = speech.Recognize(new RecognitionConfig()
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                    SampleRateHertz = 16000,
                    LanguageCode = "en",
                }, RecognitionAudio.FromFile("audio.raw"));


                textBox1.Text = "";

                foreach (var result in response.Results)
                {
                    foreach (var alternative in result.Alternatives)
                    {
                        textBox1.Text = textBox1.Text + " " + alternative.Transcript;
                    }
                }

                if (textBox1.Text.Length == 0)
                    textBox1.Text = "No Data ";

            }
            else
            {

                textBox1.Text = "Audio File Missing ";

            }
        }
    }
}
