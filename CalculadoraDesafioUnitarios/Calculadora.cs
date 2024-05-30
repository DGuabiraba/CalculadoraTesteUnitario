using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDesafioUnitarios
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string data;

        public Calculadora(string data)
        {
            ListaHistorico = new List<string>();
            this.data = data;
        }
        public double somar( double  valor1, double valor2)
        {
            double resultado = valor1 + valor2;
            ListaHistorico.Insert(0, "Resultado:" + resultado + " - data:" + data);
            return resultado;
        }

        public double multiplicar(double valor1, double valor2)
        {
            double res = valor1 * valor2;
            ListaHistorico.Insert(0, "Resultado:" + res + " - data:" + data);
            return res;
        }

        public double subtrair(double valor1, double valor2)
        {
            double resultado = valor1 - valor2;
            ListaHistorico.Insert(0, "Resultado:" + resultado + " - data:" + data);
            return resultado;
        }

        public int dividir(int valor1, int valor2)
        {
            int resultado = valor1 / valor2;
            ListaHistorico.Insert(0, "Resultado:" + resultado + " - data:" + data);
            return resultado;
        }

        public List<string> historico()
        {

            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}
