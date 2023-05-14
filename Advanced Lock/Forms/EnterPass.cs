using Advanced_Lock.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Advanced_Lock.Class.Colers;
using Microsoft.Win32;

namespace Advanced_Lock.Forms
{
    public partial class EnterPass : Form
    {
        public EnterPass()
        {
            InitializeComponent();
        }
        private void EnterPass_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                this.BackColor = Darkmode.DarkMode[2];
                this.ForeColor = Color.White;
                OK_BTN.FillColor = Darkmode.DarkMode[0];
            }
            Box_password.Focus();
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AdvancedLock\password", true);

            string password = Encryption_Decryption.Encryption__Decryption__Text.Decryption(reg.GetValue("pass").ToString(), "Adv@n3eD KeY!");
            if (Box_password.Text == password)
            {
                Settings.Default.Password_Enter = true;
                Settings.Default.Save();
                Application.Restart();
            }
            else
            {
                Transition.AddToQueue(Incorect, Guna.UI2.AnimatorNS.AnimateMode.Show);
                Timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Transition.AddToQueue(Incorect, Guna.UI2.AnimatorNS.AnimateMode.Hide);
            Timer.Stop();
        }
    }
}
