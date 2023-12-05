using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khoi tao thong tin
            NguoiChuNha chuNha01 = new NguoiChuNha("Duc Huy", 21, 20145449, "01234244179", "Nam", "Shark");
            NguoiChuNha chuNha02 = new NguoiChuNha("Hoai Lam", 20, 20110112, "01234655478", "Nam", "Richoi");

            NguoiThue nguoiThue01 = new NguoiThue("Thanh Long", 18, 20232014, "09975234752", "Nam", "Sinh vien");
            NguoiThue nguoiThue02 = new NguoiThue("Tuan Anh", 19, 20232024, "0915334752", "Nam", "Sinh vien");

            PhongTro phongTro01 = new PhongTro(50, "Tu lanh, may lanh", 6000000, "GoVap", false, false, true, true, 3, "Khong hut thuoc");
            PhongTro phongTro02 = new PhongTro(40, " ", 4500000, "GoVap", true, false, true, true, 2, "Khong nhau nhet");
            PhongTro phongTro03 = new PhongTro(45, " ", 4000000, "ThuDuc", true, false, true, true, 2, "Ve truoc 23h toi");
            PhongTro phongTro04 = new PhongTro(35, " ", 3500000, "ThuDuc", false, false, true, true, 2, "Sinh vien SPKT");

            List<NguoiChuNha> ChuNha = new List<NguoiChuNha>();
            ChuNha.Add(chuNha01);
            ChuNha.Add(chuNha02);
            List<NguoiThue> NguoiThueNha = new List<NguoiThue>();
            NguoiThueNha.Add(nguoiThue01);
            NguoiThueNha.Add(nguoiThue02);
            List<PhongTro> PhongTroChoThue = new List<PhongTro>();
            PhongTroChoThue.Add(phongTro01);
            PhongTroChoThue.Add(phongTro02);
            PhongTroChoThue.Add(phongTro03);
            PhongTroChoThue.Add(phongTro04);

            // Bat dau chuong trinh
            Console.WriteLine("Chao mung den chuong trinh quan ly phong tro!!");
            while (true)
            {
                Console.WriteLine("[1]. Nguoi thue tro");
                Console.WriteLine("[2]. Nguoi cho thue tro");
                Console.WriteLine("[3]. Thoat chuong trinh");
                Console.Write("Nhap lua chon: ");
                int option;
                string input = Console.ReadLine();
                int.TryParse(input, out option);
                // Nguoi thue tro
                if (option == 1)
                {
                    // Chon nguoi thue tro
                    Console.WriteLine("Vui long chon thong tin cua ban: ");
                    int cnt = 0;
                    NguoiThue nguoiChon = null;
                    foreach (NguoiThue nguoi in NguoiThueNha)
                    {
                        Console.WriteLine($"================{++cnt}================");
                        nguoi.InThongTin();
                        Console.WriteLine("*********************************");
                    }
                    ++cnt;
                    Console.WriteLine($"Quay lai an phim {cnt}");
                    int thongTin = int.Parse(Console.ReadLine());
                    if (thongTin <= 0 || thongTin > cnt)
                    {
                        Console.WriteLine("Invalid! Enter again: ");
                    }
                    else if (thongTin == cnt)
                    {
                        break;
                    }
                    else
                    {
                        int dem = 1;
                        foreach (NguoiThue nguoi in NguoiThueNha)
                        {
                            if (dem == thongTin)
                            {
                                nguoiChon = nguoi;
                            }
                            dem++;
                        }
                        Console.WriteLine($"Xin chao: {nguoiChon.HoTen}");
                    }
                    // Chuc nang cua nguoi thue tro
                    Console.WriteLine("Nhap thong tin tro can tim:");
                    Console.Write("Dia chi tro: ");
                    string diaChi = Console.ReadLine();
                    Console.Write("Gia phong tro: ");
                    int giaCa = int.Parse(Console.ReadLine());
                    PhongTro phongCanTim = nguoiChon.TimTro(diaChi, giaCa, PhongTroChoThue);
                    Console.WriteLine(">>>KY HOP DONG");
                    DateTime hetHan = new DateTime(2023, 12, 30);
                    nguoiChon.KyHopDong(phongCanTim, chuNha01, hetHan);
                    nguoiChon.HopDong.ThongTinHopDong();
                }
                // Nguoi cho thue tro
                while (option == 2)
                {

                }
                // Thoat chuong trinh
                if (option == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Vui long nhap lai.");
                }
            }
        }
    }
}
