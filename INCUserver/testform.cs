using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace INCUserver
{
    public partial class testform : Form
    {
        public testform()
        {
            InitializeComponent();
        }

        private void testform_Load(object sender, EventArgs e)
        {
          
           
        }
        private void AddText(string s)
        {
            this.rtfRichTextBox1.Text += Environment.NewLine;
            this.rtfRichTextBox1.Text += s;
        }
        private void AddText(string[] ss)
        {
            foreach (string s in ss)
            {
                this.rtfRichTextBox1.Text += Environment.NewLine;
                this.rtfRichTextBox1.Text += s;
            }
        }
    }
}
