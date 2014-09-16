namespace Ternakan
{
    partial class frmLactacaoDiaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLactacaoDiaria));
            this.tbLactacao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbIncluirLactacao = new System.Windows.Forms.GroupBox();
            this.cbTirada = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btGravar = new System.Windows.Forms.Button();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVaca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgLactacao = new System.Windows.Forms.DataGridView();
            this.lblDeletar = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.cbTirada2 = new System.Windows.Forms.ComboBox();
            this.lblTirada2 = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.txtProducao2 = new System.Windows.Forms.TextBox();
            this.lblProducao2 = new System.Windows.Forms.Label();
            this.txtData2 = new System.Windows.Forms.MaskedTextBox();
            this.lblData2 = new System.Windows.Forms.Label();
            this.lblVaca2 = new System.Windows.Forms.Label();
            this.cbVaca2 = new System.Windows.Forms.ComboBox();
            this.tbLactacao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbIncluirLactacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLactacao)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLactacao
            // 
            this.tbLactacao.Controls.Add(this.tabPage1);
            this.tbLactacao.Controls.Add(this.tabPage2);
            this.tbLactacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLactacao.Location = new System.Drawing.Point(12, 12);
            this.tbLactacao.Name = "tbLactacao";
            this.tbLactacao.SelectedIndex = 0;
            this.tbLactacao.Size = new System.Drawing.Size(451, 226);
            this.tbLactacao.TabIndex = 0;
            this.tbLactacao.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbIncluirLactacao);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir Lactação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDeletar);
            this.tabPage2.Controls.Add(this.btCancelar);
            this.tabPage2.Controls.Add(this.lblAlterar);
            this.tabPage2.Controls.Add(this.cbTirada2);
            this.tabPage2.Controls.Add(this.lblTirada2);
            this.tabPage2.Controls.Add(this.btAlterar);
            this.tabPage2.Controls.Add(this.txtProducao2);
            this.tabPage2.Controls.Add(this.lblProducao2);
            this.tabPage2.Controls.Add(this.txtData2);
            this.tabPage2.Controls.Add(this.lblData2);
            this.tabPage2.Controls.Add(this.lblVaca2);
            this.tabPage2.Controls.Add(this.cbVaca2);
            this.tabPage2.Controls.Add(this.dgLactacao);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver ou Alterar lactação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbIncluirLactacao
            // 
            this.gbIncluirLactacao.Controls.Add(this.label6);
            this.gbIncluirLactacao.Controls.Add(this.button1);
            this.gbIncluirLactacao.Controls.Add(this.label5);
            this.gbIncluirLactacao.Controls.Add(this.cbTirada);
            this.gbIncluirLactacao.Controls.Add(this.label4);
            this.gbIncluirLactacao.Controls.Add(this.btGravar);
            this.gbIncluirLactacao.Controls.Add(this.txtProducao);
            this.gbIncluirLactacao.Controls.Add(this.label3);
            this.gbIncluirLactacao.Controls.Add(this.txtData);
            this.gbIncluirLactacao.Controls.Add(this.label2);
            this.gbIncluirLactacao.Controls.Add(this.label1);
            this.gbIncluirLactacao.Controls.Add(this.cbVaca);
            this.gbIncluirLactacao.Location = new System.Drawing.Point(6, 6);
            this.gbIncluirLactacao.Name = "gbIncluirLactacao";
            this.gbIncluirLactacao.Size = new System.Drawing.Size(426, 176);
            this.gbIncluirLactacao.TabIndex = 0;
            this.gbIncluirLactacao.TabStop = false;
            // 
            // cbTirada
            // 
            this.cbTirada.FormattingEnabled = true;
            this.cbTirada.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbTirada.Location = new System.Drawing.Point(363, 48);
            this.cbTirada.Name = "cbTirada";
            this.cbTirada.Size = new System.Drawing.Size(37, 24);
            this.cbTirada.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tirada:";
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.White;
            this.btGravar.Image = ((System.Drawing.Image)(resources.GetObject("btGravar.Image")));
            this.btGravar.Location = new System.Drawing.Point(109, 87);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(50, 50);
            this.btGravar.TabIndex = 15;
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(240, 48);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(53, 22);
            this.txtProducao.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Produção:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(49, 48);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 22);
            this.txtData.TabIndex = 9;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Vaca:";
            // 
            // cbVaca
            // 
            this.cbVaca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVaca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVaca.FormattingEnabled = true;
            this.cbVaca.Location = new System.Drawing.Point(49, 15);
            this.cbVaca.Name = "cbVaca";
            this.cbVaca.Size = new System.Drawing.Size(351, 24);
            this.cbVaca.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Guardar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(253, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Limpar";
            // 
            // dgLactacao
            // 
            this.dgLactacao.AllowUserToAddRows = false;
            this.dgLactacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLactacao.Location = new System.Drawing.Point(6, 6);
            this.dgLactacao.Name = "dgLactacao";
            this.dgLactacao.ReadOnly = true;
            this.dgLactacao.Size = new System.Drawing.Size(730, 376);
            this.dgLactacao.TabIndex = 1;
            // 
            // lblDeletar
            // 
            this.lblDeletar.AutoSize = true;
            this.lblDeletar.Location = new System.Drawing.Point(380, 441);
            this.lblDeletar.Name = "lblDeletar";
            this.lblDeletar.Size = new System.Drawing.Size(59, 16);
            this.lblDeletar.TabIndex = 31;
            this.lblDeletar.Text = "Deletar";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btCancelar.Image")));
            this.btCancelar.Location = new System.Drawing.Point(384, 388);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(50, 50);
            this.btCancelar.TabIndex = 30;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lblAlterar
            // 
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.Location = new System.Drawing.Point(299, 441);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(54, 16);
            this.lblAlterar.TabIndex = 29;
            this.lblAlterar.Text = "Alterar";
            // 
            // cbTirada2
            // 
            this.cbTirada2.FormattingEnabled = true;
            this.cbTirada2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbTirada2.Location = new System.Drawing.Point(362, 421);
            this.cbTirada2.Name = "cbTirada2";
            this.cbTirada2.Size = new System.Drawing.Size(37, 24);
            this.cbTirada2.TabIndex = 25;
            this.cbTirada2.Visible = false;
            // 
            // lblTirada2
            // 
            this.lblTirada2.AutoSize = true;
            this.lblTirada2.Location = new System.Drawing.Point(298, 424);
            this.lblTirada2.Name = "lblTirada2";
            this.lblTirada2.Size = new System.Drawing.Size(58, 16);
            this.lblTirada2.TabIndex = 28;
            this.lblTirada2.Text = "Tirada:";
            this.lblTirada2.Visible = false;
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.White;
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.Location = new System.Drawing.Point(301, 388);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(50, 50);
            this.btAlterar.TabIndex = 27;
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // txtProducao2
            // 
            this.txtProducao2.Location = new System.Drawing.Point(239, 421);
            this.txtProducao2.Name = "txtProducao2";
            this.txtProducao2.Size = new System.Drawing.Size(53, 22);
            this.txtProducao2.TabIndex = 24;
            this.txtProducao2.Visible = false;
            // 
            // lblProducao2
            // 
            this.lblProducao2.AutoSize = true;
            this.lblProducao2.Location = new System.Drawing.Point(154, 424);
            this.lblProducao2.Name = "lblProducao2";
            this.lblProducao2.Size = new System.Drawing.Size(79, 16);
            this.lblProducao2.TabIndex = 26;
            this.lblProducao2.Text = "Produção:";
            this.lblProducao2.Visible = false;
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(48, 421);
            this.txtData2.Mask = "00/00/0000";
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(100, 22);
            this.txtData2.TabIndex = 21;
            this.txtData2.ValidatingType = typeof(System.DateTime);
            this.txtData2.Visible = false;
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Location = new System.Drawing.Point(3, 424);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(45, 16);
            this.lblData2.TabIndex = 23;
            this.lblData2.Text = "Data:";
            this.lblData2.Visible = false;
            // 
            // lblVaca2
            // 
            this.lblVaca2.AutoSize = true;
            this.lblVaca2.Location = new System.Drawing.Point(3, 391);
            this.lblVaca2.Name = "lblVaca2";
            this.lblVaca2.Size = new System.Drawing.Size(48, 16);
            this.lblVaca2.TabIndex = 22;
            this.lblVaca2.Text = "Vaca:";
            this.lblVaca2.Visible = false;
            // 
            // cbVaca2
            // 
            this.cbVaca2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbVaca2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVaca2.FormattingEnabled = true;
            this.cbVaca2.Location = new System.Drawing.Point(48, 388);
            this.cbVaca2.Name = "cbVaca2";
            this.cbVaca2.Size = new System.Drawing.Size(351, 24);
            this.cbVaca2.TabIndex = 20;
            this.cbVaca2.Visible = false;
            // 
            // frmLactacaoDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 249);
            this.Controls.Add(this.tbLactacao);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(488, 287);
            this.MinimumSize = new System.Drawing.Size(488, 287);
            this.Name = "frmLactacaoDiaria";
            this.Text = "Lactação Diária";
            this.Shown += new System.EventHandler(this.frmLactacaoDiaria_Shown);
            this.tbLactacao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbIncluirLactacao.ResumeLayout(false);
            this.gbIncluirLactacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLactacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbLactacao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbIncluirLactacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTirada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVaca;
        private System.Windows.Forms.DataGridView dgLactacao;
        private System.Windows.Forms.Label lblDeletar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.ComboBox cbTirada2;
        private System.Windows.Forms.Label lblTirada2;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.TextBox txtProducao2;
        private System.Windows.Forms.Label lblProducao2;
        private System.Windows.Forms.MaskedTextBox txtData2;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label lblVaca2;
        private System.Windows.Forms.ComboBox cbVaca2;
    }
}