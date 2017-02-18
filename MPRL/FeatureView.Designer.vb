<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeatureView
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
        Me.LstViewFeatures = New System.Windows.Forms.ListView()
        Me.LstviewTolerances = New System.Windows.Forms.ListView()
        Me.LblTolerance = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(13, 13)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(189, 29)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Select a Feature"
        '
        'LstViewFeatures
        '
        Me.LstViewFeatures.HideSelection = False
        Me.LstViewFeatures.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.LstViewFeatures.Location = New System.Drawing.Point(18, 45)
        Me.LstViewFeatures.MultiSelect = False
        Me.LstViewFeatures.Name = "LstViewFeatures"
        Me.LstViewFeatures.ShowGroups = False
        Me.LstViewFeatures.Size = New System.Drawing.Size(768, 546)
        Me.LstViewFeatures.TabIndex = 1
        Me.LstViewFeatures.UseCompatibleStateImageBehavior = False
        '
        'LstviewTolerances
        '
        Me.LstviewTolerances.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstviewTolerances.Location = New System.Drawing.Point(796, 72)
        Me.LstviewTolerances.MultiSelect = False
        Me.LstviewTolerances.Name = "LstviewTolerances"
        Me.LstviewTolerances.Size = New System.Drawing.Size(280, 519)
        Me.LstviewTolerances.TabIndex = 2
        Me.LstviewTolerances.UseCompatibleStateImageBehavior = False
        Me.LstviewTolerances.View = System.Windows.Forms.View.List
        '
        'LblTolerance
        '
        Me.LblTolerance.AutoSize = True
        Me.LblTolerance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTolerance.Location = New System.Drawing.Point(792, 45)
        Me.LblTolerance.Name = "LblTolerance"
        Me.LblTolerance.Size = New System.Drawing.Size(270, 24)
        Me.LblTolerance.TabIndex = 3
        Me.LblTolerance.Text = "Then, select desired tolerance."
        '
        'FeatureView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 603)
        Me.Controls.Add(Me.LblTolerance)
        Me.Controls.Add(Me.LstviewTolerances)
        Me.Controls.Add(Me.LstViewFeatures)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "FeatureView"
        Me.Text = "FeatureView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LstViewFeatures As ListView
    Friend WithEvents LstviewTolerances As ListView
    Friend WithEvents LblTolerance As Label
End Class
