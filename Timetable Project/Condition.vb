Imports System.Data.OleDb
Public Class Condition
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader
    Sub loadcbo()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd1 As New OleDb.OleDbCommand("Select TeacherFirstName from Teachers where TeacherFirstName <> @TeacherFirstName", conn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@TeacherFirstName", "-")
            Dim cmd2 As New OleDb.OleDbCommand("Select SubjectCode from Subjects", conn)

            Dim cmd3 As New OleDb.OleDbCommand("Select TeacherSubjectDisplay from TeachersSubjectsQuery where TeacherFirstName <> @TeacherFirstName", conn)
            cmd3.Parameters.Clear()
            cmd3.Parameters.AddWithValue("@TeacherFirstName", "-")
            Dim cmd4 As New OleDb.OleDbCommand("Select ClassroomName from Classrooms", conn)

            cboTeachers.Items.Clear()
            dr = cmd1.ExecuteReader
            While dr.Read
                cboTeachers.Items.Add(dr.GetString(0))
            End While

            cboSubjects.Items.Clear()
            dr = cmd2.ExecuteReader
            While dr.Read
                cboSubjects.Items.Add(dr.GetString(0))
            End While

            cboClassrooms.Items.Clear()
            dr = cmd4.ExecuteReader
            While dr.Read
                cboClassrooms.Items.Add(dr.GetString(0))
            End While

            cboTeachersSubjects.Items.Clear()
            dr = cmd3.ExecuteReader
            While dr.Read
                cboTeachersSubjects.Items.Add(dr.GetString(0))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        LoadGrid()
    End Sub
    Private Sub Condition_Paint(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        loadcbo()
    End Sub
    Sub LoadGrid()
        Try
            DataGridView1.Rows.Clear()
            DataGridView2.Rows.Clear()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim cmd1 As New OleDb.OleDbCommand("Select TeacherSubjectID, TeacherFirstName, SubjectCode, SubjectName from TeachersSubjectsQuery where TeacherFirstName <> @TeacherFirstName", conn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@TeacherFirstName", "-")
            Dim cmd2 As New OleDb.OleDbCommand("Select TeacherSubjectDisplay, ClassroomName from TSClassroomsQuery where TeacherFirstName<>@TeacherFirstName", conn)
            cmd2.Parameters.Clear()
            cmd2.Parameters.AddWithValue("TeacherFirstName", "-")

            dr = cmd1.ExecuteReader

            While dr.Read
                DataGridView1.Rows.Add(dr.Item("TeacherSubjectID"), dr.Item("TeacherFirstName"), dr.Item("SubjectCode"), dr.Item("SubjectName"))
            End While
            dr = cmd2.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("TeacherSubjectDisplay"), dr.Item("ClassroomName"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Sub TSsave()
        Try
            If MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                Dim TeacherID As String = "null"
                Dim SubjectID As String = "null"
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim cmd1 As New OleDb.OleDbCommand("SELECT TeacherID FROM Teachers WHERE TeacherFirstName = '" + cboTeachers.Text + "'", conn)
                dr = cmd1.ExecuteReader
                While dr.Read
                    TeacherID = dr.Item("TeacherID")
                End While
                Dim cmd2 As New OleDb.OleDbCommand("SELECT SubjectID FROM Subjects WHERE SubjectCode = '" + cboSubjects.Text + "'", conn)
                dr = cmd2.ExecuteReader
                While dr.Read
                    SubjectID = dr.Item("SubjectID")
                End While
                Dim cmd3 As New OleDb.OleDbCommand("Insert into TeachersSubjects(`TeacherID`,`SubjectID`) values(@TeacherID,@SubjectID)", conn)
                cmd3.Parameters.Clear()
                cmd3.Parameters.AddWithValue("@TeacherID", TeacherID)
                cmd3.Parameters.AddWithValue("@SubjectID", SubjectID)
                If cmd3.ExecuteNonQuery > 0 Then
                    MsgBox("เพิ่มข้อมูลเเล้ว !", vbInformation)
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
        LoadGrid()
        loadcbo()
    End Sub
    Sub TSCsave()
        Try
            If MsgBox("คุณต้องการเพิ่มข้อมูลหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                Dim TeacherSubjectID As String = "null"
                Dim ClassroomID As String = "null"
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                Dim cmd1 As New OleDb.OleDbCommand("SELECT TeacherSubjectID FROM TeachersSubjectsQuery WHERE TeacherSubjectDisplay = '" + cboTeachersSubjects.Text + "'", conn)
                dr = cmd1.ExecuteReader
                While dr.Read
                    TeacherSubjectID = dr.Item("TeacherSubjectID")
                End While
                Dim cmd3 As New OleDb.OleDbCommand("SELECT ClassroomID FROM Classrooms WHERE ClassroomName = '" + cboClassrooms.Text + "'", conn)
                dr = cmd3.ExecuteReader
                While dr.Read
                    ClassroomID = dr.Item("ClassroomID")
                End While
                Dim cmd4 As New OleDb.OleDbCommand("Insert into TSClassrooms(`TeacherSubjectID`,`ClassroomID`) values(@TeacherSubjectID,@ClassroomID)", conn)
                cmd4.Parameters.Clear()
                cmd4.Parameters.AddWithValue("@TeacherSubjectID", TeacherSubjectID)
                cmd4.Parameters.AddWithValue("@ClassroomID", ClassroomID)

                If cmd4.ExecuteNonQuery > 0 Then
                    MsgBox("เพิ่มข้อมูลเเล้ว !", vbInformation)
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
        LoadGrid()
        loadcbo()
    End Sub
    Sub TSdelete()
        Try
            If MsgBox("คุณต้องการลบหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                If Not cboSubjects.Text = "ว่าง" Then
                    Dim TeacherSubjectIndex As String = cboTeachers.Text & "$$" & cboSubjects.Text
                    Dim TeacherSubjectIDd As String = "null"
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    Dim cmd1 As New OleDb.OleDbCommand("SELECT TeacherSubjectID FROM TeachersSubjectsQuery WHERE TeacherSubjectIndex = '" + TeacherSubjectIndex + "'", conn)
                    dr = cmd1.ExecuteReader
                    While dr.Read
                        TeacherSubjectIDd = dr.Item("TeacherSubjectID")
                    End While
                    Dim cmd2 As New OleDb.OleDbCommand("Delete from TeachersSubjects WHERE TeacherSubjectID=@TeacherSubjectID", conn)
                    cmd2.Parameters.AddWithValue("@TeacherSubjectID", TeacherSubjectIDd)

                    Dim cmd As New OleDb.OleDbCommand("UPDATE TimetablesPeriods SET `TeacherSubjectID`=@TeacherSubjectID Where TimetablePeriodID=@TimetablePeriodID", conn)
                    cmd.Parameters.AddWithValue("@TimetablePeriodID", agent.Text)
                    cmd.Parameters.AddWithValue("@TeacherSubjectID", txtId.Text)

                    cmd.ExecuteNonQuery()
                    If cmd2.ExecuteNonQuery > 0 Then
                        MsgBox("ลบสำเร็จ!", vbInformation)
                    Else
                        MsgBox("ผิดพลาด", vbCritical)
                    End If
                Else
                    MsgBox("ลบวิขาว่างไม่ได้!", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        LoadGrid()
        loadcbo()
    End Sub
    Sub TSCdelete()
        Try
            If MsgBox("คุณต้องการลบหรือไม่ ?", vbQuestion + vbYesNo, "เเจ้งเตือน") = vbYes Then
                If Not cboTeachersSubjects.Text = "- : ว่าง" Then

                    Dim Separaters() = {" : "}
                    Dim cboTextSplit() As String = cboTeachersSubjects.Text.Split(Separaters, StringSplitOptions.RemoveEmptyEntries)
                    Dim TeacherFirstName = cboTextSplit(0)
                    Dim SubjectName = cboTextSplit(1)
                    Dim TSClassroomIndex As String = TeacherFirstName & "$$" & SubjectName & "$$" & cboClassrooms.Text
                    Dim TSClassroomID As String = "null"
                    If conn.State = ConnectionState.Closed Then
                        conn.Open()
                    End If
                    Dim cmd1 As New OleDb.OleDbCommand("SELECT TSClassroomID FROM TSClassroomsQuery WHERE TSClassroomIndex = '" + TSClassroomIndex + "'", conn)
                    dr = cmd1.ExecuteReader
                    While dr.Read
                        TSClassroomID = dr.Item("TSClassroomID")
                    End While
                    Dim cmd2 As New OleDb.OleDbCommand("Delete from TSClassrooms WHERE TSClassroomID = @TSClassroomID", conn)
                    cmd2.Parameters.Clear()
                    cmd2.Parameters.AddWithValue("@TSClassroomID", TSClassroomID)
                    If cmd2.ExecuteNonQuery > 0 Then
                        MsgBox("ลบสำเร็จ!", vbInformation)
                    Else
                        MsgBox("ผิดพลาด", vbCritical)
                    End If
                Else
                    MsgBox("ลบคาบวางไมได้", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        LoadGrid()
        loadcbo()
    End Sub
    Sub TSsearch()
        Try
            cboTeachers.Items.Clear()
            cboSubjects.Items.Clear()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd1 As New OleDb.OleDbCommand("Select TeacherFirstName  from Teachers WHERE TeacherFirstName like '%" & txtSearchT.Text & "%' and TeacherFirstName <> @TeacherFirstName", conn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@TeacherFirstName", "-")

            Dim cmd As New OleDb.OleDbCommand("Select SubjectCode  from Subjects WHERE SubjectCode like '%" & txtSearchS.Text & "%'", conn)



            Dim cmd2 As New OleDb.OleDbCommand("Select TeacherSubjectID,TeacherFirstName, SubjectCode, SubjectName from TeachersSubjectsQuery WHERE TeacherFirstName like '%" & txtSearchT.Text & "%' and  SubjectCode like '%" & txtSearchS.Text & "%' and TeacherFirstName <> @TeacherFirstName", conn)
            cmd2.Parameters.Clear()
            cmd2.Parameters.AddWithValue("@TeacherFirstName", "-")
            DataGridView1.Rows.Clear()

            dr = cmd1.ExecuteReader
            While dr.Read
                cboTeachers.Items.Add(dr.Item("TeacherFirstName"))
            End While
            dr.Close()

            dr = cmd.ExecuteReader
            While dr.Read
                cboSubjects.Items.Add(dr.Item("SubjectCode"))
            End While
            dr.Close()

            dr = cmd2.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("TeacherSubjectID"), dr.Item("TeacherFirstName"), dr.Item("SubjectCode"), dr.Item("SubjectName"))
            End While
            dr.Close()

        Catch
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub txtSearchT_TextChanged(sender As Object, e As EventArgs) Handles txtSearchT.TextChanged
        TSsearch()
    End Sub
    Private Sub txtSearchS_TextChanged(sender As Object, e As EventArgs) Handles txtSearchS.TextChanged
        TSsearch()
    End Sub
    Sub TSCsearch()
        Try
            cboTeachersSubjects.Items.Clear()
            cboClassrooms.Items.Clear()
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            Dim cmd1 As New OleDb.OleDbCommand("Select TeacherSubjectDisplay  from TeachersSubjectsQuery WHERE TeacherSubjectDisplay like '%" & txtSearchTS.Text & "%' and TeacherFirstName<>@TeacherFirstName", conn)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@TeacherFirstName", "-")
            Dim cmd As New OleDb.OleDbCommand("Select ClassroomName from Classrooms WHERE ClassroomName like '%" & txtSearchC.Text & "%'", conn)

            Dim cmd2 As New OleDb.OleDbCommand("Select TeacherSubjectDisplay,ClassroomName from TSClassroomsQuery WHERE TeacherSubjectDisplay like '%" & txtSearchTS.Text & "%' and  ClassroomName like '%" & txtSearchC.Text & "%' and TeacherFirstName<>@TeacherFirstName", conn)
            cmd2.Parameters.Clear()
            cmd2.Parameters.AddWithValue("@TeacherFirstName", "-")
            DataGridView2.Rows.Clear()

            dr = cmd1.ExecuteReader
            While dr.Read
                cboTeachersSubjects.Items.Add(dr.Item("TeacherSubjectDisplay"))
            End While
            dr.Close()

            dr = cmd.ExecuteReader
            While dr.Read
                cboClassrooms.Items.Add(dr.Item("ClassroomName"))
            End While
            dr.Close()

            dr = cmd2.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("TeacherSubjectDisplay"), dr.Item("ClassroomName"))
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
    Sub id()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("SELECT TimetablePeriodID FROM TimetablesPeriods WHERE TeacherSubjectID like '%" & CStr(txtPR.Text) & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                txtId.Text = CStr(dr.Item("TimetablePeriodID"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
    Private Sub cboTeachers_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSubjects.SelectedValueChanged, cboSubjects.SelectionChangeCommitted, cboSubjects.SelectedIndexChanged, cboTeachers.SelectedIndexChanged
        Me.agent.Focus()
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        cboTeachers.Text = DataGridView1.CurrentRow.Cells(1).Value
        cboSubjects.Text = DataGridView1.CurrentRow.Cells(2).Value
        txtPR.Text = DataGridView1.CurrentRow.Cells(0).Value
        id()
    End Sub
    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        cboTeachersSubjects.Text = DataGridView2.CurrentRow.Cells(0).Value
        cboClassrooms.Text = DataGridView2.CurrentRow.Cells(1).Value
    End Sub
    Private Sub txtSearchC_TextChanged(sender As Object, e As EventArgs) Handles txtSearchC.TextChanged
        TSCsearch()
    End Sub
    Private Sub txtSearchTS_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTS.TextChanged
        TSCsearch()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnTSSave.Click
        TSsave()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnTSDelete.Click
        TSdelete()
    End Sub
    Private Sub btnTSCSave_Click(sender As Object, e As EventArgs) Handles btnTSCSave.Click
        TSCsave()
    End Sub
    Private Sub btnTSCDelete_Click(sender As Object, e As EventArgs) Handles btnTSCDelete.Click
        TSCdelete()
    End Sub
End Class