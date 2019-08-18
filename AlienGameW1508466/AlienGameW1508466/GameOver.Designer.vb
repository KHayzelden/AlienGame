<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOver
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
        Me.Quit = New System.Windows.Forms.Button()
        Me.points = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menu = New System.Windows.Forms.Button()
        Me.frown = New System.Windows.Forms.PictureBox()
        CType(Me.frown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Black
        Me.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Quit.Font = New System.Drawing.Font("Racer", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.ForeColor = System.Drawing.Color.Lime
        Me.Quit.Location = New System.Drawing.Point(986, 856)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(145, 45)
        Me.Quit.TabIndex = 11
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'points
        '
        Me.points.BackColor = System.Drawing.Color.Black
        Me.points.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.points.Font = New System.Drawing.Font("Racer", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.points.ForeColor = System.Drawing.Color.Lime
        Me.points.Location = New System.Drawing.Point(826, 210)
        Me.points.Name = "points"
        Me.points.Size = New System.Drawing.Size(305, 44)
        Me.points.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Racer", 99.74999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(54, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1045, 145)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Game Over"
        '
        'menu
        '
        Me.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu.Font = New System.Drawing.Font("Racer", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu.ForeColor = System.Drawing.Color.Lime
        Me.menu.Location = New System.Drawing.Point(817, 856)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(145, 45)
        Me.menu.TabIndex = 8
        Me.menu.Text = "Menu"
        Me.menu.UseVisualStyleBackColor = True
        '
        'frown
        '
        Me.frown.Location = New System.Drawing.Point(79, 229)
        Me.frown.Name = "frown"
        Me.frown.Size = New System.Drawing.Size(672, 672)
        Me.frown.TabIndex = 12
        Me.frown.TabStop = False
        '
        'GameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1184, 962)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.points)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.frown)
        Me.Name = "GameOver"
        Me.Text = "GameOver"
        CType(Me.frown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents points As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents menu As System.Windows.Forms.Button
    Friend WithEvents frown As System.Windows.Forms.PictureBox
End Class
