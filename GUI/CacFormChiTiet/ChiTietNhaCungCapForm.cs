using BUS;
using BUS.OtherFunctions;
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

namespace GUI
{
    public partial class ChiTietNhaCungCapForm : Form
    {
        NhaCungCap nhaCungCap;
        string context;
        NhaCungCapBUS nhaCungCapBUS;
        NhaCungCapForm form;
        NhapHangForm nhapHangForm;

        public ChiTietNhaCungCapForm(NhaCungCap nhaCungCap, string context, NhaCungCapForm form)
        {
            InitializeComponent();
            CenterToParent();

            nhaCungCapBUS = new NhaCungCapBUS();
            this.nhaCungCap = nhaCungCap;
            this.context = context;
            this.form = form;
        }

        public ChiTietNhaCungCapForm(string context, NhaCungCapForm form)
        {
            InitializeComponent();
            CenterToParent();

            nhaCungCapBUS = new NhaCungCapBUS();
            this.context = context;
            this.form = form;
        }

        public ChiTietNhaCungCapForm(string context, NhapHangForm form)
        {
            InitializeComponent();
            CenterToParent();

            nhaCungCapBUS = new NhaCungCapBUS();
            this.context = context;
            this.nhapHangForm = nhapHangForm;
        }

        private void ChiTietNhaCungCapForm_Load(object sender, EventArgs e)
        {
            switch (context)
            {
                case "Chi tiết":
                    tieuDeFormLabel.Text = "Chi tiết nhà cung cấp";

                    maNhaCungCapTextBox.Text = nhaCungCap.maNhaCungCap;
                    tenNhaCungCapTextBox.Text = nhaCungCap.tenNhaCungCap;
                    soDienThoaiTextBox.Text = nhaCungCap.soDienThoai;
                    emailTextBox.Text = nhaCungCap.email;
                    diaChiTextBox.Text = nhaCungCap.diaChi;

                    maNhaCungCapTextBox.ReadOnly = true;
                    tenNhaCungCapTextBox.ReadOnly = true;
                    soDienThoaiTextBox.ReadOnly = true;
                    emailTextBox.ReadOnly = true;
                    diaChiTextBox.ReadOnly = true;
                    luuButton.Visible = false;
                    huyBoButton.Visible = false;
                    this.Height -= huyBoButton.Height;

                    break;

                case "Thêm":
                    tieuDeFormLabel.Text = "Thêm nhà cung cấp";

                    maNhaCungCapTextBox.Text = IDGenerator.GenerateNhaCungCapID();

                    maNhaCungCapTextBox.ReadOnly = true;

                    break;

                case "Sửa":
                    tieuDeFormLabel.Text = "Chỉnh sửa thông tin nhà cung cấp";

                    maNhaCungCapTextBox.Text = nhaCungCap.maNhaCungCap;
                    tenNhaCungCapTextBox.Text = nhaCungCap.tenNhaCungCap;
                    soDienThoaiTextBox.Text = nhaCungCap.soDienThoai;
                    emailTextBox.Text = nhaCungCap.email;
                    diaChiTextBox.Text = nhaCungCap.diaChi;

                    maNhaCungCapTextBox.ReadOnly = true;
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
                    tenNhaCungCapTextBox.Text = nhaCungCap.tenNhaCungCap;
                    soDienThoaiTextBox.Text = nhaCungCap.soDienThoai;
                    emailTextBox.Text = nhaCungCap.email;
                    diaChiTextBox.Text = nhaCungCap.diaChi;
                }
                else if (context.Equals("Thêm"))
                {
                    tenNhaCungCapTextBox.Clear();
                    soDienThoaiTextBox.Clear();
                    emailTextBox.Clear();
                    diaChiTextBox.Clear();
                }
            }
        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            string maNhaCungCap = maNhaCungCapTextBox.Text;
            string tenNhaCungCap = tenNhaCungCapTextBox.Text;
            string soDienThoai = soDienThoaiTextBox.Text;
            string email = emailTextBox.Text;
            string diaChi = diaChiTextBox.Text;

            DialogResult result = MessageBox.Show("Bạn có muốn lưu thông tin nhà cung cấp không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string message = "";

                switch (context)
                {
                    case "Thêm":
                        message = nhaCungCapBUS.ThemNhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi);
                        break;

                    case "Sửa":
                        message = nhaCungCapBUS.SuaNhaCungCap(maNhaCungCap, tenNhaCungCap, soDienThoai, email, diaChi);
                        break;
                }

                MessageBox.Show(message);

                if (message.Equals("Thêm nhà cung cấp thành công!") || message.Equals("Chỉnh sửa thông tin nhà cung cấp thành công!"))
                {
                    if (form != null)
                        form.lamMoiButton_Click(sender, e);

                    if (nhapHangForm != null)
                    {
                        nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoMa(maNhaCungCap);
                        nhapHangForm.nhaCungCap = nhaCungCap;
                        nhapHangForm.maNhaCungCapTextBox.Text = nhaCungCap.maNhaCungCap;
                        nhapHangForm.tenNhaCungCapTextBox.Text = nhaCungCap.tenNhaCungCap;
                        nhapHangForm.canhBaoLabel.Visible = false;
                    }
                    this.Close();
                }
            }
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < 32 || e.KeyChar > 126 || e.KeyChar == ' '))
            {
                e.Handled = true;
            }
        }

        private void soDienThoaiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
