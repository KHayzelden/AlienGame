Public Class Credits

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

    End Sub


    Private Sub Buton1_Click(sender As Object, e As EventArgs) Handles Buton1.Click

        Dim Menu As New Menu
        Menu.Show()
        Me.Close()

    End Sub
End Class