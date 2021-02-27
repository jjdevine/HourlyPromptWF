using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourlyPromptWF
{
    public partial class AlertForm : Form
    {
        private DateTime StartOfHour;

        private List<Event> TimerEvents;

        private Timer HideFormTimer;

        private Timer GlowingLabelTimer;

        private Timer SlidingWindowTimer;

        Timer EventCheckTimer;

        private int MovementSpeed = 1;

        bool hourInProgress = false;

        bool dontStartNewHour = false;

        public AlertForm()
        {
            InitializeComponent();

            EventCheckTimer = new Timer();
            EventCheckTimer.Interval = (5 * 1000); // 5 seconds
            EventCheckTimer.Tick += new EventHandler(TimeoutHandler);
            EventCheckTimer.Start();

            HideFormTimer = new Timer();
            HideFormTimer.Interval = (20 * 1000); //20 seconds
            HideFormTimer.Tick += new EventHandler(HideFormTimeout);

            GlowingLabelTimer = new Timer();
            GlowingLabelTimer.Interval = (100); //0.05 seconds
            GlowingLabelTimer.Tick += new EventHandler(LabelChangeTimeout);

            SlidingWindowTimer = new Timer();
            SlidingWindowTimer.Interval = (3); //0.05 seconds
            SlidingWindowTimer.Tick += new EventHandler(SlideWindowDown);

            StartNewHour();
        }

        private void TimeoutHandler(object sender, EventArgs e)
        {
            CheckElapsedEvents();
        }

        private int CalculateWindowX()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            return workingArea.Right - 10 - Size.Width - 10;
        }

        private void MoveWindowToTopRight()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(CalculateWindowX(), 10);
        }

        private void SlideWindowDown(object sender, EventArgs e)
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            int currentY = this.Location.Y;
            if (currentY < workingArea.Bottom - Size.Height - 10 )
            {
                this.Location = new Point(CalculateWindowX(), currentY + MovementSpeed);
            } 
            else
            {
                SlidingWindowTimer.Stop();
            } 
        }

        public void StartNewHour()
        {
            if(dontStartNewHour)
            {
                Application.Exit();
            }

            if(!notificationsPaused)
            {
                StartOfHour = DateTime.Now;
                GenerateEventsList();
                hourInProgress = true;
            }
        }

        private void GenerateEventsList()
        {
            TimerEvents = new List<Event>();
            TimerEvents.Add(new Event(DateTime.Now.AddMinutes(30), EventType.Warning_30_Minutes));
            TimerEvents.Add(new Event(DateTime.Now.AddMinutes(45), EventType.Warning_15_Minutes));
            TimerEvents.Add(new Event(DateTime.Now.AddMinutes(55), EventType.Warning_5_Minutes));
            TimerEvents.Add(new Event(DateTime.Now.AddMinutes(60), EventType.Hour_Complete));
        }

        private void GenerateDebugEventsList()
        {
            MovementSpeed = 50;
            HideFormTimer.Interval = 2 * 1000;
            EventCheckTimer.Interval = (5 * 100); // 0.5 seconds

            TimerEvents = new List<Event>();
            TimerEvents.Add(new Event(DateTime.Now.AddSeconds(0), EventType.Warning_30_Minutes));
            TimerEvents.Add(new Event(DateTime.Now.AddSeconds(7), EventType.Warning_15_Minutes));
            TimerEvents.Add(new Event(DateTime.Now.AddSeconds(14), EventType.Warning_5_Minutes));
            TimerEvents.Add(new Event(DateTime.Now.AddSeconds(21), EventType.Hour_Complete));
        }

        private void CheckElapsedEvents()
        {
            foreach (Event timerEvent in TimerEvents)
            {
                //any events that elapsed in the last 3 minutes
                if(DateTime.Compare(timerEvent.DueDateTime, DateTime.Now) <= 0
                    && DateTime.Compare(timerEvent.DueDateTime, DateTime.Now.AddMinutes(-3)) > 0)
                {
                    TimerEvents.Remove(timerEvent);
                    ShowEvent(timerEvent.Type);
                    if (timerEvent.Type == EventType.Hour_Complete) 
                    {
                        hourInProgress = false;
                        if(!notificationsPaused)
                        {
                            ShowHourlyLog();
                        }
                        
                    }
                    break;
                }
            }


        }

        private void ShowEvent(EventType eventType)
        {
            switch(eventType)
            {
                case EventType.Warning_30_Minutes:
                    label1.Text = "Time Remaining: 30 Minutes";
                    break;
                case EventType.Warning_15_Minutes:
                    label1.Text = "Time Remaining: 15 Minutes";
                    break;
                case EventType.Warning_5_Minutes:
                    label1.Text = "Time Remaining: 5 Minutes";
                    break;
                case EventType.Hour_Complete:
                    label1.Text = "Hour Complete!!";
                    break;
            }

            MoveWindowToTopRight();
            if(!notificationsPaused) { 
                this.Show();
            }

            HideFormTimer.Start();
            GlowingLabelTimer.Start();
            SlidingWindowTimer.Start();
        }

        private void HideFormTimeout(object sender, EventArgs e)
        {
            HideFormTimer.Stop();
            GlowingLabelTimer.Stop();
            this.Hide();
        }

        int LabelIteration = 0;
        bool LabelIterationIncreasing = true;

        private void LabelChangeTimeout(object sender, EventArgs e)
        {
            SetLabelColour();
        }

        private void SetLabelColour()
        {
            int maxIterations = 10;

            if(LabelIterationIncreasing)
            {
                LabelIteration++;
                if(LabelIteration >= maxIterations)
                {
                    LabelIterationIncreasing = false;
                }
            } 
            else
            {
                if(LabelIteration == 1)
                {
                    LabelIterationIncreasing = true;
                }
                LabelIteration--;
            }

            int colorOffset = 25 * LabelIteration;

            label1.ForeColor = Color.FromArgb(
                colorOffset,
                255,
                0);
        }

        bool notificationsPaused = false;

        private void pauseNotificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invert setting
            notificationsPaused = !notificationsPaused;

            if(notificationsPaused)
            {
                pauseNotificationsToolStripMenuItem.Text = "Resume Notifications";
            }
            else
            {
                if(!hourInProgress) {
                    ShowHourlyLog();
                }
                pauseNotificationsToolStripMenuItem.Text = "Pause Notifications";
            }
        }

        private void stopAndWriteLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerEvents.Clear();
            dontStartNewHour = true;
            ShowHourlyLog();
        }

        private void stopAndQuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowHourlyLog()
        {
            new HourlyLog(DateTime.Now.ToString("HH:mm"), this).Show();
        }
    }
}
