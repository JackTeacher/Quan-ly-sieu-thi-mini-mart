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
    public class PhieuNhapBUS
    {
        PhieuNhapDAO phieuNhapDAO;

        public PhieuNhapBUS()
        {
            phieuNhapDAO = new PhieuNhapDAO();
        }

        public List<PhieuNhap> LayDanhSachPhieuNhap()
        {
            return phieuNhapDAO.LayDanhSachPhieuNhap();
        }

        public int DemSoPhieuNhapTheoNgay(string strNgay)
        {
            DateTime ngay = DateTime.ParseExact(strNgay, "dd/MM/yyyy", null);
            return phieuNhapDAO.DemSoPhieuNhapTheoNgay(ngay);
        }

        public PhieuNhap LayPhieuNhapTheoMa(string maPhieuNhap)
        {
            return phieuNhapDAO.LayPhieuNhapTheoMa(maPhieuNhap);
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapChuaDuyet()
        {
            return phieuNhapDAO.LayDanhSachPhieuNhapChuaDuyet();
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapDaDuyet()
        {
            return phieuNhapDAO.LayDanhSachPhieuNhapDaDuyet();
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapDaTuChoi()
        {
            return phieuNhapDAO.LayDanhSachPhieuNhapDaTuChoi();
        }

        public string ThemPhieuNhap(List<ChiTietPhieuNhap> listChiTietPhieuNhap, string maPhieuNhap, string maNhaCungCap, string maNguoiTao, string thanhTien)
        {
            PhieuNhap phieuNhap= new PhieuNhap();

            phieuNhap.maPhieuNhap = maPhieuNhap;
            phieuNhap.maNhaCungCap = maNhaCungCap;
            phieuNhap.maNguoiTao = maNguoiTao;
            phieuNhap.thoiGianTao = DateTime.Now;
            phieuNhap.thanhTien = Decimal.Parse(thanhTien);

            foreach(ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                if (chiTietPhieuNhap.giaBan == 0 || chiTietPhieuNhap.giaNhap == 0)
                    return "Sản phẩm phải có giá nhập và giá bán lớn hơn 0, vui lòng kiểm tra lại!";
            }

            if (phieuNhapDAO.ThemPhieuNhap(phieuNhap, listChiTietPhieuNhap))
                return "Thêm phiếu nhập thành công!";
            else
                return "Thêm phiếu nhập thất bại!";
        }

        public string SuaPhieuNhapChuaDuyet(List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            if (phieuNhapDAO.SuaPhieuNhapChuaDuyet(listChiTietPhieuNhap))
                return "Sửa phiếu nhập chưa duyệt thành công!";
            else
                return "Sửa phiếu nhập chưa duyệt thất bại!";
        }

        public string DuyetPhieuNhap(string maPhieuNhap, string maNguoiDuyet)
        {
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new ChiTietPhieuNhapDAO().LayDanhSachChiTietPhieuNhap(maPhieuNhap);

            foreach (ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                SanPhamBUS sanPhamBUS = new SanPhamBUS();
                SanPham sanPham = sanPhamBUS.LaySanPhamTheoMa(chiTietPhieuNhap.maSanPham);
                sanPhamBUS.SuaSanPham(sanPham.maSanPham, sanPham.maLoaiSanPham, sanPham.tenSanPham, sanPham.donVi, chiTietPhieuNhap.giaBan.ToString("0"), sanPham.duLieuAnh, sanPham.trangThai);
                sanPhamBUS.CapNhatSoLuong(chiTietPhieuNhap.maSanPham, +(chiTietPhieuNhap.soLuong));
            }

            if (phieuNhapDAO.DuyetPhieuNhap(maPhieuNhap, maNguoiDuyet, DateTime.Now))
                return "Duyệt phiếu nhập thành công!";
            else
                return "Duyệt phiếu nhập thất bại!";
        }

        public List<PhieuNhap> TimKiemPhieuNhap(string tuKhoa, string trangThai, string thoiGianBatDau, string thoiGianKetThuc)
        {
            if (!string.IsNullOrEmpty(thoiGianBatDau) && !string.IsNullOrEmpty(thoiGianKetThuc))
            {
                DateTime dateTimeBatDau = DateTime.ParseExact(thoiGianBatDau, "dd/MM/yyyy HH:mm:ss", null);
                DateTime dateTimeKetThuc = DateTime.ParseExact(thoiGianKetThuc, "dd/MM/yyyy HH:mm:ss", null);

                if (dateTimeBatDau > dateTimeKetThuc)
                    return null;
            }

            tuKhoa = tuKhoa.Trim().ToLower();

            return phieuNhapDAO.TimKiemPhieuNhap(tuKhoa, trangThai, thoiGianBatDau, thoiGianKetThuc);
        }

        public string TuChoiPhieuNhap(string maPhieuNhap)
        {
            if (phieuNhapDAO.TuChoiDuyetPhieuNhap(maPhieuNhap))
                return "Đã từ chối duyệt phiếu nhập!";
            else
                return "Từ chối duyệt phiếu nhập thất bại!";
        }
    }
}
