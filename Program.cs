using System;

namespace dev_homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            const string nombre = "Gabo";

            int edad=19;

            Console.WriteLine("Mis datos son ") ; 
            Console.WriteLine($"{nombre} y {edad}");

            int edades=23;

            double sueldo=14.3;

            var resultado=sueldo*2 + 1 + edad;

            Console.WriteLine(resultado + "  " + edades);
        }
    }
}
