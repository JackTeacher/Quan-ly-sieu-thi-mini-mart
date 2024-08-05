using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        public ChiTietPhieuNhap()
        {
            maPhieuNhap = string.Empty;
            maSanPham = string.Empty;
            tenSanPham = string.Empty;
            donVi = string.Empty;
            soLuong = 0;
            giaBan = 0;
            giaNhap = 0;
            tongTien = 0;
        }

        public ChiTietPhieuNhap(string maPhieuNhap, string maSanPham, string tenSanPham, string donVi, int soLuong, decimal giaBan, decimal giaNhap, decimal tongTien)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.donVi = donVi;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
            this.giaNhap = giaNhap;
            this.tongTien = tongTien;
        }

        public string maPhieuNhap { get; set; }
        public string maSanPham { get; set; }
        public string tenSanPham { get; set; }
        public string donVi { get; set; }
        public int soLuong { get; set; }
        public decimal giaBan { get; set; }
        public decimal giaNhap { get; set; }
        public decimal tongTien { get; set; }
    }
}
