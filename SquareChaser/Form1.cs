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

using System.Windows.Forms;

using System.Media;

namespace SquareChaser
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Rectangle player1 = new Rectangle(375, 200, 10, 10);
        Rectangle player2 = new Rectangle(400, 200, 10, 10);
        Rectangle border = new Rectangle(265, 100, 250, 250);
        Rectangle speedPellet = new Rectangle(0, 0, 5, 5);
        Rectangle pointPellet = new Rectangle(0, 0, 7, 7);


        int direction;

        int player1Score = 0;
        int player2Score = 0;



        int playerSpeed = 4;


        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool downPressed = false;

        bool leftPressed = false;
        bool rightPressed = false;
        bool dPressed = false;
        bool aPressed = false;

        bool gameStarted = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush greenBrush = new SolidBrush(Color.LawnGreen);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        Pen redPen = new Pen(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        public Form1()
        {
            InitializeComponent();

            speedPellet.X = random.Next(270, 500);
            speedPellet.Y = random.Next(100, 340);
            pointPellet.X = random.Next(270, 500);
            pointPellet.Y = random.Next(100, 340);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.Left:
                    leftPressed = true;
                    break;
                case Keys.Right:
                    rightPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.Left:
                    leftPressed = false;
                    break;
                case Keys.Right:
                    rightPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            keyCheck();

            if (player1.IntersectsWith(speedPellet) && playerSpeed < 8)
            {
                playerSpeed++;
                speedPellet.X = random.Next(270, 500);
                speedPellet.Y = random.Next(100, 340);
                SoundPlayer player = new SoundPlayer(Properties.Resources.Robot_blip_Marianne_Gagnon_120342607);

                player.Play();
            }
            if (player2.IntersectsWith(speedPellet) && playerSpeed < 8)
            {
                playerSpeed++;
                speedPellet.X = random.Next(270, 500);
                speedPellet.Y = random.Next(100, 340);
                SoundPlayer player = new SoundPlayer(Properties.Resources.Robot_blip_Marianne_Gagnon_120342607);

                player.Play();
            }



            if (player1.IntersectsWith(pointPellet))
            {
                player1Score++;
                pointPellet.X = random.Next(270, 500);
                pointPellet.Y = random.Next(100, 340);
                p1ScoreLable.Text = $"Player 1 - {player1Score}";
                SoundPlayer player = new SoundPlayer(Properties.Resources. Robot_blip_Marianne_Gagnon_120342607);

                player.Play();
                p1ScoreLable.Refresh();
            }
            if (player2.IntersectsWith(pointPellet))
            {
                player2Score++;
                pointPellet.X = random.Next(270, 500);
                pointPellet.Y = random.Next(100, 340);
                p2ScoreLable.Text = $"Player 2 - {player2Score}";
                SoundPlayer player = new SoundPlayer(Properties.Resources.Robot_blip_Marianne_Gagnon_120342607);

                player.Play();
                p2ScoreLable.Refresh();
            }

            checkWin();



        }

        public void keyCheck()
        {


            if (upPressed == true)
            {
                if (player2.Y > 100)
                {
                    winLabel.Text = "";
                    player2.Y -= playerSpeed;
                }
            }
            if (downPressed == true)
            {
                if (player2.Y < 340)
                {
                    winLabel.Text = "";
                    player2.Y += playerSpeed;
                }
            }
            if (leftPressed == true)
            {
                if (player2.X > 264)
                {
                    winLabel.Text = "";
                    player2.X = player2.X - playerSpeed;
                }
            }
            if (rightPressed == true)
            {
                if (player2.X < 504)
                {
                    winLabel.Text = "";
                    player2.X += playerSpeed;
                }
            }

            if (wPressed == true)
            {
                if (player1.Y > 100)
                {
                    winLabel.Text = "";
                    player1.Y -= playerSpeed;
                }
            }
            if (sPressed == true)
            {
                if (player1.Y < 340)
                {
                    winLabel.Text = "";
                    player1.Y += playerSpeed;
                }
            }
            if (aPressed == true)
            {
                if (player1.X > 264)
                {
                    winLabel.Text = "";
                    player1.X -= playerSpeed;
                }
            }
            if (dPressed == true)
            {
                if (player1.X < 504)
                {
                    winLabel.Text = "";
                    player1.X += playerSpeed;
                }
            }


            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(greenBrush, player2);
            e.Graphics.DrawRectangle(redPen, border);
            e.Graphics.FillRectangle(blackBrush, speedPellet);
            e.Graphics.FillRectangle(yellowBrush, pointPellet);


        }


        public void checkWin()
        {
            if (player1Score == 3)
            {
                winLabel.Text = "Player 1 has won!";
               
                winLabel.Refresh();

                player1Score = player2Score = 0;
                SoundPlayer player = new SoundPlayer(Properties.Resources.Ta_Da_SoundBible_com_1884170640);

                player.Play();
                Thread.Sleep(3000);
                p1ScoreLable.Text = p2ScoreLable.Text = "";
                p1ScoreLable.Refresh();
                p2ScoreLable.Refresh();
                winLabel.Text = "";
                Refresh();
            }
            if (player2Score == 3)
            {
                winLabel.Text = "Player 2 has won!";
              
                winLabel.Refresh();
               
                player1Score = player2Score = 0;
                SoundPlayer player = new SoundPlayer(Properties.Resources.Ta_Da_SoundBible_com_1884170640);

                player.Play();
                Thread.Sleep(3000);
                p1ScoreLable.Text = p2ScoreLable.Text = "";
                p1ScoreLable.Refresh();
                p2ScoreLable.Refresh();
                winLabel.Text = "";
                gameStarted = false;
                Refresh();
            }
            else
            {
                Refresh();
            }
        }
    }
}


