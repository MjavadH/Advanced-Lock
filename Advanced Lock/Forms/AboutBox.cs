using Advanced_Lock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Advanced_Lock.Class.Colers;

namespace Advanced_Lock
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            label_Version.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
        void DarkMode()
        {
            this.BackColor = Darkmode.DarkMode[0];
            this.ForeColor = Darkmode.DarkMode[3];
            panel_Title.FillColor = Darkmode.DarkMode[1];
            panel_Bottom.FillColor = Darkmode.DarkMode[1];
            button_OK.FillColor = Darkmode.DarkMode[4];
        }
        private void AboutBox_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                DarkMode();
            }
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel_Github.Text);
        }
    }
}
