﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class NguoiChuNha : Nguoi
    {
        private List<PhongTro> phongTro;
        public List<PhongTro> PhongTro
        {
            get { return phongTro; }
            set { phongTro = value; }
        }
        public NguoiChuNha(string hoTen, int tuoi, int cmnd, string gioiTinh, string ngheNghiep, int soDienThoai) : base(hoTen, tuoi, cmnd, soDienThoai, gioiTinh, ngheNghiep)
        {
        }
        public void ThemPhong(PhongTro phongTro)
        {
            PhongTro.Add(phongTro);
        }
        public void InDanhSachPhong()
        {
            foreach (PhongTro phong in phongTro)
            {

            }
        }
    }
}