using System;

namespace _09C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej celé číslo: ");
            int a = int.Parse(Console.ReadLine());

            //lze také:
            //int a;                                        //deklarace proměnné
            //a = Convert.ToInt32(Console.ReadLine());      //příkaz pro vstup

            Console.Write("Zadej desetinné číslo: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("Zadej desetinné číslo: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Zadej logickou hodnotu: ");     //true nebo false
            bool d = bool.Parse(Console.ReadLine());

            Console.Write("Zadej znak: ");
            char e = char.Parse(Console.ReadLine());

            Console.Write("Zadej řetězec znaků: ");
            string f = Console.ReadLine();                  //neprovádí se konverze hodnoty

            Console.WriteLine();

            Console.WriteLine("Byly zadány tyto hodnoty:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);

            Console.ReadLine();

        }
    }
}
