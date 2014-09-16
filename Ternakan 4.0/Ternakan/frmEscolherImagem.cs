using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ternakan
{
    public partial class frmEscolherImagem : Form
    {
        public string location;
        public frmEscolherImagem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            location = textBox1.Text;      
            Close();
            
        }

    }
}
