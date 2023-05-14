
namespace Advanced_Lock.Forms
{
    partial class Notification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 7;
            this.Elipse.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NText
            // 
            this.NText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NText.Location = new System.Drawing.Point(5, 5);
            this.NText.Name = "NText";
            this.NText.Size = new System.Drawing.Size(362, 98);
            this.NText.TabIndex = 1;
            this.NText.Text = "Notification Text";
            this.NText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Notification
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(372, 108);
            this.Controls.Add(this.NText);
            this.Font = new System.Drawing.Font("Vazir", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label NText;
    }
}