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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            gridNCC.DataSource = XL_NHACUNGCAP.LoadNhaCungCap();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemNhaCungCap frm = new frmThemNhaCungCap();
            frm.ShowDialog();
            LoadDuLieu();
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
                object value = gridView1.GetRowCellValue(row_index, "MaSo");
                if (value != null)
                {
                    //xóa
                    XL_NHACUNGCAP.XoaNhaCungCap(value.ToString());
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else
                    XtraMessageBox.Show("Bạn chưa chọn đối tượng xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhaCungCap kq = TruyenDuLieu();
            frmSuaNhaCungCap frm = new frmSuaNhaCungCap(kq);
            frm.ShowDialog();
            LoadDuLieu();
        }

        private NhaCungCap TruyenDuLieu()
        {
            NhaCungCap kq = new NhaCungCap();
            int row_index = gridView1.FocusedRowHandle;
            object MaSo = gridView1.GetRowCellValue(row_index, "MaSo");
            object TenNhaCungCap = gridView1.GetRowCellValue(row_index, "TenNhaCungCap");
            object NguoiLienHe = gridView1.GetRowCellValue(row_index, "NguoiLienHe");
            object ChucVu = gridView1.GetRowCellValue(row_index, "ChucVu");
            object DiaChi = gridView1.GetRowCellValue(row_index, "DiaChi");
            object DienThoai = gridView1.GetRowCellValue(row_index, "DienThoai");
            object DiDong = gridView1.GetRowCellValue(row_index, "DiDong");
            object Fax = gridView1.GetRowCellValue(row_index, "Fax");
            object MaKhuVuc = gridView1.GetRowCellValue(row_index, "Ten");
           
            kq.MaNCC = MaSo.ToString();
            kq.TenNCC = TenNhaCungCap.ToString();
            kq.NguoiLienHe = NguoiLienHe.ToString();
            kq.DiaChi = DiaChi.ToString();
            kq.DienThoai = DienThoai.ToString();
            kq.DiDong = DiDong.ToString();
            kq.Fax = Fax.ToString();
            kq.MaKhuVuc = MaKhuVuc.ToString();
            kq.ChucVu = ChucVu.ToString();
            return kq;
        }
    }
}