using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class HopDong
    {
        private double tienCoc;
        private PhongTro phongThue;
        private NguoiChuNha benChoThue;
        private NguoiThue benThue;
        private DateTime ngayKy;
        private DateTime ngayHetHan;
        private Nguoi kyVoi;

        public Nguoi KyVoi
        {
            get { return kyVoi; }
            set { kyVoi = value; }
        }

        public DateTime NgayKy
        {
            get { return ngayKy; ; }
            set { ngayKy = value; }
        }
        public DateTime HanHopDong
        {
            get { return ngayHetHan; }
            set { ngayHetHan = value; }
        }
        public NguoiThue BenThue
        {
            get { return benThue; }
            set { benThue = value; }
        }
        public NguoiChuNha BenChoThue
        {
            get { return benChoThue; }
            set { benChoThue = value; }
        }
        public PhongTro PhongThue
        {
            get { return phongThue; }
            set { phongThue = value; }
        }
        public double TienCoc
        {
            get { return tienCoc; }
            set { tienCoc = value; }
        }
        public HopDong(int tienCoc, PhongTro phongThue, NguoiChuNha benChoThue, NguoiThue benThue, DateTime ngayKy, DateTime ngayHetHan)
        {
            this.tienCoc = tienCoc;
            this.phongThue = phongThue;
            this.benChoThue = benChoThue;
            this.benThue = benThue;
            this.ngayKy = ngayKy;
            this.ngayHetHan = ngayHetHan;
        }
        public void ThongTinHopDong()
        {
            Console.WriteLine("##################################");
            Console.WriteLine($">>>DA KY HOP DONG VOI {kyVoi.HoTen}");
            Console.WriteLine($"SO TIEN COC: {tienCoc}");
            Console.WriteLine($"NGAY KY: {ngayKy}");
            Console.WriteLine($"NGAY HET HAN: {ngayHetHan}");
            Console.WriteLine("##################################");
        }
    }
}