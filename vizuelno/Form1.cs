using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingFruits
{

    public partial class Form1 : Form
    {
        public List<PictureBox> fruits;
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
            scene = new Scene(fruits,this.Height);
            timer1.Start();
            this.DoubleBuffered = true;
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
        }


    }
}