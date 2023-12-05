using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class PhongTro
    {
        private int dienTich;
        private int giaCa;
        private int soNguoiO;
        private string noiThat;
        private string diaChi;
        private string yeuCau;
        private bool tinhTrang;
        private bool phongDanhChoNu;
        private bool nuoiThuCung;
        private bool loiDiRieng;
        private bool gioGiacTuDo;
        public int DienTich
        {
            get { return dienTich; }
            set { dienTich = value; }
        }
        public string NoiThat
        {
            get { return noiThat; }
            set { noiThat = value; }
        }
        public int GiaCa
        {
            get { return giaCa; }
            set { giaCa = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public bool TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }
        public bool PhongDanhChoNu
        {
            get { return phongDanhChoNu; }
            set { phongDanhChoNu = value; }
        }
        public bool NuoiThuCung
        {
            get { return nuoiThuCung; }
            set { nuoiThuCung = value; }
        }
        public bool LoiDiRieng
        {
            get { return loiDiRieng; }
            set { loiDiRieng = value; }
        }
        public bool GioGiacTuDo
        {
            get { return gioGiacTuDo; }
            set { gioGiacTuDo = value; }
        }
        public int SoNguoiO
        {
            get { return soNguoiO; }
            set { soNguoiO = value; }
        }
        public string YeuCau
        {
            get { return yeuCau; }
            set { yeuCau = value; }
        }
        public void InThongTin()
        {
            Console.WriteLine($"Dien tich phong: {dienTich}");
            Console.WriteLine($"Noi that trong phong: {noiThat}");
            Console.WriteLine($"Gia phong: {giaCa}");
            Console.WriteLine($"Dia chi: {diaChi}");
            if (phongDanhChoNu)
            {
                Console.WriteLine("Phong danh cho: Nu.");
            }
            else
            {
                Console.WriteLine("Phong danh cho: Nam.");
            }
            if (nuoiThuCung)
            {
                Console.WriteLine("Phong duoc nuoi thu cung.");
            }
            else
            {
                Console.WriteLine("Phong khong cho nuoi thu cung.");
            }
            if (loiDiRieng)
            {
                Console.WriteLine("Co loi di rieng.");
            }
            else
            {
                Console.WriteLine("Khong co loi di rieng.");
            }
            if (gioGiacTuDo)
            {
                Console.WriteLine("Gio giac tu do.");
            }
            else
            {
                Console.WriteLine("Gio giac KHONG tu do.");
            }
            Console.WriteLine($"Duoc o toi da: {soNguoiO} nguoi");
            Console.WriteLine($"Yeu cau rieng: {yeuCau}");
        }
        public PhongTro(string diaChi, int GiaCa)
        {
            this.diaChi = diaChi;
            this.GiaCa = GiaCa;
        }
        public PhongTro(int dienTich, string noiThat, int giaCa, string diaChi, bool tinhTrang, bool phongDanhChoNu, bool nuoiThuCung, bool loiDiRieng, bool gioGiacTuDo, int soNguoiO, string yeuCau)
        {
            this.dienTich = dienTich;
            this.noiThat = noiThat;
            this.giaCa = giaCa;
            this.tinhTrang = tinhTrang;
            this.diaChi = diaChi;
            this.phongDanhChoNu = phongDanhChoNu;
            this.nuoiThuCung = nuoiThuCung;
            this.loiDiRieng = loiDiRieng;
            this.gioGiacTuDo = gioGiacTuDo;
            this.soNguoiO = soNguoiO;
            this.yeuCau = yeuCau;
        }
    }
}