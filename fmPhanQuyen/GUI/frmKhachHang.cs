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
using fmPhanQuyen.DTO;

namespace fmPhanQuyen.GUI
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            gridKhachHang.DataSource = XL_KHACHHANG.LayDuLieuKhachHang();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemKhachHang frm = new frmThemKhachHang();
            frm.ShowDialog();
            LoadKhachHang();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu đang chọn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gridView1.FocusedRowHandle;
                object value = gridView1.GetRowCellValue(row_index, "MaKH");
                if (value != null)
                {
                    //xóa
                    XL_KHACHHANG.XoaKhachHang(value.ToString());
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                }
                else
                    XtraMessageBox.Show("Bạn chưa chọn đối tượng xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhachHang kq = TruyenDuLieu();
            frmSuaKhachHang frm = new frmSuaKhachHang(kq);
            frm.ShowDialog();
            LoadKhachHang();
        }

        private KhachHang TruyenDuLieu()
        {
            KhachHang kq = new KhachHang();
            int row_index = gridView1.FocusedRowHandle;
            object Ma = gridView1.GetRowCellValue(row_index, "MaKH");
            object Ten = gridView1.GetRowCellValue(row_index, "TenKH");
            object NguoiLienHe = gridView1.GetRowCellValue(row_index, "NguoiLienHe");
            object DiaChi = gridView1.GetRowCellValue(row_index, "DiaChi");
            object DienThoai = gridView1.GetRowCellValue(row_index, "DienThoai");
            object DiDong = gridView1.GetRowCellValue(row_index, "DiDong");
            object Fax = gridView1.GetRowCellValue(row_index, "Fax");
            object Email = gridView1.GetRowCellValue(row_index, "Email");
            object Website = gridView1.GetRowCellValue(row_index, "Website");
            object MaSoThue = gridView1.GetRowCellValue(row_index, "MaSoThue");
            object TenNganHang = gridView1.GetRowCellValue(row_index, "TenNganHang");
            object MaKhuVuc = gridView1.GetRowCellValue(row_index, "MaKhuVuc");
            object SoTaiKhoan = gridView1.GetRowCellValue(row_index, "SoTaiKhoan");
            kq.MaKH = Ma.ToString();
            kq.TenKH = Ten.ToString();
            kq.NguoiLienHe = NguoiLienHe.ToString();
            kq.DiaChi = DiaChi.ToString();
            kq.DienThoai = DienThoai.ToString();
            kq.DiDong = DiDong.ToString();
            kq.Fax = Fax.ToString();
            kq.Email = Email.ToString();
            kq.Website = Website.ToString();
            kq.MaSoThue = MaSoThue.ToString();
            kq.TenNganHang = TenNganHang.ToString();
            kq.MaKhuVuc = MaKhuVuc.ToString();
            kq.SoTaiKhoan = SoTaiKhoan.ToString();
            return kq;
        }
    }
}