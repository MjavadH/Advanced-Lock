
namespace Advanced_Lock
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_Made = new System.Windows.Forms.Label();
            this.panel_Title = new Guna.UI2.WinForms.Guna2Panel();
            this.image_AppIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_Bottom = new Guna.UI2.WinForms.Guna2Panel();
            this.label_inIran = new System.Windows.Forms.Label();
            this.label_Heart = new System.Windows.Forms.Label();
            this.button_OK = new Guna.UI2.WinForms.Guna2Button();
            this.label_E_and_D = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.linkLabel_Github = new System.Windows.Forms.LinkLabel();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_AppIcon)).BeginInit();
            this.panel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            resources.ApplyResources(this.label_Title, "label_Title");
            this.label_Title.Name = "label_Title";
            // 
            // label_Version
            // 
            resources.ApplyResources(this.label_Version, "label_Version");
            this.label_Version.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Version.Name = "label_Version";
            // 
            // label_Made
            // 
            resources.ApplyResources(this.label_Made, "label_Made");
            this.label_Made.Name = "label_Made";
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Transparent;
            this.panel_Title.BorderRadius = 10;
            this.panel_Title.Controls.Add(this.label_Version);
            this.panel_Title.Controls.Add(this.label_Title);
            this.panel_Title.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel_Title, "panel_Title");
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.ShadowDecoration.Parent = this.panel_Title;
            // 
            // image_AppIcon
            // 
            resources.ApplyResources(this.image_AppIcon, "image_AppIcon");
            this.image_AppIcon.Name = "image_AppIcon";
            this.image_AppIcon.ShadowDecoration.Parent = this.image_AppIcon;
            this.image_AppIcon.TabStop = false;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.Transparent;
            this.panel_Bottom.BorderRadius = 10;
            this.panel_Bottom.Controls.Add(this.label_inIran);
            this.panel_Bottom.Controls.Add(this.label_Heart);
            this.panel_Bottom.Controls.Add(this.button_OK);
            this.panel_Bottom.Controls.Add(this.label_Made);
            this.panel_Bottom.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel_Bottom, "panel_Bottom");
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.ShadowDecoration.Parent = this.panel_Bottom;
            // 
            // label_inIran
            // 
            resources.ApplyResources(this.label_inIran, "label_inIran");
            this.label_inIran.Name = "label_inIran";
            // 
            // label_Heart
            // 
            resources.ApplyResources(this.label_Heart, "label_Heart");
            this.label_Heart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label_Heart.Name = "label_Heart";
            // 
            // button_OK
            // 
            this.button_OK.BorderRadius = 5;
            this.button_OK.CheckedState.Parent = this.button_OK;
            this.button_OK.CustomImages.Parent = this.button_OK;
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_OK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.button_OK, "button_OK");
            this.button_OK.ForeColor = System.Drawing.Color.White;
            this.button_OK.HoverState.Parent = this.button_OK;
            this.button_OK.Name = "button_OK";
            this.button_OK.ShadowDecoration.Parent = this.button_OK;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_E_and_D
            // 
            resources.ApplyResources(this.label_E_and_D, "label_E_and_D");
            this.label_E_and_D.Name = "label_E_and_D";
            // 
            // label_Description
            // 
            resources.ApplyResources(this.label_Description, "label_Description");
            this.label_Description.Name = "label_Description";
            // 
            // linkLabel_Github
            // 
            resources.ApplyResources(this.linkLabel_Github, "linkLabel_Github");
            this.linkLabel_Github.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_Github.Name = "linkLabel_Github";
            this.linkLabel_Github.TabStop = true;
            this.linkLabel_Github.VisitedLinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Github_LinkClicked);
            // 
            // AboutBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.linkLabel_Github);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_E_and_D);
            this.Controls.Add(this.image_AppIcon);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AboutBox_Load);
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_AppIcon)).EndInit();
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Label label_Made;
        private Guna.UI2.WinForms.Guna2Panel panel_Title;
        private Guna.UI2.WinForms.Guna2PictureBox image_AppIcon;
        private Guna.UI2.WinForms.Guna2Panel panel_Bottom;
        private Guna.UI2.WinForms.Guna2Button button_OK;
        private System.Windows.Forms.Label label_inIran;
        private System.Windows.Forms.Label label_Heart;
        private System.Windows.Forms.Label label_E_and_D;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.LinkLabel linkLabel_Github;
    }
}
