<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Room
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
        Me.txtPR = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.Connection_status = New System.Windows.Forms.Label()
        Me.Connection = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.btnEdit = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnDelete = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnClear = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnSvae = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lblSearch = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPR
        '
        Me.txtPR.AllowDrop = True
        Me.txtPR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPR.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtPR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPR.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.txtPR.Location = New System.Drawing.Point(137, 94)
        Me.txtPR.MaxLength = 5
        Me.txtPR.Name = "txtPR"
        Me.txtPR.Size = New System.Drawing.Size(240, 34)
        Me.txtPR.TabIndex = 63
        Me.txtPR.Visible = False
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblNumber.Font = New System.Drawing.Font("Sylfaen", 18.0!)
        Me.lblNumber.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNumber.Location = New System.Drawing.Point(23, 99)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(97, 31)
        Me.lblNumber.TabIndex = 62
        Me.lblNumber.Text = "Number"
        Me.lblNumber.Visible = False
        '
        'Connection_status
        '
        Me.Connection_status.AutoSize = True
        Me.Connection_status.BackColor = System.Drawing.Color.Transparent
        Me.Connection_status.Font = New System.Drawing.Font("Microsoft Tai Le", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Connection_status.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Connection_status.Location = New System.Drawing.Point(597, 42)
        Me.Connection_status.Name = "Connection_status"
        Me.Connection_status.Size = New System.Drawing.Size(177, 25)
        Me.Connection_status.TabIndex = 61
        Me.Connection_status.Text = "Connection status :"
        '
        'Connection
        '
        Me.Connection.AllowDrop = True
        Me.Connection.AutoSize = True
        Me.Connection.BackColor = System.Drawing.Color.Transparent
        Me.Connection.Font = New System.Drawing.Font("Sylfaen", 15.0!)
        Me.Connection.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Connection.Location = New System.Drawing.Point(455, 38)
        Me.Connection.Name = "Connection"
        Me.Connection.Size = New System.Drawing.Size(148, 26)
        Me.Connection.TabIndex = 59
        Me.Connection.Text = "สถานะการเชื่อมต่อ :"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(519, 65)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(473, 34)
        Me.btnSearch.TabIndex = 56
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.txtName.ForeColor = System.Drawing.Color.White
        Me.txtName.Location = New System.Drawing.Point(137, 216)
        Me.txtName.MaxLength = 100
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(240, 34)
        Me.txtName.TabIndex = 53
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DataGridView1.Location = New System.Drawing.Point(416, 113)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
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
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(621, 418)
        Me.DataGridView1.TabIndex = 51
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
        Me.Column1.HeaderText = "รหัสห้อง"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 92
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "ชั้น"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Sylfaen", 18.0!)
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblName.Location = New System.Drawing.Point(78, 216)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 31)
        Me.lblName.TabIndex = 47
        Me.lblName.Text = "ชั้น"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Sylfaen", 18.0!)
        Me.lblID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblID.Location = New System.Drawing.Point(46, 158)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(85, 31)
        Me.lblID.TabIndex = 46
        Me.lblID.Text = "รหัสห้อง"
        '
        'txtID
        '
        Me.txtID.AllowDrop = True
        Me.txtID.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtID.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.txtID.ForeColor = System.Drawing.Color.White
        Me.txtID.Location = New System.Drawing.Point(137, 155)
        Me.txtID.MaxLength = 5
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(240, 34)
        Me.txtID.TabIndex = 45
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Sylfaen", 36.0!)
        Me.lblRoom.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblRoom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRoom.Location = New System.Drawing.Point(96, 18)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(290, 62)
        Me.lblRoom.TabIndex = 65
        Me.lblRoom.Text = "เเก้ไขข้อมูลห้อง"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(34, 481)
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
        Me.btnEdit.Size = New System.Drawing.Size(317, 50)
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
        Me.btnEdit.TabIndex = 76
        Me.btnEdit.Values.Text = "แก้ไขข้อมูล"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(258, 423)
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
        Me.btnDelete.Size = New System.Drawing.Size(115, 52)
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
        Me.btnDelete.TabIndex = 75
        Me.btnDelete.Values.Text = "ลบ"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(137, 423)
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
        Me.btnClear.Size = New System.Drawing.Size(115, 52)
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
        Me.btnClear.TabIndex = 74
        Me.btnClear.Values.Text = "ล้างข้อมูล"
        '
        'btnSvae
        '
        Me.btnSvae.Location = New System.Drawing.Point(16, 423)
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
        Me.btnSvae.Size = New System.Drawing.Size(115, 52)
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
        Me.btnSvae.TabIndex = 73
        Me.btnSvae.Values.Text = "บันทึก"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Transparent
        Me.lblSearch.Font = New System.Drawing.Font("Sylfaen", 20.0!)
        Me.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSearch.Location = New System.Drawing.Point(443, 64)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(70, 35)
        Me.lblSearch.TabIndex = 77
        Me.lblSearch.Text = "ค้นหา"
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSvae)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.txtPR)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.Connection_status)
        Me.Controls.Add(Me.Connection)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Room"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPR As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents Connection_status As Label
    Friend WithEvents Connection As Label
    Friend WithEvents btnSearch As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents lblRoom As Label
    Private WithEvents btnEdit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnDelete As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnClear As ComponentFactory.Krypton.Toolkit.KryptonButton
    Private WithEvents btnSvae As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblSearch As Label
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
