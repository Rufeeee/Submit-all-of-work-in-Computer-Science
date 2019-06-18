<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.pbTarget = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pbPlayingField = New System.Windows.Forms.PictureBox()
        CType(Me.pbTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlayingField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbTarget
        '
        Me.pbTarget.BackColor = System.Drawing.Color.SlateBlue
        Me.pbTarget.Location = New System.Drawing.Point(84, 92)
        Me.pbTarget.Name = "pbTarget"
        Me.pbTarget.Size = New System.Drawing.Size(149, 143)
        Me.pbTarget.TabIndex = 1
        Me.pbTarget.TabStop = False
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(-3, -1)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(329, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'pbPlayingField
        '
        Me.pbPlayingField.BackColor = System.Drawing.Color.LightSlateGray
        Me.pbPlayingField.Location = New System.Drawing.Point(-3, -1)
        Me.pbPlayingField.Name = "pbPlayingField"
        Me.pbPlayingField.Size = New System.Drawing.Size(329, 315)
        Me.pbPlayingField.TabIndex = 3
        Me.pbPlayingField.TabStop = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 311)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.pbTarget)
        Me.Controls.Add(Me.pbPlayingField)
        Me.Name = "form1"
        Me.Text = "Form1"
        CType(Me.pbTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlayingField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbTarget As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents pbPlayingField As System.Windows.Forms.PictureBox

End Class
