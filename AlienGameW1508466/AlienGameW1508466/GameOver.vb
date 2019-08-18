Public Class GameOver

    Public Declare Function apiBlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer


    Private Sub GameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        apiBlockInput(1)

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        frown.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\lose.png")

    End Sub



    Private Sub Quit_Click_1(sender As Object, e As EventArgs) Handles Quit.Click

        Application.Exit()

    End Sub

    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        Dim Menu As New Menu
        Menu.Show()
        Me.Close()
    End Sub
End Class