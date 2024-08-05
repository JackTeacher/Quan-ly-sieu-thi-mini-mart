using BUS.OtherFunctions;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hoaDonDAO;
        public HoaDonBUS() 
        { 
            hoaDonDAO = new HoaDonDAO();
        }

        public List<HoaDon> LayDanhSachHoaDon()
        {
            return hoaDonDAO.LayDanhSachHoaDon();
        }

        public HoaDon LayHoaDonTheoMa(string maHoaDon)
        {
            return hoaDonDAO.LayHoaDonTheoMa(maHoaDon);
        }

        public List<HoaDon> LayDanhSachHoaDonTheoNgay(string ngay)
        {
            DateTime dateTime = DateTime.ParseExact(ngay, "dd/MM/yyyy", null);

            return hoaDonDAO.LayDanhSachHoaDonTheoNgay(dateTime);
        }

        public List<HoaDon> LayDanhSachHoaDonTheoKhoangThoiGian(string strNgayTruoc, string strNgaySau)
        {
            DateTime ngayTruoc = DateTime.ParseExact(strNgayTruoc, "dd/MM/yyyy", null);
            DateTime ngaySau = DateTime.ParseExact(strNgaySau, "dd/MM/yyyy", null);

            return hoaDonDAO.LayDanhSachHoaDonTheoKhoangThoiGian(ngayTruoc, ngaySau);
        }

        public int DemSoHoaDon()
        {
            return hoaDonDAO.DemSoHoaDon();
        }

        public int DemSoHoaDonTheoNgay(string ngay)
        {
            DateTime dateTime = DateTime.ParseExact(ngay, "dd/MM/yyyy", null); 
            return hoaDonDAO.DemSoHoaDonTheoNgay(dateTime);
        }

        public string ThemHoaDon(List<ChiTietHoaDon> listChiTietHoaDon, string maNhanVien, string maKhachHang, string maKhuyenMai, string tongTien, string giamGia, string thanhTien, string tienNhan, string tienThua)
        {
            if(listChiTietHoaDon.Count <= 0) { return "Đơn hàng trống!"; }
            HoaDon hoaDon = new HoaDon();

            hoaDon.maHoaDon = IDGenerator.GenerateHoaDonID();
            hoaDon.maNhanVien = maNhanVien;
            hoaDon.maKhachHang = maKhachHang;
            hoaDon.maKhuyenMai = maKhuyenMai;
            hoaDon.thoiGianTao = DateTime.Now;
            hoaDon.tongTien = Decimal.Parse(tongTien);
            hoaDon.giamGia = Decimal.Parse(giamGia);
            hoaDon.thanhTien = Decimal.Parse(thanhTien);
            hoaDon.tienNhan = Decimal.Parse(tienNhan);
            hoaDon.tienThua = Decimal.Parse(tienThua);

            if (hoaDon.tienNhan == 0 || hoaDon.tienNhan < hoaDon.thanhTien)
                return "Khách hàng chưa thanh toán đủ!";

            foreach(ChiTietHoaDon chiTietHoaDon in listChiTietHoaDon)
            {
                SanPhamBUS sanPhamBUS = new SanPhamBUS();

                sanPhamBUS.CapNhatSoLuong(chiTietHoaDon.maSanPham, -(chiTietHoaDon.soLuong));
            }

            new KhachHangBUS().TichDiem(maKhachHang, tongTien);

            if (hoaDonDAO.ThemHoaDon(hoaDon, listChiTietHoaDon))
                return "Thanh toán thành công!";
            else
                return "Thanh toán thất bại!";
        }

        public List<HoaDon> TimKiemHoaDon(string tuKhoa)
        {
            tuKhoa = tuKhoa.Trim().ToLower();

            return hoaDonDAO.TimKiemHoaDon(tuKhoa);
        }

        public List<HoaDon> LayDanhSachHoaDonTheoNhanVien(string maNhanVien)
        {
            return hoaDonDAO.LayDanhSachHoaDonTheoNhanVien(maNhanVien);
        }
    }
}
