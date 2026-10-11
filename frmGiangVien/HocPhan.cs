using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiangVien
{
    public class HocPhan
    {
        public int ID { get; set; }
        public string TenHP { get; set; }
        public int SoTC { get; set; }
        public HocPhan(int id, string ten, int tc)
        {
            this.ID = id;
            this.TenHP = ten;
            this.SoTC = tc;
        }
        public HocPhan(string ten)
        {
            this.TenHP = ten;
        }
        public override string ToString()
        {
            return TenHP;
        }
    }
}
