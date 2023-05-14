
namespace Advanced_Lock.Forms
{
    partial class Setting_Page
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_Page));
            this.DarkModePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label_DarkM = new System.Windows.Forms.Label();
            this.DarkModePic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DarkMode_Toggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.SwitchLangPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_Lang = new System.Windows.Forms.Panel();
            this.SwitchLang_Toggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Lable_fa = new System.Windows.Forms.Label();
            this.label_en = new System.Windows.Forms.Label();
            this.label_Lang = new System.Windows.Forms.Label();
            this.LangPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Notifi_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label_notifi = new System.Windows.Forms.Label();
            this.NotifiPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Notifi_Toggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Sound_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label_Sound = new System.Windows.Forms.Label();
            this.SoundPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Sound_Toggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Password_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.OK_BTN = new System.Windows.Forms.PictureBox();
            this.Submit_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Box_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.PasswordPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.password_Toggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.timerOK = new System.Windows.Forms.Timer(this.components);
            this.TransitionOK = new Guna.UI2.WinForms.Guna2Transition();
            this.Config_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label_Config = new System.Windows.Forms.Label();
            this.CheckConfig_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.ConfigPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.DarkModePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DarkModePic)).BeginInit();
            this.SwitchLangPanel.SuspendLayout();
            this.panel_Lang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LangPic)).BeginInit();
            this.Notifi_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotifiPic)).BeginInit();
            this.Sound_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoundPic)).BeginInit();
            this.Password_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OK_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).BeginInit();
            this.Config_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DarkModePanel
            // 
            this.DarkModePanel.BackColor = System.Drawing.Color.Transparent;
            this.DarkModePanel.BorderRadius = 20;
            this.DarkModePanel.Controls.Add(this.label_DarkM);
            this.DarkModePanel.Controls.Add(this.DarkModePic);
            this.DarkModePanel.Controls.Add(this.DarkMode_Toggle);
            this.TransitionOK.SetDecoration(this.DarkModePanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DarkModePanel.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.DarkModePanel, "DarkModePanel");
            this.DarkModePanel.Name = "DarkModePanel";
            this.DarkModePanel.ShadowDecoration.BorderRadius = 20;
            this.DarkModePanel.ShadowDecoration.Depth = 8;
            this.DarkModePanel.ShadowDecoration.Enabled = true;
            this.DarkModePanel.ShadowDecoration.Parent = this.DarkModePanel;
            // 
            // label_DarkM
            // 
            this.TransitionOK.SetDecoration(this.label_DarkM, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label_DarkM, "label_DarkM");
            this.label_DarkM.Name = "label_DarkM";
            // 
            // DarkModePic
            // 
            this.TransitionOK.SetDecoration(this.DarkModePic, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.DarkModePic, "DarkModePic");
            this.DarkModePic.Image = global::Advanced_Lock.Properties.Resources.icons8_night_wind_96px;
            this.DarkModePic.Name = "DarkModePic";
            this.DarkModePic.ShadowDecoration.Parent = this.DarkModePic;
            this.DarkModePic.TabStop = false;
            // 
            // DarkMode_Toggle
            // 
            this.DarkMode_Toggle.Animated = true;
            this.DarkMode_Toggle.AutoRoundedCorners = true;
            this.DarkMode_Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DarkMode_Toggle.CheckedState.BorderRadius = 14;
            this.DarkMode_Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DarkMode_Toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.DarkMode_Toggle.CheckedState.InnerBorderRadius = 10;
            this.DarkMode_Toggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DarkMode_Toggle.CheckedState.Parent = this.DarkMode_Toggle;
            this.TransitionOK.SetDecoration(this.DarkMode_Toggle, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.DarkMode_Toggle, "DarkMode_Toggle");
            this.DarkMode_Toggle.Name = "DarkMode_Toggle";
            this.DarkMode_Toggle.ShadowDecoration.Parent = this.DarkMode_Toggle;
            this.DarkMode_Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DarkMode_Toggle.UncheckedState.BorderRadius = 14;
            this.DarkMode_Toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DarkMode_Toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.DarkMode_Toggle.UncheckedState.InnerBorderRadius = 10;
            this.DarkMode_Toggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.DarkMode_Toggle.UncheckedState.Parent = this.DarkMode_Toggle;
            this.DarkMode_Toggle.Click += new System.EventHandler(this.Toggles_Click);
            // 
            // SwitchLangPanel
            // 
            this.SwitchLangPanel.BackColor = System.Drawing.Color.Transparent;
            this.SwitchLangPanel.BorderRadius = 20;
            this.SwitchLangPanel.Controls.Add(this.panel_Lang);
            this.SwitchLangPanel.Controls.Add(this.label_Lang);
            this.SwitchLangPanel.Controls.Add(this.LangPic);
            this.TransitionOK.SetDecoration(this.SwitchLangPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SwitchLangPanel.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.SwitchLangPanel, "SwitchLangPanel");
            this.SwitchLangPanel.Name = "SwitchLangPanel";
            this.SwitchLangPanel.ShadowDecoration.BorderRadius = 20;
            this.SwitchLangPanel.ShadowDecoration.Depth = 8;
            this.SwitchLangPanel.ShadowDecoration.Enabled = true;
            this.SwitchLangPanel.ShadowDecoration.Parent = this.SwitchLangPanel;
            // 
            // panel_Lang
            // 
            this.panel_Lang.Controls.Add(this.SwitchLang_Toggle);
            this.panel_Lang.Controls.Add(this.Lable_fa);
            this.panel_Lang.Controls.Add(this.label_en);
            this.TransitionOK.SetDecoration(this.panel_Lang, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panel_Lang, "panel_Lang");
            this.panel_Lang.Name = "panel_Lang";
            // 
            // SwitchLang_Toggle
            // 
            this.SwitchLang_Toggle.Animated = true;
            this.SwitchLang_Toggle.AutoRoundedCorners = true;
            this.SwitchLang_Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SwitchLang_Toggle.CheckedState.BorderRadius = 14;
            this.SwitchLang_Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SwitchLang_Toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwitchLang_Toggle.CheckedState.InnerBorderRadius = 10;
            this.SwitchLang_Toggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SwitchLang_Toggle.CheckedState.Parent = this.SwitchLang_Toggle;
            this.TransitionOK.SetDecoration(this.SwitchLang_Toggle, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.SwitchLang_Toggle, "SwitchLang_Toggle");
            this.SwitchLang_Toggle.Name = "SwitchLang_Toggle";
            this.SwitchLang_Toggle.ShadowDecoration.Parent = this.SwitchLang_Toggle;
            this.SwitchLang_Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwitchLang_Toggle.UncheckedState.BorderRadius = 14;
            this.SwitchLang_Toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwitchLang_Toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwitchLang_Toggle.UncheckedState.InnerBorderRadius = 10;
            this.SwitchLang_Toggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.SwitchLang_Toggle.UncheckedState.Parent = this.SwitchLang_Toggle;
            this.SwitchLang_Toggle.Click += new System.EventHandler(this.ToggleSwitchLang_Click);
            // 
            // Lable_fa
            // 
            this.TransitionOK.SetDecoration(this.Lable_fa, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.Lable_fa, "Lable_fa");
            this.Lable_fa.Name = "Lable_fa";
            // 
            // label_en
            // 
            this.TransitionOK.SetDecoration(this.label_en, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label_en, "label_en");
            this.label_en.Name = "label_en";
            // 
            // label_Lang
            // 
            this.TransitionOK.SetDecoration(this.label_Lang, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label_Lang, "label_Lang");
            this.label_Lang.Name = "label_Lang";
            // 
            // LangPic
            // 
            this.TransitionOK.SetDecoration(this.LangPic, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.LangPic, "LangPic");
            this.LangPic.Image = global::Advanced_Lock.Properties.Resources.icons8_language_85px;
            this.LangPic.Name = "LangPic";
            this.LangPic.ShadowDecoration.Parent = this.LangPic;
            this.LangPic.TabStop = false;
            // 
            // Notifi_Panel
            // 
            this.Notifi_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Notifi_Panel.BorderRadius = 20;
            this.Notifi_Panel.Controls.Add(this.label_notifi);
            this.Notifi_Panel.Controls.Add(this.NotifiPic);
            this.Notifi_Panel.Controls.Add(this.Notifi_Toggle);
            this.TransitionOK.SetDecoration(this.Notifi_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Notifi_Panel.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Notifi_Panel, "Notifi_Panel");
            this.Notifi_Panel.Name = "Notifi_Panel";
            this.Notifi_Panel.ShadowDecoration.BorderRadius = 20;
            this.Notifi_Panel.ShadowDecoration.Depth = 8;
            this.Notifi_Panel.ShadowDecoration.Enabled = true;
            this.Notifi_Panel.ShadowDecoration.Parent = this.Notifi_Panel;
            // 
            // label_notifi
            // 
            this.TransitionOK.SetDecoration(this.label_notifi, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label_notifi, "label_notifi");
            this.label_notifi.Name = "label_notifi";
            // 
            // NotifiPic
            // 
            this.TransitionOK.SetDecoration(this.NotifiPic, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.NotifiPic, "NotifiPic");
            this.NotifiPic.Image = global::Advanced_Lock.Properties.Resources.icons8_info_popup_85px;
            this.NotifiPic.Name = "NotifiPic";
            this.NotifiPic.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.NotifiPic.ShadowDecoration.Parent = this.NotifiPic;
            this.NotifiPic.TabStop = false;
            // 
            // Notifi_Toggle
            // 
            this.Notifi_Toggle.Animated = true;
            this.Notifi_Toggle.AutoRoundedCorners = true;
            this.Notifi_Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Notifi_Toggle.CheckedState.BorderRadius = 14;
            this.Notifi_Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Notifi_Toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Notifi_Toggle.CheckedState.InnerBorderRadius = 10;
            this.Notifi_Toggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Notifi_Toggle.CheckedState.Parent = this.Notifi_Toggle;
            this.TransitionOK.SetDecoration(this.Notifi_Toggle, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.Notifi_Toggle, "Notifi_Toggle");
            this.Notifi_Toggle.Name = "Notifi_Toggle";
            this.Notifi_Toggle.ShadowDecoration.Parent = this.Notifi_Toggle;
            this.Notifi_Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Notifi_Toggle.UncheckedState.BorderRadius = 14;
            this.Notifi_Toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Notifi_Toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Notifi_Toggle.UncheckedState.InnerBorderRadius = 10;
            this.Notifi_Toggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Notifi_Toggle.UncheckedState.Parent = this.Notifi_Toggle;
            this.Notifi_Toggle.Click += new System.EventHandler(this.Toggles_Click);
            // 
            // Sound_Panel
            // 
            this.Sound_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Sound_Panel.BorderRadius = 20;
            this.Sound_Panel.Controls.Add(this.label_Sound);
            this.Sound_Panel.Controls.Add(this.SoundPic);
            this.Sound_Panel.Controls.Add(this.Sound_Toggle);
            this.TransitionOK.SetDecoration(this.Sound_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sound_Panel.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Sound_Panel, "Sound_Panel");
            this.Sound_Panel.Name = "Sound_Panel";
            this.Sound_Panel.ShadowDecoration.BorderRadius = 20;
            this.Sound_Panel.ShadowDecoration.Depth = 8;
            this.Sound_Panel.ShadowDecoration.Enabled = true;
            this.Sound_Panel.ShadowDecoration.Parent = this.Sound_Panel;
            // 
            // label_Sound
            // 
            this.TransitionOK.SetDecoration(this.label_Sound, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label_Sound, "label_Sound");
            this.label_Sound.Name = "label_Sound";
            // 
            // SoundPic
            // 
            this.TransitionOK.SetDecoration(this.SoundPic, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.SoundPic, "SoundPic");
            this.SoundPic.Image = global::Advanced_Lock.Properties.Resources.icons8_sound_85px;
            this.SoundPic.Name = "SoundPic";
            this.SoundPic.ShadowDecoration.Parent = this.SoundPic;
            this.SoundPic.TabStop = false;
            // 
            // Sound_Toggle
            // 
            this.Sound_Toggle.Animated = true;
            this.Sound_Toggle.AutoRoundedCorners = true;
            this.Sound_Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound_Toggle.CheckedState.BorderRadius = 14;
            this.Sound_Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound_Toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Sound_Toggle.CheckedState.InnerBorderRadius = 10;
            this.Sound_Toggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Sound_Toggle.CheckedState.Parent = this.Sound_Toggle;
            this.TransitionOK.SetDecoration(this.Sound_Toggle, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.Sound_Toggle, "Sound_Toggle");
            this.Sound_Toggle.Name = "Sound_Toggle";
            this.Sound_Toggle.ShadowDecoration.Parent = this.Sound_Toggle;
            this.Sound_Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sound_Toggle.UncheckedState.BorderRadius = 14;
            this.Sound_Toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sound_Toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Sound_Toggle.UncheckedState.InnerBorderRadius = 10;
            this.Sound_Toggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Sound_Toggle.UncheckedState.Parent = this.Sound_Toggle;
            this.Sound_Toggle.Click += new System.EventHandler(this.Toggles_Click);
            // 
            // Password_Panel
            // 
            this.Password_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Password_Panel.BorderRadius = 20;
            this.Password_Panel.Controls.Add(this.OK_BTN);
            this.Password_Panel.Controls.Add(this.Submit_BTN);
            this.Password_Panel.Controls.Add(this.Box_password);
            this.Password_Panel.Controls.Add(this.label_Password);
            this.Password_Panel.Controls.Add(this.PasswordPic);
            this.Password_Panel.Controls.Add(this.password_Toggle);
            this.TransitionOK.SetDecoration(this.Password_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Password_Panel.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Password_Panel, "Password_Panel");
            this.Password_Panel.Name = "Password_Panel";
            this.Password_Panel.ShadowDecoration.BorderRadius = 20;
            this.Password_Panel.ShadowDecoration.Depth = 8;
            this.Password_Panel.ShadowDecoration.Enabled = true;
            this.Password_Panel.ShadowDecoration.Parent = this.Password_Panel;
            // 
            // OK_BTN
            // 
            this.TransitionOK.SetDecoration(this.OK_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.OK_BTN.Image = global::Advanced_Lock.Properties.Resources.icons8_ok_30px;
            resources.ApplyResources(this.OK_BTN, "OK_BTN");
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.TabStop = false;
            // 
            // Submit_BTN
            // 
            this.Submit_BTN.BorderRadius = 10;
            this.Submit_BTN.CheckedState.Parent = this.Submit_BTN;
            this.Submit_BTN.CustomImages.Parent = this.Submit_BTN;
            this.TransitionOK.SetDecoration(this.Submit_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Submit_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.Submit_BTN, "Submit_BTN");
            this.Submit_BTN.ForeColor = System.Drawing.Color.White;
            this.Submit_BTN.HoverState.Parent = this.Submit_BTN;
            this.Submit_BTN.Name = "Submit_BTN";
            this.Submit_BTN.ShadowDecoration.Parent = this.Submit_BTN;
            this.Submit_BTN.Click += new System.EventHandler(this.Submit_BTN_Click);
            // 
            // Box_password
            // 
            this.Box_password.AutoRoundedCorners = true;
            this.Box_password.BorderRadius = 14;
            this.Box_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TransitionOK.SetDecoration(this.Box_password, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.Box_password.IconRight = global::Advanced_Lock.Properties.Resources.eye;
            this.Box_password.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.Box_password.Name = "Box_password";
            this.Box_password.PasswordChar = '\0';
            this.Box_password.PlaceholderText = "";
            this.Box_password.SelectedText = "";
            this.Box_password.ShadowDecoration.Parent = this.Box_password;
            this.Box_password.TabStop = false;
            this.Box_password.TextOffset = new System.Drawing.Point(0, -1);
            this.Box_password.UseSystemPasswordChar = true;
            this.Box_password.WordWrap = false;
            this.Box_password.IconRightClick += new System.EventHandler(this.Box_password_IconRightClick);
            // 
            // label_Password
            // 
            this.TransitionOK.SetDecoration(this.label_Password, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label_Password, "label_Password");
            this.label_Password.Name = "label_Password";
            // 
            // PasswordPic
            // 
            this.TransitionOK.SetDecoration(this.PasswordPic, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.PasswordPic, "PasswordPic");
            this.PasswordPic.Image = global::Advanced_Lock.Properties.Resources.icons8_safe_85px;
            this.PasswordPic.Name = "PasswordPic";
            this.PasswordPic.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.PasswordPic.ShadowDecoration.Parent = this.PasswordPic;
            this.PasswordPic.TabStop = false;
            // 
            // password_Toggle
            // 
            this.password_Toggle.Animated = true;
            this.password_Toggle.AutoRoundedCorners = true;
            this.password_Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_Toggle.CheckedState.BorderRadius = 14;
            this.password_Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_Toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.password_Toggle.CheckedState.InnerBorderRadius = 10;
            this.password_Toggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.password_Toggle.CheckedState.Parent = this.password_Toggle;
            this.TransitionOK.SetDecoration(this.password_Toggle, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.password_Toggle, "password_Toggle");
            this.password_Toggle.Name = "password_Toggle";
            this.password_Toggle.ShadowDecoration.Parent = this.password_Toggle;
            this.password_Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.password_Toggle.UncheckedState.BorderRadius = 14;
            this.password_Toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.password_Toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.password_Toggle.UncheckedState.InnerBorderRadius = 10;
            this.password_Toggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.password_Toggle.UncheckedState.Parent = this.password_Toggle;
            this.password_Toggle.CheckedChanged += new System.EventHandler(this.password_Toggle_CheckedChanged);
            this.password_Toggle.Click += new System.EventHandler(this.Toggles_Click);
            // 
            // timerOK
            // 
            this.timerOK.Interval = 2000;
            this.timerOK.Tick += new System.EventHandler(this.timerOK_Tick);
            // 
            // TransitionOK
            // 
            this.TransitionOK.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.TransitionOK.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.TransitionOK.DefaultAnimation = animation2;
            // 
            // Config_Panel
            // 
            this.Config_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Config_Panel.BorderRadius = 20;
            this.Config_Panel.Controls.Add(this.label_Config);
            this.Config_Panel.Controls.Add(this.CheckConfig_BTN);
            this.Config_Panel.Controls.Add(this.ConfigPic);
            this.TransitionOK.SetDecoration(this.Config_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Config_Panel.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Config_Panel, "Config_Panel");
            this.Config_Panel.Name = "Config_Panel";
            this.Config_Panel.ShadowDecoration.BorderRadius = 20;
            this.Config_Panel.ShadowDecoration.Depth = 8;
            this.Config_Panel.ShadowDecoration.Enabled = true;
            this.Config_Panel.ShadowDecoration.Parent = this.Config_Panel;
            // 
            // label_Config
            // 
            this.TransitionOK.SetDecoration(this.label_Config, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label_Config, "label_Config");
            this.label_Config.Name = "label_Config";
            // 
            // CheckConfig_BTN
            // 
            this.CheckConfig_BTN.BorderRadius = 10;
            this.CheckConfig_BTN.CheckedState.Parent = this.CheckConfig_BTN;
            this.CheckConfig_BTN.CustomImages.Parent = this.CheckConfig_BTN;
            this.TransitionOK.SetDecoration(this.CheckConfig_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CheckConfig_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.CheckConfig_BTN, "CheckConfig_BTN");
            this.CheckConfig_BTN.ForeColor = System.Drawing.Color.White;
            this.CheckConfig_BTN.HoverState.Parent = this.CheckConfig_BTN;
            this.CheckConfig_BTN.Name = "CheckConfig_BTN";
            this.CheckConfig_BTN.ShadowDecoration.Parent = this.CheckConfig_BTN;
            this.CheckConfig_BTN.Click += new System.EventHandler(this.CheckConfig_BTN_Click);
            // 
            // ConfigPic
            // 
            this.TransitionOK.SetDecoration(this.ConfigPic, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.ConfigPic, "ConfigPic");
            this.ConfigPic.Image = global::Advanced_Lock.Properties.Resources.icons8_administrative_tools_96px;
            this.ConfigPic.Name = "ConfigPic";
            this.ConfigPic.ShadowDecoration.Parent = this.ConfigPic;
            this.ConfigPic.TabStop = false;
            // 
            // Setting_Page
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.SwitchLangPanel);
            this.Controls.Add(this.Config_Panel);
            this.Controls.Add(this.Sound_Panel);
            this.Controls.Add(this.Password_Panel);
            this.Controls.Add(this.Notifi_Panel);
            this.Controls.Add(this.DarkModePanel);
            this.TransitionOK.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting_Page";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Setting_Page_Load);
            this.DarkModePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DarkModePic)).EndInit();
            this.SwitchLangPanel.ResumeLayout(false);
            this.panel_Lang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LangPic)).EndInit();
            this.Notifi_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NotifiPic)).EndInit();
            this.Sound_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoundPic)).EndInit();
            this.Password_Panel.ResumeLayout(false);
            this.Password_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OK_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).EndInit();
            this.Config_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConfigPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel DarkModePanel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch DarkMode_Toggle;
        private Guna.UI2.WinForms.Guna2PictureBox DarkModePic;
        private Guna.UI2.WinForms.Guna2Panel SwitchLangPanel;
        private Guna.UI2.WinForms.Guna2PictureBox LangPic;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SwitchLang_Toggle;
        private System.Windows.Forms.Label Lable_fa;
        private System.Windows.Forms.Label label_en;
        private System.Windows.Forms.Label label_DarkM;
        private System.Windows.Forms.Panel panel_Lang;
        private System.Windows.Forms.Label label_Lang;
        private Guna.UI2.WinForms.Guna2Panel Notifi_Panel;
        private System.Windows.Forms.Label label_notifi;
        private Guna.UI2.WinForms.Guna2PictureBox NotifiPic;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Notifi_Toggle;
        private Guna.UI2.WinForms.Guna2Panel Sound_Panel;
        private System.Windows.Forms.Label label_Sound;
        private Guna.UI2.WinForms.Guna2PictureBox SoundPic;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Sound_Toggle;
        private Guna.UI2.WinForms.Guna2Panel Password_Panel;
        private System.Windows.Forms.Label label_Password;
        private Guna.UI2.WinForms.Guna2PictureBox PasswordPic;
        private Guna.UI2.WinForms.Guna2ToggleSwitch password_Toggle;
        private Guna.UI2.WinForms.Guna2TextBox Box_password;
        private Guna.UI2.WinForms.Guna2Button Submit_BTN;
        private System.Windows.Forms.PictureBox OK_BTN;
        private Guna.UI2.WinForms.Guna2Transition TransitionOK;
        private System.Windows.Forms.Timer timerOK;
        private Guna.UI2.WinForms.Guna2Panel Config_Panel;
        private System.Windows.Forms.Label label_Config;
        private Guna.UI2.WinForms.Guna2PictureBox ConfigPic;
        private Guna.UI2.WinForms.Guna2Button CheckConfig_BTN;
    }
}