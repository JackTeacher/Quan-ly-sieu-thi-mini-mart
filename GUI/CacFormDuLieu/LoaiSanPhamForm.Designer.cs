namespace GUI
{
    partial class LoaiSanPhamForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            xoaTatCaButton = new FontAwesome.Sharp.IconButton();
            trangThaiComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            loaiSanPhamDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            maLoaiSanPhamColumn = new DataGridViewTextBoxColumn();
            tenLoaiSanPhamColumn = new DataGridViewTextBoxColumn();
            trangThaiColumn = new DataGridViewTextBoxColumn();
            infoButtonColumn = new DataGridViewImageColumn();
            editButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn = new DataGridViewImageColumn();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            timKiemButton.Location = new Point(662, 54);
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
            xuatExcelButton.Location = new Point(881, 53);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(116, 36);
            xuatExcelButton.TabIndex = 31;
            xuatExcelButton.Text = "Xuất Excel";
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
            themMoiButton.Location = new Point(760, 54);
            themMoiButton.Name = "themMoiButton";
            themMoiButton.Size = new Size(115, 36);
            themMoiButton.TabIndex = 30;
            themMoiButton.Text = "Thêm mới";
            themMoiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiButton.UseVisualStyleBackColor = false;
            themMoiButton.Click += themMoiButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(trangThaiComboBox);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(lamMoiButton);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(xuatExcelButton);
            panel2.Controls.Add(themMoiButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1167, 104);
            panel2.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.ForeColor = Color.FromArgb(0, 79, 111);
            label1.Location = new Point(242, 22);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 76;
            label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.ForeColor = Color.FromArgb(0, 79, 111);
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 75;
            label2.Text = "Trạng thái";
            // 
            // panel4
            // 
            panel4.Controls.Add(xoaTatCaButton);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1003, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(164, 104);
            panel4.TabIndex = 74;
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
            xoaTatCaButton.Location = new Point(25, 51);
            xoaTatCaButton.Name = "xoaTatCaButton";
            xoaTatCaButton.Size = new Size(115, 36);
            xoaTatCaButton.TabIndex = 71;
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
            trangThaiComboBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trangThaiComboBox.ForeColor = Color.FromArgb(0, 79, 111);
            trangThaiComboBox.ItemHeight = 30;
            trangThaiComboBox.Items.AddRange(new object[] { "Đang sử dụng", "Đã xóa" });
            trangThaiComboBox.Location = new Point(12, 51);
            trangThaiComboBox.Name = "trangThaiComboBox";
            trangThaiComboBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            trangThaiComboBox.Size = new Size(222, 36);
            trangThaiComboBox.TabIndex = 72;
            trangThaiComboBox.SelectionChangeCommitted += trangThaiComboBox_SelectionChangeCommitted;
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
            timKiemTextBox.Font = new Font("Segoe UI", 12F);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(242, 51);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            timKiemTextBox.Size = new Size(412, 38);
            timKiemTextBox.TabIndex = 70;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
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
            lamMoiButton.Location = new Point(711, 54);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 68;
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(loaiSanPhamDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(1167, 678);
            panel3.TabIndex = 29;
            // 
            // loaiSanPhamDataGridView
            // 
            loaiSanPhamDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            loaiSanPhamDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            loaiSanPhamDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            loaiSanPhamDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            loaiSanPhamDataGridView.ColumnHeadersHeight = 40;
            loaiSanPhamDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            loaiSanPhamDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, maLoaiSanPhamColumn, tenLoaiSanPhamColumn, trangThaiColumn, infoButtonColumn, editButtonColumn, deleteButtonColumn });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            loaiSanPhamDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            loaiSanPhamDataGridView.Dock = DockStyle.Fill;
            loaiSanPhamDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            loaiSanPhamDataGridView.Location = new Point(0, 0);
            loaiSanPhamDataGridView.Name = "loaiSanPhamDataGridView";
            loaiSanPhamDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            loaiSanPhamDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            loaiSanPhamDataGridView.RowHeadersVisible = false;
            loaiSanPhamDataGridView.RowTemplate.DividerHeight = 3;
            loaiSanPhamDataGridView.RowTemplate.Height = 50;
            loaiSanPhamDataGridView.Size = new Size(1167, 678);
            loaiSanPhamDataGridView.TabIndex = 28;
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            loaiSanPhamDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            loaiSanPhamDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            loaiSanPhamDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            loaiSanPhamDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            loaiSanPhamDataGridView.ThemeStyle.ReadOnly = true;
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.Height = 50;
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            loaiSanPhamDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            loaiSanPhamDataGridView.CellContentClick += loaiSanPhamDataGridView_CellContentClick;
            loaiSanPhamDataGridView.CellFormatting += loaiSanPhamDataGridView_CellFormatting;
            loaiSanPhamDataGridView.CellPainting += loaiSanPhamDataGridView_CellPainting;
            loaiSanPhamDataGridView.SelectionChanged += loaiSanPhamDataGridView_SelectionChanged;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "#";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 43;
            // 
            // maLoaiSanPhamColumn
            // 
            maLoaiSanPhamColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maLoaiSanPhamColumn.FillWeight = 129.305817F;
            maLoaiSanPhamColumn.HeaderText = "Mã loại sản phẩm ";
            maLoaiSanPhamColumn.Name = "maLoaiSanPhamColumn";
            maLoaiSanPhamColumn.ReadOnly = true;
            maLoaiSanPhamColumn.Resizable = DataGridViewTriState.True;
            // 
            // tenLoaiSanPhamColumn
            // 
            tenLoaiSanPhamColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenLoaiSanPhamColumn.FillWeight = 155.167023F;
            tenLoaiSanPhamColumn.HeaderText = "Tên loại sản phẩm ";
            tenLoaiSanPhamColumn.Name = "tenLoaiSanPhamColumn";
            tenLoaiSanPhamColumn.ReadOnly = true;
            // 
            // trangThaiColumn
            // 
            trangThaiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            trangThaiColumn.FillWeight = 155.167023F;
            trangThaiColumn.HeaderText = "Trạng thái";
            trangThaiColumn.Name = "trangThaiColumn";
            trangThaiColumn.ReadOnly = true;
            // 
            // infoButtonColumn
            // 
            infoButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            infoButtonColumn.FillWeight = 30F;
            infoButtonColumn.HeaderText = "";
            infoButtonColumn.Image = Properties.Resources._003_info1;
            infoButtonColumn.Name = "infoButtonColumn";
            infoButtonColumn.ReadOnly = true;
            infoButtonColumn.Width = 5;
            // 
            // editButtonColumn
            // 
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editButtonColumn.FillWeight = 30F;
            editButtonColumn.HeaderText = "";
            editButtonColumn.Image = Properties.Resources._002_pencil1;
            editButtonColumn.Name = "editButtonColumn";
            editButtonColumn.ReadOnly = true;
            editButtonColumn.Width = 5;
            // 
            // deleteButtonColumn
            // 
            deleteButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deleteButtonColumn.FillWeight = 30F;
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Image = Properties.Resources._001_bin;
            deleteButtonColumn.Name = "deleteButtonColumn";
            deleteButtonColumn.ReadOnly = true;
            deleteButtonColumn.Width = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 782);
            panel1.TabIndex = 2;
            // 
            // LoaiSanPhamForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1167, 782);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 14.25F);
            Margin = new Padding(5);
            Name = "LoaiSanPhamForm";
            Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            Load += LoaiSanPhamForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loaiSanPhamDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
        private FontAwesome.Sharp.IconButton themMoiButton;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView loaiSanPhamDataGridView;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private FontAwesome.Sharp.IconButton xoaTatCaButton;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn maLoaiSanPhamColumn;
        private DataGridViewTextBoxColumn tenLoaiSanPhamColumn;
        private DataGridViewTextBoxColumn trangThaiColumn;
        private DataGridViewImageColumn infoButtonColumn;
        private DataGridViewImageColumn editButtonColumn;
        private DataGridViewImageColumn deleteButtonColumn;
        private Guna.UI2.WinForms.Guna2ComboBox trangThaiComboBox;
        private Panel panel4;
        private Label label2;
        private Label label1;
    }
}