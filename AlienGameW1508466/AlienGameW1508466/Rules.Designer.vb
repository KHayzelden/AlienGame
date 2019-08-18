<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rules
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rules))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Easy = New System.Windows.Forms.Button()
        Me.Normal = New System.Windows.Forms.Button()
        Me.Hard = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Racer", 25.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox1.Location = New System.Drawing.Point(82, 215)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(1100, 557)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Easy
        '
        Me.Easy.BackColor = System.Drawing.Color.Black
        Me.Easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Easy.Font = New System.Drawing.Font("Racer", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Easy.ForeColor = System.Drawing.Color.Lime
        Me.Easy.Location = New System.Drawing.Point(212, 801)
        Me.Easy.Name = "Easy"
        Me.Easy.Size = New System.Drawing.Size(145, 45)
        Me.Easy.TabIndex = 2
        Me.Easy.Text = "Easy"
        Me.Easy.UseVisualStyleBackColor = False
        '
        'Normal
        '
        Me.Normal.BackColor = System.Drawing.Color.Black
        Me.Normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Normal.Font = New System.Drawing.Font("Racer", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Normal.ForeColor = System.Drawing.Color.Lime
        Me.Normal.Location = New System.Drawing.Point(529, 801)
        Me.Normal.Name = "Normal"
        Me.Normal.Size = New System.Drawing.Size(185, 45)
        Me.Normal.TabIndex = 3
        Me.Normal.Text = "Normal"
        Me.Normal.UseVisualStyleBackColor = False
        '
        'Hard
        '
        Me.Hard.BackColor = System.Drawing.Color.Black
        Me.Hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Hard.Font = New System.Drawing.Font("Racer", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hard.ForeColor = System.Drawing.Color.Lime
        Me.Hard.Location = New System.Drawing.Point(900, 801)
        Me.Hard.Name = "Hard"
        Me.Hard.Size = New System.Drawing.Size(145, 45)
        Me.Hard.TabIndex = 4
        Me.Hard.Text = "Hard"
        Me.Hard.UseVisualStyleBackColor = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.Black
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Racer", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox2.Location = New System.Drawing.Point(885, 852)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(180, 112)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = "Aliens are faster" & Global.Microsoft.VisualBasic.ChrW(10) & "You shoot slower" & Global.Microsoft.VisualBasic.ChrW(10) & "You have 15 shots" & Global.Microsoft.VisualBasic.ChrW(10) & "Points are doubled"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.Black
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Font = New System.Drawing.Font("Racer", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox3.Location = New System.Drawing.Point(529, 852)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(185, 112)
        Me.RichTextBox3.TabIndex = 6
        Me.RichTextBox3.Text = "Aliens are 10 points" & Global.Microsoft.VisualBasic.ChrW(10) & "Bonus alien is 50" & Global.Microsoft.VisualBasic.ChrW(10) & "You have 20 shots"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.Black
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Racer", 9.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox4.Location = New System.Drawing.Point(200, 852)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(185, 112)
        Me.RichTextBox4.TabIndex = 7
        Me.RichTextBox4.Text = "Half the aliens" & Global.Microsoft.VisualBasic.ChrW(10) & "Aliens are slower" & Global.Microsoft.VisualBasic.ChrW(10) & "You have 20 shots" & Global.Microsoft.VisualBasic.ChrW(10) & "Points are halved"
        '
        'Rules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1264, 986)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Hard)
        Me.Controls.Add(Me.Normal)
        Me.Controls.Add(Me.Easy)
        Me.Controls.Add(Me.RichTextBox1)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Name = "Rules"
        Me.Text = "Rules"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Easy As System.Windows.Forms.Button
    Friend WithEvents Normal As System.Windows.Forms.Button
    Friend WithEvents Hard As System.Windows.Forms.Button
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
End Class
