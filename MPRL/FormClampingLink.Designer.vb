<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClampingLink
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
        Me.CmboboxAdd = New System.Windows.Forms.ComboBox()
        Me.CmboboxRemove = New System.Windows.Forms.ComboBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.LblTargetName = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmboboxAdd
        '
        Me.CmboboxAdd.FormattingEnabled = True
        Me.CmboboxAdd.Location = New System.Drawing.Point(36, 128)
        Me.CmboboxAdd.Name = "CmboboxAdd"
        Me.CmboboxAdd.Size = New System.Drawing.Size(358, 21)
        Me.CmboboxAdd.TabIndex = 25
        '
        'CmboboxRemove
        '
        Me.CmboboxRemove.FormattingEnabled = True
        Me.CmboboxRemove.Location = New System.Drawing.Point(36, 101)
        Me.CmboboxRemove.Name = "CmboboxRemove"
        Me.CmboboxRemove.Size = New System.Drawing.Size(358, 21)
        Me.CmboboxRemove.TabIndex = 24
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(400, 130)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 23
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(400, 101)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 22
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'LblTargetName
        '
        Me.LblTargetName.AutoSize = True
        Me.LblTargetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTargetName.Location = New System.Drawing.Point(41, 54)
        Me.LblTargetName.Name = "LblTargetName"
        Me.LblTargetName.Size = New System.Drawing.Size(229, 26)
        Me.LblTargetName.TabIndex = 21
        Me.LblTargetName.Text = "For: TargetName Here"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(12, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(441, 37)
        Me.LblTitle.TabIndex = 20
        Me.LblTitle.Text = "Machine Tool - Clamping Link"
        '
        'FormClampingLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 185)
        Me.Controls.Add(Me.CmboboxAdd)
        Me.Controls.Add(Me.CmboboxRemove)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.LblTargetName)
        Me.Controls.Add(Me.LblTitle)
        Me.Name = "FormClampingLink"
        Me.Text = "Machine Tool Clamping Link"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmboboxAdd As ComboBox
    Friend WithEvents CmboboxRemove As ComboBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents LblTargetName As Label
    Friend WithEvents LblTitle As Label
End Class
