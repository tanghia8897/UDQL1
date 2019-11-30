using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmPhanQuyen.DTO
{
    public class VaiTroChucNang
    {
        public int MaVaiTro { get; set; }
        public int MaChucNang { get; set; }
        public bool TatCa { get; set; }
        public bool TruyCap { get; set; }
        public bool Them { get; set; }
        public bool Xoa { get; set; }
        public bool Sua { get; set; }
        public bool InAn { get; set; }
        public bool Nhap { get; set; }
        public bool Xuat { get; set; }
        public string TenTrongHeThong { get; set; }
    }
}
