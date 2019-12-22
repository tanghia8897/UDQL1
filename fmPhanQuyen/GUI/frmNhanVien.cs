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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            gridNhanVien.DataSource = XL_NHANVIEN.LayDuLieuNhanVien();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
            LoadDuLieu();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu đang chọn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gridView1.FocusedRowHandle;
                object value = gridView1.GetRowCellValue(row_index, "Ma");
                if (value != null)
                {
                    //xóa
                    XL_NHANVIEN.XoaNhanVien(value.ToString());
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else
                    XtraMessageBox.Show("Bạn chưa chọn đối tượng xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhanVien nv = TruyenDuLieu();
            frmSuaNhanVien frm = new frmSuaNhanVien(nv);
            frm.ShowDialog();
            LoadDuLieu();
        }

        private NhanVien TruyenDuLieu()
        {
            NhanVien kq = new NhanVien();
            int row_index = gridView1.FocusedRowHandle;
            object Ma = gridView1.GetRowCellValue(row_index, "Ma");
            object Ten = gridView1.GetRowCellValue(row_index, "Ten");
            object DiaChi = gridView1.GetRowCellValue(row_index, "DiaChi");
            object DienThoai = gridView1.GetRowCellValue(row_index, "DienThoai");
            object DiDong = gridView1.GetRowCellValue(row_index, "DiDong");
            object Email = gridView1.GetRowCellValue(row_index, "Email");
            object TenBoPhan = gridView1.GetRowCellValue(row_index, "TenBoPhan");
            kq.Ma = Ma.ToString();
            kq.Ten = Ten.ToString();
            kq.DiaChi = DiaChi.ToString();
            kq.DienThoai = DienThoai.ToString();
            kq.DiDong = DiDong.ToString();
            kq.Email = Email.ToString();
            return kq;
        }
    }
}