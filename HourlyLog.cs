using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourlyPromptWF
{
    public partial class HourlyLog : Form
    {
        string Time;
        AlertForm Parent;

        public HourlyLog(String time, AlertForm parent)
        {
            InitializeComponent();
            labelTime.Text = time;

            this.Time = time;
            this.Parent = parent;

            //focus this window and the text box
            //Activate();  //doesn't work!
            TextBoxLog.Focus();
        }

        private void SaveContinueButton_Click(object sender, EventArgs e)
        {
            LogUtils.WriteToLog(TextBoxLog.Text, Time);
            Parent.StartNewHour();
            this.Close();
        }

        private void SaveExitButton_Click(object sender, EventArgs e)
        {
            LogUtils.WriteToLog(TextBoxLog.Text, Time);
            Application.Exit();
        }
    }
}
