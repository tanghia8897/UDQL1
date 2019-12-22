using DevExpress.XtraEditors;
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
    public partial class fmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public fmHangHoa()
        {
            InitializeComponent();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmThemHangHoa frm = new fmThemHangHoa();
            frm.ShowDialog();
            LoadDuLieu();
        }

        private void fmHangHoa_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            gridHangHoa.DataSource = XL_HANGHOA.LoadHangHoa();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu đang chọn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gridView1.FocusedRowHandle;
                object value = gridView1.GetRowCellValue(row_index, "MaHang");
                if (value != null)
                {
                    //xóa
                    XL_HANGHOA.XoaHangHoa(value.ToString());
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else
                    XtraMessageBox.Show("Bạn chưa chọn đối tượng xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HangHoa hh = TruyenDuLieu();
            frmSuaHangHoa frm = new frmSuaHangHoa(hh);
            frm.ShowDialog();
            LoadDuLieu();
        }

        private HangHoa TruyenDuLieu()
        {
            HangHoa kq = new HangHoa();
            int row_index = gridView1.FocusedRowHandle;
            object Ma = gridView1.GetRowCellValue(row_index, "MaHang");
            object Ten = gridView1.GetRowCellValue(row_index, "TenHang");
            object GiaMua = gridView1.GetRowCellValue(row_index, "GiaMua");
            object GiaBanSi = gridView1.GetRowCellValue(row_index, "GiaBanSi");
            object GiaBanLe = gridView1.GetRowCellValue(row_index, "GiaBanLe");
            object TinhChat = gridView1.GetRowCellValue(row_index, "TinhChat");
            object MaVach = gridView1.GetRowCellValue(row_index, "MaVach");
            object MaNhomHang = gridView1.GetRowCellValue(row_index, "MaNhomHang");
            object MaKhoHang = gridView1.GetRowCellValue(row_index, "MaKhoHang");
            object MaDonViTinh = gridView1.GetRowCellValue(row_index, "MaDonViTinh");
            object SoLuong = gridView1.GetRowCellValue(row_index, "SoLuong");
            object SoLuongTon = gridView1.GetRowCellValue(row_index, "SoLuongTon");
            object TonKhoToiThieu = gridView1.GetRowCellValue(row_index, "TonKhoToiThieu");
            object MaNhaCungCap = gridView1.GetRowCellValue(row_index, "MaNhaCungCap");
            kq.MaHang = Ma.ToString();
            kq.TenHang = Ten.ToString();
            kq.GiaMua = float.Parse(GiaMua.ToString());
            kq.GiaBanSi = float.Parse(GiaBanSi.ToString());
            kq.GiaBanLe = float.Parse(GiaBanLe.ToString());
            kq.TinhChat = TinhChat.ToString();
            kq.MaVach = MaVach.ToString();
            kq.MaNhomHang = MaNhomHang.ToString();
            kq.MaKhoHang = MaKhoHang.ToString();
            kq.MaDonViTinh = MaDonViTinh.ToString();
            kq.MaNCC = MaNhaCungCap.ToString();
            return kq;
        }

       
    }

}
