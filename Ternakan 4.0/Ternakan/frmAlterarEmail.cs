using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Ternakan
{
    public partial class frmAlterarEmail : Form
    {
        public frmAlterarEmail()
        {
            InitializeComponent();
        }

        private void frmAlterarEmail_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza de que deseja alterar o e-mail?", "Confimação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConfigurationManager.AppSettings["email"] = textBox1.Text;
                MessageBox.Show("E-mail alterado com sucesso\nO novo e-mail é:\n" + ConfigurationManager.AppSettings["email"]);
                
                Close();
            }
        }

        private void frmAlterarEmail_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
