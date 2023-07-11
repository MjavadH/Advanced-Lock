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
using Advanced_Lock.Class;

namespace Advanced_Lock.Forms
{
    public partial class Setting_Page : Form
    {
        public Setting_Page()
        {
            InitializeComponent();
        }
        AllText text = new AllText();
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
        void Notif(string msg)
        {
            Notification frm = new Notification();
            frm.showAlert(msg);
        }
        private void SetTextLanguages()
        {
            label_DarkM.Text = text.Dark_Mode;
            label_notifi.Text = text.Show_Notification;
            label_Password.Text = text.Enable_Password;
            Submit_BTN.Text = text.Submit;
            label_Lang.Text = text.Change_Languages;
            label_Sound.Text = text.Play_Sound;
            label_Config.Text = text.Check_Configuration;
            CheckConfig_BTN.Text = text.Check;
        }
        private void Setting_Page_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                DarkMode();
            }
            DarkMode_Toggle.Checked = Settings.Default.DarkMode;
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
            SetTextLanguages();
            foreach (var languagesName in text.allAvailableLanguages.Values)
            {
                comboBox_Languages.Items.Add(languagesName);
            }
            comboBox_Languages.Text = text.allAvailableLanguages[Settings.Default.languages];
        }   
        private void Toggles_Click(object sender, EventArgs e)
        {
            Guna2ToggleSwitch BTNT = (Guna2ToggleSwitch)sender;
            switch (BTNT.Name)
            {
                case "DarkMode_Toggle":
                    Settings.Default.DarkMode = !Settings.Default.DarkMode;
                    Notif(text.Restart_app_to_chenge_theme);
                    break;
                case "Notifi_Toggle":
                    Settings.Default.Show_notification = !Settings.Default.Show_notification;
                    Notif(text.Example_Notification);
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

            Notif(text.Restart_app_to_chenge_language);
        }
        /*--------- Password Panel Start ---------*/
        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Box_password.Text))
            {
                string password = Encrypt_Decrypt.Encryption__Decryption__Text.Encryption(Box_password.Text, Box_password.Text);

                Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AdvancedLock\password", RegistryKeyPermissionCheck.ReadWriteSubTree);
                RegistryKey regPass = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\AdvancedLock\password", true);
                regPass.SetValue("pass", password, RegistryValueKind.String);
                regPass.SetValue("passEnabaled", "true", RegistryValueKind.String);

                TransitionOK.Show(OK_BTN);
                Notif(text.Password_is_enable);
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
            try
            {
                if (!new Registry_Editor().CheckExtensionRegistery())
                {
                    new Registry_Editor().CreateRegistery();
                    Notif(text.Checked_configuration_and_fixed_problems);
                }
                else
                {
                    Notif(text.There_is_no_problem_in_configuring);
                    TransitionOK.Show(Checked_BTN);
                }
            }
            catch (Exception)
            {
                Notif(text.Error);
            }
            
        }
        private void comboBox_Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Languages.Text != text.allAvailableLanguages[Settings.Default.languages])
            {
                Settings.Default.languages = text.allAvailableLanguages.FirstOrDefault(x => x.Value == comboBox_Languages.Text).Key;
                Notif(text.Restart_app_to_chenge_language);
            }
        }

        private void Setting_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
        /*--------- Config Panel End ---------*/

    }
}
