using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMai
    {
        public KhuyenMai()
        {
            maKhuyenMai = string.Empty;
            tenKhuyenMai = string.Empty;
            thoiGianBatDau = DateTime.MinValue;
            thoiGianKetThuc  = DateTime.MinValue;
            loaiGiaTri = string.Empty;
            giaTri = 0;
        }

        public KhuyenMai(string maKhuyenMai, string tenKhuyenMai, DateTime thoiGianBatDau, DateTime thoiGianKetThuc, string loaiGiaTri, decimal giaTri)
        {
            this.maKhuyenMai = maKhuyenMai;
            this.tenKhuyenMai = tenKhuyenMai;
            this.thoiGianBatDau = thoiGianBatDau;
            this.thoiGianKetThuc = thoiGianKetThuc;
            this.loaiGiaTri = loaiGiaTri;
            this.giaTri = giaTri;
        }

        public string maKhuyenMai { get; set; }
        public string tenKhuyenMai { get; set; }
        public DateTime thoiGianBatDau { get; set; }
        public DateTime thoiGianKetThuc { get; set; }
        public string loaiGiaTri { get; set; }
        public decimal giaTri { get; set; }
    }
}
