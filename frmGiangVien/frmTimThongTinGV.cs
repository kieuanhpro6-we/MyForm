using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmGiangVien
{
    public partial class frmTimThongTinGV : Form
    {
        private QuanLyGiangVien qlgv;
        public frmTimThongTinGV()
        {
            InitializeComponent();
        }
        // Constructor nhận đối tượng QuanLyGiangVien từ Form chính truyền sang
        public frmTimThongTinGV(QuanLyGiangVien ql)
        {
            InitializeComponent();
            this.qlgv = ql;
        }
        // Sự kiện Form Load
        private void frmTimThongTin_Load(object sender, EventArgs e)
        {
            label1.Text = "Mã GV";
            txtNhap.Focus();
        }
        // Sự kiện khi chọn RadioButton "Mã GV"
        private void rdMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
            {
                label1.Text = "Mã GV";
                txtNhap.Clear();
                txtNhap.Focus();
            }
        }
        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHoTen.Checked)
            {
                label1.Text = "Họ tên";
                txtNhap.Clear();
                txtNhap.Focus();
            }
        }
        private void rdSDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSDT.Checked)
            {
                label1.Text = "Số điện thoại";
                txtNhap.Clear();
                txtNhap.Focus();
            }
        }
        // So sánh theo Mã GV (không phân biệt hoa/thường)
        private int SoSanhTheoMa(object a, object b)
        {
            return string.Compare(a.ToString().Trim(), ((GiangVien)b).MaSo.Trim(), true);
        }
        // So sánh theo Họ Tên (không phân biệt hoa/thường)
        private int SoSanhTheoHoTen(object a, object b)
        {
            return string.Compare(a.ToString().Trim(), ((GiangVien)b).HoTen.Trim(), true);
        }
        // So sánh theo Số điện thoại
        private int SoSanhTheoSDT(object a, object b)
        {
            return string.Compare(a.ToString().Trim(), ((GiangVien)b).SoDT.Trim(), true);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng đã nhập thông tin tìm kiếm chưa
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.Focus();
                return;
            }
            // Nếu chưa có dữ liệu giảng viên
            if (qlgv == null || qlgv.dsGiangVien.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SoSanh ss = null;
            object thongTinTim = txtNhap.Text.Trim();
            // Xác định tiêu chí tìm kiếm theo RadioButton đang chọn
            if (rdMaGV.Checked)
            {
                ss = SoSanhTheoMa;
            }
            else if (rdHoTen.Checked)
            {
                ss = SoSanhTheoHoTen;
            }
            else if (rdSDT.Checked)
            {
                ss = SoSanhTheoSDT;
            }
            // Gọi phương thức Tim của QuanLyGiangVien
            GiangVien gvTimThay = qlgv.Tim(thongTinTim, ss);
            if (gvTimThay != null)
            {
                // Nếu tìm thấy: Hiển thị frmTBGiangVien (như ảnh 2)
                frmTBGiangVien.frmTBGiangVien frmTB = new frmTBGiangVien.frmTBGiangVien();
                frmTB.SetText(gvTimThay.ToString());
                frmTB.ShowDialog();
            }
            else
            {
                // Nếu không tìm thấy: Hiển thị thông báo (như ảnh 3)
                MessageBox.Show("Không tìm thấy thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {

        }
    }
}
