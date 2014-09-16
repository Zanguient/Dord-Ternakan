namespace Ternakan
{
    partial class frmImprimirRelatorioRegistrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirRelatorioRegistrado));
            this.label1 = new System.Windows.Forms.Label();
            this.btConfirmarImpressão = new System.Windows.Forms.Button();
            this.cxMorto = new System.Windows.Forms.CheckBox();
            this.cxTrocado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Não deseja imprimir animais:";
            // 
            // btConfirmarImpressão
            // 
            this.btConfirmarImpressão.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConfirmarImpressão.BackgroundImage")));
            this.btConfirmarImpressão.Location = new System.Drawing.Point(15, 80);
            this.btConfirmarImpressão.Name = "btConfirmarImpressão";
            this.btConfirmarImpressão.Size = new System.Drawing.Size(50, 50);
            this.btConfirmarImpressão.TabIndex = 3;
            this.btConfirmarImpressão.UseVisualStyleBackColor = true;
            this.btConfirmarImpressão.Click += new System.EventHandler(this.btConfirmarImpressão_Click);
            // 
            // cxMorto
            // 
            this.cxMorto.AutoSize = true;
            this.cxMorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxMorto.Location = new System.Drawing.Point(15, 28);
            this.cxMorto.Name = "cxMorto";
            this.cxMorto.Size = new System.Drawing.Size(66, 20);
            this.cxMorto.TabIndex = 1;
            this.cxMorto.Text = "Morto";
            this.cxMorto.UseVisualStyleBackColor = true;
            // 
            // cxTrocado
            // 
            this.cxTrocado.AutoSize = true;
            this.cxTrocado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxTrocado.Location = new System.Drawing.Point(15, 54);
            this.cxTrocado.Name = "cxTrocado";
            this.cxTrocado.Size = new System.Drawing.Size(163, 20);
            this.cxTrocado.TabIndex = 2;
            this.cxTrocado.Text = "Vendido ou trocado";
            this.cxTrocado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirmar";
            // 
            // frmImprimirRelatorioRegistrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(237, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cxTrocado);
            this.Controls.Add(this.cxMorto);
            this.Controls.Add(this.btConfirmarImpressão);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(253, 195);
            this.MinimumSize = new System.Drawing.Size(253, 195);
            this.Name = "frmImprimirRelatorioRegistrado";
            this.Shown += new System.EventHandler(this.frmImprimirRelatorioRegistrado_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConfirmarImpressão;
        private System.Windows.Forms.CheckBox cxMorto;
        private System.Windows.Forms.CheckBox cxTrocado;
        private System.Windows.Forms.Label label2;

    }
}