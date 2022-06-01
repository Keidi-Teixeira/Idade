namespace Idade
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnCalcularIdade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.btnCalculaIdadeMaisPrecisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(16, 135);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(269, 26);
            this.dtpNascimento.TabIndex = 0;
            this.dtpNascimento.Value = new System.DateTime(2022, 6, 1, 15, 13, 14, 0);
            // 
            // btnCalcularIdade
            // 
            this.btnCalcularIdade.Location = new System.Drawing.Point(16, 176);
            this.btnCalcularIdade.Name = "btnCalcularIdade";
            this.btnCalcularIdade.Size = new System.Drawing.Size(122, 31);
            this.btnCalcularIdade.TabIndex = 1;
            this.btnCalcularIdade.Text = "Calcular";
            this.btnCalcularIdade.UseVisualStyleBackColor = true;
            this.btnCalcularIdade.Click += new System.EventHandler(this.btnIdade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe sua data de nascimento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIdade.Location = new System.Drawing.Point(16, 229);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(259, 22);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "                                                              ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Informe seu nome completo:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(16, 66);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(269, 26);
            this.textNome.TabIndex = 5;
            this.textNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCalculaIdadeMaisPrecisa
            // 
            this.btnCalculaIdadeMaisPrecisa.Location = new System.Drawing.Point(171, 176);
            this.btnCalculaIdadeMaisPrecisa.Name = "btnCalculaIdadeMaisPrecisa";
            this.btnCalculaIdadeMaisPrecisa.Size = new System.Drawing.Size(114, 31);
            this.btnCalculaIdadeMaisPrecisa.TabIndex = 6;
            this.btnCalculaIdadeMaisPrecisa.Text = "Idade precisa";
            this.btnCalculaIdadeMaisPrecisa.UseVisualStyleBackColor = true;
            this.btnCalculaIdadeMaisPrecisa.Click += new System.EventHandler(this.btnCalculaIdadeMaisPrecisa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculaIdadeMaisPrecisa);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcularIdade);
            this.Controls.Add(this.dtpNascimento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Button btnCalcularIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button btnCalculaIdadeMaisPrecisa;
    }
}

