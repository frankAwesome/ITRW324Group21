using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Louder : Form
    {
        public Louder()
        {
            InitializeComponent();
            pictureBox1.Image = animatedImage;
            t.Start();
        }


        static int iL, iT = 0;

        Thread t = new Thread(new ThreadStart(ThreadProc));

        public static void ThreadProc()
        {

            string path = @Directory.GetCurrentDirectory() + @"\Settings\Location.txt";


            while(true){ 
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

            private void Louder_Load(object sender, EventArgs e)
            {
            this.Left = iL;
            this.Top = iT;

            Thread.Sleep(2000);

            //label1.Visible = false;

            }

        static string pad = @Directory.GetCurrentDirectory() + @"\Images\loadingzGIF.gif";
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            

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
