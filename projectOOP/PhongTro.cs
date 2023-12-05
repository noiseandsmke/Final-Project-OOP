using System;
using System.Collections.Generic;
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