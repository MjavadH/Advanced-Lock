using Advanced_Lock.Forms;
using Advanced_Lock.Properties;
using Encrypt_Decrypt;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static Advanced_Lock.Class.Colers;
using System.IO;

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
        public void show_ED(string UserSelected, string type)
        {
            this.UserSelected.Text = UserSelected;
            /*Set Action*/
            switch (type)
            {
                case "Decryption":
                    action = enmAction.Decryption;
                    if (Settings.Default.lan)
                    {
                        this.Text = "رمزگشایی فایل";
                    }
                    else
                    {
                        this.Text = "Decryption File";
                    }
                    this.Icon = Resources.File_Icon;
                    break;
                case "Encryption":
                    action = enmAction.Encryption;
                    if (Settings.Default.lan)
                    {
                        this.Text = "رمزنگاری فایل";
                    }
                    else
                    {
                        this.Text = "Encryption File";
                    }
                    this.Icon = Resources.File_Icon;
                    break;
                case "EncryptFolder":
                    action = enmAction.EncryptFolder;
                    if (Settings.Default.lan)
                    {
                        this.Text = "رمزنگاری پوشه";
                    }
                    else
                    {
                        this.Text = "Encryption Folder";
                    }
                    break;
                case "DecryptFolder":
                    action = enmAction.DecryptFolder;
                    if (Settings.Default.lan)
                    {
                        this.Text = "رمزگشایی پوشه";
                    }
                    else
                    {
                        this.Text = "Decryption Folder";
                    }
                    break;
                case "TextE":
                    action = enmAction.TextE;
                    this.UserSelected.ReadOnly = false;
                    progressBar.Visible = false;
                    Text_ED_Panel.Visible = true;
                    if (Settings.Default.lan)
                    {
                        this.Text = "رمزنگاری متن";
                    }
                    else
                    {
                        this.Text = "Encryption Text";
                    }
                    break;
                case "TextD":
                    Text_ED_Panel.Visible = true;
                    this.UserSelected.ReadOnly = false;
                    progressBar.Visible = false;
                    action = enmAction.TextD;
                    if (Settings.Default.lan)
                    {
                        this.Text = "رمزگشایی متن";
                    }
                    else
                    {
                        this.Text = "Decryption Text";
                    }
                    break;
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
                        new Advanced().historyadd(UserSelected.Text, Password_User.Text, Result_ED_Text.Text);
                        Progress_BTN.Enabled = true;
                        break;
                    /*Decryption Text*/
                    case enmAction.TextD:
                        Result = Encryption__Decryption__Text.Decryption(UserSelected.Text, Password_User.Text);
                        Result_ED_Text.Text = Result;
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
            backgroundProgress.RunWorkerAsync(Arg);
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
            if (Result_Work == "Error")
            {
                Cancel_BTN.Enabled = true;
                Progress_BTN.Enabled = true;
                progressBar.ProgressColor = Color.FromArgb(255, 96, 96);
                progressBar.ProgressColor2 = Color.FromArgb(255, 96, 96);
                Notif("Error!", "خطایی رخ داد!");
            }
            else if (Result_Work == "incorect password")
            {
                Cancel_BTN.Enabled = true;
                Progress_BTN.Enabled = true;
                Notif("incorect password", "گذرواژه اشتباه است");
                progressBar.Value = 0;
            }
            else if (Result_Work == "not found file")
            {
                Cancel_BTN.Enabled = true;
                Notif("not found file", "فایل پیدا نشد");
                progressBar.Value = 0;
            }
            else
            {
                if (Environment.GetCommandLineArgs().Length >= 2)
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
            while (string.IsNullOrEmpty(Result_Work))
            {
                progressBar.Maximum = (int) Progress_status.progressBar_MaxValue /10;
                progressBar.Value = (int) Progress_status.progressBar_Value / 10;
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
