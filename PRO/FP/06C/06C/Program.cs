using System;

namespace _06C
{
    class Program
    {
        static void Main(string[] args)
        {

            double k, l, m; //input

            Console.WriteLine("vzorec je K = 2L + M");

            Console.WriteLine("zadejte číslo L"); //number l
            l = double.Parse(Console.ReadLine());

            Console.WriteLine("zadejte číslo M"); //number m
            m = double.Parse(Console.ReadLine());

            k = 2 * l + m; //calculation

            Console.WriteLine("K = " + k); //output

            Console.ReadLine();
        }
    }
}
