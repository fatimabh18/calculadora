using System;
using Clase.Calculadora;

enum opcionUsuario
{
   Suma = 1,
   Resta = 2,
   Multiplicacion = 3,
   Division = 4,
   Salir = 0
}
class program
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();
        int numero1 = 0;
        int numero2 = 0;

        while ((int)opcionUsuario.Salir != 5)
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
                case opcionUsuario.Suma:
                    Calculadora.Suma(numero1, numero2);
                    break;
                case opcionUsuario.Resta:
                    Calculadora.Resta(numero1, numero2);
                    break;
                case opcionUsuario.Multiplicacion:
                    Calculadora.Multiplicación(numero1, numero2);
                    break;
                case opcionUsuario.Division:
                    Calculadora.División(numero1, numero2);
                    break;
            }
        }   
    }
}

       

   