using System;

namespace Clase.Calculadora
{
    public class Calculadora
    {
        public static int Suma(int sumando1, int sumando2)
        {
            int resultado;
            resultado = sumando1 + sumando2;
            Console.WriteLine("El resultado de la suma es " + resultado);
            return resultado;
        }
        public static int Resta(int minuendo, int sustraendo)
        {
            int resultado;
            resultado = minuendo - sustraendo;
            Console.WriteLine("El resultado de la resta es: " + resultado);
            return (resultado);
        }
        public static int Multiplicación(int multiplicador1, int multiplicado2)
        {
            int resultado;
            resultado = multiplicador1 * multiplicado2;
            Console.WriteLine("El resultado de la multiplicación es: " + resultado);
            return (resultado);
        }
        public static int División(int dividendo, int divisor)
        {
            int resultado;
            resultado = dividendo / divisor;
            Console.WriteLine("El resultado de la división es: " + resultado);
            return (resultado);
        }
    }
}
