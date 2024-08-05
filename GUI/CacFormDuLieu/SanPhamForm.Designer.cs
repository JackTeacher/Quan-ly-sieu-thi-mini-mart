namespace GUI
{
    partial class SanPhamForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            sanPhamDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            panel4 = new Panel();
            xoaTatCaButton = new FontAwesome.Sharp.IconButton();
            trangThaiComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            sapXepComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            loaiSanPhamComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            Column2 = new DataGridViewTextBoxColumn();
            maSanPhamColumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            infoButtonColumn = new DataGridViewImageColumn();
            editButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sanPhamDataGridView).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 821);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(sanPhamDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 689);
            panel3.TabIndex = 29;
            // 
            // sanPhamDataGridView
            // 
            sanPhamDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            sanPhamDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            sanPhamDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            sanPhamDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            sanPhamDataGridView.ColumnHeadersHeight = 40;
            sanPhamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            sanPhamDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, maSanPhamColumn, Column3, Column4, Column6, Column7, Column8, Column5, infoButtonColumn, editButtonColumn, deleteButtonColumn });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            sanPhamDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            sanPhamDataGridView.Dock = DockStyle.Fill;
            sanPhamDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            sanPhamDataGridView.Location = new Point(0, 0);
            sanPhamDataGridView.Name = "sanPhamDataGridView";
            sanPhamDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            sanPhamDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            sanPhamDataGridView.RowHeadersVisible = false;
            sanPhamDataGridView.RowHeadersWidth = 62;
            sanPhamDataGridView.RowTemplate.DividerHeight = 3;
            sanPhamDataGridView.RowTemplate.Height = 50;
            sanPhamDataGridView.Size = new Size(1183, 689);
            sanPhamDataGridView.TabIndex = 28;
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            sanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            sanPhamDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            sanPhamDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            sanPhamDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            sanPhamDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            sanPhamDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            sanPhamDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            sanPhamDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            sanPhamDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            sanPhamDataGridView.ThemeStyle.ReadOnly = true;
            sanPhamDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            sanPhamDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            sanPhamDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            sanPhamDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            sanPhamDataGridView.ThemeStyle.RowsStyle.Height = 50;
            sanPhamDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            sanPhamDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            sanPhamDataGridView.CellContentClick += sanPhamDataGridView_CellContentClick;
            sanPhamDataGridView.CellFormatting += sanPhamDataGridView_CellFormatting;
            sanPhamDataGridView.CellPainting += sanPhamDataGridView_CellPainting;
            sanPhamDataGridView.SelectionChanged += sanPhamDataGridView_SelectionChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(trangThaiComboBox);
            panel2.Controls.Add(lamMoiButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(xuatExcelButton);
            panel2.Controls.Add(themMoiButton);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(sapXepComboBox);
            panel2.Controls.Add(loaiSanPhamComboBox);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Microsoft Sans Serif", 14.25F);
            panel2.ForeColor = Color.FromArgb(0, 79, 111);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 132);
            panel2.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.Controls.Add(xoaTatCaButton);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1011, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(172, 132);
            panel4.TabIndex = 66;
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
            xoaTatCaButton.Location = new Point(54, 84);
            xoaTatCaButton.Name = "xoaTatCaButton";
            xoaTatCaButton.Size = new Size(115, 36);
            xoaTatCaButton.TabIndex = 37;
            xoaTatCaButton.Text = "Xoá tất cả ";
            xoaTatCaButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xoaTatCaButton.UseVisualStyleBackColor = false;
            xoaTatCaButton.Visible = false;
            xoaTatCaButton.Click += xoaTatCaButton_Click;
            // 
            // trangThaiComboBox
            // 
            trangThaiComboBox.BackColor = Color.Transparent;
            trangThaiComboBox.CustomizableEdges = customizableEdges1;
            trangThaiComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            trangThaiComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            trangThaiComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            trangThaiComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            trangThaiComboBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            trangThaiComboBox.ForeColor = Color.FromArgb(0, 79, 111);
            trangThaiComboBox.ItemHeight = 30;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang bán", "Chờ xử lý", "Hết hàng", "Ngừng kinh doanh" });
            trangThaiComboBox.Location = new Point(16, 36);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            trangThaiComboBox.Size = new Size(216, 36);
            trangThaiComboBox.TabIndex = 65;
            trangThaiComboBox.SelectionChangeCommitted += trangThaiComboBox_SelectionChangeCommitted;
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
            lamMoiButton.Location = new Point(962, 83);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 64;
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.ForeColor = Color.FromArgb(0, 79, 111);
            label3.Location = new Point(541, 9);
            label3.Name = "label3";
            label3.Size = new Size(80, 24);
            label3.TabIndex = 35;
            label3.Text = "Sắp xếp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.ForeColor = Color.FromArgb(0, 79, 111);
            label2.Location = new Point(238, 9);
            label2.Name = "label2";
            label2.Size = new Size(133, 24);
            label2.TabIndex = 34;
            label2.Text = "Loại sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.ForeColor = Color.FromArgb(0, 79, 111);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 33;
            label1.Text = "Trạng thái";
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
            timKiemButton.Location = new Point(913, 83);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 32;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
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
            xuatExcelButton.Location = new Point(890, 36);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(115, 36);
            xuatExcelButton.TabIndex = 31;
            xuatExcelButton.Text = "Xuất excel";
            xuatExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xuatExcelButton.UseVisualStyleBackColor = false;
            xuatExcelButton.Click += xuatExcelButton_Click;
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
            themMoiButton.Location = new Point(769, 36);
            themMoiButton.Name = "themMoiButton";
            themMoiButton.Size = new Size(115, 36);
            themMoiButton.TabIndex = 30;
            themMoiButton.Text = "Thêm mới";
            themMoiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiButton.UseVisualStyleBackColor = false;
            themMoiButton.Click += themMoiButton_Click;
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges3;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(16, 83);
            timKiemTextBox.Margin = new Padding(5, 5, 5, 5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            timKiemTextBox.Size = new Size(889, 36);
            timKiemTextBox.TabIndex = 29;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // sapXepComboBox
            // 
            sapXepComboBox.BackColor = Color.Transparent;
            sapXepComboBox.CustomizableEdges = customizableEdges5;
            sapXepComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            sapXepComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sapXepComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            sapXepComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            sapXepComboBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            sapXepComboBox.ForeColor = Color.FromArgb(0, 79, 111);
            sapXepComboBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            sapXepComboBox.ItemHeight = 30;
            sapXepComboBox.Items.AddRange(new object[] { "Giá tăng dần", "Giá giảm dần", "Số lượng tăng dần", "Số lượng giảm dần" });
            sapXepComboBox.Location = new Point(541, 36);
            sapXepComboBox.Name = "sapXepComboBox";
            sapXepComboBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            sapXepComboBox.Size = new Size(222, 36);
            sapXepComboBox.TabIndex = 28;
            sapXepComboBox.SelectionChangeCommitted += sapXepComboBox_SelectionChangeCommitted;
            // 
            // loaiSanPhamComboBox
            // 
            loaiSanPhamComboBox.BackColor = Color.Transparent;
            loaiSanPhamComboBox.CustomizableEdges = customizableEdges7;
            loaiSanPhamComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            loaiSanPhamComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            loaiSanPhamComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            loaiSanPhamComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            loaiSanPhamComboBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            loaiSanPhamComboBox.ForeColor = Color.FromArgb(0, 79, 111);
            loaiSanPhamComboBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            loaiSanPhamComboBox.ItemHeight = 30;
            loaiSanPhamComboBox.Location = new Point(238, 36);
            loaiSanPhamComboBox.Name = "loaiSanPhamComboBox";
            loaiSanPhamComboBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            loaiSanPhamComboBox.Size = new Size(297, 36);
            loaiSanPhamComboBox.TabIndex = 27;
            loaiSanPhamComboBox.SelectionChangeCommitted += loaiSanPhamComboBox_SelectionChangeCommitted;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "#";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 43;
            // 
            // maSanPhamColumn
            // 
            maSanPhamColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maSanPhamColumn.FillWeight = 129.305817F;
            maSanPhamColumn.HeaderText = "Mã sản phẩm";
            maSanPhamColumn.MinimumWidth = 8;
            maSanPhamColumn.Name = "maSanPhamColumn";
            maSanPhamColumn.ReadOnly = true;
            maSanPhamColumn.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 155.167023F;
            Column3.HeaderText = "Tên sản phẩm";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 155.167023F;
            Column4.HeaderText = "Loại sản phẩm";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle4;
            Column6.FillWeight = 64.65291F;
            Column6.HeaderText = "Đơn vị ";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column7.DefaultCellStyle = dataGridViewCellStyle5;
            Column7.FillWeight = 103.444656F;
            Column7.HeaderText = "Số lượng ";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column8.DefaultCellStyle = dataGridViewCellStyle6;
            Column8.FillWeight = 129.305817F;
            Column8.HeaderText = "Giá bán ";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 155.167023F;
            Column5.HeaderText = "Trạng thái";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // infoButtonColumn
            // 
            infoButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            infoButtonColumn.FillWeight = 30F;
            infoButtonColumn.HeaderText = "";
            infoButtonColumn.Image = Properties.Resources._003_info;
            infoButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            infoButtonColumn.MinimumWidth = 8;
            infoButtonColumn.Name = "infoButtonColumn";
            infoButtonColumn.ReadOnly = true;
            infoButtonColumn.Width = 8;
            // 
            // editButtonColumn
            // 
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editButtonColumn.FillWeight = 30F;
            editButtonColumn.HeaderText = "";
            editButtonColumn.Image = Properties.Resources._002_pencil1;
            editButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editButtonColumn.MinimumWidth = 8;
            editButtonColumn.Name = "editButtonColumn";
            editButtonColumn.ReadOnly = true;
            editButtonColumn.Width = 8;
            // 
            // deleteButtonColumn
            // 
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deleteButtonColumn.FillWeight = 30F;
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Image = Properties.Resources._001_bin;
            deleteButtonColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteButtonColumn.MinimumWidth = 8;
            deleteButtonColumn.Name = "deleteButtonColumn";
            deleteButtonColumn.ReadOnly = true;
            deleteButtonColumn.Width = 8;
            // 
            // SanPhamForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1183, 821);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 14.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "SanPhamForm";
            Text = "QUẢN LÝ SẢN PHẨM";
            Load += SanPhamForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sanPhamDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView sanPhamDataGridView;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private FontAwesome.Sharp.IconButton xoaTatCaButton;
        private Label label3;
        private Label label2;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
        private FontAwesome.Sharp.IconButton themMoiButton;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox sapXepComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox loaiSanPhamComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox trangThaiComboBox;
        private Label label1;
        private Panel panel4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn maSanPhamColumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn infoButtonColumn;
        private DataGridViewImageColumn editButtonColumn;
        private DataGridViewImageColumn deleteButtonColumn;
    }
}