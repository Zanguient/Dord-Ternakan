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
    public partial class frmMenuAgenda : Form
    {
        public frmMenuAgenda()
        {
            InitializeComponent();
        }


        //Concatena o nome da fazenda selecionada com o nome da janela
        private void frmMenuAgenda_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }


        //Ações para o clique no botão
        private void btConfirmarEvento_Click(object sender, EventArgs e)
        {

        }

        private void btDeletarEvento_Click(object sender, EventArgs e)
        {

        }
    }
}
