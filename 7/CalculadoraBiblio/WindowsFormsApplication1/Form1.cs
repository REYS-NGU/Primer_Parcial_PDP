using CalculadoraLib;  // Usar la biblioteca de clases
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CalculadoraConClase : Form
    {
        private Calculadora calculadora;

        // Constructor correcto
        public CalculadoraConClase()
        {
            InitializeComponent();
            calculadora = new Calculadora();  // Crear una instancia de la calculadora
        }

        private void composicion_click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Text;
            EntradaC.Text += buttonText;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = EntradaC.Text;
                double result;

                if (calculadora.Notacion == "infija")
                {
                    result = calculadora.EvaluarOperacion(expression);
                }
                else
                {
                    result = calculadora.EvaluarPrefija(expression);
                }

                EntradaC.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la operación: " + ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            EntradaC.Clear();
        }

        private void ChangeNotation(string newNotation)
        {
            calculadora.CambiarNotacion(newNotation);
            EntradaC.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ChangeNotation("infija");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ChangeNotation("prefija");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            EntradaC.Text += " ";
        }
    }
}
