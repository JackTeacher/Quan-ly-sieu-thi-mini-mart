using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.OtherFunctions
{
    public class InAn
    {
        string context = "";

        public InAn() { }

        public static void InHoaDon(HoaDon hoaDon)
        {
            List<ChiTietHoaDon> listChiTietHoaDon = new ChiTietHoaDonBUS().LayDanhSachChiTietHoaDon(hoaDon.maHoaDon);
        }

        public static void InPhieuNhap(PhieuNhap phieuNhap) 
        {
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new ChiTietPhieuNhapBUS().LayDanhSachChiTietPhieuNhap(phieuNhap.maPhieuNhap);
        }


    }
}
