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
        private const string Slogan = "Have It Your Way!";

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

                Thread.Sleep(5000);
            }
        }

        private void Pin2Desktop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = Pin2Desktop.Checked;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _keepRunning = true;
            if (_antiSleepThread == null || !_antiSleepThread.IsAlive)
            {
                InitializeAndStartAntiSleepThread();
            }
            UpdateUIForState("Running...", Color.Green, SystemColors.Control);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            _keepRunning = false;
            UpdateUIForState("Stopped", SystemColors.Control, Color.Red);
        }

        private void InitializeAndStartAntiSleepThread()
        {
            _antiSleepThread = new Thread(AntiSleepTask)
            {
                IsBackground = true
            };
            _antiSleepThread.Start();
        }

        private void UpdateUIForState(string statusText, Color startButtonColor, Color stopButtonColor)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateUIForState(statusText, startButtonColor, stopButtonColor)));
                return;
            }

            statusLabel.Text = statusText;
            startButton.BackColor = startButtonColor;
            stopButton.BackColor = stopButtonColor;
        }
    }
}