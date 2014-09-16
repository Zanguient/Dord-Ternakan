namespace Ternakan
{
    partial class frmIncluirCruzamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRacaVacaCruzamento = new System.Windows.Forms.ComboBox();
            this.cbNomeVacaCruzamento = new System.Windows.Forms.ComboBox();
            this.cbNumeroVacaCruzamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataCruzamento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNaoInseminacao = new System.Windows.Forms.RadioButton();
            this.rbSimInseminacao = new System.Windows.Forms.RadioButton();
            this.btSairIncluirCruzamento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNomeReprodutor = new System.Windows.Forms.ComboBox();
            this.cbRacaReprodutor = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSemem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cruzamento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbRacaVacaCruzamento
            // 
            this.cbRacaVacaCruzamento.Enabled = false;
            this.cbRacaVacaCruzamento.FormattingEnabled = true;
            this.cbRacaVacaCruzamento.Location = new System.Drawing.Point(9, 87);
            this.cbRacaVacaCruzamento.Name = "cbRacaVacaCruzamento";
            this.cbRacaVacaCruzamento.Size = new System.Drawing.Size(240, 21);
            this.cbRacaVacaCruzamento.TabIndex = 3;
            // 
            // cbNomeVacaCruzamento
            // 
            this.cbNomeVacaCruzamento.Enabled = false;
            this.cbNomeVacaCruzamento.FormattingEnabled = true;
            this.cbNomeVacaCruzamento.Location = new System.Drawing.Point(118, 48);
            this.cbNomeVacaCruzamento.Name = "cbNomeVacaCruzamento";
            this.cbNomeVacaCruzamento.Size = new System.Drawing.Size(373, 21);
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
            this.cbNumeroVacaCruzamento.Size = new System.Drawing.Size(56, 21);
            this.cbNumeroVacaCruzamento.TabIndex = 4;
            this.cbNumeroVacaCruzamento.ValueMember = "ID";
            this.cbNumeroVacaCruzamento.SelectionChangeCommitted += new System.EventHandler(this.cbNumeroVacaCruzamento_SelectionChangeCommitted_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Raça da vaca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número da vaca:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome da vaca:";
            // 
            // txtDataCruzamento
            // 
            this.txtDataCruzamento.Location = new System.Drawing.Point(338, 87);
            this.txtDataCruzamento.Mask = "00/00/0000";
            this.txtDataCruzamento.Name = "txtDataCruzamento";
            this.txtDataCruzamento.Size = new System.Drawing.Size(103, 20);
            this.txtDataCruzamento.TabIndex = 1;
            this.txtDataCruzamento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data do cruzamento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNaoInseminacao);
            this.groupBox2.Controls.Add(this.rbSimInseminacao);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 59);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inseminação";
            // 
            // rbNaoInseminacao
            // 
            this.rbNaoInseminacao.AutoSize = true;
            this.rbNaoInseminacao.Checked = true;
            this.rbNaoInseminacao.Location = new System.Drawing.Point(7, 36);
            this.rbNaoInseminacao.Name = "rbNaoInseminacao";
            this.rbNaoInseminacao.Size = new System.Drawing.Size(45, 17);
            this.rbNaoInseminacao.TabIndex = 1;
            this.rbNaoInseminacao.TabStop = true;
            this.rbNaoInseminacao.Text = "Não";
            this.rbNaoInseminacao.UseVisualStyleBackColor = true;
            this.rbNaoInseminacao.CheckedChanged += new System.EventHandler(this.rbNaoInseminacao_CheckedChanged);
            // 
            // rbSimInseminacao
            // 
            this.rbSimInseminacao.AutoSize = true;
            this.rbSimInseminacao.Location = new System.Drawing.Point(7, 14);
            this.rbSimInseminacao.Name = "rbSimInseminacao";
            this.rbSimInseminacao.Size = new System.Drawing.Size(42, 17);
            this.rbSimInseminacao.TabIndex = 0;
            this.rbSimInseminacao.Text = "Sim";
            this.rbSimInseminacao.UseVisualStyleBackColor = true;
            this.rbSimInseminacao.CheckedChanged += new System.EventHandler(this.rbSimInseminacao_CheckedChanged);
            // 
            // btSairIncluirCruzamento
            // 
            this.btSairIncluirCruzamento.Location = new System.Drawing.Point(415, 261);
            this.btSairIncluirCruzamento.Name = "btSairIncluirCruzamento";
            this.btSairIncluirCruzamento.Size = new System.Drawing.Size(75, 23);
            this.btSairIncluirCruzamento.TabIndex = 6;
            this.btSairIncluirCruzamento.Text = "Sair";
            this.btSairIncluirCruzamento.UseVisualStyleBackColor = true;
            this.btSairIncluirCruzamento.Click += new System.EventHandler(this.btSairIncluirCruzamento_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirmar Cruzamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Raça do reprodutor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome do Reprodutor:";
            // 
            // cbNomeReprodutor
            // 
            this.cbNomeReprodutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNomeReprodutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNomeReprodutor.DisplayMember = "ID";
            this.cbNomeReprodutor.FormattingEnabled = true;
            this.cbNomeReprodutor.Location = new System.Drawing.Point(6, 30);
            this.cbNomeReprodutor.Name = "cbNomeReprodutor";
            this.cbNomeReprodutor.Size = new System.Drawing.Size(263, 21);
            this.cbNomeReprodutor.TabIndex = 1;
            this.cbNomeReprodutor.ValueMember = "ID";
            this.cbNomeReprodutor.SelectionChangeCommitted += new System.EventHandler(this.cbNomeReprodutor_SelectionChangeCommitted_1);
            this.cbNomeReprodutor.SelectedIndexChanged += new System.EventHandler(this.cbNomeReprodutor_SelectedIndexChanged);
            // 
            // cbRacaReprodutor
            // 
            this.cbRacaReprodutor.Enabled = false;
            this.cbRacaReprodutor.FormattingEnabled = true;
            this.cbRacaReprodutor.Location = new System.Drawing.Point(275, 29);
            this.cbRacaReprodutor.Name = "cbRacaReprodutor";
            this.cbRacaReprodutor.Size = new System.Drawing.Size(216, 21);
            this.cbRacaReprodutor.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbNomeReprodutor);
            this.groupBox3.Controls.Add(this.cbRacaReprodutor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(498, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cbSemem
            // 
            this.cbSemem.FormattingEnabled = true;
            this.cbSemem.Location = new System.Drawing.Point(150, 238);
            this.cbSemem.Name = "cbSemem";
            this.cbSemem.Size = new System.Drawing.Size(216, 21);
            this.cbSemem.TabIndex = 4;
            this.cbSemem.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Semem";
            this.label7.Visible = false;
            // 
            // frmIncluirCruzamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 299);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSemem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSairIncluirCruzamento);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmIncluirCruzamento";
            this.Text = "Incluir Cruzamento";
            this.Shown += new System.EventHandler(this.frmIncluirCruzamento_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDataCruzamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSairIncluirCruzamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbNaoInseminacao;
        private System.Windows.Forms.RadioButton rbSimInseminacao;
        private System.Windows.Forms.ComboBox cbRacaVacaCruzamento;
        private System.Windows.Forms.ComboBox cbNomeVacaCruzamento;
        private System.Windows.Forms.ComboBox cbNumeroVacaCruzamento;
        private System.Windows.Forms.ComboBox cbNomeReprodutor;
        private System.Windows.Forms.ComboBox cbRacaReprodutor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbSemem;
        private System.Windows.Forms.Label label7;
    }
}