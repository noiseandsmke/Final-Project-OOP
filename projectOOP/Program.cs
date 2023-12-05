using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            NguoiChuNha chuNha01 = new NguoiChuNha("Duc Huy", 21, 20145449, "Nam", "Shark", 01234244179);
            NguoiChuNha chuNha02 = new NguoiChuNha("Hoai Lam", 20, 20110112, "Nam", "Richoi", 01234655478);
            PhongTro phongTro01 = new PhongTro(50, "Tu lanh, may lanh, tivi", 6000000, "GoVap", true, false, false, true, true, 3, "Khong hut thuoc");
            PhongTro phongTro02 = new PhongTro(40, " ", 4500000, "GoVap", true, true, false, true, true, 2, "Khong nhau nhet");
        }
    }
}
