Imports System.Data.OleDb
Public Class MixmizeSubjects
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Connection_status.Text = "เชื่อมต่อแล้ว"
            Connection_status.ForeColor = Color.Lime
        Catch ex As Exception
            Connection_status.Text = "ไม่มีการเชื่อมต่อ"
            Connection_status.ForeColor = Color.Red
        End Try
        conn.Close()
        LoadGrid()
        txtPR.Text = "[ AUTO ]"
        txtPR.Enabled = False
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtPR.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtID.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtName.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtRoom.Text = DataGridView1.CurrentRow.Cells(3).Value
    End Sub
    Sub LoadGrid()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from Subjects", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("SubjectID"), dr.Item("SubjectCode"), dr.Item("SubjectName"), dr.Item("SubjectDepartment"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub clear()
        txtPR.Text = "[AUTO]"
        txtID.Clear()
        txtName.Clear()
        txtRoom.Clear()
    End Sub
    Sub save()
        Try
            If MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("Insert into Subjects(`SubjectCode`,`SubjectName`,`SubjectDepartment`) values(@SubjectCode,@SubjectName,@SubjectDepartment)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@SubjectCode", txtID.Text)
                cmd.Parameters.AddWithValue("@SubjectName", txtName.Text)
                cmd.Parameters.AddWithValue("@SubjectDepartment", txtRoom.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("เพิ่มข้อมูลเเล้ว !", vbInformation)
                Else
                    MsgBox("ผิดพลาด", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        LoadGrid()
        clear()
    End Sub
    Sub edit()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("UPDATE Subjects SET `SubjectCode`=@SubjectCode,`SubjectName`=@SubjectName,`SubjectDepartment`=@SubjectDepartment Where SubjectID=@SubjectID ", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@SubjectCode", txtID.Text)
            cmd.Parameters.AddWithValue("@SubjectName", txtName.Text)
            cmd.Parameters.AddWithValue("@SubjectDepartment", txtRoom.Text)
            cmd.Parameters.AddWithValue("@SubjectID", txtPR.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("แก้ไขแล้ว !", vbInformation)
            Else
                MsgBox("ผิดพลาด", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        LoadGrid()
        clear()
    End Sub
    Sub search()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from Subjects WHERE `SubjectName` like '%" & txtSearch.Text & "%' or `SubjectDepartment` like '%" & txtSearch.Text & "%'or `SubjectCode` like '%" & txtSearch.Text & "%'or `SubjectID` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("SubjectID"), dr.Item("SubjectCode"), dr.Item("SubjectName"), dr.Item("SubjectDepartment"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub delete()
        Try
            If MsgBox("คุณต้องการลบหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("Delete from Subjects WHERE SubjectCode=@SubjectCode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@SubjectCode", txtID.Text)
                cmd.Parameters.AddWithValue("@SubjectName", txtName.Text)
                cmd.Parameters.AddWithValue("@SubjectDepartment", txtRoom.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("ลบสำเร็จ !", vbInformation)
                Else
                    MsgBox("ผิดพลาด", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()
        LoadGrid()
        clear()
    End Sub
    Private Sub btnSvae_Click(sender As Object, e As EventArgs) Handles btnSvae.Click
        save()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        delete()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit()
    End Sub
    Private Sub Text_search_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search()
    End Sub
End Class
