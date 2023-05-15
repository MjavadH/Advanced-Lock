using Advanced_Lock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Advanced_Lock.Class.Colers;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using Registry_Configuration;

namespace Advanced_Lock.Forms
{
    public partial class Setting_Page : Form
    {
        public Setting_Page()
        {
            InitializeComponent();
        }
        void DarkMode()
        {
            this.BackColor = Darkmode.DarkMode[2];
            this.ForeColor = Color.White;
            Submit_BTN.FillColor = Darkmode.DarkMode[4];
            CheckConfig_BTN.FillColor = Darkmode.DarkMode[4];
            Guna2Panel[] PL = { DarkModePanel, SwitchLangPanel,Sound_Panel,Notifi_Panel, Password_Panel, Config_Panel };
            for (int i = 0; i < PL.Length; i++)
            {
                PL[i].FillColor = Darkmode.DarkMode[1];
                PL[i].ShadowDecoration.Color = Darkmode.DarkMode[3];
            }
        }
        void Notif(string msg_en, string msg_fa)
        {
            Notification frm = new Notification();
            if (Settings.Default.lan)
            {
                frm.showAlert(msg_fa);
            }
            else
            {
                frm.showAlert(msg_en);
            }
        }
        private void Setting_Page_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                DarkMode();
            }
            DarkMode_Toggle.Checked = Settings.Default.DarkMode;
            SwitchLang_Toggle.Checked = Settings.Default.lan;
            Notifi_Toggle.Checked = Settings.Default.Show_notification;
            Sound_Toggle.Checked = Settings.Default.Play_sound;
            password_Toggle.Checked = Settings.Default.Enable_Password;
            if (!password_Toggle.Checked)
            {
                Box_password.Enabled = false;
                Submit_BTN.Enabled = false;
            }
            else
            {
                try
                {
                    RegistryKey regPass = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AdvancedLock\password", true);
                    string pass = regPass.GetValue("pass","").ToString();
                    if (!string.IsNullOrEmpty(pass))
                    {
                        Box_password.Text = Encrypt_Decrypt.Encryption__Decryption__Text.Decryption(pass, "Adv@n3eD KeY!");
                    }
                }
                catch (Exception)
                { }
            }
        }   
        private void Toggles_Click(object sender, EventArgs e)
        {
            Guna2ToggleSwitch BTNT = (Guna2ToggleSwitch)sender;
            switch (BTNT.Name)
            {
                case "DarkMode_Toggle":
                    Settings.Default.DarkMode = !Settings.Default.DarkMode;
                    Notif("Restart app to chenge theme", "برنامه را بسته و مجدد باز نمایید تا تغییر حالت به درستی انجام گیرد");
                    break;
                case "Notifi_Toggle":
                    Settings.Default.Show_notification = !Settings.Default.Show_notification;
                    Notif("example notification", "مثال نمایش اعلان");
                    break;
                case "Sound_Toggle":
                    Settings.Default.Play_sound = !Settings.Default.Play_sound;
                    break;
                case "password_Toggle":
                    Settings.Default.Enable_Password = !Settings.Default.Enable_Password;
                    if (password_Toggle.Checked)
                    {
                        Box_password.Enabled = true;
                        Submit_BTN.Enabled = true;
                    }
                    else
                    {
                        Box_password.Enabled = false;
                        Submit_BTN.Enabled = false;
                    }
                    break;
            }
            Settings.Default.Save();
        }
        /*--------- Chenge Lang ---------*/
        private void ToggleSwitchLang_Click(object sender, EventArgs e)
        {
            if (!SwitchLang_Toggle.Checked)
            {
                CultureInfo cul;
                cul = new CultureInfo("en-US");
                Settings.Default.lan = false;
                Settings.Default.Save();
            }
            else if (SwitchLang_Toggle.Checked)
            {
                CultureInfo cul;
                cul = new CultureInfo("fa-IR");
                Settings.Default.lan = true;
                Settings.Default.Save();
            }
            Notif("Restart app to chenge language", "برنامه را بسته و مجدد باز نمایید تا زبان تغییر کند");
        }
        /*--------- Password Panel Start ---------*/
        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Box_password.Text))
            {
                string password = Encrypt_Decrypt.Encryption__Decryption__Text.Encryption(Box_password.Text, "Adv@n3eD KeY!");

                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AdvancedLock\password", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RegistryKey regPass = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AdvancedLock\password", true);
                regPass.SetValue("pass", password, RegistryValueKind.String);
                regPass.SetValue("passEnabaled", "true", RegistryValueKind.String);

                TransitionOK.AddToQueue(OK_BTN, Guna.UI2.AnimatorNS.AnimateMode.Show);
                Notif("password is enable", "گذرواژه فعال شد");
                timerOK.Start();
            }
        }

        private void Box_password_IconRightClick(object sender, EventArgs e)
        {
            Box_password.UseSystemPasswordChar = !Box_password.UseSystemPasswordChar;
        }

        private void timerOK_Tick(object sender, EventArgs e)
        {
            TransitionOK.Hide(OK_BTN);
            timerOK.Stop();
        }

        private void password_Toggle_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey regPass;
            if (!password_Toggle.Checked)
            {
                try
                {
                    regPass = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AdvancedLock\password", true);
                    regPass.SetValue("passEnabaled", "false", RegistryValueKind.String);
                }
                catch (Exception)
                {}
            }
            else if (password_Toggle.Checked && Box_password.Text != "")
            {
                try
                {
                    regPass = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AdvancedLock\password", true);
                }
                catch (Exception)
                {
                    regPass = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AdvancedLock\password", RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
                regPass.SetValue("passEnabaled", "true", RegistryValueKind.String);
            }
        }

        /*--------- Pass Panel End ---------*/
        /*--------- Config Panel Start ---------*/
        private void CheckConfig_BTN_Click(object sender, EventArgs e)
        {
            if (!new LockRegistry().CheckRegistery())
            {
                new LockRegistry().CreateRegistery();
                Notif("The configuration was checked and all problems were fixed", "پیکربندی برسی شد و تمامی مشکلات رفع شد");
            }
            else
            {
                Notif("There is no problem in configuring the software", "مشکلی در پیکربندی نرم‌افزار وجود ندارد");
                TransitionOK.ShowSync(Checked_BTN);
            }
        }
        /*--------- Config Panel End ---------*/

    }
}
