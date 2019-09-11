using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfApp5;
using System.Windows.Media.Imaging;
using System.Net;
using System.IO;
using System.Threading;
using LoadingIndicator.WinForms;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public int maxNumber, currentNumber = 1;

        public string currentHeader = "";


        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();



        public Form1()
        {
            InitializeComponent();

            this.Visible = false;

            WpfApp5.ApiHelper.InitializeClient();
            button2.Visible = false;

            //pictureBox5.Visible = false;

            Thread ATM2 = new Thread(new ThreadStart(ThreadProcOne));

            ATM2.Start();

            t.Start();
        }


        static int iL, iT = 0;

        Thread t = new Thread(new ThreadStart(ThreadProc));

        public static void ThreadProc()
        {

            string path = @Directory.GetCurrentDirectory() + @"\Settings\Location.txt";


            while (true)
            {
                try
                {

                    using (StreamReader sr = new StreamReader(path))
                    {




                        iL = Convert.ToInt16(sr.ReadLine());
                        iT = Convert.ToInt16(sr.ReadLine());


                    }
                }
                catch
                {

                }

                Thread.Sleep(200);
            }
        }







        public void ThreadProcOne()
        {
            var frm = new Louder();
            frm.ShowDialog();

            frm.MinimizeBox = false;
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label7.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            monthCalendar1.Visible = false;



            if (currentNumber < maxNumber)
            {
                currentNumber += 1;

                button1.Visible = true;

                await LoadImage(currentNumber);
            }

            if (currentNumber == maxNumber)
            {
                button2.Visible = false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label7.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            monthCalendar1.Visible = false;



            if (currentNumber > 1)
            {
                currentNumber -= 1;

                button2.Visible = true;

                await LoadImage(currentNumber);

                if (currentNumber == 1)
                {
                    button1.Visible = false;
                }

            }
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //this.Visible = false;

            await LoadImage();

            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            Thread.Sleep(2000);



            this.WindowState = FormWindowState.Normal;


            //pictureBox5.Visible = false;

            this.Visible = true;

            this.WindowState = FormWindowState.Normal;
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();


            this.Left = iL;
            this.Top = iT;

        }



        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            Application.Exit();

            //this.BackColor = System.Drawing.Color.Green;
            //panel1.BackColor = Color.Red;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        public async Task LoadImage(int imageNumber = 0)
            {

                var comic = await CommicProcessor.LoadCommic(imageNumber);
                if (imageNumber == 0)
                {
                    maxNumber = comic.Id;
                }

                currentNumber = comic.Id;
                currentHeader = comic.Title;
                label1.Text = currentHeader;
                label2.Text = comic.Subtitle;

                textBox1.Text = comic.Article;

                label5.Text = comic.Day;

                label7.Text = comic.Month;


                var uriSource = new Uri(comic.Urlone, UriKind.Absolute);
                var uriSourceTwo = new Uri(comic.Urltwo, UriKind.Absolute);





                //Convert uri to image
                BitmapImage bitM = new BitmapImage(uriSource);
                var wc = new WebClient();
                Image x = Image.FromStream(wc.OpenRead(uriSource));
                pictureBox1.Image = x;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


                BitmapImage bitMtwo = new BitmapImage(uriSourceTwo);
                var wctwo = new WebClient();
                Image y = Image.FromStream(wctwo.OpenRead(uriSourceTwo));
                pictureBox2.Image = y;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;



                int iCalMonth = 0;

                if (comic.Month == "January")
                {
                    iCalMonth = 1;
                }
                if (comic.Month == "February")
                {
                    iCalMonth = 2;
                }
                if (comic.Month == "March")
                {
                    iCalMonth = 3;
                }
                if (comic.Month == "April")
                {
                    iCalMonth = 4;
                }
                if (comic.Month == "May")
                {
                    iCalMonth = 5;
                }
                if (comic.Month == "June")
                {
                    iCalMonth = 6;
                }
                if (comic.Month == "July")
                {
                    iCalMonth = 7;
                }
                if (comic.Month == "August")
                {
                    iCalMonth = 8;
                }
                if (comic.Month == "September")
                {
                    iCalMonth = 9;
                }
                if (comic.Month == "October")
                {
                    iCalMonth = 10;
                }
                if (comic.Month == "November")
                {
                    iCalMonth = 11;
                }
                if (comic.Month == "December")
                {
                    iCalMonth = 12;
                }



                string sFirstDay = "";

                sFirstDay = comic.Day;

                this.monthCalendar1.SetDate(new DateTime(2019, iCalMonth, Convert.ToInt16(sFirstDay), 0, 0, 0, 0));

                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;





                label1.Visible = true;
                label2.Visible = true;
                label7.Visible = true;
                label5.Visible = true;
                textBox1.Visible = true;
                monthCalendar1.Visible = true;


            Thread.Sleep(200);

            this.WindowState = FormWindowState.Normal;
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            int iLeft = this.Left;
            int iTop = this.Top;

            string path = @Directory.GetCurrentDirectory() + @"\Settings\Location.txt";


            /*
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(iLeft);
                    tw.WriteLine(iTop);
                }

            }
            else if (File.Exists(path))
            {
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(iLeft);
                    tw.WriteLine(iTop);
                }
            }
            */

        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            { 
            t1.Stop();

        }//this stops the timer if the form is completely displayed
            else
                Opacity += 0.01;
        }



    }
}


