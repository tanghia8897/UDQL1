using fmPhanQuyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DAO
{
    public class XL_NHACUNGCAP
    {
        public static DataTable LoadNhaCungCap()
        {
            string sql = "select ncc.MaSo,ncc.TenNhaCungCap,ncc.NguoiLienHe,ncc.ChucVu,ncc.DiaChi,ncc.DienThoai,ncc.DiDong,ncc.Fax,ncc.ConQuanLy,kv.Ten from NhaCungCap ncc,KhuVuc kv where ncc.MaKhuVuc = kv.Ma";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static void ThemNhaCungCap(NhaCungCap kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemNhaCungCap",
                new SqlParameter { ParameterName = "@ma", Value = kq.MaNCC },
                new SqlParameter { ParameterName = "@ten", Value = kq.TenNCC },
                new SqlParameter { ParameterName = "@nguoilienhe", Value = kq.NguoiLienHe },
                new SqlParameter { ParameterName = "@chucvu", Value = kq.ChucVu },
                new SqlParameter { ParameterName = "@diachi", Value = kq.DiaChi },
                new SqlParameter { ParameterName = "@DienThoai", Value = kq.DienThoai },
                new SqlParameter { ParameterName = "@DiDong", Value = kq.DiDong },
                new SqlParameter { ParameterName = "@fax", Value = kq.Fax },
                new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL },
                new SqlParameter { ParameterName = "@makhuvuc", Value = kq.MaKhuVuc });
        }

        public static void XoaNhaCungCap(string MaNCC)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaNhaCungCap",
                 new SqlParameter { ParameterName = "@ma", Value = MaNCC });
        }

        public static void SuaNhaCungCap(NhaCungCap kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "SuaNhaCungCap",
                new SqlParameter { ParameterName = "@ma", Value = kq.MaNCC },
                new SqlParameter { ParameterName = "@ten", Value = kq.TenNCC },
                new SqlParameter { ParameterName = "@nguoilienhe", Value = kq.NguoiLienHe },
                new SqlParameter { ParameterName = "@chucvu", Value = kq.ChucVu },
                new SqlParameter { ParameterName = "@diachi", Value = kq.DiaChi },
                new SqlParameter { ParameterName = "@DienThoai", Value = kq.DienThoai },
                new SqlParameter { ParameterName = "@DiDong", Value = kq.DiDong },
                new SqlParameter { ParameterName = "@fax", Value = kq.Fax },
                new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL },
                new SqlParameter { ParameterName = "@makhuvuc", Value = kq.MaKhuVuc });
        }
    }
}
