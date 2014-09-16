namespace Ternakan
{
    partial class frmRemoverCruzamento
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Reprodutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroVaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoverCruzamentos = new System.Windows.Forms.Button();
            this.btSairRemoverCruzamento = new System.Windows.Forms.Button();
            this.cbSim = new System.Windows.Forms.RadioButton();
            this.cbNao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checado,
            this.Reprodutor,
            this.Numero,
            this.Vaca,
            this.NumeroVaca,
            this.Data});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(752, 380);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btRemoverCruzamentos
            // 
            this.btRemoverCruzamentos.Location = new System.Drawing.Point(322, 532);
            this.btRemoverCruzamentos.Name = "btRemoverCruzamentos";
            this.btRemoverCruzamentos.Size = new System.Drawing.Size(75, 23);
            this.btRemoverCruzamentos.TabIndex = 3;
            this.btRemoverCruzamentos.Text = "Remover";
            this.btRemoverCruzamentos.UseVisualStyleBackColor = true;
            this.btRemoverCruzamentos.Click += new System.EventHandler(this.btRemoverCruzamentos_Click);
            // 
            // btSairRemoverCruzamento
            // 
            this.btSairRemoverCruzamento.Location = new System.Drawing.Point(424, 532);
            this.btSairRemoverCruzamento.Name = "btSairRemoverCruzamento";
            this.btSairRemoverCruzamento.Size = new System.Drawing.Size(75, 23);
            this.btSairRemoverCruzamento.TabIndex = 4;
            this.btSairRemoverCruzamento.Text = "Sair";
            this.btSairRemoverCruzamento.UseVisualStyleBackColor = true;
            this.btSairRemoverCruzamento.Click += new System.EventHandler(this.btSairRemoverCruzamento_Click);
            // 
            // cbSim
            // 
            this.cbSim.AutoSize = true;
            this.cbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSim.Location = new System.Drawing.Point(372, 423);
            this.cbSim.Name = "cbSim";
            this.cbSim.Size = new System.Drawing.Size(49, 21);
            this.cbSim.TabIndex = 1;
            this.cbSim.TabStop = true;
            this.cbSim.Text = "Sim";
            this.cbSim.UseVisualStyleBackColor = true;
            this.cbSim.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cbNao
            // 
            this.cbNao.AutoSize = true;
            this.cbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNao.Location = new System.Drawing.Point(369, 450);
            this.cbNao.Name = "cbNao";
            this.cbNao.Size = new System.Drawing.Size(52, 21);
            this.cbNao.TabIndex = 2;
            this.cbNao.TabStop = true;
            this.cbNao.Text = "Não";
            this.cbNao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 40;
            this.label1.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(204, 423);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(130, 17);
            this.label.TabIndex = 41;
            this.label.Text = "O bezerro nasceu?";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(447, 441);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 42;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Data do acontecimento:";
            // 
            // frmRemoverCruzamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ternakan.Properties.Resources.fundo_do_programa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNao);
            this.Controls.Add(this.cbSim);
            this.Controls.Add(this.btSairRemoverCruzamento);
            this.Controls.Add(this.btRemoverCruzamentos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRemoverCruzamento";
            this.Text = "Remover Cruzamento";
            this.Load += new System.EventHandler(this.frmRemoverCruzamento_Load);
            this.Shown += new System.EventHandler(this.frmRemoverCruzamento_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRemoverCruzamento_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btRemoverCruzamentos;
        private System.Windows.Forms.Button btSairRemoverCruzamento;
        private System.Windows.Forms.RadioButton cbSim;
        private System.Windows.Forms.RadioButton cbNao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reprodutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroVaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.Label label2;
    }
}