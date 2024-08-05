namespace GUI.CacFormDuLieu
{
    partial class NguoiDungForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            nguoiDungDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            maNguoiDungColumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tenDangNhapColumn = new DataGridViewTextBoxColumn();
            hoTenColumn = new DataGridViewTextBoxColumn();
            gioiTinhColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            infoButtonColumn = new DataGridViewImageColumn();
            editButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn = new DataGridViewImageColumn();
            panel1 = new Panel();
            label3 = new Label();
            gioiTinhComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            trangThaiComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            xoaTatCaButton = new FontAwesome.Sharp.IconButton();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            phanQuyenComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            phanQuyenBindingSource = new BindingSource(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nguoiDungDataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phanQuyenBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(nguoiDungDataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 696);
            panel2.TabIndex = 59;
            // 
            // nguoiDungDataGridView
            // 
            nguoiDungDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            nguoiDungDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            nguoiDungDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            nguoiDungDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            nguoiDungDataGridView.ColumnHeadersHeight = 40;
            nguoiDungDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            nguoiDungDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, maNguoiDungColumn, Column3, tenDangNhapColumn, hoTenColumn, gioiTinhColumn, trangThaiColumn, infoButtonColumn, editButtonColumn, deleteButtonColumn });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            nguoiDungDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            nguoiDungDataGridView.Dock = DockStyle.Fill;
            nguoiDungDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            nguoiDungDataGridView.Location = new Point(0, 0);
            nguoiDungDataGridView.Name = "nguoiDungDataGridView";
            nguoiDungDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            nguoiDungDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            nguoiDungDataGridView.RowHeadersVisible = false;
            nguoiDungDataGridView.RowHeadersWidth = 51;
            nguoiDungDataGridView.RowTemplate.DividerHeight = 3;
            nguoiDungDataGridView.RowTemplate.Height = 50;
            nguoiDungDataGridView.Size = new Size(1183, 696);
            nguoiDungDataGridView.TabIndex = 51;
            nguoiDungDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            nguoiDungDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            nguoiDungDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            nguoiDungDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            nguoiDungDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            nguoiDungDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            nguoiDungDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            nguoiDungDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            nguoiDungDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            nguoiDungDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            nguoiDungDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            nguoiDungDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            nguoiDungDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            nguoiDungDataGridView.ThemeStyle.ReadOnly = true;
            nguoiDungDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            nguoiDungDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            nguoiDungDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            nguoiDungDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            nguoiDungDataGridView.ThemeStyle.RowsStyle.Height = 50;
            nguoiDungDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            nguoiDungDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            nguoiDungDataGridView.CellContentClick += nguoiDungDataGridView_CellContentClick;
            nguoiDungDataGridView.CellFormatting += nguoiDungDataGridView_CellFormatting;
            nguoiDungDataGridView.CellPainting += nguoiDungDataGridView_CellPainting;
            nguoiDungDataGridView.SelectionChanged += nguoiDungDataGridView_SelectionChanged;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 41;
            // 
            // maNguoiDungColumn
            // 
            maNguoiDungColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNguoiDungColumn.HeaderText = "Mã người dùng";
            maNguoiDungColumn.MinimumWidth = 6;
            maNguoiDungColumn.Name = "maNguoiDungColumn";
            maNguoiDungColumn.ReadOnly = true;
            maNguoiDungColumn.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Phân quyền";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // tenDangNhapColumn
            // 
            tenDangNhapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenDangNhapColumn.FillWeight = 120F;
            tenDangNhapColumn.HeaderText = "Tên đăng nhập";
            tenDangNhapColumn.MinimumWidth = 6;
            tenDangNhapColumn.Name = "tenDangNhapColumn";
            tenDangNhapColumn.ReadOnly = true;
            // 
            // hoTenColumn
            // 
            hoTenColumn.HeaderText = "Họ tên";
            hoTenColumn.Name = "hoTenColumn";
            hoTenColumn.ReadOnly = true;
            // 
            // gioiTinhColumn
            // 
            gioiTinhColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gioiTinhColumn.FillWeight = 65F;
            gioiTinhColumn.HeaderText = "Giới tính";
            gioiTinhColumn.MinimumWidth = 6;
            gioiTinhColumn.Name = "gioiTinhColumn";
            gioiTinhColumn.ReadOnly = true;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.FillWeight = 70F;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.MinimumWidth = 6;
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.ReadOnly = true;
            // 
            // infoButtonColumn
            // 
            infoButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            infoButtonColumn.FillWeight = 30F;
            infoButtonColumn.HeaderText = "";
            infoButtonColumn.Image = Properties.Resources._003_info;
            infoButtonColumn.MinimumWidth = 6;
            infoButtonColumn.Name = "infoButtonColumn";
            infoButtonColumn.ReadOnly = true;
            infoButtonColumn.Width = 6;
            // 
            // editButtonColumn
            // 
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editButtonColumn.FillWeight = 30F;
            editButtonColumn.HeaderText = "";
            editButtonColumn.Image = Properties.Resources._002_pencil1;
            editButtonColumn.MinimumWidth = 6;
            editButtonColumn.Name = "editButtonColumn";
            editButtonColumn.ReadOnly = true;
            editButtonColumn.Width = 6;
            // 
            // deleteButtonColumn
            // 
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deleteButtonColumn.FillWeight = 30F;
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Image = Properties.Resources._001_bin;
            deleteButtonColumn.MinimumWidth = 6;
            deleteButtonColumn.Name = "deleteButtonColumn";
            deleteButtonColumn.ReadOnly = true;
            deleteButtonColumn.Width = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(gioiTinhComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(trangThaiComboBox);
            panel1.Controls.Add(timKiemTextBox);
            panel1.Controls.Add(xoaTatCaButton);
            panel1.Controls.Add(timKiemButton);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(themMoiButton);
            panel1.Controls.Add(xuatExcelButton);
            panel1.Controls.Add(phanQuyenComboBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 125);
            panel1.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(343, 9);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 99;
            label3.Text = "Giới tính";
            // 
            // gioiTinhComboBox
            // 
            gioiTinhComboBox.BackColor = Color.Transparent;
            gioiTinhComboBox.CustomizableEdges = customizableEdges1;
            gioiTinhComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            gioiTinhComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            gioiTinhComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            gioiTinhComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gioiTinhComboBox.Font = new Font("Segoe UI", 10F);
            gioiTinhComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            gioiTinhComboBox.ItemHeight = 30;
            gioiTinhComboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioiTinhComboBox.Location = new Point(343, 34);
            gioiTinhComboBox.Name = "gioiTinhComboBox";
            gioiTinhComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gioiTinhComboBox.Size = new Size(168, 36);
            gioiTinhComboBox.TabIndex = 98;
            gioiTinhComboBox.SelectionChangeCommitted += gioiTinhComboBox_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(169, 8);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 97;
            label2.Text = "Phân quyền";
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.BackColor = Color.Transparent;
            trangThaiComboBox.CustomizableEdges = customizableEdges3;
            trangThaiComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            trangThaiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trangThaiComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            trangThaiComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            trangThaiComboBox.Font = new Font("Segoe UI", 10F);
            trangThaiComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            trangThaiComboBox.ItemHeight = 30;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang hoạt động", "Tạm đình chỉ", "Đã xóa" });
            trangThaiComboBox.Location = new Point(15, 34);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            trangThaiComboBox.Size = new Size(148, 36);
            trangThaiComboBox.StartIndex = 0;
            trangThaiComboBox.TabIndex = 96;
            trangThaiComboBox.SelectionChangeCommitted += trangThaiComboBox_SelectionChangeCommitted;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges5;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 12F);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(14, 78);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            timKiemTextBox.Size = new Size(815, 36);
            timKiemTextBox.TabIndex = 95;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // xoaTatCaButton
            // 
            xoaTatCaButton.BackColor = Color.IndianRed;
            xoaTatCaButton.FlatAppearance.BorderSize = 0;
            xoaTatCaButton.FlatStyle = FlatStyle.Flat;
            xoaTatCaButton.Font = new Font("Microsoft Sans Serif", 12F);
            xoaTatCaButton.ForeColor = Color.White;
            xoaTatCaButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            xoaTatCaButton.IconColor = Color.White;
            xoaTatCaButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xoaTatCaButton.IconSize = 20;
            xoaTatCaButton.ImageAlign = ContentAlignment.MiddleLeft;
            xoaTatCaButton.Location = new Point(1056, 34);
            xoaTatCaButton.Name = "xoaTatCaButton";
            xoaTatCaButton.Size = new Size(115, 36);
            xoaTatCaButton.TabIndex = 94;
            xoaTatCaButton.Text = "Xoá tất cả ";
            xoaTatCaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xoaTatCaButton.UseVisualStyleBackColor = false;
            xoaTatCaButton.Visible = false;
            xoaTatCaButton.Click += xoaTatCaButton_Click;
            // 
            // timKiemButton
            // 
            timKiemButton.BackColor = Color.FromArgb(226, 153, 48);
            timKiemButton.FlatAppearance.BorderSize = 0;
            timKiemButton.FlatStyle = FlatStyle.Flat;
            timKiemButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            timKiemButton.IconColor = Color.White;
            timKiemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            timKiemButton.IconSize = 20;
            timKiemButton.Location = new Point(837, 78);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 90;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // lamMoiButton
            // 
            lamMoiButton.BackColor = Color.FromArgb(33, 31, 48);
            lamMoiButton.FlatAppearance.BorderSize = 0;
            lamMoiButton.FlatStyle = FlatStyle.Flat;
            lamMoiButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            lamMoiButton.IconColor = Color.White;
            lamMoiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            lamMoiButton.IconSize = 20;
            lamMoiButton.Location = new Point(886, 78);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 93;
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(15, 8);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 91;
            label1.Text = "Trạng thái";
            // 
            // themMoiButton
            // 
            themMoiButton.BackColor = Color.FromArgb(226, 153, 48);
            themMoiButton.FlatAppearance.BorderSize = 0;
            themMoiButton.FlatStyle = FlatStyle.Flat;
            themMoiButton.Font = new Font("Microsoft Sans Serif", 12F);
            themMoiButton.ForeColor = Color.White;
            themMoiButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            themMoiButton.IconColor = Color.White;
            themMoiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            themMoiButton.IconSize = 20;
            themMoiButton.ImageAlign = ContentAlignment.MiddleLeft;
            themMoiButton.Location = new Point(1056, 78);
            themMoiButton.Name = "themMoiButton";
            themMoiButton.Size = new Size(115, 36);
            themMoiButton.TabIndex = 88;
            themMoiButton.Text = "Thêm mới";
            themMoiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiButton.UseVisualStyleBackColor = false;
            themMoiButton.Click += themMoiButton_Click;
            // 
            // xuatExcelButton
            // 
            xuatExcelButton.BackColor = Color.FromArgb(33, 31, 48);
            xuatExcelButton.FlatAppearance.BorderSize = 0;
            xuatExcelButton.FlatStyle = FlatStyle.Flat;
            xuatExcelButton.Font = new Font("Microsoft Sans Serif", 12F);
            xuatExcelButton.ForeColor = Color.White;
            xuatExcelButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            xuatExcelButton.IconColor = Color.White;
            xuatExcelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatExcelButton.IconSize = 20;
            xuatExcelButton.ImageAlign = ContentAlignment.MiddleLeft;
            xuatExcelButton.Location = new Point(935, 78);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(115, 36);
            xuatExcelButton.TabIndex = 89;
            xuatExcelButton.Text = "Xuất excel";
            xuatExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xuatExcelButton.UseVisualStyleBackColor = false;
            xuatExcelButton.Click += xuatExcelButton_Click;
            // 
            // phanQuyenComboBox
            // 
            phanQuyenComboBox.BackColor = Color.Transparent;
            phanQuyenComboBox.CustomizableEdges = customizableEdges7;
            phanQuyenComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            phanQuyenComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            phanQuyenComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            phanQuyenComboBox.Font = new Font("Segoe UI", 10F);
            phanQuyenComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            phanQuyenComboBox.ItemHeight = 30;
            phanQuyenComboBox.Location = new Point(169, 34);
            phanQuyenComboBox.Name = "phanQuyenComboBox";
            phanQuyenComboBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            phanQuyenComboBox.Size = new Size(168, 36);
            phanQuyenComboBox.TabIndex = 87;
            phanQuyenComboBox.SelectionChangeCommitted += phanQuyenComboBox_SelectionChangeCommitted;
            // 
            // phanQuyenBindingSource
            // 
            phanQuyenBindingSource.DataSource = typeof(DTO.PhanQuyen);
            // 
            // NguoiDungForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1183, 821);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "NguoiDungForm";
            Text = "NhanVienForm";
            Load += NguoiDungForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nguoiDungDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)phanQuyenBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView nguoiDungDataGridView;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private FontAwesome.Sharp.IconButton xoaTatCaButton;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private Label label1;
        private FontAwesome.Sharp.IconButton themMoiButton;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
        private Guna.UI2.WinForms.Guna2ComboBox phanQuyenComboBox;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn maNguoiDungColumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn tenDangNhapColumn;
        private DataGridViewTextBoxColumn hoTenColumn;
        private DataGridViewTextBoxColumn gioiTinhColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewImageColumn infoButtonColumn;
        private DataGridViewImageColumn editButtonColumn;
        private DataGridViewImageColumn deleteButtonColumn;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox trangThaiComboBox;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox gioiTinhComboBox;
        private BindingSource phanQuyenBindingSource;
    }
}