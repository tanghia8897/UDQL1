using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DAO
{
    public class XL_QUYENHAN
    {
        public static DataTable HienThiQuyenHan()
        {
            string sql = "select cn.TenChucNang,th.TatCa,th.TruyCap,th.Them,th.Xoa,th.Sua,th.InAn,th.Nhap,th.Xuat from VAITRO_CHUCNANG th,CHUCNANG cn,NGUOIDUNG nd where cn.ID=th.MaChucNang and nd.MaVaiTro = th.MaVaiTro and nd.MaVaiTro=1";
            return XL_DULIEU.LayDuLieu(sql);
        }
    }
}
