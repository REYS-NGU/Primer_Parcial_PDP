using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLib
{
    public class Calculadora
    {
        public string Notacion { get; private set; }

        // Constructor que inicializa el valor predeterminado de la propiedad
        public Calculadora()
        {
            Notacion = "infija";
        }

        // Cambiar la notación
        public void CambiarNotacion(string nuevaNotacion)
        {
            Notacion = nuevaNotacion;
        }

        // Evaluar una operación en notación infija
        public double EvaluarOperacion(string operation)
        {
            var tokens = ParseTokens(operation);  // Aquí se llama ParseTokens
            return EvaluarTokens(tokens);
        }

        // Evaluar una operación en notación prefija
        public double EvaluarPrefija(string expression)
        {
            Stack<double> stack = new Stack<double>();
            string[] tokens = expression.Split(' ');

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                string token = tokens[i];
                double num;

                if (double.TryParse(token, out num))
                {
                    stack.Push(num);
                }
                else
                {
                    if (stack.Count < 2)
                        throw new InvalidOperationException("Expresión prefija inválida.");

                    double left = stack.Pop();
                    double right = stack.Pop();
                    double result = 0;

                    switch (token)
                    {
                        case "+":
                            result = left + right;
                            break;
                        case "-":
                            result = left - right;
                            break;
                        case "*":
                            result = left * right;
                            break;
                        case "/":
                            if (right == 0)
                                throw new DivideByZeroException("División entre cero.");
                            result = left / right;
                            break;
                        default:
                            throw new InvalidOperationException("Operador prefijo inválido: " + token);
                    }

                    stack.Push(result);
                }
            }

            if (stack.Count != 1)
                throw new InvalidOperationException("Expresión prefija inválida.");

            return stack.Pop();
        }

        // Método para dividir la operación en tokens (números y operadores)
        private List<string> ParseTokens(string operation)
        {
            var tokens = new List<string>();
            string number = "";

            foreach (char c in operation)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    number += c;  // Si es un número o punto decimal, lo agregamos
                }
                else
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        tokens.Add(number);  // Añadir número a la lista
                        number = "";
                    }
                    tokens.Add(c.ToString());  // Añadir operador
                }
            }

            if (!string.IsNullOrEmpty(number))
                tokens.Add(number);  // Añadir el último número si existe

            return tokens;
        }

        // Evaluar los tokens de una expresión infija
        private double EvaluarTokens(List<string> tokens)
        {
            // Evaluar multiplicación y división primero
for (int i = 0; i < tokens.Count; i++)
{
    if (tokens[i] == "*" || tokens[i] == "/")
    {
        if (i > 0 && i < tokens.Count - 1)
        {
            double left = double.Parse(tokens[i - 1]);
            double right = double.Parse(tokens[i + 1]);
            double result = 0;

            if (tokens[i] == "*")
            {
                result = left * right;
            }
            else if (tokens[i] == "/")
            {
                if (right == 0)
                    throw new DivideByZeroException("División entre cero.");
                
                result = left / right;
            }

            tokens[i - 1] = result.ToString();
            tokens.RemoveAt(i + 1);
            tokens.RemoveAt(i);
            i--;
        }
    }
}


            // Evaluar suma y resta
            for (int i = 0; i < tokens.Count; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-")
                {
                    if (i > 0 && i < tokens.Count - 1)
                    {
                        double left = double.Parse(tokens[i - 1]);
                        double right = double.Parse(tokens[i + 1]);
                        double result = tokens[i] == "+" ? left + right : left - right;

                        tokens[i - 1] = result.ToString();
                        tokens.RemoveAt(i + 1);
                        tokens.RemoveAt(i);
                        i--;
                    }
                }
            }

            // El resultado final es el único valor que queda en los tokens
            return double.Parse(tokens[0]);
        }
    }
}

