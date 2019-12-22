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
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace fmPhanQuyen.GUI
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        public delegate void DangNhapThanhCong(List<VaiTroChucNang> data);
        public event DangNhapThanhCong KhiDangNhapThanhCong = null;
        public frmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.Properties.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int mavaitro = XL_NGUOIDUNG.LayMaVaiTroNguoiDung(txtTaiKhoan.Text, txtMatKhau.Text);
            if (mavaitro > 0)
            {
                DataTable dt = XL_VAITROCHUCNANG.LayThongTin(mavaitro);
                List<VaiTroChucNang> duLieu = ChuyenSangDTO(dt);
                //Gọi sự kiện ở đây khi đăng nhập thành công
                KhiDangNhapThanhCong(duLieu);
                this.Close();
                XtraMessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        List<VaiTroChucNang> ChuyenSangDTO(DataTable bang)
        {
            List<VaiTroChucNang> kq = new List<VaiTroChucNang>();

            foreach (DataRow dong in bang.Rows)
            {
                VaiTroChucNang duLieu = new VaiTroChucNang();
                duLieu.MaChucNang = (int)dong["MaChucNang"];
                duLieu.Them = (bool)dong["Them"];
                duLieu.Xoa = (bool)dong["Xoa"];
                duLieu.Sua = (bool)dong["Sua"];
                duLieu.TenTrongHeThong = dong["TenTrongHeThong"].ToString();
                kq.Add(duLieu);
            }
            return kq;
        }

        //hiển thị mật khẩu
        private void checkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPW.Checked)
                txtMatKhau.Properties.UseSystemPasswordChar = false;
            else
                txtMatKhau.Properties.UseSystemPasswordChar = true;
        }

    }
}