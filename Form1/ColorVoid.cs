using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Form1
{
    public class ColorVoid
    {
        public static string lineNumberUpdate(string text)
        {
            string resultString = "";
            string[] splitString = text.Split(new char[] { '\n', });
            int numOfLines = splitString.Length;
            for (int i = 1; i <= numOfLines; i++)
            {
                resultString += i + "\n";
            }
            return resultString;

        }
        public static void Save()
        {
            if (Globals.currentFile[1] != null)
            {
                using (StreamWriter writer = new StreamWriter(Globals.currentFile[1]))
                {
                    writer.Write(Program.MainWindow1.mainTextBox.Text);
                }
                Program.MainWindow1.saveStateLabel.Text = "Saved";


            }
            else
            {
                Program.MainWindow1.saveFileDialog1.ShowDialog();
            }
        }

        public static void SaveAs(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(Program.MainWindow1.mainTextBox.Text);
            }
            Globals.currentFile[1] = filePath;

            string _fileName = filePath.Split('\\')[filePath.Split('\\').Length - 1];
            bool original = false;
            while (original == false)
            {
                original = true;
                foreach (string[] file in Globals.loadedFileList)
                {
                    if (file[0] == _fileName)
                    {
                        original = false;
                        _fileName = file[0] + "I";
                    }
                }

            }
            int index = Program.MainWindow1.listBox1.Items.IndexOf(Globals.currentFile[0]);
            Globals.currentFile[0] = _fileName;
            Program.MainWindow1.listBox1.Items.RemoveAt(index);

            ColorVoid.Replace(Globals.currentFile[0], Globals.currentFile);
            Program.MainWindow1.saveStateLabel.Text = "Saved";
            Program.MainWindow1.listBox1.Items.Insert(index, Globals.currentFile[0]);
            Program.MainWindow1.listBox1.SelectedIndex= index;
        }



        public static void Add(string fileName, string filePath, string fileContent)
        {
            ColorVoid.Replace(Globals.currentFile[0], new string[] { Globals.currentFile[0], Globals.currentFile[1], Program.MainWindow1.mainTextBox.Text });

            string _fileName = fileName;

            if (!Globals.loadedFileList.Any())
            {

               
            }
            else
            {
                bool original = false;
                while (original == false)
                {
                    original = true;
                    foreach (string[] file in Globals.loadedFileList)
                    {
                        if (file[0] == _fileName)
                        {
                            original = false;
                            _fileName = file[0] + "I";
                        }
                    }

                }
              

            }
            // fileName, filePath, fileContent


            
            string[] cars2 = { _fileName, filePath, fileContent };
            
            Globals.currentFile = cars2;
            Globals.loadedFileList.Add(Globals.currentFile);           
            Program.MainWindow1.Text = Globals.currentFile[0] + " - shitpad";          
            Program.MainWindow1.listBox1.Items.Add(Globals.currentFile[0]);
            Program.MainWindow1.mainTextBox.Text = Globals.currentFile[2];

            Program.MainWindow1.characterLabel.Text = "Characters: " + Globals.currentFile[2].Length.ToString();
            Program.MainWindow1.listBox1.SelectedIndex = Program.MainWindow1.listBox1.Items.IndexOf(Globals.currentFile[0]);
           
            Program.MainWindow1.saveStateLabel.Text = "Saved";


        }
        public static void Replace(string fileNameToReplace, string[] fileReplaced)
        {
            foreach (string[] file in Globals.loadedFileList)
            {
                if (file[0] == fileNameToReplace)
                {
                    Globals.loadedFileList[Globals.loadedFileList.IndexOf(file)] = fileReplaced; break;
                }
            }
        }

        public static byte[] FromStringToByteArray(string value)
        {
            value = value.Replace("{", null);
            value = value.Replace("}", null);
            value = value.Replace(" ", null);
            string[] dog = value.Split(',');
            byte[] result = new byte[dog.Length];
            for(int i = 0; i < dog.Length; i++)
            {
                result[i] = Convert.ToByte(Convert.ToInt16(dog[i]));
            }

            return result;
        }

        public static string FromByteArrayToString(byte[] value)
        {
            string mid = "{";
            foreach(byte Byte in value)
            {
                mid = mid + Convert.ToString(Convert.ToInt16(Byte)) + ",";
            }
            mid = mid.Remove(mid.Length - 1) + "}";
            return mid;
            
        }
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
        public static void ReplaceSelected(string text)
        {
            string beforeString = Program.MainWindow1.mainTextBox.Text.Substring(0, 0 + Program.MainWindow1.mainTextBox.SelectionStart);        
            string afterString = Program.MainWindow1.mainTextBox.Text.Substring(Program.MainWindow1.mainTextBox.SelectionStart + Program.MainWindow1.mainTextBox.SelectionLength);
            int prevSel = Program.MainWindow1.mainTextBox.SelectionStart;

            Program.MainWindow1.mainTextBox.Text = beforeString + afterString;
            Program.MainWindow1.mainTextBox.Select(prevSel, 0);
            Program.MainWindow1.mainTextBox.Text = Program.MainWindow1.mainTextBox.Text.Insert(Program.MainWindow1.mainTextBox.SelectionStart, text);
        }
       
    }
}
    
    

