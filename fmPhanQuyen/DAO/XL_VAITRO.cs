using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fmPhanQuyen.DTO;

namespace fmPhanQuyen.DAO
{
    public class XL_VAITRO
    {
        public static void ThemVaiTro(VaiTro vt)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemVaiTro",
               new SqlParameter { ParameterName = "@mavt", Value = vt.MaVaiTro },
               new SqlParameter { ParameterName = "@tenvt", Value = vt.TenVaiTro },
               new SqlParameter { ParameterName = "@diengiai", Value = vt.DienGiai },
               new SqlParameter { ParameterName = "@kichhoat", Value = vt.KichHoat });
        }
    }
}
