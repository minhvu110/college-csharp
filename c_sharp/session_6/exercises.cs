using System;



internal class Program
{
    public static long largest(params long[] numbers)
    {
        if (numbers.Length == 0)
        {
            Console.WriteLine("try again");
        }
        long temp = numbers[0];
        foreach (long number in numbers)
        {
            if (number > temp) temp = number;
        }
        return temp;
    }
    public static long factorial(long x)
    {
        long total = 1;
        for (long i = 1; i <= x; i++)
        {
            total *= i;
        }
        return total;
    }
    static bool is_prime(int prime)
    {
        if (prime <= 1)
        {
            return false;
        }
        for (int i = 2; i <= (int)(Math.Sqrt(prime)); i++)
        {
            if (prime % i == 0)
                return false;
        }
        return true;
    }
    static void print_all_the_primes_less_than_N(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (is_prime(i))
            {
                System.Console.Write($"{i} ");
            }
        }
        System.Console.WriteLine();
    }
    static void print_the_frist_N_numbers(int n)
    {
        int count = 0;
        int number = 2;
        while (count < n)
        {
            if (is_prime(number))
            {
                System.Console.Write($"{number} ");
                count++;
            }
            number++;
        }
        System.Console.WriteLine();
    }
    static bool is_perfect(int n)
    {
        if (n <= 1) return false;
        int sum = 1;
        for (int i = 2; i <= (int)(Math.Sqrt(n)); i++)
        {
            if (n % i == 0)
            {
                sum += i;
                if (i != n / i)
                {
                    sum += n / i;
                }
            }
        }
        if (sum == n)
            return true;
        else return false;
    }
    static void print_all_the_prefect_number_under_1000()
    {
        int number = 2;
        while (number < 1000)
        {
            if (is_perfect(number))
            {
                System.Console.Write($"{number} ");
            }
            number++;
        }
        System.Console.WriteLine();
    }
    static bool IS_PANGRAMS(string str)
    {
        str = str.ToLower();
        int[] tracker = new int[26];
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (c >= 'a' && c <= 'z')
            {
                int index = c - 'a';
                tracker[index]++;
            }
        }
        for (int i = 0; i < 25; i++)
        {
            if (tracker[i] == 0)
            {
                return false;
            }
        }
        return true;
    }
    public static void Main1(string[] args)
    {
        //Write a C# function to find the maximum of three numbers.
        //-Improve the next version that accept at least 1 parameter
        Console.Write("enter number 1: ");
        long a = long.Parse(Console.ReadLine());
        Console.Write("enter number 2: ");
        long b = long.Parse(Console.ReadLine());
        Console.Write("enter number 3: ");
        long c = long.Parse(Console.ReadLine());
        Console.WriteLine($"largest {largest(a, b, c)}");
        //Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        Console.Write("enter a number to factorial: ");
        long num = long.Parse(Console.ReadLine());
        Console.WriteLine(factorial(num));
        //Write a C# function that takes a number as a parameter and checks whether the number is prime or not
        Console.Write("enter a number to check: ");
        int prime_check = int.Parse(Console.ReadLine());
        if (is_prime(prime_check))
        {
            System.Console.WriteLine($"{prime_check} is a prime");
        }
        else
        {
            System.Console.WriteLine($"{prime_check} is not a prime");
        }
        // Write a C# function to print
        // 1. all prime numbers that less than a number (enter prompt keyboard).
        // 2. the first N prime numbers
        Console.Write("enter a number: ");
        int numberN = int.Parse(Console.ReadLine());
        System.Console.Write("all prime numbers that less than a number ");
        print_all_the_primes_less_than_N(numberN);
        System.Console.Write("the first N prime numbers ");
        print_the_frist_N_numbers(numberN);
        // Write a C# function to check whether a number is "Perfect" or not. Then print
        // all perfect number that less than 1000
        Console.Write("enter a number: ");
        int perfect = int.Parse(Console.ReadLine());
        if (is_perfect(perfect))
        {
            System.Console.WriteLine($"{perfect} is a perfect number");
        }
        else
        {
            System.Console.WriteLine($"{perfect} is not a perfect number");
        }
        print_all_the_prefect_number_under_1000();
        // Write a C# function to check whether a string is a pangram or not.
        // (Note : Pangrams are words or sentences containing every letter of the alphabet at
        // least once. For example : "The quick brown fox jumps over the lazy dog
        System.Console.Write("enter your string: ");
        string pangrams = Console.ReadLine();
        if (IS_PANGRAMS(pangrams))
        {
            System.Console.WriteLine(pangrams + " is a pangram");
        }
        else
        {
            System.Console.WriteLine(pangrams + " is not a pangram");
        }
    }

}
