using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using FirebirdSql.Data.FirebirdClient;

namespace Ternakan
{
    public partial class VerRelatorio : Form
    {
        public int nFotos1 = 0, nFotos2 = 0;

        public VerRelatorio()
        {
            InitializeComponent();
        }

        private DataRow retornarFazendaRow(DataTable dtFazenda)//Fazer isso com firebird
        {
            DataRow rFazenda = dtFazenda.NewRow();
            FbConnection fbConn = new FbConnection(frmHome.strConn);
            string query = string.Format("SELECT ID, NOME, CIDADE, ESTADO FROM FAZENDA WHERE ID = {0}",
                frmHome.IDFazendaSelecionada);
            FbCommand fbCmd = new FbCommand(query, fbConn);
            try
            {
                fbConn.Open();

                FbDataReader r = fbCmd.ExecuteReader();
                if (r.Read())
                {
                    rFazenda["NOME_FAZENDA"] = r[1];
                    rFazenda["CIDADE"] = r[2];
                    rFazenda["ESTADO"] = r[3];
                }



            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

            }
            finally
            {
                fbConn.Close();
            }


            return rFazenda;
        }

        private DataTable retornarTabelaVacina()
        {
            dsTernakan ds = new dsTernakan();
            DataTable dtUsuarios = ds.Tables["VACINA"];
            FbConnection fbConn = new FbConnection(frmHome.strConn);

            FbCommand fbCmd = new FbCommand("SELECT ID, ID_GADO, NOME,DATA_APLICACAO  FROM VACINACA", fbConn);

            try
            {
                fbConn.Open();
                DataRow rDataSet;
                FbDataReader r = fbCmd.ExecuteReader();

                while (r.Read())
                {
                    rDataSet = dtUsuarios.NewRow();
                    rDataSet["ID"] = r["ID"];
                    rDataSet["ID_GADO"] = r["ID_GADO"];
                    rDataSet["NOME"] = r["NOME"];
                    rDataSet["DATA_APLICACAO"] = r["DATA_APLICACAO"];
                    dtUsuarios.Rows.Add(rDataSet);
                }
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro ao acessar o FireBird " + fbex.Message, "Erro");
            }
            finally
            {
                fbConn.Close();
            }
            return dtUsuarios;
        }

        public void carregarDsTrabalhadoresInativos(string nome)
        {

            try
            {
                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                dsTernakan dsTemp = new dsTernakan();
                DataTable t = dsTemp.Tables["TRABALHADOR"];
                DataRow rDataset;
                //Firebird
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query = string.Format("SELECT NOME, DATA_NASCIMENTO,SALARIO FROM TRABALHADOR WHERE ((ATIVIDADE = 0) AND (ID_FAZENDA = {0}) AND (NOME like '{1}%'))",
                 frmHome.IDFazendaSelecionada, nome);

                

                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();
                    while (r.Read())
                    {
                        rDataset = t.NewRow();

                        rDataset["NOME"] = r[0];
                        rDataset["DATA_NASCIMENTO"] = r[1];
                        rDataset["SALARIO"] = r[2];

                        t.Rows.Add(rDataset);
                    }
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }


                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));
                RelatorioTrabalhadores objRpt = new RelatorioTrabalhadores();
                objRpt.Database.Tables[0].SetDataSource(t);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarDsTrabalhadores(DateTime dateDe, DateTime dataAte, bool ExibirInativos)
        {

            try
            {
                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                dsTernakan dsTemp = new dsTernakan();
                DataTable t = dsTemp.Tables["TRABALHADOR"];
                DataRow rDataset;
                //Firebird
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;
                if (ExibirInativos)
                {
                    query = string.Format("SELECT NOME, DATA_TRABALHO,SALARIO FROM TRABALHADOR WHERE ((DATA_TRABALHO >= '{0}') AND (DATA_TRABALHO <= '{1}') AND (ID_FAZENDA = {2}) )",
                        dateDe.ToString("MM/dd/yyyy"), dataAte.ToString("MM/dd/yyyy"), frmHome.IDFazendaSelecionada);
                }
                else
                {
                    query = string.Format("SELECT NOME, DATA_TRABALHO,SALARIO FROM TRABALHADOR WHERE ((DATA_TRABALHO >= '{0}') AND (DATA_TRABALHO <= '{1}') AND (ID_FAZENDA = {2}) AND (ATIVIDADE = 1))",
                    dateDe.ToString("MM/dd/yyyy"), dataAte.ToString("MM/dd/yyyy"), frmHome.IDFazendaSelecionada);
                }

                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();
                    while (r.Read())
                    {
                        rDataset = t.NewRow();

                        rDataset["NOME"] = r[0];
                        rDataset["DATA_NASCIMENTO"] = r[1];
                        rDataset["SALARIO"] = r[2];

                        t.Rows.Add(rDataset);
                    }
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }


                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));
                RelatorioTrabalhadores objRpt = new RelatorioTrabalhadores();
                objRpt.Database.Tables[0].SetDataSource(t);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarRelatorioNatalidade(DateTime dateDe, DateTime dataAte)
        {
            dsTernakan ds = new dsTernakan();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = ds.Tables["GADO"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT NOME, NUMERO, DATA_NASCIMENTO_GADO, SEXO FROM GADO WHERE ((DATA_NASCIMENTO_GADO >= '{0}') AND (DATA_NASCIMENTO_GADO <= '{1}') AND (TIPO_CADASTRO = 'Nascido') AND (ID_FAZENDA = {2}))",
                    dateDe.ToString("MM/dd/yyyy"), dataAte.ToString("MM/dd/yyyy"), frmHome.IDFazendaSelecionada);


                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();

                        rDataSet["NOME"] = r["NOME"];
                        rDataSet["NUMERO"] = r["NUMERO"];
                        rDataSet["DATA_NASCIMENTO_GADO"] = r["DATA_NASCIMENTO_GADO"];
                        rDataSet["SEXO"] = r["SEXO"];
                        /* rDataSet["PAI"] = r["PAI"];
                         rDataSet["MAE"] = r["MAE"];
                         rDataSet["RACA"] = r["RACA"];
                         rDataSet["PELAGEM"] = r["PELAGEM"];
                         rDataSet["LACTACAO_MEDIA"] = r["LACTACAO_MEDIA"];
                         rDataSet["NUMERO_FILHOS"] = r["NUMERO_FILHOS"];
                         rDataSet["NUMERO_DONOS"] = r["NUMERO_DONOS"];
                         rDataSet["NUMERO_REGISTRO"] = r["NUMERO_REGISTRO"];

                         if (!(r["FOTO1"] is DBNull))
                         {

                             rDataSet["FOTO1"] = r["FOTO1"];
                   
                         }

                         if (!(r["FOTO2"] is DBNull))
                         {

                             rDataSet["FOTO2"] = r["FOTO2"];
                        
                         }
                         */
                        t.Rows.Add(rDataSet);

                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }

                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));

                RelatorioNatalidade objRpt = new RelatorioNatalidade();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar o relatório");
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarRelatorioEntrada(DateTime dateDe, DateTime dataAte)
        {
            dsTernakan ds = new dsTernakan();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = ds.Tables["GADO"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT NOME, NUMERO, PRECO, VENDEDOR, SEXO FROM GADO WHERE ((TIPO_CADASTRO = 'Compra') AND (DATA_ENTRADA >= '{0}') AND (DATA_ENTRADA <= '{1}') AND (ID_FAZENDA = {2}))",
                     dateDe.ToString("MM/dd/yyyy"), dataAte.ToString("MM/dd/yyyy"), frmHome.IDFazendaSelecionada);


                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();

                        rDataSet["NOME"] = r["NOME"];
                        rDataSet["NUMERO"] = r["NUMERO"];
                        rDataSet["PRECO"] = r["PRECO"];
                        rDataSet["VENDEDOR"] = r["VENDEDOR"];
                        rDataSet["SEXO"] = r["SEXO"];
                        t.Rows.Add(rDataSet);

                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }

                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));

                RelatorioEntradaGadoFim objRpt = new RelatorioEntradaGadoFim();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarRelatorioSaida(DateTime dateDe, DateTime dataAte)
        {
            dsVirtual dsVirt = new dsVirtual();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = dsVirt.Tables["SAIDA"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT SAIDA_ANIMAIS.PRECO,  SAIDA_ANIMAIS.DATA_SAIDA, GADO.SEXO, GADO.NOME, GADO.NUMERO, SAIDA_ANIMAIS.TIPO_SAIDA, SAIDA_ANIMAIS.OBSERVACAO FROM GADO, SAIDA_ANIMAIS WHERE ((SAIDA_ANIMAIS.ID_GADO = GADO.ID) AND (GADO.ID_FAZENDA = {0}) AND (SAIDA_ANIMAIS.DATA_SAIDA >= '{1}') AND (SAIDA_ANIMAIS.DATA_SAIDA <= '{2}'))",
                      frmHome.IDFazendaSelecionada, dateDe.ToString("MM/dd/yyyy"), dataAte.ToString("MM/dd/yyyy"));


                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();

                        rDataSet["NOME"] = r[3];
                        rDataSet["NUMERO"] = r[4];
                        rDataSet["PRECO"] = r[0];
                        rDataSet["DATA_SAIDA"] = r[1];
                        rDataSet["SEXO"] = r[2];
                        rDataSet["TIPO_SAIDA"] = r[5]; 
                        rDataSet["OBSERVACAO"] = r[6];
                        t.Rows.Add(rDataSet);

                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }

                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));

                RelatoriosSaidaGado objRpt = new RelatoriosSaidaGado();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarRelatorioMortalidade(DateTime dateDe, DateTime dataAte)
        {
            dsVirtual dsVirt = new dsVirtual();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = dsVirt.Tables["VIRTUALMORTE"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT MORTALIDAE.CAUSA, MORTALIDAE.DATA_MORTE, GADO.NOME, GADO.NUMERO, GADO.SEXO FROM GADO, MORTALIDAE WHERE ((GADO.ID = MORTALIDAE.ID) AND (GADO.ID_FAZENDA = {0}) AND (MORTALIDAE.DATA_MORTE >= '{1}') AND (MORTALIDAE.DATA_MORTE <= '{2}'))",
                      frmHome.IDFazendaSelecionada, dateDe.ToString("MM/dd/yyyy"), dataAte.ToString("MM/dd/yyyy"));


                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();

                        rDataSet["NOME"] = r[2];
                        rDataSet["NUMERO"] = r[3];
                        rDataSet["CAUSA"] = r[0];
                        rDataSet["DATA_MORTE"] = r[1];
                        rDataSet["SEXO"] = r[4];
                        t.Rows.Add(rDataSet);

                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }

                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));

                RelatorioMortalidade objRpt = new RelatorioMortalidade();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarRelatorioLactacaoDia(DateTime dtInicial, DateTime dtFinal)
        {
            dsVirtual dsVirt = new dsVirtual();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = dsVirt.Tables["LDIA"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT LACTACAO_DIA.DATA, LACTACAO_DIA.PRODUCAO, GADO.NUMERO, GADO.NOME, LACTACAO_DIA.TIRADA FROM GADO, LACTACAO_DIA WHERE ((GADO.ID = LACTACAO_DIA.ID_GADO) AND (GADO.ID_FAZENDA = {0}) AND (LACTACAO_DIA.DATA >= '{1}') AND (LACTACAO_DIA.DATA <= '{2}'))",
                      frmHome.IDFazendaSelecionada, dtInicial.ToString("MM/dd/yyyy"), dtFinal.ToString("MM/dd/yyyy"));


                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();

                        rDataSet["PRODUCAO"] = r[1];
                        rDataSet["NUMERO"] = r[2];
                        rDataSet["NOME"] = r[3];
                        rDataSet["DATA"] = r[0];
                        rDataSet["TIRADA"] = r[4];
                        t.Rows.Add(rDataSet);

                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }



                RelatorioLdia objRpt = new RelatorioLdia();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);

                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarRelatorioPerfilGado()
        {
            dsTernakan ds = new dsTernakan();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = ds.Tables["GADO"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT * FROM GADO WHERE ((ID_FAZENDA = {0}) AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO'))",
                    frmHome.IDFazendaSelecionada);


                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();
                        rDataSet["ID"] = r["ID"];
                        rDataSet["NOME"] = r["NOME"];
                        rDataSet["NUMERO"] = r["NUMERO"];
                        rDataSet["DATA_NASCIMENTO_GADO"] = r["DATA_NASCIMENTO_GADO"];
                        rDataSet["SEXO"] = r["SEXO"];
                        rDataSet["PAI"] = r["PAI"];
                        rDataSet["MAE"] = r["MAE"];
                        rDataSet["RACA"] = r["RACA"];
                        rDataSet["PELAGEM"] = r["PELAGEM"];
                        rDataSet["LACTACAO_MEDIA"] = r["LACTACAO_MEDIA"];
                        rDataSet["NUMERO_FILHOS"] = r["NUMERO_FILHO"];
                        rDataSet["NUMERO_DONOS"] = r["NUMERO_DONOS"];
                        rDataSet["NUMERO_REGISTRO"] = r["NUMERO_REGISTRO"];

                        if (!(r["FOTO1"] is DBNull))
                        {

                            rDataSet["FOTO1"] = r["FOTO1"];

                        }

                        if (!(r["FOTO2"] is DBNull))
                        {

                            rDataSet["FOTO2"] = r["FOTO2"];

                        }

                        t.Rows.Add(rDataSet);

                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }

                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));

                RelatorioPerfilGado objRpt = new RelatorioPerfilGado();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(retornarTabelaVacina());
                objRpt.Subreports[1].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarRelatorioPerfilGado(LinkedList<int> id)
        {
            dsTernakan ds = new dsTernakan();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = ds.Tables["GADO"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT * FROM GADO WHERE (ID_FAZENDA = {0} AND (",
                    frmHome.IDFazendaSelecionada);

                for (int i = 0; i < (id.Count - 1); i++)
                {
                    query += string.Format(" (ID = {0}) OR",id.ElementAt(i));
                }
                query += string.Format(" (ID = {0})))", id.Last.Value);
                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();
                    //    if (id.Find(Convert.ToInt32(rDataSet["ID"])) != null)
                      //  {
                            rDataSet["ID"] = r["ID"];
                            rDataSet["NOME"] = r["NOME"];
                            rDataSet["NUMERO"] = r["NUMERO"];
                            rDataSet["DATA_NASCIMENTO_GADO"] = r["DATA_NASCIMENTO_GADO"];
                            rDataSet["SEXO"] = r["SEXO"];
                            rDataSet["PAI"] = r["PAI"];
                            rDataSet["MAE"] = r["MAE"];
                            rDataSet["RACA"] = r["RACA"];
                            rDataSet["PELAGEM"] = r["PELAGEM"];
                            rDataSet["LACTACAO_MEDIA"] = r["LACTACAO_MEDIA"];
                            rDataSet["NUMERO_FILHOS"] = r["NUMERO_FILHO"];
                            rDataSet["NUMERO_DONOS"] = r["NUMERO_DONOS"];
                            rDataSet["NUMERO_REGISTRO"] = r["NUMERO_REGISTRO"];

                            if (!(r["FOTO1"] is DBNull))
                            {

                                rDataSet["FOTO1"] = r["FOTO1"];

                            }

                            if (!(r["FOTO2"] is DBNull))
                            {

                                rDataSet["FOTO2"] = r["FOTO2"];

                            }

                            t.Rows.Add(rDataSet);
                        }
                   // }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }

                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));

                RelatorioPerfilGado objRpt = new RelatorioPerfilGado();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(retornarTabelaVacina());
                objRpt.Subreports[1].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarRelatorioPerfilGado(int id)
        {
            dsTernakan ds = new dsTernakan();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = ds.Tables["GADO"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT * FROM GADO WHERE (ID = {0})",
                    id);


                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();
                        rDataSet["ID"] = r["ID"];
                        rDataSet["NOME"] = r["NOME"];
                        rDataSet["NUMERO"] = r["NUMERO"];
                        rDataSet["DATA_NASCIMENTO_GADO"] = r["DATA_NASCIMENTO_GADO"];
                        rDataSet["SEXO"] = r["SEXO"];
                        rDataSet["PAI"] = r["PAI"];
                        rDataSet["MAE"] = r["MAE"];
                        rDataSet["RACA"] = r["RACA"];
                        rDataSet["PELAGEM"] = r["PELAGEM"];
                        rDataSet["LACTACAO_MEDIA"] = r["LACTACAO_MEDIA"];
                        rDataSet["NUMERO_FILHOS"] = r["NUMERO_FILHO"];
                        rDataSet["NUMERO_DONOS"] = r["NUMERO_DONOS"];
                        rDataSet["NUMERO_REGISTRO"] = r["NUMERO_REGISTRO"];

                        if (!(r["FOTO1"] is DBNull))
                        {

                            rDataSet["FOTO1"] = r["FOTO1"];

                        }

                        if (!(r["FOTO2"] is DBNull))
                        {

                            rDataSet["FOTO2"] = r["FOTO2"];

                        }

                        t.Rows.Add(rDataSet);

                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }

                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));

                RelatorioPerfilGado objRpt = new RelatorioPerfilGado();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);
                DataTable wVacina = retornarTabelaVacina();

                objRpt.Subreports[1].Database.Tables[0].SetDataSource(tFazenda);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(wVacina);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarRelatorioProduto(DateTime dateDe, DateTime dataAte)
        {
            dsTernakan ds = new dsTernakan();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = ds.Tables["PRODUTO"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT NOME_PRODUTO, NUMERO_NOTA_FISCAL, DATA_COMPRA, EMPRESA, QUANTIDADE, VALOR_PRODUTO FROM PRODUTO WHERE ((DATA_COMPRA >= '{0}') AND (DATA_COMPRA <= '{1}') AND (ID_FAZENDA = {2}))",
                     dateDe.ToString("MM/dd/yyyy"), dataAte.ToString("MM/dd/yyyy"), frmHome.IDFazendaSelecionada);


                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();

                        rDataSet["NOME_PRODUTO"] = r[0];
                        rDataSet["NUMERO_NOTA_FISCAL"] = r[1];
                        rDataSet["DATA_COMPRA_PRODUTO"] = r[2];
                        rDataSet["EMPRESA"] = r[3];
                        rDataSet["QUANTIDADE"] = r[4];
                        rDataSet["VALOR_PRODUTO"] = r[5];
                        t.Rows.Add(rDataSet);

                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }

                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));

                RelatorioProdutoFinal objRpt = new RelatorioProdutoFinal();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }
        }

        public void carregarPiquet(int IDPiquet)
        {
            dsVirtual dsVirt = new dsVirtual();
            try
            {

                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                DataTable t = dsVirt.Tables["PIQUET"];
                DataRow rDataSet;
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;

                query = string.Format("SELECT PIQUET.NOME, PIQUET.NUMERO, GADO.NOME, GADO.NUMERO FROM GADO , PIQUET WHERE ((GADO.ID_PIQUET = {0}) AND (PIQUET.ID = {0}) AND " +
                    "(GADO.TIPO_CADASTRO != 'MORTO') AND (GADO.TIPO_CADASTRO != 'VENDIDO') AND (GADO.TIPO_CADASTRO != 'TROCADO'))",
                    IDPiquet);

                FbCommand fbCmd = new FbCommand(query, fbConn);
                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();

                    while (r.Read())
                    {
                        rDataSet = t.NewRow();

                        rDataSet["NOME_PIQUET"] = r[0];
                        rDataSet["NUMERO_PIQUET"] = r[1];
                        rDataSet["NOME_ANIMAL"] = r[2];
                        rDataSet["NUMERO_ANIMAL"] = r[3];
                        t.Rows.Add(rDataSet);

                    }

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }

                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));

                RelatorioPiquet objRpt = new RelatorioPiquet();
                objRpt.Database.Tables[0].SetDataSource(t);
                //  objRpt.SetDataSource(ds);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(tFazenda);
                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
            }

        }

        public void relatorioEmBranco(int par)
        {
            switch (par)
            {
                case 0:
                    RelatorioBrancoLactacao rbl = new RelatorioBrancoLactacao();
                    crystalReportViewer1.ReportSource = rbl;
                    crystalReportViewer1.SelectionFormula = "";
                    break;
                case 1:
                    RelatorioBrancoVacinacao rbv = new RelatorioBrancoVacinacao();
                    crystalReportViewer1.ReportSource = rbv;
                    crystalReportViewer1.SelectionFormula = "";
                    break;
                case 2:
                    RelatorioBrancoCruzamento rbc = new RelatorioBrancoCruzamento();
                    crystalReportViewer1.ReportSource = rbc;
                    crystalReportViewer1.SelectionFormula = "";
                    break;
                default:
                    break;
            }
        }
        
        public void carregarRelatorioGadoRegistrado(bool mostrarMortos, bool mostrarVendidos)
        {
            try
            {
                //Codigo para o relatorio
                Cursor.Current = Cursors.WaitCursor;

                dsTernakan dsTemp = new dsTernakan();
                DataTable t = dsTemp.Tables["GADO"];
                DataRow rDataset;
                //Firebird
                FbConnection fbConn = new FbConnection(frmHome.strConn);
                string query;
                if (!mostrarMortos && !mostrarVendidos)
                {
                    query = string.Format("SELECT NOME, NUMERO, SEXO, NUMERO_REGISTRO FROM GADO WHERE ((ID_FAZENDA = {0}) AND (NUMERO_REGISTRO != '') AND (TIPO_CADASTRO != 'MORTO') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO'))",
                        frmHome.IDFazendaSelecionada);
                }
                else if (!mostrarMortos && mostrarVendidos)
                {
                    query = string.Format("SELECT NOME, NUMERO, SEXO, NUMERO_REGISTRO FROM GADO WHERE ((ID_FAZENDA = {0}) AND (NUMERO_REGISTRO != '') AND (TIPO_CADASTRO != 'MORTO'))",
                        frmHome.IDFazendaSelecionada);
                }
                else if (mostrarMortos && !mostrarVendidos)
                {
                    query = string.Format("SELECT NOME, NUMERO, SEXO, NUMERO_REGISTRO FROM GADO WHERE ((ID_FAZENDA = {0}) AND (NUMERO_REGISTRO != '') AND (TIPO_CADASTRO != 'VENDIDO') AND (TIPO_CADASTRO != 'TROCADO'))",
                        frmHome.IDFazendaSelecionada);
                }
                else
                {
                    query = string.Format("SELECT NOME, NUMERO, SEXO, NUMERO_REGISTRO FROM GADO WHERE ((ID_FAZENDA = {0}) AND (NUMERO_REGISTRO != ''))",
                        frmHome.IDFazendaSelecionada);
                }


                FbCommand fbCmd = new FbCommand(query, fbConn);

                try
                {
                    fbConn.Open();

                    FbDataReader r = fbCmd.ExecuteReader();
                    while (r.Read())
                    {
                        rDataset = t.NewRow();

                        rDataset["NOME"] = r[0];
                        rDataset["NUMERO"] = r[1];
                        rDataset["SEXO"] = r[2];
                        rDataset["NUMERO_REGISTRO"] = r[3];

                        t.Rows.Add(rDataset);
                    }
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro ao acessar o Banco de Dados:\n" + fbex.Message, "Erro");

                }
                finally
                {
                    fbConn.Close();
                }


                dsFazendasEUsuarios dsFazenda = new dsFazendasEUsuarios();
                DataTable tFazenda = dsFazenda.Tables["FAZENDA"];
                tFazenda.Rows.Add(retornarFazendaRow(tFazenda));
                RelatorioGadoRegistrado objRpt = new RelatorioGadoRegistrado();
                objRpt.Database.Tables[0].SetDataSource(t);
                objRpt.Subreports[0].Database.Tables[0].SetDataSource(tFazenda);

                crystalReportViewer1.ReportSource = objRpt;
                crystalReportViewer1.Refresh();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Erro ao carregar o relatório\n" + ee.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        internal void relatorioEmBrancoCruzamento()
        {
            throw new NotImplementedException();
        }

    }
}
