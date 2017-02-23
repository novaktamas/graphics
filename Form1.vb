Public Class Form1
    Dim p() As Point
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint




    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles scr.Scroll
        Dim p() As Point = {New Point(scr.Value, 450), New Point(scr.Value + 75, 30), New Point(scr.Value + 150, 400)}
        Me.CreateGraphics.DrawCurve(Pens.Black, p, 1)
    End Sub
End Class
