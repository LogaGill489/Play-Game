using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Play_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //changes colour upon hover
        private void startButton_MouseHover(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Green;
        }

        private void startButton_MouseLeave(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Black;
        }


        //main code for when button is pressed
        private void startButton_Click(object sender, EventArgs e)
        {
            //setting my sounds as variables to be used in the .Play commands
            SoundPlayer sound1 = new SoundPlayer(Properties.Resources.beepNoise);
            SoundPlayer sound2 = new SoundPlayer(Properties.Resources.arcadeCoins);
            sound1.Play();
            //removes Button and enables countdown timer
            countdownText.Visible = true;
            startButton.Visible = false;
            pressStart.Visible = false;
            Refresh();
            Thread.Sleep(1000);

            //changes countdown timer, repeats countdown sound
            countdownText.Text = "The Game Will Start in: 2";
            sound1.Play();
            Refresh();
            Thread.Sleep(1000);

            countdownText.Text = "The Game Will Start in: 1";
            sound1.Play();
            Refresh();
            Thread.Sleep(1000);

            //plays arcade sound and changes the background to a set arcade styled background
            sound2.Play();
            Form1.ActiveForm.BackgroundImage = Properties.Resources.arcadeBackground;
            countdownText.Visible = false;
            startText.Visible = true;
        }
    }
}
