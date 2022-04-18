using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mia_Calculadora
{
    public partial class Form1 : Form
    {
        double VEntrada1; double VEntrada2;
        string operacao;
       
        public Form1()
        { 
            InitializeComponent();
        }
        //Definição dos Botões Númericos!
        private void bot_Caract_Click(object sender, EventArgs e)
        {
            textresultado.Text += ",";
            textcalculo.Text += ",";
        }

        private void bot_9_Click(object sender, EventArgs e)
        {
            textresultado.Text += "9";
            textcalculo.Text += "9";
        }

        private void bot_8_Click(object sender, EventArgs e)
        {
            textresultado.Text += "8";
            textcalculo.Text += "8";
        }

        private void bot_7_Click(object sender, EventArgs e)
        {
            textresultado.Text += "7";
            textcalculo.Text += "7";
        }

        private void bot_6_Click(object sender, EventArgs e)
        {
            textresultado.Text += "6";
            textcalculo.Text += "6";
        }

        private void bot_5_Click(object sender, EventArgs e)
        {
            textresultado.Text += "5";
            textcalculo.Text += "5";
        }

        private void bot_4_Click(object sender, EventArgs e)
        {
            textresultado.Text += "4";
            textcalculo.Text += "4";
        }

        private void bot_3_Click(object sender, EventArgs e)
        {
            textresultado.Text += "3";
            textcalculo.Text += "3";
        }

        private void bot_2_Click(object sender, EventArgs e)
        {
            textresultado.Text += "2";
            textcalculo.Text += "2";
        }

        private void bot_1_Click(object sender, EventArgs e)
        {
            textresultado.Text += "1";
            textcalculo.Text += "1";
        }
        private void bot_0_Click(object sender, EventArgs e)
        {
            textresultado.Text += "0";
            textcalculo.Text += "0";
        }

        private void textresultado_TextChanged(object sender, EventArgs e)
        {
           
              
        }

        //Definição dos Botões Operacionais!
        private void bot_adi_Click(object sender, EventArgs e)
        {
            if (textcalculo.Text != "")
            {
                VEntrada1 = Convert.ToDouble(textresultado.Text);
                textcalculo.Text += "+";
                textresultado.Text = "";
                operacao = "Soma";
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }
        }

        private void bot_Sub_Click(object sender, EventArgs e)
        { if (textcalculo.Text != "")
            {
                VEntrada1 = Convert.ToDouble(textresultado.Text);
                textcalculo.Text += "-";
                textresultado.Text = "";
                operacao = "Subtracao";
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }
        }

        private void bot_Mult_Click(object sender, EventArgs e)
        {
            if (textcalculo.Text != "")
            {
                VEntrada1 = Convert.ToDouble(textresultado.Text);
                textcalculo.Text += "x";
                textresultado.Text = "";
                operacao = "Multiplicacao";
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }
        }

        private void bot_Div_Click(object sender, EventArgs e)
        {
            if (textcalculo.Text != "")
            {
                VEntrada1 = Convert.ToDouble(textresultado.Text);
                textcalculo.Text += "÷";
                textresultado.Text = "";
                operacao = "Divisao";
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }
        }

        private void bot_Porc_Click(object sender, EventArgs e)
        {
            if (textcalculo.Text != "")
            {
                VEntrada1 = Convert.ToDouble(textresultado.Text);
                textcalculo.Text += "%";
                textresultado.Text = "";
                operacao = "Porcentagem";
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }
        }

        private void bot_Pot_Click(object sender, EventArgs e)
        {
            if (textcalculo.Text != "")
            {
                VEntrada1 = Convert.ToDouble(textresultado.Text);
                textcalculo.Text += "^";
                textresultado.Text = "";
                operacao = "Potencia";
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }
        }

        private void bot_Raiz_Click(object sender, EventArgs e)
        {
            if (textcalculo.Text != "")
            {
                VEntrada1 = Convert.ToDouble(textcalculo.Text);
                textresultado.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(VEntrada1)));
                textcalculo.Text = VEntrada1.ToString() + "=";
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }

        }

        private void bot_Arredondar_Click(object sender, EventArgs e)
        {
            if (textcalculo.Text != "")
            {
                VEntrada1 = Convert.ToDouble(textresultado.Text);
            textcalculo.Text += Convert.ToString(VEntrada1);
            textresultado.Text= Math.Round(VEntrada1).ToString();
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }
        }

        private void bot_ArreCima_Click(object sender, EventArgs e)
        {
            if (textcalculo.Text != "")
            {
                VEntrada1 = Convert.ToDouble(textresultado.Text);
            textcalculo.Text += Convert.ToString(VEntrada1);
            textresultado.Text = Math.Ceiling(VEntrada1).ToString();
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }
        }

        private void bot_Result_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != ""){
                VEntrada2 = Convert.ToDouble(textresultado.Text);
                textcalculo.Text += "=";
            
                switch (operacao)
                {
                    case "Soma": textresultado.Text = Convert.ToString(VEntrada1 + VEntrada2); break;
                    case "Subtracao": textresultado.Text = Convert.ToString(VEntrada1 - VEntrada2); break;
                    case "Multiplicacao": textresultado.Text = Convert.ToString(VEntrada1 * VEntrada2); break;
                    case "Divisao": textresultado.Text = Convert.ToString(VEntrada1 / VEntrada2); break;
                    case "Porcentagem": textresultado.Text = Convert.ToString(VEntrada1 * VEntrada2 / 100); break;
                    case "Potencia": textresultado.Text = Math.Pow(Convert.ToDouble(VEntrada1), Convert.ToDouble(VEntrada2)).ToString(); break;
                    default: textresultado.Text = Convert.ToString(0); break;
                }
            } else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação.");}
            
        }

        //Apagar as operações!
        private void bot_Apagar_Click(object sender, EventArgs e)
        {
            textresultado.Text = "";
            textcalculo.Text = "";
        }
        private void bot_Del_Click(object sender, EventArgs e)
        {
            if (textresultado.Text != "")
            {
                string resultado = textresultado.Text;
                string calculo = textcalculo.Text;
                textresultado.Text = resultado.Substring(0, resultado.Length - 1);
                textcalculo.Text = calculo.Substring(0, calculo.Length - 1);
            }
            else { MessageBox.Show("Erro! Por Favor Digíte um Valor Válido para Realizar a Operação."); }
        }
    }
}
