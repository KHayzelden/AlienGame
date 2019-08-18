Public Class Rules

    Public Declare Function apiBlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer


    Private Sub Rules_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Easy_Click(sender As Object, e As EventArgs) Handles Easy.Click

        Game.difficulty.Text = 0

        Game.Show()
        Me.Hide()

    End Sub

    Private Sub Normal_Click(sender As Object, e As EventArgs) Handles Normal.Click

        Game.difficulty.Text = 1

        Game.Show()
        Me.Hide()

    End Sub

    Private Sub Hard_Click(sender As Object, e As EventArgs) Handles Hard.Click

        Game.difficulty.Text = 2

        Game.Show()
        Me.Hide()

    End Sub
End Class