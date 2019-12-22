using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DAO
{
    public class XL_KHOHANG
    {
        public static DataTable LayDuLieuKhoHang()
        {
            string sql = "select k.Ma,k.Ten,k.LienHe,k.DiaChi,k.DienThoai,k.ConQuanLy,nv.Ten as TenNV,k.Fax,k.Email,k.KyHieu,k.GhiChu from KhoHang k left join NhanVien nv on k.MaNguoiQuanLy=nv.Ma";
            return XL_DULIEU.LayDuLieu(sql);
        }
        public static void XoaKhoHang(string Ma)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaKhoHang",
                 new SqlParameter { ParameterName = "@ma", Value = Ma });
        }
    }
}
