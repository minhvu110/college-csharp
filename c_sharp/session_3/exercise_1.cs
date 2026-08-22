using System;

namespace Workspace
{
    class Program
    {
        static void Main1(string[] args)
        {



            exercise1();
            exercise2();
            exercise3();

            Console.ReadKey();
        }
        static void exercise1()
        {
            int c = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine($"kelvin= {c + 237}");
            System.Console.WriteLine($"fahrenheit= {(int)(c * 1.8 + 32)}");
        }
        static void exercise2()
        {
            double r = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine($"Surface: {4 * Math.PI * Math.Pow(r, 2)}");
            System.Console.WriteLine($"Volume: {(4 / 3) * Math.PI * Math.Pow(r, 3)}");
        }
        static void exercise3()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine($"{a} + {b} = {a+b}");
            System.Console.WriteLine($"{a} - {b} = {a-b}");
            System.Console.WriteLine($"{a} * {b} = {a*b}");
            System.Console.WriteLine($"{a} / {b} = {1.0*a/b}");
            System.Console.WriteLine($"{a} mod {b} = {a%b}");
        }
    }
}
