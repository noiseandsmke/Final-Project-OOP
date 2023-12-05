using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class NguoiThue : Nguoi
    {
        public NguoiThue(string hoTen, int tuoi, int cmnd, string soDienThoai, string gioiTinh, string ngheNghiep) : base(hoTen, tuoi, cmnd, soDienThoai, gioiTinh, ngheNghiep)
        {
        }
        public void TimTro(string diaChi, int giaCa, List<PhongTro> PhongTro)
        {
            PhongTro phong = PhongTro.Where(phongTro => phongTro.DiaChi == diaChi && phongTro.GiaCa == giaCa).FirstOrDefault();
            if (phong != null)
            {
                Console.WriteLine(">>THONG TIN PHONG TRO<<");
                phong.InThongTin();
            }
            else { Console.WriteLine(">>KHONG TIM THAY PHONG TRO<<"); }
        }
        public void InThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Tuoi : {Tuoi}");
            Console.WriteLine($"Gioi tinh: {GioiTinh}");
            Console.WriteLine($"So dien thoai: {SoDienThoai}");
        }
    }
}