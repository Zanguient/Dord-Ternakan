namespace Ternakan
{
    partial class frmBusca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusca));
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbIntervalo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtFim = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDtNascimento = new System.Windows.Forms.RadioButton();
            this.rbNumeroPiquet = new System.Windows.Forms.RadioButton();
            this.rbNomePiquet = new System.Windows.Forms.RadioButton();
            this.rbBuscaTodos = new System.Windows.Forms.RadioButton();
            this.rbBuscaFemea = new System.Windows.Forms.RadioButton();
            this.rbBuscaMacho = new System.Windows.Forms.RadioButton();
            this.rbFiltroRaca = new System.Windows.Forms.RadioButton();
            this.rbFiltroNome = new System.Windows.Forms.RadioButton();
            this.rbFiltroNumero = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbIntervalo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(12, 18);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(285, 22);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyDown);
            // 
            // btBuscar
            // 
            this.btBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscar.BackgroundImage")));
            this.btBuscar.Location = new System.Drawing.Point(303, 18);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(50, 50);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.gbIntervalo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema de Busca";
            this.groupBox1.UseCompatibleTextRendering = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbIntervalo
            // 
            this.gbIntervalo.Controls.Add(this.label2);
            this.gbIntervalo.Controls.Add(this.txtInicio);
            this.gbIntervalo.Controls.Add(this.txtFim);
            this.gbIntervalo.Controls.Add(this.label1);
            this.gbIntervalo.Location = new System.Drawing.Point(185, 49);
            this.gbIntervalo.Name = "gbIntervalo";
            this.gbIntervalo.Size = new System.Drawing.Size(112, 103);
            this.gbIntervalo.TabIndex = 8;
            this.gbIntervalo.TabStop = false;
            this.gbIntervalo.Text = "Intervalo";
            this.gbIntervalo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "De:";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(12, 34);
            this.txtInicio.Mask = "00/00/0000";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(84, 22);
            this.txtInicio.TabIndex = 1;
            this.txtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(13, 77);
            this.txtFim.Mask = "00/00/0000";
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(83, 22);
            this.txtFim.TabIndex = 2;
            this.txtFim.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Até:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDtNascimento);
            this.groupBox2.Controls.Add(this.rbNumeroPiquet);
            this.groupBox2.Controls.Add(this.rbNomePiquet);
            this.groupBox2.Controls.Add(this.rbBuscaTodos);
            this.groupBox2.Controls.Add(this.rbBuscaFemea);
            this.groupBox2.Controls.Add(this.rbBuscaMacho);
            this.groupBox2.Controls.Add(this.rbFiltroRaca);
            this.groupBox2.Controls.Add(this.rbFiltroNome);
            this.groupBox2.Controls.Add(this.rbFiltroNumero);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // rbDtNascimento
            // 
            this.rbDtNascimento.AutoSize = true;
            this.rbDtNascimento.Location = new System.Drawing.Point(6, 201);
            this.rbDtNascimento.Name = "rbDtNascimento";
            this.rbDtNascimento.Size = new System.Drawing.Size(164, 20);
            this.rbDtNascimento.TabIndex = 8;
            this.rbDtNascimento.Text = "Data de nascimento";
            this.rbDtNascimento.UseVisualStyleBackColor = true;
            this.rbDtNascimento.CheckedChanged += new System.EventHandler(this.rbDtNascimento_CheckedChanged);
            // 
            // rbNumeroPiquet
            // 
            this.rbNumeroPiquet.AutoSize = true;
            this.rbNumeroPiquet.Location = new System.Drawing.Point(6, 71);
            this.rbNumeroPiquet.Name = "rbNumeroPiquet";
            this.rbNumeroPiquet.Size = new System.Drawing.Size(150, 20);
            this.rbNumeroPiquet.TabIndex = 3;
            this.rbNumeroPiquet.Text = "Número do Piquet";
            this.rbNumeroPiquet.UseVisualStyleBackColor = true;
            // 
            // rbNomePiquet
            // 
            this.rbNomePiquet.AutoSize = true;
            this.rbNomePiquet.Location = new System.Drawing.Point(6, 175);
            this.rbNomePiquet.Name = "rbNomePiquet";
            this.rbNomePiquet.Size = new System.Drawing.Size(137, 20);
            this.rbNomePiquet.TabIndex = 7;
            this.rbNomePiquet.Text = "Nome do Piquet";
            this.rbNomePiquet.UseVisualStyleBackColor = true;
            // 
            // rbBuscaTodos
            // 
            this.rbBuscaTodos.AutoSize = true;
            this.rbBuscaTodos.Checked = true;
            this.rbBuscaTodos.Location = new System.Drawing.Point(6, 227);
            this.rbBuscaTodos.Name = "rbBuscaTodos";
            this.rbBuscaTodos.Size = new System.Drawing.Size(71, 20);
            this.rbBuscaTodos.TabIndex = 9;
            this.rbBuscaTodos.TabStop = true;
            this.rbBuscaTodos.Text = "Todos";
            this.rbBuscaTodos.UseVisualStyleBackColor = true;
            // 
            // rbBuscaFemea
            // 
            this.rbBuscaFemea.AutoSize = true;
            this.rbBuscaFemea.Location = new System.Drawing.Point(6, 97);
            this.rbBuscaFemea.Name = "rbBuscaFemea";
            this.rbBuscaFemea.Size = new System.Drawing.Size(74, 20);
            this.rbBuscaFemea.TabIndex = 4;
            this.rbBuscaFemea.Text = "Fêmea";
            this.rbBuscaFemea.UseVisualStyleBackColor = true;
            // 
            // rbBuscaMacho
            // 
            this.rbBuscaMacho.AutoSize = true;
            this.rbBuscaMacho.Location = new System.Drawing.Point(6, 123);
            this.rbBuscaMacho.Name = "rbBuscaMacho";
            this.rbBuscaMacho.Size = new System.Drawing.Size(72, 20);
            this.rbBuscaMacho.TabIndex = 5;
            this.rbBuscaMacho.Text = "Macho";
            this.rbBuscaMacho.UseVisualStyleBackColor = true;
            // 
            // rbFiltroRaca
            // 
            this.rbFiltroRaca.AutoSize = true;
            this.rbFiltroRaca.Location = new System.Drawing.Point(6, 149);
            this.rbFiltroRaca.Name = "rbFiltroRaca";
            this.rbFiltroRaca.Size = new System.Drawing.Size(63, 20);
            this.rbFiltroRaca.TabIndex = 6;
            this.rbFiltroRaca.Text = "Raça";
            this.rbFiltroRaca.UseVisualStyleBackColor = true;
            // 
            // rbFiltroNome
            // 
            this.rbFiltroNome.AutoSize = true;
            this.rbFiltroNome.Location = new System.Drawing.Point(6, 19);
            this.rbFiltroNome.Name = "rbFiltroNome";
            this.rbFiltroNome.Size = new System.Drawing.Size(67, 20);
            this.rbFiltroNome.TabIndex = 1;
            this.rbFiltroNome.Text = "Nome";
            this.rbFiltroNome.UseVisualStyleBackColor = true;
            // 
            // rbFiltroNumero
            // 
            this.rbFiltroNumero.AutoSize = true;
            this.rbFiltroNumero.Location = new System.Drawing.Point(6, 45);
            this.rbFiltroNumero.Name = "rbFiltroNumero";
            this.rbFiltroNumero.Size = new System.Drawing.Size(80, 20);
            this.rbFiltroNumero.TabIndex = 2;
            this.rbFiltroNumero.Text = "Número";
            this.rbFiltroNumero.UseVisualStyleBackColor = true;
            // 
            // frmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 337);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 375);
            this.MinimumSize = new System.Drawing.Size(411, 375);
            this.Name = "frmBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de Busca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBusca_FormClosed);
            this.Load += new System.EventHandler(this.frmBusca_Load);
            this.Shown += new System.EventHandler(this.frmBusca_Shown);
            this.SizeChanged += new System.EventHandler(this.frmBusca_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbIntervalo.ResumeLayout(false);
            this.gbIntervalo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBuscaFemea;
        private System.Windows.Forms.RadioButton rbBuscaMacho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFiltroRaca;
        private System.Windows.Forms.RadioButton rbFiltroNome;
        private System.Windows.Forms.RadioButton rbFiltroNumero;
        private System.Windows.Forms.RadioButton rbBuscaTodos;
        private System.Windows.Forms.RadioButton rbNumeroPiquet;
        private System.Windows.Forms.RadioButton rbNomePiquet;
        private System.Windows.Forms.RadioButton rbDtNascimento;
        private System.Windows.Forms.GroupBox gbIntervalo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtInicio;
        private System.Windows.Forms.MaskedTextBox txtFim;
        private System.Windows.Forms.Label label1;
    }
}