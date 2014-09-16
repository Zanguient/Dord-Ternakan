namespace Ternakan
{
    partial class frmIntervaloNascimento
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtInicioLactacao = new System.Windows.Forms.MaskedTextBox();
            this.txtFimLactacao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSairRelatorioLactacao = new System.Windows.Forms.Button();
            this.btConfirmarImpressaoLactacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "De:";
            // 
            // txtInicioLactacao
            // 
            this.txtInicioLactacao.Location = new System.Drawing.Point(12, 28);
            this.txtInicioLactacao.Mask = "00/00/0000";
            this.txtInicioLactacao.Name = "txtInicioLactacao";
            this.txtInicioLactacao.Size = new System.Drawing.Size(100, 20);
            this.txtInicioLactacao.TabIndex = 1;
            this.txtInicioLactacao.ValidatingType = typeof(System.DateTime);
            // 
            // txtFimLactacao
            // 
            this.txtFimLactacao.Location = new System.Drawing.Point(118, 28);
            this.txtFimLactacao.Mask = "00/00/0000";
            this.txtFimLactacao.Name = "txtFimLactacao";
            this.txtFimLactacao.Size = new System.Drawing.Size(100, 20);
            this.txtFimLactacao.TabIndex = 2;
            this.txtFimLactacao.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Até:";
            // 
            // btSairRelatorioLactacao
            // 
            this.btSairRelatorioLactacao.Location = new System.Drawing.Point(129, 81);
            this.btSairRelatorioLactacao.Name = "btSairRelatorioLactacao";
            this.btSairRelatorioLactacao.Size = new System.Drawing.Size(75, 23);
            this.btSairRelatorioLactacao.TabIndex = 4;
            this.btSairRelatorioLactacao.Text = "Sair";
            this.btSairRelatorioLactacao.UseVisualStyleBackColor = true;
            this.btSairRelatorioLactacao.Click += new System.EventHandler(this.btSairRelatorioLactacao_Click);
            // 
            // btConfirmarImpressaoLactacao
            // 
            this.btConfirmarImpressaoLactacao.Location = new System.Drawing.Point(25, 81);
            this.btConfirmarImpressaoLactacao.Name = "btConfirmarImpressaoLactacao";
            this.btConfirmarImpressaoLactacao.Size = new System.Drawing.Size(75, 23);
            this.btConfirmarImpressaoLactacao.TabIndex = 3;
            this.btConfirmarImpressaoLactacao.Text = "Confirmar";
            this.btConfirmarImpressaoLactacao.UseVisualStyleBackColor = true;
            this.btConfirmarImpressaoLactacao.Click += new System.EventHandler(this.btConfirmarImpressaoLactacao_Click);
            // 
            // frmIntervaloNascimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(245, 124);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInicioLactacao);
            this.Controls.Add(this.txtFimLactacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSairRelatorioLactacao);
            this.Controls.Add(this.btConfirmarImpressaoLactacao);
            this.Name = "frmIntervaloNascimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecione o intervalo";
            this.Shown += new System.EventHandler(this.frmIntervaloNascimento_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtInicioLactacao;
        private System.Windows.Forms.MaskedTextBox txtFimLactacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSairRelatorioLactacao;
        private System.Windows.Forms.Button btConfirmarImpressaoLactacao;
    }
}