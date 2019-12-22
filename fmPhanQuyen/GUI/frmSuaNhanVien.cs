using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using fmPhanQuyen.DTO;
using fmPhanQuyen.DAO;
using fmPhanQuyen.BUS;

namespace fmPhanQuyen.GUI
{
    public partial class frmSuaNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaNhanVien()
        {
            InitializeComponent();
        }

        public frmSuaNhanVien(NhanVien kq)
        {
            InitializeComponent();
            LoadComboBoPhan();
            txtMa.Text = kq.Ma;
            txtTen.Text = kq.Ten;
            txtDiaChi.Text = kq.DiaChi;
            txtDienThoai.Text = kq.DienThoai;
            txtDiDong.Text = kq.DiDong;
            txtEmail.Text = kq.Email;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien kq = ChuyenSangDTO();
            XL_NHANVIEN.SuaNhanVien(kq);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        NhanVien ChuyenSangDTO()
        {
            NhanVien kq = new NhanVien();
            kq.Ma = txtMa.Text;
            kq.Ten = txtTen.Text;
            kq.DiaChi = txtDiaChi.Text;
            kq.DienThoai = txtDienThoai.Text;
            kq.DiDong = txtDiDong.Text;
            kq.Email = txtEmail.Text;
            kq.ConQL = XL_NUTCHECK.Check(checkConQL);
            kq.MaBoPhan = cbBoPhan.GetItemText(cbBoPhan.SelectedValue);
            return kq;
        }
        public void LoadComboBoPhan()
        {
            cbBoPhan.DataSource = XL_NHANVIEN.LoadCbBoPhan();
            cbBoPhan.DisplayMember = "Ten";
            cbBoPhan.ValueMember = "Ma";
        }
    }
}