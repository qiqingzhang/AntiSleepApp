using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AntiSleepApp
{
    public partial class AntiSleep : Form
    {
        private Thread _antiSleepThread;
        private bool _keepRunning;
        private const string Slogan = "forever!";

        public AntiSleep()
        {
            InitializeComponent();
        }

        private void AntiSleepTask()
        {
            while (_keepRunning)
            {
                foreach (var c in Slogan)
                {
                    if (!_keepRunning) break;

                    SendKeys.SendWait(c.ToString());
                    Thread.Sleep(400);
                }

                for (var i = 0; i < Slogan.Length; i++)
                {
                    if (!_keepRunning) break;

                    SendKeys.SendWait("{BACKSPACE}");
                    Thread.Sleep(400);
                }

                var count = 0;
                while (count < 50 && _keepRunning)
                {
                    Thread.Sleep(100);
                    count++;
                }
            }
        }

        private void Pin2Desktop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            Pin2Desktop.Checked = this.TopMost;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (_antiSleepThread == null || !_antiSleepThread.IsAlive)
            {
                _keepRunning = true;
                _antiSleepThread = new Thread(AntiSleepTask)
                {
                    IsBackground = true
                };
                _antiSleepThread.Start();

                statusLabel.Text = @"Running...";
                startButton.BackColor = Color.Green;
                stopButton.BackColor = SystemColors.Control;
            }
            else
            {
                _keepRunning = true;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            _keepRunning = false;

            if (_antiSleepThread != null && _antiSleepThread.IsAlive)
            {
                _antiSleepThread.Join();
            }

            statusLabel.Text = @"Stopped";
            stopButton.BackColor = Color.Red;
            startButton.BackColor = SystemColors.Control;
        }
    }
}
