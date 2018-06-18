using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Media;


// ew dzwiek


namespace Snake
{
    public partial class aForm : Form
    {
        public bool bordersEnabled;
        public int timeTick;
        bool _timeModeEnabled;
        public bool timeModeEnabled
        {
            set
            {
                    aTimeLeftLabel.Visible = value;
                    aTimeLeft.Enabled = value;
                    aTimeLeft.Visible = value;
                    _timeModeEnabled = value;

            }
            get
            {
                return _timeModeEnabled;
            }
        }
        SnakeBody snake;
        Food food;
        bool directionChanged;
        int _timeLeft;
        public int timeLeft
        {
            set
            {
                _timeLeft = value;
                aTimeLeft.Text = string.Format("{0}:{1:d2}", _timeLeft / 60, _timeLeft % 60);
            }
            get
            {
                return _timeLeft;
            }
        }

        int foodTime;
        

        public aForm()
        {
            _timeLeft = 30;
            InitializeComponent();
            snake = new SnakeBody(aScoreLabel, aRecordLabel, this, aSnakeHead, aSegment1, aSegment2, aSegment3, aSegment4);
            food = new Food(this, aSuperFood ,aFood, snake);
            bordersEnabled = true;
            timeModeEnabled = false;
            timeLeft = 10;

            if (!File.Exists("score.ini"))
            {
                using (StreamWriter writer = new StreamWriter("score.ini"))
                {
                    writer.Write("0\n0\n0\n0");
                    writer.Close();
                }
            }

            CheckForRecord();
        }


        private void aForm_Load(object sender, EventArgs e)
        {
            InitializeSnake();
            aBox.Size = new Size(549, 549);
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            if (snake.Dieded())
            {
                aTimer.Stop();
                aTimeModeTimer.Enabled = false;
                EnableMenu(true);
            }
            else
            {
                snake.DoMove();

                //eat
                if (snake.head.Bounds.IntersectsWith(food.foodLocator))
                {
                    SoundPlayer eat = new SoundPlayer(Properties.Resources.Eat1);
                    eat.Play();
                    food = new Food(this, aSuperFood, aFood, snake);
                    snake.Grow();
                }

                if(Controls.Contains(aSuperFood))
                {
                    foodTime++;
                }
                if(foodTime >= 30)
                {
                    foodTime = 0;
                    Controls.Remove(aSuperFood);
                    food.superFoodLocator = new Rectangle();
                }

                if (snake.head.Bounds.IntersectsWith(food.superFoodLocator))
                {
                    SoundPlayer superEat = new SoundPlayer(Properties.Resources.Eat2);
                    superEat.Play();

                    Controls.Remove(aSuperFood);
                    food.superFoodLocator = new Rectangle();
                    foodTime = 0;
                    snake.Grow();
                    snake.Grow();
                    snake.Grow();
                }
            }
            directionChanged = false;
        }


        private void aForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                aQuitButton.Enabled = true;
                aTimer.Enabled = false;
                aTimeModeTimer.Enabled = false;
            }

            if (!directionChanged)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                {
                    if (timeModeEnabled) aTimeModeTimer.Enabled = true;
                    EnableMenu(false);
                    if(aTimer.Enabled == false)
                    {
                        SoundPlayer start = new SoundPlayer(Properties.Resources.start);
                        start.Play();
                    }

                    aTimer.Enabled = true;


                    aFood.Visible = true;
                    snake.ChangeDirection(e);
                    directionChanged = true;
                }
            }
        }
    

        private void EnableMenu(bool mode)
        {
            aModeLabel.Enabled = mode;
            aRestartButton.Visible = mode;
            aBorderLabel.Enabled = mode;
            aQuitButton.Enabled = mode;
            aRestartButton.Enabled = mode;
            aSpeedLabel.Enabled = mode;
            aPauseLabel.Visible = !mode;

            if(timeModeEnabled)
            {
            aAddSpeed.Enabled = false;
            aSubtractSpeed.Enabled = false;
            }
            else
            {
                aAddSpeed.Enabled = mode;
                aSubtractSpeed.Enabled = mode;
            }

        }


        private void aRestartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer replay = new SoundPlayer(Properties.Resources.Replay);
            replay.Play();
            CheckForRecord();
            for (int i = snake.tail.Count - 1; i > 0; i--)
                Controls.Remove(snake.tail[i]);

            InitializeSnake();

            snake = new SnakeBody(aScoreLabel, aRecordLabel, this, aSnakeHead, aSegment1, aSegment2, aSegment3, aSegment4);
            food = new Food(this, aSuperFood ,aFood, snake);
            food.picture.Visible = false;
            aTimer.Enabled = false;
            timeLeft = 10;
            timeTick = 0;

        }


        private void InitializeSnake()
        {
            Controls.Add(aSnakeHead);
            Controls.Add(aSegment1);
            Controls.Add(aSegment2);
            Controls.Add(aSegment3);
            Controls.Add(aSegment4);
            aSnakeHead.Image = Properties.Resources.headUp;
            aSnakeHead.Location = new System.Drawing.Point(252, 232);
            aSnakeHead.BringToFront();

            aSegment1.Image = Properties.Resources.tailVertical;
            aSegment1.Location = new Point(252, 252);
            aSegment1.BringToFront();

            aSegment2.Image = Properties.Resources.tailVertical;
            aSegment2.Location = new System.Drawing.Point(252, 272);
            aSegment2.BringToFront();

            aSegment3.Image = Properties.Resources.tailVertical;
            aSegment3.Location = new Point(252, 292);
            aSegment3.BringToFront();

            aSegment4.Image = Properties.Resources.endUp;
            aSegment4.Location = new Point(252, 312);
            aSegment4.BringToFront();
        }


        private void aQuitButton_Click(object sender, EventArgs e)
        {
            CheckForRecord();
            Application.Exit();
        }


        private void MouseEnters(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Brown;
        }


        private void MouseLeaves(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Black;
        }


        private void aBorderLabel_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text == "Borders: NO")
            {
                bordersEnabled = true;
                label.Text = "Borders: YES";
            }
            else
            {
                bordersEnabled = false;
                label.Text = "Borders: NO";
            }
            CheckForRecord();
        }


        private void aAddSpeed_Click(object sender, EventArgs e)
        {
            if (aTimer.Interval > 50)
            {
                aTimer.Interval -= 25;
                aSpeedLabel.Text = string.Format("Speed: {0}", (300 - aTimer.Interval) / 25);
            }
        }


        private void aSubtractSpeed_Click(object sender, EventArgs e)
        {
            if (aTimer.Interval < 275)
            {
                aTimer.Interval += 25;
                aSpeedLabel.Text = string.Format("Speed: {0}", (300 - aTimer.Interval) / 25);
            }
        }


        private void aModeLabel_Click(object sender, EventArgs e)
        {
            CheckForRecord();
            Label label = (Label)sender;
            
            if(label.Text == "Mode: Classic")
            {
                label.Text = "Mode: Time Run";
                timeModeEnabled = true;
                aTimer.Interval = 125;
                aSpeedLabel.Text = string.Format("Speed: {0}", (300 - aTimer.Interval) / 25);
                aSubtractSpeed.Enabled = false;
                aAddSpeed.Enabled = false;
                aScoreLabel.Text = "0:00";
                timeTick = 0;
                timeLeft = 10;
                
            }
            else
            {
                label.Text = "Mode: Classic";
                timeModeEnabled = false;
                aTimer.Interval = 175;
                aSpeedLabel.Text = string.Format("Speed: {0}", (300 - aTimer.Interval) / 25);
                aSubtractSpeed.Enabled = true;
                aAddSpeed.Enabled = true;
                aScoreLabel.Text = "0";
            }
            CheckForRecord();
        }


        private void aTimeModeTimer_Tick(object sender, EventArgs e)
        { 
            timeTick++;
            aScoreLabel.Text = String.Format("{0}:{1:d2}", timeTick / 60, timeTick % 60);
            timeLeft--;
            Thread thread = new Thread(CheckTime);
            thread.Start();


            if (timeLeft <= 0)
            {
                aTimer.Enabled = false;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.TimeOut);
                sound.Play();

                snake.DieAndShowBloodstain();

                for (int j = 1; j <= snake.tail.Count - 1; j++)
                    snake.tail[j].BringToFront();

                aTimeModeTimer.Enabled = false;

                EnableMenu(true);
            }
        }

        private void CheckTime()
        {
            if(timeLeft <=5 && timeLeft > 0)
                Console.Beep(1200 - timeLeft*50, 300);
        }

        private void CheckForRecord()
        {
            string[] records = File.ReadAllLines("score.ini");

            if (bordersEnabled && !timeModeEnabled)        // granice classic
            {
                if (int.Parse(aScoreLabel.Text) > int.Parse(records[0]))
                {
                    records[0] = aScoreLabel.Text;
                }
                    aRecordLabel.Text = records[0];
            }

            else if (!bordersEnabled && !timeModeEnabled) // bez granic classic
            {
                if (int.Parse(aScoreLabel.Text) > int.Parse(records[1]))
                {
                    records[1] = aScoreLabel.Text;
                }
                    aRecordLabel.Text = records[1];
            }

            else if (bordersEnabled && timeModeEnabled)   // granice time run
            {
                if (timeTick > int.Parse(records[2]))
                {
                    int x = timeTick;
                    records[2] = x.ToString();
                }
                    aRecordLabel.Text = string.Format("{0}:{1:d2}", int.Parse(records[2])/60,int.Parse(records[2])%60);
            }
            else if (!bordersEnabled && timeModeEnabled)  // bez granic time run
            {
                if (timeTick > int.Parse(records[3]))
                {

                    records[3] = timeTick.ToString();
                }
                    aRecordLabel.Text = string.Format("{0}:{1:d2}", int.Parse(records[3]) / 60, int.Parse(records[3]) % 60);
            }

            File.WriteAllLines("score.ini", records);
        }
    }
}
