using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;


using System.Net.Http;
using VP_10_Base_Project;
using System.Threading;

namespace WindowsFormsApp9
{
    public partial class PostNews : Form
    {
        string sJsonHolder = "";



        public PostNews()
        {
            InitializeComponent();
        }



        private void btnSpeechInfo_Click(object sender, EventArgs e)
        {
            var uriSource = new Uri(textBox5.Text, UriKind.Absolute);
            var uriSourceTwo = new Uri(textBox6.Text, UriKind.Absolute);

            //Convert uri to image
            BitmapImage bitM = new BitmapImage(uriSource);
            var wc = new WebClient();
            Image x = Image.FromStream(wc.OpenRead(uriSource));
            pictureBox5.Image = x;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;


            BitmapImage bitMtwo = new BitmapImage(uriSourceTwo);
            var wctwo = new WebClient();
            Image y = Image.FromStream(wctwo.OpenRead(uriSourceTwo));
            pictureBox2.Image = y;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;



            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;
            textBox7.Text = textBox3.Text;
            label11.Text = textBox8.Text;
            label12.Text = textBox4.Text;



            int iCalMonth = 0;

            if (textBox8.Text == "January")
            {
                iCalMonth = 1;
            }
            if (textBox8.Text == "February")
            {
                iCalMonth = 2;
            }
            if (textBox8.Text == "March")
            {
                iCalMonth = 3;
            }
            if (textBox8.Text == "April")
            {
                iCalMonth = 4;
            }
            if (textBox8.Text == "May")
            {
                iCalMonth = 5;
            }
            if (textBox8.Text == "June")
            {
                iCalMonth = 6;
            }
            if (textBox8.Text == "July")
            {
                iCalMonth = 7;
            }
            if (textBox8.Text == "August")
            {
                iCalMonth = 8;
            }
            if (textBox8.Text == "September")
            {
                iCalMonth = 9;
            }
            if (textBox8.Text == "October")
            {
                iCalMonth = 10;
            }
            if (textBox8.Text == "November")
            {
                iCalMonth = 11;
            }
            if (textBox8.Text == "December")
            {
                iCalMonth = 12;
            }



            string sFirstDay = "";

            sFirstDay = textBox4.Text;

            this.monthCalendar1.SetDate(new DateTime(2019, iCalMonth, Convert.ToInt16(sFirstDay), 0, 0, 0, 0));





            pictureBox7.Visible = false;
            pictureBox6.Visible = false;

            label9.Visible = true;
            label10.Visible = true;
            textBox7.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            monthCalendar1.Visible = true;
            pictureBox4.Visible = true;

            pictureBox5.Visible = true;
            pictureBox2.Visible = true;

            button1.Visible = true;



        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PostNews_Load(object sender, EventArgs e)
        {
            label9.Visible = false;
            label10.Visible = false;
            textBox7.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            monthCalendar1.Visible = false;
            pictureBox4.Visible = false;

            pictureBox6.Visible = false;

            pictureBox7.Visible = false;

            button1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox6.Visible = false;

            pictureBox7.Visible = false;


            sJsonHolder = @"{""title"":"""+ textBox1.Text
                            + @"""" + "," + @"""" +
                            "subtitle" + @"""" + ":" + @"""" + textBox2.Text + @"""" +
                            "," + @"""" + "article" + @"""" + ":" + @"""" + textBox3.Text + @"""" + ","+
                             @"""" + "day" + @"""" + ":" + @"""" + textBox4.Text + @"""" + "," +
                             @"""" + "month" + @"""" + ":" + @"""" + textBox8.Text + @"""" + "," +
                             @"""" + "urlone" + @"""" + ":" + @"""" + textBox5.Text + @"""" + "," +
                             @"""" + "urltwo" + @"""" + ":" + @"""" + textBox6.Text + @"""" + "," +
                             @"""" + "urlthree" + @"""" + ":" + @"""" + textBox5.Text + @"""" +
                            "}"
                            ;

            //MessageBox.Show(sJsonHolder);


            RestClient rClient = new RestClient();
            rClient.endPoint = @"https://localhost:44367/api/values";


                    rClient.httpMethod = httpVerb.POST;
                    rClient.postJSON = sJsonHolder;




            debugOutput("REST Success");

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            debugOutput(strResponse);

            label9.Visible = false;
            label10.Visible = false;
            textBox7.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            monthCalendar1.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox2.Visible = false;

            pictureBox6.Visible = true;

            button1.Visible = false;




            Thread.Sleep(1000);

            pictureBox6.Visible = false;


            pictureBox7.Visible = true;

        }

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                label13.Text = strDebugText + Environment.NewLine;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }
    }
}
