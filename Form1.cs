using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGameAmixsty
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string firstChoise;
        string secondChoise;
        int treis;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totaltime = 30;
        int countDownTime;
        bool gameOver = false;
        public Form1()
        {
            InitializeComponent();
            LoadPictures();
        }

        private void TimerEvent(object sender, EventArgs e)
        {

            countDownTime--;
            lbltimeleft.Text = "" + countDownTime;
            if (countDownTime < 10 && countDownTime > 1)
            {
                lbltimeleft.ForeColor = Color.Red;
            }
                if (countDownTime < 1)
            {
                GameOver("times up , you loose");
                foreach(PictureBox x in pictures)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("matchgamepics/" + (string)x.Tag + ".png");
                    }
                }
            }
        }


        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void LoadPictures()
        {
            int leftPos = 20;
            int topPos = 20;
            int rows = 0;
            for (int i = 0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 50;
                newPic.Width = 50;
                newPic.BackColor = Color.LightSkyBlue;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 3)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 60;
                }
                if (rows == 3)
                {
                    leftPos = 20;
                    topPos += 60;
                    rows = 0;
                }
            }
            RestartGame();
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            if (firstChoise == null)
            {
                picA = sender as PictureBox;
                if (picA.Tag != null && picA.Image == null)
                {
                    picA.Image = Image.FromFile("matchgamepics/"+(string)picA.Tag + ".png");
                    firstChoise = (string)picA.Tag;

                }
     
            }
            else if (secondChoise == null)
            {
                picB = sender as PictureBox;
                if (picB.Tag != null && picB.Image ==null)
                {
                    picB.Image = Image.FromFile("matchgamepics/" + (string)picB.Tag + ".png");
                    secondChoise = (string)picB.Tag;
                }
            }
            else
            {
                CheckPictures(picA, picB);
            }
        }

        private void RestartGame()
        {
            lbltimeleft.ForeColor = Color.Black;
            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            numbers = randomList;

            for (int i = 0; i < pictures.Count; i++)
            {
                pictures[i].Image = null;
                pictures[i].Tag = numbers[i].ToString();

            }
            treis = 0;
            lblstatus.Text = "Wrong " + treis ;
            lbltimeleft.Text = "" + totaltime;
            gameOver = false;
            gametimer.Start();
            countDownTime = totaltime;


        }


        private void CheckPictures(PictureBox A , PictureBox B)
        {
            if (firstChoise == secondChoise)
            {
                A.Tag = null;
                B.Tag = null;
            }
            else
            {
                treis++;
                lblstatus.Text = "Wrong " + treis ;

            }
            firstChoise = null;
            secondChoise = null;

            foreach(PictureBox pics in pictures.ToList())
            {
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }

            if (pictures.All(o => o.Tag == pictures[0].Tag))
            {
                GameOver("Great Work!");
            }



        }

        private void GameOver(string msg)
        {
            gametimer.Stop();
            gameOver = true;
            MessageBox.Show(msg + " click restart to play again","game msg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
