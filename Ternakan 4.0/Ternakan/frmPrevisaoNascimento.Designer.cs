namespace Ternakan
{
    partial class frmPrevisaoNascimento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrevisaoNascimento));
            this.cRUZAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVirtual = new Ternakan.dsVirtual();
            this.label1 = new System.Windows.Forms.Label();
            this.btSairPrevisaoNascimento = new System.Windows.Forms.Button();
            this.dgListaPrevisaoNascimento = new System.Windows.Forms.DataGridView();
            this.NUMERO_VACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reprodutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDepois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cRUZAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVirtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPrevisaoNascimento)).BeginInit();
            this.SuspendLayout();
            // 
            // cRUZAMENTOBindingSource
            // 
            this.cRUZAMENTOBindingSource.DataMember = "CRUZAMENTO";
            this.cRUZAMENTOBindingSource.DataSource = this.dsVirtual;
            // 
            // dsVirtual
            // 
            this.dsVirtual.DataSetName = "dsVirtual";
            this.dsVirtual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sair";
            // 
            // btSairPrevisaoNascimento
            // 
            this.btSairPrevisaoNascimento.Image = ((System.Drawing.Image)(resources.GetObject("btSairPrevisaoNascimento.Image")));
            this.btSairPrevisaoNascimento.Location = new System.Drawing.Point(366, 489);
            this.btSairPrevisaoNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.btSairPrevisaoNascimento.Name = "btSairPrevisaoNascimento";
            this.btSairPrevisaoNascimento.Size = new System.Drawing.Size(50, 50);
            this.btSairPrevisaoNascimento.TabIndex = 40;
            this.btSairPrevisaoNascimento.UseVisualStyleBackColor = true;
            this.btSairPrevisaoNascimento.Click += new System.EventHandler(this.btSairPrevisaoNascimento_Click_1);
            // 
            // dgListaPrevisaoNascimento
            // 
            this.dgListaPrevisaoNascimento.AllowUserToAddRows = false;
            this.dgListaPrevisaoNascimento.AllowUserToDeleteRows = false;
            this.dgListaPrevisaoNascimento.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgListaPrevisaoNascimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaPrevisaoNascimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMERO_VACA,
            this.Vaca,
            this.Reprodutor,
            this.Data,
            this.DataDepois});
            this.dgListaPrevisaoNascimento.Location = new System.Drawing.Point(1, 5);
            this.dgListaPrevisaoNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dgListaPrevisaoNascimento.Name = "dgListaPrevisaoNascimento";
            this.dgListaPrevisaoNascimento.ReadOnly = true;
            this.dgListaPrevisaoNascimento.Size = new System.Drawing.Size(782, 473);
            this.dgListaPrevisaoNascimento.TabIndex = 41;
            // 
            // NUMERO_VACA
            // 
            this.NUMERO_VACA.HeaderText = "Numero";
            this.NUMERO_VACA.Name = "NUMERO_VACA";
            this.NUMERO_VACA.ReadOnly = true;
            this.NUMERO_VACA.Width = 125;
            // 
            // Vaca
            // 
            this.Vaca.DataPropertyName = "NOME_VACA";
            this.Vaca.HeaderText = "Nome da vaca:";
            this.Vaca.Name = "Vaca";
            this.Vaca.ReadOnly = true;
            this.Vaca.Width = 350;
            // 
            // Reprodutor
            // 
            this.Reprodutor.DataPropertyName = "NOME_BOI";
            this.Reprodutor.HeaderText = "Nome do Reprodutor";
            this.Reprodutor.Name = "Reprodutor";
            this.Reprodutor.ReadOnly = true;
            this.Reprodutor.Width = 350;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DATA_CRUZAMENTO";
            this.Data.HeaderText = "Data de Cruzamento";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 200;
            // 
            // DataDepois
            // 
            this.DataDepois.DataPropertyName = "DATA_PREVISTA";
            this.DataDepois.HeaderText = "Data Prevista:";
            this.DataDepois.Name = "DataDepois";
            this.DataDepois.ReadOnly = true;
            this.DataDepois.Width = 200;
            // 
            // frmPrevisaoNascimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSairPrevisaoNascimento);
            this.Controls.Add(this.dgListaPrevisaoNascimento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPrevisaoNascimento";
            this.Text = "Previsão de Nascimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmPrevisaoNascimento_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cRUZAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVirtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaPrevisaoNascimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cRUZAMENTOBindingSource;
        private dsVirtual dsVirtual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSairPrevisaoNascimento;
        protected System.Windows.Forms.DataGridView dgListaPrevisaoNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO_VACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reprodutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDepois;
    }
}