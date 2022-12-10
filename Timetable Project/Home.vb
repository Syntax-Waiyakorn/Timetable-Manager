Public Class Home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Maximize()
        switch(Homescreen)
        Timer1.Enabled = True
    End Sub
    Sub switch(panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub
    Sub CheckClear()
        chkHome.Visible = False
        chkT.Visible = False
        chkSub.Visible = False
        chkRoom.Visible = False
        chkIF.Visible = False
        chkStudentTable.Visible = False
        chkTeachersTable.Visible = False
        chklockTable.Visible = False
    End Sub
    Sub Maximize()
        Dim x As Integer = SystemInformation.WorkingArea.Width
        Dim y As Integer = SystemInformation.WorkingArea.Height
        Me.WindowState = FormWindowState.Normal
        Me.Location = New Point(0, 0)
        Me.Size = New Size(x, y)
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        CheckClear()
        chkHome.Visible = True
        switch(Homescreen)
        If chkHome.Visible = True Then
            btnHome.ForeColor = Color.White
            btnTeacher.ForeColor = Color.Gray
            btnSubject.ForeColor = Color.Gray
            btnClassroom.ForeColor = Color.Gray
            btnCondition.ForeColor = Color.Gray
            btnStudentTable.ForeColor = Color.Gray
            btnTeachersTable.ForeColor = Color.Gray
            btnlockTable.ForeColor = Color.Gray


        End If
        If chkHome.Visible = True Then
            btnHome.Image = project.My.Resources.Resources.home_7_24
            btnTeacher.Image = project.My.Resources.Resources.add_userGray
            btnSubject.Image = project.My.Resources.Resources.literatureGray
            btnClassroom.Image = project.My.Resources.Resources.classroomGray
            btnCondition.Image = project.My.Resources.Resources.gearGray
            btnStudentTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnTeachersTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnlockTable.Image = project.My.Resources.Resources.grid_two_upgray


        End If
    End Sub
    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        CheckClear()
        chkT.Visible = True
        switch(Teachers)
        If chkT.Visible = True Then
            btnHome.ForeColor = Color.Gray
            btnTeacher.ForeColor = Color.White
            btnSubject.ForeColor = Color.Gray
            btnClassroom.ForeColor = Color.Gray
            btnCondition.ForeColor = Color.Gray
            btnStudentTable.ForeColor = Color.Gray
            btnTeachersTable.ForeColor = Color.Gray
            btnlockTable.ForeColor = Color.Gray


        End If
        If chkT.Visible = True Then
            btnHome.Image = project.My.Resources.Resources.homeGray
            btnTeacher.Image = project.My.Resources.Resources.add_user_24
            btnSubject.Image = project.My.Resources.Resources.literatureGray
            btnClassroom.Image = project.My.Resources.Resources.classroomGray
            btnCondition.Image = project.My.Resources.Resources.gearGray
            btnStudentTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnTeachersTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnlockTable.Image = project.My.Resources.Resources.grid_two_upgray


        End If
    End Sub
    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        CheckClear()
        chkSub.Visible = True
        switch(Subjects)
        If chkSub.Visible = True Then
            btnHome.ForeColor = Color.Gray
            btnTeacher.ForeColor = Color.Gray
            btnSubject.ForeColor = Color.White
            btnClassroom.ForeColor = Color.Gray
            btnCondition.ForeColor = Color.Gray
            btnStudentTable.ForeColor = Color.Gray
            btnlockTable.ForeColor = Color.Gray

        End If
        If chkSub.Visible = True Then
            btnHome.Image = project.My.Resources.Resources.homeGray
            btnTeacher.Image = project.My.Resources.Resources.add_userGray
            btnSubject.Image = project.My.Resources.Resources.literature_24
            btnClassroom.Image = project.My.Resources.Resources.classroomGray
            btnCondition.Image = project.My.Resources.Resources.gearGray
            btnStudentTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnTeachersTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnlockTable.Image = project.My.Resources.Resources.grid_two_upgray


        End If
    End Sub
    Private Sub btnClassroom_Click(sender As Object, e As EventArgs) Handles btnClassroom.Click
        CheckClear()
        chkRoom.Visible = True
        switch(Classrooms)
        If chkRoom.Visible = True Then
            btnHome.ForeColor = Color.Gray
            btnTeacher.ForeColor = Color.Gray
            btnSubject.ForeColor = Color.Gray
            btnClassroom.ForeColor = Color.White
            btnCondition.ForeColor = Color.Gray
            btnStudentTable.ForeColor = Color.Gray
            btnTeachersTable.ForeColor = Color.Gray
            btnlockTable.ForeColor = Color.Gray
        End If
        If chkRoom.Visible = True Then
            btnHome.Image = project.My.Resources.Resources.homeGray
            btnTeacher.Image = project.My.Resources.Resources.add_userGray
            btnSubject.Image = project.My.Resources.Resources.literatureGray
            btnClassroom.Image = project.My.Resources.Resources.classroom_24
            btnCondition.Image = project.My.Resources.Resources.gearGray
            btnStudentTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnTeachersTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnlockTable.Image = project.My.Resources.Resources.grid_two_upgray
        End If
    End Sub
    Private Sub btnCondition_Click(sender As Object, e As EventArgs) Handles btnCondition.Click
        CheckClear()
        chkIF.Visible = True
        switch(Condition)
        If chkIF.Visible = True Then
            btnHome.ForeColor = Color.Gray
            btnTeacher.ForeColor = Color.Gray
            btnSubject.ForeColor = Color.Gray
            btnClassroom.ForeColor = Color.Gray
            btnCondition.ForeColor = Color.White
            btnStudentTable.ForeColor = Color.Gray
            btnTeachersTable.ForeColor = Color.Gray
            btnlockTable.ForeColor = Color.Gray


        End If
        If chkIF.Visible = True Then
            btnHome.Image = project.My.Resources.Resources.homeGray
            btnTeacher.Image = project.My.Resources.Resources.add_userGray
            btnSubject.Image = project.My.Resources.Resources.literatureGray
            btnClassroom.Image = project.My.Resources.Resources.classroomGray
            btnCondition.Image = project.My.Resources.Resources.gear_24
            btnStudentTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnTeachersTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnlockTable.Image = project.My.Resources.Resources.grid_two_upgray


        End If
    End Sub
    Private Sub btnTable_Click(sender As Object, e As EventArgs) Handles btnStudentTable.Click
        CheckClear()
        chkStudentTable.Visible = True
        switch(StudentTimetables)
        If chkStudentTable.Visible = True Then
            btnHome.ForeColor = Color.Gray
            btnTeacher.ForeColor = Color.Gray
            btnSubject.ForeColor = Color.Gray
            btnClassroom.ForeColor = Color.Gray
            btnCondition.ForeColor = Color.Gray
            btnStudentTable.ForeColor = Color.White
            btnTeachersTable.ForeColor = Color.Gray
            btnlockTable.ForeColor = Color.Gray


        End If
        If chkStudentTable.Visible = True Then
            btnHome.Image = project.My.Resources.Resources.homeGray
            btnTeacher.Image = project.My.Resources.Resources.add_userGray
            btnSubject.Image = project.My.Resources.Resources.literatureGray
            btnClassroom.Image = project.My.Resources.Resources.classroomGray
            btnCondition.Image = project.My.Resources.Resources.gearGray
            btnStudentTable.Image = project.My.Resources.Resources.grid_two_up_24
            btnTeachersTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnlockTable.Image = project.My.Resources.Resources.grid_two_upgray


        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim ClosePage As New CloseTab
        ClosePage.Show()
    End Sub
    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTeachersTable.Click
        CheckClear()
        chkTeachersTable.Visible = True
        switch(TeachersTimetables)
        If chkTeachersTable.Visible = True Then
            btnHome.ForeColor = Color.Gray
            btnTeacher.ForeColor = Color.Gray
            btnSubject.ForeColor = Color.Gray
            btnClassroom.ForeColor = Color.Gray
            btnCondition.ForeColor = Color.Gray
            btnStudentTable.ForeColor = Color.Gray
            btnTeachersTable.ForeColor = Color.White
            btnlockTable.ForeColor = Color.Gray

        End If
        If chkTeachersTable.Visible = True Then
            btnHome.Image = project.My.Resources.Resources.homeGray
            btnTeacher.Image = project.My.Resources.Resources.add_userGray
            btnSubject.Image = project.My.Resources.Resources.literatureGray
            btnClassroom.Image = project.My.Resources.Resources.classroomGray
            btnCondition.Image = project.My.Resources.Resources.gearGray
            btnStudentTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnTeachersTable.Image = project.My.Resources.Resources.grid_two_up_24
            btnlockTable.Image = project.My.Resources.Resources.grid_two_upgray

        End If
    End Sub

    Private Sub btnlockTable_Click(sender As Object, e As EventArgs) Handles btnlockTable.Click
        CheckClear()
        chklockTable.Visible = True
        switch(lockTable)
        If chklockTable.Visible = True Then
            btnHome.ForeColor = Color.Gray
            btnTeacher.ForeColor = Color.Gray
            btnSubject.ForeColor = Color.Gray
            btnClassroom.ForeColor = Color.Gray
            btnCondition.ForeColor = Color.Gray
            btnStudentTable.ForeColor = Color.Gray
            btnTeachersTable.ForeColor = Color.Gray
            btnlockTable.ForeColor = Color.White
        End If
        If chklockTable.Visible = True Then
            btnHome.Image = project.My.Resources.Resources.homeGray
            btnTeacher.Image = project.My.Resources.Resources.add_userGray
            btnSubject.Image = project.My.Resources.Resources.literatureGray
            btnClassroom.Image = project.My.Resources.Resources.classroomGray
            btnCondition.Image = project.My.Resources.Resources.gearGray
            btnStudentTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnTeachersTable.Image = project.My.Resources.Resources.grid_two_upgray
            btnlockTable.Image = project.My.Resources.Resources.grid_two_up_24
        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = Date.Now.ToString("   วันที่ dd เดือน MMMM ปี yyyy เวลา HH:mm:ss จัดทำโดย") + " ทีม Syntax"
    End Sub
End Class


