﻿using Advanced_Lock.Classes;
using Advanced_Lock.Forms;
using Advanced_Lock.Properties;
using Encrypt_Decrypt;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static Advanced_Lock.Classes.Colors;

namespace Advanced_Lock
{
    public partial class ED : Form
    {
        public ED()
        {
            InitializeComponent();
        }
        AllText text = new AllText();
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
        private enmAction action;

        string Result_Work;

        void DarkMode()
        {
            this.BackColor = Darkmode.Dark_Gray;
            this.ForeColor = Darkmode.Light_Gray;
            this.ForeColor = Darkmode.Light_Gray;
            UserSelected.FillColor = Darkmode.Very_Dark_Gray;
            Password_User.FillColor = Darkmode.Very_Dark_Gray;
            Result_ED_Text.FillColor = Darkmode.Very_Dark_Gray;
        }
        void Notif(string msg)
        {
            Notification frm = new Notification();
            frm.showAlert(msg);
        }
        private void SetTextLanguages()
        {
            PathText.Text = text.Your_Choice + ":";
            PasswordText.Text = text.Password + ":";
            ED_Text_Text.Text = text.Result + ":";
            Cancel_BTN.Text = text.Cancel;
            Progress_BTN.Text = text.OK;
        }
        Advanced advanced = new Advanced();
        private void SendToHistory()
        {
            if (action == enmAction.TextE || action == enmAction.TextD)
            {
                advanced.historyadd(UserSelected.Text, Password_User.Text, Result_ED_Text.Text);
            }
            else
            {
                advanced.historyadd(UserSelected.Text, Password_User.Text, Result_Work);
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
            else if (Environment.GetCommandLineArgs().Length == 3)
            {
                if (Environment.GetCommandLineArgs()[1].EndsWith(".alo"))
                {
                    show_ED(Environment.GetCommandLineArgs()[1], "Decryption");
                }
                else if (Environment.GetCommandLineArgs()[1].EndsWith(".alf"))
                {
                    show_ED(Environment.GetCommandLineArgs()[1], "DecryptFolder");
                }
                else
                {
                    if (Environment.GetCommandLineArgs()[2] == "File")
                    {
                        show_ED(Environment.GetCommandLineArgs()[1], "Encryption");
                    }
                    else if (Environment.GetCommandLineArgs()[2] == "Folder")
                    {
                        show_ED(Environment.GetCommandLineArgs()[1], "EncryptFolder");
                    }
                }
            }
            SetTextLanguages();
        }
        public void show_ED(string UserSelected, string type)
        {
            this.UserSelected.Text = UserSelected;
            /*Set Action*/
            switch (type)
            {
                case "Decryption":
                    action = enmAction.Decryption;
                    this.Text = text.Decryption_File;
                    this.Icon = Resources.File_Icon;
                    break;
                case "Encryption":
                    action = enmAction.Encryption;
                    this.Text = text.Encryption_File;
                    this.Icon = Resources.File_Icon;
                    break;
                case "EncryptFolder":
                    action = enmAction.EncryptFolder;
                    this.Text = text.Encryption_Folder;
                    this.Icon = Resources.Folder_Icon;
                    break;
                case "DecryptFolder":
                    action = enmAction.DecryptFolder;
                    this.Text = text.Decryption_Folder;
                    this.Icon = Resources.Folder_Icon;
                    break;
                case "TextE":
                    action = enmAction.TextE;
                    this.UserSelected.ReadOnly = false;
                    progressBar.Visible = false;
                    result_Panel.Visible = true;
                    this.Text = text.Encryption_Text;
                    break;
                case "TextD":
                    result_Panel.Visible = true;
                    this.UserSelected.ReadOnly = false;
                    progressBar.Visible = false;
                    action = enmAction.TextD;
                    this.Text = text.Decryption_Text;
                    break;
            }
            this.Show();
        }
        private void Progress_BTN_Click(object sender, EventArgs e)
        {
            /*Check Box*/
            if (UserSelected.Text == "" || Password_User.Text == "")
            {
                alert_Label.ForeColor = Color.FromArgb(255, 96, 96);
                alert_Label.Text = text.Error_Password_Or_Your_Choice;
                alert_Label.Visible = true;
            }
            else
            {
                /*Start Encryption && Decryption*/
                Progress_BTN.Enabled = false;
                //alert_Label.Visible = true;
                alert_Label.Text = "";
                alert_Label.ForeColor = Color.FromArgb(128, 128, 255);//Blue color
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
                        if (Result != "Error")
                        {
                            SendToHistory();
                        }
                        Progress_BTN.Enabled = true;
                        break;
                    /*Decryption Text*/
                    case enmAction.TextD:
                        Result = Encryption__Decryption__Text.Decryption(UserSelected.Text, Password_User.Text);
                        Result_ED_Text.Text = Result;
                        if (Result != "Incorrect input")
                        {
                            SendToHistory();
                        }
                        Progress_BTN.Enabled = true;
                        break;
                }
            }
        }
        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            if (Background_EFile.IsBusy)
            {
                this.Cursor = Cursors.WaitCursor;
                Cancel_BTN.Enabled = false;
                BackgroundWorker waitForResult = new BackgroundWorker();
                waitForResult.DoWork += WaitForResult_DoWork;
                waitForResult.RunWorkerCompleted += WaitForResult_RunWorkerCompleted;
                waitForResult.RunWorkerAsync();
            }
            else
            {
                this.Close();
            }
        }
        private void WaitForResult_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = Cursors.Default;
            Cancel_BTN.Enabled = true;
        }
        private void WaitForResult_DoWork(object sender, DoWorkEventArgs e)
        {
            Progress_status.Cancel_Progress();
        }
        /*copy to clipboard*/
        private void Result_ED_Text_IconRightClick(object sender, EventArgs e)
        {
            if (Result_ED_Text.Text == "")
            {
                Result_ED_Text.PlaceholderText = text.Result_text_empty;
            }
            else
            {
                Clipboard.SetText(Result_ED_Text.Text);
                Result_ED_Text.Text = "";
                Result_ED_Text.PlaceholderText = text.Result_text_copyed;
            }
        }
        private void Background_EFile_DoWork(object sender, DoWorkEventArgs e)
        {
            string Arg = e.Argument.ToString();
            if (!backgroundProgress.IsBusy)
            {
                backgroundProgress.RunWorkerAsync();
            }
            switch (Arg)
            {
                case "Decrypt_File":
                    Result_Work = Encryption__Decryption__File.Decryption(UserSelected.Text, Password_User.Text);
                    break;
                case "Encrypt_File":
                    Result_Work = Encryption__Decryption__File.Encryption(UserSelected.Text, Password_User.Text);
                    break;
                case "Encrypt_Folder":
                    Result_Work = Encryption__Decryption__Folder.Encryption(UserSelected.Text, Password_User.Text);
                    break;
                case "Decrypt_Folder":
                    Result_Work = Encryption__Decryption__Folder.Decryption(UserSelected.Text, Password_User.Text);
                    break;
            }
        }
        private void Background_EFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            switch (Result_Work)
            {
                case "Error":
                    Progress_BTN.Enabled = true;
                    progressBar.ProgressColor = Color.FromArgb(255, 96, 96);
                    progressBar.ProgressColor2 = Color.FromArgb(255, 96, 96);
                    Notif(text.Error);
                    break;
                case "incorect password":
                    Progress_BTN.Enabled = true;
                    Notif(text.Incorect_Password);
                    break;
                case "not found file":
                    Notif(text.Not_found_file);
                    break;
                case "Cancel":
                    Progress_BTN.Enabled = true;
                    Cancel_BTN.Enabled = true;
                    Notif("Cancel");
                    break;
                default:
                    if (Environment.GetCommandLineArgs().Length >= 2)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        SendToHistory();
                        this.Close();
                    }
                    break;
            }
            progressBar.Maximum = 0;
            Result_Work = "";
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
            do
            {
                progressBar.Maximum = (int)Progress_status.progressBar_MaxValue;
            }
            while (progressBar.Maximum < 1);
            while (string.IsNullOrEmpty(Result_Work))
            {
                progressBar.Value = (int)Progress_status.progressBar_Value;
            }
        }
        private void ED_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Environment.GetCommandLineArgs().Length < 2)
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
            catch (Exception) { }
        }
    }
}