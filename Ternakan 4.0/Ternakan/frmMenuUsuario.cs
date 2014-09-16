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
    public partial class frmMenuUsuario : Form
    {
        public frmMenuUsuario()
        {
            InitializeComponent();
        }


        //Ações para a passagem do mouse sobre algum botão
        private void btCadastrarUsuario_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Permite cadastrar novos usuários no sistema.";
        }

        private void btTrocarSenha_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Permite trocar a senha do usuário que encontra-se atualmente logado.";
        }

        private void btListarUsuarios_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Lista todos os usuários do sistema, podendo removê-los ou alterar as suas senhas.";
        }

        private void btTrocarUsuario_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Permite a troca de usuário sem que haja a necessidade fechar o sistema.";
        }


        //Concatena o nome da fazenda selecionada com o nome da janela
        private void frmMenuUsuario_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }


        //Ações para o clique no botão
        private void btCadastrarUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuarios frm = new frmCadastroUsuarios();
            frm.ShowDialog();
        }

        private void btListarUsuarios_Click(object sender, EventArgs e)
        {
            fmrRemoverUsuario frm = new fmrRemoverUsuario();
            frm.ShowDialog();
        }
        private void btTrocarUsuario_Click(object sender, EventArgs e)
        {
            frmSelecionarFazenda frm = new frmSelecionarFazenda();
            frm.ShowDialog();
        }
        private void btTrocarSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frm = new frmAlterarSenha();
            frm.ShowDialog();
        }
    }
}