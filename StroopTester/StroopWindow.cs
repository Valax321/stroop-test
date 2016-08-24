using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StroopTester
{
    public partial class StroopWindow : Form
    {
        enum GameState
        {
            Menu,
            Play,
            Score
        }

        int startTimer = 3;
        int RoundPos = 0;
        int gameTime = 0;

        struct StroopReaction
        {
            public int SpeedInMilliseconds;
            public Color RealColor;
            public Color ColorOfWord;
            public bool ChoseCorrectly;

            public StroopReaction(int time, Color rc, Color color, bool correct)
            {
                SpeedInMilliseconds = time;
                ChoseCorrectly = correct;
                RealColor = rc;
                ColorOfWord = color;
            }

        }

        struct StroopColor
        {
            public Color DisplayColor;
            public string ColorDisplayName;

            public StroopColor(Color c, string s)
            {
                DisplayColor = c;
                ColorDisplayName = s;
            }
        }

        StroopColor strc(Color c, string s)
        {
            return new StroopColor(c, s);
        }

        List<StroopReaction> ListOfReactions = new List<StroopReaction>();

        List<StroopColor> ListOfColors = new List<StroopColor>();

        GameState CurrentState = GameState.Menu;

        public StroopWindow()
        {
            InitializeComponent();
        }

        public void InitControlGroup()
        {
            ListOfColors.Add(strc(Color.Blue, "Blue"));
            ListOfColors.Add(strc(Color.Red, "Red"));
            ListOfColors.Add(strc(Color.Green, "Green"));
            ListOfColors.Add(strc(Color.Blue, "Blue"));
            ListOfColors.Add(strc(Color.Red, "Red"));
            ListOfColors.Add(strc(Color.Green, "Green"));
        }

        public void InitGroup1()
        {
            ListOfColors.Add(strc(Color.Blue, "Blue"));
            ListOfColors.Add(strc(Color.Blue, "Yellow"));
            ListOfColors.Add(strc(Color.Orange, "Blue"));
            ListOfColors.Add(strc(Color.Blue, "Indigo"));
            ListOfColors.Add(strc(Color.Purple, "Black"));
            ListOfColors.Add(strc(Color.Blue, "Orange"));
        }

        public void InitGroup2()
        {
            ListOfColors.Add(strc(Color.Green, "Green"));
            ListOfColors.Add(strc(Color.Green, "Yellow"));
            ListOfColors.Add(strc(Color.Orange, "Green"));
            ListOfColors.Add(strc(Color.Green, "Indigo"));
            ListOfColors.Add(strc(Color.Purple, "Black"));
            ListOfColors.Add(strc(Color.Green, "Orange"));
        }

        public void InitGroup3()
        {
            ListOfColors.Add(strc(Color.Red, "Red"));
            ListOfColors.Add(strc(Color.Red, "Yellow"));
            ListOfColors.Add(strc(Color.Orange, "Red"));
            ListOfColors.Add(strc(Color.Red, "Indigo"));
            ListOfColors.Add(strc(Color.Purple, "Black"));
            ListOfColors.Add(strc(Color.Red, "Orange"));
        }

        void InitPlay()
        {
            panelPlay.Visible = false;
            lblCountDownTimer.Visible = true;
            timerWaitStart.Start();
        }

        void DisplayScores()
        {
            panelPlay.Visible = false;
            foreach (StroopReaction sr in ListOfReactions)
            {
                textBoxResults.AppendText(string.Format("Test {0}:\n\tCorrect: {1}\n\tTime: {2}ms\n", ListOfReactions.IndexOf(sr) + 1, sr.ChoseCorrectly, sr.SpeedInMilliseconds));
            }
            panelScores.Visible = true;
        }

        void StartRound(StroopColor roundcolor)
        {
            labelTestCount.Text = string.Format("{0} of {1}", RoundPos + 1, ListOfColors.Count);
            lblCountDownTimer.Visible = false;
            labelWordRead.ForeColor = roundcolor.DisplayColor;
            labelWordRead.Text = roundcolor.ColorDisplayName;
            panelPlay.Visible = true;
            timerGameTime.Start();
        }

        void CheckColor(Color pressed)
        {
            //MessageBox.Show(string.Format("Color choice: {0}\nCorrect Color: {1}", pressed.ToString(), ListOfColors[RoundPos].DisplayColor.ToString()));
            timerGameTime.Stop();
            ListOfReactions.Add(new StroopReaction(gameTime, ListOfColors[RoundPos].DisplayColor, pressed, ListOfColors[RoundPos].DisplayColor == pressed));
            gameTime = 0;
            RoundPos++;
            if (RoundPos > 5)
            {
                DisplayScores();
            }
            else
            {
                InitPlay();
            }            
        }

        private void lblSpacebarHint_Click(object sender, EventArgs e)
        {
            if (CurrentState == GameState.Menu)
            {
                CurrentState = GameState.Play;
                if (radioButtonControl.Checked)
                {
                    InitControlGroup();
                }
                else if (radioButtonGroup1.Checked)
                {
                    InitGroup1();
                }
                else if (radioButtonGroup2.Checked)
                {
                    InitGroup2();
                }
                else if (radioButtonGroup3.Checked)
                {
                    InitGroup3();
                }
                panelIntro.Visible = false;
                InitPlay();
            }
        }

        private void timerWaitStart_Tick(object sender, EventArgs e)
        {
            if (startTimer <= 0)
            {
                timerWaitStart.Stop();
                startTimer = 3;
                StartRound(ListOfColors[RoundPos]);
            }

            startTimer--;
            lblCountDownTimer.Text = startTimer.ToString();
        }

        private void timerGameTime_Tick(object sender, EventArgs e)
        {
            gameTime++;
        }

        private void buttonOptRed_Click(object sender, EventArgs e)
        {
            CheckColor(buttonOptRed.BackColor);
        }

        private void buttonOptBlue_Click(object sender, EventArgs e)
        {
            CheckColor(buttonOptBlue.BackColor);
        }

        private void buttonOptGreen_Click(object sender, EventArgs e)
        {
            CheckColor(buttonOptGreen.BackColor);
        }

        private void buttonOptOrange_Click(object sender, EventArgs e)
        {
            CheckColor(buttonOptOrange.BackColor);
        }

        private void buttonOptPurple_Click(object sender, EventArgs e)
        {
            CheckColor(buttonOptPurple.BackColor);
        }
    }
}
