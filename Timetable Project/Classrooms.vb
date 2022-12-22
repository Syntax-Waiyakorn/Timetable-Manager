Imports System.Data.OleDb
Public Class Classrooms
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer

    Dim ClassroomID As String = "null"
    Dim ClassroomDayID As String = "null"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
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
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Try
            txtPR.Text = DataGridView1.CurrentRow.Cells(0).Value
            txtID.Text = DataGridView1.CurrentRow.Cells(1).Value
            txtName.Text = DataGridView1.CurrentRow.Cells(2).Value
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
            Dim cmd As New OleDb.OleDbCommand("Select ClassroomID,ClassroomCode,ClassroomName from Classrooms", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ClassroomID"), dr.Item("ClassroomCode"), dr.Item("ClassroomName"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub clear()
        txtPR.Text = "[ AUTO ]"
        txtID.Clear()
        txtName.Clear()
    End Sub
    Sub save()
        Try
            If MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim cmd As New OleDb.OleDbCommand("INSERT into Classrooms(`ClassroomCode`,`ClassroomName`) values(@ClassroomCode,@ClassroomName)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ClassroomCode", txtID.Text)
                cmd.Parameters.AddWithValue("@ClassroomName", txtName.Text)
                cmd.ExecuteNonQuery()

                Dim cmd1 As New OleDb.OleDbCommand("SELECT ClassroomID from Classrooms WHERE ClassroomCode=@ClassroomCode AND ClassroomName=@ClassroomName", conn)
                cmd1.Parameters.Clear()
                cmd1.Parameters.AddWithValue("@ClassroomCode", txtID.Text)
                cmd1.Parameters.AddWithValue("@ClassroomName", txtName.Text)
                dr = cmd1.ExecuteReader
                While dr.Read()
                    ClassroomID = dr.Item("ClassroomID")
                End While

                For Day As Integer = 1 To 5
                    Dim cmd2 As New OleDb.OleDbCommand("INSERT into ClassroomsDays(`ClassroomID`,`DayID`) values(@ClassroomID,@DayID)", conn)
                    cmd2.Parameters.Clear()
                    cmd2.Parameters.AddWithValue("@ClassroomID", ClassroomID)
                    cmd2.Parameters.AddWithValue("@DayID", Day)
                    cmd2.ExecuteNonQuery()

                    Dim cmd3 As New OleDb.OleDbCommand("SELECT ClassroomDayID from ClassroomsDays WHERE ClassroomID=@ClassroomID AND DayID=@DayID", conn)
                    cmd3.Parameters.Clear()
                    cmd3.Parameters.AddWithValue("@ClassroomID", ClassroomID)
                    cmd3.Parameters.AddWithValue("@DayID", Day)
                    dr = cmd3.ExecuteReader
                    While dr.Read()
                        ClassroomDayID = dr.Item("ClassroomDayID")
                    End While

                    For Period As Integer = 1 To 11
                        Dim cmd4 As New OleDb.OleDbCommand("INSERT into TimetablesPeriods(`ClassroomDayID`,`PeriodID`,`TeacherSubjectID`) values(@ClassroomDayID,@PeriodID,@TeacherSubjectID)", conn)
                        cmd4.Parameters.Clear()
                        cmd4.Parameters.AddWithValue("@ClassroomDayID", ClassroomDayID)
                        cmd4.Parameters.AddWithValue("@PeriodID", Period)
                        cmd4.Parameters.AddWithValue("@TeacherSubjectID", 1)
                        i = cmd4.ExecuteNonQuery()
                    Next
                Next

                If i > 0 Then
                    MsgBox("เพิ่มข้อมูลเเล้ว !", vbInformation)
                Else
                    MsgBox("ผิดพลาด", vbCritical)
                End If
            End If
        Catch
            MsgBox("กรอกข้อมูลไม่ครบ", vbOKOnly, "เเจ้งเตือน")
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
            Dim cmd As New OleDb.OleDbCommand("UPDATE Classrooms SET `ClassroomCode`=@ClassroomCode,`ClassroomName`=@ClassroomName Where ClassroomID=@ClassroomID ", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ClassroomCode", txtID.Text)
            cmd.Parameters.AddWithValue("@ClassroomName", txtName.Text)
            cmd.Parameters.AddWithValue("@ClassroomID", txtPR.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("แก้ไขแล้ว!", vbInformation)
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
            Dim cmd As New OleDb.OleDbCommand("Select ClassroomID,ClassroomCode,ClassroomName from Classrooms WHERE `ClassroomName` like '%" & txtSearch.Text & "%' or `ClassroomCode` like '%" & txtSearch.Text & "%'or `ClassroomID` like '%" & txtSearch.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ClassroomID"), dr.Item("ClassroomCode"), dr.Item("ClassroomName"))
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
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim cmd As New OleDb.OleDbCommand("Delete from Classrooms WHERE ClassroomID=@ClassroomID", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@ClassroomID", txtPR.Text)
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
    Private Sub btnSvae_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
    Private Sub btnSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search()
    End Sub
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        Dim chr As Char = e.KeyChar
        If Not Char.IsDigit(chr) AndAlso Asc(chr) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Class
