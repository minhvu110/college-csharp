using System;
using System.Text;

namespace Workspace
{
    class Program
    {
        static int TinhTong(int a, int b)
        {
            return a + b;
        }

        static bool KiemTraChan(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        static int TimMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static long TinhGiaiThua(int n)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static string DaoNguocChuoi(string input)
        {
            char[] processing_input = input.ToCharArray();
            Array.Reverse(processing_input);
            return new string(processing_input);
        }

        static bool KiemTraNguyenTo(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= (int)(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void InFibonacci(int n)
        {
            if (n == 0) return;
            if (n == 1)
            {
                System.Console.WriteLine("1");
                return;
            }
            int a = 0;
            int b = 1;
            Console.Write($"{a} {b} ");
            for (int i = 3; i <= n; i++)
            {
                int next = a + b;
                System.Console.Write($"{next} ");
                a = b;
                b = next;
            }
        }

        static int DemNguyenAm(string s)
        {
            int count = 0;
            s = s.ToLower();
            char[] vowel = { 'a', 'i', 'e', 'o', 'u' };
            foreach (char c in s)
            {
                for (int i = 0; i < vowel.Length; i++)
                {
                    if (c == vowel[i])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }

        static double TinhLuyThua(double x, int y)
        {
            double total = 1;
            for (int i = 1; i <= y; i++)
            {
                total *= (double)x;
            }
            return total;
        }

        static double TinhTrungBinh(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return (double)total / (double)(arr.Length);
        }

        static bool KiemTraDoiXung(string s)
        {
            s = s.ToLower();
            char[] buffer = s.ToCharArray();
            Array.Reverse(buffer);
            string reversed = new string(buffer);
            if (s == reversed)
            {
                return true;
            }
            return false;
        }

        static double CelsiusToFahrenheit(double c)
        {
            return (c * 1.8) + 32.0;
        }

        static int TimMin(int[] arr)
        {
            int smallest = arr[0];
            foreach (int so in arr)
            {
                smallest = Math.Min(smallest, so);
            }
            return smallest;
        }

        static int TongCacChuSo(int n)
        {
            string chuoiso = n.ToString();
            char[] mang_chuoi_so = chuoiso.ToCharArray();
            int total = 0;
            for (int i = 0; i < mang_chuoi_so.Length; i++)
            {
                total += int.Parse(mang_chuoi_so[i].ToString());
            }
            return total;
        }

        static void SapXepMang(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        static string XoaTrungLap(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                if (result.Contains(c) == false)
                {
                    result += c;
                }
            }
            return result;
        }

        static int UCLN(int a, int b)
        {
            int temp = 0;
            if (b > a)
            {
                int buffer = 0;
                buffer = a;
                a = b;
                b = buffer;
            }
            while (b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }

        static string DecimalToBinary(int n)
        {
            string result = "";
            if (n == 0) return "0";
            while (n > 0)
            {
                result = (n % 2) + result;
                n /= 2;
            }
            return result;
        }

        static bool KiemTraNamNhuan(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        static int DemSoTu(string sentence)
        {
            int count = 0;
            bool is_in = false;
            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    is_in = false;
                }
                else if (is_in == false)
                {
                    is_in = true;
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Bài 1: Tính tổng hai số nguyên
            System.Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"a + b = {TinhTong(a, b)}");

            // Bài 2: Kiểm tra số chẵn lẻ
            System.Console.Write("enter n: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.WriteLine(KiemTraChan(number));

            // Bài 3: Tìm số lớn nhất
            System.Console.Write("enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.Write("enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            System.Console.Write("enter third number: ");
            int num3 = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"{TimMax(num1, num2, num3)} is the largest");

            // Bài 4: Tính giai thừa của một số
            System.Console.Write("enter a number to factorial: ");
            int facto = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"factorial of {facto} is {TinhGiaiThua(facto)}");

            // Bài 5: Đảo ngược chuỗi ký tự
            System.Console.Write("what is the string: ");
            string chuoi = Console.ReadLine();
            System.Console.WriteLine($"{chuoi} co nghich dao chuoi la {DaoNguocChuoi(chuoi)}");

            // Bài 6: Kiểm tra số nguyên tố
            System.Console.Write("enter a number to check for prime: ");
            int prime = int.Parse(Console.ReadLine());
            System.Console.WriteLine(KiemTraNguyenTo(prime));

            // Bài 7: In dãy Fibonacci
            System.Console.Write("enter a number for the Fibonacci: ");
            int runs = int.Parse(Console.ReadLine());
            InFibonacci(runs);
            System.Console.WriteLine();

            // Bài 8: Đếm số lượng nguyên âm trong chuỗi
            System.Console.Write("what is the string: ");
            string vowel_check = Console.ReadLine();
            System.Console.WriteLine($"{DemNguyenAm(vowel_check)}");

            // Bài 9: Tính lũy thừa
            System.Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            System.Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            System.Console.WriteLine(TinhLuyThua(x, y));

            // Bài 10: Tính điểm trung bình của mảng
            System.Console.Write("Nhap so luong phan tu: ");
            int soluong = int.Parse(Console.ReadLine());
            int[] mang = new int[soluong];
            for (int i = 0; i < soluong; i++)
            {
                mang[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine(TinhTrungBinh(mang));

            // Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
            System.Console.Write("Nhap chuoi can check doi xung: ");
            string Palindrome = Console.ReadLine();
            System.Console.WriteLine(KiemTraDoiXung(Palindrome));

            // Bài 12: Chuyển đổi nhiệt độ
            System.Console.Write("Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            System.Console.WriteLine(CelsiusToFahrenheit(celsius));

            // Bài 13: Tìm giá trị nhỏ nhất trong mảng
            System.Console.Write("Nhap so luong phan tu: ");
            int soluong1 = int.Parse(Console.ReadLine());
            int[] mangso = new int[soluong1];
            for (int i = 0; i < soluong1; i++)
            {
                mangso[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine(TimMin(mangso));

            // Bài 14: Tính tổng các chữ số của một số nguyên
            System.Console.Write("enter the number: ");
            int numstring = int.Parse(Console.ReadLine());
            System.Console.WriteLine(TongCacChuSo(numstring));

            // Bài 15: Sắp xếp mảng tăng dần
            int[] mang1 = new int[Random.Shared.Next(1, 20)];
            for (int i = 0; i < mang1.Length; i++)
            {
                mang1[i] = Random.Shared.Next(1, 1000);
            }
            SapXepMang(mang1);
            for (int i = 0; i < mang1.Length; i++)
            {
                System.Console.Write(mang1[i] + " ");
                if ((i + 1) % 10 == 0) System.Console.WriteLine();
            }
            System.Console.WriteLine();

            // Bài 16: Xóa ký tự trùng lặp
            System.Console.Write("input string: ");
            string input_string = Console.ReadLine();
            System.Console.WriteLine(XoaTrungLap(input_string));

            // Bài 17: Tìm ước chung lớn nhất (UCLN)
            System.Console.Write("a = ");
            int num_a = int.Parse(Console.ReadLine());
            System.Console.Write("b = ");
            int num_b = int.Parse(Console.ReadLine());
            System.Console.WriteLine(UCLN(num_a, num_b));

            // Bài 18: Chuyển đổi hệ thập phân sang nhị phân
            System.Console.Write("input: ");
            int decimal_input = int.Parse(Console.ReadLine());
            System.Console.WriteLine(DecimalToBinary(decimal_input));

            // Bài 19: Kiểm tra năm nhuận
            System.Console.Write("enter year: ");
            int year = int.Parse(Console.ReadLine());
            System.Console.WriteLine(KiemTraNamNhuan(year));

            // Bài 20: Đếm số từ trong câu
            System.Console.Write("enter sentence: ");
            string dem_tu = Console.ReadLine();
            System.Console.WriteLine(DemSoTu(dem_tu));
        }
    }
}
