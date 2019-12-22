using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fmPhanQuyen.DTO;
using System.Collections;
using DevExpress.XtraEditors;



namespace fmPhanQuyen.GUI
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.Hide();
            AnRibbonControl();
            frmDangNhap frm = new frmDangNhap();
            frm.KhiDangNhapThanhCong += Test;
            frm.ShowDialog();
            this.Show();
        }

        //thoát chương trình
        private void btnKetThuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void rbBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmBanHang frm = new fmBanHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmHangHoa frm = new fmHangHoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmThongTin frm = new fmThongTin();
            frm.ShowDialog();
        }


        //khi load lên là ẩn đi các ribbon, ribbonpage, baritemlink
        private void AnRibbonControl()
        {
            ArrayList visiblePages = ribbonControl1.TotalPageCategory.GetVisiblePages();
            foreach (RibbonPage page in visiblePages)
            {
                foreach (RibbonPageGroup group in page.Groups)
                {
                    foreach(BarItemLink link in group.ItemLinks)
                    {
                        link.Visible = false;
                    }
                    group.Visible = false;
                }              
                 page.Visible = false;            
            }             
        }

        private void Test(List<VaiTroChucNang> data)
        {
            foreach (VaiTroChucNang item in data)
            {
                foreach (RibbonPage page in ribbonControl1.Pages)//vòng ngoài, ribbonpage
                {
                    if (page.Name == item.TenTrongHeThong || page.Visible == true)
                    {
                        page.Visible = true;
                        foreach (RibbonPageGroup group in page.Groups)
                        {
                            if (group.Name == item.TenTrongHeThong || group.Visible == true)
                            {
                                group.Visible = true;
                                foreach (BarItemLink link in group.ItemLinks)
                                {
                                    if (link.Item.Name == item.TenTrongHeThong)
                                    {
                                        link.Visible = true;
                                        break;
                                    }
                                }//end BarItemLink
                            }//end if
                        }//end RibbonPageGroup
                    }//end if
                }//end RibbonPage
            }// end VaiTroChucNang
        }

        private void rbPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhanQuyen frm = new frmPhanQuyen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void rbNhatKyHeThong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhatKyHeThong frm = new frmNhatKyHeThong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhoHang frm = new frmKhoHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhuVuc frm = new frmKhuVuc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDonViTinh frm = new frmDonViTinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbNhomHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhomHang frm = new frmNhomHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbTyGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTyGia frm = new frmTyGia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBoPhan frm = new frmBoPhan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTonKho frm = new frmTonKho();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbChuyenKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChuyenKho frm = new frmChuyenKho();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbThuTien_ItemClick(object sender, ItemClickEventArgs e)   
        {
            frmThuTien frm = new frmThuTien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbTraTien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTraTien frm = new frmTraTien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbBaoCaoKhoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCaoKhoHang frm = new frmBaoCaoKhoHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbBaoCaoBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCaoBanHang frm = new frmBaoCaoBanHang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rbLienHe_ItemClick(object sender, ItemClickEventArgs e)
        {
            fmThongTin frm = new fmThongTin();
            frm.ShowDialog();
        }

        private void rbDangKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
        }

        private void rbTroGiup_ThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTroGiup_ThongTin frm = new frmTroGiup_ThongTin();
            frm.ShowDialog();
        }

        private void rbCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCapNhat frm = new frmCapNhat();
            frm.ShowDialog();
        }

        private void rbHuongDanSuDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Chức năng này chưa hỗ trợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rbHoTroTrucTuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Nhắn tin với chúng tôi để được hỗ trợ!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/groups/15ck3hcmus/");
            }
        }

        

    }
}
