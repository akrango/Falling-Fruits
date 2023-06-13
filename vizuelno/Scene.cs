using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingFruits
{
    public class Scene
    {
        public List<PictureBox> fruits;
        public List<PictureBox> hearts;
        public int Height;
        public int Points = 0;
        public static Random Random { get; set; } = new Random();
        public Scene(List<PictureBox> fruits, List<PictureBox> hearts, int height)
        {
            this.fruits = fruits;
            this.hearts = hearts;
            Height = height;
        }
        public void FallDown()
        {
            for (int i = fruits.Count - 1; i >= 0; i--)
            {
                fruits[i].Top += 8;
                if (fruits[i].Top > this.Height)
                {
                    RemoveGenerateFruit(fruits[i]);

                }
            }
        }
        public void IsCollected(PictureBox basket)
        {
            for (int i = fruits.Count - 1; i >= 0; i--)
            {

                if (fruits[i].Bounds.IntersectsWith(basket.Bounds))
                {

                    Points += 10;
                    
                    RemoveGenerateFruit(fruits[i]);
                }

            }


        }

       

        public void RandomizeTop(PictureBox fruit)
        {
            fruit.Top = Random.Next(-250, 60);
        }
        public void RemoveGenerateFruit(PictureBox checkFruit)
        {
            for (int i = fruits.Count - 1; i >= 0; i--)
            {
                if (checkFruit == fruits[i])
                {
                    fruits[i].Location = new Point(Random.Next(100, 500), -60);
                    RandomizeTop(fruits[i]);
                }

            }

        }
        public bool RemoveHearts()
        {
            if (hearts.Count > 0)
            {
                hearts.ElementAt(hearts.Count - 1).Visible = false;
                hearts.RemoveAt(hearts.Count - 1);
                bool AreNotVisible = true;
                foreach (PictureBox heart in hearts)
                {
                    if (heart.Visible)
                    {
                        AreNotVisible = false;
                    }
                }
                if (AreNotVisible)
                {
                    
                    return true;
                }

               
            }
            return false;

        }


    }
}
