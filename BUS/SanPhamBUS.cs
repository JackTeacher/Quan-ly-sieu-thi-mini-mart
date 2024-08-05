using DAO;
using DocumentFormat.OpenXml.Vml;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamDAO sanPhamDAO;
        public SanPhamBUS()
        {
            sanPhamDAO = new SanPhamDAO();
        }

        public List<SanPham> LayDanhSachSanPham()
        {
            return sanPhamDAO.LayDanhSachSanPham();
        }

        public SanPham LaySanPhamTheoMa(string maSanPham)
        {
            return sanPhamDAO.LaySanPhamTheoMa(maSanPham);
        }

        public int DemSoSanPham()
        {
            return sanPhamDAO.DemSoSanPham();
        }

        public string ThemSanPham(string maSanPham, string maLoaiSanPham, string tenSanPham, string donVi, string giaBan, byte[]duLieuAnh)
        {
            if (string.IsNullOrEmpty(maLoaiSanPham) || string.IsNullOrEmpty(tenSanPham) || string.IsNullOrEmpty(donVi) || string.IsNullOrEmpty(giaBan) || !(duLieuAnh != null && duLieuAnh.Length > 0))
                return "Vui lòng nhập đầy đủ thông tin!";

            SanPham sanPham = new SanPham();

            sanPham.maSanPham = maSanPham;
            sanPham.maLoaiSanPham = maLoaiSanPham;
            sanPham.tenSanPham = tenSanPham.Trim();
            sanPham.donVi = donVi.Trim();
            sanPham.giaBan = Decimal.Parse(giaBan);
            sanPham.duLieuAnh = duLieuAnh;

            if (sanPhamDAO.ThemSanPham(sanPham))
                return "Thêm sản phẩm thành công!";
            else
                return "Thêm sản phẩm thất bại!";
        }

        public string XoaSanPham(string maSanPham)
        {
            if (sanPhamDAO.XoaSanPham(maSanPham))
                return "Xóa sản phẩm thành công!";

            return "Xóa sản phẩm thất bại!";
        }

        public string SuaSanPham(string maSanPham, string maLoaiSanPham, string tenSanPham, string donVi, string giaBan, byte[] duLieuAnh, string trangThai)
        {
            if (string.IsNullOrEmpty(maLoaiSanPham) || string.IsNullOrEmpty(tenSanPham) || string.IsNullOrEmpty(donVi) || string.IsNullOrEmpty(giaBan) || !(duLieuAnh != null && duLieuAnh.Length > 0))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (giaBan == "0" && trangThai.Equals("Đang bán"))
                return "Giá bán phải lớn hơn 0 VNĐ!";

            SanPham sanPham = LaySanPhamTheoMa(maSanPham);

            sanPham.maLoaiSanPham = maLoaiSanPham;
            sanPham.tenSanPham = tenSanPham.Trim();
            sanPham.donVi = donVi.Trim();
            sanPham.giaBan = Decimal.Parse(giaBan);
            sanPham.duLieuAnh = duLieuAnh;
            sanPham.trangThai = trangThai;

            if (sanPhamDAO.SuaSanPham(sanPham))
                return "Chỉnh sửa thông tin sản phẩm thành công!";
            else
                return "Chỉnh sửa thông tin sản phẩm thất bại!";
        }

        public List<SanPham> TimKiemSanPham(string tuKhoa, string maLoaiSanPham, string trangThai, string sapXep)
        {
            tuKhoa = tuKhoa.Trim().ToLower();

            return sanPhamDAO.TimKiemSanPham(tuKhoa, maLoaiSanPham, trangThai, sapXep);
        }

        public bool CapNhatSoLuong(string maSanPham, int soLuong)
        {
            return sanPhamDAO.CapNhatSoLuong(maSanPham, soLuong);
        }
    }
}
