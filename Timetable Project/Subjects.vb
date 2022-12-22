Imports System.Data.OleDb

Public Class Subjects
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Connection_status.Text = "เชื่อมต่อแล้ว"
            Connection_status.ForeColor = Color.Lime
            Dim cmd As New OleDb.OleDbCommand("Select DepartmentName from Departments", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                cboDepartment.Items.Add(dr.GetString(0))
            End While
        Catch ex As Exception
            Connection_status.Text = "ไม่มีการเชื่อมต่อ"
            Connection_status.ForeColor = Color.Red
        End Try
        conn.Close()
        LoadGrid()
        txtPR.Text = "[ AUTO ]"
        txtPR.Enabled = False
        txtSubjectPlace.Enabled = True
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            txtPR.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtID.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtName.Text = DataGridView1.CurrentRow.Cells(2).Value
            cboDepartment.Text = DataGridView1.CurrentRow.Cells(3).Value

            If DataGridView1.CurrentRow.Cells(4).Value = "ห้องประจำ" Then
                chkDefaultClass.Checked = True
                txtSubjectPlace.Enabled = False
            Else
                chkDefaultClass.Checked = False
                txtSubjectPlace.Text = DataGridView1.CurrentRow.Cells(4).Value
            End If
        Catch
            MsgBox("ข้อมูลขาดหาย", vbOKOnly, "เเจ้งเตือน")
        End Try
    End Sub
    Sub LoadGrid()
        Try
            DataGridView1.Rows.Clear()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("Select  SubjectID, SubjectCode, SubjectName, SubjectDepartment, SubjectPlace, SubjectQuota from Subjects WHERE SubjectSpecial <> True", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("SubjectID"), dr.Item("SubjectCode"), dr.Item("SubjectName"), dr.Item("SubjectDepartment"), dr.Item("SubjectPlace"), dr.Item("SubjectQuota"))
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
        txtSubjectPlace.Clear()

        cboDepartment.SelectedIndex = -1
        chkDefaultClass.CheckState = False
    End Sub

    Sub save()

        Try
            If MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim cmd As New OleDb.OleDbCommand("Insert into Subjects(`SubjectCode`,`SubjectName`,`SubjectDepartment`,`SubjectPlace`) values(@SubjectCode,@SubjectName,@SubjectDepartment,@SubjectPlace)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@SubjectCode", txtID.Text)
                cmd.Parameters.AddWithValue("@SubjectName", txtName.Text)
                cmd.Parameters.AddWithValue("@SubjectDepartment", cboDepartment.Text)
                cmd.Parameters.AddWithValue("@SubjectPlace", txtSubjectPlace.Text)


                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("เพิ่มข้อมูลเเล้ว !", vbInformation)
                Else
                    MsgBox("ผิดพลาด", vbCritical)
                End If
            End If
        Finally
        End Try
        conn.Close()
        LoadGrid()
        clear()
    End Sub
    Sub edit()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("UPDATE Subjects SET `SubjectCode`=@SubjectCode,`SubjectName`=@SubjectName,`SubjectDepartment`=@SubjectDepartment,`SubjectPlace`=@SubjectPlace Where SubjectID=@SubjectID", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@SubjectCode", txtID.Text)
            cmd.Parameters.AddWithValue("@SubjectName", txtName.Text)
            cmd.Parameters.AddWithValue("@SubjectDepartment", cboDepartment.Text)
            cmd.Parameters.AddWithValue("@SubjectPlace", txtSubjectPlace.Text)
            cmd.Parameters.AddWithValue("@SubjectID", txtPR.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("แก้ไขแล้ว !", vbInformation)
            Else
                MsgBox("ผิดพลาด", vbCritical)
            End If
        Catch
            MsgBox("ข้อมูลขาดหาย", vbOKOnly, "เเจ้งเตือน")
        End Try
        conn.Close()
        LoadGrid()
        clear()
    End Sub
    Sub search()
        Try
            DataGridView1.Rows.Clear()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("Select SubjectID, SubjectCode, SubjectName, SubjectDepartment, SubjectPlace from Subjects WHERE (`SubjectName` like '%" & txtSearch.Text & "%' or `SubjectDepartment` like '%" & txtSearch.Text & "%'or `SubjectCode` like '%" & txtSearch.Text & "%'or `SubjectID` like '%" & txtSearch.Text & "%') AND SubjectSpecial <> True", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("SubjectID"), dr.Item("SubjectCode"), dr.Item("SubjectName"), dr.Item("SubjectDepartment"), dr.Item("SubjectPlace"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub delete()
        If MsgBox("คุณต้องการลบหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim cmd As New OleDb.OleDbCommand("SELECT TimetablePeriodID from TimetablesQuery WHERE SubjectID=@SubjectID", conn)
                cmd.Parameters.AddWithValue("@SubjectCode", txtPR.Text)
                dr = cmd.ExecuteReader()
                While dr.Read
                    Dim cmd1 As New OleDb.OleDbCommand("UPDATE TimetablesPeriods SET `TeacherSubjectID` = @TeacherSubjectID Where TimetablePeriodID = @TimetablePeriodID", conn)
                    Print(dr.Item("TimetablePeriodID"))
                    cmd1.Parameters.Clear()
                    cmd1.Parameters.AddWithValue("@TeacherSubjectID", "1")
                    cmd1.Parameters.AddWithValue("@TimetablePeriodID", dr.Item("TimetablePeriodID"))
                End While
                dr.Close()

                Dim cmd2 As New OleDb.OleDbCommand("DELETE FROM Subjects WHERE SubjectID=@SubjectID", conn)
                cmd2.Parameters.Clear()
                cmd2.Parameters.AddWithValue("@SubjectCode", txtPR.Text)

                i = cmd2.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("ลบสำเร็จ !", vbInformation)
                Else
                    MsgBox("ผิดพลาด", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        conn.Close()
        LoadGrid()
        clear()
    End Sub
    Private Sub chkDefaultClass_CheckedChanged(sender As Object, e As EventArgs) Handles chkDefaultClass.CheckedChanged
        If chkDefaultClass.Checked = True Then
            txtSubjectPlace.Enabled = False
            txtSubjectPlace.Text = ("ห้องประจำ")
        Else
            txtSubjectPlace.Enabled = True
            txtSubjectPlace.Clear()
        End If
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
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        edit()
    End Sub
    Private Sub Text_search_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search()
    End Sub
    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        Me.agent.Focus()
    End Sub
    Private Sub txtSubjectNextRequire_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim chr As Char = e.KeyChar
        If Not Char.IsDigit(chr) AndAlso Asc(chr) <> 8 Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSubjectQuota_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim chr As Char = e.KeyChar
        If Not Char.IsDigit(chr) AndAlso Asc(chr) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Class