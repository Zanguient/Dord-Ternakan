namespace Ternakan
{
    partial class frmAdicionarPiquets
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
            this.btVoltarAdicionarPiquet = new System.Windows.Forms.Button();
            this.btCadastrarPiquet = new System.Windows.Forms.Button();
            this.txtNomePiquet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroPiquet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btVoltarAdicionarPiquet);
            this.groupBox1.Controls.Add(this.btCadastrarPiquet);
            this.groupBox1.Controls.Add(this.txtNomePiquet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumeroPiquet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Piquet";
            // 
            // btVoltarAdicionarPiquet
            // 
            this.btVoltarAdicionarPiquet.Location = new System.Drawing.Point(100, 74);
            this.btVoltarAdicionarPiquet.Name = "btVoltarAdicionarPiquet";
            this.btVoltarAdicionarPiquet.Size = new System.Drawing.Size(75, 23);
            this.btVoltarAdicionarPiquet.TabIndex = 4;
            this.btVoltarAdicionarPiquet.Text = "Voltar";
            this.btVoltarAdicionarPiquet.UseVisualStyleBackColor = true;
            this.btVoltarAdicionarPiquet.Click += new System.EventHandler(this.btVoltarAdicionarPiquet_Click);
            // 
            // btCadastrarPiquet
            // 
            this.btCadastrarPiquet.Location = new System.Drawing.Point(19, 74);
            this.btCadastrarPiquet.Name = "btCadastrarPiquet";
            this.btCadastrarPiquet.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarPiquet.TabIndex = 3;
            this.btCadastrarPiquet.Text = "Cadastrar";
            this.btCadastrarPiquet.UseVisualStyleBackColor = true;
            this.btCadastrarPiquet.Click += new System.EventHandler(this.btCadastrarPiquet_Click);
            // 
            // txtNomePiquet
            // 
            this.txtNomePiquet.Location = new System.Drawing.Point(82, 48);
            this.txtNomePiquet.Name = "txtNomePiquet";
            this.txtNomePiquet.Size = new System.Drawing.Size(357, 20);
            this.txtNomePiquet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtNumeroPiquet
            // 
            this.txtNumeroPiquet.Location = new System.Drawing.Point(19, 48);
            this.txtNumeroPiquet.Name = "txtNumeroPiquet";
            this.txtNumeroPiquet.Size = new System.Drawing.Size(44, 20);
            this.txtNumeroPiquet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // frmAdicionarPiquets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ternakan.Properties.Resources.fundo_do_programa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdicionarPiquets";
            this.Text = "Adicionar Piquets";
            this.Shown += new System.EventHandler(this.frmAdicionarPiquets_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdicionarPiquets_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeroPiquet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarPiquet;
        private System.Windows.Forms.TextBox txtNomePiquet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btVoltarAdicionarPiquet;
    }
}