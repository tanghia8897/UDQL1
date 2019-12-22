using fmPhanQuyen.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmPhanQuyen.GUI
{
    public partial class fmBanHang : Form
    {
        public fmBanHang()
        {
            InitializeComponent();  
        }
        private void fmBanHang_Load(object sender, EventArgs e)
        {
            LoadComboMaKH();
            LoadComboTenKH();
            LoadComboNhanVien();
            LoadComboTenKhoHang();
        }

        public void LoadComboMaKH()
        {
            cbMaKH.DataSource = XL_KHACHHANG.LoadMaKhachHang();
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "TenKH";
        }

        public void LoadComboTenKH()
        {
            cbKhachHang.DataSource = XL_KHACHHANG.LoadMaKhachHang();
            cbKhachHang.DisplayMember = "TenKH";
            cbKhachHang.ValueMember = "MaKH";
        }

        public void LoadComboTenKhoHang()
        {
            cbKho.DataSource = XL_HANGHOA.LoadKhoHang();
            cbKho.DisplayMember = "Ten";
            cbKho.ValueMember = "Ma";
        }

        public void LoadComboNhanVien()
        {
            cbNhanVien.DataSource = XL_NHANVIEN.LoadNhanVien();
            cbNhanVien.DisplayMember = "Ten";
            cbNhanVien.ValueMember = "Ma";
        }


        private void btnIn_Click(object sender, EventArgs e)
        {
            frmInPhieuBH frm = new frmInPhieuBH();
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            fmThemHangHoa frm = new fmThemHangHoa();
            frm.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            frm.ShowDialog();
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            frmThemKhoHang frm = new frmThemKhoHang();
            frm.ShowDialog();
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaKH.Text = cbKhachHang.GetItemText(cbKhachHang.SelectedValue);
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKhachHang.Text = cbMaKH.GetItemText(cbMaKH.SelectedValue);
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            frm.ShowDialog();
        }

    }
}
