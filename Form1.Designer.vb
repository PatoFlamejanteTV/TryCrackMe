<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BAR = New System.Windows.Forms.ProgressBar()
        Me.PLUS = New System.Windows.Forms.Button()
        Me.MINUS = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BAR
        '
        Me.BAR.Location = New System.Drawing.Point(13, 162)
        Me.BAR.Name = "BAR"
        Me.BAR.Size = New System.Drawing.Size(319, 36)
        Me.BAR.TabIndex = 0
        '
        'PLUS
        '
        Me.PLUS.Location = New System.Drawing.Point(302, 133)
        Me.PLUS.Name = "PLUS"
        Me.PLUS.Size = New System.Drawing.Size(30, 23)
        Me.PLUS.TabIndex = 1
        Me.PLUS.Text = "+1"
        Me.PLUS.UseVisualStyleBackColor = True
        '
        'MINUS
        '
        Me.MINUS.Location = New System.Drawing.Point(13, 133)
        Me.MINUS.Name = "MINUS"
        Me.MINUS.Size = New System.Drawing.Size(30, 23)
        Me.MINUS.TabIndex = 2
        Me.MINUS.Text = "-1"
        Me.MINUS.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 210)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MINUS)
        Me.Controls.Add(Me.PLUS)
        Me.Controls.Add(Me.BAR)
        Me.Name = "Form1"
        Me.Text = "main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BAR As ProgressBar
    Friend WithEvents PLUS As Button
    Friend WithEvents MINUS As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
