<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.record_num_filter_txt = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.employees_dgrv = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.record_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clear_employee_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.new_salary_txt = New System.Windows.Forms.TextBox()
        Me.new_class_txt = New System.Windows.Forms.TextBox()
        Me.new_rank_txt = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.record_type_cmp = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.edit_employee_btn = New System.Windows.Forms.Button()
        Me.delete_employee_btn = New System.Windows.Forms.Button()
        Me.save_employee_btn = New System.Windows.Forms.Button()
        Me.nots_txt = New System.Windows.Forms.TextBox()
        Me.next_promotiondt = New System.Windows.Forms.DateTimePicker()
        Me.next_risingdt = New System.Windows.Forms.DateTimePicker()
        Me.current_promotiondt = New System.Windows.Forms.DateTimePicker()
        Me.current_raisingdt = New System.Windows.Forms.DateTimePicker()
        Me.joiningdt = New System.Windows.Forms.DateTimePicker()
        Me.birthday_dte = New System.Windows.Forms.DateTimePicker()
        Me.salary_txt = New System.Windows.Forms.TextBox()
        Me.class_cmp = New System.Windows.Forms.ComboBox()
        Me.rank_cmp = New System.Windows.Forms.ComboBox()
        Me.study_cmp = New System.Windows.Forms.ComboBox()
        Me.name_txt = New System.Windows.Forms.TextBox()
        Me.record_num_txt = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.employees_dgrv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.record_num_filter_txt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 95)
        Me.Panel1.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label28.Location = New System.Drawing.Point(1157, 9)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 21)
        Me.Label28.TabIndex = 56
        Me.Label28.Text = "رقم القيد"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(1235, 35)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 30)
        Me.Button5.TabIndex = 57
        Me.Button5.Text = "بحث"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'record_num_filter_txt
        '
        Me.record_num_filter_txt.BackColor = System.Drawing.Color.Ivory
        Me.record_num_filter_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.record_num_filter_txt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.record_num_filter_txt.Location = New System.Drawing.Point(942, 38)
        Me.record_num_filter_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.record_num_filter_txt.Name = "record_num_filter_txt"
        Me.record_num_filter_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.record_num_filter_txt.Size = New System.Drawing.Size(274, 29)
        Me.record_num_filter_txt.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.employees_dgrv)
        Me.Panel2.Controls.Add(Me.clear_employee_btn)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.new_salary_txt)
        Me.Panel2.Controls.Add(Me.new_class_txt)
        Me.Panel2.Controls.Add(Me.new_rank_txt)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.record_type_cmp)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.edit_employee_btn)
        Me.Panel2.Controls.Add(Me.delete_employee_btn)
        Me.Panel2.Controls.Add(Me.save_employee_btn)
        Me.Panel2.Controls.Add(Me.nots_txt)
        Me.Panel2.Controls.Add(Me.next_promotiondt)
        Me.Panel2.Controls.Add(Me.next_risingdt)
        Me.Panel2.Controls.Add(Me.current_promotiondt)
        Me.Panel2.Controls.Add(Me.current_raisingdt)
        Me.Panel2.Controls.Add(Me.joiningdt)
        Me.Panel2.Controls.Add(Me.birthday_dte)
        Me.Panel2.Controls.Add(Me.salary_txt)
        Me.Panel2.Controls.Add(Me.class_cmp)
        Me.Panel2.Controls.Add(Me.rank_cmp)
        Me.Panel2.Controls.Add(Me.study_cmp)
        Me.Panel2.Controls.Add(Me.name_txt)
        Me.Panel2.Controls.Add(Me.record_num_txt)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel2.Location = New System.Drawing.Point(0, 95)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.MaximumSize = New System.Drawing.Size(1573, 680)
        Me.Panel2.MinimumSize = New System.Drawing.Size(1573, 680)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1573, 680)
        Me.Panel2.TabIndex = 1
        '
        'employees_dgrv
        '
        Me.employees_dgrv.AllowUserToAddRows = False
        Me.employees_dgrv.AllowUserToDeleteRows = False
        Me.employees_dgrv.AllowUserToResizeRows = False
        Me.employees_dgrv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.employees_dgrv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.employees_dgrv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.employees_dgrv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.employees_dgrv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employees_dgrv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.employees_dgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employees_dgrv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.record_num, Me.order_num})
        Me.employees_dgrv.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.employees_dgrv.Location = New System.Drawing.Point(12, 55)
        Me.employees_dgrv.Name = "employees_dgrv"
        Me.employees_dgrv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employees_dgrv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.employees_dgrv.RowHeadersVisible = False
        Me.employees_dgrv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.employees_dgrv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.employees_dgrv.RowTemplate.Height = 25
        Me.employees_dgrv.Size = New System.Drawing.Size(392, 495)
        Me.employees_dgrv.TabIndex = 71
        '
        'ID
        '
        Me.ID.HeaderText = "*ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 44
        '
        'record_num
        '
        Me.record_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.record_num.HeaderText = " رقم القيد"
        Me.record_num.MinimumWidth = 15
        Me.record_num.Name = "record_num"
        Me.record_num.ReadOnly = True
        Me.record_num.Width = 89
        '
        'order_num
        '
        Me.order_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.order_num.HeaderText = "الاسم"
        Me.order_num.MinimumWidth = 300
        Me.order_num.Name = "order_num"
        Me.order_num.ReadOnly = True
        Me.order_num.Width = 300
        '
        'clear_employee_btn
        '
        Me.clear_employee_btn.BackColor = System.Drawing.Color.LimeGreen
        Me.clear_employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clear_employee_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clear_employee_btn.Location = New System.Drawing.Point(802, 538)
        Me.clear_employee_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.clear_employee_btn.Name = "clear_employee_btn"
        Me.clear_employee_btn.Size = New System.Drawing.Size(114, 37)
        Me.clear_employee_btn.TabIndex = 70
        Me.clear_employee_btn.Text = "تفريغ"
        Me.clear_employee_btn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(273, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 26)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "قائمة الموظفين"
        '
        'new_salary_txt
        '
        Me.new_salary_txt.BackColor = System.Drawing.Color.IndianRed
        Me.new_salary_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.new_salary_txt.Enabled = False
        Me.new_salary_txt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.new_salary_txt.Location = New System.Drawing.Point(942, 491)
        Me.new_salary_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.new_salary_txt.Name = "new_salary_txt"
        Me.new_salary_txt.Size = New System.Drawing.Size(302, 29)
        Me.new_salary_txt.TabIndex = 63
        '
        'new_class_txt
        '
        Me.new_class_txt.BackColor = System.Drawing.Color.IndianRed
        Me.new_class_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.new_class_txt.Enabled = False
        Me.new_class_txt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.new_class_txt.Location = New System.Drawing.Point(942, 441)
        Me.new_class_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.new_class_txt.Name = "new_class_txt"
        Me.new_class_txt.Size = New System.Drawing.Size(302, 29)
        Me.new_class_txt.TabIndex = 62
        '
        'new_rank_txt
        '
        Me.new_rank_txt.BackColor = System.Drawing.Color.IndianRed
        Me.new_rank_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.new_rank_txt.Enabled = False
        Me.new_rank_txt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.new_rank_txt.Location = New System.Drawing.Point(942, 387)
        Me.new_rank_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.new_rank_txt.Name = "new_rank_txt"
        Me.new_rank_txt.Size = New System.Drawing.Size(302, 29)
        Me.new_rank_txt.TabIndex = 61
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(1254, 493)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 21)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "الراتب الجديد"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(1254, 443)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 21)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "الفئة الجديدة"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(1254, 389)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 21)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "الدرجة الجديدة"
        '
        'record_type_cmp
        '
        Me.record_type_cmp.BackColor = System.Drawing.Color.PaleGreen
        Me.record_type_cmp.FormattingEnabled = True
        Me.record_type_cmp.Items.AddRange(New Object() {"مستمر", "متوقف"})
        Me.record_type_cmp.Location = New System.Drawing.Point(942, 78)
        Me.record_type_cmp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.record_type_cmp.Name = "record_type_cmp"
        Me.record_type_cmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.record_type_cmp.Size = New System.Drawing.Size(302, 29)
        Me.record_type_cmp.TabIndex = 57
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1252, 78)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 21)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "نوع القيد"
        '
        'edit_employee_btn
        '
        Me.edit_employee_btn.BackColor = System.Drawing.Color.Yellow
        Me.edit_employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit_employee_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.edit_employee_btn.Location = New System.Drawing.Point(1079, 538)
        Me.edit_employee_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.edit_employee_btn.Name = "edit_employee_btn"
        Me.edit_employee_btn.Size = New System.Drawing.Size(114, 37)
        Me.edit_employee_btn.TabIndex = 55
        Me.edit_employee_btn.Text = "تعديل"
        Me.edit_employee_btn.UseVisualStyleBackColor = False
        '
        'delete_employee_btn
        '
        Me.delete_employee_btn.BackColor = System.Drawing.Color.Crimson
        Me.delete_employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete_employee_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.delete_employee_btn.Location = New System.Drawing.Point(938, 538)
        Me.delete_employee_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.delete_employee_btn.Name = "delete_employee_btn"
        Me.delete_employee_btn.Size = New System.Drawing.Size(114, 37)
        Me.delete_employee_btn.TabIndex = 54
        Me.delete_employee_btn.Text = "حذف"
        Me.delete_employee_btn.UseVisualStyleBackColor = False
        '
        'save_employee_btn
        '
        Me.save_employee_btn.BackColor = System.Drawing.Color.RoyalBlue
        Me.save_employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save_employee_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.save_employee_btn.Location = New System.Drawing.Point(1209, 538)
        Me.save_employee_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.save_employee_btn.Name = "save_employee_btn"
        Me.save_employee_btn.Size = New System.Drawing.Size(114, 37)
        Me.save_employee_btn.TabIndex = 53
        Me.save_employee_btn.Text = "حفظ"
        Me.save_employee_btn.UseVisualStyleBackColor = False
        '
        'nots_txt
        '
        Me.nots_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nots_txt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nots_txt.Location = New System.Drawing.Point(421, 291)
        Me.nots_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nots_txt.Multiline = True
        Me.nots_txt.Name = "nots_txt"
        Me.nots_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nots_txt.Size = New System.Drawing.Size(274, 181)
        Me.nots_txt.TabIndex = 51
        Me.nots_txt.Text = "-"
        '
        'next_promotiondt
        '
        Me.next_promotiondt.CalendarForeColor = System.Drawing.Color.IndianRed
        Me.next_promotiondt.CalendarMonthBackground = System.Drawing.Color.Snow
        Me.next_promotiondt.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.next_promotiondt.Enabled = False
        Me.next_promotiondt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.next_promotiondt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.next_promotiondt.Location = New System.Drawing.Point(421, 254)
        Me.next_promotiondt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.next_promotiondt.Name = "next_promotiondt"
        Me.next_promotiondt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.next_promotiondt.Size = New System.Drawing.Size(274, 26)
        Me.next_promotiondt.TabIndex = 42
        '
        'next_risingdt
        '
        Me.next_risingdt.CalendarForeColor = System.Drawing.Color.IndianRed
        Me.next_risingdt.CalendarMonthBackground = System.Drawing.Color.Snow
        Me.next_risingdt.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.next_risingdt.Enabled = False
        Me.next_risingdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.next_risingdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.next_risingdt.Location = New System.Drawing.Point(421, 200)
        Me.next_risingdt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.next_risingdt.Name = "next_risingdt"
        Me.next_risingdt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.next_risingdt.Size = New System.Drawing.Size(274, 26)
        Me.next_risingdt.TabIndex = 41
        '
        'current_promotiondt
        '
        Me.current_promotiondt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.current_promotiondt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.current_promotiondt.Location = New System.Drawing.Point(421, 142)
        Me.current_promotiondt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.current_promotiondt.Name = "current_promotiondt"
        Me.current_promotiondt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.current_promotiondt.Size = New System.Drawing.Size(274, 26)
        Me.current_promotiondt.TabIndex = 40
        '
        'current_raisingdt
        '
        Me.current_raisingdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.current_raisingdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.current_raisingdt.Location = New System.Drawing.Point(421, 97)
        Me.current_raisingdt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.current_raisingdt.Name = "current_raisingdt"
        Me.current_raisingdt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.current_raisingdt.Size = New System.Drawing.Size(274, 26)
        Me.current_raisingdt.TabIndex = 39
        '
        'joiningdt
        '
        Me.joiningdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.joiningdt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.joiningdt.Location = New System.Drawing.Point(421, 56)
        Me.joiningdt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.joiningdt.Name = "joiningdt"
        Me.joiningdt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.joiningdt.Size = New System.Drawing.Size(274, 26)
        Me.joiningdt.TabIndex = 38
        '
        'birthday_dte
        '
        Me.birthday_dte.CalendarMonthBackground = System.Drawing.Color.Honeydew
        Me.birthday_dte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.birthday_dte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthday_dte.Location = New System.Drawing.Point(942, 200)
        Me.birthday_dte.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.birthday_dte.Name = "birthday_dte"
        Me.birthday_dte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.birthday_dte.Size = New System.Drawing.Size(302, 26)
        Me.birthday_dte.TabIndex = 37
        '
        'salary_txt
        '
        Me.salary_txt.BackColor = System.Drawing.Color.IndianRed
        Me.salary_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salary_txt.Enabled = False
        Me.salary_txt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.salary_txt.Location = New System.Drawing.Point(942, 341)
        Me.salary_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.salary_txt.Name = "salary_txt"
        Me.salary_txt.Size = New System.Drawing.Size(302, 29)
        Me.salary_txt.TabIndex = 36
        '
        'class_cmp
        '
        Me.class_cmp.BackColor = System.Drawing.Color.PaleGreen
        Me.class_cmp.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.class_cmp.FormattingEnabled = True
        Me.class_cmp.Items.AddRange(New Object() {"الاولى", "الثانية", "الثالثة", "الرابعة", "الخامسة", "السادسة", "السابعة", "الثامنة", "التاسعة", "العاشرة", "الحادية عشر"})
        Me.class_cmp.Location = New System.Drawing.Point(942, 290)
        Me.class_cmp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.class_cmp.Name = "class_cmp"
        Me.class_cmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.class_cmp.Size = New System.Drawing.Size(302, 29)
        Me.class_cmp.TabIndex = 35
        '
        'rank_cmp
        '
        Me.rank_cmp.BackColor = System.Drawing.Color.PaleGreen
        Me.rank_cmp.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rank_cmp.FormattingEnabled = True
        Me.rank_cmp.Items.AddRange(New Object() {"الاولى", "الثانية", "الثالثة", "الرابعة", "الخامسة", "السادسة", "السابعة", "الثامنة", "التاسعة", "العاشرة"})
        Me.rank_cmp.Location = New System.Drawing.Point(942, 249)
        Me.rank_cmp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.rank_cmp.Name = "rank_cmp"
        Me.rank_cmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rank_cmp.Size = New System.Drawing.Size(302, 29)
        Me.rank_cmp.TabIndex = 34
        '
        'study_cmp
        '
        Me.study_cmp.BackColor = System.Drawing.Color.PaleGreen
        Me.study_cmp.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.study_cmp.FormattingEnabled = True
        Me.study_cmp.Items.AddRange(New Object() {"بكلوريوس", "ماجستير", "دكتوراة"})
        Me.study_cmp.Location = New System.Drawing.Point(942, 156)
        Me.study_cmp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.study_cmp.Name = "study_cmp"
        Me.study_cmp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.study_cmp.Size = New System.Drawing.Size(302, 29)
        Me.study_cmp.TabIndex = 29
        '
        'name_txt
        '
        Me.name_txt.BackColor = System.Drawing.Color.PaleGreen
        Me.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.name_txt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.name_txt.Location = New System.Drawing.Point(942, 113)
        Me.name_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.name_txt.Name = "name_txt"
        Me.name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.name_txt.Size = New System.Drawing.Size(302, 29)
        Me.name_txt.TabIndex = 27
        '
        'record_num_txt
        '
        Me.record_num_txt.BackColor = System.Drawing.Color.PaleGreen
        Me.record_num_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.record_num_txt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.record_num_txt.Location = New System.Drawing.Point(942, 32)
        Me.record_num_txt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.record_num_txt.Name = "record_num_txt"
        Me.record_num_txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.record_num_txt.Size = New System.Drawing.Size(302, 29)
        Me.record_num_txt.TabIndex = 26
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label26.Location = New System.Drawing.Point(1254, 343)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 21)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "الراتب"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label24.Location = New System.Drawing.Point(703, 298)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 21)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "ملاحظات"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label22.Location = New System.Drawing.Point(706, 257)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(193, 21)
        Me.Label22.TabIndex = 21
        Me.Label22.Text = "تاريخ الاستحقاق الجديد للترفيع"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label21.Location = New System.Drawing.Point(703, 203)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(191, 21)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "تاريخ الاستحقاق الجديد للعلاوة"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(703, 144)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 21)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "تاريخ الترفيع الحالي"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(703, 101)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 21)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "تاريخ العلاوة الحالية"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(720, 55)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 21)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "تاريخ المباشرة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(1254, 249)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "الدرجة الوظيفية"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(1252, 298)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "الفئة الوظيفية"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(1435, 250)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "الدرجة الوظيفية"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(1259, 203)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "التولد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1243, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "التحصيل الدراسي "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(1252, 121)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "الاسم الرباعي"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1252, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم القيد"
        '
        'formInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "formInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "استمارة الموظف"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.employees_dgrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nots_txt As TextBox
    Friend WithEvents next_promotiondt As DateTimePicker
    Friend WithEvents next_risingdt As DateTimePicker
    Friend WithEvents current_promotiondt As DateTimePicker
    Friend WithEvents current_raisingdt As DateTimePicker
    Friend WithEvents joiningdt As DateTimePicker
    Friend WithEvents birthday_dte As DateTimePicker
    Friend WithEvents salary_txt As TextBox
    Friend WithEvents class_cmp As ComboBox
    Friend WithEvents rank_cmp As ComboBox
    Friend WithEvents study_cmp As ComboBox
    Friend WithEvents name_txt As TextBox
    Friend WithEvents record_num_txt As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents save_employee_btn As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents recordNumFilter As TextBox
    Friend WithEvents edit_employee_btn As Button
    Friend WithEvents delete_employee_btn As Button
    Friend WithEvents new_salary_txt As TextBox
    Friend WithEvents new_class_txt As TextBox
    Friend WithEvents new_rank_txt As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents record_type_cmp As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents clear_employee_btn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents employees_dgrv As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents record_num As DataGridViewTextBoxColumn
    Friend WithEvents order_num As DataGridViewTextBoxColumn
    Friend WithEvents record_num_filter_txt As TextBox
End Class
