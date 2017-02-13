<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFeedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFeedback))
        Me.LblQuestions = New System.Windows.Forms.Label()
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.BtnNoFeedback = New System.Windows.Forms.Button()
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SuspendLayout()
        '
        'LblQuestions
        '
        Me.LblQuestions.AutoSize = True
        Me.LblQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestions.Location = New System.Drawing.Point(13, 13)
        Me.LblQuestions.Name = "LblQuestions"
        Me.LblQuestions.Size = New System.Drawing.Size(447, 37)
        Me.LblQuestions.TabIndex = 0
        Me.LblQuestions.Text = "Was This Information Helpful?"
        '
        'BtnYes
        '
        Me.BtnYes.Location = New System.Drawing.Point(20, 84)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(137, 45)
        Me.BtnYes.TabIndex = 1
        Me.BtnYes.Text = "Yes"
        Me.BtnYes.UseVisualStyleBackColor = True
        '
        'BtnNoFeedback
        '
        Me.BtnNoFeedback.Location = New System.Drawing.Point(163, 84)
        Me.BtnNoFeedback.Name = "BtnNoFeedback"
        Me.BtnNoFeedback.Size = New System.Drawing.Size(137, 45)
        Me.BtnNoFeedback.TabIndex = 2
        Me.BtnNoFeedback.Text = "Not Applicable"
        Me.BtnNoFeedback.UseVisualStyleBackColor = True
        '
        'BtnNo
        '
        Me.BtnNo.Location = New System.Drawing.Point(306, 84)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(137, 45)
        Me.BtnNo.TabIndex = 3
        Me.BtnNo.Text = "No"
        Me.BtnNo.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "MPRL"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FormFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 179)
        Me.Controls.Add(Me.BtnNo)
        Me.Controls.Add(Me.BtnNoFeedback)
        Me.Controls.Add(Me.BtnYes)
        Me.Controls.Add(Me.LblQuestions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFeedback"
        Me.Text = "Feedback"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblQuestions As Label
    Friend WithEvents BtnYes As Button
    Friend WithEvents BtnNoFeedback As Button
    Friend WithEvents BtnNo As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
