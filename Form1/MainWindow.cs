using Form1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Form1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {            
            InitializeComponent();
            this.mainTextBox.ContextMenu = rightClickMenu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(Properties.Settings.Default.font == null)
            {
                Properties.Settings.Default.font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            if(Properties.Settings.Default.salt == null)
            {
                Properties.Settings.Default.salt = new byte[] { 1, 57, 250, 29, 132, 79, 56, 195, 234, 4, 221 };
            }
            this.mainTextBox.Font = Properties.Settings.Default.font;

            string filePath;
            if (Environment.GetCommandLineArgs().Length == 1)
            {
                ColorVoid.Add("New File", null, "");
            }
            else
            {
                filePath = Environment.GetCommandLineArgs()[1];
                string fileContent;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    fileContent = reader.ReadToEnd();
                    fileContent = fileContent.Replace("\n", Environment.NewLine);

                }
                ColorVoid.Add(filePath.Split('\\')[filePath.Split('\\').Length - 1], filePath, fileContent);
            }
                      
        }

        //Detect changes in the main text box
        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            // consoleBox.Text = ColorVoid.lineNumberUpdate(mainTextBox.Text);
            characterLabel.Text = "Characters: " + mainTextBox.Text.Length.ToString();
        }

        //Delete
        private void menuItem1_Click(object sender, EventArgs e)
        {
            ColorVoid.ReplaceSelected("");
        }

        //Copy
        private void menuItem3_Click(object sender, EventArgs e)
        {
                      
            if (mainTextBox.SelectedText != "")
            {
                Clipboard.SetText(mainTextBox.SelectedText);
            }
            else { }
            
        }

        //Paste
        private void menuItem4_Click(object sender, EventArgs e)
        {
            string targetString = Clipboard.GetText();
            int prevSel = mainTextBox.SelectionStart;
            mainTextBox.Text = mainTextBox.Text.Insert(mainTextBox.SelectionStart, targetString);
            mainTextBox.Select(prevSel, 0);
        }


        // WHEN RIGHT CLICK
        private void rightClickMenu_Popup(object sender, EventArgs e)
        {
            if (mainTextBox.Text.Substring(mainTextBox.SelectionStart, mainTextBox.SelectionLength) == "")
            {
                menuItem3.Enabled = false;
                rightClickEncryption.Enabled = false;
                rightClickConvert.Enabled = false;
                rightClickCut.Enabled = false;
                
            }
            else
            {
                menuItem3.Enabled = true;
                rightClickEncryption.Enabled = true;
                rightClickConvert.Enabled = true;
                rightClickCut.Enabled = true;

            }
        }
        //NEW FILE
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            ColorVoid.Add("New File",null,"");
        }
        //SAVE FILE
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            ColorVoid.Save();
        }
        //SAVE AS
        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }
        public void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ColorVoid.SaveAs(saveFileDialog1.FileName);
        }
        
        //OPEN FILE
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileContent;
            string filePath = openFileDialog1.FileName;
            using (StreamReader reader = new StreamReader(filePath))
            {
                fileContent = reader.ReadToEnd();
                fileContent = fileContent.Replace("\n", Environment.NewLine);

            }
            string fileName = filePath.Split('\\')[filePath.Split('\\').Length - 1];
            ColorVoid.Add(fileName,filePath,fileContent);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColorVoid.Replace(Globals.currentFile[0], new string[] { Globals.currentFile[0], Globals.currentFile[1], this.mainTextBox.Text });
           
            foreach(string[] file in Globals.loadedFileList)
            {
                if (file[0] == this.listBox1.GetItemText(this.listBox1.SelectedItem)){
                    Globals.currentFile = file;

                    Program.MainWindow1.Text = Globals.currentFile[0] + " - shitpad";
                    Program.MainWindow1.mainTextBox.Text = Globals.currentFile[2];
                }
            }
        }

        private void toolTipFilePath_Popup(object sender, PopupEventArgs e)
        {

        }

        private void copyPathFileButton_Click(object sender, EventArgs e)
        {
            if(Globals.currentFile[1] != null)
            {
                Clipboard.SetText(Globals.currentFile[1]);
            }
            else
            {
                var result = MessageBox.Show("File does not have an associated path. Save Now?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == System.Windows.Forms.DialogResult.Yes)
                {
                    ColorVoid.Save();
                }
            }
        }

        private void closeFileButton_Click(object sender, EventArgs e)
        {
            
            if (Globals.currentFile[1] == null)
            {
                var result = MessageBox.Show("File does not have an associated path. Save Now?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ColorVoid.Save();
                }
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                string fileContent;
                using (StreamReader reader = new StreamReader(Globals.currentFile[1]))
                {
                    fileContent = reader.ReadToEnd();
                    fileContent = fileContent.Replace("\n", Environment.NewLine);

                }                
                if (fileContent != Program.MainWindow1.mainTextBox.Text)
                {
                    var result = MessageBox.Show("File is not saved. Save Now?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        ColorVoid.Save();
                    }
                    if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            if(Program.MainWindow1.listBox1.Items.Count == 1)
            {
                System.Windows.Forms.Application.Exit();
            }
            Globals.loadedFileList.Remove(Globals.currentFile);
           
            Program.MainWindow1.listBox1.Items.Remove(Globals.currentFile[0]);
            Program.MainWindow1.listBox1.SelectedIndex = 0;
        }

        private void menuSettings_Click(object sender, EventArgs e)
        {           
            Program.SettingsWindow1.ShowDialog();
        }

        private void rightClickEncrypt_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.key == "" || Properties.Settings.Default.key == null)
            {
                MessageBox.Show("Please input a key.");
                Program.SettingsWindow1.ShowDialog();
            }
            else
            {             
                try
                {
                    ColorVoid.ReplaceSelected(StringCipher.EncryptStringAES(mainTextBox.SelectedText, Properties.Settings.Default.key));
                }
                catch (Exception) { MessageBox.Show("Please select valid text."); };            
            }
            
        }

        private void rightClickDecrypt_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.key == "" || Properties.Settings.Default.key == null)
            {
                MessageBox.Show("Please input a key.");
                Program.SettingsWindow1.ShowDialog();
            }
            else
            {              
                try
                {
                    ColorVoid.ReplaceSelected(StringCipher.DecryptStringAES(mainTextBox.SelectedText, Properties.Settings.Default.key));
                }
                catch (Exception ex) { MessageBox.Show("Please select valid text."); };               
            }
        }

        private void rightClickSelectAll_Click(object sender, EventArgs e)
        {
            
            mainTextBox.SelectAll();
        }

        private void mainTextBox_DragDrop(object sender, DragEventArgs e)
        {           
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);            
            foreach(string filePath in filePaths)
            {
                string fileContent;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    fileContent = reader.ReadToEnd();
                    fileContent = fileContent.Replace("\n", Environment.NewLine);
                }
                ColorVoid.Add(filePath.Split('\\')[filePath.Split('\\').Length - 1], filePath, fileContent);
            }           
        }

        private void mainTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers== Keys.Control && e.KeyCode == Keys.S)
            {
                ColorVoid.Save();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void rightClickFromStringToBinary_Click(object sender, EventArgs e)
        {
            ColorVoid.ReplaceSelected(ColorVoid.StringToBinary(mainTextBox.SelectedText));                          
        }

        private void rightClickFromBinaryToString_Click(object sender, EventArgs e)
        {
            try
            {
                ColorVoid.ReplaceSelected(ColorVoid.BinaryToString(mainTextBox.SelectedText));
            }
            catch (Exception) { MessageBox.Show("Invalid Binary data."); };
        }

        private void rightClickCut_Click(object sender, EventArgs e)
        {
            mainTextBox.Cut();
        }

        private void menuInfo_Click(object sender, EventArgs e)
        {
            Program.InfoWindow1.ShowDialog();
        }
    }

}
