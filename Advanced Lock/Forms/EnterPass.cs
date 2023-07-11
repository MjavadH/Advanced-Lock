using Advanced_Lock.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Advanced_Lock.Class.Colers;
using Microsoft.Win32;
using Advanced_Lock.Class;

namespace Advanced_Lock.Forms
{
    public partial class EnterPass : Form
    {
        public EnterPass()
        {
            InitializeComponent();
        }
        AllText text = new AllText();
        private void SetTextLanguages()
        {
            OK_BTN.Text = text.OK;
            lable_IncorectPassword.Text = text.Incorect_Password;
            Box_password.PlaceholderText = text.Enter_Password;
        }
            private void EnterPass_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                this.BackColor = Darkmode.DarkMode[2];
                this.ForeColor = Color.White;
                OK_BTN.FillColor = Darkmode.DarkMode[0];
                Box_password.FillColor = Darkmode.DarkMode[0];
                Box_password.BorderColor = Darkmode.DarkMode[4];
            }
            Box_password.Focus();
            SetTextLanguages();
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AdvancedLock\password", false);

            string password = Encrypt_Decrypt.Encryption__Decryption__Text.Encryption(Box_password.Text, Box_password.Text);
            if (reg.GetValue("pass").ToString() == password)
            {
                Settings.Default.Password_Enter = true;
                Settings.Default.Save();
                Application.Restart();
            }
            else
            {
                Transition.Show(lable_IncorectPassword);
                Timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Transition.Hide(lable_IncorectPassword);
            Timer.Stop();
        }
    }
}
