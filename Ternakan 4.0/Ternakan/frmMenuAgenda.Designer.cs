namespace Ternakan
{
    partial class frmMenuAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAgenda));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConfirmarEvento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataEvento = new System.Windows.Forms.MaskedTextBox();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btDeletarEvento = new System.Windows.Forms.Button();
            this.dgEventos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(414, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar Evento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btConfirmarEvento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDataEvento);
            this.groupBox1.Controls.Add(this.txtEvento);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirmar Evento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data";
            // 
            // btConfirmarEvento
            // 
            this.btConfirmarEvento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConfirmarEvento.BackgroundImage")));
            this.btConfirmarEvento.Location = new System.Drawing.Point(175, 234);
            this.btConfirmarEvento.Name = "btConfirmarEvento";
            this.btConfirmarEvento.Size = new System.Drawing.Size(50, 50);
            this.btConfirmarEvento.TabIndex = 3;
            this.btConfirmarEvento.UseVisualStyleBackColor = true;
            this.btConfirmarEvento.Click += new System.EventHandler(this.btConfirmarEvento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Evento";
            // 
            // txtDataEvento
            // 
            this.txtDataEvento.Location = new System.Drawing.Point(6, 34);
            this.txtDataEvento.Mask = "00/00/0000";
            this.txtDataEvento.Name = "txtDataEvento";
            this.txtDataEvento.Size = new System.Drawing.Size(100, 22);
            this.txtDataEvento.TabIndex = 1;
            this.txtDataEvento.ValidatingType = typeof(System.DateTime);
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(9, 72);
            this.txtEvento.Multiline = true;
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(380, 154);
            this.txtEvento.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btDeletarEvento);
            this.tabPage2.Controls.Add(this.dgEventos);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(414, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizar todos eventos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cancelar Evento";
            // 
            // btDeletarEvento
            // 
            this.btDeletarEvento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeletarEvento.BackgroundImage")));
            this.btDeletarEvento.Location = new System.Drawing.Point(182, 247);
            this.btDeletarEvento.Name = "btDeletarEvento";
            this.btDeletarEvento.Size = new System.Drawing.Size(50, 50);
            this.btDeletarEvento.TabIndex = 2;
            this.btDeletarEvento.UseVisualStyleBackColor = true;
            this.btDeletarEvento.Click += new System.EventHandler(this.btDeletarEvento_Click);
            // 
            // dgEventos
            // 
            this.dgEventos.AllowUserToAddRows = false;
            this.dgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEventos.Location = new System.Drawing.Point(6, 6);
            this.dgEventos.Name = "dgEventos";
            this.dgEventos.Size = new System.Drawing.Size(402, 235);
            this.dgEventos.TabIndex = 1;
            // 
            // frmMenuAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 380);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(461, 418);
            this.MinimumSize = new System.Drawing.Size(461, 418);
            this.Name = "frmMenuAgenda";
            this.Text = "Agenda";
            this.Shown += new System.EventHandler(this.frmMenuAgenda_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConfirmarEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDataEvento;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.DataGridView dgEventos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDeletarEvento;
    }
}