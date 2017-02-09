<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddResourceLink
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
        Me.LblEntityType = New System.Windows.Forms.Label()
        Me.CmboEntityType = New System.Windows.Forms.ComboBox()
        Me.CmboEntiyName = New System.Windows.Forms.ComboBox()
        Me.LblEntityname = New System.Windows.Forms.Label()
        Me.CbmoResourceName = New System.Windows.Forms.ComboBox()
        Me.LblResourceName = New System.Windows.Forms.Label()
        Me.btnAddLink = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblEntityType
        '
        Me.LblEntityType.AutoSize = True
        Me.LblEntityType.Location = New System.Drawing.Point(12, 13)
        Me.LblEntityType.Name = "LblEntityType"
        Me.LblEntityType.Size = New System.Drawing.Size(63, 13)
        Me.LblEntityType.TabIndex = 0
        Me.LblEntityType.Text = "Entity Type:"
        '
        'CmboEntityType
        '
        Me.CmboEntityType.FormattingEnabled = True
        Me.CmboEntityType.Location = New System.Drawing.Point(15, 29)
        Me.CmboEntityType.Name = "CmboEntityType"
        Me.CmboEntityType.Size = New System.Drawing.Size(193, 21)
        Me.CmboEntityType.TabIndex = 1
        '
        'CmboEntiyName
        '
        Me.CmboEntiyName.FormattingEnabled = True
        Me.CmboEntiyName.Location = New System.Drawing.Point(15, 78)
        Me.CmboEntiyName.Name = "CmboEntiyName"
        Me.CmboEntiyName.Size = New System.Drawing.Size(193, 21)
        Me.CmboEntiyName.TabIndex = 3
        '
        'LblEntityname
        '
        Me.LblEntityname.AutoSize = True
        Me.LblEntityname.Location = New System.Drawing.Point(12, 62)
        Me.LblEntityname.Name = "LblEntityname"
        Me.LblEntityname.Size = New System.Drawing.Size(64, 13)
        Me.LblEntityname.TabIndex = 2
        Me.LblEntityname.Text = "Entity Name"
        '
        'CbmoResourceName
        '
        Me.CbmoResourceName.FormattingEnabled = True
        Me.CbmoResourceName.Location = New System.Drawing.Point(15, 136)
        Me.CbmoResourceName.Name = "CbmoResourceName"
        Me.CbmoResourceName.Size = New System.Drawing.Size(193, 21)
        Me.CbmoResourceName.TabIndex = 5
        '
        'LblResourceName
        '
        Me.LblResourceName.AutoSize = True
        Me.LblResourceName.Location = New System.Drawing.Point(12, 120)
        Me.LblResourceName.Name = "LblResourceName"
        Me.LblResourceName.Size = New System.Drawing.Size(84, 13)
        Me.LblResourceName.TabIndex = 4
        Me.LblResourceName.Text = "Resource Name"
        '
        'btnAddLink
        '
        Me.btnAddLink.Location = New System.Drawing.Point(15, 183)
        Me.btnAddLink.Name = "btnAddLink"
        Me.btnAddLink.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddLink.Size = New System.Drawing.Size(193, 47)
        Me.btnAddLink.TabIndex = 6
        Me.btnAddLink.Text = "Add Link"
        Me.btnAddLink.UseVisualStyleBackColor = True
        '
        'FormAddResourceLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 261)
        Me.Controls.Add(Me.btnAddLink)
        Me.Controls.Add(Me.CbmoResourceName)
        Me.Controls.Add(Me.LblResourceName)
        Me.Controls.Add(Me.CmboEntiyName)
        Me.Controls.Add(Me.LblEntityname)
        Me.Controls.Add(Me.CmboEntityType)
        Me.Controls.Add(Me.LblEntityType)
        Me.Name = "FormAddResourceLink"
        Me.Text = "Add Resource Link"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblEntityType As Label
    Friend WithEvents CmboEntityType As ComboBox
    Friend WithEvents CmboEntiyName As ComboBox
    Friend WithEvents LblEntityname As Label
    Friend WithEvents CbmoResourceName As ComboBox
    Friend WithEvents LblResourceName As Label
    Friend WithEvents btnAddLink As Button
End Class
