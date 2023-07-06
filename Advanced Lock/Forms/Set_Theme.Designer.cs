
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
            this.panel_DarkMode = new Guna.UI2.WinForms.Guna2Panel();
            this.panelText_DarkMode = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_LightMode = new Guna.UI2.WinForms.Guna2Panel();
            this.panelText_LightMode = new Guna.UI2.WinForms.Guna2Panel();
            this.checkBox_DarkMode = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.checkBox_LightMode = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.Submit_BTN = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightMode)).BeginInit();
            this.panel_Title.SuspendLayout();
            this.panel_DarkMode.SuspendLayout();
            this.panelText_DarkMode.SuspendLayout();
            this.panel_LightMode.SuspendLayout();
            this.panelText_LightMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DarkMode
            // 
            this.label_DarkMode.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label_DarkMode, "label_DarkMode");
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
            this.DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.DarkMode.BorderRadius = 10;
            resources.ApplyResources(this.DarkMode, "DarkMode");
            this.DarkMode.Image = global::Advanced_Lock.Properties.Resources.Dark_Screen;
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.ShadowDecoration.Parent = this.DarkMode;
            this.DarkMode.TabStop = false;
            this.DarkMode.Click += new System.EventHandler(this.DarkModeBTN_Click);
            // 
            // LightMode
            // 
            this.LightMode.BackColor = System.Drawing.Color.Transparent;
            this.LightMode.BorderRadius = 10;
            resources.ApplyResources(this.LightMode, "LightMode");
            this.LightMode.Image = global::Advanced_Lock.Properties.Resources.Light_Screen;
            this.LightMode.Name = "LightMode";
            this.LightMode.ShadowDecoration.Parent = this.LightMode;
            this.LightMode.TabStop = false;
            this.LightMode.Click += new System.EventHandler(this.LightMode_BTN_Click);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Transparent;
            this.panel_Title.BorderRadius = 15;
            this.panel_Title.Controls.Add(this.label_Header);
            this.panel_Title.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel_Title, "panel_Title");
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.ShadowDecoration.Parent = this.panel_Title;
            // 
            // panel_DarkMode
            // 
            this.panel_DarkMode.BorderRadius = 15;
            this.panel_DarkMode.Controls.Add(this.DarkMode);
            this.panel_DarkMode.Controls.Add(this.panelText_DarkMode);
            this.panel_DarkMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            resources.ApplyResources(this.panel_DarkMode, "panel_DarkMode");
            this.panel_DarkMode.Name = "panel_DarkMode";
            this.panel_DarkMode.ShadowDecoration.Parent = this.panel_DarkMode;
            this.panel_DarkMode.Click += new System.EventHandler(this.DarkModeBTN_Click);
            // 
            // panelText_DarkMode
            // 
            this.panelText_DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.panelText_DarkMode.Controls.Add(this.checkBox_DarkMode);
            this.panelText_DarkMode.Controls.Add(this.label_DarkMode);
            resources.ApplyResources(this.panelText_DarkMode, "panelText_DarkMode");
            this.panelText_DarkMode.Name = "panelText_DarkMode";
            this.panelText_DarkMode.ShadowDecoration.Parent = this.panelText_DarkMode;
            this.panelText_DarkMode.Click += new System.EventHandler(this.DarkModeBTN_Click);
            // 
            // panel_LightMode
            // 
            this.panel_LightMode.BorderRadius = 15;
            this.panel_LightMode.Controls.Add(this.LightMode);
            this.panel_LightMode.Controls.Add(this.panelText_LightMode);
            this.panel_LightMode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            resources.ApplyResources(this.panel_LightMode, "panel_LightMode");
            this.panel_LightMode.Name = "panel_LightMode";
            this.panel_LightMode.ShadowDecoration.Parent = this.panel_LightMode;
            this.panel_LightMode.Click += new System.EventHandler(this.LightMode_BTN_Click);
            // 
            // panelText_LightMode
            // 
            this.panelText_LightMode.BackColor = System.Drawing.Color.Transparent;
            this.panelText_LightMode.Controls.Add(this.checkBox_LightMode);
            this.panelText_LightMode.Controls.Add(this.label_LightMode);
            resources.ApplyResources(this.panelText_LightMode, "panelText_LightMode");
            this.panelText_LightMode.Name = "panelText_LightMode";
            this.panelText_LightMode.ShadowDecoration.Parent = this.panelText_LightMode;
            this.panelText_LightMode.UseTransparentBackground = true;
            this.panelText_LightMode.Click += new System.EventHandler(this.LightMode_BTN_Click);
            // 
            // checkBox_DarkMode
            // 
            this.checkBox_DarkMode.Animated = true;
            this.checkBox_DarkMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.checkBox_DarkMode.CheckedState.BorderRadius = 8;
            this.checkBox_DarkMode.CheckedState.BorderThickness = 1;
            this.checkBox_DarkMode.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkBox_DarkMode.CheckedState.Parent = this.checkBox_DarkMode;
            resources.ApplyResources(this.checkBox_DarkMode, "checkBox_DarkMode");
            this.checkBox_DarkMode.Name = "checkBox_DarkMode";
            this.checkBox_DarkMode.ShadowDecoration.Parent = this.checkBox_DarkMode;
            this.checkBox_DarkMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox_DarkMode.UncheckedState.BorderRadius = 8;
            this.checkBox_DarkMode.UncheckedState.BorderThickness = 1;
            this.checkBox_DarkMode.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkBox_DarkMode.UncheckedState.Parent = this.checkBox_DarkMode;
            this.checkBox_DarkMode.Click += new System.EventHandler(this.DarkModeBTN_Click);
            // 
            // checkBox_LightMode
            // 
            this.checkBox_LightMode.Animated = true;
            this.checkBox_LightMode.Checked = true;
            this.checkBox_LightMode.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.checkBox_LightMode.CheckedState.BorderRadius = 8;
            this.checkBox_LightMode.CheckedState.BorderThickness = 1;
            this.checkBox_LightMode.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkBox_LightMode.CheckedState.Parent = this.checkBox_LightMode;
            this.checkBox_LightMode.CheckMarkColor = System.Drawing.Color.Black;
            this.checkBox_LightMode.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.checkBox_LightMode, "checkBox_LightMode");
            this.checkBox_LightMode.Name = "checkBox_LightMode";
            this.checkBox_LightMode.ShadowDecoration.Parent = this.checkBox_LightMode;
            this.checkBox_LightMode.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.checkBox_LightMode.UncheckedState.BorderRadius = 8;
            this.checkBox_LightMode.UncheckedState.BorderThickness = 1;
            this.checkBox_LightMode.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkBox_LightMode.UncheckedState.Parent = this.checkBox_LightMode;
            this.checkBox_LightMode.Click += new System.EventHandler(this.LightMode_BTN_Click);
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.BorderRadius = 10;
            this.Submit_BTN.CheckedState.Parent = this.Submit_BTN;
            this.Submit_BTN.CustomImages.Parent = this.Submit_BTN;
            this.Submit_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Submit_BTN, "Submit_BTN");
            this.Submit_BTN.ForeColor = System.Drawing.Color.White;
            this.Submit_BTN.HoverState.Parent = this.Submit_BTN;
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.ShadowDecoration.Parent = this.Submit_BTN;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // Set_Theme
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Submit_BTN);
            this.Controls.Add(this.panel_LightMode);
            this.Controls.Add(this.panel_DarkMode);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Set_Theme";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.DarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightMode)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_DarkMode.ResumeLayout(false);
            this.panelText_DarkMode.ResumeLayout(false);
            this.panel_LightMode.ResumeLayout(false);
            this.panelText_LightMode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_DarkMode;
        private System.Windows.Forms.Label label_LightMode;
        private System.Windows.Forms.Label label_Header;
        private Guna.UI2.WinForms.Guna2PictureBox DarkMode;
        private Guna.UI2.WinForms.Guna2PictureBox LightMode;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private Guna.UI2.WinForms.Guna2Panel panel_DarkMode;
        private Guna.UI2.WinForms.Guna2Panel panelText_DarkMode;
        private Guna.UI2.WinForms.Guna2Panel panel_LightMode;
        private Guna.UI2.WinForms.Guna2Panel panelText_LightMode;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkBox_DarkMode;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkBox_LightMode;
        private Guna.UI2.WinForms.Guna2Button Submit_BTN;
    }
}