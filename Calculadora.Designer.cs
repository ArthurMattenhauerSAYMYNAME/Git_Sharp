namespace Git_Sharp
{
    partial class Calculadora
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.lbl_sinal = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btn_som = new System.Windows.Forms.Button();
            this.btn_limpa = new System.Windows.Forms.Button();
            this.btn_esc = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_Mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_comp = new System.Windows.Forms.Button();
            this.btn_pi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(107, 59);
            this.txt_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(148, 26);
            this.txt_1.TabIndex = 0;
            this.txt_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_sinal
            // 
            this.lbl_sinal.AutoSize = true;
            this.lbl_sinal.Location = new System.Drawing.Point(64, 112);
            this.lbl_sinal.Name = "lbl_sinal";
            this.lbl_sinal.Size = new System.Drawing.Size(18, 20);
            this.lbl_sinal.TabIndex = 1;
            this.lbl_sinal.Text = "?";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Location = new System.Drawing.Point(107, 171);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(148, 20);
            this.lbl_resultado.TabIndex = 2;
            this.lbl_resultado.Text = "?";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(107, 106);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(148, 26);
            this.txt_2.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(103, 135);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(162, 20);
            this.label.TabIndex = 4;
            this.label.Text = "_________________";
            this.label.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_som
            // 
            this.btn_som.Location = new System.Drawing.Point(387, 59);
            this.btn_som.Name = "btn_som";
            this.btn_som.Size = new System.Drawing.Size(123, 41);
            this.btn_som.TabIndex = 5;
            this.btn_som.Text = "Somar";
            this.btn_som.UseVisualStyleBackColor = true;
            this.btn_som.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // btn_limpa
            // 
            this.btn_limpa.Location = new System.Drawing.Point(68, 292);
            this.btn_limpa.Name = "btn_limpa";
            this.btn_limpa.Size = new System.Drawing.Size(228, 41);
            this.btn_limpa.TabIndex = 6;
            this.btn_limpa.Text = "Limpar";
            this.btn_limpa.UseVisualStyleBackColor = true;
            this.btn_limpa.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_esc
            // 
            this.btn_esc.Location = new System.Drawing.Point(387, 292);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(123, 41);
            this.btn_esc.TabIndex = 7;
            this.btn_esc.Text = "Sair";
            this.btn_esc.UseVisualStyleBackColor = true;
            this.btn_esc.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(387, 106);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(123, 41);
            this.btn_sub.TabIndex = 8;
            this.btn_sub.Text = "Subtrair";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_Mult
            // 
            this.btn_Mult.Location = new System.Drawing.Point(387, 153);
            this.btn_Mult.Name = "btn_Mult";
            this.btn_Mult.Size = new System.Drawing.Size(123, 41);
            this.btn_Mult.TabIndex = 9;
            this.btn_Mult.Text = "Multiplicação";
            this.btn_Mult.UseVisualStyleBackColor = true;
            this.btn_Mult.Click += new System.EventHandler(this.btn_Mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(387, 200);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(123, 41);
            this.btn_div.TabIndex = 10;
            this.btn_div.Text = "Divisão";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_comp
            // 
            this.btn_comp.Location = new System.Drawing.Point(68, 245);
            this.btn_comp.Name = "btn_comp";
            this.btn_comp.Size = new System.Drawing.Size(100, 41);
            this.btn_comp.TabIndex = 11;
            this.btn_comp.Text = "Comparar";
            this.btn_comp.UseVisualStyleBackColor = true;
            this.btn_comp.Click += new System.EventHandler(this.btn_comp_Click);
            // 
            // btn_pi
            // 
            this.btn_pi.Location = new System.Drawing.Point(196, 245);
            this.btn_pi.Name = "btn_pi";
            this.btn_pi.Size = new System.Drawing.Size(100, 41);
            this.btn_pi.TabIndex = 12;
            this.btn_pi.Text = "Par Ímpar";
            this.btn_pi.UseVisualStyleBackColor = true;
            this.btn_pi.Click += new System.EventHandler(this.btn_Par_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(580, 366);
            this.Controls.Add(this.btn_pi);
            this.Controls.Add(this.btn_comp);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_Mult);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_esc);
            this.Controls.Add(this.btn_limpa);
            this.Controls.Add(this.btn_som);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_sinal);
            this.Controls.Add(this.txt_1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.Label lbl_sinal;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_som;
        private System.Windows.Forms.Button btn_limpa;
        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_Mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_comp;
        private System.Windows.Forms.Button btn_pi;
    }
}

