using BUS;
using BUS.OtherFunctions;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChiTietLoaiSanPhamForm : Form
    {
        LoaiSanPham loaiSanPham;
        LoaiSanPhamBUS loaiSanPhamBUS;
        string context;
        LoaiSanPhamForm form;

        public ChiTietLoaiSanPhamForm(LoaiSanPham loaiSanPham, string context, LoaiSanPhamForm form)
        {
            InitializeComponent();
            CenterToParent();

            loaiSanPhamBUS = new LoaiSanPhamBUS();
            this.loaiSanPham = loaiSanPham;
            this.context = context;
            this.form = form;
        }

        public ChiTietLoaiSanPhamForm(string context, LoaiSanPhamForm form)
        {
            InitializeComponent();
            CenterToParent();

            loaiSanPhamBUS = new LoaiSanPhamBUS();
            this.context = context;
            this.form = form;
        }

        private void ChiTietLoaiSanPhamForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết loại sản phẩm";

                    maLoaiSanPhamTextBox.Text = loaiSanPham.maLoaiSanPham;
                    tenLoaiSanPhamTextBox.Text = loaiSanPham.tenLoaiSanPham;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(loaiSanPham.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maLoaiSanPhamTextBox.ReadOnly = true;
                    tenLoaiSanPhamTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;
                    huyBoButton.Visible = false;
                    luuButton.Visible = false;
                    this.Height -= huyBoButton.Height;

                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm loại sản phẩm";

                    maLoaiSanPhamTextBox.Text = IDGenerator.GenerateLoaiSanPhamID();
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals("Đang sử dụng"))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maLoaiSanPhamTextBox.ReadOnly = true;
                    trangThaiComboBox.Enabled = false;

                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin loại sản phẩm";

                    maLoaiSanPhamTextBox.Text = loaiSanPham.maLoaiSanPham;
                    tenLoaiSanPhamTextBox.Text = loaiSanPham.tenLoaiSanPham;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(loaiSanPham.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    maLoaiSanPhamTextBox.ReadOnly = true;
                    break;
            }
        }

        private void huyBoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy bỏ các thông tin đã nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (context.Equals("Sửa"))
                {
                    maLoaiSanPhamTextBox.Text = loaiSanPham.maLoaiSanPham;
                    tenLoaiSanPhamTextBox.Text = loaiSanPham.tenLoaiSanPham;
                    foreach (var item in trangThaiComboBox.Items)
                    {
                        if (item.ToString().Equals(loaiSanPham.trangThai))
                        {
                            trangThaiComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }
                else if (context.Equals("Thêm"))
                {
                    tenLoaiSanPhamTextBox.Clear();
                }
            }
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin loại sản phẩm không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string maLoaiSanPham = maLoaiSanPhamTextBox.Text;
                string tenLoaiSanPham = tenLoaiSanPhamTextBox.Text;
                string trangThai = trangThaiComboBox.SelectedItem.ToString();

                string message = "";

                switch (context)
                {
                    case "Thêm":
                        message = loaiSanPhamBUS.ThemLoaiSanPham(maLoaiSanPham, tenLoaiSanPham);
                        break;

                    case "Sửa":
                        message = loaiSanPhamBUS.SuaLoaiSanPham(maLoaiSanPham, tenLoaiSanPham, trangThai);
                        break;
                }

                MessageBox.Show(message);

                if (message.Equals("Thêm loại sản phẩm thành công!") || message.Equals("Chỉnh sửa thông tin loại sản phẩm thành công!"))
                {
                    form.lamMoiButton_Click(sender, e);
                    this.Close();
                }
            }
        }

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
