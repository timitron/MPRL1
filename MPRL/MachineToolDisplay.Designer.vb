<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMachineToolsDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMachineToolsDisplay))
        Me.ListViewMachineToolDisplay = New System.Windows.Forms.ListView()
        Me.TxtBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewMachineToolDisplay
        '
        Me.ListViewMachineToolDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewMachineToolDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewMachineToolDisplay.Location = New System.Drawing.Point(18, 73)
        Me.ListViewMachineToolDisplay.MultiSelect = False
        Me.ListViewMachineToolDisplay.Name = "ListViewMachineToolDisplay"
        Me.ListViewMachineToolDisplay.Size = New System.Drawing.Size(763, 421)
        Me.ListViewMachineToolDisplay.TabIndex = 0
        Me.ListViewMachineToolDisplay.UseCompatibleStateImageBehavior = False
        '
        'TxtBoxDescription
        '
        Me.TxtBoxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxDescription.Location = New System.Drawing.Point(799, 73)
        Me.TxtBoxDescription.Margin = New System.Windows.Forms.Padding(15)
        Me.TxtBoxDescription.Name = "TxtBoxDescription"
        Me.TxtBoxDescription.ReadOnly = True
        Me.TxtBoxDescription.Size = New System.Drawing.Size(280, 421)
        Me.TxtBoxDescription.TabIndex = 2
        Me.TxtBoxDescription.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(882, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 53)
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
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(12, 39)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(520, 31)
        Me.LblTitle.TabIndex = 29
        Me.LblTitle.Text = "Select a machine tool for more information"
        '
        'FormMachineToolsDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1103, 518)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtBoxDescription)
        Me.Controls.Add(Me.ListViewMachineToolDisplay)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMachineToolsDisplay"
        Me.Text = "Machine Tools"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewMachineToolDisplay As ListView
    Friend WithEvents TxtBoxDescription As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LblTitle As Label
End Class
