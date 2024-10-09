using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;
namespace WindowsFormsApplication1
{
    public partial class CalculadoraConClase : Form
    {
        private WebServiceSoapClient cliente; // Instancia del cliente del servicio web
        private string Notacion;  // Variable para manejar la notación (infija o prefija)

        public CalculadoraConClase()
        {
            InitializeComponent();
            cliente = new WebServiceSoapClient();  // Crear la instancia del cliente del servicio web
            Notacion = "infija";  // Inicializamos con la notación infija por defecto
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

                // Llama al servicio web dependiendo de la notación
                if (Notacion == "infija")
                {
                    result = cliente.EvaluarOpeInfija(expression);  // Llama al método del servicio web para infija
                }
                else
                {
                    result = cliente.EvaluarOpePrefija(expression);  // Llama al método del servicio web para prefija
                }

                // Muestra el resultado en el TextBox
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

        // Método para cambiar la notación y llamarlo en el servicio web
        private void ChangeNotation(string newNotation)
        {
            Notacion = newNotation;  // Cambiar la notación localmente
            cliente.CambiarNotacion(newNotation);  // También cambiamos la notación en el servicio web
            EntradaC.Clear();  // Limpiar el campo de entrada
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ChangeNotation("infija");  // Cambiar a notación infija
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ChangeNotation("prefija");  // Cambiar a notación prefija
        }

        private void button20_Click(object sender, EventArgs e)
        {
            EntradaC.Text += " ";
        }
    }
}
