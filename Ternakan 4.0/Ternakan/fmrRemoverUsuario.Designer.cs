namespace Ternakan
{
    partial class fmrRemoverUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrRemoverUsuario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btRemoverUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btRemoverUsuario
            // 
            this.btRemoverUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRemoverUsuario.BackgroundImage")));
            this.btRemoverUsuario.Location = new System.Drawing.Point(257, 319);
            this.btRemoverUsuario.Name = "btRemoverUsuario";
            this.btRemoverUsuario.Size = new System.Drawing.Size(50, 50);
            this.btRemoverUsuario.TabIndex = 1;
            this.btRemoverUsuario.UseVisualStyleBackColor = true;
            this.btRemoverUsuario.Click += new System.EventHandler(this.btRemoverUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Remover Usuário";
            // 
            // fmrRemoverUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoverUsuario);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 439);
            this.MinimumSize = new System.Drawing.Size(565, 439);
            this.Name = "fmrRemoverUsuario";
            this.Text = "Lista de Usuário";
            this.Shown += new System.EventHandler(this.fmrRemoverUsuario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btRemoverUsuario;
        private System.Windows.Forms.Label label1;
    }
}