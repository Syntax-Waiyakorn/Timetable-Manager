Imports System.Data.OleDb

Public Class Table
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader
    Private Sub Table_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("Select * from Classrooms", conn)
        Dim cmd1 As New OleDb.OleDbCommand("Select * from Teachers", conn)
        Dim cmd2 As New OleDb.OleDbCommand("Select * from Subjects", conn)

        cboClassrooms.Items.Clear()
        dr = cmd.ExecuteReader
        While dr.Read
            cboClassrooms.Items.Add(dr.GetString(1))
        End While

        cboTeachers.Items.Clear()
        dr = cmd1.ExecuteReader
        While dr.Read
            cboTeachers.Items.Add(dr.GetString(1))
        End While

        cboSubjects.Items.Clear()
        dr = cmd2.ExecuteReader
        While dr.Read
            cboSubjects.Items.Add(dr.GetString(2) + " " + dr.GetString(1))
        End While

        conn.Close()
        InitializeTable()
    End Sub
    Sub InitializeTable()
        Dim lblDays() As Label = {lblDay1, lblDay2, lblDay3, lblDay4, lblDay5}
        Dim lblPeriods() As Label = {lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11}
        Dim lblTimes() As Label = {lblTime1, lblTime2, lblTime3, lblTime4, lblTime5, lblTime6, lblTime7, lblTime8, lblTime9, lblTime10, lblTime11}
        Try
            conn.Open()
            For i As Integer = 1 To 5
                Dim cmd As New OleDb.OleDbCommand("Select TOP 1 * from Days WHERE `DayNumber` like '%" & CStr(i) & "%' ", conn)
                dr = cmd.ExecuteReader
                While dr.Read
                    lblDays(i - 1).Text = CStr(dr.Item("DayName"))
                End While
            Next
            For i As Integer = 1 To 11
                Dim cmd As New OleDb.OleDbCommand("Select TOP 1 * from Periods WHERE `PeriodID` like '%" & CStr(i) & "%' ", conn)
                dr = cmd.ExecuteReader
                While dr.Read
                    lblPeriods(i - 1).Text = CStr(dr.Item("PeriodNumber"))
                    lblTimes(i - 1).Text = CStr(dr.Item("PeriodTimeStart")) + "-" + CStr(dr.Item("PeriodTimeEnd"))
                End While
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub DisplayClassroomTable(Classroom As String)
        Dim lblPeriods() As Label = {lblD1P1, lblD1P2, lblD1P3, lblD1P4, lblD1P5, lblD1P6, lblD1P7, lblD1P8, lblD1P9, lblD1P10, lblD1P11,
                                     lblD2P1, lblD2P2, lblD2P3, lblD2P4, lblD2P5, lblD2P6, lblD2P7, lblD2P8, lblD2P9, lblD2P10, lblD2P11,
                                     lblD3P1, lblD3P2, lblD3P3, lblD3P4, lblD3P5, lblD3P6, lblD3P7, lblD3P8, lblD3P9, lblD3P10, lblD3P11,
                                     lblD4P1, lblD4P2, lblD4P3, lblD4P4, lblD4P5, lblD4P6, lblD4P7, lblD4P8, lblD4P9, lblD4P10, lblD4P11,
                                     lblD5P1, lblD5P2, lblD5P3, lblD5P4, lblD5P5, lblD5P6, lblD5P7, lblD5P8, lblD5P9, lblD5P10, lblD5P11}
        For Each PLabel As Label In lblPeriods
            DisplayPeriod(Classroom, PLabel)
        Next
    End Sub
    Sub DisplayPeriod(Classroom As String, PLabel As Label)
        Try
            conn.Open()
            Dim PLabelName As String = PLabel.Name
            Dim PDay As String = PLabelName.Chars(4)
            Dim PPeriod As String
            Try
                PPeriod = CStr(PLabelName.Chars(6)) & CStr(PLabelName.Chars(7))
            Catch
                PPeriod = PLabelName.Chars(6)
            End Try
            Dim TimetableIndex As String = CStr(Classroom) & "$$" & PDay & "$$" & PPeriod
            Dim cmd As New OleDb.OleDbCommand("SELECT * FROM Timetable WHERE TimetableIndex = '" + TimetableIndex + "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                PLabel.Text = CStr(dr.Item("TeacherFirstName")) & vbCrLf & CStr(dr.Item("SubjectCode")) & vbCrLf & CStr(dr.Item("ClassroomCode"))
            End While
            conn.Close()
        Catch ex As Exception
                MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cboClassrooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClassrooms.SelectedIndexChanged
        Dim Classroom As String = CStr(cboClassrooms.Text)
        DisplayClassroomTable(Classroom)
    End Sub

End Class