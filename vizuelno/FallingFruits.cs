using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using FallingFruits.Models;

namespace FallingFruits
{

    public partial class FallingFruits : Form
    {
        public List<PictureBox> fruits;
        public List<PictureBox> hearts;
        public Scene scene;
        public UserDBContext db;
        public User user = null;
        public LogIn LogIn;
        public ScoresTable ScoresTable = null;
        public static Random Random { get; set; } = new Random();
        public bool UpdatedDataBase { get; private set; }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public FallingFruits(User user, Form LogIn)
        {

            InitializeComponent();
            Initialize();
            this.LogIn = (LogIn)LogIn;
            db = new UserDBContext();
            this.user = user;
            lblUserName.Text = user.Name;
        }

        private void Initialize()
        {
            InitializeFruits();
            InitializeHearts();
            scene = new Scene(fruits, hearts, this.Height);
            timer1.Start();
            timer2.Start();
            UpdatedDataBase = false;
            this.DoubleBuffered = true;
        }

        public void InitializeHearts()
        {
            hearts = new List<PictureBox>
            {
                heart1,
                heart2,
                heart3
            };
            heart1.Visible = true;
            heart2.Visible = true;
            heart3.Visible = true;
        }

        public void InitializeFruits()
        {
            fruits = new List<PictureBox>
            {
                apple,
                peach,
                prune,
                pear,

                prune,
                pear,
                apple,
                peach
            };
            bomb.Top = -50;
            foreach (PictureBox fruit in fruits)
            {
                fruit.Top = Random.Next(-250, 60);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && basket.Left > 10)
            {
                basket.Left += -10;
            }
            if (e.KeyCode == Keys.Right && basket.Left < 550)
            {
                basket.Left += 10;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.FallDown();
            scene.IsCollected(basket);
            UpdatePoints();
        }
        private void UpdatePoints()
        {
            lblPoints.Text = "Points: " + scene.Points.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bomb.Top += 25;
            if (bomb.Top == 0)
            {
                PlayCautionSound();
            }
            if (bomb.Top > this.Height)
            {
                bomb.Location = new Point(Random.Next(100, 500), -200);
            }
            if (bomb.Bounds.IntersectsWith(basket.Bounds) && bomb.Bottom >= basket.Top)
            {
                scene.Points -= 20;
                PlayBomb();
                if (scene.RemoveHearts())
                {
                    GameOver();
                }
                bomb.Location = new Point(Random.Next(100, 500), -200);
                UpdatePoints();

            }
        }
        private void GameOver()
        {
            StopTimers();
            UpdatePoints();
            DialogResult dgr = MessageBox.Show("Do you want to start again?", "Game Over", MessageBoxButtons.YesNo);
            if (dgr == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                if (scene.Points < 0)
                {
                    scene.Points = 0;
                }
                UpdateDatabase();
                this.Close();
            }
        }

        private void UpdateDatabase()
        {
            user.Score = scene.Points;
            User tmpUser = db.Users.FirstOrDefault(u => u.Name == user.Name);
            if (tmpUser != null)
            {
                if (tmpUser.Score > user.Score)
                {
                    user.Score = tmpUser.Score;
                }
                tmpUser.Score = user.Score;
            }
            else
            {
                db.Users.Add(user);
            }
            db.SaveChanges();
            UpdatedDataBase = true;
        }

        private void ResetGame()
        {
            Initialize();

        }
        private void PlayCautionSound()
        {
            Stream soundStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FallingFruits.Resources.pazi-sega.wav");
            if (soundStream != null)
            {
                using (SoundPlayer sp = new SoundPlayer(soundStream))
                {
                    sp.Play();
                }
            }
        }
        private void PlayBomb()
        {
            Stream soundStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("FallingFruits.Resources.bomba.wav");
            if (soundStream != null)
            {
                using (SoundPlayer sp = new SoundPlayer(soundStream))
                {
                    sp.Play();
                }
            }
        }

        private void FallingFruits_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopTimers();
            if (UpdatedDataBase)
            {
                ScoresTable = new ScoresTable(this);
                this.Hide();
                ScoresTable.ShowDialog();
            }
            LogIn.Close();
        }

        private void StopTimers()
        {
            timer1.Stop();
            timer2.Stop();
        }
    }
}