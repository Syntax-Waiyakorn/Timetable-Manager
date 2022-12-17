Imports System.Data.OleDb
Public Class LockTable
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim PLabelName As String = "null"
    Dim PDay As String = "null"
    Dim PPeriod As String = "null"
    Dim TimetableIndex As String = "null"
    Dim SubjectID As Integer
    Sub LoadCbo()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("Select ClassroomName from Classrooms", conn)
            Dim cmd1 As New OleDb.OleDbCommand("Select SubjectName from Subjects where SubjectSpecial =@SubjectSpecial", conn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@SubjectSpecial", True)
            Dim cmd2 As New OleDb.OleDbCommand("Select YearNumber from Years", conn)
            Dim cmd3 As New OleDb.OleDbCommand("Select ClassroomName from Classrooms", conn)
            Dim cmd4 As New OleDb.OleDbCommand("Select DepartmentName from Departments", conn)

            ChackClassrooms.Items.Clear()
            dr = cmd.ExecuteReader
            While dr.Read
                ChackClassrooms.Items.Add(dr.GetString(0))
            End While
            cboTeachersSubjects.Items.Clear()
            dr = cmd1.ExecuteReader
            While dr.Read
                cboTeachersSubjects.Items.Add(dr.GetString(0))
            End While
            ChackClassrooms.Items.Clear()
            dr = cmd3.ExecuteReader
            While dr.Read
                ChackClassrooms.Items.Add(dr.GetString(0))
            End While
            dr = cmd4.ExecuteReader
            While dr.Read
                cboSubjectDepartment.Items.Add(dr.GetString(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        LoadGrid()
        clear()
    End Sub
    Sub cboteacherSubject()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd1 As New OleDb.OleDbCommand("Select SubjectName from Subjects where SubjectSpecial =@SubjectSpecial", conn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@SubjectSpecial", True)
            cboTeachersSubjects.Items.Clear()
            dr = cmd1.ExecuteReader
            While dr.Read
                cboTeachersSubjects.Items.Add(dr.GetString(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub status()
        If ChackClassrooms.SelectedIndex = -1 Then
            txtSearch.Enabled = False
            cboTeachersSubjects.Enabled = False
            Connection_status.Text = "กรุณาเลือกห้อง"
            lblCurrentDay.Text = "ว่าง"
            lblCurrentPeriod.Text = "ว่าง"
            Connection_status.ForeColor = Color.Red
            lblCurrentDay.ForeColor = Color.Red
            lblCurrentPeriod.ForeColor = Color.Red
        Else
            txtSearch.Enabled = True
            cboTeachersSubjects.Enabled = True
            If cboTeachersSubjects.SelectedIndex = -1 Then
                Connection_status.Text = "กรุณาเลือกข้อมูล"
                Connection_status.ForeColor = Color.Red
            Else
                Connection_status.Text = "พร้อมเเก้ไข"
                Connection_status.ForeColor = Color.Lime
            End If
        End If
    End Sub
    Sub search(Table As String, Field1 As String, txtBox As TextBox, cboBox As ComboBox)
        Try
            cboBox.Items.Clear()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                Dim cmd1 As New OleDb.OleDbCommand("Select " & Field1 & " from " & Table & " WHERE `SubjectName` like '%" & txtSearch.Text & "%' and SubjectSpecial=@SubjectSpecial", conn)
                cmd1.Parameters.Clear()
                cmd1.Parameters.AddWithValue("@SubjectSpecial", True)

                dr = cmd1.ExecuteReader
                While dr.Read
                    cboBox.Items.Add(dr.Item(Field1))
                End While
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Sub InitializeTable()
        Dim lblDays() As Label = {lblDay1, lblDay2, lblDay3, lblDay4, lblDay5}
        Dim lblPeriods() As Label = {lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11}
        Dim lblTimes() As Label = {lblTime1, lblTime2, lblTime3, lblTime4, lblTime5, lblTime6, lblTime7, lblTime8, lblTime9, lblTime10, lblTime11}
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            For i As Integer = 1 To 5
                Dim cmd As New OleDb.OleDbCommand("SELECT DayName FROM Days WHERE DayNumber = @DayNumber", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@DayNumber", i)
                dr = cmd.ExecuteReader
                While dr.Read
                    lblDays(i - 1).Text = CStr(dr.Item("DayName"))
                End While
            Next
            For i As Integer = 1 To 11
                Dim cmd As New OleDb.OleDbCommand("Select PeriodNumber, PeriodName, PeriodTimeStart, PeriodTimeEnd from Periods WHERE PeriodNumber = @PeriodNumber", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PeriodNumber", i)
                dr = cmd.ExecuteReader
                While dr.Read
                    lblPeriods(i - 1).Text = CStr(dr.Item("PeriodName"))
                    lblTimes(i - 1).Text = CStr(dr.Item("PeriodTimeStart")) + "-" + CStr(dr.Item("PeriodTimeEnd"))
                End While
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Sub DisplayClassroomTable(Classroom As String)
        Dim lblDaysPeriods() As Label = {lblD1P1, lblD1P2, lblD1P3, lblD1P4, lblD1P5, lblD1P6, lblD1P7, lblD1P8, lblD1P9, lblD1P10, lblD1P11,
                                         lblD2P1, lblD2P2, lblD2P3, lblD2P4, lblD2P5, lblD2P6, lblD2P7, lblD2P8, lblD2P9, lblD2P10, lblD2P11,
                                         lblD3P1, lblD3P2, lblD3P3, lblD3P4, lblD3P5, lblD3P6, lblD3P7, lblD3P8, lblD3P9, lblD3P10, lblD3P11,
                                         lblD4P1, lblD4P2, lblD4P3, lblD4P4, lblD4P5, lblD4P6, lblD4P7, lblD4P8, lblD4P9, lblD4P10, lblD4P11,
                                         lblD5P1, lblD5P2, lblD5P3, lblD5P4, lblD5P5, lblD5P6, lblD5P7, lblD5P8, lblD5P9, lblD5P10, lblD5P11}
        For Each PLabel As Label In lblDaysPeriods
            DisplayPeriod(Classroom, PLabel)
        Next
    End Sub
    Sub DisplayPeriod(Classroom As String, PLabel As Label)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            PLabelName = PLabel.Name
            PDay = PLabelName.Chars(4)
            Try
                PPeriod = PLabelName.Chars(6) & PLabelName.Chars(7)
            Catch
                PPeriod = PLabelName.Chars(6)
            End Try
            PLabel.Text = "ว่าง"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Sub Period_Click(sender As Label, e As EventArgs) Handles lblD1P1.Click, lblD1P2.Click, lblD1P3.Click, lblD1P4.Click, lblD1P5.Click, lblD1P6.Click, lblD1P7.Click, lblD1P8.Click, lblD1P9.Click, lblD1P10.Click, lblD1P11.Click,
                                                              lblD2P1.Click, lblD2P2.Click, lblD2P3.Click, lblD2P4.Click, lblD2P5.Click, lblD2P6.Click, lblD2P7.Click, lblD2P8.Click, lblD2P9.Click, lblD2P10.Click, lblD2P11.Click,
                                                              lblD3P1.Click, lblD3P2.Click, lblD3P3.Click, lblD3P4.Click, lblD3P5.Click, lblD3P6.Click, lblD3P7.Click, lblD3P8.Click, lblD3P9.Click, lblD3P10.Click, lblD3P11.Click,
                                                              lblD4P1.Click, lblD4P2.Click, lblD4P3.Click, lblD4P4.Click, lblD4P5.Click, lblD4P6.Click, lblD4P7.Click, lblD4P8.Click, lblD4P9.Click, lblD4P10.Click, lblD4P11.Click,
                                                              lblD5P1.Click, lblD5P2.Click, lblD5P3.Click, lblD5P4.Click, lblD5P5.Click, lblD5P6.Click, lblD5P7.Click, lblD5P8.Click, lblD5P9.Click, lblD5P10.Click, lblD5P11.Click
        Try
            Dim lblName As String = sender.Name
            Dim lblPeriod As Integer
            Dim lblDay As String = lblName.Chars(4)
            Dim lblDayName As String = "null"
            Dim PLabelNameC As String = sender.Name
            Dim PDayC As String = PLabelNameC.Chars(4)
            Dim PPeriodC As String
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("Select DayName From Days Where DayNumber = '" + lblDay + "' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                lblDayName = dr.Item("DayName")
            End While

            lblCurrentDay.Text = lblDayName
            lblCurrentDay.ForeColor = Color.Lime
            Try
                lblPeriod = lblName.Chars(6) & lblName.Chars(7)
                lblCurrentPeriod.Text = lblPeriod - 1
                lblCurrentPeriod.ForeColor = Color.Lime
            Catch ex As Exception
                lblPeriod = lblName.Chars(6) & Int(0)
                lblCurrentPeriod.Text = lblPeriod / 10 - 1
                lblCurrentPeriod.ForeColor = Color.Lime
            End Try
            Try
                PPeriodC = PLabelNameC.Chars(6) & PLabelNameC.Chars(7)
            Catch
                PPeriodC = PLabelNameC.Chars(6)
            End Try
            lblCurrentDay.Tag = PDayC
            lblCurrentPeriod.Tag = PPeriodC

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub Savelook()
        Dim selectedItems As String() = ChackClassrooms.CheckedItems.OfType(Of String)().ToArray()
        Dim itemsString As String = String.Join(vbCrLf, selectedItems)
        Console.WriteLine(itemsString)

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim SubjectCode As String = "null"
            Dim Classroom As String = ChackClassrooms.Text
            Dim TDay As String = lblCurrentDay.Tag
            Dim TPeriod As String = lblCurrentPeriod.Tag
            Dim cboText As String = cboTeachersSubjects.Text
            Dim TeacherFirstName As String = "-"
            Dim SubjectName = cboText
            Dim TimetableIndex As String = Classroom & "$$" & TDay & "$$" & TPeriod
            Dim UserTeacherIndex As String = TeacherFirstName & "$$" & TDay & "$$" & TPeriod
            Dim DayPeriodIndex As String = TDay & "$$" & TPeriod
            Dim TimetablePeriodID As String = "null"

            Dim cmd As New OleDb.OleDbCommand("SELECT SubjectCode FROM Subjects WHERE SubjectName = '" + SubjectName + "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                SubjectCode = dr.Item("SubjectCode")
            End While

            Dim TeacherSubjectIndex As String = TeacherFirstName & "$$" & SubjectCode
            Dim TeacherSubjectID As String = "null"
            Dim TeacherIndex As String = "null"

            Dim cmd1 As New OleDb.OleDbCommand("SELECT TimetablePeriodID FROM TimetablesQuery WHERE TimetableIndex = '" + TimetableIndex + "'", conn)
            dr = cmd1.ExecuteReader
            While dr.Read
                TimetablePeriodID = dr.Item("TimetablePeriodID")
            End While

            Dim cmd2 As New OleDb.OleDbCommand("SELECT TeacherSubjectID FROM TeachersSubjectsQuery WHERE TeacherSubjectIndex = '" + TeacherSubjectIndex + "'", conn)
            dr = cmd2.ExecuteReader
            While dr.Read
                TeacherSubjectID = dr.Item("TeacherSubjectID")
            End While

            Dim cmd3 As New OleDb.OleDbCommand("UPDATE TimetablesPeriods SET `TeacherSubjectID`=@TeacherSubjectID Where TimetablePeriodID=@TimetablePeriodID", conn)
            cmd3.Parameters.Clear()
            cmd3.Parameters.AddWithValue("@TeacherSubjectID", TeacherSubjectID)
            cmd3.Parameters.AddWithValue("TimetablePeriodID", TimetablePeriodID)

            If cmd3.ExecuteNonQuery > 0 Then
                MsgBox("แก้ไขแล้ว!", vbInformation)
            Else
                MsgBox("ผิดพลาด", vbCritical)
            End If
            DisplayClassroomTable(Classroom)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub LoadGrid()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select  SubjectCode, SubjectName, SubjectDepartment, SubjectPlace from Subjects where SubjectSpecial =@SubjectSpecial ", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@SubjectSpecial", True)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("SubjectCode"), dr.Item("SubjectName"), dr.Item("SubjectDepartment"), dr.Item("SubjectPlace"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub ID()
        Dim SubjectID As Integer

        Dim cmd1 As New OleDb.OleDbCommand("SELECT SubjectID FROM Subjects WHERE SubjectCode = '" + SubjectCodeBox.Text + "' ", conn)
        dr = cmd1.ExecuteReader
        While dr.Read
            SubjectID = dr.Item("SubjectID")
        End While
        dr.Close()

        Dim cmd3 As New OleDb.OleDbCommand("Insert into TeachersSubjects(`TeacherID`,`SubjectID`) values(@TeacherID,@SubjectID)", conn)
        cmd3.Parameters.Clear()
        cmd3.Parameters.AddWithValue("@TeacherID", 1)
        cmd3.Parameters.AddWithValue("@SubjectID", SubjectID)
        cmd3.ExecuteNonQuery()
    End Sub
    Sub clear()
        SubjectCodeBox.Clear()
        SubjectNameBox.Clear()
        cboSubjectDepartment.SelectedIndex = -1
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ChackClassrooms.SelectedIndex = -1 Then
            MsgBox("เลือกห้องก่อน", vbYes, "เเจ้งเตือน")
        Else
            If lblCurrentDay.Text = "ว่าง" Then
                MsgBox("เลือกวันเเละคาบก่อน", vbYes, "เเจ้งเตือน")
            Else
                Savelook()
            End If
        End If
    End Sub
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            If MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("Insert into Subjects(`SubjectCode`,`SubjectName`,`SubjectDepartment`,`SubjectPlace`,`SubjectSpecial`,`SubjectQuota`) values(@SubjectCode,@SubjectName,@SubjectDepartment,@SubjectPlace,@SubjectSpecial,@SubjectQuota)", conn)
                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@SubjectCode", SubjectCodeBox.Text)
                cmd.Parameters.AddWithValue("@SubjectName", SubjectNameBox.Text)
                cmd.Parameters.AddWithValue("@SubjectDepartment", cboSubjectDepartment.Text)
                cmd.Parameters.AddWithValue("@SubjectPlace", "")
                cmd.Parameters.AddWithValue("@SubjectSpecial", True)
                cmd.Parameters.AddWithValue("@SubjectQuota", 0)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("เพิ่มข้อมูลเเล้ว !", vbInformation)
                Else
                    MsgBox("ผิดพลาด", vbCritical)
                End If
                ID()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        LoadGrid()
        clear()
        cboteacherSubject()
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try
            If MsgBox("คุณต้องการลบหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("Delete from Subjects WHERE SubjectCode=@SubjectCode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@SubjectCode", SubjectCodeBox.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("ลบสำเร็จ !", vbInformation)
                Else
                    MsgBox("ผิดพลาด", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        LoadGrid()
        clear()
        cboteacherSubject()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        SubjectCodeBox.Text = DataGridView1.CurrentRow.Cells(0).Value
        SubjectNameBox.Text = DataGridView1.CurrentRow.Cells(1).Value
        cboSubjectDepartment.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub
    Private Sub cboTeachersSubjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeachersSubjects.SelectedIndexChanged
        Me.agent.Focus()
        status()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search("Subjects", "SubjectName", txtSearch, cboTeachersSubjects)
        status()
    End Sub
    Private Sub StudentTimetables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCbo()
        InitializeTable()
        status()
    End Sub
    Private Sub StudentTimetables_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        status()
    End Sub
    Private Sub ChackClassrooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChackClassrooms.SelectedIndexChanged
        status()
    End Sub
End Class