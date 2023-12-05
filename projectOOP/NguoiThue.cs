using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class NguoiThue : Nguoi
    {
        private HopDong hopDong;

        public HopDong HopDong
        {
            get { return hopDong; }
            set { hopDong = value; }
        }

        public NguoiThue(string hoTen, int tuoi, int cmnd, string soDienThoai, string gioiTinh, string ngheNghiep) : base(hoTen, tuoi, cmnd, soDienThoai, gioiTinh, ngheNghiep)
        {
        }
        public PhongTro TimTro(string diaChi, int giaCa, List<PhongTro> PhongTro)
        {
            PhongTro phong = PhongTro.Where(phongTro => phongTro.DiaChi == diaChi && phongTro.GiaCa == giaCa).FirstOrDefault();
            if (phong != null)
            {
                Console.WriteLine(">>THONG TIN PHONG TRO<<");
                phong.InThongTin();
                return phong;
            }
            else
            {
                Console.WriteLine(">>KHONG TIM THAY PHONG TRO<<");
                return null;
            }
        }
        public void InThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Tuoi : {Tuoi}");
            Console.WriteLine($"Gioi tinh: {GioiTinh}");
            Console.WriteLine($"So dien thoai: {SoDienThoai}");
        }
        public void KyHopDong(PhongTro phong, NguoiChuNha chuNha, DateTime ngayHetHan)
        {
            hopDong.TienCoc = phong.GiaCa / 2;
            hopDong.NgayKy = DateTime.Now;
            hopDong.HanHopDong = ngayHetHan;
            hopDong.KyVoi = chuNha;
        }
    }
}