namespace Ternakan
{
    partial class frmMortalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMortalidade));
            this.label3 = new System.Windows.Forms.Label();
            this.rtObservacoesGadoMorto = new System.Windows.Forms.RichTextBox();
            this.txtCasoMorte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataMorte = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Causa:";
            // 
            // rtObservacoesGadoMorto
            // 
            this.rtObservacoesGadoMorto.Location = new System.Drawing.Point(6, 115);
            this.rtObservacoesGadoMorto.Name = "rtObservacoesGadoMorto";
            this.rtObservacoesGadoMorto.Size = new System.Drawing.Size(723, 213);
            this.rtObservacoesGadoMorto.TabIndex = 4;
            this.rtObservacoesGadoMorto.Text = "";
            // 
            // txtCasoMorte
            // 
            this.txtCasoMorte.Location = new System.Drawing.Point(389, 38);
            this.txtCasoMorte.Name = "txtCasoMorte";
            this.txtCasoMorte.Size = new System.Drawing.Size(343, 22);
            this.txtCasoMorte.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Observações:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(342, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbGado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDataMorte);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCasoMorte);
            this.groupBox1.Controls.Add(this.rtObservacoesGadoMorto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Mortes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Confirmar";
            // 
            // cbGado
            // 
            this.cbGado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGado.FormattingEnabled = true;
            this.cbGado.Location = new System.Drawing.Point(9, 38);
            this.cbGado.Name = "cbGado";
            this.cbGado.Size = new System.Drawing.Size(374, 24);
            this.cbGado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Animal:";
            // 
            // txtDataMorte
            // 
            this.txtDataMorte.Location = new System.Drawing.Point(122, 68);
            this.txtDataMorte.Mask = "00/00/0000";
            this.txtDataMorte.Name = "txtDataMorte";
            this.txtDataMorte.Size = new System.Drawing.Size(106, 22);
            this.txtDataMorte.TabIndex = 3;
            this.txtDataMorte.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Data da Morte:";
            // 
            // frmMortalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 435);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(777, 473);
            this.MinimumSize = new System.Drawing.Size(777, 473);
            this.Name = "frmMortalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Mortalidade";
            this.Shown += new System.EventHandler(this.frmMortalidade_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtObservacoesGadoMorto;
        private System.Windows.Forms.TextBox txtCasoMorte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtDataMorte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}