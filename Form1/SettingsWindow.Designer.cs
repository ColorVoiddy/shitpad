namespace Form1
{
    partial class SettingsWindow
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
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelKey = new System.Windows.Forms.Label();
            this.saltLabel = new System.Windows.Forms.Label();
            this.saltTextBox = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(109, 37);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(331, 20);
            this.keyTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(12, 39);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(95, 13);
            this.labelKey.TabIndex = 2;
            this.labelKey.Text = "Key for encryption:";
            // 
            // saltLabel
            // 
            this.saltLabel.AutoSize = true;
            this.saltLabel.Location = new System.Drawing.Point(12, 15);
            this.saltLabel.Name = "saltLabel";
            this.saltLabel.Size = new System.Drawing.Size(95, 13);
            this.saltLabel.TabIndex = 7;
            this.saltLabel.Text = "Salt for encryption:";
            // 
            // saltTextBox
            // 
            this.saltTextBox.Location = new System.Drawing.Point(109, 12);
            this.saltTextBox.Name = "saltTextBox";
            this.saltTextBox.Size = new System.Drawing.Size(331, 20);
            this.saltTextBox.TabIndex = 8;
            // 
            // fontButton
            // 
            this.fontButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fontButton.Location = new System.Drawing.Point(108, 62);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(75, 23);
            this.fontButton.TabIndex = 9;
            this.fontButton.Text = "Change font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // defaultButton
            // 
            this.defaultButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultButton.Location = new System.Drawing.Point(351, 88);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(89, 23);
            this.defaultButton.TabIndex = 10;
            this.defaultButton.Text = "Default settings";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Font:";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defaultButton);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.saltTextBox);
            this.Controls.Add(this.saltLabel);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.keyTextBox);
            this.Name = "SettingsWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsWindow_FormClosing);
            this.Load += new System.EventHandler(this.SettingsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label saltLabel;
        public System.Windows.Forms.TextBox saltTextBox;
        public System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.Label label1;
    }
}