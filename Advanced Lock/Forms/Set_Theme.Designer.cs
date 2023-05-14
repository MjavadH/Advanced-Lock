
namespace Advanced_Lock
{
    partial class Set_Theme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Set_Theme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DarkMode = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LightMode = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightMode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DarkMode
            // 
            this.DarkMode.BorderRadius = 10;
            this.DarkMode.Image = global::Advanced_Lock.Properties.Resources.Dark_Screen;
            resources.ApplyResources(this.DarkMode, "DarkMode");
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.ShadowDecoration.Parent = this.DarkMode;
            this.DarkMode.TabStop = false;
            this.DarkMode.Click += new System.EventHandler(this.DarkModeBTN_Click);
            // 
            // LightMode
            // 
            this.LightMode.BorderRadius = 10;
            this.LightMode.Image = global::Advanced_Lock.Properties.Resources.Light_Screen;
            resources.ApplyResources(this.LightMode, "LightMode");
            this.LightMode.Name = "LightMode";
            this.LightMode.ShadowDecoration.Parent = this.LightMode;
            this.LightMode.TabStop = false;
            this.LightMode.Click += new System.EventHandler(this.LightMode_BTN_Click);
            // 
            // Set_Theme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.LightMode);
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Set_Theme";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.DarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox DarkMode;
        private Guna.UI2.WinForms.Guna2PictureBox LightMode;
    }
}