using BUS;
using BUS.OtherFunctions;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CacFormChiTiet
{
    public partial class TestChiTietKhuyenMaiForm : Form
    {
        KhuyenMaiBUS khuyenMaiBUS;
        KhuyenMai khuyenMai;
        KhuyenMaiForm khuyenMaiForm;
        string context;

        public TestChiTietKhuyenMaiForm(KhuyenMai khuyenMai, string context, KhuyenMaiForm khuyenMaiForm)
        {
            InitializeComponent();
            CenterToParent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            this.khuyenMai = khuyenMai;
            this.khuyenMaiForm = khuyenMaiForm;
            this.context = context;
        }

        public TestChiTietKhuyenMaiForm(string context, KhuyenMaiForm khuyenMaiForm)
        {
            InitializeComponent();
            CenterToParent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            this.khuyenMaiForm = khuyenMaiForm;
            this.context = context;
        }

        public TestChiTietKhuyenMaiForm()
        {
        }

        private void TestChiTietKhuyenMaiForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết khuyến mãi";

                    maKhuyenMaiTextBox.Text = khuyenMai.maKhuyenMai;
                    tenKhuyenMaiTextBox.Text = khuyenMai.tenKhuyenMai;
                    if (khuyenMai.loaiGiaTri.Equals("Phần trăm"))
                        phanTramRadioButton.Checked = true;
                    else
                        cuTheRadioButton.Checked = true;
                    giaTriKhuyenMaiTextBox.Text = khuyenMai.giaTri.ToString();
                    thoiGianBatDauDateTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucDateTimePicker.Value = khuyenMai.thoiGianKetThuc;
                    thoiGianBatDauTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucTimePicker.Value = khuyenMai.thoiGianKetThuc;

                    maKhuyenMaiTextBox.ReadOnly = true;
                    tenKhuyenMaiTextBox.ReadOnly = true;
                    phanTramRadioButton.Enabled = false;
                    cuTheRadioButton.Enabled = false;
                    giaTriKhuyenMaiTextBox.ReadOnly = true;
                    thoiGianBatDauDateTimePicker.Enabled = false;
                    thoiGianBatDauTimePicker.Enabled = false;
                    thoiGianKetThucDateTimePicker.Enabled = false;
                    thoiGianKetThucTimePicker.Enabled = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;

                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm khuyến mãi";

                    maKhuyenMaiTextBox.Text = IDGenerator.GenerateKhuyenMaiID();
                    thoiGianBatDauDateTimePicker.Value = DateTime.Now;
                    thoiGianKetThucDateTimePicker.Value = DateTime.Now;
                    thoiGianBatDauTimePicker.Value = DateTime.Now;
                    thoiGianKetThucTimePicker.Value = DateTime.Now;

                    maKhuyenMaiTextBox.ReadOnly = true;

                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin khuyến mãi";

                    maKhuyenMaiTextBox.Text = khuyenMai.maKhuyenMai;
                    tenKhuyenMaiTextBox.Text = khuyenMai.tenKhuyenMai;
                    if (khuyenMai.loaiGiaTri.Equals("Phần trăm"))
                        phanTramRadioButton.Checked = true;
                    else
                        cuTheRadioButton.Checked = true;
                    giaTriKhuyenMaiTextBox.Text = khuyenMai.giaTri.ToString();
                    thoiGianBatDauDateTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucDateTimePicker.Value = khuyenMai.thoiGianKetThuc;
                    thoiGianBatDauTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucTimePicker.Value = khuyenMai.thoiGianKetThuc;

                    maKhuyenMaiTextBox.ReadOnly = true;

                    break;
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    tenKhuyenMaiTextBox.Text = khuyenMai.tenKhuyenMai;
                    if (khuyenMai.loaiGiaTri.Equals("Phần trăm"))
                        phanTramRadioButton.Checked = true;
                    else
                        cuTheRadioButton.Checked = true;
                    giaTriKhuyenMaiTextBox.Text = khuyenMai.giaTri.ToString();
                    thoiGianBatDauDateTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucDateTimePicker.Value = khuyenMai.thoiGianKetThuc;
                    thoiGianBatDauTimePicker.Value = khuyenMai.thoiGianBatDau;
                    thoiGianKetThucTimePicker.Value = khuyenMai.thoiGianKetThuc;
                }
                else if (context.Equals("Thêm"))
                {
                    tenKhuyenMaiTextBox.Clear();
                    phanTramRadioButton.Checked = false;
                    cuTheRadioButton.Checked = false;
                    giaTriKhuyenMaiTextBox.Clear();
                    thoiGianBatDauDateTimePicker.Value = DateTime.Now;
                    thoiGianKetThucDateTimePicker.Value = DateTime.Now;
                    thoiGianBatDauTimePicker.Value = DateTime.Now;
                    thoiGianKetThucTimePicker.Value = DateTime.Now;
                }
            }
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin khuyến mãi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string maKhuyenMai = maKhuyenMaiTextBox.Text;
                string tenKhuyenMai = tenKhuyenMaiTextBox.Text;
                string loaiGiaTri = "";
                if (phanTramRadioButton.Checked)
                    loaiGiaTri = "Phần trăm";
                if (cuTheRadioButton.Checked)
                    loaiGiaTri = "Cụ thể";
                string giaTriApDung = giaTriKhuyenMaiTextBox.Text;
                string thoiGianBatDau = "";
                string thoiGianKetThuc = "";
                DateTime dateTimeNgayBatDau = DateTime.ParseExact(thoiGianBatDauDateTimePicker.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dateTimeGioBatDau = DateTime.ParseExact(thoiGianBatDauTimePicker.Value.ToString("HH:mm:ss"), "HH:mm:ss", CultureInfo.InvariantCulture);
                DateTime dateTimeBatDau = dateTimeNgayBatDau.Add(new TimeSpan(dateTimeGioBatDau.Hour, dateTimeGioBatDau.Minute, dateTimeGioBatDau.Second));
                thoiGianBatDau = dateTimeBatDau.ToString("dd/MM/yyyy HH:mm:ss", null);
                DateTime dateTimeNgayKetThuc = DateTime.ParseExact(thoiGianKetThucDateTimePicker.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dateTimeGioKetThuc = DateTime.ParseExact(thoiGianKetThucTimePicker.Value.ToString("HH:mm:ss"), "HH:mm:ss", CultureInfo.InvariantCulture);
                DateTime dateTimeKetThuc = dateTimeNgayKetThuc.Add(new TimeSpan(dateTimeGioKetThuc.Hour, dateTimeGioKetThuc.Minute, dateTimeGioKetThuc.Second));
                thoiGianKetThuc = dateTimeKetThuc.ToString("dd/MM/yyyy HH:mm:ss", null);

                string message = "";

                switch (context)
                {
                    case "Thêm":
                        message = khuyenMaiBUS.ThemKhuyenMai(maKhuyenMai, tenKhuyenMai, thoiGianBatDau, thoiGianKetThuc, loaiGiaTri, giaTriApDung);
                        break;
                    case "Sửa":
                        message = khuyenMaiBUS.SuaKhuyenMai(maKhuyenMai, tenKhuyenMai, thoiGianBatDau, thoiGianKetThuc, loaiGiaTri, giaTriApDung);
                        break;
                }

                MessageBox.Show(message);

                if (message.Equals("Thêm khuyến mãi thành công!") || message.Equals("Chỉnh sửa thông tin khuyến mãi thành công!"))
                {
                    khuyenMaiForm.lamMoiButton_Click(sender, e);

                    this.Close();
                }
            }
        }

        private void giaTriKhuyenMaiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
