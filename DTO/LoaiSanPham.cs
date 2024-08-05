using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        public LoaiSanPham()
        {
            maLoaiSanPham = string.Empty;
            tenLoaiSanPham = string.Empty;
            trangThai = "Đang sử dụng";
        }

        public LoaiSanPham(string maLoaiSanPham, string tenLoaiSanPham, string trangThai)
        {
            this.maLoaiSanPham = maLoaiSanPham;
            this.tenLoaiSanPham = tenLoaiSanPham;
            this.trangThai = trangThai;
        }

        public string maLoaiSanPham { get; set; }
        public string tenLoaiSanPham { get; set; }
        public string trangThai { get; set; }
    }
}
