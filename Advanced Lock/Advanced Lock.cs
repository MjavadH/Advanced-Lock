using Advanced_Lock.Forms;
using Advanced_Lock.Properties;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using static Advanced_Lock.Class.Colers;
using Advanced_Lock.Classes;

namespace Advanced_Lock
{
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
        }
        /*--------- Func Start ---------*/
        AllText text = new AllText();
        public void historyadd(string choose, string pass, string result)
        {
            dataLoad();
            dataSet1.Tables[0].Rows.Add(choose, pass, result);
            dataSet1.AcceptChanges();
            dataSet1.WriteXml("History");
            File.WriteAllText("History", Encrypt_Decrypt.Encryption__Decryption__Text.Encryption(File.ReadAllText("History"), "Adv@n3eD KeY!"));
        }
        void dataLoad()
        {
            try
            {
                File.WriteAllText("History", Encrypt_Decrypt.Encryption__Decryption__Text.Decryption(File.ReadAllText("History"), "Adv@n3eD KeY!"));
                dataSet1.ReadXml("History");
                File.WriteAllText("History", Encrypt_Decrypt.Encryption__Decryption__Text.Encryption(File.ReadAllText("History"), "Adv@n3eD KeY!"));
            }
            catch (Exception)
            {
                dataSet1.WriteXml("History");
            }
        }
        public void HistoryRefresh()
        {
            while (History_DataTable.Rows.Count != 0)
            {
                History_DataTable.Rows.Remove(History_DataTable.Rows[0]);
            }
            dataLoad();
        }
        void DarkMode()
        {
            Guna2Button[] DarkB = { MenuBTN, FolderBTN, FileBTN, TextBTN, SettingBTN, DeleteAll_BTN, DeleteBTN, RefreshBTN, infoBTN, SaveDataBTN, LoadDataBTN };
            Guna2Button[] DarkB2 = { EFolderBTN, DFolderBTN, EFileBTN, DFileBTN, ETextBTN, DTextBTN };
            for (int i = 0; i < DarkB2.Length; i++)
            {
                DarkB2[i].FillColor = Darkmode.DarkMode[1];
            }
            for (int i = 0; i < DarkB.Length; i++)
            {
                DarkB[i].FillColor = Darkmode.DarkMode[0];
                DarkB[i].CheckedState.FillColor = Darkmode.DarkMode[0];
                DarkB[i].HoverState.FillColor = Darkmode.DarkMode[1];

            }
            this.BackColor = Darkmode.DarkMode[0];
            MainMenu.FillColor = Darkmode.DarkMode[0];
            Menu2.FillColor = Darkmode.DarkMode[0];
            History_DataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            History_DataTable.BackgroundColor = Color.FromArgb(16, 16, 17);
        }
        void Notif(string msg)
        {
            Notification frm = new Notification();
            frm.showAlert(msg);
        }
        private void SetTextLanguages()
        {
            MenuBTN.Text = text.Menu;
            FolderBTN.Text = text.Folder;
            EFolderBTN.Text = text.Encrypt;
            EFileBTN.Text = text.Encrypt;
            ETextBTN.Text = text.Encrypt;
            DFolderBTN.Text = text.Decrypt;
            DFileBTN.Text = text.Decrypt;
            DTextBTN.Text = text.Decrypt;
            DTextBTN.Text = text.Decrypt;
            FileBTN.Text = text.File;
            TextBTN.Text = text.Text;
            yourChoseHistory.HeaderText = text.Your_Choice;
            passwordHistory.HeaderText = text.Password;
            resultHistory.HeaderText = text.Result;
            toolTip_BTNs.SetToolTip(RefreshBTN, text.Refresh);
            toolTip_BTNs.SetToolTip(DeleteBTN, text.Delete_Row);
            toolTip_BTNs.SetToolTip(DeleteAll_BTN, text.Delete_All_History);
            toolTip_BTNs.SetToolTip(SettingBTN, text.Setting);
            toolTip_BTNs.SetToolTip(SaveDataBTN, text.Save_History);
            toolTip_BTNs.SetToolTip(LoadDataBTN, text.Load_History);
            toolTip_BTNs.SetToolTip(infoBTN, text.Information);
        }
        /*--------- Func End ---------*/
        private void Form_Load(object sender, EventArgs e)
        {
            dataLoad();
            SetTextLanguages();
            if (Settings.Default.DarkMode)
            {
                DarkMode();
            }
            Settings.Default.Password_Enter = false;
            Settings.Default.Save();
        }
        private void Advanced_Activated(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                DarkMode();
            }
        }
        /*--------- Menus Start ---------*/
        /*------ Menu1 Start ------*/
        private void MenuBTN_Click(object sender, EventArgs e)
        {
            Guna2Button[] MenuBTNS = { MenuBTN, FolderBTN, FileBTN, TextBTN, EFolderBTN, DFolderBTN, EFileBTN, DFileBTN, ETextBTN, DTextBTN };
            foreach (var btn in MenuBTNS)
            {
                if (MenuBTN.Checked) btn.TextOffset = new Point(98, 0);
                else btn.TextOffset = new Point(5, 0);
            }
            MenuAnimation.Start();
        }
        private void MenuAnimation_Tick(object sender, EventArgs e)
        {
            if (MenuBTN.Checked && MainMenu.Width > 49)
            {
                MainMenu.Width -= 14;
            }
            else if (!MenuBTN.Checked && MainMenu.Width < 126)
            {
                MainMenu.Width += 14;
            }
            else
            {
                MenuAnimation.Stop();
            }
        }
        private void Menu_BTN_CheckedChanged(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            switch (button.Name)
            {
                case "FolderBTN":
                    FolderPanel.Visible = FolderBTN.Checked;
                    break;
                case "FileBTN":
                    FilePanel.Visible = FileBTN.Checked;
                    break;
                case "TextBTN":
                    TextPanel.Visible = TextBTN.Checked;
                    break;
            }
        }
        /*------ Folder Encryption & Decryption ------*/
        private void EFolderBTN_Click(object sender, EventArgs e)
        {
            Guna2Button Btn = (Guna2Button)sender;
            if (Btn.Name == "DFolderBTN")
            {
                FileDialog.Filter = "Advanced Lock Folder |*.alf";
                FileDialog.Title = "Open .alf Folder";
                FileDialog.ShowDialog();
            }
            else
            {
                ED frm = new ED();
                FolderBrowserDialog FolderD = new FolderBrowserDialog();
                FolderD.Description = "Select your folder";
                if (FolderD.ShowDialog() == DialogResult.OK)
                {
                    frm.show_ED(FolderD.SelectedPath, "EncryptFolder");
                }
            }
        }
        /*------ File Encryption & Decryption Start ------*/
        private void FileBTN_Click(object sender, EventArgs e)
        {
            Guna2Button Btn = (Guna2Button)sender;
            if (Btn.Name == "DFileBTN")
            {
                FileDialog.Filter = "Advanced Lock File |*.alo";
                FileDialog.Title = "Open .alo File";
                FileDialog.ShowDialog();
            }
            else
            {
                FileDialog.Filter = "All File |*.*";
                FileDialog.Title = "Select File";
                FileDialog.ShowDialog();
            }
        }
        private void FileDialog_FileOk(object sender, CancelEventArgs e)
        {
            ED frm = new ED();
            if (FileDialog.FileName.EndsWith(".alo"))
            {
                frm.show_ED(FileDialog.FileName, "Decryption");
            }
            else if (FileDialog.FileName.EndsWith(".alf"))
            {
                frm.show_ED(FileDialog.FileName, "DecryptFolder");
            }
            else
            {
                frm.show_ED(FileDialog.FileName, "Encryption");
            }
        }
        /*------ File Encryption & Decryption End ------*/
        /*------ Text Encryption & Decryption ------*/
        private void Text_ED_Click(object sender, EventArgs e)
        {
            Guna2Button Btn = (Guna2Button)sender;
            ED frm = new ED();
            if (Btn.Name == "DTextBTN")
            {
                frm.show_ED("", "TextD");
            }
            else
            {
                frm.show_ED("", "TextE");
            }
        }
        /*------ Menu1 End ------*/
        /*------ Menu2 Start ------*/
        /*------ Delete ------*/
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (History_DataTable.Rows.Count != 0)
            {
                History_DataTable.Rows.Remove(History_DataTable.CurrentRow);
            }
            dataSet1.WriteXml("History");
            File.WriteAllText("History", Encrypt_Decrypt.Encryption__Decryption__Text.Encryption(File.ReadAllText("History"), "Adv@n3eD KeY!"));
        }
        /*------ Refresh ------*/
        private void RefreshBTN_Click(object sender, EventArgs e)
        {
            HistoryRefresh();
        }
        /*------ Delete All ------*/
        private void DeleteAll_BTN_Click(object sender, EventArgs e)
        {
            dataSet1.Tables[0].Clear();
            dataSet1.WriteXml("History");
            File.WriteAllText("History", Encrypt_Decrypt.Encryption__Decryption__Text.Encryption(File.ReadAllText("History"), "Adv@n3eD KeY!"));
            HistoryRefresh();
        }
        /*------ Setting ------*/
        private void SettingBTN_Click(object sender, EventArgs e)
        {
            new Setting_Page().ShowDialog();
        }
        /*------ Export Data ------*/
        private void SaveDataBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog exportD = new SaveFileDialog();
            exportD.Filter = "Export File |*.alh";
            exportD.DefaultExt = "AL_Data";
            if (exportD.ShowDialog() == DialogResult.OK)
            {
                dataSet1.WriteXml(exportD.FileName);
                File.WriteAllText(exportD.FileName, Encrypt_Decrypt.Encryption__Decryption__Text.Encryption(File.ReadAllText(exportD.FileName), "Adv@n3eD KeY!"));
                Notif(text.Export_Is_Done);
            }
        }
        /*------ Import Data ------*/
        private void LoadDataBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImportD = new OpenFileDialog();
            ImportD.Filter = "Export File |*.alh";
            if (ImportD.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText("History", File.ReadAllText(ImportD.FileName));
                Notif(text.Import_Is_Done);
                HistoryRefresh();
            }
        }
        /*------ Info ------*/
        private void infoBTN_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
        /*------ Menu2 End ------*/
        /*--------- Menus End ---------*/
    }
}
