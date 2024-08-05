using BUS;
using BUS.OtherFunctions;
using DTO;
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

namespace GUI.CacFormDuLieu
{
    public partial class NguoiDungForm : Form
    {
        NguoiDungBUS nguoiDungBUS;
        List<NguoiDung> listNguoiDung;

        public NguoiDungForm()
        {
            InitializeComponent();

            nguoiDungBUS = new NguoiDungBUS();
            listNguoiDung = nguoiDungBUS.LayDanhSachNguoiDung();
        }

        private void NguoiDungForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listNguoiDung);

            phanQuyenComboBox.DataSource = new PhanQuyenBUS().LayDanhSachPhanQuyen();
            phanQuyenComboBox.DisplayMember = "tenPhanQuyen";
            phanQuyenComboBox.SelectedIndex = -1;

            trangThaiComboBox.SelectedIndex = 0;

            gioiTinhComboBox.SelectedIndex = -1;
        }

        private void LoadDataToDataGridView(List<NguoiDung> listNguoiDung)
        {
            nguoiDungDataGridView.Rows.Clear();

            for (int i = 0; i < listNguoiDung.Count; i++)
            {
                nguoiDungDataGridView.Rows.Add(1);
                nguoiDungDataGridView.Rows[i].Cells[0].Value = i + 1;
                nguoiDungDataGridView.Rows[i].Cells[1].Value = listNguoiDung[i].maNguoiDung;
                nguoiDungDataGridView.Rows[i].Cells[2].Value = new PhanQuyenBUS().LayPhanQuyenTheoMa(listNguoiDung[i].maPhanQuyen).tenPhanQuyen;
                nguoiDungDataGridView.Rows[i].Cells[3].Value = listNguoiDung[i].tenDangNhap;
                nguoiDungDataGridView.Rows[i].Cells[4].Value = listNguoiDung[i].hoTen;
                nguoiDungDataGridView.Rows[i].Cells[5].Value = listNguoiDung[i].gioiTinh;
                nguoiDungDataGridView.Rows[i].Cells[6].Value = listNguoiDung[i].trangThai;
            }
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string maPhanQuyen = "";
            if (phanQuyenComboBox.SelectedValue != null)
            {
                PhanQuyen phanQuyen = phanQuyenComboBox.SelectedValue as PhanQuyen;
                maPhanQuyen = phanQuyen.maPhanQuyen;
            }
            string trangThai = "";
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();
            string gioiTinh = "";
            if (gioiTinhComboBox.SelectedItem != null)
                gioiTinh = gioiTinhComboBox.SelectedItem.ToString();

            listNguoiDung = nguoiDungBUS.TimKiemNguoiDung(tuKhoa, maPhanQuyen, gioiTinh, trangThai);

            LoadDataToDataGridView(listNguoiDung);
        }

        internal void lamMoiButton_Click(object sender, EventArgs e)
        {
            phanQuyenComboBox.SelectedItem = null;
            phanQuyenComboBox.SelectedIndex = -1;
            trangThaiComboBox.SelectedItem = null;
            trangThaiComboBox.SelectedIndex = 0;
            gioiTinhComboBox.SelectedItem = null;
            gioiTinhComboBox.SelectedIndex = -1;
            timKiemTextBox.Clear();

            listNguoiDung = nguoiDungBUS.LayDanhSachNguoiDung();

            LoadDataToDataGridView(listNguoiDung);
        }

        private void xuatExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                new XuatExcel(filePath).XuatExcelNguoiDung(listNguoiDung);

                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void themMoiButton_Click(object sender, EventArgs e)
        {
            new ChiTietNguoiDungForm("Thêm", this).Show();
        }

        private void xoaTatCaButton_Click(object sender, EventArgs e)
        {
            DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn xóa các người dùng đã chọn");

            if (result == DialogResult.Yes)
            {
                bool hoanTat = true;

                for (int i = 0; i < nguoiDungDataGridView.SelectedRows.Count; i++)
                {
                    string maNguoiDung = nguoiDungDataGridView.SelectedRows[i].Cells["maNguoiDungColumn"].Value.ToString();

                    if (!nguoiDungBUS.XoaNguoiDung(maNguoiDung).Equals("Xóa người dùng thành công!"))
                    {
                        hoanTat = false;
                        break;
                    }
                }

                if (hoanTat)
                {
                    CanhBaoForm.ShowAlertMessage("Đã xóa tất cả người dùng đã chọn!", CanhBaoForm.AlertType.SUCCESS);
                    lamMoiButton_Click(sender, e);
                }
                else
                    CanhBaoForm.ShowAlertMessage("Quá trình xóa xảy ra lỗi!", CanhBaoForm.AlertType.ERROR);
            }
        }

        private void nguoiDungDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NguoiDung nguoiDung = nguoiDungBUS.LayNguoiDungTheoMa(nguoiDungDataGridView["maNguoiDungColumn", e.RowIndex].Value.ToString());

                string columnName = nguoiDungDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("infoButtonColumn"))
                {
                    new ChiTietNguoiDungForm(nguoiDung, "Chi tiết", this).ShowDialog();
                }

                if (columnName.Equals("editButtonColumn"))
                {
                    new ChiTietNguoiDungForm(nguoiDung, "Sửa", this).ShowDialog();
                }

                if (columnName.Equals("deleteButtonColumn"))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa người dùng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string message = nguoiDungBUS.XoaNguoiDung(nguoiDung.maNguoiDung);

                        MessageBox.Show(message);

                        lamMoiButton_Click(sender, e);
                    }
                }
            }
        }

        private void phanQuyenComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (phanQuyenComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void trangThaiComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (trangThaiComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void gioiTinhComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (gioiTinhComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void nguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (nguoiDungDataGridView.SelectedRows.Count > 1)
            {
                xoaTatCaButton.Visible = true;
            }
            else
            {
                xoaTatCaButton.Visible = false;
            }
        }

        private void nguoiDungDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9) && e.RowIndex >= 0)
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

        private void nguoiDungDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < nguoiDungDataGridView.Columns.Count - numberOfColumnsToSkip)
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
    }
}
