using System;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new StreamReader("input.txt"));
            // 1. to Add / Sum Two Numbers.
            int a = 10;
            int b = 200;
            System.Console.WriteLine($"{a} + {b}={a + b}");
            // 2. to Swap Values of Two Variables.
            System.Console.WriteLine($"before swap {a} {b}");
            int temp = a;
            a = b;
            b = temp;
            System.Console.WriteLine($"after swap {a} {b}");
            // 3. to Multiply two Floating Point Numbers
            double num1 = 4.3;
            double num2 = 3.6;
            System.Console.WriteLine($"{num1}*{num2}={num1 * num2}");
            // 4. to convert feet to meter
            double h = 6.2;
            System.Console.WriteLine($"{h} feet is {h * 0.3048} meter");
            // 5. to convert Celsius to Fahrenheit and vice versa
            double tempC = 100.5;
            double tempF = 20;
            System.Console.WriteLine($"{tempC}C is {(tempC * 9 / 5) + 32}F");
            System.Console.WriteLine($"{tempF}F is {(tempF - 32) * 5 / 9}C");
            // 6. to find the Size of data types
            System.Console.WriteLine($"the size of double is {sizeof(double)}");
            System.Console.WriteLine($"the size of decimal is {sizeof(decimal)}");
            // 7. to Print ASCII Value (tip: read character, print number of this char)
            System.Console.Write("enter a character: ");
            int c = Console.Read();
            System.Console.WriteLine($"{(char)c} has the ascii of {c}");
            // 8. to Calculate Area of Circle
            double pi = 3.14;
            double r = 5;
            System.Console.WriteLine($"the area of the circle with r= {r} is {pi * pi * r}");
            // 9. to Calculate Area of Square
            int l = 4;
            System.Console.WriteLine($"the area of the square with l= {l} is {l * l}");
            // 10. to convert days to years, weeks and days
            int num3 = 1000;
            int year = num3 / 365;
            int week = (num3 % 365) / 7;
            int day = num3 - year * 365 - week * 7;
            System.Console.WriteLine($"{num3} days is equal to {year} years {week} weeks and {day} days");
            Console.ReadKey();
        }
    }
}
