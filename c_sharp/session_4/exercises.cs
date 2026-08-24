using System;
internal class Program
{
    private static void Main(string[] args)
    {
        bai4();
    }
    static void bai1()
    {
        Console.Write("a= ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b= ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{a}+{b}={a + b}");
        Console.WriteLine($"{a}-{b}={a - b}");
        Console.WriteLine($"{a}*{b}={a * b}");
        Console.WriteLine($"{a}/{b}={a / b}");
    }
    static void bai2()
    {
        Console.Write("y=");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"x = {y}^2+ 2*{y} + 1= {Math.Pow(y, 2) + 2 * y + 1}");
    }
    static void bai3()
    {
        Console.Write("distance= ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("time in hours = ");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.Write("time in minutes = ");
        double m = Convert.ToDouble(Console.ReadLine());
        Console.Write("time in sec= ");
        double s = Convert.ToDouble(Console.ReadLine());
        double total = h + (m / 60) + (s / 3600);
        Console.WriteLine($"km/h= {(d / total)}");
        Console.WriteLine($"miles/h= {(d * 0.62 / total)}");
    }
    static void bai4()
    {
        Console.Write("r= ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"V= {(4.0 / 3.0) * Math.PI * Math.Pow(r, 3)}");
    }
    static void bai5()
    {
        Console.Write("c= ");
        char c = Convert.ToChar(Console.ReadLine());
        c = char.ToLower(c);
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            Console.WriteLine($"{c} is a vowel");
        }
        else if (char.IsDigit(c) == true)
        { Console.WriteLine($"{c} is a number"); }
        else Console.WriteLine("smth else");
    }
    static void bai6()
    {
        Console.Write("enter a= ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("enter b= ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("enter c= ");
        double d = Convert.ToDouble(Console.ReadLine());
        // Truong hop a = 0 -> Phuong trinh bac nhat: bx + d = 0
        if (a == 0)
        {
            if (b == 0)
            {
                if (d == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                Console.WriteLine($"Phuong trinh bac nhat co 1 nghiem x = {-d / b}");
            }
            return;
        }

        // Tinh Delta
        double delta = b * b - 4 * a * d;

        if (delta < 0)
        {
            Console.WriteLine("Delta < 0, phuong trinh vo nghiem");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Phuong trinh co nghiem kep x1 = x2 = {x}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }

    }
}

