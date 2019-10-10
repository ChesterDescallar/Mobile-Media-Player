<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpPage))
        Me.hlpLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.helpbtnPlay = New System.Windows.Forms.PictureBox()
        Me.helpbtnPrevious = New System.Windows.Forms.PictureBox()
        Me.helpbtnNext = New System.Windows.Forms.PictureBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        CType(Me.helpbtnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.helpbtnPrevious, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.helpbtnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hlpLabel
        '
        Me.hlpLabel.AutoSize = True
        Me.hlpLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hlpLabel.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hlpLabel.Location = New System.Drawing.Point(100, 9)
        Me.hlpLabel.Name = "hlpLabel"
        Me.hlpLabel.Size = New System.Drawing.Size(77, 30)
        Me.hlpLabel.TabIndex = 0
        Me.hlpLabel.Text = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FAQs"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(22, 100)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(243, 50)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "A: Click on the add button icon and select the songs that you want to add"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(22, 177)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(243, 37)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "A: Click on the settings icon and select the desired theme"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(22, 296)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(243, 20)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "Media Player Controls:"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(23, 75)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(243, 20)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = "Q: How do I add a song?"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(22, 160)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(243, 20)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Text = "Q: How do I change theme?"
        '
        'helpbtnPlay
        '
        Me.helpbtnPlay.Image = CType(resources.GetObject("helpbtnPlay.Image"), System.Drawing.Image)
        Me.helpbtnPlay.Location = New System.Drawing.Point(23, 322)
        Me.helpbtnPlay.Name = "helpbtnPlay"
        Me.helpbtnPlay.Size = New System.Drawing.Size(26, 26)
        Me.helpbtnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.helpbtnPlay.TabIndex = 29
        Me.helpbtnPlay.TabStop = False
        '
        'helpbtnPrevious
        '
        Me.helpbtnPrevious.Image = CType(resources.GetObject("helpbtnPrevious.Image"), System.Drawing.Image)
        Me.helpbtnPrevious.Location = New System.Drawing.Point(23, 354)
        Me.helpbtnPrevious.Name = "helpbtnPrevious"
        Me.helpbtnPrevious.Size = New System.Drawing.Size(26, 26)
        Me.helpbtnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.helpbtnPrevious.TabIndex = 30
        Me.helpbtnPrevious.TabStop = False
        '
        'helpbtnNext
        '
        Me.helpbtnNext.Image = CType(resources.GetObject("helpbtnNext.Image"), System.Drawing.Image)
        Me.helpbtnNext.Location = New System.Drawing.Point(23, 386)
        Me.helpbtnNext.Name = "helpbtnNext"
        Me.helpbtnNext.Size = New System.Drawing.Size(26, 26)
        Me.helpbtnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.helpbtnNext.TabIndex = 31
        Me.helpbtnNext.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(55, 322)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(201, 20)
        Me.TextBox6.TabIndex = 32
        Me.TextBox6.Text = "Play / pause the song"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(55, 354)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(201, 20)
        Me.TextBox7.TabIndex = 33
        Me.TextBox7.Text = "Skips to the previous song"
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(55, 392)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(201, 20)
        Me.TextBox8.TabIndex = 34
        Me.TextBox8.Text = "Skips to the next song"
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(2, -1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(30, 30)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 35
        Me.btnBack.TabStop = False
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(23, 220)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(242, 35)
        Me.TextBox9.TabIndex = 36
        Me.TextBox9.Text = "Q: How do I go back to the play page?"
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(21, 254)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(243, 37)
        Me.TextBox10.TabIndex = 37
        Me.TextBox10.Text = "A: Click on the 'Now Playing' label"
        '
        'HelpPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 422)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.helpbtnNext)
        Me.Controls.Add(Me.helpbtnPrevious)
        Me.Controls.Add(Me.helpbtnPlay)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hlpLabel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "HelpPage"
        Me.Text = "HelpPage"
        CType(Me.helpbtnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.helpbtnPrevious, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.helpbtnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hlpLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents helpbtnPlay As System.Windows.Forms.PictureBox
    Friend WithEvents helpbtnPrevious As System.Windows.Forms.PictureBox
    Friend WithEvents helpbtnNext As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
End Class
