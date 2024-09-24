using System.Diagnostics.Metrics;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Show();
            this.Hide();

        }
    }
}
