namespace Ternakan
{
    partial class frmPiquet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPiquet));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Adicionar = new System.Windows.Forms.TabPage();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.btCadastrarPiquet = new System.Windows.Forms.Button();
            this.txtNomePiquet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroPiquet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dgPiquets = new System.Windows.Forms.DataGridView();
            this.txtNovoNomePiquet = new System.Windows.Forms.TextBox();
            this.txtNovoNumeroPiquet = new System.Windows.Forms.TextBox();
            this.lblNovoNumeroPiquet = new System.Windows.Forms.Label();
            this.lblNovoNomePiquet = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Adicionar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiquets)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Adicionar);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(441, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // Adicionar
            // 
            this.Adicionar.Controls.Add(this.lblCadastrar);
            this.Adicionar.Controls.Add(this.btCadastrarPiquet);
            this.Adicionar.Controls.Add(this.txtNomePiquet);
            this.Adicionar.Controls.Add(this.label2);
            this.Adicionar.Controls.Add(this.txtNumeroPiquet);
            this.Adicionar.Controls.Add(this.label1);
            this.Adicionar.Location = new System.Drawing.Point(4, 25);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Padding = new System.Windows.Forms.Padding(3);
            this.Adicionar.Size = new System.Drawing.Size(433, 289);
            this.Adicionar.TabIndex = 0;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(167, 99);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(76, 16);
            this.lblCadastrar.TabIndex = 10;
            this.lblCadastrar.Text = "Cadastrar";
            // 
            // btCadastrarPiquet
            // 
            this.btCadastrarPiquet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadastrarPiquet.BackgroundImage")));
            this.btCadastrarPiquet.Location = new System.Drawing.Point(179, 45);
            this.btCadastrarPiquet.Name = "btCadastrarPiquet";
            this.btCadastrarPiquet.Size = new System.Drawing.Size(50, 50);
            this.btCadastrarPiquet.TabIndex = 3;
            this.btCadastrarPiquet.UseVisualStyleBackColor = true;
            this.btCadastrarPiquet.Click += new System.EventHandler(this.btCadastrarPiquet_Click);
            // 
            // txtNomePiquet
            // 
            this.txtNomePiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePiquet.Location = new System.Drawing.Point(65, 19);
            this.txtNomePiquet.Name = "txtNomePiquet";
            this.txtNomePiquet.Size = new System.Drawing.Size(357, 22);
            this.txtNomePiquet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // txtNumeroPiquet
            // 
            this.txtNumeroPiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPiquet.Location = new System.Drawing.Point(2, 19);
            this.txtNumeroPiquet.Name = "txtNumeroPiquet";
            this.txtNumeroPiquet.Size = new System.Drawing.Size(54, 22);
            this.txtNumeroPiquet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbCancelar);
            this.tabPage2.Controls.Add(this.btCancelar);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btAlterar);
            this.tabPage2.Controls.Add(this.dgPiquets);
            this.tabPage2.Controls.Add(this.txtNovoNomePiquet);
            this.tabPage2.Controls.Add(this.txtNovoNumeroPiquet);
            this.tabPage2.Controls.Add(this.lblNovoNumeroPiquet);
            this.tabPage2.Controls.Add(this.lblNovoNomePiquet);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(433, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbCancelar
            // 
            this.lbCancelar.AutoSize = true;
            this.lbCancelar.Location = new System.Drawing.Point(82, 260);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(70, 16);
            this.lbCancelar.TabIndex = 112;
            this.lbCancelar.Text = "Cancelar";
            this.lbCancelar.Visible = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancelar.BackgroundImage")));
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(92, 207);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(50, 50);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Visible = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 52;
            this.label13.Text = "Alterar";
            // 
            // btAlterar
            // 
            this.btAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAlterar.BackgroundImage")));
            this.btAlterar.Location = new System.Drawing.Point(9, 207);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(50, 50);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dgPiquets
            // 
            this.dgPiquets.AllowUserToAddRows = false;
            this.dgPiquets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPiquets.Location = new System.Drawing.Point(6, 6);
            this.dgPiquets.MultiSelect = false;
            this.dgPiquets.Name = "dgPiquets";
            this.dgPiquets.ReadOnly = true;
            this.dgPiquets.Size = new System.Drawing.Size(421, 193);
            this.dgPiquets.TabIndex = 5;
            // 
            // txtNovoNomePiquet
            // 
            this.txtNovoNomePiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoNomePiquet.Location = new System.Drawing.Point(113, 177);
            this.txtNovoNomePiquet.Name = "txtNovoNomePiquet";
            this.txtNovoNomePiquet.Size = new System.Drawing.Size(310, 22);
            this.txtNovoNomePiquet.TabIndex = 2;
            this.txtNovoNomePiquet.Visible = false;
            // 
            // txtNovoNumeroPiquet
            // 
            this.txtNovoNumeroPiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoNumeroPiquet.Location = new System.Drawing.Point(9, 177);
            this.txtNovoNumeroPiquet.Name = "txtNovoNumeroPiquet";
            this.txtNovoNumeroPiquet.Size = new System.Drawing.Size(85, 22);
            this.txtNovoNumeroPiquet.TabIndex = 1;
            this.txtNovoNumeroPiquet.Visible = false;
            // 
            // lblNovoNumeroPiquet
            // 
            this.lblNovoNumeroPiquet.AutoSize = true;
            this.lblNovoNumeroPiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoNumeroPiquet.Location = new System.Drawing.Point(6, 161);
            this.lblNovoNumeroPiquet.Name = "lblNovoNumeroPiquet";
            this.lblNovoNumeroPiquet.Size = new System.Drawing.Size(107, 16);
            this.lblNovoNumeroPiquet.TabIndex = 49;
            this.lblNovoNumeroPiquet.Text = "Novo Número:";
            this.lblNovoNumeroPiquet.Visible = false;
            // 
            // lblNovoNomePiquet
            // 
            this.lblNovoNomePiquet.AutoSize = true;
            this.lblNovoNomePiquet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoNomePiquet.Location = new System.Drawing.Point(110, 161);
            this.lblNovoNomePiquet.Name = "lblNovoNomePiquet";
            this.lblNovoNomePiquet.Size = new System.Drawing.Size(94, 16);
            this.lblNovoNomePiquet.TabIndex = 48;
            this.lblNovoNomePiquet.Text = "Novo Nome:";
            this.lblNovoNomePiquet.Visible = false;
            // 
            // frmPiquet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 343);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(481, 381);
            this.MinimumSize = new System.Drawing.Size(481, 381);
            this.Name = "frmPiquet";
            this.Text = "Piquet";
            this.Shown += new System.EventHandler(this.frmPiquet_Shown);
            this.tabControl1.ResumeLayout(false);
            this.Adicionar.ResumeLayout(false);
            this.Adicionar.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPiquets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Adicionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btCadastrarPiquet;
        private System.Windows.Forms.TextBox txtNomePiquet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroPiquet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPiquets;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Label lblCadastrar;
        protected System.Windows.Forms.TextBox txtNovoNomePiquet;
        protected System.Windows.Forms.TextBox txtNovoNumeroPiquet;
        protected System.Windows.Forms.Label lblNovoNumeroPiquet;
        protected System.Windows.Forms.Label lblNovoNomePiquet;
        protected System.Windows.Forms.Label lbCancelar;
        protected System.Windows.Forms.Button btCancelar;
    }
}