<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeedbackForm
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LstviewFeedback = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(13, 13)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(188, 26)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "Student Feedback"
        '
        'LstviewFeedback
        '
        Me.LstviewFeedback.Location = New System.Drawing.Point(12, 57)
        Me.LstviewFeedback.Name = "LstviewFeedback"
        Me.LstviewFeedback.Size = New System.Drawing.Size(761, 510)
        Me.LstviewFeedback.TabIndex = 2
        Me.LstviewFeedback.UseCompatibleStateImageBehavior = False
        Me.LstviewFeedback.View = System.Windows.Forms.View.Details
        '
        'FeedbackForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 579)
        Me.Controls.Add(Me.LstviewFeedback)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "FeedbackForm"
        Me.Text = "FeedbackForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTitle As Label
    Friend WithEvents LstviewFeedback As ListView
End Class
