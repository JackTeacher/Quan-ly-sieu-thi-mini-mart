using BUS;
using BUS.OtherFunctions;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class PhieuNhapForm : Form
    {
        PhieuNhapBUS phieuNhapBUS;
        List<PhieuNhap> listPhieuNhap;

        public PhieuNhapForm()
        {
            InitializeComponent();

            phieuNhapBUS = new PhieuNhapBUS();
            listPhieuNhap = phieuNhapBUS.LayDanhSachPhieuNhap();
        }

        private void PhieuNhapForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listPhieuNhap);
            thoiGianCheckBox.Checked = false;
            thoiGianBatDauDateTimePicker.Enabled = false;
            thoiGianKetThucDateTimePicker.Enabled=false;
        }

        private void LoadDataToDataGridView(List<PhieuNhap> listPhieuNhap)
        {
            phieuNhapDataGridView.Rows.Clear();

            for (int i = 0; i < listPhieuNhap.Count; i++)
            {
                phieuNhapDataGridView.Rows.Add(1);
                phieuNhapDataGridView.Rows[i].Cells[0].Value = i + 1;
                phieuNhapDataGridView.Rows[i].Cells[1].Value = listPhieuNhap[i].maPhieuNhap;
                phieuNhapDataGridView.Rows[i].Cells[2].Value = listPhieuNhap[i].maNhaCungCap;
                phieuNhapDataGridView.Rows[i].Cells[3].Value = listPhieuNhap[i].maNguoiTao;
                phieuNhapDataGridView.Rows[i].Cells[4].Value = listPhieuNhap[i].maNguoiDuyet;
                phieuNhapDataGridView.Rows[i].Cells[5].Value = listPhieuNhap[i].thoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
                phieuNhapDataGridView.Rows[i].Cells[6].Value = listPhieuNhap[i].thoiGianDuyet?.ToString("dd/MM/yyyy HH:mm:ss");
                phieuNhapDataGridView.Rows[i].Cells[7].Value = listPhieuNhap[i].thanhTien.ToString("#,##0") + " VNĐ";
                phieuNhapDataGridView.Rows[i].Cells[8].Value = listPhieuNhap[i].trangThai;
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string trangThai = "";
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();
            string thoiGianBatDau = "";
            string thoiGianKetThuc = "";
            if (thoiGianCheckBox.Checked && thoiGianBatDauDateTimePicker.Enabled && thoiGianKetThucDateTimePicker.Enabled)
            {
                thoiGianBatDau = thoiGianBatDauDateTimePicker.Value.ToString("dd/MM/yyyy HH:mm:ss");
                thoiGianKetThuc = thoiGianKetThucDateTimePicker.Value.ToString("dd/MM/yyyy HH:mm:ss");
            }

            if (!(tuKhoa == "" && trangThai == "" && thoiGianBatDau == "" && thoiGianKetThuc == ""))
            {
                if (phieuNhapBUS.TimKiemPhieuNhap(tuKhoa, trangThai, thoiGianBatDau, thoiGianKetThuc) == null)
                    MessageBox.Show("Thời gian tìm kiếm bắt đầu không được lớn hơn kết thúc!");
                else
                {
                    listPhieuNhap = phieuNhapBUS.TimKiemPhieuNhap(tuKhoa, trangThai, thoiGianBatDau, thoiGianKetThuc);
                    LoadDataToDataGridView(listPhieuNhap);
                }
            }
        }

        private void trangThaiComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (trangThaiComboBox.SelectedItem != null)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        internal void lamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            trangThaiComboBox.SelectedIndex = -1;
            thoiGianCheckBox.Checked = false;
            listPhieuNhap = phieuNhapBUS.LayDanhSachPhieuNhap();
            LoadDataToDataGridView(listPhieuNhap);
        }

        private void xuatExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelPhieuNhap(listPhieuNhap);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void thoiGianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (thoiGianCheckBox.Checked)
            {
                thoiGianBatDauDateTimePicker.Enabled = true;
                thoiGianKetThucDateTimePicker.Enabled= true;
            }
            else
            {
                thoiGianBatDauDateTimePicker.Enabled = false;
                thoiGianKetThucDateTimePicker.Enabled = false;
            }
        }

        private void phieuNhapDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < phieuNhapDataGridView.Columns.Count - numberOfColumnsToSkip)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Đặt màu cho đường kẻ giữa các cột (nếu không thuộc vào cột cuối cùng)
                using (Pen pen = new Pen(System.Drawing.Color.FromArgb(242, 245, 250), 5))
                {
                    int x = e.CellBounds.Right - 1;
                    int y1 = e.CellBounds.Top;
                    int y2 = e.CellBounds.Bottom;
                    e.Graphics.DrawLine(pen, x, y1, x, y2);
                }

                e.Handled = true;
            }
        }

        private void phieuNhapDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if (e.RowIndex >= 0)
            {
                if ((e.ColumnIndex == 9 || e.ColumnIndex == 10 || e.ColumnIndex == 11) && e.RowIndex >= 0)
                {
                    // Kiểm tra giá trị của cell có phải là hình ảnh không.
                    if (e.Value is Image && e != null)
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

                if ((e.ColumnIndex == 10 || e.ColumnIndex == 11) && e.RowIndex >= 0)
                {
                    var trangThaiValue = phieuNhapDataGridView.Rows[e.RowIndex].Cells["trangThaiColumn"].Value?.ToString();

                    if (trangThaiValue != "Chưa duyệt") // Thay "da duyet" bằng giá trị cần kiểm tra trong cột "trangthaicolumn"
                    {
                        // Ẩn hình ảnh tại cột chỉ số 10 và 11 trong các hàng thỏa mãn điều kiện
                        e.Value = null; // Gán giá trị của ô là null để ẩn hình ảnh
                    }
                }
            }
        }

        private void phieuNhapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PhieuNhap phieuNhap = phieuNhapBUS.LayPhieuNhapTheoMa(phieuNhapDataGridView["maPhieuNhapColumn", e.RowIndex].Value.ToString());

                string columnName = phieuNhapDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("infoButtonColumn"))
                {
                    new ChiTietPhieuNhapForm(phieuNhap.maPhieuNhap, this).ShowDialog();
                }

                if (columnName.Equals("duyetButtonColumn"))
                {
                    DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn duyệt phiếu nhập đã chọn không?");

                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(phieuNhapBUS.DuyetPhieuNhap(phieuNhap.maPhieuNhap, DangNhapForm.nguoiDung.maNguoiDung));
                        lamMoiButton_Click(sender, e);
                    }
                        

                }

                if (columnName.Equals("khongDuyetButtonColumn"))
                {
                    DialogResult result = CacFormThongBao.XacNhanForm.ShowDialog("Bạn có muốn từ chối duyệt phiếu nhập đã chọn không?");

                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(phieuNhapBUS.TuChoiPhieuNhap(phieuNhap.maPhieuNhap));
                        lamMoiButton_Click(sender, e);
                    }
                        
                }
            }
        }

        
    }
}
