Public Class WinScreen

    Private Sub WinScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        smile.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\win.png")

    End Sub

    Private Sub menu_Click_1(sender As Object, e As EventArgs) Handles menu.Click

        Dim Menu As New Menu
        Menu.Show()
        Me.Close()

    End Sub

    Private Sub Quit_Click_1(sender As Object, e As EventArgs) Handles Quit.Click

        Application.Exit()

    End Sub
End Class