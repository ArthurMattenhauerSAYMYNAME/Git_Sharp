namespace Git_Sharp
{
    partial class frmRadio
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
            this.gb_Ope = new System.Windows.Forms.GroupBox();
            this.rb_pot = new System.Windows.Forms.RadioButton();
            this.rb_mult = new System.Windows.Forms.RadioButton();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.rb_sub = new System.Windows.Forms.RadioButton();
            this.rb_som = new System.Windows.Forms.RadioButton();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_limp = new System.Windows.Forms.Button();
            this.btn_fec = new System.Windows.Forms.Button();
            this.lbl_sinal = new System.Windows.Forms.Label();
            this.txt_pri = new System.Windows.Forms.TextBox();
            this.txt_sec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_resp = new System.Windows.Forms.Label();
            this.gb_Ope.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Ope
            // 
            this.gb_Ope.Controls.Add(this.rb_pot);
            this.gb_Ope.Controls.Add(this.rb_mult);
            this.gb_Ope.Controls.Add(this.rb_div);
            this.gb_Ope.Controls.Add(this.rb_sub);
            this.gb_Ope.Controls.Add(this.rb_som);
            this.gb_Ope.Location = new System.Drawing.Point(30, 22);
            this.gb_Ope.Name = "gb_Ope";
            this.gb_Ope.Size = new System.Drawing.Size(204, 293);
            this.gb_Ope.TabIndex = 0;
            this.gb_Ope.TabStop = false;
            this.gb_Ope.Text = "Operações";
            // 
            // rb_pot
            // 
            this.rb_pot.AutoSize = true;
            this.rb_pot.Location = new System.Drawing.Point(6, 196);
            this.rb_pot.Name = "rb_pot";
            this.rb_pot.Size = new System.Drawing.Size(122, 24);
            this.rb_pot.TabIndex = 1;
            this.rb_pot.Text = "Potenciação";
            this.rb_pot.UseVisualStyleBackColor = true;
            this.rb_pot.CheckedChanged += new System.EventHandler(this.rb_pot_CheckedChanged);
            // 
            // rb_mult
            // 
            this.rb_mult.AutoSize = true;
            this.rb_mult.Location = new System.Drawing.Point(6, 152);
            this.rb_mult.Name = "rb_mult";
            this.rb_mult.Size = new System.Drawing.Size(125, 24);
            this.rb_mult.TabIndex = 4;
            this.rb_mult.Text = "Multiplicação";
            this.rb_mult.UseVisualStyleBackColor = true;
            this.rb_mult.CheckedChanged += new System.EventHandler(this.rb_mult_CheckedChanged);
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(6, 113);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(85, 24);
            this.rb_div.TabIndex = 3;
            this.rb_div.Text = "Divisão";
            this.rb_div.UseVisualStyleBackColor = true;
            this.rb_div.CheckedChanged += new System.EventHandler(this.rb_div_CheckedChanged);
            // 
            // rb_sub
            // 
            this.rb_sub.AutoSize = true;
            this.rb_sub.Location = new System.Drawing.Point(6, 74);
            this.rb_sub.Name = "rb_sub";
            this.rb_sub.Size = new System.Drawing.Size(90, 24);
            this.rb_sub.TabIndex = 2;
            this.rb_sub.Text = "Subtrair";
            this.rb_sub.UseVisualStyleBackColor = true;
            this.rb_sub.CheckedChanged += new System.EventHandler(this.rb_sub_CheckedChanged);
            // 
            // rb_som
            // 
            this.rb_som.AutoSize = true;
            this.rb_som.Checked = true;
            this.rb_som.Location = new System.Drawing.Point(6, 35);
            this.rb_som.Name = "rb_som";
            this.rb_som.Size = new System.Drawing.Size(81, 24);
            this.rb_som.TabIndex = 1;
            this.rb_som.TabStop = true;
            this.rb_som.Text = "Somar";
            this.rb_som.UseVisualStyleBackColor = true;
            this.rb_som.CheckedChanged += new System.EventHandler(this.rb_som_CheckedChanged);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(253, 218);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(138, 40);
            this.btn_cal.TabIndex = 1;
            this.btn_cal.Text = "Calcular";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_limp
            // 
            this.btn_limp.Location = new System.Drawing.Point(430, 218);
            this.btn_limp.Name = "btn_limp";
            this.btn_limp.Size = new System.Drawing.Size(138, 40);
            this.btn_limp.TabIndex = 2;
            this.btn_limp.Text = "Limpar";
            this.btn_limp.UseVisualStyleBackColor = true;
            this.btn_limp.Click += new System.EventHandler(this.btn_limp_Click);
            // 
            // btn_fec
            // 
            this.btn_fec.Location = new System.Drawing.Point(253, 275);
            this.btn_fec.Name = "btn_fec";
            this.btn_fec.Size = new System.Drawing.Size(315, 40);
            this.btn_fec.TabIndex = 3;
            this.btn_fec.Text = "Fechar";
            this.btn_fec.UseVisualStyleBackColor = true;
            this.btn_fec.Click += new System.EventHandler(this.btn_fec_Click);
            // 
            // lbl_sinal
            // 
            this.lbl_sinal.AutoSize = true;
            this.lbl_sinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_sinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sinal.Location = new System.Drawing.Point(285, 99);
            this.lbl_sinal.Name = "lbl_sinal";
            this.lbl_sinal.Size = new System.Drawing.Size(25, 27);
            this.lbl_sinal.TabIndex = 4;
            this.lbl_sinal.Text = "?";
            // 
            // txt_pri
            // 
            this.txt_pri.Location = new System.Drawing.Point(328, 45);
            this.txt_pri.Name = "txt_pri";
            this.txt_pri.Size = new System.Drawing.Size(154, 26);
            this.txt_pri.TabIndex = 5;
            // 
            // txt_sec
            // 
            this.txt_sec.Location = new System.Drawing.Point(328, 96);
            this.txt_sec.Name = "txt_sec";
            this.txt_sec.Size = new System.Drawing.Size(154, 26);
            this.txt_sec.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "__________________";
            // 
            // lbl_resp
            // 
            this.lbl_resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resp.Location = new System.Drawing.Point(323, 145);
            this.lbl_resp.Name = "lbl_resp";
            this.lbl_resp.Size = new System.Drawing.Size(167, 30);
            this.lbl_resp.TabIndex = 8;
            this.lbl_resp.Text = "?";
            this.lbl_resp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(612, 355);
            this.Controls.Add(this.lbl_resp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sec);
            this.Controls.Add(this.txt_pri);
            this.Controls.Add(this.lbl_sinal);
            this.Controls.Add(this.btn_fec);
            this.Controls.Add(this.btn_limp);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.gb_Ope);
            this.Name = "frmRadio";
            this.Text = "frmRadio";
            this.Load += new System.EventHandler(this.frmRadio_Load);
            this.gb_Ope.ResumeLayout(false);
            this.gb_Ope.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Ope;
        private System.Windows.Forms.RadioButton rb_mult;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.RadioButton rb_sub;
        private System.Windows.Forms.RadioButton rb_som;
        private System.Windows.Forms.RadioButton rb_pot;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_limp;
        private System.Windows.Forms.Button btn_fec;
        private System.Windows.Forms.Label lbl_sinal;
        private System.Windows.Forms.TextBox txt_pri;
        private System.Windows.Forms.TextBox txt_sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_resp;
    }
}