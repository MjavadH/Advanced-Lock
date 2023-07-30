using Advanced_Lock.Classes;
using Advanced_Lock.Properties;
using System;
using System.Reflection;
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
        public AllText text = new AllText();
        void DarkMode()
        {
            this.BackColor = Darkmode.DarkMode[0];
            this.ForeColor = Darkmode.DarkMode[3];
            panel_Title.FillColor = Darkmode.DarkMode[1];
            panel_Bottom.FillColor = Darkmode.DarkMode[1];
            button_OK.FillColor = Darkmode.DarkMode[4];
        }
        private void SetTextLanguages()
        {
            button_OK.Text = text.OK;
            label_E_and_D.Text = text.Application_Description;
            label_Description.Text = text.Developer_Description;
            if (Settings.Default.languages == "fa" || Settings.Default.languages == "ar")
            {
                label_Made.Text = text.In_Iran;
                label_inIran.Text = text.Made_With;
            }
            else
            {
                label_Made.Text = text.Made_With;
                label_inIran.Text = text.In_Iran;
            }
        }
        private void AboutBox_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DarkMode)
            {
                DarkMode();
            }
            SetTextLanguages();
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
