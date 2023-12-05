using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class Nguoi
    {
        private string hoTen;
        private int tuoi;
        private int cmnd;
        private string gioiTinh;
        private string ngheNghiep;
        private int soDienThoai;
        public int SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public string NgheNghiep
        {
            get { return ngheNghiep; }
            set { ngheNghiep = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public int CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public int Tuoi
        {
            get { return tuoi; }
            set { tuoi = value; }
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public Nguoi(string hoTen, int tuoi, int soDienThoai, int cmnd, string gioiTinh, string ngheNghiep)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.soDienThoai = soDienThoai;
            this.cmnd = cmnd;
            this.gioiTinh = gioiTinh;
            this.ngheNghiep = ngheNghiep;
        }
    }
}