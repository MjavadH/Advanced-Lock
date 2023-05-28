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
        }
        void StartApp()
        {
            Settings.Default.Save();
            Application.Restart();
        }
        /*--------- if user click dark mode ---------*/
        private void DarkModeBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.ThemeCheck = "On";
            Settings.Default.DarkMode = true;
            StartApp();
        }
        /*--------- if user click light mode ---------*/
        private void LightMode_BTN_Click(object sender, EventArgs e)
        {
            Settings.Default.ThemeCheck = "Off";
            Settings.Default.DarkMode = false;
            StartApp();
        }
    }
}
