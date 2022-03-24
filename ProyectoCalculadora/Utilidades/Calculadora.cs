using System;

namespace Clase.Calculadora
{
    public class Calculadora
    {
        public int Suma(int sumando1, int sumando2)
        {
            int resultado;
            resultado = sumando1 + sumando2;
            Console.WriteLine("El resultado de la suma es " + resultado);
            return resultado;
        }
        public int Resta(int minuendo, int sustraendo)
        {
            int resultado;
            resultado = minuendo - sustraendo;
            Console.WriteLine("El resultado de la resta es: " + resultado);
            return (resultado);
        }
        public int Multiplicacion(int multiplicador1, int multiplicado2)
        {
            int resultado;
            resultado = multiplicador1 * multiplicado2;
            Console.WriteLine("El resultado de la multiplicación es: " + resultado);
            return (resultado);
        }
        public int Division(int dividendo, int divisor)
        {
            int resultado;
            resultado = dividendo / divisor;
            Console.WriteLine("El resultado de la división es: " + resultado);
            return (resultado);
        }
        public int Potencias(int basePotencia, int exponente)
        {
            
            int resultado = basePotencia;
            for (int i = 0; i < exponente - 1; i++)
            {
                resultado = resultado * basePotencia;
            }
            System.Console.WriteLine("El resultado de la potencia es: " + resultado);

            return resultado;

            /*int resultado = 0;
            double elevarNumero = Math.Pow(basePotencia, exponente);
            Console.WriteLine(String.Format("El resultado es {1}", resultado, elevarNumero));
            return resultado;
            //for (int i = 0; i < exponente; i++)
            //{
            //    resultado = basePotencia ^ exponente;
            //    Console.WriteLine("El resultado de la potencia es: " + resultado);
            //}
            //return resultado;*/
        }
    }
}
