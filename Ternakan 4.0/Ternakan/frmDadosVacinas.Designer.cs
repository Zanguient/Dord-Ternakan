namespace Ternakan
{
    partial class frmDadosVacinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDadosVacinas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeMedicamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataMedicacao = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOutroMedicamentoNao = new System.Windows.Forms.RadioButton();
            this.rbOutroMedicamentoSim = new System.Windows.Forms.RadioButton();
            this.btConfirmaMedicamento = new System.Windows.Forms.Button();
            this.btVoltardadosVacina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataProxVacina = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Medicamento:";
            // 
            // txtNomeMedicamento
            // 
            this.txtNomeMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMedicamento.Location = new System.Drawing.Point(12, 28);
            this.txtNomeMedicamento.Name = "txtNomeMedicamento";
            this.txtNomeMedicamento.Size = new System.Drawing.Size(303, 22);
            this.txtNomeMedicamento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data da Vacinação:";
            // 
            // txtDataMedicacao
            // 
            this.txtDataMedicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataMedicacao.Location = new System.Drawing.Point(12, 72);
            this.txtDataMedicacao.Mask = "00/00/0000";
            this.txtDataMedicacao.Name = "txtDataMedicacao";
            this.txtDataMedicacao.Size = new System.Drawing.Size(142, 22);
            this.txtDataMedicacao.TabIndex = 2;
            this.txtDataMedicacao.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOutroMedicamentoNao);
            this.groupBox1.Controls.Add(this.rbOutroMedicamentoSim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deseja cadastrar outro medicamento para os animais selecionados?";
            // 
            // rbOutroMedicamentoNao
            // 
            this.rbOutroMedicamentoNao.AutoSize = true;
            this.rbOutroMedicamentoNao.Location = new System.Drawing.Point(6, 59);
            this.rbOutroMedicamentoNao.Name = "rbOutroMedicamentoNao";
            this.rbOutroMedicamentoNao.Size = new System.Drawing.Size(55, 20);
            this.rbOutroMedicamentoNao.TabIndex = 2;
            this.rbOutroMedicamentoNao.TabStop = true;
            this.rbOutroMedicamentoNao.Text = "Não";
            this.rbOutroMedicamentoNao.UseVisualStyleBackColor = true;
            // 
            // rbOutroMedicamentoSim
            // 
            this.rbOutroMedicamentoSim.AutoSize = true;
            this.rbOutroMedicamentoSim.Location = new System.Drawing.Point(6, 38);
            this.rbOutroMedicamentoSim.Name = "rbOutroMedicamentoSim";
            this.rbOutroMedicamentoSim.Size = new System.Drawing.Size(52, 20);
            this.rbOutroMedicamentoSim.TabIndex = 1;
            this.rbOutroMedicamentoSim.TabStop = true;
            this.rbOutroMedicamentoSim.Text = "Sim";
            this.rbOutroMedicamentoSim.UseVisualStyleBackColor = true;
            // 
            // btConfirmaMedicamento
            // 
            this.btConfirmaMedicamento.BackColor = System.Drawing.Color.White;
            this.btConfirmaMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmaMedicamento.Image = ((System.Drawing.Image)(resources.GetObject("btConfirmaMedicamento.Image")));
            this.btConfirmaMedicamento.Location = new System.Drawing.Point(21, 195);
            this.btConfirmaMedicamento.Name = "btConfirmaMedicamento";
            this.btConfirmaMedicamento.Size = new System.Drawing.Size(50, 50);
            this.btConfirmaMedicamento.TabIndex = 5;
            this.btConfirmaMedicamento.UseVisualStyleBackColor = false;
            this.btConfirmaMedicamento.Click += new System.EventHandler(this.btConfirmaMedicamento_Click);
            // 
            // btVoltardadosVacina
            // 
            this.btVoltardadosVacina.BackColor = System.Drawing.Color.White;
            this.btVoltardadosVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltardadosVacina.Image = ((System.Drawing.Image)(resources.GetObject("btVoltardadosVacina.Image")));
            this.btVoltardadosVacina.Location = new System.Drawing.Point(255, 195);
            this.btVoltardadosVacina.Name = "btVoltardadosVacina";
            this.btVoltardadosVacina.Size = new System.Drawing.Size(50, 50);
            this.btVoltardadosVacina.TabIndex = 6;
            this.btVoltardadosVacina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVoltardadosVacina.UseVisualStyleBackColor = false;
            this.btVoltardadosVacina.Click += new System.EventHandler(this.btVoltardadosVacina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Próxima Vacina";
            // 
            // txtDataProxVacina
            // 
            this.txtDataProxVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataProxVacina.Location = new System.Drawing.Point(165, 72);
            this.txtDataProxVacina.Mask = "00/00/0000";
            this.txtDataProxVacina.Name = "txtDataProxVacina";
            this.txtDataProxVacina.Size = new System.Drawing.Size(150, 22);
            this.txtDataProxVacina.TabIndex = 3;
            this.txtDataProxVacina.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cancelar";
            // 
            // frmDadosVacinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataProxVacina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btVoltardadosVacina);
            this.Controls.Add(this.btConfirmaMedicamento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDataMedicacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeMedicamento);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 317);
            this.MinimumSize = new System.Drawing.Size(343, 317);
            this.Name = "frmDadosVacinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dados das Vacinas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDadosVacinas_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeMedicamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDataMedicacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOutroMedicamentoNao;
        private System.Windows.Forms.RadioButton rbOutroMedicamentoSim;
        private System.Windows.Forms.Button btConfirmaMedicamento;
        private System.Windows.Forms.Button btVoltardadosVacina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDataProxVacina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}