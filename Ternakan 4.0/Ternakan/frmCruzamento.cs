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
    public partial class frmCruzamento : Form
    {
        public frmCruzamento()
        {
            InitializeComponent();
        }


        //Concatena o nome da fazenda selecionada com o nome da janela
        private void frmCruzamento_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }
    }
}
