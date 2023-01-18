using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox= false;
            this.MaximizeBox= false;
            this.saltTextBox.Text = ColorVoid.FromByteArrayToString(Properties.Settings.Default.salt);

            this.keyTextBox.Text = Properties.Settings.Default.key;
            // this.numericUpDownFontSize.Value = Globals.fontSize;        
        }

        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Properties.Settings.Default.key = Program.SettingsWindow1.keyTextBox.Text;
            Program.MainWindow1.mainTextBox.Font = Properties.Settings.Default.font;
            if (this.saltTextBox.Text.Length != 0)
            {
                if (this.saltTextBox.Text[0] != '{' || this.saltTextBox.Text[this.saltTextBox.Text.Length - 1] != '}')
                {
                    MessageBox.Show("Please input a valid salt value.");

                }
                else
                {
                    try 
                    {
                        byte[] piss = ColorVoid.FromStringToByteArray(this.saltTextBox.Text);
                        if (piss.Length < 8)
                        {
                            
                            MessageBox.Show("Salt must be at least 8 bytes.");
                        }
                        else
                        {
                            Properties.Settings.Default.salt = piss;
                        }
                    }

                    catch (Exception) { MessageBox.Show("Please input a valid salt value."); }
                    
                }
            }
            else { MessageBox.Show("Salt value cannot be null"); }
          
            
            
        }


        private void fontButton_Click(object sender, EventArgs e)
        {
            var fontResult = this.fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                Properties.Settings.Default.font = this.fontDialog1.Font;
                if ( this.fontDialog1.Font.Name == "Comic Sans MS")
                {
                    MessageBox.Show("Literally what the fuck is wrong with you. Press ok to kill yourself.", "Bruh", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
             
                
            }
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            Properties.Settings.Default.key = null;
            this.keyTextBox.Text = Properties.Settings.Default.key;

            Properties.Settings.Default.salt = new byte[] { 25, 241, 64, 2, 59, 40, 195, 59, 200, 37, 85 };
            this.saltTextBox.Text = ColorVoid.FromByteArrayToString(Properties.Settings.Default.salt);

        }
    }
}
