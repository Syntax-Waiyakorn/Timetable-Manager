Imports System.Data.OleDb
Public Class Homescreen
    Private Sub Homescreen_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
        conn.Open()
        Dim cmd1 As New OleDb.OleDbCommand("Select count('TeachersID') from Teachers", conn)
        Dim cmd2 As New OleDb.OleDbCommand("Select count('ClassroomsID') from Classrooms", conn)
        Dim cmd3 As New OleDb.OleDbCommand("Select count('SubjectsID') from Subjects", conn)
        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
        Dim count2 = Convert.ToString(cmd2.ExecuteScalar)
        Dim count3 = Convert.ToString(cmd3.ExecuteScalar)
        lblTea.Text = count1 + " ท่าน"
        lblRoom.Text = count2 + " ห้อง"
        lblbook.Text = count3 + " วิชา"
        conn.Close()
    End Sub
    Private Sub Homescreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
        conn.Open()
        Dim cmd1 As New OleDb.OleDbCommand("Select count('TeachersID') from Teachers", conn)
        Dim cmd2 As New OleDb.OleDbCommand("Select count('ClassroomsID') from Classrooms", conn)
        Dim cmd3 As New OleDb.OleDbCommand("Select count('SubjectsID') from Subjects", conn)
        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
        Dim count2 = Convert.ToString(cmd2.ExecuteScalar)
        Dim count3 = Convert.ToString(cmd3.ExecuteScalar)
        lblTea.Text = count1 + " ท่าน"
        lblRoom.Text = count2 + " ห้อง"
        lblbook.Text = count3 + " วิชา"
        If Date.Now.ToString("HH") >= 0 Then
            lblHello.Text = "สวัสดีตอนกลางดึก !"
        End If
        If Date.Now.ToString("HH") >= 5 Then
            lblHello.Text = "สวัสดีตอนเช้า !"
        End If
        If Date.Now.ToString("HH") >= 11 Then
            lblHello.Text = "สวัสดีตอนเที่ยง !"
        End If
        If Date.Now.ToString("HH") >= 13 Then
            lblHello.Text = "สวัสดียามบ่าย !"
        End If
        If Date.Now.ToString("HH") > 15 Then
            lblHello.Text = "สวัสดีตอนเย็น !"
        End If
        If Date.Now.ToString("HH") >= 19 Then
            lblHello.Text = "สวัสดีตอนกลางคืน !"
        End If
        conn.Close()
    End Sub
End Class