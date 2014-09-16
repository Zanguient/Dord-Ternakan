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
    public partial class frmPrevisaoNascimento : Form
    {
        public frmPrevisaoNascimento()
        {
            InitializeComponent();
        }

        private void carregarDataGrid()
        {
         
            string squery;
            string query2;
            int i = 0;
            squery = string.Format("SELECT * FROM CRUZAMENTO WHERE (ID_FAZENDA = {0})", frmHome.IDFazendaSelecionada);

            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand(squery, fbConn);
            try
            {
                fbConn.Open();
                FbDataReader r = fbCmd.ExecuteReader();
                while (r.Read())
                {
                    dgListaPrevisaoNascimento.Rows.Add();
                    if (r["SEMEM"].ToString() == "1")
                    {
                        try
                        {
                            string query3;
                            query2 = string.Format("SELECT NOME FROM SEMEN WHERE (ID = {0})", r["ID_GADO_MACHO"]);
                            FbCommand fbCmd2 = new FbCommand(query2, fbConn);
                            FbDataReader r2 = fbCmd2.ExecuteReader();
                            r2.Read();
                            dgListaPrevisaoNascimento.Rows[i].Cells["Reprodutor"].Value = r2["NOME"].ToString();
                            query3 = string.Format("SELECT NOME, NUMERO FROM GADO WHERE (ID = {0})", r["ID_GADO_FEMEA"]);
                            FbCommand fbCmd3 = new FbCommand(query3, fbConn);
                            FbDataReader r3 = fbCmd3.ExecuteReader();
                            r3.Read();
                            dgListaPrevisaoNascimento.Rows[i].Cells["Vaca"].Value = r3["NOME"].ToString();
                            dgListaPrevisaoNascimento.Rows[i].Cells["NUMERO_VACA"].Value = r3["NUMERO"].ToString();
                        }
                        catch (FbException fbex)
                        {
                            MessageBox.Show("Erro no banco de dados: " + fbex.ToString());
                        }
                    }
                    else
                    {
                        try
                        {
                            string query3;
                            query2 = string.Format("SELECT NOME, NUMERO FROM GADO WHERE (ID = {0})", r["ID_GADO_MACHO"]);
                            FbCommand fbCmd2 = new FbCommand(query2, fbConn);
                            FbDataReader r2 = fbCmd2.ExecuteReader();
                            if (r2.Read())
                            {
                                dgListaPrevisaoNascimento.Rows[i].Cells[1].Value = r2[0].ToString();
                                dgListaPrevisaoNascimento.Rows[i].Cells[2].Value = r2[1].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Falha ao acessar o banco de dados.");
                            }
                            query3 = string.Format("SELECT NOME, NUMERO FROM GADO WHERE (ID = {0})", r["ID_GADO_FEMEA"]);
                            FbCommand fbCmd3 = new FbCommand(query3, fbConn);
                            FbDataReader r3 = fbCmd3.ExecuteReader();
                            r3.Read();
                            dgListaPrevisaoNascimento.Rows[i].Cells["Vaca"].Value = r3["NOME"].ToString();
                        }
                        catch (FbException fbex)
                        {
                            MessageBox.Show("Erro no banco de dados: " + fbex.ToString());
                        }
                    }
                    dgListaPrevisaoNascimento.Rows[i].Cells["Data"].Value = r["DATA_CRUZAMENTO"].ToString();
                    DateTime aux = Convert.ToDateTime(r["DATA_CRUZAMENTO"].ToString()).AddDays(270);
                    dgListaPrevisaoNascimento.Rows[i].Cells["DataDepois"].Value = aux.ToString();
                    i++;
                }
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro no banco de dados: " + fbex.ToString());
            }
        
        }


        private void frmPrevisaoNascimento_Shown(object sender, EventArgs e)
        {
            Text += " - " + frmHome.NomeFazendaSelecionada;
            carregarDataGrid();
            dgListaPrevisaoNascimento.Size = frmPrevisaoNascimento.ActiveForm.Size;
            btSairPrevisaoNascimento.Location = new Point((frmPrevisaoNascimento.ActiveForm.Width - btSairPrevisaoNascimento.Height) / 2, Convert.ToInt32(frmPrevisaoNascimento.ActiveForm.Height * 0.85));
            label1.Location = new Point(((frmPrevisaoNascimento.ActiveForm.Width - label1.Width) / 2), btSairPrevisaoNascimento.Location.Y + 52);
            frmPrevisaoNascimento.ActiveForm.MaximizeBox = false;
        }

        private void btSairPrevisaoNascimento_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
