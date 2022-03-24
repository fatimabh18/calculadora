using Xunit;
using Clase.Calculadora;

namespace TestUnitariosCalculador
{
    public class UnitTest1
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
    }
}