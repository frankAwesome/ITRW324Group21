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
    public partial class Form3 : Form
    {
        bool bFormLoaded = false;
        string[] files, paths;

        int panelWidth;
        bool Hidden;

        public Form3()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch { }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 10;


                if (PanelSlide.Width >= panelWidth)
                {
                    timer4.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 10;


                if (PanelSlide.Width <= 0)
                {
                    timer4.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //enables multiple files select
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;

                paths = openFileDialog1.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }


            }
        }
    }
}
