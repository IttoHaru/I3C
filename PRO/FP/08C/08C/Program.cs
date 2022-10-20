using System;

namespace _08C
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 2, c = 3;

            Console.WriteLine("hodnoty jsou");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.Write("hodnoty jsou: ");
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);

            Console.WriteLine();

            Console.WriteLine("hodnoty jsou: ");
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("A = 1"); //nezapisuje proměnou a

            Console.WriteLine("hodnoty všech proměnných: " + a + b + c); //špatně
            Console.WriteLine("hodnoty všech proměnných: " + a + ", " + b + ", " + c); //správně

            Console.WriteLine("hodnoty všech proměnných: 1, 2, 3"); //špatně
            Console.WriteLine("hodnoty všech proměnných: a, b, c"); //špatně

            Console.WriteLine("---------------------------------------------------");

            c = a + b;
            Console.WriteLine("součet čísel: " + a + " + " + b + " = " + c);
            c = a - b;
            Console.WriteLine("Rozdíl čísel: " + a + " - " + b + " = " + c);
            c = a * b;
            Console.WriteLine("Součin čísel: " + a + " * " + b + " = " + c);
            c = a / b;
            Console.WriteLine("Podíl  čísel: " + a + " / " + b + " = " + c);

            Console.WriteLine("---------------------------------------------------");

            c = a + b;
            Console.WriteLine("součet čísel: a + b = " + c);
            c = a - b;
            Console.WriteLine("Rozdíl čísel: a - b = " + c);
            c = a * b;
            Console.WriteLine("Součin čísel:  a * b = " + c);
            c = a / b;
            Console.WriteLine("Podíl  čísel:  a / b = "  + c);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("zadej hodnoty");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());

            c = a + b;
            Console.WriteLine("součet čísel: " + a + " + " + b + " = " + c);
            c = a - b;
            Console.WriteLine("Rozdíl čísel: " + a + " - " + b + " = " + c);
            c = a * b;
            Console.WriteLine("Součin čísel: " + a + " * " + b + " = " + c);
            c = a / b;
            Console.WriteLine("Podíl  čísel: " + a + " / " + b + " = " + c);

           
           Console.ReadLine();
        }
    }
}
