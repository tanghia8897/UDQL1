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
    public class XL_NHANVIEN
    {

        public static DataTable LoadNhanVien()
        {
            string sql = "select Ma,Ten from NhanVien";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static DataTable LoadCbBoPhan()
        {
            string sql = "select Ma, Ten from BoPhan";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static DataTable LayDuLieuNhanVien()
        {
            string sql ="select nv.Ma,nv.Ten,nv.DiaChi,nv.DienThoai,nv.DiDong,nv.Email,nv.ConQuanLy,bp.Ten as TenBoPhan from NhanVien nv left join BoPhan bp on nv.MaBoPhan=bp.Ma";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static void ThemNhanVien(NhanVien kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemNhanVien",
                 new SqlParameter { ParameterName = "@ma", Value = kq.Ma },
                 new SqlParameter { ParameterName = "@ten", Value = kq.Ten },
                 new SqlParameter { ParameterName = "@diachi", Value = kq.DiaChi },
                 new SqlParameter { ParameterName = "@dienthoai", Value = kq.DienThoai },
                 new SqlParameter { ParameterName = "@DiDong", Value = kq.DiDong },
                 new SqlParameter { ParameterName = "@email", Value = kq.Email },
                 new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL },
                 new SqlParameter { ParameterName = "@mabophan", Value = kq.MaBoPhan });
        }

        public static void XoaNhanVien(string Ma)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaNhanVien",
                 new SqlParameter { ParameterName = "@ma", Value = Ma });
        }

        public static void SuaNhanVien(NhanVien kq)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "SuaNhanVien",
                 new SqlParameter { ParameterName = "@ma", Value = kq.Ma },
                 new SqlParameter { ParameterName = "@ten", Value = kq.Ten },
                 new SqlParameter { ParameterName = "@diachi", Value = kq.DiaChi },
                 new SqlParameter { ParameterName = "@dienthoai", Value = kq.DienThoai },
                 new SqlParameter { ParameterName = "@DiDong", Value = kq.DiDong },
                 new SqlParameter { ParameterName = "@email", Value = kq.Email },
                 new SqlParameter { ParameterName = "@conquanly", Value = kq.ConQL },
                 new SqlParameter { ParameterName = "@mabophan", Value = kq.MaBoPhan });
        }
    }
}
