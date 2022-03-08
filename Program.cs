using System;
using Clase.Calculadora;

enum opcionUsuario
{
   Salir = 0,
   Suma = 1,
   Resta = 2,
   Multiplicacion = 3,
   Division = 4
}
class program
{
    static void Main(string[] args)
    {
        string opcion = "";
        int numero1;
        int numero2;
        var calculadora = new Calculadora();
        while (opcion != "5")
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
                Console.WriteLine("Introduce un numero");
                numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un segundo número");
                numero2 = Int32.Parse(Console.ReadLine());
                if (opcion == "1")
                {
                    Calculadora.Suma(numero1, numero2);
                }
                if (opcion == "2")
                {
                    Calculadora.Resta(numero1, numero2);
                }
                if (opcion == "3")
                {
                    Calculadora.Multiplicación(numero1, numero2);
                }
                if (opcion == "4")
                {
                    Calculadora.División(numero1, numero2);
                }
            } 
        }  
    }
}

       

   