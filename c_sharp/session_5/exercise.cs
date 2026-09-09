using System;
using System.Text;

namespace Workspace
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // 1. Check whether a triangle is Equilateral, Isosceles or Scalene
            tamgiac2();
            System.Console.WriteLine("next");

            // 2. Read 10 numbers and find average and sum
            numb();
            System.Console.WriteLine("next");

            // 3. Multiplication table of a given integer
            bangcuuchuong();
            System.Console.WriteLine("next");

            // 4 & 5. Triangle number patterns
            tamgiac();
            System.Console.WriteLine("next");

            // 6. n terms of harmonic series and their sum
            hamornic();
            System.Console.WriteLine("next");

            // 7. 'perfect' numbers within a given range
            perfect();
            System.Console.WriteLine("next");

            // 8. Determine whether a given number is prime or not
            prime();
            System.Console.WriteLine("next");

            Console.ReadKey();
        }

        // Exercise 1
        static void tamgiac2()
        {
            System.Console.Write("enter canh 1= ");
            decimal canh1 = Convert.ToDecimal(Console.ReadLine());
            System.Console.Write("enter canh 2= ");
            decimal canh2 = Convert.ToDecimal(Console.ReadLine());
            System.Console.Write("enter canh 3= ");
            decimal canh3 = Convert.ToDecimal(Console.ReadLine());

            if (canh1 + canh2 <= canh3 || canh1 + canh3 <= canh2 || canh2 + canh3 <= canh1 || canh1 <= 0 || canh2 <= 0 || canh3 <= 0)
            {
                System.Console.WriteLine("not even a triangle, try again");
                return;
            }
            if (canh1 == canh2 && canh2 == canh3)
            {
                System.Console.WriteLine("Equilateral, Tam giác đều");
            }
            else if (canh1 == canh2 || canh2 == canh3 || canh1 == canh3)
            {
                System.Console.WriteLine("Isosceles, Tam giác cân");
            }
            else
            {
                System.Console.WriteLine("Scalene, Tam giác thường");
            }
        }

        // Exercise 2
        static void numb()
        {
            long total = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"number {i}= ");
                long temp = long.Parse(Console.ReadLine());
                total += temp;
            }
            Console.WriteLine($"total={total}");
            Console.WriteLine($"avg={(decimal)total / 10.0m}");
        }

        // Exercise 3
        static void bangcuuchuong()
        {
            Console.Write("multi= ");
            byte multi = byte.Parse(Console.ReadLine());
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{multi}*{j}= {multi * j}");
            }
        }

        // Exercise 4 & 5
        static void tamgiac()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            System.Console.WriteLine("first one");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}  ");
                }
                Console.WriteLine();
            }

            System.Console.WriteLine("second one");
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    Console.Write($"{count}  ");
                }
                Console.WriteLine();
            }

            System.Console.WriteLine("third one");
            int count1 = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    System.Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    count1++;
                    Console.Write($" {count1}  ");
                }
                Console.WriteLine();
            }
        }

        // Exercise 6
        static void hamornic()
        {
            decimal value = 0m;
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}");
                if (i < n)
                {
                    Console.Write(" + ");
                }
                value += 1.0m / i;
            }
            Console.WriteLine();
            Console.WriteLine($"value = {value:f2}");
        }

        // Exercise 7
        static void perfect()
        {
            Console.Write("start: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("end: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                System.Console.WriteLine("try again");
                return;
            }
            System.Console.Write($"all the perfect numbers within [{a};{b}]:");
            for (int i = a; i <= b; i++)
            {
                if (i <= 1)
                {
                    continue;
                }
                int sum = 1;
                int limit = (int)Math.Sqrt(i);
                for (int j = 2; j <= limit; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                        if (j != i / j)
                        {
                            sum += i / j;
                        }
                    }
                }
                if (sum == i)
                {
                    System.Console.Write($" {i} ");
                }
            }
            Console.WriteLine();
        }

        // Exercise 8
        static void prime()
        {
            Console.Write("numbe to check: ");
            int check_prime = int.Parse(Console.ReadLine());
            if (check_prime <= 1)
            {
                System.Console.WriteLine("try again");
                return;
            }
            if (check_prime == 2)
            {
                System.Console.WriteLine("2 is a prime");
                return;
            }
            int checker = (int)Math.Sqrt(check_prime);
            for (int j = 3; j <= checker; j++)
            {
                if (check_prime % j == 0)
                {
                    System.Console.WriteLine($"{check_prime} is not a prime");
                    return;
                }
                else
                {
                    continue;
                }
            }
            System.Console.WriteLine($"{check_prime} is a prime");
        }
    }
}
