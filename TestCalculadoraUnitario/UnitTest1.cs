using System;
using Xunit;
using CalculadoraDesafioUnitarios;

namespace TesteNewTalents
{
    public class UnitTest1
    {

        public Calculadora construirClasse()
        {
            string data = "29/05/2024";
            Calculadora calculo = new Calculadora("29/05/2024");

            return calculo;
        }

        [Theory]
        [InlineData(1.5, 2, 3.5)]
        [InlineData(2.2, 5, 7.2)]
        public void TestSomar(double valor1, double valor2,double resultado)
        {
            Calculadora Calculo = construirClasse();

           double resultadoCalculadora = Calculo.somar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1.5, 3, 4.5)]
        [InlineData(3.2, 5.1, 16.32)]
        public void TestMultiplicar(double valor1, double valor2,double resultado)
        {
            Calculadora Calculo = construirClasse();

            double resultadoCalculadora = Calculo.multiplicar(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int valor1, int valor2, int resultado)
        {
            Calculadora Calculo = construirClasse();

            double resultadoCalculadora = Calculo.dividir(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6.2, 2, 4.2)]
        [InlineData(2.2, 5.7, -3.5)]
        public void TestSubtrair(double valor1, double valor2, double resultado)
        {
            Calculadora Calculo = construirClasse();

            double resultadoCalculadora = Calculo.subtrair(valor1, valor2);

            Assert.Equal(resultado, resultadoCalculadora);
        }



        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora Calculo = construirClasse();

            Assert.Throws<DivideByZeroException>(() => Calculo.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calculo = construirClasse();

            calculo.somar(1, 2);
            calculo.somar(2, 8);
            calculo.somar(1, 8);
            calculo.somar(2, 2);

            var lista = calculo.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

        /*[Fact]
        public void Test2()
        {
            Calculadora Calc = new Calculadora();

            int resultado = Calc.somar(4, 5);

            Assert.Equal(9, resultado);
        }
        */
    }
}