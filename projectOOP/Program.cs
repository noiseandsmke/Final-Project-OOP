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
            List<NguoiChuNha> ChuNha = new List<NguoiChuNha>();
            List<NguoiThue> NguoiThueNha = new List<NguoiThue>();
            List<PhongTro> PhongTroChoThue = new List<PhongTro>();
            KhoiTao.KhoiTaoThongTin(ChuNha, NguoiThueNha, PhongTroChoThue);
            KhoiTao.ThemPhongChoChuNha(ChuNha, PhongTroChoThue);

            int option = 0;
            while (true)
            {
                Console.WriteLine(">>> CHAO MUNG DEN CHUONG TRINH QUAN LY PHONG TRO <<<");
                LuaChon.Menu(ref option);
                if (option == 1)
                {
                    LuaChon.NguoiThue(NguoiThueNha, PhongTroChoThue);
                }
                if (option == 2)
                {
                    LuaChon.NguoiChoThue();
                }
                if (option == 3)
                {
                    break;
                }
                Console.ReadKey();
            }
        }
    }
}