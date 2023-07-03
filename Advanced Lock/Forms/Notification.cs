using Advanced_Lock.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Advanced_Lock.Class.Colers;

namespace Advanced_Lock.Forms
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }
        /*--------- Enum & Var Start  ---------*/
        public enum enmAction
        {
            wait,
            start,
            close
        }
        private enmAction action;

        private int x, y;
        /*--------- Enum & Var End  ---------*/
        /*--------- DarkMode Func  ---------*/
        void DarkMode()
        {
            this.BackColor = Darkmode.DarkMode[2];
            this.ForeColor = Darkmode.DarkMode[3];
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                DarkMode();
                label_CloseBTN.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
            }
        }
        /*--------- Start Timer  ---------*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 2500;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void label_CloseBTN_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void label_CloseBTN_MouseEnter(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                label_CloseBTN.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
            }
            else
            {
                label_CloseBTN.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
            }
        }

        private void label_CloseBTN_MouseLeave(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                label_CloseBTN.ForeColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
            }
            else
            {
                label_CloseBTN.ForeColor = Color.FromKnownColor(KnownColor.ControlDark);
            }
        }

        /*--------- Show Notification  ---------*/
        public void showAlert(string msg)
        {
            if (Settings.Default.Show_notification) // if Show_notification is true
            {
                /*----- Setting form -----*/
                this.Opacity = 0.0;
                this.StartPosition = FormStartPosition.Manual;
                string fname;

                for (int i = 1; i < 10; i++)
                {
                    fname = "alert" + i.ToString();
                    Notification frm = (Notification)Application.OpenForms[fname];

                    if (frm == null)
                    {
                        this.Name = fname;
                        this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                        this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                        this.Location = new Point(this.x, this.y);
                        break;
                    }
                }
                this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;


                this.NText.Text = msg; // Notification text

                /*----- Start Show -----*/
                this.Show();
                this.action = enmAction.start;
                this.timer1.Interval = 1;
                timer1.Start();
            }
            /*----- Sound -----*/
            if (Settings.Default.Play_sound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Play();
            }
        }
    }
}
