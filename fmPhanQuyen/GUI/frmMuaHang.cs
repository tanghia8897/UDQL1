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
using fmPhanQuyen.DAO;

namespace fmPhanQuyen.GUI
{
    public partial class frmMuaHang : DevExpress.XtraEditors.XtraForm
    {
        public frmMuaHang()
        {
            InitializeComponent();
        }

        private void frmMuaHang_Load(object sender, EventArgs e)
        {
            LoadComboNhanVien();
            LoadComboTenKhoHang();
            LoadComboTenNCC();
            LoadComboMaNCC();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frm = new frmThemNhaCungCap();
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadComboMaNCC()
        {
            cbMaNCC.DataSource = XL_HANGHOA.LoadNhaCungCap();
            cbMaNCC.DisplayMember = "MaSo";
            cbMaNCC.ValueMember = "TenNhaCungCap";
        }

        public void LoadComboTenNCC()
        {
            cbNCC.DataSource = XL_HANGHOA.LoadNhaCungCap();
            cbNCC.DisplayMember = "TenNhaCungCap";
            cbNCC.ValueMember = "MaSo";
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

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaNCC.Text = cbNCC.GetItemText(cbNCC.SelectedValue);
        }

        private void cbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNCC.Text = cbMaNCC.GetItemText(cbMaNCC.SelectedValue);
        }

        
    }
}