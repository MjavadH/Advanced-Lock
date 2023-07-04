
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
            this.label_DarkMode = new System.Windows.Forms.Label();
            this.label_LightMode = new System.Windows.Forms.Label();
            this.label_Header = new System.Windows.Forms.Label();
            this.DarkMode = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LightMode = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_LightMode = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_DarkMode = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightMode)).BeginInit();
            this.panel_Title.SuspendLayout();
            this.panel_LightMode.SuspendLayout();
            this.panel_DarkMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DarkMode
            // 
            resources.ApplyResources(this.label_DarkMode, "label_DarkMode");
            this.label_DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.label_DarkMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label_DarkMode.Name = "label_DarkMode";
            this.label_DarkMode.Click += new System.EventHandler(this.DarkModeBTN_Click);
            // 
            // label_LightMode
            // 
            resources.ApplyResources(this.label_LightMode, "label_LightMode");
            this.label_LightMode.Name = "label_LightMode";
            this.label_LightMode.Click += new System.EventHandler(this.LightMode_BTN_Click);
            // 
            // label_Header
            // 
            resources.ApplyResources(this.label_Header, "label_Header");
            this.label_Header.Name = "label_Header";
            // 
            // DarkMode
            // 
            resources.ApplyResources(this.DarkMode, "DarkMode");
            this.DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.DarkMode.BorderRadius = 5;
            this.DarkMode.Image = global::Advanced_Lock.Properties.Resources.Dark_Screen;
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.ShadowDecoration.Parent = this.DarkMode;
            this.DarkMode.TabStop = false;
            this.DarkMode.Click += new System.EventHandler(this.DarkModeBTN_Click);
            // 
            // LightMode
            // 
            resources.ApplyResources(this.LightMode, "LightMode");
            this.LightMode.BorderRadius = 5;
            this.LightMode.Image = global::Advanced_Lock.Properties.Resources.Light_Screen;
            this.LightMode.Name = "LightMode";
            this.LightMode.ShadowDecoration.Parent = this.LightMode;
            this.LightMode.TabStop = false;
            this.LightMode.Click += new System.EventHandler(this.LightMode_BTN_Click);
            // 
            // panel_Title
            // 
            resources.ApplyResources(this.panel_Title, "panel_Title");
            this.panel_Title.BackColor = System.Drawing.Color.Transparent;
            this.panel_Title.BorderRadius = 15;
            this.panel_Title.Controls.Add(this.label_Header);
            this.panel_Title.FillColor = System.Drawing.Color.White;
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.ShadowDecoration.Parent = this.panel_Title;
            // 
            // panel_LightMode
            // 
            resources.ApplyResources(this.panel_LightMode, "panel_LightMode");
            this.panel_LightMode.BackColor = System.Drawing.Color.Transparent;
            this.panel_LightMode.BorderRadius = 15;
            this.panel_LightMode.Controls.Add(this.label_LightMode);
            this.panel_LightMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.panel_LightMode.Name = "panel_LightMode";
            this.panel_LightMode.ShadowDecoration.Parent = this.panel_LightMode;
            // 
            // panel_DarkMode
            // 
            resources.ApplyResources(this.panel_DarkMode, "panel_DarkMode");
            this.panel_DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.panel_DarkMode.BorderRadius = 15;
            this.panel_DarkMode.Controls.Add(this.label_DarkMode);
            this.panel_DarkMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.panel_DarkMode.Name = "panel_DarkMode";
            this.panel_DarkMode.ShadowDecoration.Parent = this.panel_DarkMode;
            // 
            // Set_Theme
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.panel_DarkMode);
            this.Controls.Add(this.panel_LightMode);
            this.Controls.Add(this.panel_Title);
            this.Controls.Add(this.LightMode);
            this.Controls.Add(this.DarkMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Set_Theme";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.DarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightMode)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_LightMode.ResumeLayout(false);
            this.panel_DarkMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_DarkMode;
        private System.Windows.Forms.Label label_LightMode;
        private System.Windows.Forms.Label label_Header;
        private Guna.UI2.WinForms.Guna2PictureBox DarkMode;
        private Guna.UI2.WinForms.Guna2PictureBox LightMode;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private Guna.UI2.WinForms.Guna2Panel panel_LightMode;
        private Guna.UI2.WinForms.Guna2Panel panel_DarkMode;
    }
}