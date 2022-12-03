Imports System.Data.OleDb

Public Class MixmizeHomescreen
    Private Sub Homescreen_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
        conn.Open()
        Dim cmd1 As New OleDb.OleDbCommand("Select count(*) from Teachers", conn)
        Dim cmd2 As New OleDb.OleDbCommand("Select count(*) from Classrooms", conn)
        Dim cmd3 As New OleDb.OleDbCommand("Select count(*) from Subjects", conn)
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
        Dim cmd1 As New OleDb.OleDbCommand("Select count(*) from Teachers", conn)
        Dim cmd2 As New OleDb.OleDbCommand("Select count(*) from Classrooms", conn)
        Dim cmd3 As New OleDb.OleDbCommand("Select count(*) from Subjects", conn)
        Dim count1 = Convert.ToString(cmd1.ExecuteScalar)
        Dim count2 = Convert.ToString(cmd2.ExecuteScalar)
        Dim count3 = Convert.ToString(cmd3.ExecuteScalar)
        lblTea.Text = count1 + " ท่าน"
        lblRoom.Text = count2 + " ห้อง"
        lblbook.Text = count3 + " วิชา"
        conn.Close()
    End Sub

End Class