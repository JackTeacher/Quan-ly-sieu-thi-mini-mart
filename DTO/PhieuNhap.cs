using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        public PhieuNhap()
        {
            maPhieuNhap = string.Empty;
            maNhaCungCap = string.Empty;
            maNguoiTao = string.Empty;
            thoiGianTao = DateTime.MinValue;
            thanhTien = 0;
            trangThai = "Chưa duyệt";
        }

        public PhieuNhap(string maPhieuNhap, string maNhaCungCap, string maNguoiTao, string? maNguoiDuyet, DateTime thoiGianTao, DateTime? thoiGianDuyet, decimal thanhTien, string trangThai)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.maNhaCungCap = maNhaCungCap;
            this.maNguoiTao = maNguoiTao;
            this.maNguoiDuyet = maNguoiDuyet;
            this.thoiGianTao = thoiGianTao;
            this.thoiGianDuyet = thoiGianDuyet;
            this.thanhTien = thanhTien;
            this.trangThai = trangThai;
        }

        public string maPhieuNhap { get; set; }
        public string maNhaCungCap { get; set; }
        public string maNguoiTao { get; set; }
        public string? maNguoiDuyet { get; set; }
        public DateTime thoiGianTao { get; set; }
        public DateTime? thoiGianDuyet { get; set; }
        public decimal thanhTien { get; set; }
        public string trangThai { get; set; }
    }
}
