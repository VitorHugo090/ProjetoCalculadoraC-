using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class teladacalculadora : Form
    {
        int valor1 = 0, valor2 = 0;
        string opera = "";

        public teladacalculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text + "6";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text + "1";
        }

        private void num10_Click(object sender, EventArgs e)
        {
           lblresult.Text = lblresult.Text + "0";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text + "4";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text + "9";
        }

        private void teladacalculadora_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butsoma_Click(object sender, EventArgs e)
        {
           
            valor1 = int.Parse(lblresult.Text, CultureInfo.InvariantCulture);
            lblresult.Text = "";
            opera = "SOMA";
            lblopera.Text = "+";


        }

        private void botresult_Click(object sender, EventArgs e)
        {
            valor2 = int.Parse(lblresult.Text, CultureInfo.InvariantCulture);

            if (opera == "SOMA")
            {
               lblresult.Text =  Convert.ToString (valor1 + valor2);
            }

            if (opera == "SUBTRACAO")
            {
                lblresult.Text = Convert.ToString(valor1 - valor2);
            }


            if (opera == "DIVICAO")
            {
                lblresult.Text = Convert.ToString(valor1 / valor2);
            }

            if (opera == "MULTIPLICACAO")
            {
                lblresult.Text = Convert.ToString(valor1 * valor2);
            }
        }

        private void butsub_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(lblresult.Text, CultureInfo.InvariantCulture);
            lblresult.Text = "";
            opera = "SUBTRACAO";
            lblopera.Text = "-";
        }

        private void butdiv_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(lblresult.Text, CultureInfo.InvariantCulture);
            lblresult.Text = "";
            opera = "DIVICAO";
            lblopera.Text = "/";
        }

        private void butmult_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(lblresult.Text, CultureInfo.InvariantCulture);
            lblresult.Text = "";
            opera = "MULTIPLICACAO";
            lblopera.Text = "*";
        }

        private void butreset_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            lblopera.Text = "";
        }

        private void lblopera_Click(object sender, EventArgs e)
        {

        }
    }
}
