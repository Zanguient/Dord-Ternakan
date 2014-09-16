using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Ternakan
{
    public partial class frmAdicionarPiquets : Form
    {
        public frmAdicionarPiquets()
        {
            InitializeComponent();
        }

        private bool cadastrarPiquet()
        {
            bool retorno;
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string queryInsert = string.Format("INSERT INTO PIQUET (NUMERO,NOME, ID_FAZENDA) VALUES (@NUMERO,@NOME,{0})",
                frmHome.IDFazendaSelecionada);

            FbCommand fbCmdInsert = new FbCommand();


            //PARAMETROS
            FbParameter[] prmParametro = new FbParameter[2];

            prmParametro[0] = new FbParameter("@NUMERO", txtNumeroPiquet.Text);
            prmParametro[1] = new FbParameter("@NOME", txtNomePiquet.Text);

            foreach (FbParameter p in prmParametro)
            {
                fbCmdInsert.Parameters.Add(p);
            }

            try
            {
                fbConn.Open();
                fbCmdInsert.Connection = fbConn;
                fbCmdInsert.CommandType = CommandType.Text;
                fbCmdInsert.CommandText = queryInsert;
                fbCmdInsert.ExecuteNonQuery();
                retorno = true;
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados: " + fbex.Message, "Erro");
                retorno = false;
            }
            finally
            {
                fbConn.Close();
            }
            return retorno;
        }

        private void btCadastrarPiquet_Click(object sender, EventArgs e)
        {
            if (txtNomePiquet.Text == "" || txtNumeroPiquet.Text == "")
                MessageBox.Show("Favor preencher todos os campos");
            else
            {
                bool retorno;
                retorno = cadastrarPiquet();
                if (retorno)
                {
                    MessageBox.Show("Piquet cadastrado");
                    txtNomePiquet.Clear();
                    txtNumeroPiquet.Clear();
                }
                //Close();
            }
        }

        private void btVoltarAdicionarPiquet_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdicionarPiquets_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            txtNumeroPiquet.Focus();
        }

        private void frmAdicionarPiquets_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }
    }
}
