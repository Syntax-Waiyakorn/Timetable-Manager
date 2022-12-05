Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Public Class StudentTimetablesPrint
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Timetable.accdb")
    Dim dr As OleDbDataReader

    Private borderRadius As Integer = 30
    Private borderSize As Integer = 5
    Private borderColor As Color = Color.IndianRed
    Private Function GetRoundedPath(rect As Rectangle, radius As Single) As GraphicsPath
        Dim path As GraphicsPath = New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function
    Private Sub FormRegionAndBorder(form As Form, radius As Single, graph As Graphics, borderColor As Color, borderSize As Single)
        If Me.WindowState <> FormWindowState.Minimized Then
            Using roundPath As GraphicsPath = GetRoundedPath(form.ClientRectangle, radius)
                Using penBorder As Pen = New Pen(borderColor, borderSize)
                    Using transform As Matrix = New Matrix()

                        graph.SmoothingMode = SmoothingMode.AntiAlias
                        form.Region = New Region(roundPath)
                        If borderSize >= 1 Then
                            Dim rect As Rectangle = form.ClientRectangle
                            Dim scaleX As Single = 1.0F - ((borderSize + 1) / rect.Width)
                            Dim scaleY As Single = 1.0F - ((borderSize + 1) / rect.Height)
                            transform.Scale(scaleX, scaleY)
                            transform.Translate(borderSize / 1.6F, borderSize / 1.6F)
                            graph.Transform = transform
                            graph.DrawPath(penBorder, roundPath)
                        End If

                    End Using
                End Using
            End Using
        End If
    End Sub
    Private Sub TeachersTimetablesFrom_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        FormRegionAndBorder(Me, borderRadius, e.Graphics, borderColor, borderSize)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        PrintDialog1.Document = PrintStudentTimetables
        PrintDialog1.PrinterSettings = PrintStudentTimetables.PrinterSettings
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowNetwork = False
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintStudentTimetables.PrinterSettings = PrintDialog1.PrinterSettings
            PrintStudentTimetables.Print()
        End If
        Me.PrintStudentTimetables.PrinterSettings.DefaultPageSettings.Landscape = True
    End Sub
    Private Sub PrintStudentTimetables_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintStudentTimetables.PrintPage

        Dim cmd As New OleDb.OleDbCommand("SELECT Dayname FROM Days ", conn)
        Dim cmd1 As New OleDb.OleDbCommand("Select PeriodNumber, PeriodName, PeriodTimeStart, PeriodTimeEnd from Periods WHERE ", conn)
        Dim cmd2 As New OleDb.OleDbCommand("SELECT ClassroomCode, TeacherFirstName, SubjectCode FROM TimetablesQuery ", conn)
        Dim cmd3 As New OleDb.OleDbCommand("SELECT ClassroomCode, TeacherFirstName, SubjectCode FROM TimetablesQuery ", conn)

        Dim labelFont As New Font("Arial", 11, FontStyle.Bold)
        Dim textFont As New Font("Arial", 11, FontStyle.Regular)
        Dim headerFont As New Font("Arial", 30, FontStyle.Bold)

        e.Graphics.DrawString("ตารางสอนปีการศึกษา 2565", headerFont, Brushes.Black, 200, 30)

    End Sub
End Class