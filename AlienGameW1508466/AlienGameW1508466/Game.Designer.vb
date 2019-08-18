<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Xpos = New System.Windows.Forms.TextBox()
        Me.Ypos = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Gun = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.FireTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ammo1 = New System.Windows.Forms.PictureBox()
        Me.ammo2 = New System.Windows.Forms.PictureBox()
        Me.ammo3 = New System.Windows.Forms.PictureBox()
        Me.ammo4 = New System.Windows.Forms.PictureBox()
        Me.ammo5 = New System.Windows.Forms.PictureBox()
        Me.ammo6 = New System.Windows.Forms.PictureBox()
        Me.RightAdd = New System.Windows.Forms.TextBox()
        Me.Alien1 = New System.Windows.Forms.PictureBox()
        Me.Alien3 = New System.Windows.Forms.PictureBox()
        Me.Alien4 = New System.Windows.Forms.PictureBox()
        Me.Alien5 = New System.Windows.Forms.PictureBox()
        Me.Alien6 = New System.Windows.Forms.PictureBox()
        Me.ammo7 = New System.Windows.Forms.PictureBox()
        Me.ammo8 = New System.Windows.Forms.PictureBox()
        Me.ammo9 = New System.Windows.Forms.PictureBox()
        Me.ammo10 = New System.Windows.Forms.PictureBox()
        Me.ammo11 = New System.Windows.Forms.PictureBox()
        Me.ammo12 = New System.Windows.Forms.PictureBox()
        Me.ammo13 = New System.Windows.Forms.PictureBox()
        Me.ammo14 = New System.Windows.Forms.PictureBox()
        Me.ammo15 = New System.Windows.Forms.PictureBox()
        Me.Alien2 = New System.Windows.Forms.PictureBox()
        Me.Alien11 = New System.Windows.Forms.PictureBox()
        Me.Alien10 = New System.Windows.Forms.PictureBox()
        Me.Alien9 = New System.Windows.Forms.PictureBox()
        Me.Alien8 = New System.Windows.Forms.PictureBox()
        Me.Alien7 = New System.Windows.Forms.PictureBox()
        Me.ammo16 = New System.Windows.Forms.PictureBox()
        Me.ammo17 = New System.Windows.Forms.PictureBox()
        Me.ammo18 = New System.Windows.Forms.PictureBox()
        Me.ammo19 = New System.Windows.Forms.PictureBox()
        Me.ammo20 = New System.Windows.Forms.PictureBox()
        Me.Alien12 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.difficulty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pointslabel = New System.Windows.Forms.Label()
        CType(Me.Gun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ammo20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Xpos
        '
        Me.Xpos.Location = New System.Drawing.Point(12, 12)
        Me.Xpos.Name = "Xpos"
        Me.Xpos.Size = New System.Drawing.Size(50, 20)
        Me.Xpos.TabIndex = 0
        Me.Xpos.Text = "280"
        Me.Xpos.Visible = False
        '
        'Ypos
        '
        Me.Ypos.Location = New System.Drawing.Point(12, 37)
        Me.Ypos.Name = "Ypos"
        Me.Ypos.Size = New System.Drawing.Size(50, 20)
        Me.Ypos.TabIndex = 1
        Me.Ypos.Text = "100"
        Me.Ypos.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'Gun
        '
        Me.Gun.BackColor = System.Drawing.Color.Black
        Me.Gun.Location = New System.Drawing.Point(582, 897)
        Me.Gun.Name = "Gun"
        Me.Gun.Size = New System.Drawing.Size(100, 29)
        Me.Gun.TabIndex = 16
        Me.Gun.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Fuchsia
        Me.Bullet.Location = New System.Drawing.Point(627, 909)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(10, 17)
        Me.Bullet.TabIndex = 18
        Me.Bullet.TabStop = False
        '
        'FireTimer
        '
        Me.FireTimer.Interval = 1
        '
        'ammo1
        '
        Me.ammo1.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo1.Location = New System.Drawing.Point(918, 952)
        Me.ammo1.Name = "ammo1"
        Me.ammo1.Size = New System.Drawing.Size(11, 29)
        Me.ammo1.TabIndex = 20
        Me.ammo1.TabStop = False
        '
        'ammo2
        '
        Me.ammo2.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo2.Location = New System.Drawing.Point(935, 952)
        Me.ammo2.Name = "ammo2"
        Me.ammo2.Size = New System.Drawing.Size(11, 29)
        Me.ammo2.TabIndex = 21
        Me.ammo2.TabStop = False
        '
        'ammo3
        '
        Me.ammo3.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo3.Location = New System.Drawing.Point(952, 952)
        Me.ammo3.Name = "ammo3"
        Me.ammo3.Size = New System.Drawing.Size(11, 29)
        Me.ammo3.TabIndex = 22
        Me.ammo3.TabStop = False
        '
        'ammo4
        '
        Me.ammo4.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo4.Location = New System.Drawing.Point(969, 952)
        Me.ammo4.Name = "ammo4"
        Me.ammo4.Size = New System.Drawing.Size(11, 29)
        Me.ammo4.TabIndex = 23
        Me.ammo4.TabStop = False
        '
        'ammo5
        '
        Me.ammo5.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo5.Location = New System.Drawing.Point(986, 952)
        Me.ammo5.Name = "ammo5"
        Me.ammo5.Size = New System.Drawing.Size(11, 29)
        Me.ammo5.TabIndex = 24
        Me.ammo5.TabStop = False
        '
        'ammo6
        '
        Me.ammo6.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo6.Location = New System.Drawing.Point(1003, 952)
        Me.ammo6.Name = "ammo6"
        Me.ammo6.Size = New System.Drawing.Size(11, 29)
        Me.ammo6.TabIndex = 25
        Me.ammo6.TabStop = False
        '
        'RightAdd
        '
        Me.RightAdd.Location = New System.Drawing.Point(12, 63)
        Me.RightAdd.Name = "RightAdd"
        Me.RightAdd.Size = New System.Drawing.Size(50, 20)
        Me.RightAdd.TabIndex = 2
        Me.RightAdd.Text = "20"
        Me.RightAdd.Visible = False
        '
        'Alien1
        '
        Me.Alien1.BackColor = System.Drawing.Color.Transparent
        Me.Alien1.Location = New System.Drawing.Point(365, 114)
        Me.Alien1.Name = "Alien1"
        Me.Alien1.Size = New System.Drawing.Size(50, 50)
        Me.Alien1.TabIndex = 5
        Me.Alien1.TabStop = False
        '
        'Alien3
        '
        Me.Alien3.BackColor = System.Drawing.Color.Transparent
        Me.Alien3.Location = New System.Drawing.Point(568, 114)
        Me.Alien3.Name = "Alien3"
        Me.Alien3.Size = New System.Drawing.Size(50, 50)
        Me.Alien3.TabIndex = 12
        Me.Alien3.TabStop = False
        '
        'Alien4
        '
        Me.Alien4.BackColor = System.Drawing.Color.Transparent
        Me.Alien4.Location = New System.Drawing.Point(673, 114)
        Me.Alien4.Name = "Alien4"
        Me.Alien4.Size = New System.Drawing.Size(50, 50)
        Me.Alien4.TabIndex = 13
        Me.Alien4.TabStop = False
        '
        'Alien5
        '
        Me.Alien5.BackColor = System.Drawing.Color.Transparent
        Me.Alien5.Location = New System.Drawing.Point(772, 114)
        Me.Alien5.Name = "Alien5"
        Me.Alien5.Size = New System.Drawing.Size(50, 50)
        Me.Alien5.TabIndex = 14
        Me.Alien5.TabStop = False
        '
        'Alien6
        '
        Me.Alien6.BackColor = System.Drawing.Color.Transparent
        Me.Alien6.Location = New System.Drawing.Point(870, 114)
        Me.Alien6.Name = "Alien6"
        Me.Alien6.Size = New System.Drawing.Size(50, 50)
        Me.Alien6.TabIndex = 15
        Me.Alien6.TabStop = False
        '
        'ammo7
        '
        Me.ammo7.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo7.Location = New System.Drawing.Point(1020, 952)
        Me.ammo7.Name = "ammo7"
        Me.ammo7.Size = New System.Drawing.Size(11, 29)
        Me.ammo7.TabIndex = 26
        Me.ammo7.TabStop = False
        '
        'ammo8
        '
        Me.ammo8.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo8.Location = New System.Drawing.Point(1037, 952)
        Me.ammo8.Name = "ammo8"
        Me.ammo8.Size = New System.Drawing.Size(11, 29)
        Me.ammo8.TabIndex = 27
        Me.ammo8.TabStop = False
        '
        'ammo9
        '
        Me.ammo9.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo9.Location = New System.Drawing.Point(1054, 952)
        Me.ammo9.Name = "ammo9"
        Me.ammo9.Size = New System.Drawing.Size(11, 29)
        Me.ammo9.TabIndex = 28
        Me.ammo9.TabStop = False
        '
        'ammo10
        '
        Me.ammo10.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo10.Location = New System.Drawing.Point(1071, 952)
        Me.ammo10.Name = "ammo10"
        Me.ammo10.Size = New System.Drawing.Size(11, 29)
        Me.ammo10.TabIndex = 29
        Me.ammo10.TabStop = False
        '
        'ammo11
        '
        Me.ammo11.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo11.Location = New System.Drawing.Point(1088, 952)
        Me.ammo11.Name = "ammo11"
        Me.ammo11.Size = New System.Drawing.Size(11, 29)
        Me.ammo11.TabIndex = 30
        Me.ammo11.TabStop = False
        '
        'ammo12
        '
        Me.ammo12.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo12.Location = New System.Drawing.Point(1105, 952)
        Me.ammo12.Name = "ammo12"
        Me.ammo12.Size = New System.Drawing.Size(11, 29)
        Me.ammo12.TabIndex = 31
        Me.ammo12.TabStop = False
        '
        'ammo13
        '
        Me.ammo13.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo13.Location = New System.Drawing.Point(1122, 952)
        Me.ammo13.Name = "ammo13"
        Me.ammo13.Size = New System.Drawing.Size(11, 29)
        Me.ammo13.TabIndex = 32
        Me.ammo13.TabStop = False
        '
        'ammo14
        '
        Me.ammo14.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo14.Location = New System.Drawing.Point(1139, 952)
        Me.ammo14.Name = "ammo14"
        Me.ammo14.Size = New System.Drawing.Size(11, 29)
        Me.ammo14.TabIndex = 33
        Me.ammo14.TabStop = False
        '
        'ammo15
        '
        Me.ammo15.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo15.Location = New System.Drawing.Point(1156, 952)
        Me.ammo15.Name = "ammo15"
        Me.ammo15.Size = New System.Drawing.Size(11, 29)
        Me.ammo15.TabIndex = 34
        Me.ammo15.TabStop = False
        '
        'Alien2
        '
        Me.Alien2.BackColor = System.Drawing.Color.Transparent
        Me.Alien2.Location = New System.Drawing.Point(464, 114)
        Me.Alien2.Name = "Alien2"
        Me.Alien2.Size = New System.Drawing.Size(50, 50)
        Me.Alien2.TabIndex = 11
        Me.Alien2.TabStop = False
        '
        'Alien11
        '
        Me.Alien11.BackColor = System.Drawing.Color.Transparent
        Me.Alien11.Location = New System.Drawing.Point(821, 170)
        Me.Alien11.Name = "Alien11"
        Me.Alien11.Size = New System.Drawing.Size(50, 50)
        Me.Alien11.TabIndex = 39
        Me.Alien11.TabStop = False
        '
        'Alien10
        '
        Me.Alien10.BackColor = System.Drawing.Color.Transparent
        Me.Alien10.Location = New System.Drawing.Point(723, 170)
        Me.Alien10.Name = "Alien10"
        Me.Alien10.Size = New System.Drawing.Size(50, 50)
        Me.Alien10.TabIndex = 38
        Me.Alien10.TabStop = False
        '
        'Alien9
        '
        Me.Alien9.BackColor = System.Drawing.Color.Transparent
        Me.Alien9.Location = New System.Drawing.Point(623, 170)
        Me.Alien9.Name = "Alien9"
        Me.Alien9.Size = New System.Drawing.Size(50, 50)
        Me.Alien9.TabIndex = 37
        Me.Alien9.TabStop = False
        '
        'Alien8
        '
        Me.Alien8.BackColor = System.Drawing.Color.Transparent
        Me.Alien8.Location = New System.Drawing.Point(520, 170)
        Me.Alien8.Name = "Alien8"
        Me.Alien8.Size = New System.Drawing.Size(50, 50)
        Me.Alien8.TabIndex = 36
        Me.Alien8.TabStop = False
        '
        'Alien7
        '
        Me.Alien7.BackColor = System.Drawing.Color.Transparent
        Me.Alien7.Location = New System.Drawing.Point(414, 170)
        Me.Alien7.Name = "Alien7"
        Me.Alien7.Size = New System.Drawing.Size(50, 50)
        Me.Alien7.TabIndex = 35
        Me.Alien7.TabStop = False
        '
        'ammo16
        '
        Me.ammo16.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo16.Location = New System.Drawing.Point(1173, 952)
        Me.ammo16.Name = "ammo16"
        Me.ammo16.Size = New System.Drawing.Size(11, 29)
        Me.ammo16.TabIndex = 44
        Me.ammo16.TabStop = False
        '
        'ammo17
        '
        Me.ammo17.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo17.Location = New System.Drawing.Point(1190, 952)
        Me.ammo17.Name = "ammo17"
        Me.ammo17.Size = New System.Drawing.Size(11, 29)
        Me.ammo17.TabIndex = 45
        Me.ammo17.TabStop = False
        '
        'ammo18
        '
        Me.ammo18.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo18.Location = New System.Drawing.Point(1207, 952)
        Me.ammo18.Name = "ammo18"
        Me.ammo18.Size = New System.Drawing.Size(11, 29)
        Me.ammo18.TabIndex = 46
        Me.ammo18.TabStop = False
        '
        'ammo19
        '
        Me.ammo19.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo19.Location = New System.Drawing.Point(1224, 952)
        Me.ammo19.Name = "ammo19"
        Me.ammo19.Size = New System.Drawing.Size(11, 29)
        Me.ammo19.TabIndex = 47
        Me.ammo19.TabStop = False
        '
        'ammo20
        '
        Me.ammo20.BackColor = System.Drawing.Color.Fuchsia
        Me.ammo20.Location = New System.Drawing.Point(1241, 952)
        Me.ammo20.Name = "ammo20"
        Me.ammo20.Size = New System.Drawing.Size(11, 29)
        Me.ammo20.TabIndex = 48
        Me.ammo20.TabStop = False
        '
        'Alien12
        '
        Me.Alien12.BackColor = System.Drawing.Color.Transparent
        Me.Alien12.Location = New System.Drawing.Point(1156, 114)
        Me.Alien12.Name = "Alien12"
        Me.Alien12.Size = New System.Drawing.Size(100, 50)
        Me.Alien12.TabIndex = 51
        Me.Alien12.TabStop = False
        Me.Alien12.Visible = False
        '
        'Timer2
        '
        '
        'difficulty
        '
        Me.difficulty.Location = New System.Drawing.Point(12, 89)
        Me.difficulty.Name = "difficulty"
        Me.difficulty.Size = New System.Drawing.Size(50, 20)
        Me.difficulty.TabIndex = 52
        Me.difficulty.Text = "1"
        Me.difficulty.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Racer", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(1180, 930)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ammo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Racer", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(1039, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 19)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Press ( P ) to pause"
        '
        'Pointslabel
        '
        Me.Pointslabel.AutoSize = True
        Me.Pointslabel.Font = New System.Drawing.Font("Racer", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pointslabel.ForeColor = System.Drawing.Color.Lime
        Me.Pointslabel.Location = New System.Drawing.Point(5, 9)
        Me.Pointslabel.Name = "Pointslabel"
        Me.Pointslabel.Size = New System.Drawing.Size(163, 37)
        Me.Pointslabel.TabIndex = 54
        Me.Pointslabel.Text = "Score:"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1264, 986)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.difficulty)
        Me.Controls.Add(Me.Alien12)
        Me.Controls.Add(Me.ammo20)
        Me.Controls.Add(Me.ammo19)
        Me.Controls.Add(Me.ammo18)
        Me.Controls.Add(Me.ammo17)
        Me.Controls.Add(Me.ammo16)
        Me.Controls.Add(Me.Alien11)
        Me.Controls.Add(Me.Alien10)
        Me.Controls.Add(Me.Alien9)
        Me.Controls.Add(Me.Alien8)
        Me.Controls.Add(Me.Alien7)
        Me.Controls.Add(Me.ammo15)
        Me.Controls.Add(Me.ammo14)
        Me.Controls.Add(Me.ammo13)
        Me.Controls.Add(Me.ammo12)
        Me.Controls.Add(Me.ammo11)
        Me.Controls.Add(Me.ammo10)
        Me.Controls.Add(Me.ammo9)
        Me.Controls.Add(Me.ammo8)
        Me.Controls.Add(Me.ammo7)
        Me.Controls.Add(Me.ammo6)
        Me.Controls.Add(Me.ammo5)
        Me.Controls.Add(Me.ammo4)
        Me.Controls.Add(Me.ammo3)
        Me.Controls.Add(Me.ammo2)
        Me.Controls.Add(Me.ammo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Gun)
        Me.Controls.Add(Me.Alien6)
        Me.Controls.Add(Me.Alien5)
        Me.Controls.Add(Me.Alien4)
        Me.Controls.Add(Me.Alien3)
        Me.Controls.Add(Me.Alien2)
        Me.Controls.Add(Me.Alien1)
        Me.Controls.Add(Me.RightAdd)
        Me.Controls.Add(Me.Ypos)
        Me.Controls.Add(Me.Xpos)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Pointslabel)
        Me.Name = "Game"
        Me.Text = "Form1"
        CType(Me.Gun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ammo20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Xpos As System.Windows.Forms.TextBox
    Friend WithEvents Ypos As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Gun As System.Windows.Forms.PictureBox
    Friend WithEvents Bullet As System.Windows.Forms.PictureBox
    Friend WithEvents FireTimer As System.Windows.Forms.Timer
    Friend WithEvents ammo1 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo2 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo3 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo4 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo5 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo6 As System.Windows.Forms.PictureBox
    Friend WithEvents RightAdd As System.Windows.Forms.TextBox
    Friend WithEvents Alien1 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien3 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien4 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien5 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien6 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo7 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo8 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo9 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo10 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo11 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo12 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo13 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo14 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo15 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien2 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien11 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien10 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien9 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien8 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien7 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo16 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo17 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo18 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo19 As System.Windows.Forms.PictureBox
    Friend WithEvents ammo20 As System.Windows.Forms.PictureBox
    Friend WithEvents Score As System.Windows.Forms.TextBox
    Friend WithEvents Alien12 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents difficulty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pointslabel As System.Windows.Forms.Label

End Class
