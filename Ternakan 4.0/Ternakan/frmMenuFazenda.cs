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
    public partial class frmMenuFazenda : Form
    {
        public frmMenuFazenda()
        {
            InitializeComponent();
        }

        
        //Ações para a passagem do mouse sobre algum botão
        private void btTrabalhadores_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Cadastro, listagem e demissão de trabalhadores.";
        }

        private void btProdutos_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Cadastro e listagem de compras de produtos para a fazenda.";
        }
        private void btDespesas_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Controle de despesas relacionadas a trabalhadores e produtos adiquiridos para a fazenda.";
        }

        private void btPiquetes_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Área para cadastro e alterações de Piquetes.";
        }

        private void btCadastroFazenda_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Caso o usuário possua mais de uma propriedade ele pode fazer o cadastro de todas nessa área.";
        }


        //Ações para o clique no botão
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void btTrabalhadores_Click(object sender, EventArgs e)
        {
            frmTrabalhadores frm = new frmTrabalhadores();
            frm.ShowDialog();
        }

        private void btProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frm = new frmProdutos();
            frm.ShowDialog();
        }

        private void btDespesas_Click(object sender, EventArgs e)
        {
            gbDespesas.Visible = true;
        }

        private void btPiquetes_Click(object sender, EventArgs e)
        {
            gbDespesas.Visible = false;
            frmPiquet frm = new frmPiquet();
            frm.ShowDialog();
        }

        private void btCadastroFazenda_Click(object sender, EventArgs e)
        {
            gbDespesas.Visible = false;
            frmCadastraoFazenda frm = new frmCadastraoFazenda();
            frm.ShowDialog();
        }


        //Concatena o nome da fazenda selecionada com o nome da janela
        private void frmMenuFazenda_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
