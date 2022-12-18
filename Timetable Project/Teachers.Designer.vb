<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teachers
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTeacherQuota = New System.Windows.Forms.TextBox()
        Me.lblTeacherQuota = New System.Windows.Forms.Label()
        Me.cboTeacherDepartment = New System.Windows.Forms.ComboBox()
        Me.txtTeacherLastName = New System.Windows.Forms.TextBox()
        Me.txtTeacherFirstName = New System.Windows.Forms.TextBox()
        Me.lblTeacherFirstName = New System.Windows.Forms.Label()
        Me.lblTeacherLastName = New System.Windows.Forms.Label()
        Me.lblTeacherDepartment = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtPR = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agent = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtTeacherQuota)
        Me.Panel1.Controls.Add(Me.lblTeacherQuota)
        Me.Panel1.Controls.Add(Me.cboTeacherDepartment)
        Me.Panel1.Controls.Add(Me.txtTeacherLastName)
        Me.Panel1.Controls.Add(Me.txtTeacherFirstName)
        Me.Panel1.Controls.Add(Me.lblTeacherFirstName)
        Me.Panel1.Controls.Add(Me.lblTeacherLastName)
        Me.Panel1.Controls.Add(Me.lblTeacherDepartment)
        Me.Panel1.Location = New System.Drawing.Point(41, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 506)
        Me.Panel1.TabIndex = 144
        '
        'txtTeacherQuota
        '
        Me.txtTeacherQuota.BackColor = System.Drawing.Color.Black
        Me.txtTeacherQuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherQuota.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.txtTeacherQuota.ForeColor = System.Drawing.Color.White
        Me.txtTeacherQuota.Location = New System.Drawing.Point(197, 339)
        Me.txtTeacherQuota.Name = "txtTeacherQuota"
        Me.txtTeacherQuota.Size = New System.Drawing.Size(414, 61)
        Me.txtTeacherQuota.TabIndex = 383
        '
        'lblTeacherQuota
        '
        Me.lblTeacherQuota.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTeacherQuota.AutoSize = True
        Me.lblTeacherQuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTeacherQuota.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.lblTeacherQuota.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTeacherQuota.Location = New System.Drawing.Point(18, 340)
        Me.lblTeacherQuota.Name = "lblTeacherQuota"
        Me.lblTeacherQuota.Size = New System.Drawing.Size(146, 52)
        Me.lblTeacherQuota.TabIndex = 382
        Me.lblTeacherQuota.Text = "คาบสอน"
        '
        'cboTeacherDepartment
        '
        Me.cboTeacherDepartment.BackColor = System.Drawing.Color.Black
        Me.cboTeacherDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeacherDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTeacherDepartment.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.cboTeacherDepartment.ForeColor = System.Drawing.Color.White
        Me.cboTeacherDepartment.FormattingEnabled = True
        Me.cboTeacherDepartment.Location = New System.Drawing.Point(197, 246)
        Me.cboTeacherDepartment.Name = "cboTeacherDepartment"
        Me.cboTeacherDepartment.Size = New System.Drawing.Size(414, 40)
        Me.cboTeacherDepartment.TabIndex = 381
        '
        'txtTeacherLastName
        '
        Me.txtTeacherLastName.BackColor = System.Drawing.Color.Black
        Me.txtTeacherLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherLastName.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.txtTeacherLastName.ForeColor = System.Drawing.Color.White
        Me.txtTeacherLastName.Location = New System.Drawing.Point(197, 139)
        Me.txtTeacherLastName.Name = "txtTeacherLastName"
        Me.txtTeacherLastName.Size = New System.Drawing.Size(414, 61)
        Me.txtTeacherLastName.TabIndex = 369
        '
        'txtTeacherFirstName
        '
        Me.txtTeacherFirstName.BackColor = System.Drawing.Color.Black
        Me.txtTeacherFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTeacherFirstName.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.txtTeacherFirstName.ForeColor = System.Drawing.Color.White
        Me.txtTeacherFirstName.Location = New System.Drawing.Point(197, 32)
        Me.txtTeacherFirstName.Name = "txtTeacherFirstName"
        Me.txtTeacherFirstName.Size = New System.Drawing.Size(414, 61)
        Me.txtTeacherFirstName.TabIndex = 368
        '
        'lblTeacherFirstName
        '
        Me.lblTeacherFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTeacherFirstName.AutoSize = True
        Me.lblTeacherFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTeacherFirstName.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.lblTeacherFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTeacherFirstName.Location = New System.Drawing.Point(54, 38)
        Me.lblTeacherFirstName.Name = "lblTeacherFirstName"
        Me.lblTeacherFirstName.Size = New System.Drawing.Size(115, 52)
        Me.lblTeacherFirstName.TabIndex = 133
        Me.lblTeacherFirstName.Text = "ชื่อจริง"
        '
        'lblTeacherLastName
        '
        Me.lblTeacherLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTeacherLastName.AutoSize = True
        Me.lblTeacherLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTeacherLastName.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.lblTeacherLastName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTeacherLastName.Location = New System.Drawing.Point(24, 140)
        Me.lblTeacherLastName.Name = "lblTeacherLastName"
        Me.lblTeacherLastName.Size = New System.Drawing.Size(145, 52)
        Me.lblTeacherLastName.TabIndex = 134
        Me.lblTeacherLastName.Text = "นามสกุล"
        '
        'lblTeacherDepartment
        '
        Me.lblTeacherDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTeacherDepartment.AutoSize = True
        Me.lblTeacherDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTeacherDepartment.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.lblTeacherDepartment.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTeacherDepartment.Location = New System.Drawing.Point(18, 235)
        Me.lblTeacherDepartment.Name = "lblTeacherDepartment"
        Me.lblTeacherDepartment.Size = New System.Drawing.Size(151, 52)
        Me.lblTeacherDepartment.TabIndex = 135
        Me.lblTeacherDepartment.Text = "กลุ่มสาระ"
        '
        'lblSearch
        '
        Me.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Sylfaen", 20.0!)
        Me.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSearch.Location = New System.Drawing.Point(694, 109)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(70, 35)
        Me.lblSearch.TabIndex = 141
        Me.lblSearch.Text = "ค้นหา"
        '
        'txtPR
        '
        Me.txtPR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPR.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtPR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPR.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.txtPR.ForeColor = System.Drawing.Color.White
        Me.txtPR.Location = New System.Drawing.Point(1120, 39)
        Me.txtPR.MaxLength = 5
        Me.txtPR.Name = "txtPR"
        Me.txtPR.Size = New System.Drawing.Size(240, 34)
        Me.txtPR.TabIndex = 140
        Me.txtPR.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblStatus.Location = New System.Drawing.Point(863, 69)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(177, 25)
        Me.lblStatus.TabIndex = 139
        Me.lblStatus.Text = "Connection status :"
        '
        'lblConnection
        '
        Me.lblConnection.AllowDrop = True
        Me.lblConnection.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblConnection.AutoSize = True
        Me.lblConnection.BackColor = System.Drawing.Color.Transparent
        Me.lblConnection.Font = New System.Drawing.Font("Sylfaen", 15.0!)
        Me.lblConnection.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblConnection.Location = New System.Drawing.Point(720, 67)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(148, 26)
        Me.lblConnection.TabIndex = 138
        Me.lblConnection.Text = "สถานะการเชื่อมต่อ :"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(770, 106)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(775, 34)
        Me.txtSearch.TabIndex = 137
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Sylfaen", 20.0!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DataGridView1.Location = New System.Drawing.Point(700, 173)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(10)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 50
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Arial Narrow", 20.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(971, 751)
        Me.DataGridView1.TabIndex = 136
        '
        'Column5
        '
        Me.Column5.HeaderText = "number"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ชื่อจริง"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "นามสกุล"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 118
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "กลุ่มสาระ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "คาบสอน"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'agent
        '
        Me.agent.AutoSize = True
        Me.agent.Location = New System.Drawing.Point(848, 0)
        Me.agent.Name = "agent"
        Me.agent.Size = New System.Drawing.Size(0, 13)
        Me.agent.TabIndex = 375
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Location = New System.Drawing.Point(41, 712)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(635, 210)
        Me.Panel2.TabIndex = 380
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Black
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnEdit.FlatAppearance.BorderSize = 2
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(43, 116)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(546, 85)
        Me.btnEdit.TabIndex = 132
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Black
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(411, 25)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(178, 85)
        Me.btnDelete.TabIndex = 130
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnClear.FlatAppearance.BorderSize = 2
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(227, 25)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(178, 85)
        Me.btnClear.TabIndex = 131
        Me.btnClear.Text = "ล้าง"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Black
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(43, 25)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(178, 85)
        Me.btnSave.TabIndex = 129
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Sylfaen", 60.0!)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(44, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(90, 10, 90, 10)
        Me.lblTitle.Size = New System.Drawing.Size(634, 127)
        Me.lblTitle.TabIndex = 133
        Me.lblTitle.Text = "เเก้ไขข้อมูลครู"
        '
        'Teachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.project.My.Resources.Resources.BGExtend
        Me.ClientSize = New System.Drawing.Size(1803, 1080)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.agent)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtPR)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Teachers"
        Me.Text = "MixmizeTeachers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtPR As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblConnection As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTeacherDepartment As Label
    Friend WithEvents lblTeacherLastName As Label
    Friend WithEvents lblTeacherFirstName As Label
    Friend WithEvents agent As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtTeacherLastName As TextBox
    Friend WithEvents txtTeacherFirstName As TextBox
    Friend WithEvents cboTeacherDepartment As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTeacherQuota As TextBox
    Friend WithEvents lblTeacherQuota As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
