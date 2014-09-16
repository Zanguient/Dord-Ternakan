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
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (txtConfirmacaoSenha.Text == "" || txtNovaSenha.Text == "" || txtSenhaAtual.Text == "")
                MessageBox.Show("Favor preencher todos os campos");
            else if (txtNovaSenha.Text != txtConfirmacaoSenha.Text)
                MessageBox.Show("A nova senha e a sua confirmação estão diferentes. Favor corrigí-las.");
            else
            {
                MessageBox.Show("Senha alterada com sucesso.");
            }
        }

        private void frmAlterarSenha_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
