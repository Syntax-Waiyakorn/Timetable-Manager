Imports System.Data.OleDb



Public Class Homescreen
    Private Sub Homescreen_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
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
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
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
            Me.BackgroundImage = project.My.Resources.Resources.wp9409819_no_copyright_wallpapers
        End If
        If Date.Now.ToString("HH") >= 5 Then
            lblHello.Text = "สวัสดีตอนเช้า !"
            Me.BackgroundImage = project.My.Resources.Resources.wp9637329_no_copyright_wallpapers
        End If
        If Date.Now.ToString("HH") >= 11 Then
            lblHello.Text = "สวัสดีตอนเที่ยง !"
            Me.BackgroundImage = project.My.Resources.Resources.wp9637329_no_copyright_wallpapers
        End If
        If Date.Now.ToString("HH") >= 13 Then
            lblHello.Text = "สวัสดียามบ่าย !"
            Me.BackgroundImage = project.My.Resources.Resources.wp9637329_no_copyright_wallpapers
        End If
        If Date.Now.ToString("HH") > 15 Then
            lblHello.Text = "สวัสดีตอนเย็น !"
            Me.BackgroundImage = project.My.Resources.Resources.wp9637329_no_copyright_wallpapers
        End If
        If Date.Now.ToString("HH") >= 19 Then
            lblHello.Text = "สวัสดีตอนกลางคืน !"
            Me.BackgroundImage = project.My.Resources.Resources.wp9409819_no_copyright_wallpapers
        End If
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(Application.StartupPath & "\Manual.pdf")
    End Sub
End Class