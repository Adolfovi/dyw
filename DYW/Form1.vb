Public Class Form1
    Dim x As Integer
    Dim y As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Label2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Muy bien :D"
    End Sub
    Private Sub Button2_Enter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        x = CInt(Int((650 * Rnd())))
        y = CInt(Int((400 * Rnd())))
        Button2.Location = New Point(x, y)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseClick
        x = CInt(Int((650 * Rnd())))
        y = CInt(Int((400 * Rnd())))
        Button2.Location = New Point(x, y)
    End Sub
End Class
