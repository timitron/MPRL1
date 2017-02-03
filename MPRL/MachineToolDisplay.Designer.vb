<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMachineToolsDisplay
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
        Me.ListViewMachineToolDisplay = New System.Windows.Forms.ListView()
        Me.TxtBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ListViewMachineToolDisplay
        '
        Me.ListViewMachineToolDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewMachineToolDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewMachineToolDisplay.Location = New System.Drawing.Point(33, 24)
        Me.ListViewMachineToolDisplay.MultiSelect = False
        Me.ListViewMachineToolDisplay.Name = "ListViewMachineToolDisplay"
        Me.ListViewMachineToolDisplay.Size = New System.Drawing.Size(682, 455)
        Me.ListViewMachineToolDisplay.TabIndex = 0
        Me.ListViewMachineToolDisplay.UseCompatibleStateImageBehavior = False
        '
        'TxtBoxDescription
        '
        Me.TxtBoxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxDescription.Location = New System.Drawing.Point(733, 24)
        Me.TxtBoxDescription.Margin = New System.Windows.Forms.Padding(15)
        Me.TxtBoxDescription.Name = "TxtBoxDescription"
        Me.TxtBoxDescription.Size = New System.Drawing.Size(346, 455)
        Me.TxtBoxDescription.TabIndex = 2
        Me.TxtBoxDescription.Text = ""
        '
        'FormMachineToolsDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1103, 518)
        Me.Controls.Add(Me.TxtBoxDescription)
        Me.Controls.Add(Me.ListViewMachineToolDisplay)
        Me.Name = "FormMachineToolsDisplay"
        Me.Text = "Machine Tools"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewMachineToolDisplay As ListView
    Friend WithEvents TxtBoxDescription As RichTextBox
End Class
