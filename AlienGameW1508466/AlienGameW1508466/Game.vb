Public Class Game

    Dim NumShots As Integer
    Dim Points As Integer
    Dim RandomAlien As Integer

    Public Declare Function apiBlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        PointsLabel.Text = ("Score: " & Points)

        Alien1.Location = New Point(Xpos.Text, Ypos.Text)
        Alien2.Location = New Point(Xpos.Text + 100, Ypos.Text)
        Alien3.Location = New Point(Xpos.Text + 200, Ypos.Text)
        Alien4.Location = New Point(Xpos.Text + 300, Ypos.Text)
        Alien5.Location = New Point(Xpos.Text + 400, Ypos.Text)
        Alien6.Location = New Point(Xpos.Text + 500, Ypos.Text)
        Alien7.Location = New Point(Xpos.Text + 50, Ypos.Text + 75)
        Alien8.Location = New Point(Xpos.Text + 150, Ypos.Text + 75)
        Alien9.Location = New Point(Xpos.Text + 250, Ypos.Text + 75)
        Alien10.Location = New Point(Xpos.Text + 350, Ypos.Text + 75)
        Alien11.Location = New Point(Xpos.Text + 450, Ypos.Text + 75)

        If (Xpos.Text Mod 80 = 0) Then
            Alien1.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien2.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien3.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien4.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien5.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien6.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien7.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien8.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien9.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien10.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien11.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
        Else
            Alien1.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien2.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien3.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien4.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien5.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien6.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\aliendown.png")
            Alien7.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien8.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien9.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien10.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
            Alien11.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\alienup.png")
        End If

        Xpos.Text += Int(RightAdd.Text)

        'screen resloution 1280 (x) x 1024 (y)
        If (Xpos.Text + 550 > 1100) Then
            RightAdd.Text = -20
            Ypos.Text += 40

            Timer1.Interval -= 25
            Points -= 5

        End If

        If (Xpos.Text < 180) Then
            RightAdd.Text = 20
            Ypos.Text += 40

            Timer1.Interval -= 25
            Points -= 5

        End If

        If (Ypos.Text + 150 > Gun.Location.Y + 50) Then

            Timer1.Enabled = False
            apiBlockInput(1)
            System.Threading.Thread.Sleep(500)

            Dim GameOver As New GameOver
            GameOver.points.Text = ("Score:" & Points)
            GameOver.Show()
            Me.Close()

        End If

        If (FireTimer.Enabled = False And NumShots = 20 And (Alien1.Visible = True Or Alien2.Visible = True Or Alien3.Visible = True Or Alien4.Visible = True Or Alien5.Visible = True Or Alien6.Visible = True Or Alien7.Visible = True Or Alien8.Visible = True Or Alien9.Visible = True Or Alien10.Visible = True Or Alien11.Visible = True)) Then

            Timer1.Enabled = False
            apiBlockInput(1)
            System.Threading.Thread.Sleep(500)

            Dim GameOver As New GameOver
            GameOver.points.Text = ("Score:" & Points)
            GameOver.Show()
            Me.Close()

        End If

        If (NumShots > 0 And Alien1.Visible = False And Alien2.Visible = False And Alien3.Visible = False And Alien4.Visible = False And Alien5.Visible = False And Alien6.Visible = False And Alien7.Visible = False And Alien8.Visible = False And Alien9.Visible = False And Alien10.Visible = False And Alien11.Visible = False) Then

            Timer1.Enabled = False
            apiBlockInput(1)
            System.Threading.Thread.Sleep(500)

            Dim WinScreen As New WinScreen
            WinScreen.points.Text = ("Score:" & Points)
            WinScreen.Show()
            Me.Close()

        End If

        RandomAlien += 1


        If (RandomAlien Mod 40 = 0) Then

            Timer2.Enabled = True

        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        If (e.KeyCode = Keys.Right And Gun.Location.X < 1200) Then
            Gun.Location = New Point(Gun.Location.X + 10, Gun.Location.Y)
            If (Bullet.Location.Y = Gun.Location.Y) Then
                Bullet.Location = New Point(Bullet.Location.X + 10, Bullet.Location.Y)
            End If
        End If

        If (e.KeyCode = Keys.Left And Gun.Location.X > 25) Then
            Gun.Location = New Point(Gun.Location.X - 10, Gun.Location.Y)
            If (Bullet.Location.Y = Gun.Location.Y) Then
                Bullet.Location = New Point(Bullet.Location.X - 10, Bullet.Location.Y)
            End If
        End If

        If (e.KeyCode = Keys.Space And FireTimer.Enabled = False And NumShots < 20) Then

            FireTimer.Enabled = True

            NumShots += 1
            If (NumShots = 1) Then
                ammo1.Visible = False
            ElseIf (NumShots = 2) Then
                ammo2.Visible = False
            ElseIf (NumShots = 3) Then
                ammo3.Visible = False
            ElseIf (NumShots = 4) Then
                ammo4.Visible = False
            ElseIf (NumShots = 5) Then
                ammo5.Visible = False
            ElseIf (NumShots = 6) Then
                ammo6.Visible = False
            ElseIf (NumShots = 7) Then
                ammo7.Visible = False
            ElseIf (NumShots = 8) Then
                ammo8.Visible = False
            ElseIf (NumShots = 9) Then
                ammo9.Visible = False
            ElseIf (NumShots = 10) Then
                ammo10.Visible = False
            ElseIf (NumShots = 11) Then
                ammo11.Visible = False
            ElseIf (NumShots = 12) Then
                ammo12.Visible = False
            ElseIf (NumShots = 13) Then
                ammo13.Visible = False
            ElseIf (NumShots = 14) Then
                ammo14.Visible = False
            ElseIf (NumShots = 15) Then
                ammo15.Visible = False
            ElseIf (NumShots = 16) Then
                ammo16.Visible = False
            ElseIf (NumShots = 17) Then
                ammo17.Visible = False
            ElseIf (NumShots = 18) Then
                ammo18.Visible = False
            ElseIf (NumShots = 19) Then
                ammo19.Visible = False
            ElseIf (NumShots = 20) Then
                ammo20.Visible = False
            End If

        End If

        If (e.KeyCode = Keys.P) Then

            Dim resettimer As Boolean = False
            Dim resettimer2 As Boolean = False

            If (Timer2.Enabled = True) Then
                resettimer2 = True
            End If

            If (FireTimer.Enabled = True) Then
                resettimer = True
            End If

            Timer1.Enabled = False
            Timer2.Enabled = False
            FireTimer.Enabled = False

            Dim ReturnToMenu = MsgBox("End Game?", MsgBoxStyle.YesNo, "Paused")

            If (ReturnToMenu = 6) Then

                Timer1.Enabled = False
                Dim GameOver As New GameOver

                GameOver.points.Text = ("Score:" & Points)
                GameOver.Show()
                Me.Close()

            Else

                Timer1.Enabled = True

                If (resettimer = True) Then
                    FireTimer.Enabled = True
                End If

                If (resettimer2 = True) Then
                    Timer2.Enabled = True
                End If

            End If

        End If

    End Sub

    Private Sub FireTimer_Tick(sender As Object, e As EventArgs) Handles FireTimer.Tick

        Bullet.Location = New Point(Bullet.Location.X, Bullet.Location.Y - 15)

        If (Bullet.Bounds.IntersectsWith(Alien1.Bounds) And Alien1.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien1.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If


        End If

        If (Bullet.Bounds.IntersectsWith(Alien2.Bounds) And Alien2.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien2.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien3.Bounds) And Alien3.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien3.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien4.Bounds) And Alien4.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien4.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien5.Bounds) And Alien5.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien5.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien6.Bounds) And Alien6.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien6.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien7.Bounds) And Alien7.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien7.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien8.Bounds) And Alien8.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien8.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien9.Bounds) And Alien9.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien9.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien10.Bounds) And Alien10.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien10.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien11.Bounds) And Alien11.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Bullet.Visible = False
            Alien11.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 5
            ElseIf (difficulty.Text = 1) Then
                Points += 10
            ElseIf (difficulty.Text = 2) Then
                Points += 20
            End If

        End If

        If (Bullet.Bounds.IntersectsWith(Alien12.Bounds) And Alien12.Visible = True) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
            FireTimer.Enabled = False
            Timer2.Enabled = False
            Bullet.Visible = False
            Alien12.Visible = False
            Alien12.Location = New Point(1300, 100)

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

            If (difficulty.Text = 0) Then
                Points += 25
            ElseIf (difficulty.Text = 1) Then
                Points += 50
            ElseIf (difficulty.Text = 2) Then
                Points += 100
            End If

        End If


        If (Bullet.Location.Y < 100) Then
            FireTimer.Enabled = False
            Bullet.Visible = False

            If (NumShots < 20) Then
                Bullet.Location = New Point(Gun.Location.X + 46, Gun.Location.Y)
                Bullet.Visible = True
            End If

        End If




    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        apiBlockInput(0)

        'Me.KeyPreview = True

        Alien12.Location = New Point(1300, 100)

        Gun.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\gun.png")

        If (difficulty.Text = 0) Then

            Alien7.Visible = False
            Alien8.Visible = False
            Alien9.Visible = False
            Alien10.Visible = False
            Alien11.Visible = False

            Timer1.Interval = Timer1.Interval + 100
            Timer2.Interval = Timer2.Interval + 50

        End If

        If (difficulty.Text = 2) Then

            Timer1.Interval = Timer1.Interval - 150
            Timer2.Interval = Timer2.Interval - 50

            NumShots = 5

            ammo1.Visible = False
            ammo2.Visible = False
            ammo3.Visible = False
            ammo4.Visible = False
            ammo5.Visible = False

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Alien12.Image = Image.FromFile("H:\Introduction to Programming and Games Design Project\Alien Game\special alien.png")
        Alien12.Visible = True

        If (Alien12.Location.X > 0) Then

            Alien12.Location = New Point(Alien12.Location.X - 40, Alien12.Location.Y)

        Else

            Timer2.Enabled = False
            Alien12.Visible = False
            Alien12.Location = New Point(1300, 100)

        End If

    End Sub

End Class
