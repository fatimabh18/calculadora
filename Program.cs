//Opcion 1:Sumar
//Opcion2:Restar
//Opcion3:Multiplicar
//Opcion4:Dividir
//Opcion5:Salir
using System;
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
        Console.WriteLine("Opcion 1:Sumar");
        Console.WriteLine("Opcion2:Restar");
        Console.WriteLine("Opcion3:Multiplicar");
        Console.WriteLine("Opcion4:Dividir");
        Console.WriteLine("Opcion5:Salir");
        Console.WriteLine("\nElija una opcion");
         opcion = Console.ReadLine();
         
          
           if (opcion == "1")
            {
                Console.WriteLine("Introduce un numero");
                numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un segundo numero");
                numero2 = Int32.Parse(Console.ReadLine());
                calculadora.Suma(numero1, numero2);
                

            }
            if (opcion == "2")
            {
                Console.WriteLine("Introduce un numero");
                numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un segundo numero");
                numero2 = Int32.Parse(Console.ReadLine());
                calculadora.Resta(numero1, numero2);
            }
            if (opcion == "3")
            {
                Console.WriteLine("Introduce un numero");
                numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un segundo numero");
                numero2 = Int32.Parse(Console.ReadLine());
                calculadora.Multiplicación(numero1, numero2);
            }
            if (opcion == "4")
            {
                Console.WriteLine("Introduce un numero");
                numero1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce un segundo numero");
                numero2 = Int32.Parse(Console.ReadLine());
                calculadora.División(numero1, numero2);
               
            }   
            
            
        }  
        //while (opcion != "1" || opcion != "2" || opcion != "3" || opcion != "4" || opcion != "5")
        //{
        //    Console.WriteLine("Por favor introduzca una opción válida");
        //    Console.ReadLine();
        //}
    }
}

       

   