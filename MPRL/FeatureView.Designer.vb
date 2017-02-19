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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(13, 74)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(189, 29)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Select a Feature"
        '
        'LstViewFeatures
        '
        Me.LstViewFeatures.HideSelection = False
        Me.LstViewFeatures.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.LstViewFeatures.Location = New System.Drawing.Point(18, 106)
        Me.LstViewFeatures.MultiSelect = False
        Me.LstViewFeatures.Name = "LstViewFeatures"
        Me.LstViewFeatures.ShowGroups = False
        Me.LstViewFeatures.Size = New System.Drawing.Size(768, 485)
        Me.LstViewFeatures.TabIndex = 1
        Me.LstViewFeatures.UseCompatibleStateImageBehavior = False
        '
        'LstviewTolerances
        '
        Me.LstviewTolerances.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstviewTolerances.Location = New System.Drawing.Point(796, 106)
        Me.LstviewTolerances.MultiSelect = False
        Me.LstviewTolerances.Name = "LstviewTolerances"
        Me.LstviewTolerances.Size = New System.Drawing.Size(280, 485)
        Me.LstviewTolerances.TabIndex = 2
        Me.LstviewTolerances.UseCompatibleStateImageBehavior = False
        Me.LstviewTolerances.View = System.Windows.Forms.View.List
        '
        'LblTolerance
        '
        Me.LblTolerance.AutoSize = True
        Me.LblTolerance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTolerance.Location = New System.Drawing.Point(792, 79)
        Me.LblTolerance.Name = "LblTolerance"
        Me.LblTolerance.Size = New System.Drawing.Size(270, 24)
        Me.LblTolerance.TabIndex = 3
        Me.LblTolerance.Text = "Then, select desired tolerance."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(879, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 53)
        Me.Panel1.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(12, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 45)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(93, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 45)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FeatureView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 603)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTolerance)
        Me.Controls.Add(Me.LstviewTolerances)
        Me.Controls.Add(Me.LstViewFeatures)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "FeatureView"
        Me.Text = "FeatureView"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LstViewFeatures As ListView
    Friend WithEvents LstviewTolerances As ListView
    Friend WithEvents LblTolerance As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
