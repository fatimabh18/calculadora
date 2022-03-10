using System;
using Clase.Calculadora;


class program
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();
        int numero1 = 0;
        int numero2 = 0;
        OpcionUsuario opcion = 0;
        while (opcion != OpcionUsuario.Salir)
        {
            Console.WriteLine("******MENU******");
            Console.WriteLine("\n¿Que operacion desea realizar?");
            Console.WriteLine("Opcion 1: Sumar");
            Console.WriteLine("Opcion 2: Restar");
            Console.WriteLine("Opcion 3: Multiplicar");
            Console.WriteLine("Opcion 4: Dividir");
            Console.WriteLine("Opcion 5: Salir");
            Console.WriteLine("\nElija una opcion");
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
                    calculadora.Multiplicación(numero1, numero2);
                    break;
                }
                case (OpcionUsuario.Division):
                {
                    calculadora.División(numero1, numero2);
                    break;
                }
            } 
        }  
    }
}

       

   