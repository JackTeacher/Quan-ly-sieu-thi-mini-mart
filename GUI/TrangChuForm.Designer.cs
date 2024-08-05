namespace GUI
{
    partial class TrangChuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelNav = new Guna.UI2.WinForms.Guna2Panel();
            panelMenu = new Panel();
            fllMenu = new FlowLayoutPanel();
            btnBanHang = new FontAwesome.Sharp.IconButton();
            nhapHangButton = new FontAwesome.Sharp.IconButton();
            btnSanPham = new FontAwesome.Sharp.IconButton();
            btnLoaiSanPham = new FontAwesome.Sharp.IconButton();
            btnNhaCungCap = new FontAwesome.Sharp.IconButton();
            btnKhachHang = new FontAwesome.Sharp.IconButton();
            btnKhuyenMai = new FontAwesome.Sharp.IconButton();
            nguoiDungButton = new FontAwesome.Sharp.IconButton();
            btnHoaDon = new FontAwesome.Sharp.IconButton();
            btnPhieuNhap = new FontAwesome.Sharp.IconButton();
            btnPhanQuyen = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            dangXuatButton = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            pictureBox3 = new PictureBox();
            tenPhanQuyenLabel = new Label();
            tenNguoiDungLabel = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            panelDesktop = new Panel();
            panelNav.SuspendLayout();
            panelMenu.SuspendLayout();
            fllMenu.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(0, 79, 111);
            panelNav.Controls.Add(panelMenu);
            panelNav.Controls.Add(panel5);
            panelNav.Controls.Add(panel4);
            panelNav.CustomizableEdges = customizableEdges1;
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Margin = new Padding(5);
            panelNav.Name = "panelNav";
            panelNav.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelNav.Size = new Size(251, 881);
            panelNav.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(fllMenu);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 116);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 681);
            panelMenu.TabIndex = 20;
            // 
            // fllMenu
            // 
            fllMenu.Controls.Add(btnBanHang);
            fllMenu.Controls.Add(nhapHangButton);
            fllMenu.Controls.Add(btnSanPham);
            fllMenu.Controls.Add(btnLoaiSanPham);
            fllMenu.Controls.Add(btnNhaCungCap);
            fllMenu.Controls.Add(btnKhachHang);
            fllMenu.Controls.Add(btnKhuyenMai);
            fllMenu.Controls.Add(nguoiDungButton);
            fllMenu.Controls.Add(btnHoaDon);
            fllMenu.Controls.Add(btnPhieuNhap);
            fllMenu.Controls.Add(btnPhanQuyen);
            fllMenu.Dock = DockStyle.Fill;
            fllMenu.Location = new Point(0, 0);
            fllMenu.Name = "fllMenu";
            fllMenu.Size = new Size(251, 681);
            fllMenu.TabIndex = 0;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.FromArgb(0, 79, 111);
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnBanHang.ForeColor = Color.White;
            btnBanHang.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnBanHang.IconColor = Color.White;
            btnBanHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBanHang.IconSize = 40;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(3, 3);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(10, 0, 20, 0);
            btnBanHang.Size = new Size(238, 50);
            btnBanHang.TabIndex = 7;
            btnBanHang.Text = "Bán hàng";
            btnBanHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Visible = false;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // nhapHangButton
            // 
            nhapHangButton.BackColor = Color.FromArgb(0, 79, 111);
            nhapHangButton.FlatAppearance.BorderSize = 0;
            nhapHangButton.FlatStyle = FlatStyle.Flat;
            nhapHangButton.Font = new Font("Microsoft Sans Serif", 14.25F);
            nhapHangButton.ForeColor = Color.White;
            nhapHangButton.IconChar = FontAwesome.Sharp.IconChar.Truck;
            nhapHangButton.IconColor = Color.White;
            nhapHangButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nhapHangButton.IconSize = 40;
            nhapHangButton.ImageAlign = ContentAlignment.MiddleLeft;
            nhapHangButton.Location = new Point(3, 59);
            nhapHangButton.Name = "nhapHangButton";
            nhapHangButton.Padding = new Padding(10, 0, 20, 0);
            nhapHangButton.Size = new Size(238, 50);
            nhapHangButton.TabIndex = 13;
            nhapHangButton.Text = "Nhập hàng";
            nhapHangButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            nhapHangButton.UseVisualStyleBackColor = false;
            nhapHangButton.Visible = false;
            nhapHangButton.Click += nhapHangButton_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.FromArgb(0, 79, 111);
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnSanPham.ForeColor = Color.White;
            btnSanPham.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            btnSanPham.IconColor = Color.White;
            btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSanPham.IconSize = 40;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(3, 115);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(10, 0, 20, 0);
            btnSanPham.Size = new Size(238, 50);
            btnSanPham.TabIndex = 16;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Visible = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.BackColor = Color.FromArgb(0, 79, 111);
            btnLoaiSanPham.FlatAppearance.BorderSize = 0;
            btnLoaiSanPham.FlatStyle = FlatStyle.Flat;
            btnLoaiSanPham.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnLoaiSanPham.ForeColor = Color.White;
            btnLoaiSanPham.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnLoaiSanPham.IconColor = Color.White;
            btnLoaiSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLoaiSanPham.IconSize = 40;
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(3, 171);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Padding = new Padding(10, 0, 20, 0);
            btnLoaiSanPham.Size = new Size(238, 50);
            btnLoaiSanPham.TabIndex = 17;
            btnLoaiSanPham.Text = "Loại sản phẩm";
            btnLoaiSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoaiSanPham.UseVisualStyleBackColor = false;
            btnLoaiSanPham.Visible = false;
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.BackColor = Color.FromArgb(0, 79, 111);
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnNhaCungCap.ForeColor = Color.White;
            btnNhaCungCap.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnNhaCungCap.IconColor = Color.White;
            btnNhaCungCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaCungCap.IconSize = 40;
            btnNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.Location = new Point(3, 227);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(10, 0, 20, 0);
            btnNhaCungCap.Size = new Size(238, 50);
            btnNhaCungCap.TabIndex = 12;
            btnNhaCungCap.Text = "Nhà cung cấp";
            btnNhaCungCap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaCungCap.UseVisualStyleBackColor = false;
            btnNhaCungCap.Visible = false;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(0, 79, 111);
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnKhachHang.IconColor = Color.White;
            btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhachHang.IconSize = 40;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(3, 283);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(10, 0, 20, 0);
            btnKhachHang.Size = new Size(238, 50);
            btnKhachHang.TabIndex = 8;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Visible = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnKhuyenMai
            // 
            btnKhuyenMai.BackColor = Color.FromArgb(0, 79, 111);
            btnKhuyenMai.FlatAppearance.BorderSize = 0;
            btnKhuyenMai.FlatStyle = FlatStyle.Flat;
            btnKhuyenMai.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnKhuyenMai.ForeColor = Color.White;
            btnKhuyenMai.IconChar = FontAwesome.Sharp.IconChar.Tags;
            btnKhuyenMai.IconColor = Color.White;
            btnKhuyenMai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnKhuyenMai.IconSize = 40;
            btnKhuyenMai.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhuyenMai.Location = new Point(3, 339);
            btnKhuyenMai.Name = "btnKhuyenMai";
            btnKhuyenMai.Padding = new Padding(10, 0, 20, 0);
            btnKhuyenMai.Size = new Size(238, 50);
            btnKhuyenMai.TabIndex = 13;
            btnKhuyenMai.Text = "Khuyến mãi ";
            btnKhuyenMai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhuyenMai.UseVisualStyleBackColor = false;
            btnKhuyenMai.Visible = false;
            btnKhuyenMai.Click += btnKhuyenMai_Click;
            // 
            // nguoiDungButton
            // 
            nguoiDungButton.BackColor = Color.FromArgb(0, 79, 111);
            nguoiDungButton.FlatAppearance.BorderSize = 0;
            nguoiDungButton.FlatStyle = FlatStyle.Flat;
            nguoiDungButton.Font = new Font("Microsoft Sans Serif", 14.25F);
            nguoiDungButton.ForeColor = Color.White;
            nguoiDungButton.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            nguoiDungButton.IconColor = Color.White;
            nguoiDungButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nguoiDungButton.IconSize = 40;
            nguoiDungButton.ImageAlign = ContentAlignment.MiddleLeft;
            nguoiDungButton.Location = new Point(3, 395);
            nguoiDungButton.Name = "nguoiDungButton";
            nguoiDungButton.Padding = new Padding(10, 0, 20, 0);
            nguoiDungButton.Size = new Size(238, 50);
            nguoiDungButton.TabIndex = 14;
            nguoiDungButton.Text = "Người dùng";
            nguoiDungButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            nguoiDungButton.UseVisualStyleBackColor = false;
            nguoiDungButton.Visible = false;
            nguoiDungButton.Click += nguoiDungButton_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(0, 79, 111);
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            btnHoaDon.IconColor = Color.White;
            btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoaDon.IconSize = 40;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(3, 451);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(10, 0, 20, 0);
            btnHoaDon.Size = new Size(238, 50);
            btnHoaDon.TabIndex = 9;
            btnHoaDon.Text = "Hoá đơn";
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Visible = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.BackColor = Color.FromArgb(0, 79, 111);
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnPhieuNhap.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnPhieuNhap.ForeColor = Color.White;
            btnPhieuNhap.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btnPhieuNhap.IconColor = Color.White;
            btnPhieuNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPhieuNhap.IconSize = 40;
            btnPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.Location = new Point(3, 507);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Padding = new Padding(10, 0, 20, 0);
            btnPhieuNhap.Size = new Size(238, 50);
            btnPhieuNhap.TabIndex = 11;
            btnPhieuNhap.Text = "Phiếu nhập";
            btnPhieuNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhieuNhap.UseVisualStyleBackColor = false;
            btnPhieuNhap.Visible = false;
            btnPhieuNhap.Click += btnPhieuNhap_Click;
            // 
            // btnPhanQuyen
            // 
            btnPhanQuyen.BackColor = Color.FromArgb(0, 79, 111);
            btnPhanQuyen.FlatAppearance.BorderSize = 0;
            btnPhanQuyen.FlatStyle = FlatStyle.Flat;
            btnPhanQuyen.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnPhanQuyen.ForeColor = Color.White;
            btnPhanQuyen.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnPhanQuyen.IconColor = Color.White;
            btnPhanQuyen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPhanQuyen.IconSize = 40;
            btnPhanQuyen.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhanQuyen.Location = new Point(3, 563);
            btnPhanQuyen.Name = "btnPhanQuyen";
            btnPhanQuyen.Padding = new Padding(10, 0, 20, 0);
            btnPhanQuyen.Size = new Size(238, 50);
            btnPhanQuyen.TabIndex = 19;
            btnPhanQuyen.Text = "Phân quyền";
            btnPhanQuyen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhanQuyen.UseVisualStyleBackColor = false;
            btnPhanQuyen.Visible = false;
            btnPhanQuyen.Click += btnPhanQuyen_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(dangXuatButton);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 797);
            panel5.Name = "panel5";
            panel5.Size = new Size(251, 84);
            panel5.TabIndex = 1;
            // 
            // dangXuatButton
            // 
            dangXuatButton.BackColor = Color.FromArgb(0, 79, 111);
            dangXuatButton.FlatAppearance.BorderSize = 0;
            dangXuatButton.FlatStyle = FlatStyle.Flat;
            dangXuatButton.Font = new Font("Microsoft Sans Serif", 14.25F);
            dangXuatButton.ForeColor = Color.White;
            dangXuatButton.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            dangXuatButton.IconColor = Color.White;
            dangXuatButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            dangXuatButton.IconSize = 40;
            dangXuatButton.ImageAlign = ContentAlignment.MiddleLeft;
            dangXuatButton.Location = new Point(1, 17);
            dangXuatButton.Name = "dangXuatButton";
            dangXuatButton.Padding = new Padding(10, 0, 20, 0);
            dangXuatButton.Size = new Size(240, 50);
            dangXuatButton.TabIndex = 20;
            dangXuatButton.Text = "Đăng xuất ";
            dangXuatButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dangXuatButton.UseVisualStyleBackColor = false;
            dangXuatButton.Click += dangXuatButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(guna2ShadowPanel1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(251, 116);
            panel4.TabIndex = 0;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(pictureBox3);
            guna2ShadowPanel1.Controls.Add(tenPhanQuyenLabel);
            guna2ShadowPanel1.Controls.Add(tenNguoiDungLabel);
            guna2ShadowPanel1.Dock = DockStyle.Top;
            guna2ShadowPanel1.FillColor = Color.FromArgb(0, 50, 90);
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 5;
            guna2ShadowPanel1.ShadowColor = Color.FromArgb(0, 79, 111);
            guna2ShadowPanel1.Size = new Size(251, 110);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.user1;
            pictureBox3.Location = new Point(12, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // tenPhanQuyenLabel
            // 
            tenPhanQuyenLabel.AutoSize = true;
            tenPhanQuyenLabel.ForeColor = Color.MistyRose;
            tenPhanQuyenLabel.Location = new Point(61, 57);
            tenPhanQuyenLabel.Name = "tenPhanQuyenLabel";
            tenPhanQuyenLabel.Size = new Size(178, 24);
            tenPhanQuyenLabel.TabIndex = 2;
            tenPhanQuyenLabel.Text = "nhân viên bán hàng";
            // 
            // tenNguoiDungLabel
            // 
            tenNguoiDungLabel.AutoSize = true;
            tenNguoiDungLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            tenNguoiDungLabel.ForeColor = Color.MistyRose;
            tenNguoiDungLabel.Location = new Point(61, 29);
            tenNguoiDungLabel.Name = "tenNguoiDungLabel";
            tenNguoiDungLabel.Size = new Size(96, 24);
            tenNguoiDungLabel.TabIndex = 1;
            tenNguoiDungLabel.Text = "Ngọc Tín";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 50, 90);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(251, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 60);
            panel1.TabIndex = 1;
            panel1.MouseDown += panelTitleBar_MouseDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTitleChildForm);
            panel3.Controls.Add(iconCurrentChildForm);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 60);
            panel3.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitleChildForm.ForeColor = Color.White;
            lblTitleChildForm.Location = new Point(91, 15);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(136, 30);
            lblTitleChildForm.TabIndex = 3;
            lblTitleChildForm.Text = "TRANG CHỦ";
            lblTitleChildForm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(0, 50, 90);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 50;
            iconCurrentChildForm.Location = new Point(25, 5);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Padding = new Padding(10, 0, 0, 0);
            iconCurrentChildForm.Size = new Size(50, 50);
            iconCurrentChildForm.SizeMode = PictureBoxSizeMode.Zoom;
            iconCurrentChildForm.TabIndex = 2;
            iconCurrentChildForm.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Right;
            panel2.Controls.Add(iconButton9);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(iconButton7);
            panel2.Location = new Point(1012, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 60);
            panel2.TabIndex = 0;
            // 
            // iconButton9
            // 
            iconButton9.BackColor = Color.FromArgb(0, 50, 90);
            iconButton9.FlatAppearance.BorderSize = 0;
            iconButton9.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 60, 60, 60);
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.Font = new Font("Microsoft Sans Serif", 14.25F);
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            iconButton9.IconColor = Color.White;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton9.IconSize = 20;
            iconButton9.Location = new Point(72, 3);
            iconButton9.Name = "iconButton9";
            iconButton9.Padding = new Padding(0, 3, 0, 0);
            iconButton9.Size = new Size(45, 34);
            iconButton9.TabIndex = 11;
            iconButton9.UseVisualStyleBackColor = false;
            iconButton9.Click += btnMaximize_Click;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.FromArgb(0, 50, 90);
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Microsoft Sans Serif", 14.25F);
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton8.IconSize = 20;
            iconButton8.Location = new Point(123, 0);
            iconButton8.Name = "iconButton8";
            iconButton8.Padding = new Padding(0, 3, 0, 0);
            iconButton8.Size = new Size(45, 34);
            iconButton8.TabIndex = 9;
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += btnExit_Click;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.FromArgb(0, 50, 90);
            iconButton7.FlatAppearance.BorderSize = 0;
            iconButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(150, 60, 60, 60);
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Microsoft Sans Serif", 14.25F);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton7.IconSize = 20;
            iconButton7.ImageAlign = ContentAlignment.TopCenter;
            iconButton7.Location = new Point(21, 3);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(45, 34);
            iconButton7.TabIndex = 10;
            iconButton7.UseVisualStyleBackColor = false;
            iconButton7.Click += btnMinimize_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(251, 60);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1183, 821);
            panelDesktop.TabIndex = 2;
            // 
            // TrangChuForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1434, 881);
            Controls.Add(panelDesktop);
            Controls.Add(panel1);
            Controls.Add(panelNav);
            Font = new Font("Microsoft Sans Serif", 14.25F);
            Margin = new Padding(5);
            Name = "TrangChuForm";
            Text = "TrangChuForm";
            Load += TrangChuForm_Load;
            panelNav.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            fllMenu.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelNav;
        private FontAwesome.Sharp.IconButton btnBanHang;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnPhieuNhap;
        private FontAwesome.Sharp.IconButton btnNhaCungCap;
        private Panel panel1;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton iconButton7;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton nguoiDungButton;
        private FontAwesome.Sharp.IconButton btnKhuyenMai;
        private FontAwesome.Sharp.IconButton btnLoaiSanPham;
        private Panel panelMenu;
        private FlowLayoutPanel fllMenu;
        private FontAwesome.Sharp.IconButton btnPhanQuyen;
        private Panel panel3;
        private Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton dangXuatButton;
        private Panel panel4;
        private Label tenPhanQuyenLabel;
        private Label tenNguoiDungLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton nhapHangButton;
    }
}