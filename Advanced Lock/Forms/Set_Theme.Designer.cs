
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
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightMode)).BeginInit();
            this.panel_Title.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.DarkModeBTN_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.LightMode_BTN_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DarkMode
            // 
            this.DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.DarkMode.BorderRadius = 5;
            this.DarkMode.Image = global::Advanced_Lock.Properties.Resources.Dark_Screen;
            resources.ApplyResources(this.DarkMode, "DarkMode");
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.ShadowDecoration.Parent = this.DarkMode;
            this.DarkMode.TabStop = false;
            this.DarkMode.Click += new System.EventHandler(this.DarkModeBTN_Click);
            // 
            // LightMode
            // 
            this.LightMode.BorderRadius = 5;
            this.LightMode.Image = global::Advanced_Lock.Properties.Resources.Light_Screen;
            resources.ApplyResources(this.LightMode, "LightMode");
            this.LightMode.Name = "LightMode";
            this.LightMode.ShadowDecoration.Parent = this.LightMode;
            this.LightMode.TabStop = false;
            this.LightMode.Click += new System.EventHandler(this.LightMode_BTN_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Transparent;
            this.panel_Title.BorderRadius = 15;
            this.panel_Title.Controls.Add(this.label3);
            this.panel_Title.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel_Title, "panel_Title");
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.ShadowDecoration.Parent = this.panel_Title;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.guna2Panel2, "guna2Panel2");
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            // 
            // Set_Theme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
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
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox DarkMode;
        private Guna.UI2.WinForms.Guna2PictureBox LightMode;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}