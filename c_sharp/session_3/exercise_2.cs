using System;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Workspace
{
    class Exercise2
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            bai5();
            //Console.ReadKey();
        }
        static void bai1()
        {
            System.Console.Write("Nhập chỉ số điện cũ (kWh): ");
            float old = Convert.ToSingle(Console.ReadLine());
            float used;
            do
            {
                System.Console.Write("Nhập chỉ số điện mới (kWh): ");
                float newp = Convert.ToSingle(Console.ReadLine());
                if (newp >= old)
                {
                    used = newp - old;
                    break;
                }
                else
                {
                    System.Console.WriteLine("pls, try again...");
                }
            } while (true);
            float bac1 = Math.Max(0, Math.Min(used, 50));

            float bac2 = Math.Max(0, Math.Min(used - 50, 50));

            float bac3 = Math.Max(0, Math.Min(used - 100, 100));

            float bac4 = Math.Max(0, Math.Min(used - 200, 100));

            float bac5 = Math.Max(0, used - 300);

            decimal total = (decimal)(bac1 * 1806 + bac2 * 1866 + bac3 * 2167 + bac4 * 2729 + bac5 * 3050);
            System.Console.WriteLine($"Số điện tiêu thụ: {used} kWh");
            System.Console.WriteLine($"Tiền điện chưa thuế: {total:#,##0 VNĐ}");
            System.Console.WriteLine($"Thuế VAT (8%): {(total * 0.08m):#,##0 VNĐ}");
            System.Console.WriteLine($"Tổng thanh toán: {(total * 1.08m):#,##0 VNĐ}");
        }
        static void bai2()
        {
            System.Console.Write("Chiều cao (m): ");
            float height = Convert.ToSingle(Console.ReadLine());
            System.Console.Write("Cân nặng (kg): ");
            float weight = Convert.ToSingle(Console.ReadLine());
            double bmi = (double)(weight / Math.Pow(height, 2));
            System.Console.WriteLine($"Chỉ số BMI của bạn: {bmi:f2}");
            switch (bmi)
            {
                case < 18.5:
                    System.Console.WriteLine("Phân loại sức khỏe: Thiếu cân");
                    break;
                case < 23.0:
                    System.Console.WriteLine("Phân loại sức khỏe: Lý tưởng");
                    break;
                case < 25.0:
                    System.Console.WriteLine("Phân loại sức khỏe: Tiền béo phì");
                    break;
                case >= 25.0:
                    System.Console.WriteLine("Phân loại sức khỏe: Béo phì");
                    break;
            }
            System.Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {(18.5 * Math.Pow(height, 2)):f2} kg đến {(22.9 * Math.Pow(height, 2)):f2} kg");

        }
        static void bai3()
        {
            System.Console.Write("Nhập số tiền VNĐ: ");
            decimal money = decimal.Parse(Console.ReadLine());
            System.Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            byte choice = byte.Parse(Console.ReadLine());
            decimal tax = money * 0.005m;
            decimal actual = money - tax;
            System.Console.WriteLine($"Phí dịch vụ (0.5%): {tax:f2} VNĐ");
            System.Console.WriteLine($"Số tiền VNĐ tính đổi: {actual:f2} VNĐ");
            switch (choice)
            {
                case 1:
                    System.Console.WriteLine($"Số tiền USD nhận được: {(actual / 25400):f2} USD");
                    break;
                case 2:
                    System.Console.WriteLine($"Số tiền EUR nhận được: {(actual / 27200):f2} EUR");
                    break;
                case 3:
                    System.Console.WriteLine($"Số tiền JPY nhận được: {(actual / 165):f2} JPY");
                    break;
                case 4:
                    System.Console.WriteLine($"Số tiền GBP nhận được: {(actual / 32100):f2} GBP");
                    break;
            }

        }
        static void bai4()
        {
            DateTime now = DateTime.Now.Date;
            DateTime valid_date;
            do
            {
                System.Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                string date = Console.ReadLine();
                if ((DateTime.TryParseExact(date, "dd/MM/yyyy", null, 0, out valid_date)) == false)
                {
                    System.Console.WriteLine("pls, try again...");
                    continue;
                }
                if (valid_date > now)
                {
                    System.Console.WriteLine("pls, try again...");
                    continue;
                }
                break;
            } while (true);
            int age = now.Year - valid_date.Year;
            if (valid_date > now.AddYears(-age))
            {
                age--;
            }
            System.Console.WriteLine($"Tuổi hiện tại: {age}");
            TimeSpan lived = now - valid_date;
            System.Console.WriteLine($"Bạn đã sống tổng cộng: {(int)lived.TotalDays} ngày");
            DateTime next = new DateTime(now.Year, valid_date.Month, valid_date.Day);
            if (next < now)
            {
                next = next.AddYears(1);
            }
            System.Console.WriteLine($"Sinh nhật tiếp theo còn: {(int)(next - now).TotalDays} ngày nữa");
        }
        static void bai5()
        {
            int tccsharp = 4;
            int tctoan = 3;
            int tcanh = 2;
            System.Console.Write("C# (4 TC): ");
            double csharp = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Toán (3 TC): ");
            double toan = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Tiếng Anh (2 TC): ");
            double anh = Convert.ToDouble(Console.ReadLine());
            double avg = (tccsharp * csharp + toan * tctoan + anh*tcanh) / (tccsharp + tctoan + tcanh);
            System.Console.WriteLine($"Điểm TB Thang 10: {avg:f2}");
            switch (avg)
            {
                case >= 8.5:
                    System.Console.WriteLine("Điểm Chữ Quy Đổi: A \nĐiểm GPA Thang 4: 4.0 \nXếp Loại Học Lực: Giỏi");
                    break;
                case >= 7:
                    System.Console.WriteLine("Điểm Chữ Quy Đổi: B \nĐiểm GPA Thang 4: 3.0 \nXếp Loại Học Lực: Khá");
                    break;
                case >= 5.5:
                    System.Console.WriteLine("Điểm Chữ Quy Đổi: C \nĐiểm GPA Thang 4: 2.0 \nXếp Loại Học Lực: Trung bình");
                    break;
                case >= 4.0:
                    System.Console.WriteLine("Điểm Chữ Quy Đổi: D \nĐiểm GPA Thang 4: 1.0 \nXếp Loại Học Lực: Yếu");
                    break;
                case < 4.0:
                    System.Console.WriteLine("Điểm Chữ Quy Đổi: F \nĐiểm GPA Thang 4: 0.0 \nXếp Loại Học Lực: Kém (Trượt)");
                    break;
            }
        }
    }
}
