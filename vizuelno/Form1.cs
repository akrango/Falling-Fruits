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

namespace FallingFruits
{

    public partial class Form1 : Form
    {
        public List<PictureBox> fruits;
        public List<PictureBox> hearts;
        public Scene scene;
        public static Random Random { get; set; } = new Random();
        public Form1()
        {
            InitializeComponent();
            Initialize();

        }

        private void Initialize()
        {
            InitializeFruits();
            InitializeHearts();
            scene = new Scene(fruits, hearts, this.Height);
            timer1.Start();
            timer2.Start();
            this.DoubleBuffered = true;
        }

        public void InitializeHearts()
        {
            hearts = new List<PictureBox>();
            hearts.Add(heart1);
            hearts.Add(heart2);
            hearts.Add(heart3);
            heart1.Visible = true;
            heart2.Visible = true;
            heart3.Visible = true;
        }

        public void InitializeFruits()
        {
            fruits = new List<PictureBox>();
            fruits.Add(apple);
            fruits.Add(peach);
            fruits.Add(prune);
            fruits.Add(pear);

            fruits.Add(prune);
            fruits.Add(pear);
            fruits.Add(apple);
            fruits.Add(peach);
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
            if (bomb.Top > this.Height)
            {
                bomb.Location = new Point(Random.Next(100, 500), -60);
            }
            if (bomb.Bounds.IntersectsWith(basket.Bounds))
            {
                scene.Points -= 20;
                if (scene.RemoveHearts())
                {
                    GameOver();
                }
                bomb.Location = new Point(Random.Next(100, 500), -60);
                UpdatePoints();

            }
        }
        private void GameOver()
        {
            timer1.Stop();
            timer2.Stop();
           
            UpdatePoints();
            DialogResult dgr = MessageBox.Show("Do you want to start again?", "Game Over", MessageBoxButtons.YesNo);
            if (dgr == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                this.Close();
            }
        }

        private void ResetGame()
        {
            Initialize();

        }
    }
}