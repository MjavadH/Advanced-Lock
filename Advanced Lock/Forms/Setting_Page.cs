﻿using Advanced_Lock.Classes;
using Advanced_Lock.Properties;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using Registry_Configuration;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Advanced_Lock.Classes.Colors;

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
            this.BackColor = Darkmode.Almost_Black;
            this.ForeColor = Darkmode.Light_Gray;
            Submit_BTN.FillColor = Darkmode.Midnight_Blue;
            CheckConfig_BTN.FillColor = Darkmode.Midnight_Blue;
            Guna2Panel[] panels = { DarkModePanel, SwitchLangPanel, Sound_Panel, Notifi_Panel, Password_Panel, Config_Panel };
            for (int i = 0; i < panels.Length; i++)
            {
                panels[i].FillColor = Darkmode.Very_Dark_Gray;
                panels[i].ShadowDecoration.Color = Darkmode.Light_Gray;
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
            label_Config.Text = text.Configuration;
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
                { }
            }
            else if (password_Toggle.Checked)
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
        void DefaultBTN()
        {
            CheckConfig_BTN.Tag = "Check";
            CheckConfig_BTN.FillColor = Color.FromArgb(0, 69, 255);
            CheckConfig_BTN.Text = text.Check;
        }
        void AddConfig()
        {
            try
            {
                new Registry_Editor().StartAdmin(Registry_Editor.RegistryMode.Create);
                Notif(text.Checked_configuration_and_fixed_problems);
                TransitionOK.Show(Checked_BTN);
                DefaultBTN();
            }
            catch (Exception)
            {
                CheckConfig_BTN.FillColor = Color.FromArgb(255, 185, 0);
                CheckConfig_BTN.Text = text.Add;
                CheckConfig_BTN.Tag = "Add";
            }
        }
        private void CheckConfig_BTN_Click(object sender, EventArgs e)
        {
            if (CheckConfig_BTN.Tag.ToString() == "Add")
            {
                AddConfig();
            }
            else if (CheckConfig_BTN.Tag.ToString() == "Remove")
            {
                try
                {
                    new Registry_Editor().StartAdmin(Registry_Editor.RegistryMode.Delete);
                    TransitionOK.Show(Checked_BTN);
                    DefaultBTN();
                }
                catch (Exception)
                {
                    Notif(text.Error);
                }
            }
            else
            {
                if (!new Registry_Editor().CheckExtensionRegistery())
                {
                    AddConfig();
                }
                else
                {
                    Notif(text.There_is_no_problem_in_configuring);
                    CheckConfig_BTN.FillColor = Color.FromArgb(255, 96, 96);
                    TransitionOK.Show(Checked_BTN);
                    CheckConfig_BTN.Text = text.Remove;
                    CheckConfig_BTN.Tag = "Remove";
                }
            }
        }
        /*--------- Config Panel End ---------*/
        /*--------- Languages Panel Start ---------*/
        private void comboBox_Languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Languages.Text != text.allAvailableLanguages[Settings.Default.languages])
            {
                Settings.Default.languages = text.allAvailableLanguages.FirstOrDefault(x => x.Value == comboBox_Languages.Text).Key;
                Notif(text.Restart_app_to_chenge_language);
            }
        }
        /*--------- Languages Panel End ---------*/
        private void Setting_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}