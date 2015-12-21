using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class FormSource : Form
    {
        public FormSource()
        {
            InitializeComponent();
        }

        public void setSource(string text) 
        {
            richTextBox1.Text = text;
        }
    }
}
