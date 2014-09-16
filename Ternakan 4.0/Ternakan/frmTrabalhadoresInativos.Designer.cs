namespace Ternakan
{
    partial class frmTrabalhadoresInativos
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dgvTrabalhadores = new System.Windows.Forms.DataGridView();
            this.btApagar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhadores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(28, 30);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(395, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(429, 27);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // dgvTrabalhadores
            // 
            this.dgvTrabalhadores.AllowUserToAddRows = false;
            this.dgvTrabalhadores.AllowUserToDeleteRows = false;
            this.dgvTrabalhadores.AllowUserToOrderColumns = true;
            this.dgvTrabalhadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabalhadores.Location = new System.Drawing.Point(12, 69);
            this.dgvTrabalhadores.Name = "dgvTrabalhadores";
            this.dgvTrabalhadores.ReadOnly = true;
            this.dgvTrabalhadores.Size = new System.Drawing.Size(502, 401);
            this.dgvTrabalhadores.TabIndex = 3;
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(176, 476);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 4;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(267, 476);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 5;
            this.btImprimir.Text = "Im&primir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // frmTrabalhadoresInativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 517);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.dgvTrabalhadores);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisar);
            this.MaximizeBox = false;
            this.Name = "frmTrabalhadoresInativos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Trabalhadores Inativos";
            this.Shown += new System.EventHandler(this.frmTrabalhadoresInativos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabalhadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView dgvTrabalhadores;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btImprimir;
    }
}