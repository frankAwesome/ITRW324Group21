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

namespace WindowsFormsApp9
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();


            WpfApp5.ApiHelper.InitializeClient();

            var pos = this.PointToScreen(label1.Location);
            pos = pictureBox1.PointToClient(pos);
            label1.Parent = pictureBox1;
            label1.Location = pos;
            label1.BackColor = Color.Transparent;


            var postwo = this.PointToScreen(label2.Location);
            postwo = pictureBox1.PointToClient(postwo);
            label2.Parent = pictureBox1;
            label2.Location = postwo;
            label2.BackColor = Color.Transparent;






            var posfour = this.PointToScreen(bunifuiOSSwitch1.Location);
            posfour = pictureBox1.PointToClient(posfour);
            bunifuiOSSwitch1.Parent = pictureBox1;
            bunifuiOSSwitch1.Location = posfour;
            bunifuiOSSwitch1.BackColor = Color.Transparent;




            pictureBox1.Image = animatedImage;
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuiOSSwitch1_OnValueChange_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Weather_Load(object sender, EventArgs e)
        {
            var weatherInfo = await WeatherProcessor.LoadWeatherInfo();

            var weatherWind = await WeatherProcessor.LoadWeatherWind();

            label1.Text = Convert.ToInt16(weatherInfo.temp).ToString()+"°";

            label3.Text = "Humidity: " + weatherInfo.humidity.ToString();

            label5.Text = "Wind speed: " + weatherWind.Speed.ToString() + "m/s";


        }


        static string pad = @Directory.GetCurrentDirectory() + @"\Images\tornado.gif";
        Bitmap animatedImage = new Bitmap(@pad);
        bool currentlyAnimating = false;




        //This method begins the animation.
        public void AnimateImage()
        {
            if (!currentlyAnimating)
            {
                //Begin the animation only once.
                ImageAnimator.Animate(animatedImage, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }

        private void OnFrameChanged(object o, EventArgs e)
        {
            //Force a call to the Paint event handler.
            this.Invalidate();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            //Begin the animation.
            AnimateImage();
            //Get the next frame ready for rendering
            try
            {
                ImageAnimator.UpdateFrames();
            }
            catch { }
            //Draw the next frame in the animation.
            //e.Graphics.DrawImage(this.animatedImage, new Point(0, 0));


        }
    }
}
