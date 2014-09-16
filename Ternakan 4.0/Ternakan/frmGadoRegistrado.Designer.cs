namespace Ternakan
{
    partial class frmGadoRegistrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGadoRegistrado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvGadosRegistrados = new System.Windows.Forms.DataGridView();
            this.btImprimirGadoRegistrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGadosRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvGadosRegistrados);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 477);
            this.panel1.TabIndex = 42;
            // 
            // dgvGadosRegistrados
            // 
            this.dgvGadosRegistrados.AllowUserToAddRows = false;
            this.dgvGadosRegistrados.AllowUserToDeleteRows = false;
            this.dgvGadosRegistrados.AllowUserToOrderColumns = true;
            this.dgvGadosRegistrados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGadosRegistrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGadosRegistrados.Location = new System.Drawing.Point(0, 0);
            this.dgvGadosRegistrados.Margin = new System.Windows.Forms.Padding(10, 10, 10, 50);
            this.dgvGadosRegistrados.Name = "dgvGadosRegistrados";
            this.dgvGadosRegistrados.ReadOnly = true;
            this.dgvGadosRegistrados.Size = new System.Drawing.Size(784, 477);
            this.dgvGadosRegistrados.TabIndex = 42;
            // 
            // btImprimirGadoRegistrado
            // 
            this.btImprimirGadoRegistrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btImprimirGadoRegistrado.BackgroundImage")));
            this.btImprimirGadoRegistrado.Location = new System.Drawing.Point(375, 485);
            this.btImprimirGadoRegistrado.Name = "btImprimirGadoRegistrado";
            this.btImprimirGadoRegistrado.Size = new System.Drawing.Size(50, 50);
            this.btImprimirGadoRegistrado.TabIndex = 2;
            this.btImprimirGadoRegistrado.UseVisualStyleBackColor = true;
            this.btImprimirGadoRegistrado.Click += new System.EventHandler(this.btImprimirGadoRegistrado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Imprimir";
            // 
            // frmGadoRegistrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btImprimirGadoRegistrado);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmGadoRegistrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animais Registrados";
            this.Shown += new System.EventHandler(this.frmGadoRegistrado_Shown);
            this.Resize += new System.EventHandler(this.frmGadoRegistrado_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGadosRegistrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btImprimirGadoRegistrado;
        private System.Windows.Forms.DataGridView dgvGadosRegistrados;
        private System.Windows.Forms.Label label1;
    }
}