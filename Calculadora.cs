using System;

public class Calculadora
{
    public void Suma(int var1, int var2)
    {
        int resultado;
        resultado = var1 + var2;
        Console.WriteLine("El resultado es: " + resultado);
    }
    public void Resta(int var1, int var2)
    {
        int resultado;
        resultado = var1 - var2;
        Console.WriteLine("El resultado es: " + resultado);
    }
    public void Multiplicación(int var1, int var2)
    {
        int resultado;
        resultado = var1 * var2;
        Console.WriteLine("El resultado es: " + resultado);
    }
    public void División(int var1, int var2)
    {
        int resultado;
        resultado = var1 / var2;
        Console.WriteLine("El resultado es: " + resultado);
    }
}