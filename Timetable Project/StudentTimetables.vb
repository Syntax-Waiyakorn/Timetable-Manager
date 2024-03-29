﻿
Imports System.Data.OleDb
Public Class StudentTimetables
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
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
            Dim cmd1 As New OleDb.OleDbCommand("Select  " & Field1 & ", " & Field2 & " from " & Table & " WHERE (`SubjectCode` like '%" & txtBox.Text & "%' or `TeacherFirstName` like '%" & txtBox.Text & "%') and ClassroomName=@ClassroomName", conn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("ClassroomName", cboClassrooms.Text)
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
        Dim PDay = 1
        Dim PPeriod = 1
        Dim lblDaysPeriods() As Label = {lblD1P1, lblD1P2, lblD1P3, lblD1P4, lblD1P5, lblD1P6, lblD1P7, lblD1P8, lblD1P9, lblD1P10, lblD1P11,
                                         lblD2P1, lblD2P2, lblD2P3, lblD2P4, lblD2P5, lblD2P6, lblD2P7, lblD2P8, lblD2P9, lblD2P10, lblD2P11,
                                         lblD3P1, lblD3P2, lblD3P3, lblD3P4, lblD3P5, lblD3P6, lblD3P7, lblD3P8, lblD3P09, lblD3P10, lblD3P11,
                                         lblD4P1, lblD4P2, lblD4P3, lblD4P4, lblD4P5, lblD4P6, lblD4P7, lblD4P8, lblD4P9, lblD4P10, lblD4P11,
                                         lblD5P1, lblD5P2, lblD5P3, lblD5P4, lblD5P5, lblD5P6, lblD5P7, lblD5P8, lblD5P9, lblD5P10, lblD5P11}
        For Each PLabel As Label In lblDaysPeriods
            DisplayPeriod(Classroom, PLabel, CStr(PDay), CStr(PPeriod))
            If PPeriod = 11 Then
                PPeriod = 0
                PDay = PDay + 1
            End If
            PPeriod = PPeriod + 1
        Next
    End Sub
    Sub DisplayPeriod(Classroom As String, PLabel As Label, PDay As String, PPeriod As String)
        Dim SubjectCode As String = "null"
        Dim SubjectPlace As String = "null"
        Dim ClassroomCode As String = "null"
        Dim TeacherFirstName As String = "null"

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("SELECT SubjectCode, SubjectPlace, ClassroomCode, TeacherFirstName FROM TimetablesQuery WHERE ClassroomName = @ClassroomName AND DayNumber = @DayNumber AND PeriodNumber = @PeriodNumber", conn)
            cmd.Parameters.AddWithValue("@ClassroomName", Classroom)
            cmd.Parameters.AddWithValue("@DayNumber", PDay)
            cmd.Parameters.AddWithValue("@PeriodNumber", PPeriod)
            dr = cmd.ExecuteReader
            While dr.Read
                SubjectCode = dr.Item("SubjectCode")
                SubjectPlace = dr.Item("SubjectPlace")
                ClassroomCode = dr.Item("ClassroomCode")
                TeacherFirstName = dr.Item("TeacherFirstName")
            End While
            dr.Close()

            If TeacherFirstName = "-" Then
                TeacherFirstName = ""
                If Not SubjectCode = "ว่าง" Then
                    PLabel.BackColor = Color.Orange
                    PLabel.ForeColor = Color.Black
                Else
                    PLabel.BackColor = Color.FromArgb(30, 30, 30)
                    PLabel.ForeColor = Color.White
                End If

            End If
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

    Sub Period_Click(sender As Label, e As EventArgs) Handles lblD1P1.Click, lblD1P2.Click, lblD1P3.Click, lblD1P4.Click, lblD1P5.Click, lblD1P6.Click, lblD1P7.Click, lblD1P8.Click, lblD1P9.Click, lblD1P10.Click, lblD1P11.Click,
                                                              lblD2P1.Click, lblD2P2.Click, lblD2P3.Click, lblD2P4.Click, lblD2P5.Click, lblD2P6.Click, lblD2P7.Click, lblD2P8.Click, lblD2P9.Click, lblD2P10.Click, lblD2P11.Click,
                                                              lblD3P1.Click, lblD3P2.Click, lblD3P3.Click, lblD3P4.Click, lblD3P5.Click, lblD3P6.Click, lblD3P7.Click, lblD3P8.Click, lblD3P09.Click, lblD3P10.Click, lblD3P11.Click,
                                                              lblD4P1.Click, lblD4P2.Click, lblD4P3.Click, lblD4P4.Click, lblD4P5.Click, lblD4P6.Click, lblD4P7.Click, lblD4P8.Click, lblD4P9.Click, lblD4P10.Click, lblD4P11.Click,
                                                              lblD5P1.Click, lblD5P2.Click, lblD5P3.Click, lblD5P4.Click, lblD5P5.Click, lblD5P6.Click, lblD5P7.Click, lblD5P8.Click, lblD5P9.Click, lblD5P10.Click, lblD5P11.Click
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
                Dim again As String = "null"
                Dim cmd4 As New OleDb.OleDbCommand("SELECT ClassroomName ,TeacherIndex FROM TimetablesQuery WHERE DayPeriodIndex = '" + DayPeriodIndex + "' ", conn)
                dr = cmd4.ExecuteReader
                While dr.Read
                    TeacherIndex = dr.Item("TeacherIndex")
                    TeacherIndex.ToString()
                    If TeacherIndex = UserTeacherIndex Then
                        Occupied = True
                        again = dr.Item("ClassroomName")
                    End If
                End While
                dr.Close()

                If Occupied = True Then
                    MsgBox("มันซ้ำที่ห้อง " & again & " ไปเปลี่ยน", vbCritical)
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
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search("TSClassroomsQuery", "TeacherFirstName", "SubjectCode", txtSearch, cboTeachersSubjects)
        status()
    End Sub
    Private Sub cboTeachersSubjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeachersSubjects.SelectedIndexChanged
        Me.agent.Focus()
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