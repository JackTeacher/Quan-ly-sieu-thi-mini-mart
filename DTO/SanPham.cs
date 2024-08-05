using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public SanPham()
        {
            maSanPham = string.Empty;
            maLoaiSanPham = string.Empty;
            tenSanPham = string.Empty;
            donVi = string.Empty;
            soLuong = 0;
            giaBan = 0;
            duLieuAnh = Array.Empty<Byte>();
            trangThai = "Chờ xử lý";
        }

        public SanPham(string maSanPham, string maLoaiSanPham, string tenSanPham, string donVi, decimal giaBan, byte[] duLieuAnh, string trangThai)
        {
            this.maSanPham = maSanPham;
            this.maLoaiSanPham = maLoaiSanPham;
            this.tenSanPham = tenSanPham;
            this.donVi = donVi;
            soLuong = 0;
            this.giaBan = giaBan;
            this.duLieuAnh = duLieuAnh;
            this.trangThai = trangThai;
        }

        public string maSanPham { get; set; }
        public string maLoaiSanPham { get; set; }
        public string tenSanPham { get; set; }
        public string donVi { get; set; }
        public int soLuong { get; set; }
        public decimal giaBan { get; set; }
        public byte[] duLieuAnh { get; set; }
        public string trangThai { get; set; }
    }
}
