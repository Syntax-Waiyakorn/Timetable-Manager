<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MixmizeTeachers
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblTeachers = New System.Windows.Forms.Label()
        Me.txtPR = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtTeacherDepartment = New System.Windows.Forms.TextBox()
        Me.txtTeacherLastName = New System.Windows.Forms.TextBox()
        Me.txtTeacherFirstName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTeacherDepartment = New System.Windows.Forms.Label()
        Me.lblTeacherLastName = New System.Windows.Forms.Label()
        Me.lblTeacherFirstName = New System.Windows.Forms.Label()
        Me.btnEdit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnDelete = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnClear = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSvae = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSearch
        '
        Me.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Sylfaen", 20.0!)
        Me.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSearch.Location = New System.Drawing.Point(692, 72)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(70, 35)
        Me.lblSearch.TabIndex = 99
        Me.lblSearch.Text = "ค้นหา"
        '
        'lblTeachers
        '
        Me.lblTeachers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTeachers.AutoSize = True
        Me.lblTeachers.Font = New System.Drawing.Font("Sylfaen", 70.0!)
        Me.lblTeachers.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTeachers.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTeachers.Location = New System.Drawing.Point(73, 62)
        Me.lblTeachers.Name = "lblTeachers"
        Me.lblTeachers.Size = New System.Drawing.Size(529, 123)
        Me.lblTeachers.TabIndex = 94
        Me.lblTeachers.Text = "เเก้ไขข้อมูลครู"
        '
        'txtPR
        '
        Me.txtPR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPR.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtPR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPR.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.txtPR.ForeColor = System.Drawing.Color.White
        Me.txtPR.Location = New System.Drawing.Point(205, 237)
        Me.txtPR.MaxLength = 5
        Me.txtPR.Name = "txtPR"
        Me.txtPR.Size = New System.Drawing.Size(442, 54)
        Me.txtPR.TabIndex = 93
        Me.txtPR.Visible = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblStatus.Location = New System.Drawing.Point(862, 44)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(177, 25)
        Me.lblStatus.TabIndex = 91
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
        Me.lblConnection.Location = New System.Drawing.Point(720, 40)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(148, 26)
        Me.lblConnection.TabIndex = 90
        Me.lblConnection.Text = "สถานะการเชื่อมต่อ :"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(768, 72)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(473, 34)
        Me.txtSearch.TabIndex = 89
        '
        'txtTeacherDepartment
        '
        Me.txtTeacherDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTeacherDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtTeacherDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTeacherDepartment.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.txtTeacherDepartment.ForeColor = System.Drawing.Color.White
        Me.txtTeacherDepartment.Location = New System.Drawing.Point(205, 410)
        Me.txtTeacherDepartment.MaxLength = 100
        Me.txtTeacherDepartment.Name = "txtTeacherDepartment"
        Me.txtTeacherDepartment.Size = New System.Drawing.Size(442, 54)
        Me.txtTeacherDepartment.TabIndex = 88
        '
        'txtTeacherLastName
        '
        Me.txtTeacherLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTeacherLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtTeacherLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTeacherLastName.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.txtTeacherLastName.ForeColor = System.Drawing.Color.White
        Me.txtTeacherLastName.Location = New System.Drawing.Point(205, 323)
        Me.txtTeacherLastName.MaxLength = 100
        Me.txtTeacherLastName.Name = "txtTeacherLastName"
        Me.txtTeacherLastName.Size = New System.Drawing.Size(442, 54)
        Me.txtTeacherLastName.TabIndex = 87
        '
        'txtTeacherFirstName
        '
        Me.txtTeacherFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTeacherFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtTeacherFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTeacherFirstName.Font = New System.Drawing.Font("Arial", 35.0!)
        Me.txtTeacherFirstName.ForeColor = System.Drawing.Color.White
        Me.txtTeacherFirstName.Location = New System.Drawing.Point(205, 237)
        Me.txtTeacherFirstName.MaxLength = 100
        Me.txtTeacherFirstName.Name = "txtTeacherFirstName"
        Me.txtTeacherFirstName.Size = New System.Drawing.Size(442, 54)
        Me.txtTeacherFirstName.TabIndex = 86
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Sylfaen", 15.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DataGridView1.Location = New System.Drawing.Point(698, 112)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(971, 783)
        Me.DataGridView1.TabIndex = 85
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
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "นามสกุล"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 94
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "กลุ่มสาระ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'lblTeacherDepartment
        '
        Me.lblTeacherDepartment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTeacherDepartment.AutoSize = True
        Me.lblTeacherDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblTeacherDepartment.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.lblTeacherDepartment.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTeacherDepartment.Location = New System.Drawing.Point(36, 410)
        Me.lblTeacherDepartment.Name = "lblTeacherDepartment"
        Me.lblTeacherDepartment.Size = New System.Drawing.Size(151, 52)
        Me.lblTeacherDepartment.TabIndex = 84
        Me.lblTeacherDepartment.Text = "กลุ่มสาระ"
        '
        'lblTeacherLastName
        '
        Me.lblTeacherLastName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTeacherLastName.AutoSize = True
        Me.lblTeacherLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblTeacherLastName.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.lblTeacherLastName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTeacherLastName.Location = New System.Drawing.Point(42, 323)
        Me.lblTeacherLastName.Name = "lblTeacherLastName"
        Me.lblTeacherLastName.Size = New System.Drawing.Size(145, 52)
        Me.lblTeacherLastName.TabIndex = 83
        Me.lblTeacherLastName.Text = "นามสกุล"
        '
        'lblTeacherFirstName
        '
        Me.lblTeacherFirstName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTeacherFirstName.AutoSize = True
        Me.lblTeacherFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblTeacherFirstName.Font = New System.Drawing.Font("Sylfaen", 30.0!)
        Me.lblTeacherFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTeacherFirstName.Location = New System.Drawing.Point(72, 237)
        Me.lblTeacherFirstName.Name = "lblTeacherFirstName"
        Me.lblTeacherFirstName.Size = New System.Drawing.Size(115, 52)
        Me.lblTeacherFirstName.TabIndex = 82
        Me.lblTeacherFirstName.Text = "ชื่อจริง"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(79, 850)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEdit.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEdit.OverrideDefault.Back.ColorAngle = 45.0!
        Me.btnEdit.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnEdit.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnEdit.OverrideDefault.Border.ColorAngle = 45.0!
        Me.btnEdit.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEdit.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnEdit.OverrideDefault.Border.Rounding = 22
        Me.btnEdit.OverrideDefault.Border.Width = 2
        Me.btnEdit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.btnEdit.Size = New System.Drawing.Size(546, 87)
        Me.btnEdit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEdit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEdit.StateCommon.Back.ColorAngle = 45.0!
        Me.btnEdit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnEdit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.btnEdit.StateCommon.Border.ColorAngle = 45.0!
        Me.btnEdit.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEdit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnEdit.StateCommon.Border.Rounding = 22
        Me.btnEdit.StateCommon.Border.Width = 2
        Me.btnEdit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnEdit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnEdit.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.btnEdit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEdit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEdit.StatePressed.Back.ColorAngle = 135.0!
        Me.btnEdit.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEdit.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnEdit.StatePressed.Border.ColorAngle = 135.0!
        Me.btnEdit.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEdit.StatePressed.Border.Rounding = 20
        Me.btnEdit.StatePressed.Border.Width = 1
        Me.btnEdit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEdit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEdit.StateTracking.Back.ColorAngle = 135.0!
        Me.btnEdit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEdit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEdit.StateTracking.Border.ColorAngle = 135.0!
        Me.btnEdit.StateTracking.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEdit.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnEdit.StateTracking.Border.Rounding = 20
        Me.btnEdit.StateTracking.Border.Width = 1
        Me.btnEdit.TabIndex = 103
        Me.btnEdit.Values.Text = "แก้ไขข้อมูล"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(460, 763)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDelete.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDelete.OverrideDefault.Back.ColorAngle = 45.0!
        Me.btnDelete.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDelete.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnDelete.OverrideDefault.Border.ColorAngle = 45.0!
        Me.btnDelete.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDelete.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnDelete.OverrideDefault.Border.Rounding = 22
        Me.btnDelete.OverrideDefault.Border.Width = 2
        Me.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.btnDelete.Size = New System.Drawing.Size(201, 81)
        Me.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDelete.StateCommon.Back.ColorAngle = 45.0!
        Me.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDelete.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnDelete.StateCommon.Border.ColorAngle = 45.0!
        Me.btnDelete.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDelete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnDelete.StateCommon.Border.Rounding = 22
        Me.btnDelete.StateCommon.Border.Width = 2
        Me.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnDelete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnDelete.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.btnDelete.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDelete.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnDelete.StatePressed.Back.ColorAngle = 135.0!
        Me.btnDelete.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnDelete.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnDelete.StatePressed.Border.ColorAngle = 135.0!
        Me.btnDelete.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDelete.StatePressed.Border.Rounding = 20
        Me.btnDelete.StatePressed.Border.Width = 1
        Me.btnDelete.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnDelete.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnDelete.StateTracking.Back.ColorAngle = 135.0!
        Me.btnDelete.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnDelete.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnDelete.StateTracking.Border.ColorAngle = 135.0!
        Me.btnDelete.StateTracking.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDelete.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnDelete.StateTracking.Border.Rounding = 20
        Me.btnDelete.StateTracking.Border.Width = 1
        Me.btnDelete.TabIndex = 102
        Me.btnDelete.Values.Text = "ลบ"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(253, 763)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClear.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClear.OverrideDefault.Back.ColorAngle = 45.0!
        Me.btnClear.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnClear.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnClear.OverrideDefault.Border.ColorAngle = 45.0!
        Me.btnClear.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnClear.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnClear.OverrideDefault.Border.Rounding = 22
        Me.btnClear.OverrideDefault.Border.Width = 2
        Me.btnClear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.btnClear.Size = New System.Drawing.Size(201, 81)
        Me.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClear.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClear.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local
        Me.btnClear.StateCommon.Back.ColorAngle = 45.0!
        Me.btnClear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnClear.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnClear.StateCommon.Border.ColorAngle = 45.0!
        Me.btnClear.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnClear.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnClear.StateCommon.Border.Rounding = 22
        Me.btnClear.StateCommon.Border.Width = 2
        Me.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnClear.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnClear.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.btnClear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnClear.StatePressed.Back.ColorAngle = 135.0!
        Me.btnClear.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnClear.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnClear.StatePressed.Border.ColorAngle = 135.0!
        Me.btnClear.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnClear.StatePressed.Border.Rounding = 20
        Me.btnClear.StatePressed.Border.Width = 1
        Me.btnClear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnClear.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnClear.StateTracking.Back.ColorAngle = 135.0!
        Me.btnClear.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnClear.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnClear.StateTracking.Border.ColorAngle = 135.0!
        Me.btnClear.StateTracking.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnClear.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnClear.StateTracking.Border.Rounding = 20
        Me.btnClear.StateTracking.Border.Width = 1
        Me.btnClear.TabIndex = 101
        Me.btnClear.Values.Text = "ล้างข้อมูล"
        '
        'btnSvae
        '
        Me.btnSvae.Location = New System.Drawing.Point(46, 763)
        Me.btnSvae.Name = "btnSvae"
        Me.btnSvae.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSvae.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSvae.OverrideDefault.Back.ColorAngle = 45.0!
        Me.btnSvae.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSvae.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnSvae.OverrideDefault.Border.ColorAngle = 45.0!
        Me.btnSvae.OverrideDefault.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSvae.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnSvae.OverrideDefault.Border.Rounding = 22
        Me.btnSvae.OverrideDefault.Border.Width = 2
        Me.btnSvae.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.btnSvae.Size = New System.Drawing.Size(201, 81)
        Me.btnSvae.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSvae.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSvae.StateCommon.Back.ColorAngle = 45.0!
        Me.btnSvae.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSvae.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnSvae.StateCommon.Border.ColorAngle = 45.0!
        Me.btnSvae.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSvae.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnSvae.StateCommon.Border.Rounding = 22
        Me.btnSvae.StateCommon.Border.Width = 2
        Me.btnSvae.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace
        Me.btnSvae.StateCommon.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace
        Me.btnSvae.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSvae.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.ClearTypeGridFit
        Me.btnSvae.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSvae.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSvae.StatePressed.Back.ColorAngle = 135.0!
        Me.btnSvae.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSvae.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnSvae.StatePressed.Border.ColorAngle = 135.0!
        Me.btnSvae.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSvae.StatePressed.Border.Rounding = 20
        Me.btnSvae.StatePressed.Border.Width = 1
        Me.btnSvae.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnSvae.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnSvae.StateTracking.Back.ColorAngle = 135.0!
        Me.btnSvae.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnSvae.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnSvae.StateTracking.Border.ColorAngle = 135.0!
        Me.btnSvae.StateTracking.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSvae.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.btnSvae.StateTracking.Border.Rounding = 20
        Me.btnSvae.StateTracking.Border.Width = 1
        Me.btnSvae.TabIndex = 100
        Me.btnSvae.Values.Text = "บันทึก"
        '
        'MixmizeTeachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1696, 1080)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSvae)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblTeachers)
        Me.Controls.Add(Me.txtPR)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblConnection)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtTeacherDepartment)
        Me.Controls.Add(Me.txtTeacherLastName)
        Me.Controls.Add(Me.txtTeacherFirstName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblTeacherDepartment)
        Me.Controls.Add(Me.lblTeacherLastName)
        Me.Controls.Add(Me.lblTeacherFirstName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MixmizeTeachers"
        Me.Text = "MixmizeTeachers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents lblTeachers As Label
    Friend WithEvents txtPR As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblConnection As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtTeacherDepartment As TextBox
    Friend WithEvents txtTeacherLastName As TextBox
    Friend WithEvents txtTeacherFirstName As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents lblTeacherDepartment As Label
    Friend WithEvents lblTeacherLastName As Label
    Friend WithEvents lblTeacherFirstName As Label
    Private WithEvents btnEdit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnDelete As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnClear As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnSvae As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
