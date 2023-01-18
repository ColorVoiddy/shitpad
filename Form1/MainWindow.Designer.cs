namespace Form1
{
    partial class MainWindow
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveStateLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.rightClickMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.rightClickSelectAll = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.rightClickCut = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.rightClickEncryption = new System.Windows.Forms.MenuItem();
            this.rightClickEncrypt = new System.Windows.Forms.MenuItem();
            this.rightClickDecrypt = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.rightClickConvert = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.rightClickFromStringToBinary = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.rightClickFromBinaryToString = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuFileNew = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuFileSave = new System.Windows.Forms.MenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuFileOpen = new System.Windows.Forms.MenuItem();
            this.copyPathFileButton = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuSettings = new System.Windows.Forms.MenuItem();
            this.menuInfo = new System.Windows.Forms.MenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTipFilePath = new System.Windows.Forms.ToolTip(this.components);
            this.closeFileButton = new System.Windows.Forms.Button();
            this.characterLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File|*.txt|All files|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveStateLabel
            // 
            this.saveStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveStateLabel.AutoSize = true;
            this.saveStateLabel.Location = new System.Drawing.Point(9, 565);
            this.saveStateLabel.Name = "saveStateLabel";
            this.saveStateLabel.Size = new System.Drawing.Size(38, 13);
            this.saveStateLabel.TabIndex = 16;
            this.saveStateLabel.Text = "Saved";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // mainTextBox
            // 
            this.mainTextBox.AllowDrop = true;
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.Location = new System.Drawing.Point(122, 3);
            this.mainTextBox.MaxLength = 2147483647;
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainTextBox.Size = new System.Drawing.Size(767, 506);
            this.mainTextBox.TabIndex = 20;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            this.mainTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainTextBox_DragDrop);
            this.mainTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainTextBox_DragEnter);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.rightClickSelectAll,
            this.menuItem3,
            this.rightClickCut,
            this.menuItem4,
            this.menuItem7,
            this.rightClickEncryption,
            this.rightClickConvert});
            this.rightClickMenu.Popup += new System.EventHandler(this.rightClickMenu_Popup);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Delete";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // rightClickSelectAll
            // 
            this.rightClickSelectAll.Index = 2;
            this.rightClickSelectAll.Text = "Select All";
            this.rightClickSelectAll.Click += new System.EventHandler(this.rightClickSelectAll_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "Copy";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // rightClickCut
            // 
            this.rightClickCut.Index = 4;
            this.rightClickCut.Text = "Cut";
            this.rightClickCut.Click += new System.EventHandler(this.rightClickCut_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 5;
            this.menuItem4.Text = "Paste";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 6;
            this.menuItem7.Text = "-";
            // 
            // rightClickEncryption
            // 
            this.rightClickEncryption.Index = 7;
            this.rightClickEncryption.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.rightClickEncrypt,
            this.rightClickDecrypt,
            this.menuItem13});
            this.rightClickEncryption.Text = "Encryption";
            // 
            // rightClickEncrypt
            // 
            this.rightClickEncrypt.Index = 0;
            this.rightClickEncrypt.Text = "Encrypt ";
            this.rightClickEncrypt.Click += new System.EventHandler(this.rightClickEncrypt_Click);
            // 
            // rightClickDecrypt
            // 
            this.rightClickDecrypt.Index = 1;
            this.rightClickDecrypt.Text = "Decrypt";
            this.rightClickDecrypt.Click += new System.EventHandler(this.rightClickDecrypt_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.Text = "-";
            // 
            // rightClickConvert
            // 
            this.rightClickConvert.Index = 8;
            this.rightClickConvert.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12,
            this.menuItem15});
            this.rightClickConvert.Text = "Convert";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.rightClickFromStringToBinary});
            this.menuItem12.Text = "From string";
            // 
            // rightClickFromStringToBinary
            // 
            this.rightClickFromStringToBinary.Index = 0;
            this.rightClickFromStringToBinary.Text = "To binary";
            this.rightClickFromStringToBinary.Click += new System.EventHandler(this.rightClickFromStringToBinary_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 1;
            this.menuItem15.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.rightClickFromBinaryToString});
            this.menuItem15.Text = "From binary";
            // 
            // rightClickFromBinaryToString
            // 
            this.rightClickFromBinaryToString.Index = 0;
            this.rightClickFromBinaryToString.Text = "To string";
            this.rightClickFromBinaryToString.Click += new System.EventHandler(this.rightClickFromBinaryToString_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6,
            this.menuSettings,
            this.menuInfo});
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFileNew,
            this.menuItem8,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuItem11,
            this.menuFileOpen,
            this.copyPathFileButton});
            this.menuItem5.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Index = 0;
            this.menuFileNew.Text = "New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 1;
            this.menuItem8.Text = "-";
            // 
            // menuFileSave
            // 
            this.menuFileSave.Index = 2;
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Index = 3;
            this.menuFileSaveAs.Text = "Save as...";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 4;
            this.menuItem11.Text = "-";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Index = 5;
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // copyPathFileButton
            // 
            this.copyPathFileButton.Index = 6;
            this.copyPathFileButton.Text = "Copy Path";
            this.copyPathFileButton.Click += new System.EventHandler(this.copyPathFileButton_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Edit";
            // 
            // menuSettings
            // 
            this.menuSettings.Index = 2;
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuInfo
            // 
            this.menuInfo.Index = 3;
            this.menuInfo.Text = "Info";
            this.menuInfo.Click += new System.EventHandler(this.menuInfo_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 82);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // toolTipFilePath
            // 
            this.toolTipFilePath.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipFilePath_Popup);
            // 
            // closeFileButton
            // 
            this.closeFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeFileButton.Location = new System.Drawing.Point(9, 134);
            this.closeFileButton.Name = "closeFileButton";
            this.closeFileButton.Size = new System.Drawing.Size(104, 23);
            this.closeFileButton.TabIndex = 23;
            this.closeFileButton.Text = "Close File";
            this.closeFileButton.UseVisualStyleBackColor = true;
            this.closeFileButton.Click += new System.EventHandler(this.closeFileButton_Click);
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLabel.Location = new System.Drawing.Point(123, 513);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(91, 20);
            this.characterLabel.TabIndex = 24;
            this.characterLabel.Text = "Characters:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Form1.Properties.Resources.shitpadLogo;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.closeFileButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.saveStateLabel);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label saveStateLabel;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.SaveFileDialog saveFileDialog2;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        public System.Windows.Forms.ContextMenu rightClickMenu;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuFileNew;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuFileSave;
        private System.Windows.Forms.MenuItem menuFileSaveAs;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuFileOpen;
        private System.Windows.Forms.MenuItem menuItem6;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ToolTip toolTipFilePath;
        private System.Windows.Forms.MenuItem copyPathFileButton;
        private System.Windows.Forms.Button closeFileButton;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem rightClickEncrypt;
        private System.Windows.Forms.MenuItem rightClickDecrypt;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.MenuItem menuSettings;
        private System.Windows.Forms.MenuItem rightClickSelectAll;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem rightClickFromStringToBinary;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem rightClickFromBinaryToString;
        public System.Windows.Forms.Label characterLabel;
        public System.Windows.Forms.MenuItem rightClickEncryption;
        public System.Windows.Forms.MenuItem rightClickConvert;
        private System.Windows.Forms.MenuItem rightClickCut;
        private System.Windows.Forms.MenuItem menuInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

