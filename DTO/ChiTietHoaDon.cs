using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon()
        {
            maHoaDon = string.Empty;
            maSanPham = string.Empty;
            tenSanPham = string.Empty;
            donVi = string.Empty;
            soLuong = 0;
            donGia = 0;
            tongTien = 0;
        }

        public ChiTietHoaDon(string maHoaDon, string maSanPham, string tenSanPham, string donVi, int soLuong, decimal donGia, decimal tongTien)
        {
            this.maHoaDon = maHoaDon;
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.donVi = donVi;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.tongTien = tongTien;
        }

        public string maHoaDon { get; set; }
        public string maSanPham { get; set; }
        public string tenSanPham { get; set; }
        public string donVi {  get; set; }
        public int soLuong { get; set; }
        public decimal donGia { get; set; }
        public decimal tongTien { get; set; }
    }
}
