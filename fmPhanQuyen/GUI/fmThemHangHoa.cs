using DevExpress.XtraEditors;
using fmPhanQuyen.BUS;
using fmPhanQuyen.DAO;
using fmPhanQuyen.DTO;
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
    public partial class fmThemHangHoa : Form
    {
        public fmThemHangHoa()
        {
            InitializeComponent();
            LoadComboLoaiHang();
            LoadComboKhoHang();
            LoadComboDonVi();
            LoadComboNhaCungCap();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HangHoa hh = ChuyenSangDTO();
            XL_HANGHOA.ThemHangHoa(hh);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadComboLoaiHang()
        {
            cbLoaiHangHoa.DataSource = XL_HANGHOA.LoadTenNhomHang();
            cbLoaiHangHoa.DisplayMember = "Ten";
            cbLoaiHangHoa.ValueMember = "Ma";
        }


        public void LoadComboKhoHang()
        {
            cbKhoMacDinh.DataSource = XL_HANGHOA.LoadKhoHang();
            cbKhoMacDinh.DisplayMember = "Ten";
            cbKhoMacDinh.ValueMember = "Ma";
        }


        public void LoadComboDonVi()
        {
            cbDonVi.DataSource = XL_HANGHOA.LoadDonVi();
            cbDonVi.DisplayMember = "Ten";
            cbDonVi.ValueMember = "Ma";
        }

        

        public void LoadComboNhaCungCap()
        {
            cbNCC.DataSource = XL_HANGHOA.LoadNhaCungCap();
            cbNCC.DisplayMember = "TenNhaCungCap";
            cbNCC.ValueMember = "MaSo";
        }

        
        HangHoa ChuyenSangDTO()
        {
            HangHoa kq = new HangHoa();
            kq.MaHang = txtMaHang.Text;
            kq.TinhChat = cbTinhChat.GetItemText(cbTinhChat.SelectedItem);
            kq.MaKhoHang = cbKhoMacDinh.GetItemText(cbKhoMacDinh.SelectedValue);
            kq.MaNhomHang = cbLoaiHangHoa.GetItemText(cbLoaiHangHoa.SelectedValue);
            kq.MaVach = txtMaVach.Text;
            kq.TenHang = txtTenHang.Text;
            kq.MaDonViTinh = cbDonVi.GetItemText(cbDonVi.SelectedValue);
            kq.TonKhoToiThieu = int.Parse(cbTonKhoToiThieu.Text);
            kq.SoLuongTon = int.Parse(cbTonHienTai.Text);
            kq.MaNCC = cbNCC.GetItemText(cbNCC.SelectedValue);
            kq.GiaMua = float.Parse(txtGiaMua.Text);
            kq.GiaBanSi = float.Parse(txtGiaBanSi.Text);
            kq.GiaBanLe = float.Parse(txtGiaBanLe.Text);
            kq.ConQuanLi = XL_NUTCHECK.Check(checkConQL);
            kq.SoLuong = int.Parse(txtSoLuong.Text);
            return kq;
        }

    }
}
