using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiangVien
{
    public class GiangVien
    {
        public string MaSo {  get; set; }
        public string HoTen {  get; set; }
        public DateTime NgaySinh { get; set; }
        public DanhMucHocPhan dsHocPhan;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string SoDT;
        public string Mail;
        public GiangVien()
        {
            dsHocPhan=new DanhMucHocPhan();
            NgoaiNgu = new string[20];
        }
        public GiangVien(string maso, string sdt,string mail,string hoten,
            DateTime ngaysinh, DanhMucHocPhan ds,string gt, string[] nn)
        {
            this.MaSo = maso;
            this.SoDT = sdt;
            this.Mail = mail;
            this.HoTen = hoten;
            this.NgoaiNgu = nn;
            this.NgaySinh = ngaysinh;
            this.dsHocPhan = ds;
            this.GioiTinh = gt;
        }
        public override string ToString()
        {
            string s = "Mã số: " + MaSo + "\n"
                + "Họ tên: " + HoTen + "\n"
                + "Ngày sinh: " + NgaySinh + "\n"
                + "Giới tính: " + GioiTinh + "\n"
                + "Số ĐT: " + SoDT + "\n"
                + "Mail: " + Mail + "\n";
            string sngoaingu = "Ngoại ngữ";
            foreach (string t in NgoaiNgu)
                sngoaingu+= t+";";
            string monDay = "Danh sách môn dạy: ";
            foreach (HocPhan hp in dsHocPhan.ds)
                monDay += hp + ";";
            s += "\n" + sngoaingu + "\n" + monDay;
            return s;
        }
        
    }
}
