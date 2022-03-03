using System;
using Clase.Calculadora;

enum opcionUsuario
{
   opcion = 1,
   opcion2 = 2,
   opcion3 = 3,
   opcion4 = 4,
}
class program
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();
        int numero1 = 0;
        int numero2 = 0;

        while ((int)opcionUsuario.opcion != 5)
        {
            Console.WriteLine("******MENU******");
            Console.WriteLine("\n¿Que operacion desea realizar?");
            Console.WriteLine("Opcion 1:Sumar");
            Console.WriteLine("Opcion2:Restar");
            Console.WriteLine("Opcion3:Multiplicar");
            Console.WriteLine("Opcion4:Dividir");
            Console.WriteLine("Opcion5:Salir");
            Console.WriteLine("\nElija una opcion");
            opcionUsuario opcion = (opcionUsuario) Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case opcionUsuario.opcion:
                case opcionUsuario.opcion2:
                case opcionUsuario.opcion3:
                case opcionUsuario.opcion4:
                    Console.WriteLine("Introduce un numero");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce un segundo número");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    return;
            }
            switch (opcion)
            {
                case opcionUsuario.opcion:
                    Calculadora.Suma(numero1 , numero2);
                    break;
                case opcionUsuario.opcion2:
                    Calculadora.Resta(numero1, numero2);
                    break;
                case opcionUsuario.opcion3:
                    Calculadora.Multiplicación(numero1, numero2);
                    break;
                case opcionUsuario.opcion4:
                    Calculadora.División(numero1, numero2);
                    break;
            }
        }   
    }
}

       

   