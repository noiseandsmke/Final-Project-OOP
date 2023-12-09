using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class LuaChon
    {
        public static void Menu(ref int option)
        {
            Console.WriteLine("[1]. Nguoi thue tro");
            Console.WriteLine("[2]. Nguoi cho thue tro");
            Console.WriteLine("[3]. Thoat chuong trinh");
            Console.Write("Nhap lua chon: ");
            string input = Console.ReadLine();
            int.TryParse(input, out option);
        }
        public static void NguoiThue(List<NguoiThue> NguoiThueNha, List<PhongTro> PhongTroChoThue)
        {
            Console.WriteLine("Vui long chon thong tin cua ban: ");
            int cnt = 0;
            NguoiThue nguoiChon = null;
            foreach (NguoiThue nguoi in NguoiThueNha)
            {
                Console.WriteLine($"================{++cnt}================");
                nguoi.InThongTin();
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
                return;
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
            while (true)
            {
                Console.WriteLine("[1] Ky hop dong thue tro nay.");
                Console.WriteLine("[2] In thong tin cua ban.");
                Console.WriteLine("[3] Quay lai.");
                Console.Write(">> Nhap lua chon: ");
                int luaChon = int.Parse(Console.ReadLine());
                if (luaChon == 1)
                {
                    Console.WriteLine(">>> KY HOP DONG <<<");
                    DateTime hetHan = new DateTime(2023, 12, 30);
                    nguoiChon.KyHopDong(phongCanTim, phongCanTim.ChuNha, hetHan);
                }
                else if (luaChon == 2)
                {
                    nguoiChon.InThongTin();
                }
                else if (luaChon == 3)
                {
                    break;
                }
            }
        }
        public static void NguoiChoThue()
        {

        }
        public static void KetThuc()
        {

        }
    }
}
