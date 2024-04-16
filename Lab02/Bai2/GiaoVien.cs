using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai2
{
    class GiaoVien
    {
        private string Name;

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        private bool GioiTinh;

        public bool GioiTinh1
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        private int dem=0;
        public int Dem1
        {
            get { return dem; }
            set { dem = value; }
        }
        public GiaoVien() { }
        public GiaoVien(string Name,bool GioiTinh)
        {
            this.Name = Name;
            this.GioiTinh = GioiTinh;
        }
    }
}
