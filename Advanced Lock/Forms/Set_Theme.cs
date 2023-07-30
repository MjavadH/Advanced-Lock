using Advanced_Lock.Classes;
using Advanced_Lock.Properties;
using System;
using System.Windows.Forms;

namespace Advanced_Lock
{
    public partial class Set_Theme : Form
    {
        public Set_Theme()
        {
            InitializeComponent();
            SetTextLanguages();
        }

        AllText text = new AllText();
        private void SetTextLanguages()
        {
            label_Header.Text = text.Select_Your_Theme;
            Submit_BTN.Text = text.Submit;
            label_DarkMode.Text = text.Dark_Mode;
            label_LightMode.Text = text.Light_Mode;
        }
        void StartApp()
        {
            if (string.IsNullOrEmpty(Settings.Default.ThemeCheck))
            {
                Settings.Default.ThemeCheck = "Off";
                Settings.Default.DarkMode = false;
            }
            Settings.Default.Save();
            Application.Restart();
        }
        /*--------- if user click dark mode ---------*/
        private void DarkModeBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.ThemeCheck = "On";
            Settings.Default.DarkMode = true;
            checkBox_DarkMode.Checked = true;
            checkBox_LightMode.Checked = false;
        }
        /*--------- if user click light mode ---------*/
        private void LightMode_BTN_Click(object sender, EventArgs e)
        {
            Settings.Default.ThemeCheck = "Off";
            Settings.Default.DarkMode = false;
            checkBox_DarkMode.Checked = false;
            checkBox_LightMode.Checked = true;
        }

        private void Submit_BTN_Click(object sender, EventArgs e)
        {
            StartApp();
        }
    }
}
