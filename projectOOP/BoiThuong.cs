using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class BoiThuong
    {
        private PhongTro phongThue;
        private NguoiThue nguoiThue;
        private NguoiChuNha chuNha;
        private string thongTinBoiThuong;
        public string ThongTinBoiThuong
        {
            get { return thongTinBoiThuong; }
            set { thongTinBoiThuong = value; }
        }
        public NguoiChuNha ChuNha
        {
            get { return chuNha; }
            set { chuNha = value; }
        }
        public NguoiThue NguoiThue
        {
            get { return nguoiThue; }
            set { nguoiThue = value; }
        }
        public PhongTro PhongThue
        {
            get { return phongThue; }
            set { phongThue = value; }
        }
        public BoiThuong(PhongTro phongThue, NguoiThue nguoiThue, NguoiChuNha chuNha)
        {
            this.phongThue = phongThue;
            this.nguoiThue = nguoiThue;
            this.chuNha = chuNha;
            thongTinBoiThuong = $"Boi thuong 60% gia tri phong: {(double)phongThue.GiaCa / 5 * 3}";
        }
    }
}