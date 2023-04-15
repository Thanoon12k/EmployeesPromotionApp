<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_thanks
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_thanks))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mylabel9 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.timeadd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.order_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.record_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.filter_text = New System.Windows.Forms.TextBox()
        Me.filter_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.record_text = New System.Windows.Forms.TextBox()
        Me.datepicker = New System.Windows.Forms.DateTimePicker()
        Me.notes_text = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.order_text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Form2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Form2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Form2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1046, 115)
        Me.Panel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(463, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 31)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "التشكرات"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.mylabel9)
        Me.Panel2.Controls.Add(Me.dgv)
        Me.Panel2.Controls.Add(Me.delete_btn)
        Me.Panel2.Controls.Add(Me.filter_text)
        Me.Panel2.Controls.Add(Me.filter_btn)
        Me.Panel2.Controls.Add(Me.add_btn)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.record_text)
        Me.Panel2.Controls.Add(Me.datepicker)
        Me.Panel2.Controls.Add(Me.notes_text)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.order_text)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel2.Location = New System.Drawing.Point(0, 115)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1046, 524)
        Me.Panel2.TabIndex = 1
        '
        'mylabel9
        '
        Me.mylabel9.AutoSize = True
        Me.mylabel9.Location = New System.Drawing.Point(430, 191)
        Me.mylabel9.Name = "mylabel9"
        Me.mylabel9.Size = New System.Drawing.Size(40, 23)
        Me.mylabel9.TabIndex = 65
        Me.mylabel9.Text = "ddd"
        Me.mylabel9.Visible = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.timeadd, Me.ID, Me.order_num, Me.record_num, Me.notes})
        Me.dgv.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgv.Location = New System.Drawing.Point(29, 117)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.Size = New System.Drawing.Size(364, 303)
        Me.dgv.TabIndex = 64
        '
        'timeadd
        '
        Me.timeadd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.timeadd.HeaderText = "التاريخ"
        Me.timeadd.MinimumWidth = 75
        Me.timeadd.Name = "timeadd"
        Me.timeadd.ReadOnly = True
        Me.timeadd.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.timeadd.Width = 79
        '
        'ID
        '
        Me.ID.HeaderText = "*ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 66
        '
        'order_num
        '
        Me.order_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.order_num.HeaderText = "رقم الأمر"
        Me.order_num.Name = "order_num"
        Me.order_num.ReadOnly = True
        Me.order_num.Width = 96
        '
        'record_num
        '
        Me.record_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.record_num.HeaderText = " رقم القيد"
        Me.record_num.MinimumWidth = 10
        Me.record_num.Name = "record_num"
        Me.record_num.ReadOnly = True
        Me.record_num.Width = 94
        '
        'notes
        '
        Me.notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.notes.HeaderText = "  ملاحظات        "
        Me.notes.Name = "notes"
        Me.notes.ReadOnly = True
        Me.notes.Width = 149
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.Red
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.delete_btn.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.delete_btn.Location = New System.Drawing.Point(279, 460)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(114, 37)
        Me.delete_btn.TabIndex = 63
        Me.delete_btn.Text = "حذف"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'filter_text
        '
        Me.filter_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.filter_text.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.filter_text.Location = New System.Drawing.Point(34, 58)
        Me.filter_text.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.filter_text.Name = "filter_text"
        Me.filter_text.Size = New System.Drawing.Size(235, 32)
        Me.filter_text.TabIndex = 62
        Me.filter_text.Text = "رقم القيد"
        Me.filter_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'filter_btn
        '
        Me.filter_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.filter_btn.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.filter_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.filter_btn.Location = New System.Drawing.Point(279, 58)
        Me.filter_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.filter_btn.Name = "filter_btn"
        Me.filter_btn.Size = New System.Drawing.Size(114, 37)
        Me.filter_btn.TabIndex = 61
        Me.filter_btn.Text = "بحث"
        Me.filter_btn.UseVisualStyleBackColor = False
        '
        'add_btn
        '
        Me.add_btn.BackColor = System.Drawing.Color.Crimson
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add_btn.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.add_btn.Location = New System.Drawing.Point(899, 460)
        Me.add_btn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(114, 37)
        Me.add_btn.TabIndex = 59
        Me.add_btn.Text = "تصدير"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(819, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "رقم القيد"
        '
        'record_text
        '
        Me.record_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.record_text.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.record_text.Location = New System.Drawing.Point(533, 147)
        Me.record_text.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.record_text.Name = "record_text"
        Me.record_text.Size = New System.Drawing.Size(274, 32)
        Me.record_text.TabIndex = 1
        '
        'datepicker
        '
        Me.datepicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepicker.Location = New System.Drawing.Point(533, 24)
        Me.datepicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.datepicker.Name = "datepicker"
        Me.datepicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.datepicker.Size = New System.Drawing.Size(274, 26)
        Me.datepicker.TabIndex = 39
        '
        'notes_text
        '
        Me.notes_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.notes_text.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.notes_text.Location = New System.Drawing.Point(533, 248)
        Me.notes_text.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.notes_text.Multiline = True
        Me.notes_text.Name = "notes_text"
        Me.notes_text.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.notes_text.Size = New System.Drawing.Size(274, 92)
        Me.notes_text.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(831, 248)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "ملاحظات"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(825, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "رقم الامر "
        '
        'order_text
        '
        Me.order_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.order_text.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.order_text.Location = New System.Drawing.Point(533, 90)
        Me.order_text.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.order_text.Name = "order_text"
        Me.order_text.Size = New System.Drawing.Size(274, 32)
        Me.order_text.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(831, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "التاريخ"
        '
        'Form2BindingSource
        '
        Me.Form2BindingSource.DataSource = GetType(employee1.form_thanks)
        '
        'Form2BindingSource1
        '
        Me.Form2BindingSource1.DataSource = GetType(employee1.form_thanks)
        '
        'form_thanks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 639)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximumSize = New System.Drawing.Size(1062, 678)
        Me.MinimumSize = New System.Drawing.Size(1062, 678)
        Me.Name = "form_thanks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "التشكرات"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Form2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents notes_text As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents order_text As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents datepicker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents record_text As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents add_btn As Button
    Friend WithEvents filter_text As TextBox
    Friend WithEvents filter_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents Form2BindingSource As BindingSource
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Form2BindingSource1 As BindingSource
    Friend WithEvents mylabel9 As Label
    Friend WithEvents timeadd As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents order_num As DataGridViewTextBoxColumn
    Friend WithEvents record_num As DataGridViewTextBoxColumn
    Friend WithEvents notes As DataGridViewTextBoxColumn
End Class
