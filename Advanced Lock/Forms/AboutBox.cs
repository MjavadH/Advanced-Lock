using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Lock
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            label_Version.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
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
