using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class NguoiMoGioi : Nguoi
    {
        public NguoiMoGioi(string hoTen, int tuoi, int cmnd, string gioiTinh, string ngheNghiep, int soDienThoai) : base(hoTen, tuoi, cmnd, soDienThoai, gioiTinh, ngheNghiep)
        {
            
        }
    }
}