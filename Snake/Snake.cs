using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Snake
{
    class SnakeBody
    {
        public PictureBox head;
        public int xSpeed, ySpeed;
        public List<PictureBox> tail;

        int speed;
        Label scoreLabel;
        Label recordLabel;
        aForm form;
        int oldLocationX;
        int oldLocationY;

        private int _points;
        public int Points
        {
            set
            {
                _points = value;
                scoreLabel.Text = Points.ToString();
            }
            get
            {
                return _points;
            }
        }


        public SnakeBody(Label scoreLabel, Label recordLabel, aForm form, params PictureBox[] tail)
        {
            this.form = form;
            this.scoreLabel = scoreLabel;
            this.scoreLabel.Text = "0";
            this.recordLabel = recordLabel;

            head = tail[0];
            speed = head.Height;
            this.tail = new List<PictureBox> { head };
            for (int i = 1; i < tail.Length; i++)
                this.tail.Add(tail[i]);
        }


        public void Grow()
        {
            tail.Add(new PictureBox());
            tail[tail.Count - 1].Image = tail[tail.Count - 2].Image;
            tail[tail.Count - 1].Size = new Size(20, 20);
            tail[tail.Count - 1].BackColor = Color.Cornsilk;
            tail[tail.Count - 1].Location = new Point(oldLocationX, oldLocationY);
            form.Controls.Add(tail[tail.Count - 1]);
            tail[tail.Count - 1].BringToFront();

            if (tail[tail.Count - 3].Location.X != tail[tail.Count - 2].Location.X)
                tail[tail.Count - 2].Image = Properties.Resources.tailHorizontal;
            else
                tail[tail.Count - 2].Image = Properties.Resources.tailVertical;

            if (!form.timeModeEnabled)
            {
                Points += ((300 - form.aTimer.Interval) / 25);
            }
            else
            {
                form.timeLeft += 2;
            }

        }


        public bool Dieded()
        {
            if (HitWall() && form.bordersEnabled)
            {
                SoundPlayer hitWall = new SoundPlayer(Properties.Resources.HitWall1);
                hitWall.Play();

                DieAndShowBloodstain();
                tail[1].BringToFront();

                return true;
            }
            for (int i = 1; i <= tail.Count - 1; i++)
            {
                if (head.Location == tail[i].Location)
                {
                    SoundPlayer cannibalism = new SoundPlayer(Properties.Resources.EatYourself);
                    cannibalism.Play();

                    DieAndShowBloodstain();

                    for (int j = 1; j <= tail.Count - 1; j++)
                        if (j != i)
                            tail[j].BringToFront();
                    return true;
                }
            }
            return false;
        }


        public void DieAndShowBloodstain()
        {
            xSpeed = 0;
            ySpeed = 0;

            PictureBox bloodStain = new PictureBox
            {
                Image = Properties.Resources.dieded
            };
            bloodStain.Size = bloodStain.Image.Size;
            bloodStain.Location = new Point(head.Location.X - 5, head.Location.Y - 5);
            bloodStain.BackColor = Color.Cornsilk;
            form.Controls.Remove(head);

            form.Controls.Add(bloodStain);
            bloodStain.BringToFront();
        }


        private bool HitWall()
        {
            if (head.Top < form.aBox.Top || head.Bottom > form.aBox.Bottom
                || head.Left < form.aBox.Left || head.Right > form.aBox.Right)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        internal void DoMove()
        {
            oldLocationX = tail[tail.Count - 1].Location.X;     //lokalizacje wykorzystywane przy rosnieciu snake'a
            oldLocationY = tail[tail.Count - 1].Location.Y;

            tail[tail.Count - 1].Location = tail[tail.Count - 2].Location;
            form.Controls.Remove(tail[tail.Count - 2]);
            tail.RemoveAt(tail.Count - 2);


            int oldHeadLocationX = head.Location.X;
            int oldHeadLocationY = head.Location.Y;

            head.Location = new Point(head.Location.X + xSpeed, head.Location.Y + ySpeed);

            tail.Insert(1,new PictureBox());

            if (xSpeed == 0)
                tail[1].Image = Properties.Resources.tailVertical;
            else
                tail[1].Image = Properties.Resources.tailHorizontal;

            tail[1].Size = new Size(20, 20);
            tail[1].BackColor = Color.Cornsilk;
            tail[1].Location = new Point(oldHeadLocationX, oldHeadLocationY);
            form.Controls.Add(tail[1]);
            tail[1].BringToFront();


            if (tail[tail.Count - 1].Location.X == (tail[tail.Count - 2].Location.X + 20) && tail[tail.Count - 1].Image != Properties.Resources.endLeft)
                tail[tail.Count - 1].Image = Properties.Resources.endLeft;

            else if (tail[tail.Count - 1].Location.X == (tail[tail.Count - 2].Location.X - 20) && tail[tail.Count - 1].Image != Properties.Resources.endRight)
                tail[tail.Count - 1].Image = Properties.Resources.endRight;

            if (tail[tail.Count - 1].Location.Y == (tail[tail.Count - 2].Location.Y + 20) && tail[tail.Count - 1].Image != Properties.Resources.endUp)
                tail[tail.Count - 1].Image = Properties.Resources.endUp;

            else if (tail[tail.Count - 1].Location.Y == (tail[tail.Count - 2].Location.Y - 20) && tail[tail.Count - 1].Image != Properties.Resources.endDown)
                tail[tail.Count - 1].Image = Properties.Resources.endDown;

            
            if (!form.bordersEnabled)
            {

                if (head.Top < form.aBox.Top)
                {
                    head.Location = new Point(head.Location.X, form.aBox.Bottom - 25);
                }
                else if (head.Bottom > form.aBox.Bottom)
                {
                    head.Location = new Point(head.Location.X, 12);
                }
                else if (head.Left < form.aBox.Left)
                {
                    head.Location = new Point(form.aBox.Right - 25, head.Location.Y);
                }
                else if (head.Right > form.aBox.Right)
                {
                    head.Location = new Point(12, head.Location.Y);
                }
            }
        }


        public void ChangeDirection(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (ySpeed == 0)
                    {
                        ySpeed = -speed;
                        xSpeed = 0;
                        head.Image = Snake.Properties.Resources.headUp;
                    }
                    break;
                case Keys.Down:
                    if (ySpeed == 0)
                    {
                        ySpeed = speed;
                        xSpeed = 0;
                        head.Image = Snake.Properties.Resources.headDown;
                    }
                    break;
                case Keys.Left:
                    if (xSpeed == 0)
                    {
                        xSpeed = -speed;
                        ySpeed = 0;
                        head.Image = Snake.Properties.Resources.headLeft;
                    }
                    break;
                case Keys.Right:
                    if (xSpeed == 0)
                    {
                        xSpeed = speed;
                        ySpeed = 0;
                        head.Image = Snake.Properties.Resources.headRight;
                    }
                    break;
            }
        }
    }
}
