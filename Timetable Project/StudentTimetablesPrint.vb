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
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
        PrintDialog1.Document = PrintStudentTimetables
        PrintDialog1.PrinterSettings = PrintStudentTimetables.PrinterSettings
        PrintDialog1.AllowSomePages = True
        PrintDialog1.ShowNetwork = False
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintStudentTimetables.PrinterSettings = PrintDialog1.PrinterSettings
            PrintStudentTimetables.Print()
        End If
    End Sub
    Public Function RoundRect(bounds As Rectangle, radius1 As Integer, radius2 As Integer, radius3 As Integer, radius4 As Integer) As GraphicsPath
        Dim diameter1 As Integer = radius1 * 2
        Dim diameter2 As Integer = radius2 * 2
        Dim diameter3 As Integer = radius3 * 2
        Dim diameter4 As Integer = radius4 * 2
        Dim arc1 As Rectangle = New Rectangle(bounds.Location, New Size(diameter1, diameter1))
        Dim arc2 As Rectangle = New Rectangle(bounds.Location, New Size(diameter2, diameter2))
        Dim arc3 As Rectangle = New Rectangle(bounds.Location, New Size(diameter3, diameter3))
        Dim arc4 As Rectangle = New Rectangle(bounds.Location, New Size(diameter4, diameter4))
        Dim path As GraphicsPath = New GraphicsPath()
        If radius1 = 0 Then
            path.AddLine(arc1.Location, arc1.Location)
        Else
            path.AddArc(arc1, 180, 90)
        End If
        arc2.X = bounds.Right - diameter2
        If radius2 = 0 Then
            path.AddLine(arc2.Location, arc2.Location)
        Else
            path.AddArc(arc2, 270, 90)
        End If
        arc3.X = bounds.Right - diameter3
        arc3.Y = bounds.Bottom - diameter3
        If radius3 = 0 Then
            path.AddLine(arc3.Location, arc3.Location)
        Else
            path.AddArc(arc3, 0, 90)
        End If
        arc4.Y = bounds.Bottom - diameter4
        arc4.X = bounds.Left
        If radius4 = 0 Then
            path.AddLine(arc4.Location, arc4.Location)
        Else
            path.AddArc(arc4, 90, 90)
        End If
        path.CloseFigure()
        Return path
    End Function
    Private Sub CreateProductLabel(g As Graphics)
        Dim cmd As New OleDb.OleDbCommand("SELECT Dayname FROM Days ", conn)
        Dim cmd1 As New OleDb.OleDbCommand("Select PeriodNumber, PeriodName, PeriodTimeStart, PeriodTimeEnd from Periods WHERE ", conn)
        Dim cmd2 As New OleDb.OleDbCommand("SELECT ClassroomCode, TeacherFirstName, SubjectCode FROM TimetablesQuery ", conn)
        Dim cmd3 As New OleDb.OleDbCommand("SELECT ClassroomCode, TeacherFirstName, SubjectCode FROM TimetablesQuery ", conn)
        Dim cmd4 As New OleDb.OleDbCommand("SELECT YearNumber FROM Years ", conn)
        Dim labelFont As New Font("Arial", 9, FontStyle.Regular)
        Dim textFont As New Font("Arial", 11, FontStyle.Regular)
        Dim headerFont As New Font("Arial", 30, FontStyle.Bold)
        Dim sizeProductionDate As SizeF = New SizeF() 'initialize
        Dim sizeShipper As SizeF = New SizeF() 'initialize
        Dim sizeCosigner As SizeF = New SizeF() 'initialize
        Dim widthOuter As Integer = 740
        Dim heightOuter As Integer = 310
        Using penDimGray As Pen = New Pen(Color.DimGray, 0)
            Dim outerRect As Rectangle = New Rectangle(60, 100, widthOuter, heightOuter)
            Using path As GraphicsPath = RoundRect(outerRect, 10, 10, 10, 10)
                g.DrawPath(penDimGray, path)
            End Using
            g.DrawLine(penDimGray, New PointF(100, 130), New PointF(800, 130))
            g.DrawLine(penDimGray, New PointF(100, 145), New PointF(800, 145))
            g.DrawLine(penDimGray, New PointF(60, 160), New PointF(800, 160))

            g.DrawLine(penDimGray, New PointF(100, 100), New PointF(100, 410))

            For XCoord As Integer = 170 To 730 Step +70
                g.DrawLine(penDimGray, New PointF(XCoord, 130), New PointF(XCoord, 410))
            Next

            For YCoord As Integer = 210 To 360 Step +50
                g.DrawLine(penDimGray, New PointF(60, YCoord), New PointF(800, YCoord))
            Next
        End Using

        Using penBlack As Pen = New Pen(Color.Black, 7)
            Using fontArial9Bold As Font = New Font("Arial", 15, FontStyle.Bold)
                Using brush As SolidBrush = New SolidBrush(Color.Black)
                    Dim XCoord = 100
                    For PeriodNumber As Integer = 0 To 9
                        g.DrawString(CStr(PeriodNumber), labelFont, brush, XCoord, 130)
                        XCoord = XCoord + 70
                    Next
                End Using
            End Using
        End Using

        Using font As Font = New Font("Arial", 7, FontStyle.Regular)
            Using brush As SolidBrush = New SolidBrush(Color.Black)
                g.DrawString("07:30-08:20", font, brush, 100, 150)
                g.DrawString("7:30-08:20", font, brush, 170, 150)
                g.DrawString("7:30-08:20", font, brush, 240, 150)
                g.DrawString("7:30-08:20", font, brush, 310, 150)
                g.DrawString("7:30-08:20", font, brush, 380, 150)
                g.DrawString("7:30-08:20", font, brush, 450, 150)
                g.DrawString("7:30-08:20", font, brush, 520, 150)
                g.DrawString("7:30-08:20", font, brush, 590, 150)
                g.DrawString("7:30-08:20", font, brush, 660, 150)
                g.DrawString("7:30-08:20", font, brush, 730, 150)
            End Using
        End Using

        Using font As Font = New Font("Arial", 11, FontStyle.Regular)
            Using brush As SolidBrush = New SolidBrush(Color.Black)
                g.DrawString("จ.", font, brush, 60, 170)
                g.DrawString("จ.", font, brush, 60, 220)
                g.DrawString("จ.", font, brush, 60, 270)
                g.DrawString("จ.", font, brush, 60, 320)
                g.DrawString("จ.", font, brush, 60, 370)
            End Using
        End Using
    End Sub
    Private Sub TeachersTimetablesFrom_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        FormRegionAndBorder(Me, borderRadius, e.Graphics, borderColor, borderSize)
    End Sub
    Private Sub PrintStudentTimetables_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintStudentTimetables.PrintPage
        CreateProductLabel(e.Graphics)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class