namespace Ternakan
{
    partial class frmVacinacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacinacao));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgSelecaoVacinacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btVacinar = new System.Windows.Forms.Button();
            this.btSelecionarTudo = new System.Windows.Forms.Button();
            this.btDesmarcarTudo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.cbPiquet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSelecaoVacinacao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 413);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgSelecaoVacinacao
            // 
            this.dgSelecaoVacinacao.HeaderText = "";
            this.dgSelecaoVacinacao.Name = "dgSelecaoVacinacao";
            this.dgSelecaoVacinacao.Width = 20;
            // 
            // btVacinar
            // 
            this.btVacinar.Image = ((System.Drawing.Image)(resources.GetObject("btVacinar.Image")));
            this.btVacinar.Location = new System.Drawing.Point(145, 484);
            this.btVacinar.Name = "btVacinar";
            this.btVacinar.Size = new System.Drawing.Size(50, 50);
            this.btVacinar.TabIndex = 2;
            this.btVacinar.UseVisualStyleBackColor = true;
            this.btVacinar.Click += new System.EventHandler(this.btVacinar_Click);
            // 
            // btSelecionarTudo
            // 
            this.btSelecionarTudo.Image = ((System.Drawing.Image)(resources.GetObject("btSelecionarTudo.Image")));
            this.btSelecionarTudo.Location = new System.Drawing.Point(36, 484);
            this.btSelecionarTudo.Name = "btSelecionarTudo";
            this.btSelecionarTudo.Size = new System.Drawing.Size(50, 50);
            this.btSelecionarTudo.TabIndex = 1;
            this.btSelecionarTudo.UseVisualStyleBackColor = true;
            this.btSelecionarTudo.Click += new System.EventHandler(this.btSelecionarTudo_Click);
            // 
            // btDesmarcarTudo
            // 
            this.btDesmarcarTudo.Image = ((System.Drawing.Image)(resources.GetObject("btDesmarcarTudo.Image")));
            this.btDesmarcarTudo.Location = new System.Drawing.Point(259, 484);
            this.btDesmarcarTudo.Name = "btDesmarcarTudo";
            this.btDesmarcarTudo.Size = new System.Drawing.Size(50, 50);
            this.btDesmarcarTudo.TabIndex = 4;
            this.btDesmarcarTudo.UseVisualStyleBackColor = true;
            this.btDesmarcarTudo.Click += new System.EventHandler(this.btDesmarcarTudo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.White;
            this.btOK.Image = ((System.Drawing.Image)(resources.GetObject("btOK.Image")));
            this.btOK.Location = new System.Drawing.Point(291, 9);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(50, 50);
            this.btOK.TabIndex = 65;
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // cbPiquet
            // 
            this.cbPiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPiquet.FormattingEnabled = true;
            this.cbPiquet.Location = new System.Drawing.Point(12, 28);
            this.cbPiquet.Name = "cbPiquet";
            this.cbPiquet.Size = new System.Drawing.Size(273, 24);
            this.cbPiquet.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 16);
            this.label10.TabIndex = 64;
            this.label10.Text = "Escolha o piquete a ser selecionado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Escolher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Marcar Todos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Selecionar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Desmarcar Todos";
            // 
            // frmVacinacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.cbPiquet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btDesmarcarTudo);
            this.Controls.Add(this.btSelecionarTudo);
            this.Controls.Add(this.btVacinar);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmVacinacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacinação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVacinacao_FormClosed);
            this.Load += new System.EventHandler(this.frmVacinacao_Load);
            this.Shown += new System.EventHandler(this.frmVacinacao_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btVacinar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgSelecaoVacinacao;
        private System.Windows.Forms.Button btSelecionarTudo;
        private System.Windows.Forms.Button btDesmarcarTudo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.ComboBox cbPiquet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}