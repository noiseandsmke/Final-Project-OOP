using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOOP
{
    class CongTyMoGioi
    {
        private string diaChi;
        private int maSoThue;
        private string tenCongTy;
        public int MaSoThue
        {
            get { return maSoThue; }
            set { maSoThue = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string TenCongTy
        {
            get { return tenCongTy; }
            set { tenCongTy = value; }
        }
        public CongTyMoGioi(string tenCongTy, string diaChi, int maSoThue)
        {
            this.diaChi = tenCongTy;
            this.tenCongTy = diaChi;
            this.maSoThue = maSoThue;
        }
    }
}