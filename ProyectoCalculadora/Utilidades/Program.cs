using System;
using Clase.Calculadora;


class program
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();
        int numero1 = 0;
        int numero2 = 0;
        int exponente = 0;
        int basePotencia = 0;
        OpcionUsuario opcion = 0;
        while (opcion != OpcionUsuario.Salir)
        {
            CalculadoraServices Calcu = new CalculadoraServices();
            Calcu.Ejecutar();
            opcion = (OpcionUsuario) Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case OpcionUsuario.Suma:
                case OpcionUsuario.Resta:
                case OpcionUsuario.Multiplicacion:
                case OpcionUsuario.Division:
                    Console.WriteLine("Introduce un numero");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce un segundo número");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    break;
                case OpcionUsuario.Potencias:
                    Console.WriteLine("Introduzca el número");
                    basePotencia = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduzca el exponente");
                    exponente = Convert.ToInt32(Console.ReadLine());
                    break;

            }
            switch (opcion)
            {
                case (OpcionUsuario.Suma):
                {
                    calculadora.Suma(numero1, numero2);
                    break;
                }
                case (OpcionUsuario.Resta):
                {
                    calculadora.Resta(numero1, numero2);
                    break;
                }
                case (OpcionUsuario.Multiplicacion):
                {
                    calculadora.Multiplicacion(numero1, numero2);
                    break;
                }
                case (OpcionUsuario.Division):
                {
                    calculadora.Division(numero1, numero2);
                    break;
                }
                case (OpcionUsuario.Potencias):
                {
                    calculadora.Potencias(basePotencia, exponente);
                    break;
                }
                case (OpcionUsuario.ListadoOperaciones):
                {
                        calculadora.ListadoOperaciones();
                    break;
                }
            } 
        }  
    }
}

       

   