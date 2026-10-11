using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiangVien
{
    public enum KieuTim
    {
        TheoMa,
        TheoHoTen,
        TheoSDT
    }

    public delegate int SoSanh(object a, object b);

    public class QuanLyGiangVien
    {
        public List<GiangVien> dsGiangVien;

        public QuanLyGiangVien()
        {
            dsGiangVien = new List<GiangVien>();
        }

        public GiangVien this[int index]
        {
            get { return dsGiangVien[index]; }
            set { dsGiangVien[index] = value; }
        }

        // Thêm giảng viên: trả về true nếu thêm thành công, false nếu đã tồn tại mã số
        public bool Them(GiangVien gv)
        {
            if (gv == null) return false;
            foreach (GiangVien item in dsGiangVien)
            {
                if (item.MaSo == gv.MaSo)
                    return false;
            }
            dsGiangVien.Add(gv);
            return true;
        }

        // Method Tìm giảng viên theo tiêu chí so sánh
        public GiangVien Tim(object temp, SoSanh ss)
        {
            foreach (GiangVien gv in dsGiangVien)
            {
                try
                {
                    if (ss(temp, gv) == 0)
                        return gv;
                }
                catch
                {
                    if (ss(gv, temp) == 0)
                        return gv;
                }
            }
            return null;
        }

        public GiangVien Xoa(object temp, SoSanh ss)
        {
            GiangVien gv = Tim(temp, ss);
            if (gv != null)
            {
                dsGiangVien.Remove(gv);
            }
            return gv;
        }

        public void SapXep(SoSanh ss)
        {
            for (int i = 0; i < dsGiangVien.Count - 1; i++)
            {
                for (int j = i + 1; j < dsGiangVien.Count; j++)
                {
                    if (ss(dsGiangVien[i], dsGiangVien[j]) > 0)
                    {
                        GiangVien temp = dsGiangVien[i];
                        dsGiangVien[i] = dsGiangVien[j];
                        dsGiangVien[j] = temp;
                    }
                }
            }
        }
    }
}
