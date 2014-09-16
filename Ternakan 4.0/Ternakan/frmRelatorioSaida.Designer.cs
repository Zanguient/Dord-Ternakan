namespace Ternakan
{
    partial class frmRelatorioSaida
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
            this.btSairRelatorioSaida = new System.Windows.Forms.Button();
            this.btImprimirRelatorioSaida = new System.Windows.Forms.Button();
            this.txtAteSaida = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeSaida = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSairRelatorioSaida);
            this.groupBox1.Controls.Add(this.btImprimirRelatorioSaida);
            this.groupBox1.Controls.Add(this.txtAteSaida);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDeSaida);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório";
            // 
            // btSairRelatorioSaida
            // 
            this.btSairRelatorioSaida.Location = new System.Drawing.Point(155, 90);
            this.btSairRelatorioSaida.Name = "btSairRelatorioSaida";
            this.btSairRelatorioSaida.Size = new System.Drawing.Size(75, 23);
            this.btSairRelatorioSaida.TabIndex = 4;
            this.btSairRelatorioSaida.Text = "Sair";
            this.btSairRelatorioSaida.UseVisualStyleBackColor = true;
            this.btSairRelatorioSaida.Click += new System.EventHandler(this.btSairRelatorioSaida_Click);
            // 
            // btImprimirRelatorioSaida
            // 
            this.btImprimirRelatorioSaida.Location = new System.Drawing.Point(36, 90);
            this.btImprimirRelatorioSaida.Name = "btImprimirRelatorioSaida";
            this.btImprimirRelatorioSaida.Size = new System.Drawing.Size(75, 23);
            this.btImprimirRelatorioSaida.TabIndex = 3;
            this.btImprimirRelatorioSaida.Text = "Imprimir";
            this.btImprimirRelatorioSaida.UseVisualStyleBackColor = true;
            this.btImprimirRelatorioSaida.Click += new System.EventHandler(this.btImprimirRelatorioSaida_Click);
            // 
            // txtAteSaida
            // 
            this.txtAteSaida.Location = new System.Drawing.Point(36, 55);
            this.txtAteSaida.Mask = "00/00/0000";
            this.txtAteSaida.Name = "txtAteSaida";
            this.txtAteSaida.Size = new System.Drawing.Size(100, 20);
            this.txtAteSaida.TabIndex = 2;
            this.txtAteSaida.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Até:";
            // 
            // txtDeSaida
            // 
            this.txtDeSaida.Location = new System.Drawing.Point(36, 25);
            this.txtDeSaida.Mask = "00/00/0000";
            this.txtDeSaida.Name = "txtDeSaida";
            this.txtDeSaida.Size = new System.Drawing.Size(100, 20);
            this.txtDeSaida.TabIndex = 1;
            this.txtDeSaida.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // frmRelatorioSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(301, 141);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRelatorioSaida";
            this.Text = "Relatorio de Saida dos Animais";
            this.Shown += new System.EventHandler(this.frmRelatorioSaida_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btImprimirRelatorioSaida;
        private System.Windows.Forms.MaskedTextBox txtAteSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDeSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSairRelatorioSaida;
    }
}