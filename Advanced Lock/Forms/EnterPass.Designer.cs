
namespace Advanced_Lock.Forms
{
    partial class EnterPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterPass));
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            this.label1 = new System.Windows.Forms.Label();
            this.Box_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.OK_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Incorect = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Transition = new Guna.UI2.WinForms.Guna2Transition();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.Transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Name = "label1";
            // 
            // Box_password
            // 
            this.Box_password.AutoRoundedCorners = true;
            this.Box_password.BorderRadius = 14;
            this.Box_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Transition.SetDecoration(this.Box_password, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Box_password.DefaultText = "";
            this.Box_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Box_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Box_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Box_password.DisabledState.Parent = this.Box_password;
            this.Box_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Box_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Box_password.FocusedState.Parent = this.Box_password;
            resources.ApplyResources(this.Box_password, "Box_password");
            this.Box_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Box_password.HoverState.Parent = this.Box_password;
            this.Box_password.Name = "Box_password";
            this.Box_password.PasswordChar = '\0';
            this.Box_password.PlaceholderText = "";
            this.Box_password.SelectedText = "";
            this.Box_password.ShadowDecoration.Parent = this.Box_password;
            this.Box_password.TabStop = false;
            this.Box_password.TextOffset = new System.Drawing.Point(0, -1);
            this.Box_password.UseSystemPasswordChar = true;
            this.Box_password.WordWrap = false;
            // 
            // OK_BTN
            // 
            this.OK_BTN.AutoRoundedCorners = true;
            this.OK_BTN.BorderRadius = 14;
            this.OK_BTN.CheckedState.Parent = this.OK_BTN;
            this.OK_BTN.CustomImages.Parent = this.OK_BTN;
            this.Transition.SetDecoration(this.OK_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.OK_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.OK_BTN, "OK_BTN");
            this.OK_BTN.ForeColor = System.Drawing.Color.White;
            this.OK_BTN.HoverState.Parent = this.OK_BTN;
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.ShadowDecoration.Parent = this.OK_BTN;
            this.OK_BTN.Click += new System.EventHandler(this.OK_BTN_Click);
            // 
            // Incorect
            // 
            resources.ApplyResources(this.Incorect, "Incorect");
            this.Transition.SetDecoration(this.Incorect, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Incorect.ForeColor = System.Drawing.Color.Red;
            this.Incorect.Name = "Incorect";
            // 
            // Timer
            // 
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Transition
            // 
            this.Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Transition.DefaultAnimation = animation1;
            // 
            // EnterPass
            // 
            this.AcceptButton = this.OK_BTN;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.Incorect);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.Box_password);
            this.Controls.Add(this.label1);
            this.Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterPass";
            this.Load += new System.EventHandler(this.EnterPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Box_password;
        private Guna.UI2.WinForms.Guna2Button OK_BTN;
        private Guna.UI2.WinForms.Guna2Transition Transition;
        private System.Windows.Forms.Label Incorect;
        private System.Windows.Forms.Timer Timer;
    }
}