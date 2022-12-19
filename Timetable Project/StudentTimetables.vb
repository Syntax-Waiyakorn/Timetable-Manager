Imports System.Data.OleDb
Public Class StudentTimetables
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim PLabelName As String = "null"
    Dim PDay As String = "null"
    Dim PPeriod As String = "null"
    Dim TimetableIndex As String = "null"
    Sub LoadCbo()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("Select ClassroomName from Classrooms", conn)
            cboClassrooms.Items.Clear()
            dr = cmd.ExecuteReader
            While dr.Read
                cboClassrooms.Items.Add(dr.GetString(0))
            End While
            dr.Close()
            Dim cmd2 As New OleDb.OleDbCommand("Select YearNumber from Pass", conn)
            dr = cmd2.ExecuteReader
            While dr.Read
                txtYear.Text = CStr(dr.Item("YearNumber"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Sub status()
        If cboClassrooms.SelectedIndex = -1 Then
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
    Sub search(Table As String, Field1 As String, Field2 As String, txtBox As TextBox, cboBox As ComboBox)
        Try
            cboBox.Items.Clear()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd1 As New OleDb.OleDbCommand("Select  " & Field1 & ", " & Field2 & " from " & Table & " WHERE " & Field1 & " like '%" & txtBox.Text & "%' or " & Field2 & " like '%" & txtBox.Text & "%'", conn)
            dr = cmd1.ExecuteReader
            While dr.Read
                cboBox.Items.Add(dr.Item(Field1) & " : " & dr.Item(Field2))
            End While
            dr.Close()
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
                dr.Close()
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
                dr.Close()
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
        Dim lblDaysPeriods() As Label = {lblD1P01, lblD1P02, lblD1P03, lblD1P04, lblD1P05, lblD1P06, lblD1P07, lblD1P08, lblD1P09, lblD1P10, lblD1P11,
                                         lblD2P01, lblD2P02, lblD2P03, lblD2P04, lblD2P05, lblD2P06, lblD2P07, lblD2P08, lblD2P09, lblD2P10, lblD2P11,
                                         lblD3P01, lblD3P02, lblD3P03, lblD3P04, lblD3P05, lblD3P06, lblD3P07, lblD3P08, lblD3P09, lblD3P10, lblD3P11,
                                         lblD4P01, lblD4P02, lblD4P03, lblD4P04, lblD4P05, lblD4P06, lblD4P07, lblD4P08, lblD4P09, lblD4P10, lblD4P11,
                                         lblD5P01, lblD5P02, lblD5P03, lblD5P04, lblD5P05, lblD5P06, lblD5P07, lblD5P08, lblD5P09, lblD5P10, lblD5P11}
        For Each PLabel As Label In lblDaysPeriods
            DisplayPeriod(Classroom, PLabel)
        Next
    End Sub
    Sub DisplayPeriod(Classroom As String, PLabel As Label)
        Dim SubjectCode As String = "null"
        Dim SubjectPlace As String = "null"
        Dim ClassroomCode As String = "null"
        Dim TeacherFirstName As String = "null"

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            PLabelName = PLabel.Name
            PDay = PLabelName.Chars(4)
            PPeriod = CStr(CInt(PLabelName.Chars(6) & PLabelName.Chars(7)))
            TimetableIndex = CStr(Classroom) & "$$" & PDay & "$$" & PPeriod
            Dim cmd As New OleDb.OleDbCommand("SELECT SubjectCode, SubjectPlace, ClassroomCode, TeacherFirstName FROM TimetablesQuery WHERE TimetableIndex = @TimetableIndex", conn)
            cmd.Parameters.AddWithValue("@TimetableIndex", TimetableIndex)
            dr = cmd.ExecuteReader
            While dr.Read
                SubjectCode = dr.Item("SubjectCode")
                SubjectPlace = dr.Item("SubjectPlace")
                ClassroomCode = dr.Item("ClassroomCode")
                TeacherFirstName = dr.Item("TeacherFirstName")
            End While
            dr.Close()

            If Not SubjectPlace = "ห้องประจำ" Then
                ClassroomCode = SubjectPlace
            End If
            PLabel.Text = TeacherFirstName & vbCrLf & SubjectCode & vbCrLf & ClassroomCode
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Sub Period_Click(sender As Label, e As EventArgs) Handles lblD1P01.Click, lblD1P02.Click, lblD1P03.Click, lblD1P04.Click, lblD1P05.Click, lblD1P06.Click, lblD1P07.Click, lblD1P08.Click, lblD1P09.Click, lblD1P10.Click, lblD1P11.Click,
                                                              lblD2P01.Click, lblD2P02.Click, lblD2P03.Click, lblD2P04.Click, lblD2P05.Click, lblD2P06.Click, lblD2P07.Click, lblD2P08.Click, lblD2P09.Click, lblD2P10.Click, lblD2P11.Click,
                                                              lblD3P01.Click, lblD3P02.Click, lblD3P03.Click, lblD3P04.Click, lblD3P05.Click, lblD3P06.Click, lblD3P07.Click, lblD3P08.Click, lblD3P09.Click, lblD3P10.Click, lblD3P11.Click,
                                                              lblD4P01.Click, lblD4P02.Click, lblD4P03.Click, lblD4P04.Click, lblD4P05.Click, lblD4P06.Click, lblD4P07.Click, lblD4P08.Click, lblD4P09.Click, lblD4P10.Click, lblD4P11.Click,
                                                              lblD5P01.Click, lblD5P02.Click, lblD5P03.Click, lblD5P04.Click, lblD5P05.Click, lblD5P06.Click, lblD5P07.Click, lblD5P08.Click, lblD5P09.Click, lblD5P10.Click, lblD5P11.Click
        If Not cboClassrooms.SelectedIndex = -1 Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim lblText As String = sender.Text
                Dim Separaters() = {vbCrLf, ""}
                Dim lblTextSplit() As String = lblText.Split(Separaters, StringSplitOptions.RemoveEmptyEntries)
                Dim Teacher As String = lblTextSplit(0)
                Dim Subject As String = lblTextSplit(1)
                Dim TeacherSubject As String = Teacher & " : " & Subject
                Dim cboIndex = cboTeachersSubjects.FindString(TeacherSubject)
                cboTeachersSubjects.SelectedIndex = cboIndex
                Dim PLabelNameC As String = sender.Name
                Dim PDayC As String = PLabelNameC.Chars(4)
                Dim PPeriodC As String
                Try
                    PPeriodC = PLabelNameC.Chars(6) & PLabelNameC.Chars(7)
                Catch
                    PPeriodC = PLabelNameC.Chars(6)
                End Try
                lblCurrentDay.Tag = PDayC
                lblCurrentPeriod.Tag = PPeriodC
                Dim cmd1 As New OleDb.OleDbCommand("Select TOP 1 DayNumber, DayName from Days WHERE `DayNumber` like '%" & PDayC & "%' ", conn)
                Dim cmd2 As New OleDb.OleDbCommand("Select TOP 1 PeriodNumber, PeriodName  from Periods WHERE `PeriodNumber` like '%" & PPeriodC & "%' ", conn)
                dr = cmd1.ExecuteReader
                While dr.Read
                    lblCurrentDay.Text = dr.Item("DayName")
                    lblCurrentDay.ForeColor = Color.Lime
                End While
                dr = cmd2.ExecuteReader
                While dr.Read
                    lblCurrentPeriod.Text = dr.Item("PeriodName")
                    lblCurrentPeriod.ForeColor = Color.Lime
                End While
            Catch
                MsgBox("วิชา ล็อก อยู่", vbCritical)

            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        Else
            MsgBox("เลือกห้องก่อน", vbYes, "เเจ้งเตืน")
        End If
    End Sub
    Sub edit()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim Classroom As String = cboClassrooms.Text
            Dim TDay As String = lblCurrentDay.Tag
            Dim TPeriod As String = lblCurrentPeriod.Tag
            Dim cboText = cboTeachersSubjects.Text
            Dim Separaters() = {" : "}
            Dim cboTextSplit() As String = cboText.Split(Separaters, StringSplitOptions.RemoveEmptyEntries)
            Dim TeacherFirstName = cboTextSplit(0)
            Dim SubjectName = cboTextSplit(1)
            Dim TimetableIndex As String = Classroom & "$$" & TDay & "$$" & TPeriod
            Dim UserTeacherIndex As String = TeacherFirstName & "$$" & TDay & "$$" & TPeriod
            Dim DayPeriodIndex As String = TDay & "$$" & TPeriod
            Dim TeacherSubjectIndex As String = TeacherFirstName & "$$" & SubjectName
            Dim TimetablePeriodID As String = "null"
            Dim TeacherSubjectID As String = "null"
            Dim TeacherIndex As String = "null"
            Dim Occupied As Boolean = False
            If cboText = "- : ว่าง" Then
                Dim cmd1 As New OleDb.OleDbCommand("SELECT TimetablePeriodID FROM TimetablesQuery WHERE TimetableIndex = '" + TimetableIndex + "'", conn)
                dr = cmd1.ExecuteReader
                While dr.Read
                    TimetablePeriodID = dr.Item("TimetablePeriodID")
                End While
                dr.Close()
                Dim cmd2 As New OleDb.OleDbCommand("SELECT TeacherSubjectID FROM TeachersSubjectsQuery WHERE TeacherSubjectIndex = '" + TeacherSubjectIndex + "'", conn)
                dr = cmd2.ExecuteReader
                While dr.Read
                    TeacherSubjectID = dr.Item("TeacherSubjectID")
                End While
                dr.Close()

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
            Else
                Dim cmd4 As New OleDb.OleDbCommand("SELECT TeacherIndex FROM TimetablesQuery WHERE DayPeriodIndex = '" + DayPeriodIndex + "' ", conn)
                dr = cmd4.ExecuteReader
                While dr.Read
                    TeacherIndex = dr.Item("TeacherIndex")
                    TeacherIndex.ToString()
                    If TeacherIndex = UserTeacherIndex Then
                        Occupied = True
                    End If
                End While
                dr.Close()

                If Occupied = True Then
                    MsgBox("มันซ้ำ ไปเปลี่ยน", vbInformation)
                End If
                If Occupied = False Then
                    Dim cmd1 As New OleDb.OleDbCommand("SELECT TimetablePeriodID FROM TimetablesQuery WHERE TimetableIndex = '" + TimetableIndex + "'", conn)
                    dr = cmd1.ExecuteReader
                    While dr.Read
                        TimetablePeriodID = dr.Item("TimetablePeriodID")
                    End While
                    dr.Close()

                    Dim cmd2 As New OleDb.OleDbCommand("SELECT TeacherSubjectID FROM TeachersSubjectsQuery WHERE TeacherSubjectIndex = '" + TeacherSubjectIndex + "'", conn)
                    dr = cmd2.ExecuteReader
                    While dr.Read
                        TeacherSubjectID = dr.Item("TeacherSubjectID")
                    End While
                    dr.Close()

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
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Sub Year()
        Try
            If MsgBox("คุณต้องบันทึกปีการฯศึกษาหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim cmd As New OleDb.OleDbCommand("UPDATE Pass SET `YearNumber`=@YearNumber ", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@YearNumber", txtYear.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("บันทึกเเล้ว !", vbInformation)
                Else
                    MsgBox("ผิดพลาด", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If cboClassrooms.SelectedIndex = -1 Then
            MsgBox("เลือกห้องก่อน", vbYes, "เเจ้งเตือน")
        Else
            If lblCurrentDay.Text = "ว่าง" Then
                MsgBox("เลือกวันเเละคาบก่อน", vbYes, "เเจ้งเตือน")
            Else
                edit()
            End If
        End If
    End Sub
    Private Sub cboClassrooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClassrooms.SelectedIndexChanged
        Dim Timetables As String
        Timetables = cboClassrooms.Text
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("UPDATE Pass SET `RoomName`=@RoomName ", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@RoomName", Timetables)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd1 As New OleDb.OleDbCommand("Select TeacherSubjectDisplay from TSClassroomsQuery where ClassroomName = @ClassroomName", conn)
            cboTeachersSubjects.Items.Clear()
            cmd1.Parameters.AddWithValue("@ClassroomName", cboClassrooms.Text)
            dr = cmd1.ExecuteReader
            While dr.Read
                cboTeachersSubjects.Items.Add(dr.GetString(0))
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Dim Classroom As String = CStr(cboClassrooms.Text)
        DisplayClassroomTable(Classroom)
        status()
    End Sub
    Private Sub cboTeachersSubjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeachersSubjects.SelectedIndexChanged
        Me.agent.Focus()
        status()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search("TeachersSubjectsQuery", "TeacherFirstName", "SubjectCode", txtSearch, cboTeachersSubjects)
        status()
    End Sub
    Private Sub StudentTimetables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTable()
        status()
    End Sub
    Private Sub StudentTimetables_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        LoadCbo()
        status()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If cboClassrooms.SelectedIndex = -1 Then
            MsgBox("เลือกห้องก่อน", vbYes, "เเจ้งเตือน")
        Else
            Dim StudentTimetablesPrint As New StudentTimetablesPrint
            StudentTimetablesPrint.Show()
        End If
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim OBJ As New TeachersTimetables
        Year()
    End Sub
End Class