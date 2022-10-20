using System;

namespace _10C
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, o;                                            //deklarace proměnných
            
            Console.WriteLine("--------------------------------");
            Console.WriteLine("PROGRAM PRO V7POČET");
            Console.WriteLine("--------------------------------");

            Console.Write("zadej stranu čtverce a v cm: ");
            a = double.Parse(Console.ReadLine());                   //vztup

            o = 4 * a;                                              //zpracování

            Console.WriteLine("Obvod čtverce je " + o + " cm.");    //výstup

            Console.ReadLine();
        }
    }
}
