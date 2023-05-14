
namespace Advanced_Lock
{
    partial class Advanced
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advanced));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuAnimation = new System.Windows.Forms.Timer(this.components);
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.TextPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DTextBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ETextBTN = new Guna.UI2.WinForms.Guna2Button();
            this.TextBTN = new Guna.UI2.WinForms.Guna2Button();
            this.FilePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DFileBTN = new Guna.UI2.WinForms.Guna2Button();
            this.EFileBTN = new Guna.UI2.WinForms.Guna2Button();
            this.FileBTN = new Guna.UI2.WinForms.Guna2Button();
            this.FolderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DFolderBTN = new Guna.UI2.WinForms.Guna2Button();
            this.EFolderBTN = new Guna.UI2.WinForms.Guna2Button();
            this.FolderBTN = new Guna.UI2.WinForms.Guna2Button();
            this.MenuBTN = new Guna.UI2.WinForms.Guna2Button();
            this.dataSet1 = new System.Data.DataSet();
            this.HistoryTable = new System.Data.DataTable();
            this.UserSelected_name_DS = new System.Data.DataColumn();
            this.UserSelected_password_DS = new System.Data.DataColumn();
            this.User_Result = new System.Data.DataColumn();
            this.History_DataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.yourChoseHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu2 = new Guna.UI2.WinForms.Guna2Panel();
            this.infoBTN = new Guna.UI2.WinForms.Guna2Button();
            this.LoadDataBTN = new Guna.UI2.WinForms.Guna2Button();
            this.SaveDataBTN = new Guna.UI2.WinForms.Guna2Button();
            this.TelegramBTN = new Guna.UI2.WinForms.Guna2Button();
            this.SettingBTN = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteAll_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBTN = new Guna.UI2.WinForms.Guna2Button();
            this.RefreshBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.FilePanel.SuspendLayout();
            this.FolderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.History_DataTable)).BeginInit();
            this.Menu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuAnimation
            // 
            this.MenuAnimation.Interval = 1;
            this.MenuAnimation.Tick += new System.EventHandler(this.MenuAnimation_Tick);
            // 
            // FileDialog
            // 
            resources.ApplyResources(this.FileDialog, "FileDialog");
            this.FileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_FileOk);
            // 
            // MainMenu
            // 
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Controls.Add(this.TextPanel);
            this.MainMenu.Controls.Add(this.TextBTN);
            this.MainMenu.Controls.Add(this.FilePanel);
            this.MainMenu.Controls.Add(this.FileBTN);
            this.MainMenu.Controls.Add(this.FolderPanel);
            this.MainMenu.Controls.Add(this.FolderBTN);
            this.MainMenu.Controls.Add(this.MenuBTN);
            this.MainMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.MainMenu.ForeColor = System.Drawing.Color.White;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.ShadowDecoration.Depth = 40;
            this.MainMenu.ShadowDecoration.Enabled = true;
            this.MainMenu.ShadowDecoration.Parent = this.MainMenu;
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.DTextBTN);
            this.TextPanel.Controls.Add(this.ETextBTN);
            resources.ApplyResources(this.TextPanel, "TextPanel");
            this.TextPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.ShadowDecoration.Parent = this.TextPanel;
            // 
            // DTextBTN
            // 
            this.DTextBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.DTextBTN.CheckedState.Parent = this.DTextBTN;
            this.DTextBTN.CustomImages.Parent = this.DTextBTN;
            resources.ApplyResources(this.DTextBTN, "DTextBTN");
            this.DTextBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.DTextBTN.ForeColor = System.Drawing.Color.White;
            this.DTextBTN.HoverState.Parent = this.DTextBTN;
            this.DTextBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_padlock_48px;
            this.DTextBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DTextBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.DTextBTN.Name = "DTextBTN";
            this.DTextBTN.ShadowDecoration.Parent = this.DTextBTN;
            this.DTextBTN.Click += new System.EventHandler(this.Text_ED_Click);
            this.DTextBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // ETextBTN
            // 
            this.ETextBTN.BackColor = System.Drawing.Color.Transparent;
            this.ETextBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.ETextBTN.CheckedState.Parent = this.ETextBTN;
            this.ETextBTN.CustomImages.Parent = this.ETextBTN;
            resources.ApplyResources(this.ETextBTN, "ETextBTN");
            this.ETextBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.ETextBTN.ForeColor = System.Drawing.Color.White;
            this.ETextBTN.HoverState.Parent = this.ETextBTN;
            this.ETextBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_lock_48px_1;
            this.ETextBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ETextBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.ETextBTN.Name = "ETextBTN";
            this.ETextBTN.ShadowDecoration.Parent = this.ETextBTN;
            this.ETextBTN.Click += new System.EventHandler(this.Text_ED_Click);
            this.ETextBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // TextBTN
            // 
            this.TextBTN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.TextBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.TextBTN.CheckedState.Parent = this.TextBTN;
            this.TextBTN.CustomImages.Parent = this.TextBTN;
            resources.ApplyResources(this.TextBTN, "TextBTN");
            this.TextBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.TextBTN.ForeColor = System.Drawing.Color.White;
            this.TextBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.TextBTN.HoverState.Parent = this.TextBTN;
            this.TextBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_text_48px;
            this.TextBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.TextBTN.Name = "TextBTN";
            this.TextBTN.ShadowDecoration.Parent = this.TextBTN;
            this.TextBTN.CheckedChanged += new System.EventHandler(this.Menu_BTN_CheckedChanged);
            this.TextBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // FilePanel
            // 
            this.FilePanel.Controls.Add(this.DFileBTN);
            this.FilePanel.Controls.Add(this.EFileBTN);
            resources.ApplyResources(this.FilePanel, "FilePanel");
            this.FilePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.FilePanel.Name = "FilePanel";
            this.FilePanel.ShadowDecoration.Parent = this.FilePanel;
            // 
            // DFileBTN
            // 
            this.DFileBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.DFileBTN.CheckedState.Parent = this.DFileBTN;
            this.DFileBTN.CustomImages.Parent = this.DFileBTN;
            resources.ApplyResources(this.DFileBTN, "DFileBTN");
            this.DFileBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.DFileBTN.ForeColor = System.Drawing.Color.White;
            this.DFileBTN.HoverState.Parent = this.DFileBTN;
            this.DFileBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_unlocked_file_48px_1;
            this.DFileBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DFileBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.DFileBTN.Name = "DFileBTN";
            this.DFileBTN.ShadowDecoration.Parent = this.DFileBTN;
            this.DFileBTN.Click += new System.EventHandler(this.FileBTN_Click);
            this.DFileBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // EFileBTN
            // 
            this.EFileBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.EFileBTN.CheckedState.Parent = this.EFileBTN;
            this.EFileBTN.CustomImages.Parent = this.EFileBTN;
            resources.ApplyResources(this.EFileBTN, "EFileBTN");
            this.EFileBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.EFileBTN.ForeColor = System.Drawing.Color.White;
            this.EFileBTN.HoverState.Parent = this.EFileBTN;
            this.EFileBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_secured_file_48px;
            this.EFileBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EFileBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.EFileBTN.Name = "EFileBTN";
            this.EFileBTN.ShadowDecoration.Parent = this.EFileBTN;
            this.EFileBTN.Click += new System.EventHandler(this.FileBTN_Click);
            this.EFileBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // FileBTN
            // 
            this.FileBTN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.FileBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.FileBTN.CheckedState.Parent = this.FileBTN;
            this.FileBTN.CustomImages.Parent = this.FileBTN;
            resources.ApplyResources(this.FileBTN, "FileBTN");
            this.FileBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.FileBTN.ForeColor = System.Drawing.Color.White;
            this.FileBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.FileBTN.HoverState.Parent = this.FileBTN;
            this.FileBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_file_48px;
            this.FileBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FileBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.FileBTN.Name = "FileBTN";
            this.FileBTN.ShadowDecoration.Parent = this.FileBTN;
            this.FileBTN.CheckedChanged += new System.EventHandler(this.Menu_BTN_CheckedChanged);
            this.FileBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // FolderPanel
            // 
            this.FolderPanel.Controls.Add(this.DFolderBTN);
            this.FolderPanel.Controls.Add(this.EFolderBTN);
            resources.ApplyResources(this.FolderPanel, "FolderPanel");
            this.FolderPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.FolderPanel.Name = "FolderPanel";
            this.FolderPanel.ShadowDecoration.Parent = this.FolderPanel;
            // 
            // DFolderBTN
            // 
            this.DFolderBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.DFolderBTN.CheckedState.Parent = this.DFolderBTN;
            this.DFolderBTN.CustomImages.Parent = this.DFolderBTN;
            resources.ApplyResources(this.DFolderBTN, "DFolderBTN");
            this.DFolderBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.DFolderBTN.ForeColor = System.Drawing.Color.White;
            this.DFolderBTN.HoverState.Parent = this.DFolderBTN;
            this.DFolderBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_opened_folder_52px;
            this.DFolderBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DFolderBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.DFolderBTN.Name = "DFolderBTN";
            this.DFolderBTN.ShadowDecoration.Parent = this.DFolderBTN;
            this.DFolderBTN.Click += new System.EventHandler(this.EFolderBTN_Click);
            this.DFolderBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // EFolderBTN
            // 
            this.EFolderBTN.BackColor = System.Drawing.Color.Transparent;
            this.EFolderBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.EFolderBTN.CheckedState.Parent = this.EFolderBTN;
            this.EFolderBTN.CustomImages.Parent = this.EFolderBTN;
            resources.ApplyResources(this.EFolderBTN, "EFolderBTN");
            this.EFolderBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.EFolderBTN.ForeColor = System.Drawing.Color.White;
            this.EFolderBTN.HoverState.Parent = this.EFolderBTN;
            this.EFolderBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_private_folder_48px;
            this.EFolderBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EFolderBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.EFolderBTN.Name = "EFolderBTN";
            this.EFolderBTN.ShadowDecoration.Parent = this.EFolderBTN;
            this.EFolderBTN.Click += new System.EventHandler(this.EFolderBTN_Click);
            this.EFolderBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // FolderBTN
            // 
            this.FolderBTN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.FolderBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.FolderBTN.CheckedState.Parent = this.FolderBTN;
            this.FolderBTN.CustomImages.Parent = this.FolderBTN;
            resources.ApplyResources(this.FolderBTN, "FolderBTN");
            this.FolderBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.FolderBTN.ForeColor = System.Drawing.Color.White;
            this.FolderBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.FolderBTN.HoverState.Parent = this.FolderBTN;
            this.FolderBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_folder_48px;
            this.FolderBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FolderBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.FolderBTN.Name = "FolderBTN";
            this.FolderBTN.ShadowDecoration.Parent = this.FolderBTN;
            this.FolderBTN.CheckedChanged += new System.EventHandler(this.Menu_BTN_CheckedChanged);
            this.FolderBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // MenuBTN
            // 
            this.MenuBTN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.MenuBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.MenuBTN.CheckedState.Parent = this.MenuBTN;
            this.MenuBTN.CustomImages.Parent = this.MenuBTN;
            resources.ApplyResources(this.MenuBTN, "MenuBTN");
            this.MenuBTN.FillColor = System.Drawing.Color.Empty;
            this.MenuBTN.ForeColor = System.Drawing.Color.White;
            this.MenuBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.MenuBTN.HoverState.Parent = this.MenuBTN;
            this.MenuBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_menu_48px;
            this.MenuBTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MenuBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.MenuBTN.Name = "MenuBTN";
            this.MenuBTN.ShadowDecoration.Parent = this.MenuBTN;
            this.MenuBTN.Click += new System.EventHandler(this.MenuBTN_Click);
            this.MenuBTN.Resize += new System.EventHandler(this.MenuBTN_Resize);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "AdvancedLockData";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("");
            this.dataSet1.Namespace = "Encrypt_Decrypt";
            this.dataSet1.Prefix = "History";
            this.dataSet1.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.HistoryTable});
            // 
            // HistoryTable
            // 
            this.HistoryTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.UserSelected_name_DS,
            this.UserSelected_password_DS,
            this.User_Result});
            this.HistoryTable.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.HistoryTable.TableName = "History";
            // 
            // UserSelected_name_DS
            // 
            this.UserSelected_name_DS.ColumnName = "YourChose";
            // 
            // UserSelected_password_DS
            // 
            this.UserSelected_password_DS.ColumnName = "Password";
            // 
            // User_Result
            // 
            this.User_Result.ColumnName = "Result";
            // 
            // History_DataTable
            // 
            this.History_DataTable.AllowUserToAddRows = false;
            this.History_DataTable.AllowUserToDeleteRows = false;
            this.History_DataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.History_DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.History_DataTable.AutoGenerateColumns = false;
            this.History_DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.History_DataTable.BackgroundColor = System.Drawing.Color.White;
            this.History_DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.History_DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.History_DataTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.History_DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Vazir", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.History_DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.History_DataTable, "History_DataTable");
            this.History_DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.History_DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yourChoseHistory,
            this.passwordHistory,
            this.resultHistory});
            this.History_DataTable.DataMember = "History";
            this.History_DataTable.DataSource = this.dataSet1;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Vazir", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.History_DataTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.History_DataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.History_DataTable.EnableHeadersVisualStyles = false;
            this.History_DataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.History_DataTable.MultiSelect = false;
            this.History_DataTable.Name = "History_DataTable";
            this.History_DataTable.ReadOnly = true;
            this.History_DataTable.RowHeadersVisible = false;
            this.History_DataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.History_DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.History_DataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember;
            this.History_DataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(196)))));
            this.History_DataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.History_DataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.History_DataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.History_DataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.History_DataTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.History_DataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(177)))));
            this.History_DataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.History_DataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.History_DataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Vazir", 12F);
            this.History_DataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.History_DataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.History_DataTable.ThemeStyle.HeaderStyle.Height = 35;
            this.History_DataTable.ThemeStyle.ReadOnly = true;
            this.History_DataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(215)))));
            this.History_DataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.History_DataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Vazir", 12F);
            this.History_DataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.History_DataTable.ThemeStyle.RowsStyle.Height = 22;
            this.History_DataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(213)))), ((int)(((byte)(89)))));
            this.History_DataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // yourChoseHistory
            // 
            this.yourChoseHistory.DataPropertyName = "YourChose";
            resources.ApplyResources(this.yourChoseHistory, "yourChoseHistory");
            this.yourChoseHistory.Name = "yourChoseHistory";
            this.yourChoseHistory.ReadOnly = true;
            // 
            // passwordHistory
            // 
            this.passwordHistory.DataPropertyName = "Password";
            resources.ApplyResources(this.passwordHistory, "passwordHistory");
            this.passwordHistory.Name = "passwordHistory";
            this.passwordHistory.ReadOnly = true;
            // 
            // resultHistory
            // 
            this.resultHistory.DataPropertyName = "Result";
            resources.ApplyResources(this.resultHistory, "resultHistory");
            this.resultHistory.Name = "resultHistory";
            this.resultHistory.ReadOnly = true;
            // 
            // Menu2
            // 
            this.Menu2.Controls.Add(this.label1);
            this.Menu2.Controls.Add(this.infoBTN);
            this.Menu2.Controls.Add(this.LoadDataBTN);
            this.Menu2.Controls.Add(this.SaveDataBTN);
            this.Menu2.Controls.Add(this.TelegramBTN);
            this.Menu2.Controls.Add(this.SettingBTN);
            this.Menu2.Controls.Add(this.DeleteAll_BTN);
            this.Menu2.Controls.Add(this.DeleteBTN);
            this.Menu2.Controls.Add(this.RefreshBTN);
            resources.ApplyResources(this.Menu2, "Menu2");
            this.Menu2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.Menu2.Name = "Menu2";
            this.Menu2.ShadowDecoration.Depth = 40;
            this.Menu2.ShadowDecoration.Enabled = true;
            this.Menu2.ShadowDecoration.Parent = this.Menu2;
            // 
            // infoBTN
            // 
            this.infoBTN.CheckedState.Parent = this.infoBTN;
            this.infoBTN.CustomImages.Parent = this.infoBTN;
            resources.ApplyResources(this.infoBTN, "infoBTN");
            this.infoBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.infoBTN.ForeColor = System.Drawing.Color.White;
            this.infoBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.infoBTN.HoverState.Parent = this.infoBTN;
            this.infoBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_info_48px;
            this.infoBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.infoBTN.Name = "infoBTN";
            this.infoBTN.ShadowDecoration.Parent = this.infoBTN;
            this.infoBTN.Click += new System.EventHandler(this.infoBTN_Click);
            // 
            // LoadDataBTN
            // 
            this.LoadDataBTN.CheckedState.Parent = this.LoadDataBTN;
            this.LoadDataBTN.CustomImages.Parent = this.LoadDataBTN;
            resources.ApplyResources(this.LoadDataBTN, "LoadDataBTN");
            this.LoadDataBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LoadDataBTN.ForeColor = System.Drawing.Color.White;
            this.LoadDataBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.LoadDataBTN.HoverState.Parent = this.LoadDataBTN;
            this.LoadDataBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_download_48px;
            this.LoadDataBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.LoadDataBTN.Name = "LoadDataBTN";
            this.LoadDataBTN.ShadowDecoration.Parent = this.LoadDataBTN;
            this.LoadDataBTN.Click += new System.EventHandler(this.LoadDataBTN_Click);
            // 
            // SaveDataBTN
            // 
            this.SaveDataBTN.CheckedState.Parent = this.SaveDataBTN;
            this.SaveDataBTN.CustomImages.Parent = this.SaveDataBTN;
            resources.ApplyResources(this.SaveDataBTN, "SaveDataBTN");
            this.SaveDataBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.SaveDataBTN.ForeColor = System.Drawing.Color.White;
            this.SaveDataBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.SaveDataBTN.HoverState.Parent = this.SaveDataBTN;
            this.SaveDataBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_save_48px;
            this.SaveDataBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.SaveDataBTN.Name = "SaveDataBTN";
            this.SaveDataBTN.ShadowDecoration.Parent = this.SaveDataBTN;
            this.SaveDataBTN.Click += new System.EventHandler(this.SaveDataBTN_Click);
            // 
            // TelegramBTN
            // 
            this.TelegramBTN.CheckedState.Parent = this.TelegramBTN;
            this.TelegramBTN.CustomImages.Parent = this.TelegramBTN;
            resources.ApplyResources(this.TelegramBTN, "TelegramBTN");
            this.TelegramBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.TelegramBTN.ForeColor = System.Drawing.Color.White;
            this.TelegramBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.TelegramBTN.HoverState.Parent = this.TelegramBTN;
            this.TelegramBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_telegram_app_48px_1;
            this.TelegramBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.TelegramBTN.Name = "TelegramBTN";
            this.TelegramBTN.ShadowDecoration.Parent = this.TelegramBTN;
            this.TelegramBTN.Click += new System.EventHandler(this.TelegramBTN_Click);
            // 
            // SettingBTN
            // 
            this.SettingBTN.CheckedState.Parent = this.SettingBTN;
            this.SettingBTN.CustomImages.Parent = this.SettingBTN;
            resources.ApplyResources(this.SettingBTN, "SettingBTN");
            this.SettingBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.SettingBTN.ForeColor = System.Drawing.Color.White;
            this.SettingBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.SettingBTN.HoverState.Parent = this.SettingBTN;
            this.SettingBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_wrench_48px;
            this.SettingBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.SettingBTN.Name = "SettingBTN";
            this.SettingBTN.ShadowDecoration.Parent = this.SettingBTN;
            this.SettingBTN.Click += new System.EventHandler(this.SettingBTN_Click);
            // 
            // DeleteAll_BTN
            // 
            this.DeleteAll_BTN.CheckedState.Parent = this.DeleteAll_BTN;
            this.DeleteAll_BTN.CustomImages.Parent = this.DeleteAll_BTN;
            resources.ApplyResources(this.DeleteAll_BTN, "DeleteAll_BTN");
            this.DeleteAll_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.DeleteAll_BTN.ForeColor = System.Drawing.Color.White;
            this.DeleteAll_BTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.DeleteAll_BTN.HoverState.Parent = this.DeleteAll_BTN;
            this.DeleteAll_BTN.Image = global::Advanced_Lock.Properties.Resources.icons8_delete_table_96px;
            this.DeleteAll_BTN.ImageSize = new System.Drawing.Size(25, 25);
            this.DeleteAll_BTN.Name = "DeleteAll_BTN";
            this.DeleteAll_BTN.ShadowDecoration.Parent = this.DeleteAll_BTN;
            this.DeleteAll_BTN.Click += new System.EventHandler(this.DeleteAll_BTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.CheckedState.Parent = this.DeleteBTN;
            this.DeleteBTN.CustomImages.Parent = this.DeleteBTN;
            resources.ApplyResources(this.DeleteBTN, "DeleteBTN");
            this.DeleteBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.DeleteBTN.ForeColor = System.Drawing.Color.White;
            this.DeleteBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.DeleteBTN.HoverState.Parent = this.DeleteBTN;
            this.DeleteBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_trash_96px;
            this.DeleteBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.ShadowDecoration.Parent = this.DeleteBTN;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // RefreshBTN
            // 
            this.RefreshBTN.CheckedState.Parent = this.RefreshBTN;
            this.RefreshBTN.CustomImages.Parent = this.RefreshBTN;
            resources.ApplyResources(this.RefreshBTN, "RefreshBTN");
            this.RefreshBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.RefreshBTN.ForeColor = System.Drawing.Color.White;
            this.RefreshBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(166)))), ((int)(((byte)(0)))));
            this.RefreshBTN.HoverState.Parent = this.RefreshBTN;
            this.RefreshBTN.Image = global::Advanced_Lock.Properties.Resources.icons8_synchronize_96px;
            this.RefreshBTN.ImageSize = new System.Drawing.Size(25, 25);
            this.RefreshBTN.Name = "RefreshBTN";
            this.RefreshBTN.ShadowDecoration.Parent = this.RefreshBTN;
            this.RefreshBTN.Click += new System.EventHandler(this.RefreshBTN_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Advanced
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.History_DataTable);
            this.Controls.Add(this.Menu2);
            this.Controls.Add(this.MainMenu);
            this.Name = "Advanced";
            this.Activated += new System.EventHandler(this.Advanced_Activated);
            this.Load += new System.EventHandler(this.Form_Load);
            this.MainMenu.ResumeLayout(false);
            this.TextPanel.ResumeLayout(false);
            this.FilePanel.ResumeLayout(false);
            this.FolderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.History_DataTable)).EndInit();
            this.Menu2.ResumeLayout(false);
            this.Menu2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MenuAnimation;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private Guna.UI2.WinForms.Guna2Panel MainMenu;
        private Guna.UI2.WinForms.Guna2Panel TextPanel;
        private Guna.UI2.WinForms.Guna2Button DTextBTN;
        private Guna.UI2.WinForms.Guna2Button ETextBTN;
        private Guna.UI2.WinForms.Guna2Button TextBTN;
        private Guna.UI2.WinForms.Guna2Panel FilePanel;
        private Guna.UI2.WinForms.Guna2Button DFileBTN;
        private Guna.UI2.WinForms.Guna2Button EFileBTN;
        private Guna.UI2.WinForms.Guna2Button FileBTN;
        private Guna.UI2.WinForms.Guna2Panel FolderPanel;
        private Guna.UI2.WinForms.Guna2Button DFolderBTN;
        private Guna.UI2.WinForms.Guna2Button EFolderBTN;
        private Guna.UI2.WinForms.Guna2Button FolderBTN;
        private Guna.UI2.WinForms.Guna2Button MenuBTN;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable HistoryTable;
        private System.Data.DataColumn UserSelected_name_DS;
        private System.Data.DataColumn UserSelected_password_DS;
        private System.Data.DataColumn User_Result;
        private Guna.UI2.WinForms.Guna2DataGridView History_DataTable;
        private Guna.UI2.WinForms.Guna2Panel Menu2;
        private Guna.UI2.WinForms.Guna2Button RefreshBTN;
        private Guna.UI2.WinForms.Guna2Button DeleteBTN;
        private Guna.UI2.WinForms.Guna2Button DeleteAll_BTN;
        private Guna.UI2.WinForms.Guna2Button SettingBTN;
        private Guna.UI2.WinForms.Guna2Button infoBTN;
        private Guna.UI2.WinForms.Guna2Button TelegramBTN;
        private Guna.UI2.WinForms.Guna2Button SaveDataBTN;
        private Guna.UI2.WinForms.Guna2Button LoadDataBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn yourChoseHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultHistory;
        private System.Windows.Forms.Label label1;
    }
}

