namespace Ternakan
{
    partial class frmResultadoBusca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultadoBusca));
            this.dgResultadoBusca = new System.Windows.Forms.DataGridView();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btImprimirGadoRegistrado = new System.Windows.Forms.Button();
            this.btAlterarPiquet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResultadoBusca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResultadoBusca
            // 
            this.dgResultadoBusca.AllowUserToAddRows = false;
            this.dgResultadoBusca.AllowUserToDeleteRows = false;
            this.dgResultadoBusca.AllowUserToOrderColumns = true;
            this.dgResultadoBusca.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgResultadoBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResultadoBusca.Location = new System.Drawing.Point(0, 0);
            this.dgResultadoBusca.Name = "dgResultadoBusca";
            this.dgResultadoBusca.Size = new System.Drawing.Size(784, 475);
            this.dgResultadoBusca.TabIndex = 37;
            this.dgResultadoBusca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgResultadoBusca.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResultadoBusca_CellContentDoubleClick);
            this.dgResultadoBusca.SelectionChanged += new System.EventHandler(this.dgResultadoBusca_SelectionChanged);
            this.dgResultadoBusca.Click += new System.EventHandler(this.btSairResultadoBusca_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSelecionar.BackgroundImage")));
            this.btSelecionar.Location = new System.Drawing.Point(261, 481);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(50, 50);
            this.btSelecionar.TabIndex = 1;
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSairResultadoBusca_Click);
            // 
            // btImprimirGadoRegistrado
            // 
            this.btImprimirGadoRegistrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btImprimirGadoRegistrado.BackgroundImage")));
            this.btImprimirGadoRegistrado.Location = new System.Drawing.Point(368, 481);
            this.btImprimirGadoRegistrado.Name = "btImprimirGadoRegistrado";
            this.btImprimirGadoRegistrado.Size = new System.Drawing.Size(50, 50);
            this.btImprimirGadoRegistrado.TabIndex = 2;
            this.btImprimirGadoRegistrado.UseVisualStyleBackColor = true;
            this.btImprimirGadoRegistrado.Click += new System.EventHandler(this.btImprimirGadoRegistrado_Click);
            // 
            // btAlterarPiquet
            // 
            this.btAlterarPiquet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAlterarPiquet.BackgroundImage")));
            this.btAlterarPiquet.Location = new System.Drawing.Point(477, 481);
            this.btAlterarPiquet.Name = "btAlterarPiquet";
            this.btAlterarPiquet.Size = new System.Drawing.Size(50, 50);
            this.btAlterarPiquet.TabIndex = 38;
            this.btAlterarPiquet.UseVisualStyleBackColor = true;
            this.btAlterarPiquet.Click += new System.EventHandler(this.btAlterarPiquet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Selecionar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Imprimir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Alterar Piquete";
            // 
            // frmResultadoBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAlterarPiquet);
            this.Controls.Add(this.btImprimirGadoRegistrado);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.dgResultadoBusca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmResultadoBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado da Busca";
            this.Activated += new System.EventHandler(this.dgResultadoBusca_SelectionChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmResultadoBusca_FormClosed);
            this.Shown += new System.EventHandler(this.frmResultadoBusca_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgResultadoBusca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgResultadoBusca;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btImprimirGadoRegistrado;
        private System.Windows.Forms.Button btAlterarPiquet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}