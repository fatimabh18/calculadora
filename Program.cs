using System;
class program
{
    static void Main(string[] args)
    {
        string opcion = "";
        int numero1 = 0;
        int numero2 = 0;
        var calculadora = new Calculadora();

        while (opcion != "5")
        {
            Console.WriteLine("******MENU******");
            Console.WriteLine("\n¿Que operacion desea realizar?");
            Console.WriteLine("Opcion 1:Sumar");
            Console.WriteLine("Opcion2:Restar");
            Console.WriteLine("Opcion3:Multiplicar");
            Console.WriteLine("Opcion4:Dividir");
            Console.WriteLine("Opcion5:Salir");
            Console.WriteLine("\nElija una opcion");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("Introduce un numero");
                    numero1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Introduce un segundo número");
                    numero2 = Int32.Parse(Console.ReadLine());
                    break;
            }
            switch (opcion)
            {
                case "1":
                    Calculadora.Suma(numero1 , numero2);
                    break;
                case "2":
                    Calculadora.Resta(numero1, numero2);
                    break;
                case "3":
                    Calculadora.Multiplicación(numero1, numero2);
                    break;
                case "4":
                    Calculadora.División(numero1, numero2);
                    break;
            }
        }   
    }
}

       

   