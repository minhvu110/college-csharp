using System;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Workspace
{
    class Exercise2
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            bai12();
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
            double avg = (tccsharp * csharp + toan * tctoan + anh * tcanh) / (tccsharp + tctoan + tcanh);
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
        static void bai6()
        {
            // Test case= Lâm Hồng Hải Hoàng Lê
            char[] codau = "áàảãạăắằẳẵặâấầẩẫậđéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵ".ToCharArray();
            char[] kdau = "aaaaaaaaaaaaaaaaadeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyy".ToCharArray();
            System.Console.Write("Nhập họ tên thô: ");
            string tengoc = System.Console.ReadLine();
            tengoc = tengoc.ToLower();
            string[] words = tengoc.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            System.Console.Write("Họ tên chuẩn hóa: ");
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                System.Console.Write($"{words[i]} ");

            }
            System.Console.WriteLine();
            string tendem = "";
            if (words.Length > 2)
            {
                for (int j = 1; j <= words.Length - 2; j++)
                {
                    tendem += words[j] + " ";
                }
            }
            System.Console.WriteLine($"Họ: {words[0]} | Tên đệm: {tendem} | Tên: {words[words.Length - 1]}");
            string[] bodau = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                string w = words[i].ToLower();
                for (int j = 0; j < codau.Length; j++)
                {
                    w = w.Replace(codau[j], kdau[j]);
                }
                bodau[i] = w;
            }
            string tendembodau = "";
            if (bodau.Length > 2)
            {
                for (int j = 1; j <= bodau.Length - 2; j++)
                {
                    tendembodau += bodau[j];
                }
            }
            string username = bodau[bodau.Length - 1] + "." + bodau[0] + tendembodau;
            System.Console.WriteLine($"Username tạo tự động: {username}");
            string email = username + "@company.edu.vn";
            System.Console.WriteLine($"Email cấp phát: {email}");
        }
        static void bai7()
        {
            System.Console.Write("Quãng đường (km): ");
            double distance = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Mức tiêu hao (L/100km): ");
            double gas = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Giá xăng (VNĐ/Lít): ");
            decimal gas_price = Convert.ToDecimal(System.Console.ReadLine());
            System.Console.Write("Số người đi: ");
            int people = Convert.ToInt16(System.Console.ReadLine());
            double consumed = (distance / 100) * gas;
            System.Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {consumed:f2} Lít");
            decimal total_gas = (decimal)consumed * gas_price;
            System.Console.WriteLine($"Tổng chi phí xăng dầu: {Math.Floor(total_gas):C0} VNĐ");
            decimal raw_person = total_gas / people;
            System.Console.WriteLine($"Chi phí mỗi người: {(Math.Ceiling(raw_person / 1000m) * 1000m):C0} VNĐ");
        }
        static void bai8()
        {
            string otp_chuan = "839201";
            string otp;
            do
            {
                System.Console.Write("Mã OTP nhận được: ");
                otp = System.Console.ReadLine();
                otp = otp.Trim();
                bool check_1 = int.TryParse(otp, out int checking) && otp.Length == 6;
                if (check_1 == false)
                {
                    System.Console.WriteLine("LỖI - Định dạng không hợp lệ");
                    continue;
                }
                if (otp != otp_chuan)
                {
                    System.Console.WriteLine("LỖI - Mã sai");
                    continue;
                }
                break;
            } while (true);
            System.Console.Write("Số phút trôi qua: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Số giây trôi qua: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            TimeSpan elaspedtime = new TimeSpan(0, minutes, seconds);
            if (elaspedtime.TotalSeconds > 300)
            {
                System.Console.WriteLine("LỖI - Hết hạn OTP");
                return;
            }
            System.Console.WriteLine("THÀNH CÔNG - Giao dịch đã được phê duyệt.");
        }
        static void bai9()
        {
            System.Console.Write("Lương Gross: ");
            decimal gross = Convert.ToDecimal(System.Console.ReadLine());
            System.Console.Write("Số người phụ thuộc: ");
            int people = Convert.ToInt32(System.Console.ReadLine());
            decimal insurance = gross * 0.105m;
            System.Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {insurance:C0} VNĐ");
            decimal ictax = gross - insurance - 11_000_000m - (people * 4_400_000m);
            ictax = Math.Max(0m, ictax);
            System.Console.WriteLine($"Thu nhập chịu thuế: {ictax:C0} VNĐ");
            decimal count = Math.Ceiling(ictax / 5_000_000m);
            decimal tncn = 0m;
            if (ictax <= 0)
                tncn = 0m;
            else if (ictax <= 5_000_000m)
                tncn = ictax * 0.05m;
            else if (ictax <= 10_000_000m)
                tncn = (5_000_000m * 0.05m) + (ictax - 5_000_000m) * 0.10m;
            else if (ictax <= 18_000_000m)
                tncn = (5_000_000m * 0.05m) + (5_000_000m * 0.10m) + (ictax - 10_000_000m) * 0.15m;
            else if (ictax <= 32_000_000m)
                tncn = 250_000m + 500_000m + 1_200_000m + (ictax - 18_000_000m) * 0.20m;
            else if (ictax <= 52_000_000m)
                tncn = 250_000m + 500_000m + 1_200_000m + 2_800_000m + (ictax - 32_000_000m) * 0.25m;
            else if (ictax <= 80_000_000m)
                tncn = 250_000m + 500_000m + 1_200_000m + 2_800_000m + 5_000_000m + (ictax - 52_000_000m) * 0.30m;
            else
                tncn = 250_000m + 500_000m + 1_200_000m + 2_800_000m + 5_000_000m + 8_400_000m + (ictax - 80_000_000m) * 0.35m;
            System.Console.WriteLine($"Thuế TNCN phải nộp: {tncn:C0} VNĐ");
            decimal net = gross - insurance - tncn;
            System.Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {net:C0} VNĐ");
        }
       //unsolved
        static void bai10()
        {

        }
        static void bai11()
        {
            System.Console.Write("Số tiền gửi: ");
            decimal p =Convert.ToDecimal(System.Console.ReadLine());
            System.Console.Write("Lãi suất năm: ");
            double r= Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Thời gian gửi: ");
            int n = Convert.ToInt32(System.Console.ReadLine());
            decimal si = p * ((decimal)r / 100m) * ((decimal)n / 12.0m);
            decimal ci = (decimal)((double)p*Math.Pow((1 + (r / 100.0) / 12.0), n))-p;
            System.Console.WriteLine($"Tổng tiền lãi (Lãi đơn): {si:C0} VNĐ");
            System.Console.WriteLine($"Tổng tiền lãi (Lãi kép): {ci:C0} VNĐ");
            System.Console.WriteLine($"Lợi nhuận chênh lệch: {(ci-si):C0} VNĐ");
        }
        static void bai12()
        {
            static string cypher_decypher(string text, int shift)
            {
                string ceasar = "";
                foreach (char c in text)
                {
                    if(char.IsUpper(c)==true)
                    {
                        ceasar += (char)('A' + (c - 'A' + shift) % 26);
                    }
                    else if(char.IsLower(c)==true)
                    {
                        ceasar += (char)('a' + (c - 'a' + shift) % 26);
                    }
                    else
                    {
                        ceasar += c;
                    }
                }
                return ceasar;
            }
            System.Console.Write("Văn bản gốc: ");
            string ogtext = System.Console.ReadLine();
            System.Console.Write("Khóa dịch chuyển (Shift Key k): ");
            int k = Convert.ToInt32(System.Console.ReadLine());
            string encrypted = cypher_decypher(ogtext, k);
            string decrypted = cypher_decypher(encrypted, 26 - k);
            System.Console.WriteLine($"Văn bản Mã hóa: {encrypted}");
            System.Console.WriteLine($"Văn bản Giải mã: {decrypted}");
        }
    }
}
