namespace CMRev
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroButtonRemove = new MetroFramework.Controls.MetroButton();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.CheckBoxDIE = new MetroFramework.Controls.MetroCheckBox();
            this.metroButtonDIEpath = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxDIEpath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonDnSpy32path = new MetroFramework.Controls.MetroButton();
            this.TextBoxDnSpy32path = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonDnSpy64path = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxDnSpy64path = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonIDA32path = new MetroFramework.Controls.MetroButton();
            this.TextBoxIDA32path = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonIDA64path = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TextBoxIDA64path = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonRemove
            // 
            this.metroButtonRemove.BackColor = System.Drawing.Color.Maroon;
            this.metroButtonRemove.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonRemove.Location = new System.Drawing.Point(256, 509);
            this.metroButtonRemove.Name = "metroButtonRemove";
            this.metroButtonRemove.Size = new System.Drawing.Size(201, 48);
            this.metroButtonRemove.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonRemove.TabIndex = 58;
            this.metroButtonRemove.Text = "Remove from context menu";
            this.metroButtonRemove.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonRemove.UseSelectable = true;
            this.metroButtonRemove.Click += new System.EventHandler(this.metroButtonRemove_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.BackColor = System.Drawing.Color.Maroon;
            this.metroButtonAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonAdd.Location = new System.Drawing.Point(23, 509);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(201, 48);
            this.metroButtonAdd.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonAdd.TabIndex = 57;
            this.metroButtonAdd.Text = "Add to context menu (save)";
            this.metroButtonAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButtonAdd_Click);
            // 
            // CheckBoxDIE
            // 
            this.CheckBoxDIE.AutoSize = true;
            this.CheckBoxDIE.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.CheckBoxDIE.Location = new System.Drawing.Point(24, 391);
            this.CheckBoxDIE.Name = "CheckBoxDIE";
            this.CheckBoxDIE.Size = new System.Drawing.Size(216, 15);
            this.CheckBoxDIE.Style = MetroFramework.MetroColorStyle.Red;
            this.CheckBoxDIE.TabIndex = 56;
            this.CheckBoxDIE.Text = "Run DIE along with the decompiler";
            this.CheckBoxDIE.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CheckBoxDIE.UseSelectable = true;
            // 
            // metroButtonDIEpath
            // 
            this.metroButtonDIEpath.Location = new System.Drawing.Point(426, 366);
            this.metroButtonDIEpath.Name = "metroButtonDIEpath";
            this.metroButtonDIEpath.Size = new System.Drawing.Size(31, 19);
            this.metroButtonDIEpath.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonDIEpath.TabIndex = 55;
            this.metroButtonDIEpath.Text = "...";
            this.metroButtonDIEpath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonDIEpath.UseSelectable = true;
            this.metroButtonDIEpath.Click += new System.EventHandler(this.metroButtonDIEpath_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(23, 326);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 15);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel7.TabIndex = 54;
            this.metroLabel7.Text = "Detect It Easy";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBoxDIEpath
            // 
            // 
            // 
            // 
            this.TextBoxDIEpath.CustomButton.Image = null;
            this.TextBoxDIEpath.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.TextBoxDIEpath.CustomButton.Name = "";
            this.TextBoxDIEpath.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TextBoxDIEpath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxDIEpath.CustomButton.TabIndex = 1;
            this.TextBoxDIEpath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxDIEpath.CustomButton.UseSelectable = true;
            this.TextBoxDIEpath.CustomButton.Visible = false;
            this.TextBoxDIEpath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxDIEpath.Lines = new string[0];
            this.TextBoxDIEpath.Location = new System.Drawing.Point(23, 366);
            this.TextBoxDIEpath.MaxLength = 32767;
            this.TextBoxDIEpath.Multiline = true;
            this.TextBoxDIEpath.Name = "TextBoxDIEpath";
            this.TextBoxDIEpath.PasswordChar = '\0';
            this.TextBoxDIEpath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxDIEpath.SelectedText = "";
            this.TextBoxDIEpath.SelectionLength = 0;
            this.TextBoxDIEpath.SelectionStart = 0;
            this.TextBoxDIEpath.ShortcutsEnabled = true;
            this.TextBoxDIEpath.Size = new System.Drawing.Size(392, 19);
            this.TextBoxDIEpath.Style = MetroFramework.MetroColorStyle.Red;
            this.TextBoxDIEpath.TabIndex = 53;
            this.TextBoxDIEpath.Tag = "DIE";
            this.TextBoxDIEpath.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBoxDIEpath.UseSelectable = true;
            this.TextBoxDIEpath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxDIEpath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.White;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(23, 344);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(92, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel8.TabIndex = 52;
            this.metroLabel8.Text = "die.exe path";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonDnSpy32path
            // 
            this.metroButtonDnSpy32path.Location = new System.Drawing.Point(426, 289);
            this.metroButtonDnSpy32path.Name = "metroButtonDnSpy32path";
            this.metroButtonDnSpy32path.Size = new System.Drawing.Size(31, 19);
            this.metroButtonDnSpy32path.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonDnSpy32path.TabIndex = 51;
            this.metroButtonDnSpy32path.Text = "...";
            this.metroButtonDnSpy32path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonDnSpy32path.UseSelectable = true;
            this.metroButtonDnSpy32path.Click += new System.EventHandler(this.metroButtonDnSpy32path_Click);
            // 
            // TextBoxDnSpy32path
            // 
            // 
            // 
            // 
            this.TextBoxDnSpy32path.CustomButton.Image = null;
            this.TextBoxDnSpy32path.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.TextBoxDnSpy32path.CustomButton.Name = "";
            this.TextBoxDnSpy32path.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TextBoxDnSpy32path.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxDnSpy32path.CustomButton.TabIndex = 1;
            this.TextBoxDnSpy32path.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxDnSpy32path.CustomButton.UseSelectable = true;
            this.TextBoxDnSpy32path.CustomButton.Visible = false;
            this.TextBoxDnSpy32path.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxDnSpy32path.Lines = new string[0];
            this.TextBoxDnSpy32path.Location = new System.Drawing.Point(23, 289);
            this.TextBoxDnSpy32path.MaxLength = 32767;
            this.TextBoxDnSpy32path.Multiline = true;
            this.TextBoxDnSpy32path.Name = "TextBoxDnSpy32path";
            this.TextBoxDnSpy32path.PasswordChar = '\0';
            this.TextBoxDnSpy32path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxDnSpy32path.SelectedText = "";
            this.TextBoxDnSpy32path.SelectionLength = 0;
            this.TextBoxDnSpy32path.SelectionStart = 0;
            this.TextBoxDnSpy32path.ShortcutsEnabled = true;
            this.TextBoxDnSpy32path.Size = new System.Drawing.Size(392, 19);
            this.TextBoxDnSpy32path.Style = MetroFramework.MetroColorStyle.Red;
            this.TextBoxDnSpy32path.TabIndex = 50;
            this.TextBoxDnSpy32path.Tag = "dnSpy 32";
            this.TextBoxDnSpy32path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBoxDnSpy32path.UseSelectable = true;
            this.TextBoxDnSpy32path.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxDnSpy32path.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.White;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(23, 267);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "dnSpy32.exe path";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonDnSpy64path
            // 
            this.metroButtonDnSpy64path.Location = new System.Drawing.Point(426, 245);
            this.metroButtonDnSpy64path.Name = "metroButtonDnSpy64path";
            this.metroButtonDnSpy64path.Size = new System.Drawing.Size(31, 19);
            this.metroButtonDnSpy64path.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonDnSpy64path.TabIndex = 48;
            this.metroButtonDnSpy64path.Text = "...";
            this.metroButtonDnSpy64path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonDnSpy64path.UseSelectable = true;
            this.metroButtonDnSpy64path.Click += new System.EventHandler(this.metroButtonDnSpy64path_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.Location = new System.Drawing.Point(23, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 15);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel4.TabIndex = 47;
            this.metroLabel4.Text = ".NET";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBoxDnSpy64path
            // 
            // 
            // 
            // 
            this.TextBoxDnSpy64path.CustomButton.Image = null;
            this.TextBoxDnSpy64path.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.TextBoxDnSpy64path.CustomButton.Name = "";
            this.TextBoxDnSpy64path.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TextBoxDnSpy64path.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxDnSpy64path.CustomButton.TabIndex = 1;
            this.TextBoxDnSpy64path.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxDnSpy64path.CustomButton.UseSelectable = true;
            this.TextBoxDnSpy64path.CustomButton.Visible = false;
            this.TextBoxDnSpy64path.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxDnSpy64path.Lines = new string[0];
            this.TextBoxDnSpy64path.Location = new System.Drawing.Point(23, 245);
            this.TextBoxDnSpy64path.MaxLength = 32767;
            this.TextBoxDnSpy64path.Multiline = true;
            this.TextBoxDnSpy64path.Name = "TextBoxDnSpy64path";
            this.TextBoxDnSpy64path.PasswordChar = '\0';
            this.TextBoxDnSpy64path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxDnSpy64path.SelectedText = "";
            this.TextBoxDnSpy64path.SelectionLength = 0;
            this.TextBoxDnSpy64path.SelectionStart = 0;
            this.TextBoxDnSpy64path.ShortcutsEnabled = true;
            this.TextBoxDnSpy64path.Size = new System.Drawing.Size(392, 19);
            this.TextBoxDnSpy64path.Style = MetroFramework.MetroColorStyle.Red;
            this.TextBoxDnSpy64path.TabIndex = 46;
            this.TextBoxDnSpy64path.Tag = "dnSpy 64";
            this.TextBoxDnSpy64path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBoxDnSpy64path.UseSelectable = true;
            this.TextBoxDnSpy64path.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxDnSpy64path.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.White;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(23, 223);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(129, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel6.TabIndex = 45;
            this.metroLabel6.Text = "dnSpy64.exe path";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonIDA32path
            // 
            this.metroButtonIDA32path.Location = new System.Drawing.Point(426, 159);
            this.metroButtonIDA32path.Name = "metroButtonIDA32path";
            this.metroButtonIDA32path.Size = new System.Drawing.Size(31, 19);
            this.metroButtonIDA32path.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonIDA32path.TabIndex = 44;
            this.metroButtonIDA32path.Text = "...";
            this.metroButtonIDA32path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonIDA32path.UseSelectable = true;
            this.metroButtonIDA32path.Click += new System.EventHandler(this.metroButtonIDA32path_Click);
            // 
            // TextBoxIDA32path
            // 
            // 
            // 
            // 
            this.TextBoxIDA32path.CustomButton.Image = null;
            this.TextBoxIDA32path.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.TextBoxIDA32path.CustomButton.Name = "";
            this.TextBoxIDA32path.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TextBoxIDA32path.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxIDA32path.CustomButton.TabIndex = 1;
            this.TextBoxIDA32path.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxIDA32path.CustomButton.UseSelectable = true;
            this.TextBoxIDA32path.CustomButton.Visible = false;
            this.TextBoxIDA32path.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxIDA32path.Lines = new string[0];
            this.TextBoxIDA32path.Location = new System.Drawing.Point(23, 159);
            this.TextBoxIDA32path.MaxLength = 32767;
            this.TextBoxIDA32path.Multiline = true;
            this.TextBoxIDA32path.Name = "TextBoxIDA32path";
            this.TextBoxIDA32path.PasswordChar = '\0';
            this.TextBoxIDA32path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxIDA32path.SelectedText = "";
            this.TextBoxIDA32path.SelectionLength = 0;
            this.TextBoxIDA32path.SelectionStart = 0;
            this.TextBoxIDA32path.ShortcutsEnabled = true;
            this.TextBoxIDA32path.Size = new System.Drawing.Size(392, 19);
            this.TextBoxIDA32path.Style = MetroFramework.MetroColorStyle.Red;
            this.TextBoxIDA32path.TabIndex = 43;
            this.TextBoxIDA32path.Tag = "IDA 32";
            this.TextBoxIDA32path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBoxIDA32path.UseSelectable = true;
            this.TextBoxIDA32path.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxIDA32path.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.White;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(23, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "IDA32.exe path";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonIDA64path
            // 
            this.metroButtonIDA64path.Location = new System.Drawing.Point(426, 115);
            this.metroButtonIDA64path.Name = "metroButtonIDA64path";
            this.metroButtonIDA64path.Size = new System.Drawing.Size(31, 19);
            this.metroButtonIDA64path.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButtonIDA64path.TabIndex = 41;
            this.metroButtonIDA64path.Text = "...";
            this.metroButtonIDA64path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonIDA64path.UseSelectable = true;
            this.metroButtonIDA64path.Click += new System.EventHandler(this.metroButtonIDA64path_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.Location = new System.Drawing.Point(23, 75);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 15);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 40;
            this.metroLabel5.Text = "Native";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBoxIDA64path
            // 
            // 
            // 
            // 
            this.TextBoxIDA64path.CustomButton.Image = null;
            this.TextBoxIDA64path.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.TextBoxIDA64path.CustomButton.Name = "";
            this.TextBoxIDA64path.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TextBoxIDA64path.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxIDA64path.CustomButton.TabIndex = 1;
            this.TextBoxIDA64path.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxIDA64path.CustomButton.UseSelectable = true;
            this.TextBoxIDA64path.CustomButton.Visible = false;
            this.TextBoxIDA64path.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBoxIDA64path.Lines = new string[0];
            this.TextBoxIDA64path.Location = new System.Drawing.Point(23, 115);
            this.TextBoxIDA64path.MaxLength = 32767;
            this.TextBoxIDA64path.Multiline = true;
            this.TextBoxIDA64path.Name = "TextBoxIDA64path";
            this.TextBoxIDA64path.PasswordChar = '\0';
            this.TextBoxIDA64path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxIDA64path.SelectedText = "";
            this.TextBoxIDA64path.SelectionLength = 0;
            this.TextBoxIDA64path.SelectionStart = 0;
            this.TextBoxIDA64path.ShortcutsEnabled = true;
            this.TextBoxIDA64path.Size = new System.Drawing.Size(392, 19);
            this.TextBoxIDA64path.Style = MetroFramework.MetroColorStyle.Red;
            this.TextBoxIDA64path.TabIndex = 39;
            this.TextBoxIDA64path.Tag = "IDA 64";
            this.TextBoxIDA64path.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBoxIDA64path.UseSelectable = true;
            this.TextBoxIDA64path.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxIDA64path.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(23, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "IDA64.exe path";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CMRev.Properties.Resources._124909221;
            this.pictureBox1.Location = new System.Drawing.Point(23, 433);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // metroLink1
            // 
            this.metroLink1.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink1.Location = new System.Drawing.Point(84, 462);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(373, 26);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLink1.TabIndex = 63;
            this.metroLink1.Text = "Telegram";
            this.metroLink1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.metroLink2.Location = new System.Drawing.Point(84, 433);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(373, 23);
            this.metroLink2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLink2.TabIndex = 64;
            this.metroLink2.Text = "GitHub of CMRev";
            this.metroLink2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 580);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButtonRemove);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.CheckBoxDIE);
            this.Controls.Add(this.metroButtonDIEpath);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.TextBoxDIEpath);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroButtonDnSpy32path);
            this.Controls.Add(this.TextBoxDnSpy32path);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButtonDnSpy64path);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TextBoxDnSpy64path);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroButtonIDA32path);
            this.Controls.Add(this.TextBoxIDA32path);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButtonIDA64path);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.TextBoxIDA64path);
            this.Controls.Add(this.metroLabel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Context menu reversing";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonRemove;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
        private MetroFramework.Controls.MetroCheckBox CheckBoxDIE;
        private MetroFramework.Controls.MetroButton metroButtonDIEpath;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox TextBoxDIEpath;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton metroButtonDnSpy32path;
        private MetroFramework.Controls.MetroTextBox TextBoxDnSpy32path;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButtonDnSpy64path;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TextBoxDnSpy64path;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButtonIDA32path;
        private MetroFramework.Controls.MetroTextBox TextBoxIDA32path;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButtonIDA64path;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TextBoxIDA64path;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
    }
}

