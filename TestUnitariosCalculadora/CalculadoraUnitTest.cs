using Xunit;
using Clase.Calculadora;

namespace TestUnitariosCalculador
{
    public class CalculadoraUnitTest
    {
        [Fact]
        public void Test_Operacion_Suma()
        {
            // arrange
            int sumando1 = 2;
            int sumando2 = 2;
            // act
            Calculadora calculadora = new Calculadora();
            int resultado = calculadora.Suma(sumando1, sumando2);
            // asert
            Assert.Equal(4, resultado);
        }


        [Fact]
        public void Test_Operacion_Resta()
        {
            //arrange
            int minuendo = 2;
            int sustraendo = 2;
            //act
            Calculadora calculadora=new Calculadora();
            int resultado = calculadora.Resta(minuendo, sustraendo);
            //asert
            Assert.Equal(0,resultado);

        }
        

        [Fact]
        public void Test_Operacion_Multiplicacion()
        {
            // arrange
            int multiplicador1 = 2;
            int multiplicador2 = 5;
            // act
            Calculadora calculadora = new Calculadora();
            int resultado = calculadora.Multiplicacion(multiplicador1, multiplicador2);
            // asert
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void Test_Operacion_Division()
        {
            // arrange
            int dividendo = 4;
            int divisor = 2;
            // act
            Calculadora calculadora = new Calculadora();
            int resultado = calculadora.Division(dividendo, divisor);
            // asert
            Assert.Equal(2, resultado);
        }


    }
}