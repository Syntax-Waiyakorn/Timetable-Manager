Imports System.Data.OleDb
Public Class Teachers
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            lblStatus.Text = "เชื่อมต่อแล้ว"
            lblStatus.ForeColor = Color.Lime
            Dim cmd As New OleDb.OleDbCommand("Select DepartmentName from Departments", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                cboTeacherDepartment.Items.Add(dr.GetString(0))
            End While
        Catch ex As Exception
            lblStatus.Text = "ไม่มีการเชื่อมต่อ"
            lblStatus.ForeColor = Color.Red
        End Try
        conn.Close()
        LoadGrid()
        txtPR.Text = "[Auto]"
        txtPR.Enabled = False
    End Sub
    Sub LoadGrid()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select TeacherID, TeacherFirstName, TeacherLastName, TeacherDepartment, TeacherQuota from Teachers", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("TeacherID"), dr.Item("TeacherFirstName"), dr.Item("TeacherLastName"), dr.Item("TeacherDepartment"), dr.Item("TeacherQuota"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        txtPR.Text = DataGridView1.CurrentRow.Cells(0).Value
        txtTeacherFirstName.Text = DataGridView1.CurrentRow.Cells(1).Value
        txtTeacherLastName.Text = DataGridView1.CurrentRow.Cells(2).Value
        cboTeacherDepartment.Text = DataGridView1.CurrentRow.Cells(3).Value
        txtTeacherQuota.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub
    Sub clear()
        txtPR.Text = "[AUTO]"
        txtTeacherFirstName.Clear()
        txtTeacherLastName.Clear()
    End Sub
    Sub save()
        Try
            If MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("Insert into Teachers(`TeacherFirstName`,`TeacherLastName`,`TeacherDepartment`,`TeacherQuota`) values(@TeacherCode,@TeacherFirstName,@TeacherLastName,@TeacherDepartment,@TeacherQuota)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@TeacherFirstName", txtTeacherFirstName.Text)
                cmd.Parameters.AddWithValue("@TeacherLastName", txtTeacherLastName.Text)
                cmd.Parameters.AddWithValue("@TeacherDepartment", cboTeacherDepartment.Text)
                cmd.Parameters.AddWithValue("@TeacherQuota", txtTeacherQuota.Text)
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
            Dim cmd As New OleDb.OleDbCommand("UPDATE Teachers SET `TeacherFirstName`=@TeacherFirstName,`TeacherLastName`=@TeacherLastName,`TeacherDepartment`=@TeacherDepartment,`TeacherQuota`=@TeacherQuota Where TeacherID=@TeacherID ", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@TeacherFirstName", txtTeacherFirstName.Text)
            cmd.Parameters.AddWithValue("@TeacherLastName", txtTeacherLastName.Text)
            cmd.Parameters.AddWithValue("@TeacherDepartment", cboTeacherDepartment.Text)
            cmd.Parameters.AddWithValue("@TeacherQuota", txtTeacherQuota.Text)
            cmd.Parameters.AddWithValue("@TeacherID", txtPR.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("แก้ไขแล้ว!", vbInformation)
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
            Dim cmd As New OleDb.OleDbCommand("Select TeacherID, TeacherFirstName, TeacherLastName, TeacherDepartment from Teachers WHERE `TeacherFirstName` like '%" & txtSearch.Text & "%' or `TeacherLastName` like '%" & txtSearch.Text & "%' or `TeacherDepartment` like '%" & txtSearch.Text & "%' or `TeacherQuota` like '%" & txtSearch.Text & "%' or `TeacherID` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("TeacherID"), dr.Item("TeacherFirstName"), dr.Item("TeacherLastName"), dr.Item("TeacherDepartment"), dr.Item("TeacherQuota"))
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
                Dim cmd As New OleDb.OleDbCommand("Delete from Teachers WHERE TeacherID=@TeacherID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@TeacherID", txtPR.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("ลบสำเร็จ!", vbInformation)
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
    Private Sub cboTeacherDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeacherDepartment.SelectedIndexChanged
        Me.agent.Focus()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        delete()
    End Sub
    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search()
    End Sub
End Class