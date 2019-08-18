<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.StartGame = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Credits = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartGame
        '
        Me.StartGame.BackColor = System.Drawing.Color.Black
        Me.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartGame.Font = New System.Drawing.Font("Racer", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartGame.ForeColor = System.Drawing.Color.Lime
        Me.StartGame.Location = New System.Drawing.Point(515, 445)
        Me.StartGame.Name = "StartGame"
        Me.StartGame.Size = New System.Drawing.Size(234, 45)
        Me.StartGame.TabIndex = 0
        Me.StartGame.Text = "Start Game"
        Me.StartGame.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Racer", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1069, 105)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kill Dem Aliens"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Racer", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Lime
        Me.Button2.Location = New System.Drawing.Point(515, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Quit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Credits
        '
        Me.Credits.BackColor = System.Drawing.Color.Black
        Me.Credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Credits.Font = New System.Drawing.Font("Racer", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credits.ForeColor = System.Drawing.Color.Lime
        Me.Credits.Location = New System.Drawing.Point(515, 496)
        Me.Credits.Name = "Credits"
        Me.Credits.Size = New System.Drawing.Size(234, 45)
        Me.Credits.TabIndex = 4
        Me.Credits.Text = "Credits"
        Me.Credits.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1264, 986)
        Me.Controls.Add(Me.Credits)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartGame)
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartGame As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Credits As System.Windows.Forms.Button
End Class
