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
        private PhongTro phongThue;
        public HopDong HopDong
        {
            get { return hopDong; }
            set { hopDong = value; }
        }
        public PhongTro PhongThue
        {
            get { return phongThue; }
            set { phongThue = value; }
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
        private string ThongTinTro()
        {
            if (phongThue == null)
            {
                return $"dang di tim tro";
            }
            else
            {
                return $"dang thue tro o {phongThue.DiaChi}";
            }
        }
        public void InThongTin()
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Tuoi : {Tuoi}");
            Console.WriteLine($"Gioi tinh: {GioiTinh}");
            Console.WriteLine($"So dien thoai: {SoDienThoai}");
            Console.WriteLine($"Thong tin tro: {ThongTinTro()}");
            if (phongThue != null)
            {
                Console.WriteLine($"Co hop dong den: {hopDong.HanHopDong}");
            }
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        }
        public void KyHopDong(PhongTro phong, NguoiChuNha chuNha, DateTime ngayHetHan)
        {
            double tienCoc = (double)phong.GiaCa / 2;
            this.phongThue = phong;
            hopDong = new HopDong(tienCoc, DateTime.Now, ngayHetHan, chuNha);
            hopDong.ThongTinHopDong();
        }
    }
}