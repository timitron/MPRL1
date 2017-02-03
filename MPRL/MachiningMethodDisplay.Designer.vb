<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMachiningMethodsDisplay
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
        Me.LstViewMachiningMethods = New System.Windows.Forms.ListView()
        Me.TxtBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'LstViewMachiningMethods
        '
        Me.LstViewMachiningMethods.Location = New System.Drawing.Point(42, 17)
        Me.LstViewMachiningMethods.Name = "LstViewMachiningMethods"
        Me.LstViewMachiningMethods.Size = New System.Drawing.Size(1033, 536)
        Me.LstViewMachiningMethods.TabIndex = 0
        Me.LstViewMachiningMethods.UseCompatibleStateImageBehavior = False
        '
        'TxtBoxDescription
        '
        Me.TxtBoxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxDescription.Location = New System.Drawing.Point(1093, 16)
        Me.TxtBoxDescription.Margin = New System.Windows.Forms.Padding(15)
        Me.TxtBoxDescription.Name = "TxtBoxDescription"
        Me.TxtBoxDescription.Size = New System.Drawing.Size(250, 537)
        Me.TxtBoxDescription.TabIndex = 1
        Me.TxtBoxDescription.Text = ""
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'FormMachiningMethodsDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1367, 585)
        Me.Controls.Add(Me.TxtBoxDescription)
        Me.Controls.Add(Me.LstViewMachiningMethods)
        Me.Name = "FormMachiningMethodsDisplay"
        Me.Text = "Machining Methods "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstViewMachiningMethods As ListView
    Friend WithEvents TxtBoxDescription As RichTextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
