using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class InfoWindow : Form
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        private void InfoWindow_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.textBox1.Select(this.textBox1.Text.Length, this.textBox1.Text.Length);
        }
    }
}
