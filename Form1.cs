using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPomodoroApp
{
    public partial class PomodoroApp : Form
    {



        int hrs = 0, mins = 25, secs = 0;

        bool isBreakSession = false;
        short finishedSessions = 1;

        int timeStudiedInMins = 0;
        int timeStudiedInHrs = 0;

        public void updateTimeStudied()
        { 
            getTimeStudied();

            lblTimeStudied.Text=timeStudiedInHrs.ToString()+"hr(s)" + " "
                +timeStudiedInMins.ToString() + "mins";
        }

        public void getTimeStudied()
        {
            timeStudiedInMins += Convert.ToInt32(numericUpDownMins.Value)  ;
            timeStudiedInHrs += Convert.ToInt32(numericUpDownHrs.Value);
            if (timeStudiedInMins >= 60)
            {
                timeStudiedInHrs++;

                timeStudiedInMins -= 60;
                
            }
        }

        public void startTimer()
        {
            if (hrs == 0 && mins == 0 && secs == 0)
            {
                if (isBreakSession)
                    endBreakSession();
                else
                    endPomodoroSession();
            }

            if (secs > 0)
                secs--;

            if (secs == 0 && mins == 0 && hrs > 0)
            {
                mins = 59;
                secs = 59;
                hrs--;
            }

            if (secs == 0 && mins > 0)
            {
                secs = 59;
                mins--;
            }

            updateTimerValue();
        }

        public void startBreakSession()
        {

            hrs = Convert.ToInt32(numBreakHrs.Value);
            mins = Convert.ToInt32(numBreakMins.Value);
            secs = Convert.ToInt32(numBreakSecs.Value);
            
            updateTimerValue();

            timer2.Enabled = true;

            startTimer();
        }

        public void updateTimerValue()
        { 

            lblTimer.Text = (hrs.ToString("00") + ":" + mins.ToString("00") + ":" + secs.ToString("00"));
        }

        public void endPomodoroSession()
        {
            if (isBreakSession == false)
            {
                timer2.Enabled = false;
                isBreakSession = true;

                this.BackColor= Color.LightSeaGreen;

                hrs = Convert.ToInt32(numBreakHrs.Value);
                mins = Convert.ToInt32(numBreakMins.Value);
                secs = Convert.ToInt32(numBreakSecs.Value);

                updateTimerValue();

                MessageBox.Show("Time for a break!", "Time's up!", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                groupBox1.Enabled = true;
                groupBoxBreak.Enabled = true;

                updateTimeStudied();
            }

        }

        public void endBreakSession()
        {

            if (isBreakSession)
            {
                timer2.Enabled = false;
                isBreakSession = false;

                this.BackColor= Color.DarkSalmon;

                hrs = Convert.ToInt32(numericUpDownHrs.Value);
                mins = Convert.ToInt32(numericUpDownMins.Value);
                secs = Convert.ToInt32(numericUpDownSecs.Value);

                updateTimerValue();

                MessageBox.Show("Time to study!", "Break's over!", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);

                groupBox1.Enabled = true;
                groupBoxBreak.Enabled = true;
            }
            finishedSessions++;
            lblSessionsCounter.Text=finishedSessions.ToString();
        }

        public PomodoroApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnHideSettings.Visible = false;
            groupBox1.Visible = false;
            groupBoxBreak.Visible = false;
            
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            startTimer();

        }

        private void btnEndPeriod_Click(object sender, EventArgs e)
        {
            if (isBreakSession)
                endBreakSession();
            else
                endPomodoroSession();
        }

        private void txtBoxHrs_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numericUpDownMins_ValueChanged(object sender, EventArgs e)
        {
            mins=Convert.ToInt32(numericUpDownMins.Value);
            updateTimerValue();
        }

        private void numericUpDownHrs_ValueChanged(object sender, EventArgs e)
        {
            hrs = Convert.ToInt32(numericUpDownHrs.Value);
            updateTimerValue();
        }

        private void numericUpDownSecs_ValueChanged(object sender, EventArgs e)
        {
            secs = Convert.ToInt32(numericUpDownSecs.Value);
            updateTimerValue();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnHideSettings.Visible = true;
            groupBox1.Visible = true;
            groupBoxBreak.Visible = true;
        }

        private void btnHideSettings_Click(object sender, EventArgs e)
        {
            btnHideSettings.Visible = false;
            groupBox1.Visible = false;
            groupBoxBreak.Visible = false;
        }

        private void numBreakHrs_ValueChanged(object sender, EventArgs e)
        {
            hrs = Convert.ToInt32(numBreakHrs.Value);
            updateTimerValue();
        }

        private void numBreakMins_ValueChanged(object sender, EventArgs e)
        {
            mins = Convert.ToInt32(numBreakMins.Value);
            updateTimerValue();
        }

        private void numBreakSecs_ValueChanged(object sender, EventArgs e)
        {
            secs = Convert.ToInt32(numBreakSecs.Value);
            updateTimerValue();
        }

        private void btnResetStats_Click(object sender, EventArgs e)
        {
            lblSessionsCounter.Text = "1";
            lblTimeStudied.Text = "0hr(s) 00mins";
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            timer2.Enabled = true;
            groupBox1.Enabled = false;
            groupBoxBreak.Enabled = false;
        }
    }
}
