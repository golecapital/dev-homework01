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

            char charcito='c';
            float flotante=3.1F/5.6F;
            double doubles=3.1D/5.7D;
            decimal decimals=3.1M/5.8M;

            Console.WriteLine($"{flotante}");            
            Console.WriteLine($"{doubles}");            
            Console.WriteLine($"{decimals}");            

            var resultado=sueldo*2 + 1 + edad;

            Console.WriteLine(resultado + "  " + edades);
        }
    }
}
