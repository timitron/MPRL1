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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BttnPrint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstViewMachiningMethods
        '
        Me.LstViewMachiningMethods.Location = New System.Drawing.Point(42, 78)
        Me.LstViewMachiningMethods.Name = "LstViewMachiningMethods"
        Me.LstViewMachiningMethods.Size = New System.Drawing.Size(1033, 475)
        Me.LstViewMachiningMethods.TabIndex = 0
        Me.LstViewMachiningMethods.UseCompatibleStateImageBehavior = False
        '
        'TxtBoxDescription
        '
        Me.TxtBoxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxDescription.Location = New System.Drawing.Point(1088, 78)
        Me.TxtBoxDescription.Margin = New System.Windows.Forms.Padding(15)
        Me.TxtBoxDescription.Name = "TxtBoxDescription"
        Me.TxtBoxDescription.Size = New System.Drawing.Size(250, 475)
        Me.TxtBoxDescription.TabIndex = 1
        Me.TxtBoxDescription.Text = ""
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BttnPrint)
        Me.Panel1.Location = New System.Drawing.Point(1094, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 53)
        Me.Panel1.TabIndex = 28
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
        'BttnPrint
        '
        Me.BttnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnPrint.Location = New System.Drawing.Point(186, 2)
        Me.BttnPrint.Name = "BttnPrint"
        Me.BttnPrint.Size = New System.Drawing.Size(57, 46)
        Me.BttnPrint.TabIndex = 26
        Me.BttnPrint.Text = "Print NA"
        Me.BttnPrint.UseVisualStyleBackColor = True
        '
        'FormMachiningMethodsDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1362, 585)
        Me.Controls.Add(Me.TxtBoxDescription)
        Me.Controls.Add(Me.LstViewMachiningMethods)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormMachiningMethodsDisplay"
        Me.Text = "Machining Methods "
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstViewMachiningMethods As ListView
    Friend WithEvents TxtBoxDescription As RichTextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BttnPrint As Button
End Class
