using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CacFormChiTiet
{
    public partial class ChiTietHoaDonForm : Form
    {
        List<ChiTietHoaDon> listChiTietHoaDon;
        HoaDon hoaDon;
        ChiTietHoaDonBUS chiTietHoaDonBUS;
        HoaDonBUS hoaDonBUS;

        public ChiTietHoaDonForm(string maHoaDon)
        {
            InitializeComponent();
            CenterToParent();

            hoaDonBUS = new HoaDonBUS();
            chiTietHoaDonBUS = new ChiTietHoaDonBUS();
            hoaDon = hoaDonBUS.LayHoaDonTheoMa(maHoaDon);
            listChiTietHoaDon = chiTietHoaDonBUS.LayDanhSachChiTietHoaDon(maHoaDon);
        }

        private void ChiTietHoaDonForm_Load(object sender, EventArgs e)
        {
            maHoaDonTextBox.Text = hoaDon.maHoaDon;
            maNhanVienTextBox.Text = hoaDon.maNhanVien;
            maKhachHangTextBox.Text = hoaDon.maKhachHang;
            maKhuyenMaiTextBox.Text = hoaDon.maKhuyenMai;
            thoiGianTaoDateTimePicker.Value = hoaDon.thoiGianTao;
            tongTienTextBox.Text = hoaDon.tongTien.ToString("#,##0") + " VNĐ";
            giamGiaTextBox.Text = hoaDon.giamGia.ToString("#,##0") + " VNĐ";
            thanhTienTextBox.Text = hoaDon.thanhTien.ToString("#,##0") + " VNĐ";
            tienNhanTextBox.Text = hoaDon.tienNhan.ToString("#,##0") + " VNĐ";
            tienThuaTextBox.Text = hoaDon.tienThua.ToString("#,##0") + " VNĐ";

            maHoaDonTextBox.ReadOnly = true;
            maNhanVienTextBox.ReadOnly = true;
            maKhachHangTextBox.ReadOnly = true;
            maKhuyenMaiTextBox.ReadOnly = true;
            thoiGianTaoDateTimePicker.Enabled = false;
            tongTienTextBox.ReadOnly = true;
            giamGiaTextBox.ReadOnly = true;
            thanhTienTextBox.ReadOnly = true;
            tienNhanTextBox.ReadOnly = true;
            tienThuaTextBox.ReadOnly = true;

            LoadDataToDataGridView(listChiTietHoaDon);
        }

        private void LoadDataToDataGridView(List<ChiTietHoaDon> listChiTietHoaDon)
        {
            chiTietHoaDonDataGridView.Rows.Clear();

            for (int i = 0; i < listChiTietHoaDon.Count; i++)
            {
                chiTietHoaDonDataGridView.Rows.Add(1);
                chiTietHoaDonDataGridView.Rows[i].Cells[0].Value = listChiTietHoaDon[i].maHoaDon;
                chiTietHoaDonDataGridView.Rows[i].Cells[1].Value = listChiTietHoaDon[i].maSanPham;
                chiTietHoaDonDataGridView.Rows[i].Cells[2].Value = listChiTietHoaDon[i].soLuong;
                chiTietHoaDonDataGridView.Rows[i].Cells[3].Value = listChiTietHoaDon[i].donVi;
                chiTietHoaDonDataGridView.Rows[i].Cells[4].Value = listChiTietHoaDon[i].donGia.ToString("#,##0") + " VNĐ";
                chiTietHoaDonDataGridView.Rows[i].Cells[5].Value = listChiTietHoaDon[i].tongTien.ToString("#,##0") + " VNĐ";
            }
        }

        private void phanQuyenDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 0; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < chiTietHoaDonDataGridView.Columns.Count - numberOfColumnsToSkip)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Đặt màu cho đường kẻ giữa các cột (nếu không thuộc vào cột cuối cùng)
                using (Pen pen = new Pen(Color.FromArgb(242, 245, 250), 5))
                {
                    int x = e.CellBounds.Right - 1;
                    int y1 = e.CellBounds.Top;
                    int y2 = e.CellBounds.Bottom;
                    e.Graphics.DrawLine(pen, x, y1, x, y2);
                }

                e.Handled = true;
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
