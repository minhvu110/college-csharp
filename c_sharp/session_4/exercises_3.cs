using System;


namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            phuong_trinh_bac2();
            System.Console.WriteLine("next");

            odd_even();
            System.Console.WriteLine("next");

            large_num();
            System.Console.WriteLine("next");

            tam_giac();
            System.Console.WriteLine("next");

            coord();
            System.Console.WriteLine("next");
            Console.ReadKey();

        }

        static void phuong_trinh_bac2()
        {
            Console.Write("enter a= ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter b= ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter c= ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    Console.WriteLine($"Phuong trinh bac nhat co 1 nghiem: x = {-c / b}");
                }
                return;
            }
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Delta < 0, phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep: x1 = x2 = {x}");
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
        static void odd_even()
        {
            System.Console.Write("enter a number: ");
            long number = Convert.ToInt64(System.Console.ReadLine());
            if (number % 2 == 0)
            {
                System.Console.WriteLine("even");
                return;
            }
            System.Console.WriteLine("odd");
        }
        static void large_num()
        {

            System.Console.Write("enter number 1= ");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            System.Console.Write("enter number 2= ");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            System.Console.Write("enter number 3= ");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            decimal largest = num1;
            largest = Math.Max(largest, num2);
            largest = Math.Max(largest, num3);
            System.Console.WriteLine($"largest number out of 3: {largest}");
        }
        static void tam_giac()
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
        static void coord()
        {
            System.Console.Write("Input the value for X coordinate: ");
            decimal xcoord = Convert.ToDecimal(Console.ReadLine());
            System.Console.Write("Input the value for Y coordinate: ");
            decimal ycoord = Convert.ToDecimal(Console.ReadLine());
            if (xcoord == 0 && ycoord == 0)
            {
                Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) is at the Origin");
                return;
            }
            if (xcoord == 0)
            {
                Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) lies on the Y-axis");
                return;
            }
            if (ycoord == 0)
            {
                Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) lies on the X-axis");
                return;
            }
            if (xcoord > 0 && ycoord > 0)
            {
                Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) lies in the First quadrant");
                return;
            }
            if (xcoord < 0 && ycoord > 0)
            {
                Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) lies in the Second quadrant");
                return;
            }
            if (xcoord < 0 && ycoord < 0)
            {
                Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) lies in the Third quadrant");
                return;
            }

            Console.WriteLine($"The coordinate point ({xcoord},{ycoord}) lies in the Fourth quadrant");
        }
    }
}
