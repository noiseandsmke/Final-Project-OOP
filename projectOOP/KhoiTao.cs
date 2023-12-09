using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class KhoiTao
    {
        public static void KhoiTaoThongTin(List<NguoiChuNha> ChuNha, List<NguoiThue> NguoiThueNha, List<PhongTro> PhongTroChoThue)
        {
            KhoiTaoChuNha(ChuNha);
            KhoiTaoNguoiThue(NguoiThueNha);
            KhoiTaoPhongTro(PhongTroChoThue);
        }
        public static void KhoiTaoChuNha(List<NguoiChuNha> ChuNha)
        {
            NguoiChuNha chuNha01 = new NguoiChuNha("Duc Huy", 21, 20145449, "01234244179", "Nam", "Shark");
            NguoiChuNha chuNha02 = new NguoiChuNha("Hoai Lam", 20, 20110112, "01234655478", "Nam", "Richoi");

            ChuNha.Add(chuNha01);
            ChuNha.Add(chuNha02);
        }
        public static void KhoiTaoNguoiThue(List<NguoiThue> NguoiThueNha)
        {
            NguoiThue nguoiThue01 = new NguoiThue("Thanh Long", 18, 20232014, "09975234752", "Nam", "Sinh vien");
            NguoiThue nguoiThue02 = new NguoiThue("Tuan Anh", 19, 20232024, "0915334752", "Nam", "Sinh vien");

            NguoiThueNha.Add(nguoiThue01);
            NguoiThueNha.Add(nguoiThue02);
        }
        public static void KhoiTaoPhongTro(List<PhongTro> PhongTroChoThue)
        {
            PhongTro phongTro01 = new PhongTro(50, "Tu lanh, may lanh", 6000000, "GoVap", false, false, true, true, 3, "Khong hut thuoc");
            PhongTro phongTro02 = new PhongTro(40, " ", 4500000, "GoVap", false, false, true, true, 2, "Khong nhau nhet");
            PhongTro phongTro03 = new PhongTro(45, " ", 4000000, "ThuDuc", true, false, true, true, 2, "Ve truoc 23h toi");
            PhongTro phongTro04 = new PhongTro(35, " ", 3500000, "ThuDuc", false, false, true, true, 2, "Sinh vien SPKT");

            PhongTroChoThue.Add(phongTro01);
            PhongTroChoThue.Add(phongTro02);
            PhongTroChoThue.Add(phongTro03);
            PhongTroChoThue.Add(phongTro04);
        }
        public static void ThemPhongChoChuNha(List<NguoiChuNha> ChuNha, List<PhongTro> PhongTroChoThue)
        {
            ChuNha[0].ThemPhong(PhongTroChoThue[0]);
            ChuNha[0].ThemPhong(PhongTroChoThue[1]);
            ChuNha[1].ThemPhong(PhongTroChoThue[2]);
            ChuNha[1].ThemPhong(PhongTroChoThue[3]);
        }
    }
}