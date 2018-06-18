using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Snake
{
    class Food
    {
        public Rectangle foodLocator;
        public Rectangle superFoodLocator;
        public PictureBox picture;
        Image[] dishes = {  Properties.Resources.apple,     Properties.Resources.banana,
                            Properties.Resources.grapes,    Properties.Resources.orange };

        Random rand;
        int x, y;
        private bool remakeFood;
        aForm form;
        

        public Food(aForm form, PictureBox super, PictureBox pic, SnakeBody snake)
        {
            this.form = form;
            picture = pic;
            rand = new Random();
            picture.Image = dishes[rand.Next(dishes.Count())];
            picture.BringToFront();


            do
            {
                remakeFood = false;
                x = rand.Next(26);
                y = rand.Next(26);
                picture.Location = new Point(x * 20 + 10, y * 20 + 10);
                foodLocator = new Rectangle(picture.Location.X + picture.Width / 2, picture.Location.Y + picture.Height / 2, 2, 2);
                for (int i = 0; i < snake.tail.Count - 1; i++)
                {
                    if (snake.tail[i].Bounds.IntersectsWith(foodLocator))
                    {
                        remakeFood = true;
                        break;
                    }
                }
            } while (remakeFood);

            if (rand.Next(4) == 1)
            {
                MakeSuperFood(super, snake);
            }
        }
        private void MakeSuperFood(PictureBox super, SnakeBody snake)
        {
            bool remake;
            do
            {
                remake = false;
                x = rand.Next(26);
                y = rand.Next(26);
                super.Location = new Point(x * 20 + 10, y * 20 + 10);
                form.Controls.Add(super);
                super.BringToFront();
                super.Visible = true;
                superFoodLocator = new Rectangle(super.Location.X + super.Width / 2, super.Location.Y + super.Height / 2, 2, 2);
                for (int i = 0; i < snake.tail.Count - 1; i++)
                {
                    if (snake.tail[i].Bounds.IntersectsWith(superFoodLocator))
                    {
                        remake = true;
                        break;
                    }
                }
            } while (remake);
        }
    }
}
