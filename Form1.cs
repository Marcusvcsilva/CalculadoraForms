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

namespace Calculadora
{
    public partial class Form_Calculadora : Form
    {
        int valor1 =0, valor2 =0;
        string operacao = ""; 
        public Form_Calculadora()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(tbresultado.Text, CultureInfo.InvariantCulture);

            tbresultado.Text = "";
            operacao = "MULTIPLICACAO";
            lboperacao.Text = "x";
        }

        private void btresultado_Click(object sender, EventArgs e)
        {
            valor2 = int.Parse(tbresultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                tbresultado.Text = Convert.ToString(valor1 + valor2); 
            }

            else if(operacao == "SUBTRACAO")
            {
                tbresultado.Text = Convert.ToString(valor1 - valor2);
            }

            else if(operacao == "MULTIPLICACAO")
            {
                tbresultado.Text = Convert.ToString(valor1 * valor2);
            }

            else if(operacao == "DIVISAO")
            {
                tbresultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "0"; 
        }

        private void btporcentagem_Click(object sender, EventArgs e)
        {

        }

        private void Form_Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tbresultado.Text += "9";
        }

        private void btvirgula_Click(object sender, EventArgs e)
        {
            tbresultado.Text += ",";
        }

        private void btapagar_Click(object sender, EventArgs e)
        {
            
        }

        private void btsubtracao_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(tbresultado.Text, CultureInfo.InvariantCulture);

            tbresultado.Text = "";
            operacao = "SUBTRACAO";
            lboperacao.Text = "-";
        }

        private void btdivisao_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(tbresultado.Text, CultureInfo.InvariantCulture);

            tbresultado.Text = "";
            operacao = "DIVISAO";
            lboperacao.Text = "÷";
        }

        private void btraiz_Click(object sender, EventArgs e)
        {
            double primeiro = 2;

            double resutado = Convert.ToSingle(Math.Sqrt(primeiro));

            tbresultado.Text = resutado.ToString();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            tbresultado.Text = " ";
            valor1 = 0;
            valor2 = 0; 
            lboperacao.Text =" ";
        }

        private void btcancelarregistro_Click(object sender, EventArgs e)
        {
            tbresultado.Text = " ";
        }

        private void btadicao_Click(object sender, EventArgs e)
        {
            valor1 = int.Parse(tbresultado.Text, CultureInfo.InvariantCulture);

            tbresultado.Text = "";
            operacao = "SOMA";
            lboperacao.Text = "+";
            
        }





    }




}
