namespace Ternakan
{
    partial class frmIntervaloDe_Lactacao
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
            this.btConfirmarImpressaoLactacao = new System.Windows.Forms.Button();
            this.btSairRelatorioLactacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFimLactacao = new System.Windows.Forms.MaskedTextBox();
            this.txtInicioLactacao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConfirmarImpressaoLactacao
            // 
            this.btConfirmarImpressaoLactacao.Location = new System.Drawing.Point(15, 78);
            this.btConfirmarImpressaoLactacao.Name = "btConfirmarImpressaoLactacao";
            this.btConfirmarImpressaoLactacao.Size = new System.Drawing.Size(75, 23);
            this.btConfirmarImpressaoLactacao.TabIndex = 3;
            this.btConfirmarImpressaoLactacao.Text = "Confirmar";
            this.btConfirmarImpressaoLactacao.UseVisualStyleBackColor = true;
            this.btConfirmarImpressaoLactacao.Click += new System.EventHandler(this.btConfirmarImpressaoLactacao_Click);
            // 
            // btSairRelatorioLactacao
            // 
            this.btSairRelatorioLactacao.Location = new System.Drawing.Point(146, 78);
            this.btSairRelatorioLactacao.Name = "btSairRelatorioLactacao";
            this.btSairRelatorioLactacao.Size = new System.Drawing.Size(75, 23);
            this.btSairRelatorioLactacao.TabIndex = 5;
            this.btSairRelatorioLactacao.Text = "Sair";
            this.btSairRelatorioLactacao.UseVisualStyleBackColor = true;
            this.btSairRelatorioLactacao.Click += new System.EventHandler(this.btSairRelatorioLactacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Até:";
            // 
            // txtFimLactacao
            // 
            this.txtFimLactacao.Location = new System.Drawing.Point(121, 25);
            this.txtFimLactacao.Mask = "00/00/0000";
            this.txtFimLactacao.Name = "txtFimLactacao";
            this.txtFimLactacao.Size = new System.Drawing.Size(100, 20);
            this.txtFimLactacao.TabIndex = 1;
            this.txtFimLactacao.ValidatingType = typeof(System.DateTime);
            // 
            // txtInicioLactacao
            // 
            this.txtInicioLactacao.Location = new System.Drawing.Point(15, 25);
            this.txtInicioLactacao.Mask = "00/00/0000";
            this.txtInicioLactacao.Name = "txtInicioLactacao";
            this.txtInicioLactacao.Size = new System.Drawing.Size(100, 20);
            this.txtInicioLactacao.TabIndex = 0;
            this.txtInicioLactacao.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "De:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmIntervaloDe_Lactacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(237, 118);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInicioLactacao);
            this.Controls.Add(this.txtFimLactacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSairRelatorioLactacao);
            this.Controls.Add(this.btConfirmarImpressaoLactacao);
            this.Name = "frmIntervaloDe_Lactacao";
            this.Text = "Relatório de Lactação";
            this.Load += new System.EventHandler(this.frmIntervaloDe_Lactacao_Load);
            this.Shown += new System.EventHandler(this.frmIntervaloDe_Lactacao_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfirmarImpressaoLactacao;
        private System.Windows.Forms.Button btSairRelatorioLactacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFimLactacao;
        private System.Windows.Forms.MaskedTextBox txtInicioLactacao;
        private System.Windows.Forms.Label label2;
    }
}