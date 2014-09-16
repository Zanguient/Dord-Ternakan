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
    public partial class frmMenuAnimais : Form
    {
        public frmMenuAnimais()
        {
            InitializeComponent();
        }


        //Ações para a passagem do mouse sobre algum botão
        private void btProcurar_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Procura os animais desejados de acordo com o filtro selecionado.";
        }

        private void btCasdastrar_MouseHover(object sender, EventArgs e)
        {
            txtInformacao.Text = "Cadastra os animais da fazenda.";
        }

        private void btAnimaisRegistrados_MouseHover_1(object sender, EventArgs e)
        {
            txtInformacao.Text = "Lista todos os animais que possuam registro.";
        }


        //Concatena o nome da fazenda selecionada com o nome da janela
        private void frmMenuAnimais_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }


        //Ações para o clique no botão
        private void btProcurar_Click(object sender, EventArgs e)
        {
            frmBusca frm = new frmBusca();
            frm.ShowDialog();
        }

        private void btCasdastrar_Click(object sender, EventArgs e)
        {
            frmGadoCadastro frm = new frmGadoCadastro();
            frm.ShowDialog();
        }

        private void btAnimaisRegistrados_Click(object sender, EventArgs e)
        {
            frmGadoRegistrado frm = new frmGadoRegistrado();
            frm.ShowDialog();
        }
    }
}
