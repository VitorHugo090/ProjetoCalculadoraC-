namespace Calculadora1
{
    partial class teladacalculadora
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
            this.teladeresultado = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num10 = new System.Windows.Forms.Button();
            this.butsoma = new System.Windows.Forms.Button();
            this.butsub = new System.Windows.Forms.Button();
            this.butdiv = new System.Windows.Forms.Button();
            this.butmult = new System.Windows.Forms.Button();
            this.butreset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.lbloperacao = new System.Windows.Forms.Label();
            this.lblopera = new System.Windows.Forms.Label();
            this.botresult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teladeresultado
            // 
            this.teladeresultado.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.teladeresultado.Location = new System.Drawing.Point(12, 46);
            this.teladeresultado.Multiline = true;
            this.teladeresultado.Name = "teladeresultado";
            this.teladeresultado.Size = new System.Drawing.Size(292, 36);
            this.teladeresultado.TabIndex = 0;
            this.teladeresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.teladeresultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(26, 139);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(47, 70);
            this.num1.TabIndex = 1;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(79, 139);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(51, 70);
            this.num2.TabIndex = 2;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(136, 139);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(60, 70);
            this.num3.TabIndex = 3;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(26, 227);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(47, 47);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(79, 228);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(51, 46);
            this.num5.TabIndex = 5;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.button5_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(136, 228);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(60, 47);
            this.num6.TabIndex = 6;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.button6_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(26, 298);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(47, 41);
            this.num7.TabIndex = 7;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(79, 298);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(51, 41);
            this.num8.TabIndex = 8;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(137, 298);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(60, 41);
            this.num9.TabIndex = 9;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num10
            // 
            this.num10.Location = new System.Drawing.Point(79, 363);
            this.num10.Name = "num10";
            this.num10.Size = new System.Drawing.Size(51, 51);
            this.num10.TabIndex = 10;
            this.num10.Text = "0";
            this.num10.UseVisualStyleBackColor = true;
            this.num10.Click += new System.EventHandler(this.num10_Click);
            // 
            // butsoma
            // 
            this.butsoma.Location = new System.Drawing.Point(264, 105);
            this.butsoma.Name = "butsoma";
            this.butsoma.Size = new System.Drawing.Size(101, 85);
            this.butsoma.TabIndex = 11;
            this.butsoma.Text = "+";
            this.butsoma.UseVisualStyleBackColor = true;
            this.butsoma.Click += new System.EventHandler(this.butsoma_Click);
            // 
            // butsub
            // 
            this.butsub.Location = new System.Drawing.Point(397, 105);
            this.butsub.Name = "butsub";
            this.butsub.Size = new System.Drawing.Size(107, 85);
            this.butsub.TabIndex = 12;
            this.butsub.Text = "-";
            this.butsub.UseVisualStyleBackColor = true;
            this.butsub.Click += new System.EventHandler(this.butsub_Click);
            // 
            // butdiv
            // 
            this.butdiv.Location = new System.Drawing.Point(264, 196);
            this.butdiv.Name = "butdiv";
            this.butdiv.Size = new System.Drawing.Size(97, 79);
            this.butdiv.TabIndex = 13;
            this.butdiv.Text = "/";
            this.butdiv.UseVisualStyleBackColor = true;
            this.butdiv.Click += new System.EventHandler(this.butdiv_Click);
            // 
            // butmult
            // 
            this.butmult.Location = new System.Drawing.Point(397, 196);
            this.butmult.Name = "butmult";
            this.butmult.Size = new System.Drawing.Size(98, 77);
            this.butmult.TabIndex = 14;
            this.butmult.Text = "*";
            this.butmult.UseVisualStyleBackColor = true;
            this.butmult.Click += new System.EventHandler(this.butmult_Click);
            // 
            // butreset
            // 
            this.butreset.Location = new System.Drawing.Point(268, 298);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(93, 76);
            this.butreset.TabIndex = 15;
            this.butreset.Text = "RESET";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(90, 49);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 18;
            // 
            // lbloperacao
            // 
            this.lbloperacao.AutoSize = true;
            this.lbloperacao.Location = new System.Drawing.Point(27, 63);
            this.lbloperacao.Name = "lbloperacao";
            this.lbloperacao.Size = new System.Drawing.Size(0, 13);
            this.lbloperacao.TabIndex = 19;
            this.lbloperacao.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblopera
            // 
            this.lblopera.AutoSize = true;
            this.lblopera.Location = new System.Drawing.Point(13, 51);
            this.lblopera.Name = "lblopera";
            this.lblopera.Size = new System.Drawing.Size(0, 13);
            this.lblopera.TabIndex = 20;
            this.lblopera.Click += new System.EventHandler(this.lblopera_Click);
            // 
            // botresult
            // 
            this.botresult.Location = new System.Drawing.Point(397, 308);
            this.botresult.Name = "botresult";
            this.botresult.Size = new System.Drawing.Size(75, 83);
            this.botresult.TabIndex = 21;
            this.botresult.Text = "=";
            this.botresult.UseVisualStyleBackColor = true;
            this.botresult.Click += new System.EventHandler(this.botresult_Click);
            // 
            // teladacalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.botresult);
            this.Controls.Add(this.lblopera);
            this.Controls.Add(this.lbloperacao);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.butmult);
            this.Controls.Add(this.butdiv);
            this.Controls.Add(this.butsub);
            this.Controls.Add(this.butsoma);
            this.Controls.Add(this.num10);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.teladeresultado);
            this.Name = "teladacalculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.teladacalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teladeresultado;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num10;
        private System.Windows.Forms.Button butsoma;
        private System.Windows.Forms.Button butsub;
        private System.Windows.Forms.Button butdiv;
        private System.Windows.Forms.Button butmult;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label operacao;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lbloperacao;
        private System.Windows.Forms.Label lblopera;
        private System.Windows.Forms.Button botresult;
    }
}

