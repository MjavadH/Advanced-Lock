
namespace Advanced_Lock
{
    partial class ED
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ED));
            this.ED_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.AlertBox = new System.Windows.Forms.Label();
            this.Text_ED_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Result_ED_Text = new Guna.UI2.WinForms.Guna2TextBox();
            this.ED_Text_Text = new System.Windows.Forms.Label();
            this.Password_User = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordText = new System.Windows.Forms.Label();
            this.Line = new Guna.UI2.WinForms.Guna2Separator();
            this.UserSelected = new Guna.UI2.WinForms.Guna2TextBox();
            this.PathText = new System.Windows.Forms.Label();
            this.Cancel_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Progress_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Background_EFile = new System.ComponentModel.BackgroundWorker();
            this.backgroundProgress = new System.ComponentModel.BackgroundWorker();
            this.ED_Panel.SuspendLayout();
            this.Text_ED_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ED_Panel
            // 
            this.ED_Panel.Controls.Add(this.progressBar);
            this.ED_Panel.Controls.Add(this.AlertBox);
            this.ED_Panel.Controls.Add(this.Text_ED_Panel);
            this.ED_Panel.Controls.Add(this.Password_User);
            this.ED_Panel.Controls.Add(this.PasswordText);
            this.ED_Panel.Controls.Add(this.Line);
            this.ED_Panel.Controls.Add(this.UserSelected);
            this.ED_Panel.Controls.Add(this.PathText);
            this.ED_Panel.Controls.Add(this.Cancel_BTN);
            this.ED_Panel.Controls.Add(this.Progress_BTN);
            resources.ApplyResources(this.ED_Panel, "ED_Panel");
            this.ED_Panel.Name = "ED_Panel";
            this.ED_Panel.ShadowDecoration.Parent = this.ED_Panel;
            // 
            // progressBar
            // 
            this.progressBar.BorderRadius = 5;
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBar.Name = "progressBar";
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // AlertBox
            // 
            this.AlertBox.AutoEllipsis = true;
            resources.ApplyResources(this.AlertBox, "AlertBox");
            this.AlertBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.AlertBox.Name = "AlertBox";
            // 
            // Text_ED_Panel
            // 
            this.Text_ED_Panel.Controls.Add(this.Result_ED_Text);
            this.Text_ED_Panel.Controls.Add(this.ED_Text_Text);
            resources.ApplyResources(this.Text_ED_Panel, "Text_ED_Panel");
            this.Text_ED_Panel.Name = "Text_ED_Panel";
            this.Text_ED_Panel.ShadowDecoration.Parent = this.Text_ED_Panel;
            // 
            // Result_ED_Text
            // 
            this.Result_ED_Text.BorderRadius = 3;
            this.Result_ED_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Result_ED_Text.DefaultText = "";
            this.Result_ED_Text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Result_ED_Text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Result_ED_Text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Result_ED_Text.DisabledState.Parent = this.Result_ED_Text;
            this.Result_ED_Text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.Result_ED_Text, "Result_ED_Text");
            this.Result_ED_Text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Result_ED_Text.FocusedState.Parent = this.Result_ED_Text;
            this.Result_ED_Text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Result_ED_Text.HoverState.Parent = this.Result_ED_Text;
            this.Result_ED_Text.IconRight = global::Advanced_Lock.Properties.Resources.icons8_copy_48px;
            this.Result_ED_Text.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Result_ED_Text.IconRightOffset = new System.Drawing.Point(0, -17);
            this.Result_ED_Text.Name = "Result_ED_Text";
            this.Result_ED_Text.PasswordChar = '\0';
            this.Result_ED_Text.PlaceholderText = "";
            this.Result_ED_Text.ReadOnly = true;
            this.Result_ED_Text.SelectedText = "";
            this.Result_ED_Text.ShadowDecoration.Parent = this.Result_ED_Text;
            this.Result_ED_Text.TextOffset = new System.Drawing.Point(0, -2);
            this.Result_ED_Text.WordWrap = false;
            this.Result_ED_Text.IconRightClick += new System.EventHandler(this.Result_ED_Text_IconRightClick);
            // 
            // ED_Text_Text
            // 
            resources.ApplyResources(this.ED_Text_Text, "ED_Text_Text");
            this.ED_Text_Text.Name = "ED_Text_Text";
            // 
            // Password_User
            // 
            this.Password_User.AutoRoundedCorners = true;
            this.Password_User.BorderRadius = 21;
            this.Password_User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_User.DefaultText = "";
            this.Password_User.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_User.DisabledState.Parent = this.Password_User;
            this.Password_User.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.Password_User, "Password_User");
            this.Password_User.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_User.FocusedState.Parent = this.Password_User;
            this.Password_User.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_User.HoverState.Parent = this.Password_User;
            this.Password_User.IconRight = ((System.Drawing.Image)(resources.GetObject("Password_User.IconRight")));
            this.Password_User.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Password_User.IconRightOffset = new System.Drawing.Point(2, 0);
            this.Password_User.Name = "Password_User";
            this.Password_User.PasswordChar = '\0';
            this.Password_User.PlaceholderText = "insert password";
            this.Password_User.SelectedText = "";
            this.Password_User.ShadowDecoration.Parent = this.Password_User;
            this.Password_User.TextOffset = new System.Drawing.Point(0, -2);
            this.Password_User.UseSystemPasswordChar = true;
            this.Password_User.WordWrap = false;
            this.Password_User.IconRightClick += new System.EventHandler(this.Password_User_IconRightClick);
            // 
            // PasswordText
            // 
            resources.ApplyResources(this.PasswordText, "PasswordText");
            this.PasswordText.Name = "PasswordText";
            // 
            // Line
            // 
            resources.ApplyResources(this.Line, "Line");
            this.Line.Name = "Line";
            // 
            // UserSelected
            // 
            this.UserSelected.AutoRoundedCorners = true;
            this.UserSelected.BorderRadius = 21;
            this.UserSelected.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserSelected.DefaultText = "";
            this.UserSelected.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserSelected.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserSelected.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserSelected.DisabledState.Parent = this.UserSelected;
            this.UserSelected.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            resources.ApplyResources(this.UserSelected, "UserSelected");
            this.UserSelected.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserSelected.FocusedState.Parent = this.UserSelected;
            this.UserSelected.HideSelection = false;
            this.UserSelected.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserSelected.HoverState.Parent = this.UserSelected;
            this.UserSelected.Name = "UserSelected";
            this.UserSelected.PasswordChar = '\0';
            this.UserSelected.PlaceholderText = "";
            this.UserSelected.ReadOnly = true;
            this.UserSelected.SelectedText = "";
            this.UserSelected.ShadowDecoration.Parent = this.UserSelected;
            this.UserSelected.TabStop = false;
            this.UserSelected.TextOffset = new System.Drawing.Point(0, -2);
            this.UserSelected.WordWrap = false;
            // 
            // PathText
            // 
            resources.ApplyResources(this.PathText, "PathText");
            this.PathText.Name = "PathText";
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.AutoRoundedCorners = true;
            this.Cancel_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Cancel_BTN.BorderRadius = 21;
            this.Cancel_BTN.CheckedState.Parent = this.Cancel_BTN;
            this.Cancel_BTN.CustomImages.Parent = this.Cancel_BTN;
            this.Cancel_BTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            resources.ApplyResources(this.Cancel_BTN, "Cancel_BTN");
            this.Cancel_BTN.ForeColor = System.Drawing.Color.White;
            this.Cancel_BTN.HoverState.Parent = this.Cancel_BTN;
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.ShadowDecoration.Parent = this.Cancel_BTN;
            this.Cancel_BTN.Click += new System.EventHandler(this.Cancel_BTN_Click);
            // 
            // Progress_BTN
            // 
            this.Progress_BTN.AutoRoundedCorners = true;
            this.Progress_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Progress_BTN.BorderRadius = 21;
            this.Progress_BTN.CheckedState.Parent = this.Progress_BTN;
            this.Progress_BTN.CustomImages.Parent = this.Progress_BTN;
            this.Progress_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.Progress_BTN, "Progress_BTN");
            this.Progress_BTN.ForeColor = System.Drawing.Color.White;
            this.Progress_BTN.HoverState.Parent = this.Progress_BTN;
            this.Progress_BTN.Name = "Progress_BTN";
            this.Progress_BTN.ShadowDecoration.Parent = this.Progress_BTN;
            this.Progress_BTN.Click += new System.EventHandler(this.Progress_BTN_Click);
            // 
            // Background_EFile
            // 
            this.Background_EFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Background_EFile_DoWork);
            this.Background_EFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Background_EFile_RunWorkerCompleted);
            // 
            // backgroundProgress
            // 
            this.backgroundProgress.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundProgress_DoWork);
            // 
            // ED
            // 
            this.AcceptButton = this.Progress_BTN;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ED_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ED";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ED_FormClosing);
            this.Load += new System.EventHandler(this.ED_Load);
            this.ED_Panel.ResumeLayout(false);
            this.Text_ED_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel ED_Panel;
        private Guna.UI2.WinForms.Guna2TextBox UserSelected;
        private System.Windows.Forms.Label PathText;
        private Guna.UI2.WinForms.Guna2Button Cancel_BTN;
        private Guna.UI2.WinForms.Guna2Button Progress_BTN;
        private Guna.UI2.WinForms.Guna2TextBox Password_User;
        private System.Windows.Forms.Label PasswordText;
        private Guna.UI2.WinForms.Guna2Separator Line;
        private Guna.UI2.WinForms.Guna2Panel Text_ED_Panel;
        private Guna.UI2.WinForms.Guna2TextBox Result_ED_Text;
        private System.Windows.Forms.Label ED_Text_Text;
        private System.Windows.Forms.Label AlertBox;
        private System.ComponentModel.BackgroundWorker Background_EFile;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundProgress;
    }
}