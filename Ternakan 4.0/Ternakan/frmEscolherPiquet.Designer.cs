namespace Ternakan
{
    partial class frmEscolherPiquet
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPiquetRelatorio = new System.Windows.Forms.ComboBox();
            this.btImprimirPiquet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deseja Imprimir qual Piquet?";
            // 
            // cbPiquetRelatorio
            // 
            this.cbPiquetRelatorio.FormattingEnabled = true;
            this.cbPiquetRelatorio.Location = new System.Drawing.Point(15, 32);
            this.cbPiquetRelatorio.Name = "cbPiquetRelatorio";
            this.cbPiquetRelatorio.Size = new System.Drawing.Size(311, 21);
            this.cbPiquetRelatorio.TabIndex = 1;
            // 
            // btImprimirPiquet
            // 
            this.btImprimirPiquet.Location = new System.Drawing.Point(126, 64);
            this.btImprimirPiquet.Name = "btImprimirPiquet";
            this.btImprimirPiquet.Size = new System.Drawing.Size(75, 23);
            this.btImprimirPiquet.TabIndex = 2;
            this.btImprimirPiquet.Text = "Imprimir";
            this.btImprimirPiquet.UseVisualStyleBackColor = true;
            this.btImprimirPiquet.Click += new System.EventHandler(this.btImprimirPiquet_Click);
            // 
            // frmEscolherPiquet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 122);
            this.Controls.Add(this.btImprimirPiquet);
            this.Controls.Add(this.cbPiquetRelatorio);
            this.Controls.Add(this.label1);
            this.Name = "frmEscolherPiquet";
            this.Text = "Escolher Piquet";
            this.Shown += new System.EventHandler(this.frmEscolherPiquet_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPiquetRelatorio;
        private System.Windows.Forms.Button btImprimirPiquet;
    }
}