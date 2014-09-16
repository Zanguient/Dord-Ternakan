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
    public partial class frmVacasLactacao : Form
    {
        bool mudouDeTab = new bool();
        public frmVacasLactacao()
        {
            InitializeComponent();
            frmVacasLactacao.ActiveForm.Height = 269;
            frmVacasLactacao.ActiveForm.Width = 486;

            tcVacasLactacao.Height = 201;
            tcVacasLactacao.Width = 445;

            gbVacasLactacao.Height = 152;
            gbVacasLactacao.Width = 450;
            mudouDeTab = true;
        }

        private void frmVacasLactacao_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
        }

        private void tcVacasLactacao_Selected(object sender, TabControlEventArgs e)
        {
            if (mudouDeTab == false)
            {
                frmVacasLactacao.ActiveForm.MaximumSize = frmVacasLactacao.ActiveForm.MinimumSize = new Size(486, 269);
                frmVacasLactacao.ActiveForm.Height = 269;
                frmVacasLactacao.ActiveForm.Width = 486;

                tcVacasLactacao.Height = 201;
                tcVacasLactacao.Width = 445;

                gbVacasLactacao.Height = 152;
                gbVacasLactacao.Width = 450;

                mudouDeTab = true;
            }
            else
            {
                frmVacasLactacao.ActiveForm.MaximumSize = frmVacasLactacao.ActiveForm.MinimumSize = new Size(486, 434);
                frmVacasLactacao.ActiveForm.Height = 434;
                frmVacasLactacao.ActiveForm.Width = 486;

                dgVacasLactacao.Height = 252;
                dgVacasLactacao.Width = 423;

                btRemover.Location = new Point(186, 265);
                lblRemover.Location = new Point(176, 318);

                tcVacasLactacao.Height = 370;
                tcVacasLactacao.Width = 445;
                mudouDeTab = false;
            }
        }

    }
}
