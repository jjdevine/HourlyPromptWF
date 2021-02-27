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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LogUtils.GetLogFile(); //create log file now to avoid race conditions on File Access
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AlertForm();
        }
    }
}
