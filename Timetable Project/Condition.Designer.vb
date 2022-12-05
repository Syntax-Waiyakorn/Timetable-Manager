<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Condition
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
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTSDelete = New System.Windows.Forms.Button()
        Me.btnTSSave = New System.Windows.Forms.Button()
        Me.txtSearchS = New System.Windows.Forms.TextBox()
        Me.txtSearchT = New System.Windows.Forms.TextBox()
        Me.cboSubjects = New System.Windows.Forms.ComboBox()
        Me.cboTeachers = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.agent = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnTSCDelete = New System.Windows.Forms.Button()
        Me.btnTSCSave = New System.Windows.Forms.Button()
        Me.txtSearchC = New System.Windows.Forms.TextBox()
        Me.txtSearchTS = New System.Windows.Forms.TextBox()
        Me.cboClassrooms = New System.Windows.Forms.ComboBox()
        Me.cboTeachersSubjects = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPR = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 25.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 44)
        Me.Label2.TabIndex = 367
        Me.Label2.Text = "ครูผู้สอน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Sylfaen", 25.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(23, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 44)
        Me.Label6.TabIndex = 369
        Me.Label6.Text = "รหัสวิชา"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnTSDelete)
        Me.Panel1.Controls.Add(Me.btnTSSave)
        Me.Panel1.Controls.Add(Me.txtSearchS)
        Me.Panel1.Controls.Add(Me.txtSearchT)
        Me.Panel1.Controls.Add(Me.cboSubjects)
        Me.Panel1.Controls.Add(Me.cboTeachers)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(45, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 264)
        Me.Panel1.TabIndex = 371
        '
        'btnTSDelete
        '
        Me.btnTSDelete.BackColor = System.Drawing.Color.Black
        Me.btnTSDelete.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnTSDelete.FlatAppearance.BorderSize = 2
        Me.btnTSDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTSDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTSDelete.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.btnTSDelete.ForeColor = System.Drawing.Color.White
        Me.btnTSDelete.Location = New System.Drawing.Point(137, 198)
        Me.btnTSDelete.Name = "btnTSDelete"
        Me.btnTSDelete.Size = New System.Drawing.Size(349, 55)
        Me.btnTSDelete.TabIndex = 387
        Me.btnTSDelete.Text = "เลิกสอน"
        Me.btnTSDelete.UseVisualStyleBackColor = False
        '
        'btnTSSave
        '
        Me.btnTSSave.BackColor = System.Drawing.Color.Black
        Me.btnTSSave.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnTSSave.FlatAppearance.BorderSize = 2
        Me.btnTSSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTSSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTSSave.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.btnTSSave.ForeColor = System.Drawing.Color.White
        Me.btnTSSave.Location = New System.Drawing.Point(137, 137)
        Me.btnTSSave.Name = "btnTSSave"
        Me.btnTSSave.Size = New System.Drawing.Size(349, 55)
        Me.btnTSSave.TabIndex = 386
        Me.btnTSSave.Text = "สอน"
        Me.btnTSSave.UseVisualStyleBackColor = False
        '
        'txtSearchS
        '
        Me.txtSearchS.BackColor = System.Drawing.Color.Black
        Me.txtSearchS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchS.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.txtSearchS.ForeColor = System.Drawing.Color.White
        Me.txtSearchS.Location = New System.Drawing.Point(345, 69)
        Me.txtSearchS.Name = "txtSearchS"
        Me.txtSearchS.Size = New System.Drawing.Size(141, 53)
        Me.txtSearchS.TabIndex = 385
        '
        'txtSearchT
        '
        Me.txtSearchT.BackColor = System.Drawing.Color.Black
        Me.txtSearchT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchT.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.txtSearchT.ForeColor = System.Drawing.Color.White
        Me.txtSearchT.Location = New System.Drawing.Point(345, 10)
        Me.txtSearchT.Name = "txtSearchT"
        Me.txtSearchT.Size = New System.Drawing.Size(141, 53)
        Me.txtSearchT.TabIndex = 384
        '
        'cboSubjects
        '
        Me.cboSubjects.BackColor = System.Drawing.Color.Black
        Me.cboSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSubjects.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.cboSubjects.ForeColor = System.Drawing.Color.White
        Me.cboSubjects.FormattingEnabled = True
        Me.cboSubjects.IntegralHeight = False
        Me.cboSubjects.Location = New System.Drawing.Point(147, 75)
        Me.cboSubjects.Name = "cboSubjects"
        Me.cboSubjects.Size = New System.Drawing.Size(183, 40)
        Me.cboSubjects.TabIndex = 383
        '
        'cboTeachers
        '
        Me.cboTeachers.BackColor = System.Drawing.Color.Black
        Me.cboTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTeachers.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.cboTeachers.ForeColor = System.Drawing.Color.White
        Me.cboTeachers.FormattingEnabled = True
        Me.cboTeachers.IntegralHeight = False
        Me.cboTeachers.Location = New System.Drawing.Point(147, 14)
        Me.cboTeachers.Name = "cboTeachers"
        Me.cboTeachers.Size = New System.Drawing.Size(183, 40)
        Me.cboTeachers.TabIndex = 382
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle41.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle41
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Sylfaen", 15.0!)
        DataGridViewCellStyle42.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle42
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle43.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle43.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle43
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DataGridView1.Location = New System.Drawing.Point(45, 419)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle44.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle44
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle45.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle45
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(500, 505)
        Me.DataGridView1.TabIndex = 372
        '
        'agent
        '
        Me.agent.AutoSize = True
        Me.agent.Location = New System.Drawing.Point(542, 54)
        Me.agent.Name = "agent"
        Me.agent.Size = New System.Drawing.Size(13, 13)
        Me.agent.TabIndex = 374
        Me.agent.Text = "1"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Font = New System.Drawing.Font("Sylfaen", 55.0!)
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(103, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTitle.Size = New System.Drawing.Size(390, 118)
        Me.lblTitle.TabIndex = 375
        Me.lblTitle.Text = "วิชาที่ครูสอน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 55.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(669, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(300, 118)
        Me.Label1.TabIndex = 379
        Me.Label1.Text = "เชื่อมห้อง"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1057, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 378
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle46.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle46.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle46
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle47.Font = New System.Drawing.Font("Sylfaen", 15.0!)
        DataGridViewCellStyle47.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle47
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5})
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle48.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle48.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle48
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.Black
        Me.DataGridView2.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.DataGridView2.Location = New System.Drawing.Point(560, 419)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle49.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle49.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle49
        Me.DataGridView2.RowHeadersVisible = False
        DataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle50.Font = New System.Drawing.Font("Arial Narrow", 13.0!)
        DataGridViewCellStyle50.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle50
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.ShowCellErrors = False
        Me.DataGridView2.ShowCellToolTips = False
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.ShowRowErrors = False
        Me.DataGridView2.Size = New System.Drawing.Size(500, 505)
        Me.DataGridView2.TabIndex = 377
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "ครู-วิชา"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "ห้อง"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnTSCDelete)
        Me.Panel2.Controls.Add(Me.btnTSCSave)
        Me.Panel2.Controls.Add(Me.txtSearchC)
        Me.Panel2.Controls.Add(Me.txtSearchTS)
        Me.Panel2.Controls.Add(Me.cboClassrooms)
        Me.Panel2.Controls.Add(Me.cboTeachersSubjects)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(560, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 264)
        Me.Panel2.TabIndex = 376
        '
        'btnTSCDelete
        '
        Me.btnTSCDelete.BackColor = System.Drawing.Color.Black
        Me.btnTSCDelete.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnTSCDelete.FlatAppearance.BorderSize = 2
        Me.btnTSCDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTSCDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTSCDelete.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.btnTSCDelete.ForeColor = System.Drawing.Color.White
        Me.btnTSCDelete.Location = New System.Drawing.Point(137, 198)
        Me.btnTSCDelete.Name = "btnTSCDelete"
        Me.btnTSCDelete.Size = New System.Drawing.Size(349, 55)
        Me.btnTSCDelete.TabIndex = 387
        Me.btnTSCDelete.Text = "ยกเลิก"
        Me.btnTSCDelete.UseVisualStyleBackColor = False
        '
        'btnTSCSave
        '
        Me.btnTSCSave.BackColor = System.Drawing.Color.Black
        Me.btnTSCSave.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnTSCSave.FlatAppearance.BorderSize = 2
        Me.btnTSCSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnTSCSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTSCSave.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.btnTSCSave.ForeColor = System.Drawing.Color.White
        Me.btnTSCSave.Location = New System.Drawing.Point(137, 137)
        Me.btnTSCSave.Name = "btnTSCSave"
        Me.btnTSCSave.Size = New System.Drawing.Size(349, 55)
        Me.btnTSCSave.TabIndex = 386
        Me.btnTSCSave.Text = "เชื่อม"
        Me.btnTSCSave.UseVisualStyleBackColor = False
        '
        'txtSearchC
        '
        Me.txtSearchC.BackColor = System.Drawing.Color.Black
        Me.txtSearchC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchC.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.txtSearchC.ForeColor = System.Drawing.Color.White
        Me.txtSearchC.Location = New System.Drawing.Point(345, 69)
        Me.txtSearchC.Name = "txtSearchC"
        Me.txtSearchC.Size = New System.Drawing.Size(141, 53)
        Me.txtSearchC.TabIndex = 385
        '
        'txtSearchTS
        '
        Me.txtSearchTS.BackColor = System.Drawing.Color.Black
        Me.txtSearchTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchTS.Font = New System.Drawing.Font("Arial", 30.0!)
        Me.txtSearchTS.ForeColor = System.Drawing.Color.White
        Me.txtSearchTS.Location = New System.Drawing.Point(345, 10)
        Me.txtSearchTS.Name = "txtSearchTS"
        Me.txtSearchTS.Size = New System.Drawing.Size(141, 53)
        Me.txtSearchTS.TabIndex = 384
        '
        'cboClassrooms
        '
        Me.cboClassrooms.BackColor = System.Drawing.Color.Black
        Me.cboClassrooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClassrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboClassrooms.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.cboClassrooms.ForeColor = System.Drawing.Color.White
        Me.cboClassrooms.FormattingEnabled = True
        Me.cboClassrooms.IntegralHeight = False
        Me.cboClassrooms.Location = New System.Drawing.Point(147, 75)
        Me.cboClassrooms.Name = "cboClassrooms"
        Me.cboClassrooms.Size = New System.Drawing.Size(183, 40)
        Me.cboClassrooms.TabIndex = 383
        '
        'cboTeachersSubjects
        '
        Me.cboTeachersSubjects.BackColor = System.Drawing.Color.Black
        Me.cboTeachersSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeachersSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTeachersSubjects.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.cboTeachersSubjects.ForeColor = System.Drawing.Color.White
        Me.cboTeachersSubjects.FormattingEnabled = True
        Me.cboTeachersSubjects.IntegralHeight = False
        Me.cboTeachersSubjects.Location = New System.Drawing.Point(147, 14)
        Me.cboTeachersSubjects.Name = "cboTeachersSubjects"
        Me.cboTeachersSubjects.Size = New System.Drawing.Size(183, 40)
        Me.cboTeachersSubjects.TabIndex = 382
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Sylfaen", 25.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 44)
        Me.Label4.TabIndex = 367
        Me.Label4.Text = "ครู-วิชา"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Sylfaen", 25.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(64, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 44)
        Me.Label5.TabIndex = 369
        Me.Label5.Text = "ห้อง"
        '
        'txtPR
        '
        Me.txtPR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPR.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtPR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPR.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.txtPR.ForeColor = System.Drawing.Color.White
        Me.txtPR.Location = New System.Drawing.Point(989, 33)
        Me.txtPR.MaxLength = 5
        Me.txtPR.Name = "txtPR"
        Me.txtPR.Size = New System.Drawing.Size(240, 34)
        Me.txtPR.TabIndex = 380
        '
        'txtId
        '
        Me.txtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.txtId.ForeColor = System.Drawing.Color.White
        Me.txtId.Location = New System.Drawing.Point(989, 73)
        Me.txtId.MaxLength = 5
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(240, 34)
        Me.txtId.TabIndex = 381
        '
        'Column6
        '
        Me.Column6.HeaderText = "PR"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "ครูผู้สอน"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "วิชา"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "ชื่อวิชา"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Condition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1696, 1080)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtPR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.agent)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Condition"
        Me.Text = "MixmizeCondition"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents agent As Label
    Friend WithEvents cboTeachers As ComboBox
    Friend WithEvents cboSubjects As ComboBox
    Friend WithEvents txtSearchS As TextBox
    Friend WithEvents txtSearchT As TextBox
    Friend WithEvents btnTSDelete As Button
    Friend WithEvents btnTSSave As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTSCDelete As Button
    Friend WithEvents btnTSCSave As Button
    Friend WithEvents txtSearchC As TextBox
    Friend WithEvents txtSearchTS As TextBox
    Friend WithEvents cboClassrooms As ComboBox
    Friend WithEvents cboTeachersSubjects As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents txtPR As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
