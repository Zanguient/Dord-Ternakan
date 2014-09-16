namespace Ternakan
{
    partial class frmQuantidadeGado
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbQuantidadeGadoMacho = new System.Windows.Forms.Label();
            this.lbQuantidadeGadoFemea = new System.Windows.Forms.Label();
            this.lbQuantidadeGadoTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPiquet = new System.Windows.Forms.ComboBox();
            this.lblqntPiquet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Machos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de Fêmeas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL:";
            // 
            // lbQuantidadeGadoMacho
            // 
            this.lbQuantidadeGadoMacho.AutoSize = true;
            this.lbQuantidadeGadoMacho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeGadoMacho.Location = new System.Drawing.Point(184, 18);
            this.lbQuantidadeGadoMacho.Name = "lbQuantidadeGadoMacho";
            this.lbQuantidadeGadoMacho.Size = new System.Drawing.Size(44, 16);
            this.lbQuantidadeGadoMacho.TabIndex = 3;
            this.lbQuantidadeGadoMacho.Text = "XXXX";
            // 
            // lbQuantidadeGadoFemea
            // 
            this.lbQuantidadeGadoFemea.AutoSize = true;
            this.lbQuantidadeGadoFemea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeGadoFemea.Location = new System.Drawing.Point(184, 40);
            this.lbQuantidadeGadoFemea.Name = "lbQuantidadeGadoFemea";
            this.lbQuantidadeGadoFemea.Size = new System.Drawing.Size(44, 16);
            this.lbQuantidadeGadoFemea.TabIndex = 4;
            this.lbQuantidadeGadoFemea.Text = "XXXX";
            // 
            // lbQuantidadeGadoTotal
            // 
            this.lbQuantidadeGadoTotal.AutoSize = true;
            this.lbQuantidadeGadoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeGadoTotal.Location = new System.Drawing.Point(184, 60);
            this.lbQuantidadeGadoTotal.Name = "lbQuantidadeGadoTotal";
            this.lbQuantidadeGadoTotal.Size = new System.Drawing.Size(53, 16);
            this.lbQuantidadeGadoTotal.TabIndex = 5;
            this.lbQuantidadeGadoTotal.Text = "XXXXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade nesse Piquete:";
            // 
            // cbPiquet
            // 
            this.cbPiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPiquet.FormattingEnabled = true;
            this.cbPiquet.Location = new System.Drawing.Point(9, 37);
            this.cbPiquet.Name = "cbPiquet";
            this.cbPiquet.Size = new System.Drawing.Size(256, 24);
            this.cbPiquet.TabIndex = 62;
            this.cbPiquet.SelectedValueChanged += new System.EventHandler(this.cbPiquet_SelectedValueChanged);
            // 
            // lblqntPiquet
            // 
            this.lblqntPiquet.AutoSize = true;
            this.lblqntPiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqntPiquet.Location = new System.Drawing.Point(212, 64);
            this.lblqntPiquet.Name = "lblqntPiquet";
            this.lblqntPiquet.Size = new System.Drawing.Size(0, 16);
            this.lblqntPiquet.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome do Piquete:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbQuantidadeGadoMacho);
            this.groupBox1.Controls.Add(this.lbQuantidadeGadoFemea);
            this.groupBox1.Controls.Add(this.lbQuantidadeGadoTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 101);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantidade Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbPiquet);
            this.groupBox2.Controls.Add(this.lblqntPiquet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(267, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 101);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantidade por Piquete";
            // 
            // frmQuantidadeGado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 124);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(576, 162);
            this.MinimumSize = new System.Drawing.Size(576, 162);
            this.Name = "frmQuantidadeGado";
            this.Text = "Quantidade de Animais em:";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuantidadeGado_FormClosed);
            this.Shown += new System.EventHandler(this.frmQuantidadeGado_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbQuantidadeGadoMacho;
        private System.Windows.Forms.Label lbQuantidadeGadoFemea;
        private System.Windows.Forms.Label lbQuantidadeGadoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPiquet;
        private System.Windows.Forms.Label lblqntPiquet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}