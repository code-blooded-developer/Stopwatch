<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StopWatch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StopWatch))
        Me.start = New System.Windows.Forms.Button
        Me.reset = New System.Windows.Forms.Button
        Me.exit_btn = New System.Windows.Forms.Button
        Me.millisec = New System.Windows.Forms.Label
        Me.sec = New System.Windows.Forms.Label
        Me.min = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lstlap = New System.Windows.Forms.ListBox
        Me.pause = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'start
        '
        Me.start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start.Location = New System.Drawing.Point(74, 143)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 0
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(317, 143)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 1
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'exit_btn
        '
        Me.exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(434, 143)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 2
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'millisec
        '
        Me.millisec.AutoSize = True
        Me.millisec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.millisec.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.millisec.Location = New System.Drawing.Point(329, 70)
        Me.millisec.Name = "millisec"
        Me.millisec.Size = New System.Drawing.Size(46, 31)
        Me.millisec.TabIndex = 3
        Me.millisec.Text = "00"
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sec.Location = New System.Drawing.Point(264, 70)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(46, 31)
        Me.sec.TabIndex = 4
        Me.sec.Text = "00"
        '
        'min
        '
        Me.min.AutoSize = True
        Me.min.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.min.Location = New System.Drawing.Point(197, 70)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(46, 31)
        Me.min.TabIndex = 5
        Me.min.Text = "00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'lstlap
        '
        Me.lstlap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstlap.FormattingEnabled = True
        Me.lstlap.ItemHeight = 20
        Me.lstlap.Location = New System.Drawing.Point(231, 218)
        Me.lstlap.Name = "lstlap"
        Me.lstlap.Size = New System.Drawing.Size(112, 84)
        Me.lstlap.TabIndex = 6
        '
        'pause
        '
        Me.pause.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pause.Location = New System.Drawing.Point(194, 143)
        Me.pause.Name = "pause"
        Me.pause.Size = New System.Drawing.Size(75, 23)
        Me.pause.TabIndex = 7
        Me.pause.Text = "Pause"
        Me.pause.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(226, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Last Lap :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(311, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 31)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(246, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 31)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = ":"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(551, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StopWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(551, 314)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pause)
        Me.Controls.Add(Me.lstlap)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.sec)
        Me.Controls.Add(Me.millisec)
        Me.Controls.Add(Me.exit_btn)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StopWatch"
        Me.Text = "Stopwatch"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents start As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents millisec As System.Windows.Forms.Label
    Friend WithEvents sec As System.Windows.Forms.Label
    Friend WithEvents min As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lstlap As System.Windows.Forms.ListBox
    Friend WithEvents pause As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
