<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.chkTeachersTable = New System.Windows.Forms.Panel()
        Me.btnTeachersTable = New System.Windows.Forms.Button()
        Me.chkRoom = New System.Windows.Forms.Panel()
        Me.chkStudentTable = New System.Windows.Forms.Panel()
        Me.chkIF = New System.Windows.Forms.Panel()
        Me.chkSub = New System.Windows.Forms.Panel()
        Me.chkT = New System.Windows.Forms.Panel()
        Me.chkHome = New System.Windows.Forms.Panel()
        Me.btnStudentTable = New System.Windows.Forms.Button()
        Me.btnCondition = New System.Windows.Forms.Button()
        Me.btnClassroom = New System.Windows.Forms.Button()
        Me.btnSubject = New System.Windows.Forms.Button()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlIcon = New System.Windows.Forms.Panel()
        Me.picBook = New System.Windows.Forms.PictureBox()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.btnMinimized = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnlockTable = New System.Windows.Forms.Button()
        Me.chklockTable = New System.Windows.Forms.Panel()
        Me.pnlMenu.SuspendLayout()
        Me.pnlIcon.SuspendLayout()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.chklockTable)
        Me.pnlMenu.Controls.Add(Me.btnlockTable)
        Me.pnlMenu.Controls.Add(Me.chkTeachersTable)
        Me.pnlMenu.Controls.Add(Me.btnTeachersTable)
        Me.pnlMenu.Controls.Add(Me.chkRoom)
        Me.pnlMenu.Controls.Add(Me.chkStudentTable)
        Me.pnlMenu.Controls.Add(Me.chkIF)
        Me.pnlMenu.Controls.Add(Me.chkSub)
        Me.pnlMenu.Controls.Add(Me.chkT)
        Me.pnlMenu.Controls.Add(Me.chkHome)
        Me.pnlMenu.Controls.Add(Me.btnStudentTable)
        Me.pnlMenu.Controls.Add(Me.btnCondition)
        Me.pnlMenu.Controls.Add(Me.btnClassroom)
        Me.pnlMenu.Controls.Add(Me.btnSubject)
        Me.pnlMenu.Controls.Add(Me.btnTeacher)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Controls.Add(Me.pnlIcon)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 69)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(192, 631)
        Me.pnlMenu.TabIndex = 30
        '
        'chkTeachersTable
        '
        Me.chkTeachersTable.BackColor = System.Drawing.Color.IndianRed
        Me.chkTeachersTable.Location = New System.Drawing.Point(0, 521)
        Me.chkTeachersTable.Name = "chkTeachersTable"
        Me.chkTeachersTable.Size = New System.Drawing.Size(10, 41)
        Me.chkTeachersTable.TabIndex = 4
        Me.chkTeachersTable.Visible = False
        '
        'btnTeachersTable
        '
        Me.btnTeachersTable.BackColor = System.Drawing.Color.Transparent
        Me.btnTeachersTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTeachersTable.FlatAppearance.BorderSize = 0
        Me.btnTeachersTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnTeachersTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnTeachersTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeachersTable.Font = New System.Drawing.Font("Sylfaen", 17.0!)
        Me.btnTeachersTable.ForeColor = System.Drawing.Color.Gray
        Me.btnTeachersTable.Image = Global.project.My.Resources.Resources.grid_two_upgray
        Me.btnTeachersTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeachersTable.Location = New System.Drawing.Point(0, 515)
        Me.btnTeachersTable.Name = "btnTeachersTable"
        Me.btnTeachersTable.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnTeachersTable.Size = New System.Drawing.Size(192, 55)
        Me.btnTeachersTable.TabIndex = 16
        Me.btnTeachersTable.Text = "  ตารางสอน"
        Me.btnTeachersTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeachersTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTeachersTable.UseVisualStyleBackColor = False
        '
        'chkRoom
        '
        Me.chkRoom.BackColor = System.Drawing.Color.IndianRed
        Me.chkRoom.Location = New System.Drawing.Point(0, 357)
        Me.chkRoom.Name = "chkRoom"
        Me.chkRoom.Size = New System.Drawing.Size(10, 41)
        Me.chkRoom.TabIndex = 3
        Me.chkRoom.Visible = False
        '
        'chkStudentTable
        '
        Me.chkStudentTable.BackColor = System.Drawing.Color.IndianRed
        Me.chkStudentTable.Location = New System.Drawing.Point(-1, 465)
        Me.chkStudentTable.Name = "chkStudentTable"
        Me.chkStudentTable.Size = New System.Drawing.Size(10, 41)
        Me.chkStudentTable.TabIndex = 3
        Me.chkStudentTable.Visible = False
        '
        'chkIF
        '
        Me.chkIF.BackColor = System.Drawing.Color.IndianRed
        Me.chkIF.Location = New System.Drawing.Point(0, 410)
        Me.chkIF.Name = "chkIF"
        Me.chkIF.Size = New System.Drawing.Size(10, 41)
        Me.chkIF.TabIndex = 2
        Me.chkIF.Visible = False
        '
        'chkSub
        '
        Me.chkSub.BackColor = System.Drawing.Color.IndianRed
        Me.chkSub.Location = New System.Drawing.Point(0, 302)
        Me.chkSub.Name = "chkSub"
        Me.chkSub.Size = New System.Drawing.Size(10, 41)
        Me.chkSub.TabIndex = 1
        Me.chkSub.Visible = False
        '
        'chkT
        '
        Me.chkT.BackColor = System.Drawing.Color.IndianRed
        Me.chkT.Location = New System.Drawing.Point(0, 244)
        Me.chkT.Name = "chkT"
        Me.chkT.Size = New System.Drawing.Size(10, 41)
        Me.chkT.TabIndex = 1
        Me.chkT.Visible = False
        '
        'chkHome
        '
        Me.chkHome.BackColor = System.Drawing.Color.IndianRed
        Me.chkHome.Location = New System.Drawing.Point(0, 183)
        Me.chkHome.Name = "chkHome"
        Me.chkHome.Size = New System.Drawing.Size(10, 41)
        Me.chkHome.TabIndex = 0
        '
        'btnStudentTable
        '
        Me.btnStudentTable.BackColor = System.Drawing.Color.Transparent
        Me.btnStudentTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStudentTable.FlatAppearance.BorderSize = 0
        Me.btnStudentTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnStudentTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnStudentTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStudentTable.Font = New System.Drawing.Font("Sylfaen", 17.0!)
        Me.btnStudentTable.ForeColor = System.Drawing.Color.Gray
        Me.btnStudentTable.Image = Global.project.My.Resources.Resources.grid_two_upgray
        Me.btnStudentTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentTable.Location = New System.Drawing.Point(0, 460)
        Me.btnStudentTable.Name = "btnStudentTable"
        Me.btnStudentTable.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnStudentTable.Size = New System.Drawing.Size(192, 55)
        Me.btnStudentTable.TabIndex = 13
        Me.btnStudentTable.Text = "  ตารางเรียน"
        Me.btnStudentTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStudentTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStudentTable.UseVisualStyleBackColor = False
        '
        'btnCondition
        '
        Me.btnCondition.BackColor = System.Drawing.Color.Transparent
        Me.btnCondition.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCondition.FlatAppearance.BorderSize = 0
        Me.btnCondition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnCondition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCondition.Font = New System.Drawing.Font("Sylfaen", 17.0!)
        Me.btnCondition.ForeColor = System.Drawing.Color.Gray
        Me.btnCondition.Image = Global.project.My.Resources.Resources.gearGray
        Me.btnCondition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCondition.Location = New System.Drawing.Point(0, 405)
        Me.btnCondition.Name = "btnCondition"
        Me.btnCondition.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnCondition.Size = New System.Drawing.Size(192, 55)
        Me.btnCondition.TabIndex = 12
        Me.btnCondition.Text = "  เงื่อนไข"
        Me.btnCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCondition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCondition.UseVisualStyleBackColor = False
        '
        'btnClassroom
        '
        Me.btnClassroom.BackColor = System.Drawing.Color.Transparent
        Me.btnClassroom.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClassroom.FlatAppearance.BorderSize = 0
        Me.btnClassroom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnClassroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClassroom.Font = New System.Drawing.Font("Sylfaen", 17.0!)
        Me.btnClassroom.ForeColor = System.Drawing.Color.Gray
        Me.btnClassroom.Image = Global.project.My.Resources.Resources.classroomGray
        Me.btnClassroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClassroom.Location = New System.Drawing.Point(0, 350)
        Me.btnClassroom.Margin = New System.Windows.Forms.Padding(100, 3, 3, 3)
        Me.btnClassroom.Name = "btnClassroom"
        Me.btnClassroom.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnClassroom.Size = New System.Drawing.Size(192, 55)
        Me.btnClassroom.TabIndex = 11
        Me.btnClassroom.Text = "  ห้องเรียน"
        Me.btnClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClassroom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClassroom.UseVisualStyleBackColor = False
        '
        'btnSubject
        '
        Me.btnSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnSubject.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubject.FlatAppearance.BorderSize = 0
        Me.btnSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubject.Font = New System.Drawing.Font("Sylfaen", 17.0!)
        Me.btnSubject.ForeColor = System.Drawing.Color.Gray
        Me.btnSubject.Image = Global.project.My.Resources.Resources.literatureGray
        Me.btnSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubject.Location = New System.Drawing.Point(0, 295)
        Me.btnSubject.Name = "btnSubject"
        Me.btnSubject.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnSubject.Size = New System.Drawing.Size(192, 55)
        Me.btnSubject.TabIndex = 10
        Me.btnSubject.Text = "  วิชา"
        Me.btnSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubject.UseVisualStyleBackColor = False
        '
        'btnTeacher
        '
        Me.btnTeacher.BackColor = System.Drawing.Color.Transparent
        Me.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTeacher.FlatAppearance.BorderSize = 0
        Me.btnTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacher.Font = New System.Drawing.Font("Sylfaen", 17.0!)
        Me.btnTeacher.ForeColor = System.Drawing.Color.Gray
        Me.btnTeacher.Image = Global.project.My.Resources.Resources.add_userGray
        Me.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacher.Location = New System.Drawing.Point(0, 233)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnTeacher.Size = New System.Drawing.Size(192, 62)
        Me.btnTeacher.TabIndex = 9
        Me.btnTeacher.Text = "  ครู"
        Me.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTeacher.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Sylfaen", 17.0!)
        Me.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHome.Image = Global.project.My.Resources.Resources.home_7_24
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 171)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
        Me.btnHome.Size = New System.Drawing.Size(192, 62)
        Me.btnHome.TabIndex = 15
        Me.btnHome.Text = "  หน้าหลัก"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'pnlIcon
        '
        Me.pnlIcon.Controls.Add(Me.picBook)
        Me.pnlIcon.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlIcon.Location = New System.Drawing.Point(0, 0)
        Me.pnlIcon.Name = "pnlIcon"
        Me.pnlIcon.Size = New System.Drawing.Size(192, 171)
        Me.pnlIcon.TabIndex = 8
        '
        'picBook
        '
        Me.picBook.Image = Global.project.My.Resources.Resources.Logo
        Me.picBook.Location = New System.Drawing.Point(21, 16)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(138, 137)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBook.TabIndex = 0
        Me.picBook.TabStop = False
        '
        'pnlTop
        '
        Me.pnlTop.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lbltime)
        Me.pnlTop.Controls.Add(Me.btnMinimized)
        Me.pnlTop.Controls.Add(Me.btnExit)
        Me.pnlTop.Controls.Add(Me.Panel1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1247, 69)
        Me.pnlTop.TabIndex = 32
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Sylfaen", 17.0!)
        Me.lbltime.ForeColor = System.Drawing.Color.White
        Me.lbltime.Location = New System.Drawing.Point(198, 19)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(58, 29)
        Me.lbltime.TabIndex = 36
        Me.lbltime.Text = "time"
        '
        'btnMinimized
        '
        Me.btnMinimized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimized.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimized.BackgroundImage = Global.project.My.Resources.Resources.Black_White_Minimalist_Line_T_shirt_Logo_removebg_preview
        Me.btnMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimized.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMinimized.FlatAppearance.BorderSize = 0
        Me.btnMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimized.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMinimized.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnMinimized.Location = New System.Drawing.Point(1163, 18)
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(33, 30)
        Me.btnMinimized.TabIndex = 35
        Me.btnMinimized.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = Global.project.My.Resources.Resources._1544641784
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(1202, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(33, 30)
        Me.btnExit.TabIndex = 33
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(192, 69)
        Me.Panel1.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.BackgroundImage = Global.project.My.Resources.Resources.BG
        Me.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlMain.Location = New System.Drawing.Point(192, 68)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1055, 632)
        Me.pnlMain.TabIndex = 31
        '
        'btnlockTable
        '
        Me.btnlockTable.BackColor = System.Drawing.Color.Transparent
        Me.btnlockTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnlockTable.FlatAppearance.BorderSize = 0
        Me.btnlockTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnlockTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.btnlockTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlockTable.Font = New System.Drawing.Font("Sylfaen", 17.0!)
        Me.btnlockTable.ForeColor = System.Drawing.Color.Gray
        Me.btnlockTable.Image = Global.project.My.Resources.Resources.grid_two_upgray
        Me.btnlockTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlockTable.Location = New System.Drawing.Point(0, 570)
        Me.btnlockTable.Name = "btnlockTable"
        Me.btnlockTable.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnlockTable.Size = New System.Drawing.Size(192, 55)
        Me.btnlockTable.TabIndex = 17
        Me.btnlockTable.Text = "ล็อกตาราง"
        Me.btnlockTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlockTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlockTable.UseVisualStyleBackColor = False
        '
        'chklockTable
        '
        Me.chklockTable.BackColor = System.Drawing.Color.IndianRed
        Me.chklockTable.Location = New System.Drawing.Point(0, 576)
        Me.chklockTable.Name = "chklockTable"
        Me.chklockTable.Size = New System.Drawing.Size(10, 41)
        Me.chklockTable.TabIndex = 5
        Me.chklockTable.Visible = False
        '
        'Home
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1247, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlMain)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "โปรเเกรมจัดตารางสอน"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlIcon.ResumeLayout(False)
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnStudentTable As Button
    Friend WithEvents btnCondition As Button
    Friend WithEvents btnClassroom As Button
    Friend WithEvents btnSubject As Button
    Friend WithEvents pnlTop As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimized As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents chkRoom As Panel
    Friend WithEvents chkStudentTable As Panel
    Friend WithEvents chkIF As Panel
    Friend WithEvents chkSub As Panel
    Friend WithEvents chkT As Panel
    Friend WithEvents chkHome As Panel
    Friend WithEvents lbltime As Label
    Friend WithEvents btnTeacher As Button
    Friend WithEvents pnlIcon As Panel
    Friend WithEvents picBook As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkTeachersTable As Panel
    Friend WithEvents btnTeachersTable As Button
    Friend WithEvents chklockTable As Panel
    Friend WithEvents btnlockTable As Button
End Class
