using System;

namespace _11C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("obvod obdelníka");
            
            Console.WriteLine("-------------------------");

            double a, b, o;
            
            Console.WriteLine("zadejte hodnoty v cm");

            Console.Write("hodnota a: ");
            a = Double.Parse(Console.ReadLine());

            Console.Write("hodnota b: ");
            b = Double.Parse(Console.ReadLine());

            o = 2 * (a + b);

            Console.WriteLine("-------------------------");
            
            Console.WriteLine("obvod je: " + o);

            Console.ReadLine();
        }
    }
}
