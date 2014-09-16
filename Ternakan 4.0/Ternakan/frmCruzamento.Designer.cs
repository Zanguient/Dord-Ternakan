namespace Ternakan
{
    partial class frmCruzamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCruzamento));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbNomeReprodutor = new System.Windows.Forms.ComboBox();
            this.cbRacaReprodutor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRacaVacaCruzamento = new System.Windows.Forms.ComboBox();
            this.cbNomeVacaCruzamento = new System.Windows.Forms.ComboBox();
            this.cbNumeroVacaCruzamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataCruzamento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSemem = new System.Windows.Forms.ComboBox();
            this.rbNaoInseminacao = new System.Windows.Forms.RadioButton();
            this.rbSimInseminacao = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btRemoverCruzamentos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbSim = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.cbNao = new System.Windows.Forms.RadioButton();
            this.dgListaCruzamento = new System.Windows.Forms.DataGridView();
            this.checado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Reprodutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroVaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCruzamento)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 453);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "Remover Cruzamentos";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir Cruzamento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Cruzamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Confirmar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbNomeReprodutor);
            this.groupBox3.Controls.Add(this.cbRacaReprodutor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(649, 84);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações do Reprodutor:";
            // 
            // cbNomeReprodutor
            // 
            this.cbNomeReprodutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNomeReprodutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNomeReprodutor.DisplayMember = "ID";
            this.cbNomeReprodutor.FormattingEnabled = true;
            this.cbNomeReprodutor.Location = new System.Drawing.Point(6, 34);
            this.cbNomeReprodutor.Name = "cbNomeReprodutor";
            this.cbNomeReprodutor.Size = new System.Drawing.Size(321, 24);
            this.cbNomeReprodutor.TabIndex = 5;
            this.cbNomeReprodutor.ValueMember = "ID";
            // 
            // cbRacaReprodutor
            // 
            this.cbRacaReprodutor.Enabled = false;
            this.cbRacaReprodutor.FormattingEnabled = true;
            this.cbRacaReprodutor.Location = new System.Drawing.Point(333, 34);
            this.cbRacaReprodutor.Name = "cbRacaReprodutor";
            this.cbRacaReprodutor.Size = new System.Drawing.Size(310, 24);
            this.cbRacaReprodutor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Raça do reprodutor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome do Reprodutor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRacaVacaCruzamento);
            this.groupBox1.Controls.Add(this.cbNomeVacaCruzamento);
            this.groupBox1.Controls.Add(this.cbNumeroVacaCruzamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDataCruzamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 122);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Fêmea";
            // 
            // cbRacaVacaCruzamento
            // 
            this.cbRacaVacaCruzamento.Enabled = false;
            this.cbRacaVacaCruzamento.FormattingEnabled = true;
            this.cbRacaVacaCruzamento.Location = new System.Drawing.Point(9, 87);
            this.cbRacaVacaCruzamento.Name = "cbRacaVacaCruzamento";
            this.cbRacaVacaCruzamento.Size = new System.Drawing.Size(320, 24);
            this.cbRacaVacaCruzamento.TabIndex = 3;
            // 
            // cbNomeVacaCruzamento
            // 
            this.cbNomeVacaCruzamento.Enabled = false;
            this.cbNomeVacaCruzamento.FormattingEnabled = true;
            this.cbNomeVacaCruzamento.Location = new System.Drawing.Point(89, 48);
            this.cbNomeVacaCruzamento.Name = "cbNomeVacaCruzamento";
            this.cbNomeVacaCruzamento.Size = new System.Drawing.Size(402, 24);
            this.cbNomeVacaCruzamento.TabIndex = 2;
            // 
            // cbNumeroVacaCruzamento
            // 
            this.cbNumeroVacaCruzamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNumeroVacaCruzamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNumeroVacaCruzamento.DisplayMember = "ID";
            this.cbNumeroVacaCruzamento.FormattingEnabled = true;
            this.cbNumeroVacaCruzamento.Location = new System.Drawing.Point(9, 47);
            this.cbNumeroVacaCruzamento.Name = "cbNumeroVacaCruzamento";
            this.cbNumeroVacaCruzamento.Size = new System.Drawing.Size(63, 24);
            this.cbNumeroVacaCruzamento.TabIndex = 1;
            this.cbNumeroVacaCruzamento.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raça:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtDataCruzamento
            // 
            this.txtDataCruzamento.Location = new System.Drawing.Point(496, 48);
            this.txtDataCruzamento.Mask = "00/00/0000";
            this.txtDataCruzamento.Name = "txtDataCruzamento";
            this.txtDataCruzamento.Size = new System.Drawing.Size(147, 22);
            this.txtDataCruzamento.TabIndex = 4;
            this.txtDataCruzamento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data do cruzamento:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(309, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbSemem);
            this.groupBox2.Controls.Add(this.rbNaoInseminacao);
            this.groupBox2.Controls.Add(this.rbSimInseminacao);
            this.groupBox2.Location = new System.Drawing.Point(6, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 62);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inseminação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Semem";
            this.label7.Visible = false;
            // 
            // cbSemem
            // 
            this.cbSemem.FormattingEnabled = true;
            this.cbSemem.Location = new System.Drawing.Point(145, 26);
            this.cbSemem.Name = "cbSemem";
            this.cbSemem.Size = new System.Drawing.Size(498, 24);
            this.cbSemem.TabIndex = 8;
            this.cbSemem.Visible = false;
            // 
            // rbNaoInseminacao
            // 
            this.rbNaoInseminacao.AutoSize = true;
            this.rbNaoInseminacao.Checked = true;
            this.rbNaoInseminacao.Location = new System.Drawing.Point(84, 19);
            this.rbNaoInseminacao.Name = "rbNaoInseminacao";
            this.rbNaoInseminacao.Size = new System.Drawing.Size(55, 20);
            this.rbNaoInseminacao.TabIndex = 7;
            this.rbNaoInseminacao.TabStop = true;
            this.rbNaoInseminacao.Text = "Não";
            this.rbNaoInseminacao.UseVisualStyleBackColor = true;
            // 
            // rbSimInseminacao
            // 
            this.rbSimInseminacao.AutoSize = true;
            this.rbSimInseminacao.Location = new System.Drawing.Point(7, 19);
            this.rbSimInseminacao.Name = "rbSimInseminacao";
            this.rbSimInseminacao.Size = new System.Drawing.Size(52, 20);
            this.rbSimInseminacao.TabIndex = 6;
            this.rbSimInseminacao.Text = "Sim";
            this.rbSimInseminacao.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btRemoverCruzamentos);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dgListaCruzamento);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remover Cruzamentos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 52;
            this.label12.Text = "Cruzamento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Remover";
            // 
            // btRemoverCruzamentos
            // 
            this.btRemoverCruzamentos.Image = ((System.Drawing.Image)(resources.GetObject("btRemoverCruzamentos.Image")));
            this.btRemoverCruzamentos.Location = new System.Drawing.Point(305, 332);
            this.btRemoverCruzamentos.Name = "btRemoverCruzamentos";
            this.btRemoverCruzamentos.Size = new System.Drawing.Size(50, 50);
            this.btRemoverCruzamentos.TabIndex = 50;
            this.btRemoverCruzamentos.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbSim);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtDataNascimento);
            this.groupBox4.Controls.Add(this.cbNao);
            this.groupBox4.Location = new System.Drawing.Point(6, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 74);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "O bezerro nasceu?";
            // 
            // cbSim
            // 
            this.cbSim.AutoSize = true;
            this.cbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSim.Location = new System.Drawing.Point(6, 21);
            this.cbSim.Name = "cbSim";
            this.cbSim.Size = new System.Drawing.Size(52, 20);
            this.cbSim.TabIndex = 44;
            this.cbSim.TabStop = true;
            this.cbSim.Text = "Sim";
            this.cbSim.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Data do acontecimento:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(67, 42);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(91, 22);
            this.txtDataNascimento.TabIndex = 47;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // cbNao
            // 
            this.cbNao.AutoSize = true;
            this.cbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNao.Location = new System.Drawing.Point(6, 43);
            this.cbNao.Name = "cbNao";
            this.cbNao.Size = new System.Drawing.Size(55, 20);
            this.cbNao.TabIndex = 45;
            this.cbNao.TabStop = true;
            this.cbNao.Text = "Não";
            this.cbNao.UseVisualStyleBackColor = true;
            // 
            // dgListaCruzamento
            // 
            this.dgListaCruzamento.AllowUserToAddRows = false;
            this.dgListaCruzamento.AllowUserToDeleteRows = false;
            this.dgListaCruzamento.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgListaCruzamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaCruzamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checado,
            this.Reprodutor,
            this.Numero,
            this.Vaca,
            this.NumeroVaca,
            this.Data});
            this.dgListaCruzamento.Location = new System.Drawing.Point(6, 8);
            this.dgListaCruzamento.Name = "dgListaCruzamento";
            this.dgListaCruzamento.ReadOnly = true;
            this.dgListaCruzamento.Size = new System.Drawing.Size(648, 318);
            this.dgListaCruzamento.TabIndex = 43;
            this.dgListaCruzamento.Tag = "";
            // 
            // checado
            // 
            this.checado.HeaderText = "";
            this.checado.Name = "checado";
            this.checado.ReadOnly = true;
            // 
            // Reprodutor
            // 
            this.Reprodutor.HeaderText = "Nome do reprodutor:";
            this.Reprodutor.Name = "Reprodutor";
            this.Reprodutor.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número do Reprodutor:";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Vaca
            // 
            this.Vaca.HeaderText = "Nome da vaca:";
            this.Vaca.Name = "Vaca";
            this.Vaca.ReadOnly = true;
            // 
            // NumeroVaca
            // 
            this.NumeroVaca.HeaderText = "Número da Vaca:";
            this.NumeroVaca.Name = "NumeroVaca";
            this.NumeroVaca.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data do cruzamento:";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // frmCruzamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 476);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(706, 514);
            this.MinimumSize = new System.Drawing.Size(706, 514);
            this.Name = "frmCruzamento";
            this.Text = "Cruzamento";
            this.Shown += new System.EventHandler(this.frmCruzamento_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCruzamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbNomeReprodutor;
        private System.Windows.Forms.ComboBox cbRacaReprodutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbRacaVacaCruzamento;
        private System.Windows.Forms.ComboBox cbNomeVacaCruzamento;
        private System.Windows.Forms.ComboBox cbNumeroVacaCruzamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDataCruzamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSemem;
        private System.Windows.Forms.RadioButton rbNaoInseminacao;
        private System.Windows.Forms.RadioButton rbSimInseminacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgListaCruzamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reprodutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroVaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.RadioButton cbNao;
        private System.Windows.Forms.RadioButton cbSim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btRemoverCruzamentos;
    }
}