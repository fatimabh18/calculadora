using System;
using Clase.Calculadora;

enum opcionUsuario
{

   Salir = 0,
   Suma = 1,
   Resta = 2,
   Multiplicacion = 3,
   Division = 4
=======
    Suma = 1,
    Resta = 2,
    Multiplicacion = 3,
    Division = 4,
    Salir = 0,
>>>>>>> Stashed changes
}
class program
{
    static void Main(string[] args)
    {
        string opcion = "";
        int numero1;
        int numero2;
        var calculadora = new Calculadora();
<<<<<<< Updated upstream
        while (opcion != "5")
=======
        int numero1 = 0;
        int numero2 = 0;

        while ((int)opcionUsuario.Salir!=5)
>>>>>>> Stashed changes
        {
            Console.WriteLine("******MENU******");
            Console.WriteLine("\n¿Que operacion desea realizar?");
            Console.WriteLine("Opcion 1: Sumar");
            Console.WriteLine("Opcion 2: Restar");
            Console.WriteLine("Opcion 3: Multiplicar");
            Console.WriteLine("Opcion 4: Dividir");
            Console.WriteLine("Opcion 5: Salir");
            Console.WriteLine("\nElija una opcion");
            opcionUsuario opcion = (opcionUsuario) Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case opcionUsuario.Suma:
                case opcionUsuario.Resta:
                case opcionUsuario.Multiplicacion:
                case opcionUsuario.Division:
                    Console.WriteLine("Introduce un numero");
                    numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce un segundo número");
                    numero2 = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            switch (opcion)
            {
                case (opcionUsuario.Suma):
                {
                    calculadora.Suma(numero1, numero2);
                    break;
                }
                case (opcionUsuario.Resta):
                {
                    calculadora.Resta(numero1, numero2);
                    break;
                }
                case (opcionUsuario.Multiplicacion):
                {
                    calculadora.Multiplicación(numero1, numero2);
                    break;
                }
                case (opcionUsuario.Division):
                {
                    calculadora.División(numero1, numero2);
                    break;
                }
            } 
        }  
    }
}

       

   