using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        float valor1 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Num1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "5";

        }

        private void Num6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "0";
        }
        private void BtnMais_click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(TxtResultado.Text);
            operacao = "Mais";
            TxtResultado.Clear();
        }
        private void BtnMenos_click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(TxtResultado.Text);
            operacao = "Menos";
            TxtResultado.Clear();
        }
        private void BtnVezes_click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(TxtResultado.Text);
            operacao = "Vezes";
            TxtResultado.Clear();
        }
        private void BtnDividido_click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(TxtResultado.Text);
            operacao = "Dividir";
            TxtResultado.Clear();

        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
          if (this.operacao == "soma")
            {
                float resultado = valor1 + Convert.ToSingle(TxtResultado.Text);
                TxtResultado.Text = Convert.ToString(resultado);
                TxtResultado.Text = resultado.ToString();


            }
        }
    }
}
