using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DTO
{
    public class NhanVien
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string DiDong { get; set; }
        public string Email { get; set; }
        public bool ConQL { get; set; }
        public string MaBoPhan { get; set; }
    }
}
