Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub StartGame_Click(sender As Object, e As EventArgs) Handles StartGame.Click

        Dim Rules As New Rules
        Rules.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Application.Exit()

    End Sub

    Private Sub Credits_Click(sender As Object, e As EventArgs) Handles Credits.Click

        Dim Credits As New Credits
        Credits.Show()
        Me.Hide()

    End Sub
End Class