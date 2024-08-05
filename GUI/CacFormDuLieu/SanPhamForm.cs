using BUS;
using BUS.OtherFunctions;
using DTO;
using GUI.CacFormChiTiet;
using GUI.CacFormThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SanPhamForm : Form
    {
        List<SanPham> listSanPham;
        SanPhamBUS sanPhamBUS;

        public SanPhamForm()
        {
            InitializeComponent();

            sanPhamBUS = new SanPhamBUS();
            listSanPham = sanPhamBUS.LayDanhSachSanPham();

            List<LoaiSanPham> listLoaiSanPham = new LoaiSanPhamBUS().LayDanhSachLoaiSanPham();
            loaiSanPhamComboBox.DataSource = listLoaiSanPham;
            loaiSanPhamComboBox.DisplayMember = "tenLoaiSanPham";

            trangThaiComboBox.SelectedIndex = 0;
            loaiSanPhamComboBox.SelectedIndex = -1;
            sapXepComboBox.SelectedIndex = -1;
        }

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listSanPham);
        }

        private void LoadDataToDataGridView(List<SanPham> listSanPham)
        {
            sanPhamDataGridView.Rows.Clear();

            for (int i = 0; i < listSanPham.Count; i++)
            {
                sanPhamDataGridView.Rows.Add(1);
                sanPhamDataGridView.Rows[i].Cells[0].Value = i + 1;
                sanPhamDataGridView.Rows[i].Cells[1].Value = listSanPham[i].maSanPham;
                sanPhamDataGridView.Rows[i].Cells[2].Value = listSanPham[i].tenSanPham;
                sanPhamDataGridView.Rows[i].Cells[3].Value = new LoaiSanPhamBUS().LayLoaiSanPhamTheoMa(listSanPham[i].maLoaiSanPham).tenLoaiSanPham;
                sanPhamDataGridView.Rows[i].Cells[4].Value = listSanPham[i].donVi;
                sanPhamDataGridView.Rows[i].Cells[5].Value = listSanPham[i].soLuong;
                sanPhamDataGridView.Rows[i].Cells[6].Value = listSanPham[i].giaBan.ToString("#,##0") + " VNĐ";
                sanPhamDataGridView.Rows[i].Cells[7].Value = listSanPham[i].trangThai;
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;

            string trangThai = "";
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();
            string maLoaiSanPham = "";
            if (loaiSanPhamComboBox.SelectedValue != null)
            {
                LoaiSanPham loaiSanPham = loaiSanPhamComboBox.SelectedValue as LoaiSanPham;
                maLoaiSanPham = loaiSanPham.maLoaiSanPham;
            }
            string maNhaCungCap = ""; //CHỜ SỬA
            string sapXep = "";
            if (sapXepComboBox.SelectedItem != null)
                sapXep = sapXepComboBox.SelectedItem.ToString();

            listSanPham = sanPhamBUS.TimKiemSanPham(tuKhoa, maLoaiSanPham, trangThai, sapXep);

            LoadDataToDataGridView(listSanPham);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        public void lamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            trangThaiComboBox.SelectedItem = null;
            trangThaiComboBox.SelectedIndex = 0;
            loaiSanPhamComboBox.SelectedItem = null;
            loaiSanPhamComboBox.SelectedIndex = -1;
            sapXepComboBox.SelectedItem = null;
            sapXepComboBox.SelectedIndex = -1;

            listSanPham = sanPhamBUS.LayDanhSachSanPham();

            LoadDataToDataGridView(listSanPham);
        }

        private void trangThaiComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (trangThaiComboBox.SelectedItem != null)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void loaiSanPhamComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (loaiSanPhamComboBox.SelectedItem != null)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void sapXepComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sapXepComboBox.SelectedItem != null)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void xuatExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                new XuatExcel(filePath).XuatExcelSanPham(listSanPham);
                DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("File Excel đã được tạo tại: " + filePath);

            }
        }

        private void themMoiButton_Click(object sender, EventArgs e)
        {
            new ChiTietSanPhamForm("Thêm", this).ShowDialog();
        }

        private void xoaTatCaButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn xóa các sản phẩm đã chọn");

            if (result == DialogResult.Yes)
            {
                bool hoanTat = true;

                for (int i = 0; i < sanPhamDataGridView.SelectedRows.Count; i++)
                {
                    string maSanPham = sanPhamDataGridView.SelectedRows[i].Cells["maSanPhamColumn"].Value.ToString();

                    if (!sanPhamBUS.XoaSanPham(maSanPham).Equals("Xóa sản phẩm thành công!"))
                    {
                        hoanTat = false;
                        break;
                    }
                }

                if (hoanTat)
                {
                    CanhBaoForm.ShowAlertMessage("Đã xóa tất cả sản phẩm đã chọn!", CanhBaoForm.AlertType.SUCCESS);
                    lamMoiButton_Click(sender, e);
                }
                else
                    CanhBaoForm.ShowAlertMessage("Quá trình xóa xảy ra lỗi!", CanhBaoForm.AlertType.ERROR);
            }
        }

        private void sanPhamDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SanPham sanPham = sanPhamBUS.LaySanPhamTheoMa(sanPhamDataGridView.Rows[e.RowIndex].Cells["maSanPhamColumn"].Value.ToString());

            string columnName = sanPhamDataGridView.Columns[e.ColumnIndex].Name;

            if (columnName.Equals("infoButtonColumn"))
            {
                new ChiTietSanPhamForm(sanPham, "Chi tiết", this).ShowDialog();
            }

            if (columnName.Equals("editButtonColumn"))
            {
                new ChiTietSanPhamForm(sanPham, "Sửa", this).ShowDialog();
            }

            if (columnName.Equals("deleteButtonColumn"))
            {
                DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn xóa sản phẩm không?");

                if (result == DialogResult.Yes)
                {
                    string maSanPham = sanPhamDataGridView.Rows[e.RowIndex].Cells["maSanPhamColumn"].Value.ToString();
                    CanhBaoForm.ShowAlertMessage(sanPhamBUS.XoaSanPham(maSanPham), CanhBaoForm.AlertType.SUCCESS);

                    lamMoiButton_Click(sender, e);
                }
            }
        }

        private void sanPhamDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10) && e.RowIndex >= 0)
            {
                // Kiểm tra giá trị của cell có phải là hình ảnh không.
                if (e.Value is Image)
                {
                    // Thiết lập kích thước mới cho hình ảnh.
                    int newWidth = 25; // Kích thước mới theo chiều rộng
                    int newHeight = 25; // Kích thước mới theo chiều cao

                    // Đổi kích thước hình ảnh.
                    Image originalImage = (Image)e.Value;
                    Image resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight));

                    // Gán hình ảnh mới vào cell.
                    e.Value = resizedImage;
                }
            }
        }

        private void sanPhamDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < sanPhamDataGridView.Columns.Count - numberOfColumnsToSkip)
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

        private void sanPhamDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (sanPhamDataGridView.SelectedRows.Count > 1)
            {
                xoaTatCaButton.Visible = true;
            }
            else
            {
                xoaTatCaButton.Visible = false;
            }
        }

    }
}
