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
    public partial class ChiTietPhieuNhapForm : Form
    {
        ChiTietPhieuNhapBUS chiTietPhieuNhapBUS;
        PhieuNhapBUS phieuNhapBUS;
        internal List<ChiTietPhieuNhap> listChiTietPhieuNhap;
        PhieuNhap phieuNhap;
        PhieuNhapForm phieuNhapForm;

        public ChiTietPhieuNhapForm(string maPhieuNhap, PhieuNhapForm phieuNhapForm)
        {
            InitializeComponent();
            CenterToParent();

            phieuNhapBUS = new PhieuNhapBUS();
            chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
            phieuNhap = phieuNhapBUS.LayPhieuNhapTheoMa(maPhieuNhap);
            listChiTietPhieuNhap = chiTietPhieuNhapBUS.LayDanhSachChiTietPhieuNhap(maPhieuNhap);
            this.phieuNhapForm = phieuNhapForm;
        }

        private void ChiTietPhieuNhapForm_Load(object sender, EventArgs e)
        {
            maPhieuNhapTextBox.Text = phieuNhap.maPhieuNhap;
            maNhaCungCapTextBox.Text = phieuNhap.maNhaCungCap;
            maNguoiTaoTextBox.Text = phieuNhap.maNguoiTao;
            maNguoiDuyetTextBox.Text = phieuNhap.maNguoiDuyet;
            thoiGianTaoDateTimePicker.Value = phieuNhap.thoiGianTao;
            if (phieuNhap.thoiGianDuyet.HasValue)
                thoiGianDuyetDateTimePicker.Value = (DateTime)phieuNhap.thoiGianDuyet;
            thanhTienTextBox.Text = phieuNhap.thanhTien.ToString("0") + " VNĐ";
            trangThaiTextBox.Text = phieuNhap.trangThai;
            if (phieuNhap.trangThai.Equals("Chưa duyệt"))
            {
                duyetButton.Visible = true;
                khongDuyetButton.Visible = true;
            }
            if (!phieuNhap.trangThai.Equals("Chưa duyệt"))
                chiTietPhieuNhapDataGridView.Columns[7].Visible = false;

            LoadDataToDataGridView(listChiTietPhieuNhap);
        }

        internal void LoadDataToDataGridView(List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            chiTietPhieuNhapDataGridView.Rows.Clear();

            for (int i = 0; i < listChiTietPhieuNhap.Count; i++)
            {
                chiTietPhieuNhapDataGridView.Rows.Add(1);
                chiTietPhieuNhapDataGridView.Rows[i].Cells[0].Value = listChiTietPhieuNhap[i].maSanPham;
                chiTietPhieuNhapDataGridView.Rows[i].Cells[1].Value = listChiTietPhieuNhap[i].tenSanPham;
                chiTietPhieuNhapDataGridView.Rows[i].Cells[2].Value = listChiTietPhieuNhap[i].donVi;
                chiTietPhieuNhapDataGridView.Rows[i].Cells[3].Value = listChiTietPhieuNhap[i].soLuong;
                chiTietPhieuNhapDataGridView.Rows[i].Cells[4].Value = listChiTietPhieuNhap[i].giaBan.ToString("#,##0") + " VNĐ";
                chiTietPhieuNhapDataGridView.Rows[i].Cells[5].Value = listChiTietPhieuNhap[i].giaNhap.ToString("#,##0") + " VNĐ";
                chiTietPhieuNhapDataGridView.Rows[i].Cells[6].Value = listChiTietPhieuNhap[i].tongTien.ToString("#,##0") + " VNĐ";
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chiTietPhieuNhapDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 0; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < chiTietPhieuNhapDataGridView.Columns.Count - numberOfColumnsToSkip)
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

        private void duyetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn duyệt phiếu nhập này không?");

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(phieuNhapBUS.DuyetPhieuNhap(phieuNhap.maPhieuNhap, DangNhapForm.nguoiDung.maNguoiDung));
                phieuNhapForm.lamMoiButton_Click(sender, e);
                this.Close();
            }


            this.Close();
        }

        private void khongDuyetButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn từ chối duyệt phiếu nhập đã chọn không?");

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(phieuNhapBUS.TuChoiPhieuNhap(phieuNhap.maPhieuNhap));
                phieuNhapForm.lamMoiButton_Click(sender, e);
                this.Close();
            }
        }

        private void chiTietPhieuNhapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = chiTietPhieuNhapBUS.LayChiTietPhieuNhap(phieuNhap.maPhieuNhap, chiTietPhieuNhapDataGridView["maSanPhamColumn", e.RowIndex].Value.ToString());

                string columnName = chiTietPhieuNhapDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("suaButtonColumn"))
                {
                    new SuaChiTietPhieuNhapForm(chiTietPhieuNhap, this).ShowDialog();
                }
            }
        }
    }
}
