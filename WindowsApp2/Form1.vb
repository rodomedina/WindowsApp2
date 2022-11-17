Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 100
            Process.Start("explorer.exe", "c:/")
        Next
    End Sub
End Class
