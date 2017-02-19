<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
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
        Me.editList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblFilter = New System.Windows.Forms.Label()
        Me.Txtboxfilter = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'editList
        '
        Me.editList.FormattingEnabled = True
        Me.editList.Location = New System.Drawing.Point(9, 92)
        Me.editList.Name = "editList"
        Me.editList.Size = New System.Drawing.Size(263, 225)
        Me.editList.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label1"
        '
        'LblFilter
        '
        Me.LblFilter.AutoSize = True
        Me.LblFilter.Location = New System.Drawing.Point(9, 50)
        Me.LblFilter.Name = "LblFilter"
        Me.LblFilter.Size = New System.Drawing.Size(63, 13)
        Me.LblFilter.TabIndex = 11
        Me.LblFilter.Text = "Name Filter:"
        '
        'Txtboxfilter
        '
        Me.Txtboxfilter.Location = New System.Drawing.Point(9, 66)
        Me.Txtboxfilter.Name = "Txtboxfilter"
        Me.Txtboxfilter.Size = New System.Drawing.Size(263, 20)
        Me.Txtboxfilter.TabIndex = 12
        '
        'EditForm
        '
        Me.ClientSize = New System.Drawing.Size(284, 332)
        Me.Controls.Add(Me.LblFilter)
        Me.Controls.Add(Me.Txtboxfilter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.editList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EditForm"
        Me.Text = "Select Entity To Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListEditItems As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents editList As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblFilter As Label
    Friend WithEvents Txtboxfilter As TextBox
End Class
