﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Encryption_Decryption;
using Advanced_Lock.Properties;
using Advanced_Lock.Forms;
using static Advanced_Lock.Class.Colers;
using System.Reflection;
using Microsoft.Win32;

namespace Advanced_Lock
{
    public partial class ED : Form
    {
        public ED()
        {
            InitializeComponent();
        }
        public enum enmAction
        {
            /*Actions*/
            Encryption,
            Decryption,
            EncryptFolder,
            DecryptFolder,
            TextE,
            TextD
        }
        private ED.enmAction action;

        string Result_Work;

        void DarkMode()
        {
            this.BackColor = Darkmode.DarkMode[0];
            this.ForeColor = Color.White;
            ED_Panel.BackColor = Darkmode.DarkMode[1];
            ED_Panel.ForeColor = Color.White;
            UserSelected.FillColor = Darkmode.DarkMode[1];
            Password_User.FillColor = Darkmode.DarkMode[1];
            Result_ED_Text.FillColor = Darkmode.DarkMode[1];
        }
        void Notif(string msg_en,string msg_fa)
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
        private void ED_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                DarkMode();
            }
            if (Environment.GetCommandLineArgs().Length == 2)
            {
                if (Environment.GetCommandLineArgs()[1].EndsWith(".alo"))
                {
                    show_ED(Environment.GetCommandLineArgs()[1], "Decryption");
                }
                else if (Environment.GetCommandLineArgs()[1].EndsWith(".alf"))
                {
                    show_ED(Environment.GetCommandLineArgs()[1], "DecryptFolder");
                }
            }
        }
        public void show_ED(string UserSelected,string type)
        {
            this.UserSelected.Text = UserSelected;
            /*Set Action*/
            if (type == "Decryption")
            {
                action = enmAction.Decryption;
                this.Text = "Decryption";
                this.Icon = Resources.File_Icon;
            }
            else if (type == "Encryption")
            {
                action = enmAction.Encryption;
                this.Text = "Encryption";
                this.Icon = Resources.File_Icon;
            }
            else if (type == "EncryptFolder")
            {
                action = enmAction.EncryptFolder;
                this.Text = "EncryptFolder";
            }
            else if (type == "DecryptFolder")
            {
                action = enmAction.DecryptFolder;
                this.Text = "DecryptFolder";
            }
            else if (type == "TextE")
            {
                action = enmAction.TextE;
                this.UserSelected.ReadOnly = false;
                ProgressBar.Visible = false;
                Text_ED_Panel.Visible = true;
                this.Text = "Encryption";
            }
            else if (type == "TextD")
            {
                Text_ED_Panel.Visible = true;
                this.UserSelected.ReadOnly = false;
                ProgressBar.Visible = false;
                action = enmAction.TextD;
                this.Text = "Decryption";
            }
            this.Show();
        }
        private void Progress_BTN_Click(object sender, EventArgs e)
        {
            /*Check Box*/
            if (UserSelected.Text == "" || Password_User.Text == "")
            {
                AlertBox.Visible = true;
            }
            else
            {
                AlertBox.Visible = false;
                /*Start Encryption && Decryption*/
                Cancel_BTN.Enabled = false;
                Progress_BTN.Enabled = false;
                string Result;
                switch (this.action)
                {
                    /*Encryption File*/
                    case enmAction.Encryption:
                        Background_EFile.RunWorkerAsync("Encrypt_File");

                        break;
                    /*Decryption File*/
                    case enmAction.Decryption:
                        Background_EFile.RunWorkerAsync("Decrypt_File");
                        break;
                    /*Encryption Folder*/
                    case enmAction.EncryptFolder:
                        Background_EFile.RunWorkerAsync("Encrypt_Folder");
                        break;
                    /*Decryption Folder*/
                    case enmAction.DecryptFolder:
                        Background_EFile.RunWorkerAsync("Decrypt_Folder");
                        break;
                    /*Encryption Text*/
                    case enmAction.TextE:
                        Result = Encryption__Decryption__Text.Encryption(UserSelected.Text, Password_User.Text);
                        Result_ED_Text.Text = Result;
                        Cancel_BTN.Enabled = true;
                        new Advanced().historyadd(UserSelected.Text, Password_User.Text, Result_ED_Text.Text);
                        Progress_BTN.Enabled = true;
                        break;
                    /*Decryption Text*/
                    case enmAction.TextD:
                        Result = Encryption__Decryption__Text.Decryption(UserSelected.Text, Password_User.Text);
                        Result_ED_Text.Text = Result;
                        Cancel_BTN.Enabled = true;
                        if (Result != "Error incorent input")
                        {
                            new Advanced().historyadd(UserSelected.Text, Password_User.Text, Result_ED_Text.Text);
                        }
                        Progress_BTN.Enabled = true;
                        break;
                }
            }
        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*copy to clipboard*/
        private void Result_ED_Text_IconRightClick(object sender, EventArgs e)
        {
            if (Result_ED_Text.Text == "")
            {
                Result_ED_Text.PlaceholderText = "Result text is empty!";
            }
            else
            {
                Clipboard.SetText(Result_ED_Text.Text);
                Result_ED_Text.Text = "";
                Result_ED_Text.PlaceholderText = "Result text was copyed!";
            }
        }

        private void Background_EFile_DoWork(object sender, DoWorkEventArgs e)
        {
            string Arg = e.Argument.ToString();
            backgroundProgress.RunWorkerAsync();
            if (Arg == "Decrypt_File")
            {
                Result_Work = Encryption__Decryption__File.Decryption(UserSelected.Text, Password_User.Text);
            }
            else if (Arg == "Encrypt_File")
            {
                Result_Work = Encryption__Decryption__File.Encryption(UserSelected.Text, Password_User.Text);
            }
            else if (Arg == "Encrypt_Folder")
            {
                Result_Work = Encryption__Decryption__Folder.Encryption(UserSelected.Text,Password_User.Text);
            }
            else if (Arg == "Decrypt_Folder")
            {
                Result_Work = Encryption__Decryption__Folder.Decryption(UserSelected.Text,Password_User.Text);
            }
        }

        private void Background_EFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Result_Work == "Error")
            {
                ProgressBar.ProgressColor = Color.FromArgb(255, 96, 96);
                ProgressBar.ProgressColor2 = Color.FromArgb(255, 96, 96);
                Cancel_BTN.Enabled = true;
                Progress_BTN.Text = "Error!";
                Notif("Error!","خطایی رخ داد!");
            }
            else if (Result_Work == "incorect password")
            {
                Cancel_BTN.Enabled = true;
                Progress_BTN.Enabled = true;
                Notif("incorect password", "گذرواژه اشتباه است");
                ProgressBar.Value = 0;
            }
            else if (Result_Work == "not found file")
            {
                Cancel_BTN.Enabled = true;
                Notif("not found file", "فایل پیدا نشد");
                ProgressBar.Value = 0;
            }
            else
            {
                if (Environment.GetCommandLineArgs().Length == 2)
                {
                    Application.Exit();
                }
                else
                {
                    new Advanced().historyadd(UserSelected.Text, Password_User.Text, Result_Work);
                    this.Close();
                }
            }
        }

        private void Password_User_IconRightClick(object sender, EventArgs e)
        {
            if (Password_User.UseSystemPasswordChar)
            {
                Password_User.UseSystemPasswordChar = false;
            }
            else Password_User.UseSystemPasswordChar = true;
        }

        private void backgroundProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] Results = { "Error", "incorect password", "not found file" };
            while (true)
            {
                ProgressBar.Value = int.Parse(PV.ProgressV);
                if (ProgressBar.Value > 99 || Result_Work == Results[0] || Result_Work == Results[1] || Result_Work == Results[2])
                {
                    break;
                }
            }
        }

        private void ED_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backgroundProgress.IsBusy)
            {
                backgroundProgress.CancelAsync();
            }
            if (Background_EFile.IsBusy)
            {
                Background_EFile.CancelAsync();
            }
        }
    }
}