namespace GUI
{
    partial class HoaDonForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            hoaDonDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            maHoaDonColumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            infoButtonColumn = new DataGridViewImageColumn();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            thoiGianCheckBox = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            thoiGianKetThucDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            thoiGianBatDauDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hoaDonDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(hoaDonDataGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 89);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 732);
            panel2.TabIndex = 55;
            // 
            // hoaDonDataGridView
            // 
            hoaDonDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            hoaDonDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            hoaDonDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            hoaDonDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            hoaDonDataGridView.ColumnHeadersHeight = 40;
            hoaDonDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            hoaDonDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, maHoaDonColumn, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, infoButtonColumn });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            hoaDonDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            hoaDonDataGridView.Dock = DockStyle.Fill;
            hoaDonDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            hoaDonDataGridView.Location = new Point(0, 0);
            hoaDonDataGridView.Name = "hoaDonDataGridView";
            hoaDonDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            hoaDonDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            hoaDonDataGridView.RowHeadersVisible = false;
            hoaDonDataGridView.RowHeadersWidth = 51;
            hoaDonDataGridView.RowTemplate.DividerHeight = 3;
            hoaDonDataGridView.RowTemplate.Height = 50;
            hoaDonDataGridView.Size = new Size(1183, 732);
            hoaDonDataGridView.TabIndex = 51;
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            hoaDonDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            hoaDonDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            hoaDonDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            hoaDonDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            hoaDonDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            hoaDonDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            hoaDonDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            hoaDonDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            hoaDonDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            hoaDonDataGridView.ThemeStyle.ReadOnly = true;
            hoaDonDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            hoaDonDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            hoaDonDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            hoaDonDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            hoaDonDataGridView.ThemeStyle.RowsStyle.Height = 50;
            hoaDonDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            hoaDonDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            hoaDonDataGridView.CellContentClick += hoaDonDataGridView_CellContentClick;
            hoaDonDataGridView.CellFormatting += hoaDonDataGridView_CellFormatting;
            hoaDonDataGridView.CellPainting += hoaDonDataGridView_CellPainting;
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
            Column2.Width = 39;
            // 
            // maHoaDonColumn
            // 
            maHoaDonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maHoaDonColumn.HeaderText = "Mã hóa đơn";
            maHoaDonColumn.MinimumWidth = 6;
            maHoaDonColumn.Name = "maHoaDonColumn";
            maHoaDonColumn.ReadOnly = true;
            maHoaDonColumn.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Mã nhân viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 120F;
            Column4.HeaderText = "Mã khách hàng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.FillWeight = 120F;
            Column5.HeaderText = "Mã khuyến mãi";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle4;
            Column6.HeaderText = "Thời gian tạo";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column7.DefaultCellStyle = dataGridViewCellStyle5;
            Column7.FillWeight = 80F;
            Column7.HeaderText = "Tổng tiền";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column8.DefaultCellStyle = dataGridViewCellStyle6;
            Column8.HeaderText = "Chiết khấu ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.FillWeight = 80F;
            Column9.HeaderText = "Thành tiền";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.FillWeight = 80F;
            Column10.HeaderText = "Tiền nhận";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column11
            // 
            Column11.FillWeight = 80F;
            Column11.HeaderText = "Tiền thừa";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
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
            xuatExcelButton.Location = new Point(485, 35);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(114, 36);
            xuatExcelButton.TabIndex = 46;
            xuatExcelButton.Text = "Xuất excel";
            xuatExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xuatExcelButton.UseVisualStyleBackColor = false;
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
            timKiemButton.Location = new Point(385, 35);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 47;
            timKiemButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(thoiGianCheckBox);
            panel1.Controls.Add(thoiGianKetThucDateTimePicker);
            panel1.Controls.Add(thoiGianBatDauDateTimePicker);
            panel1.Controls.Add(guna2HtmlLabel5);
            panel1.Controls.Add(guna2HtmlLabel4);
            panel1.Controls.Add(timKiemTextBox);
            panel1.Controls.Add(lamMoiButton);
            panel1.Controls.Add(xuatExcelButton);
            panel1.Controls.Add(timKiemButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 89);
            panel1.TabIndex = 54;
            // 
            // thoiGianCheckBox
            // 
            thoiGianCheckBox.CheckedState.Image = (Image)resources.GetObject("resource.Image");
            thoiGianCheckBox.CheckedState.ImageSize = new Size(40, 40);
            thoiGianCheckBox.Image = (Image)resources.GetObject("thoiGianCheckBox.Image");
            thoiGianCheckBox.ImageOffset = new Point(0, 0);
            thoiGianCheckBox.ImageRotate = 0F;
            thoiGianCheckBox.ImageSize = new Size(40, 40);
            thoiGianCheckBox.Location = new Point(935, 35);
            thoiGianCheckBox.Name = "thoiGianCheckBox";
            thoiGianCheckBox.ShadowDecoration.CustomizableEdges = customizableEdges1;
            thoiGianCheckBox.Size = new Size(50, 50);
            thoiGianCheckBox.TabIndex = 97;
            // 
            // thoiGianKetThucDateTimePicker
            // 
            thoiGianKetThucDateTimePicker.Checked = true;
            thoiGianKetThucDateTimePicker.CustomizableEdges = customizableEdges2;
            thoiGianKetThucDateTimePicker.Font = new Font("Microsoft Sans Serif", 14.25F);
            thoiGianKetThucDateTimePicker.Format = DateTimePickerFormat.Short;
            thoiGianKetThucDateTimePicker.Location = new Point(769, 35);
            thoiGianKetThucDateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            thoiGianKetThucDateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            thoiGianKetThucDateTimePicker.Name = "thoiGianKetThucDateTimePicker";
            thoiGianKetThucDateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges3;
            thoiGianKetThucDateTimePicker.Size = new Size(160, 36);
            thoiGianKetThucDateTimePicker.TabIndex = 96;
            thoiGianKetThucDateTimePicker.Value = new DateTime(2023, 11, 30, 4, 24, 4, 22);
            // 
            // thoiGianBatDauDateTimePicker
            // 
            thoiGianBatDauDateTimePicker.Checked = true;
            thoiGianBatDauDateTimePicker.CustomizableEdges = customizableEdges4;
            thoiGianBatDauDateTimePicker.Font = new Font("Microsoft Sans Serif", 14.25F);
            thoiGianBatDauDateTimePicker.Format = DateTimePickerFormat.Short;
            thoiGianBatDauDateTimePicker.Location = new Point(603, 35);
            thoiGianBatDauDateTimePicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            thoiGianBatDauDateTimePicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            thoiGianBatDauDateTimePicker.Name = "thoiGianBatDauDateTimePicker";
            thoiGianBatDauDateTimePicker.ShadowDecoration.CustomizableEdges = customizableEdges5;
            thoiGianBatDauDateTimePicker.Size = new Size(160, 36);
            thoiGianBatDauDateTimePicker.TabIndex = 95;
            thoiGianBatDauDateTimePicker.Value = new DateTime(2023, 11, 30, 4, 23, 58, 417);
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Microsoft Sans Serif", 14.25F);
            guna2HtmlLabel5.ForeColor = Color.FromArgb(0, 79, 111);
            guna2HtmlLabel5.Location = new Point(769, 8);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(152, 26);
            guna2HtmlLabel5.TabIndex = 94;
            guna2HtmlLabel5.Text = "Thời gian kết thúc";
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Microsoft Sans Serif", 14.25F);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(0, 79, 111);
            guna2HtmlLabel4.Location = new Point(603, 8);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(150, 26);
            guna2HtmlLabel4.TabIndex = 93;
            guna2HtmlLabel4.Text = "Thời gian bắt đầu";
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges6;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 12F);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(5, 35);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges7;
            timKiemTextBox.Size = new Size(373, 36);
            timKiemTextBox.TabIndex = 87;
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
            lamMoiButton.Location = new Point(435, 35);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 66;
            lamMoiButton.UseVisualStyleBackColor = false;
            // 
            // HoaDonForm
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
            Name = "HoaDonForm";
            Text = "QUẢN LÝ HOÁ ĐƠN";
            Load += HoaDonForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hoaDonDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView hoaDonDataGridView;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Guna.UI2.WinForms.Guna2ImageCheckBox thoiGianCheckBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker thoiGianKetThucDateTimePicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker thoiGianBatDauDateTimePicker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn maHoaDonColumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewImageColumn infoButtonColumn;
    }
}