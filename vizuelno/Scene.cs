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
        public int Height;
        public static Random Random { get; set; } = new Random();
        public Scene(List<PictureBox> fruits, int height)
        {
            this.fruits = fruits;
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


    }
}
