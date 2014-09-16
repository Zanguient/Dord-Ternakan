namespace Ternakan
{
    partial class frmRevomerVacaLactacao
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
            this.valido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btRevomerVacaLactacao = new System.Windows.Forms.Button();
            this.btSairRemoverVacasLactacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valido});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 485);
            this.dataGridView1.TabIndex = 35;
            // 
            // valido
            // 
            this.valido.HeaderText = "";
            this.valido.Name = "valido";
            this.valido.Width = 20;
            // 
            // btRevomerVacaLactacao
            // 
            this.btRevomerVacaLactacao.Location = new System.Drawing.Point(348, 527);
            this.btRevomerVacaLactacao.Name = "btRevomerVacaLactacao";
            this.btRevomerVacaLactacao.Size = new System.Drawing.Size(75, 23);
            this.btRevomerVacaLactacao.TabIndex = 1;
            this.btRevomerVacaLactacao.Text = "Remover";
            this.btRevomerVacaLactacao.UseVisualStyleBackColor = true;
            this.btRevomerVacaLactacao.Click += new System.EventHandler(this.btRevomerVacaLactacao_Click_1);
            // 
            // btSairRemoverVacasLactacao
            // 
            this.btSairRemoverVacasLactacao.Location = new System.Drawing.Point(429, 527);
            this.btSairRemoverVacasLactacao.Name = "btSairRemoverVacasLactacao";
            this.btSairRemoverVacasLactacao.Size = new System.Drawing.Size(75, 23);
            this.btSairRemoverVacasLactacao.TabIndex = 2;
            this.btSairRemoverVacasLactacao.Text = "Sair";
            this.btSairRemoverVacasLactacao.UseVisualStyleBackColor = true;
            this.btSairRemoverVacasLactacao.Click += new System.EventHandler(this.btSairRemoverVacasLactacao_Click);
            // 
            // frmRevomerVacaLactacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ternakan.Properties.Resources.fundo_do_programa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btSairRemoverVacasLactacao);
            this.Controls.Add(this.btRevomerVacaLactacao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRevomerVacaLactacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revomer Vaca da Lactação";
            this.Shown += new System.EventHandler(this.frmRevomerVacaLactacao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btRevomerVacaLactacao;
        private System.Windows.Forms.Button btSairRemoverVacasLactacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valido;
    }
}