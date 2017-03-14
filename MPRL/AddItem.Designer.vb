<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddItem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitChanges = New System.Windows.Forms.Button()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LblDuplicate = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PctureboxIcon = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblDescriptionMax = New System.Windows.Forms.Label()
        Me.LblTitleMax = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PctureboxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Detail Image"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 248)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.CausesValidation = False
        Me.DescriptionTextBox.Location = New System.Drawing.Point(9, 79)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DescriptionTextBox.Size = New System.Drawing.Size(301, 146)
        Me.DescriptionTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(9, 36)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(301, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'SubmitChanges
        '
        Me.SubmitChanges.Location = New System.Drawing.Point(185, 529)
        Me.SubmitChanges.Name = "SubmitChanges"
        Me.SubmitChanges.Size = New System.Drawing.Size(153, 43)
        Me.SubmitChanges.TabIndex = 5
        Me.SubmitChanges.Text = "Submit"
        Me.SubmitChanges.UseVisualStyleBackColor = True
        '
        'Browse
        '
        Me.Browse.Location = New System.Drawing.Point(234, 348)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(76, 25)
        Me.Browse.TabIndex = 3
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Label5"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LblDuplicate
        '
        Me.LblDuplicate.AutoSize = True
        Me.LblDuplicate.Location = New System.Drawing.Point(57, 20)
        Me.LblDuplicate.Name = "LblDuplicate"
        Me.LblDuplicate.Size = New System.Drawing.Size(72, 13)
        Me.LblDuplicate.TabIndex = 11
        Me.LblDuplicate.Text = "Unique Name"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Add Entity"
        Me.NotifyIcon1.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PctureboxIcon)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.LblDescriptionMax)
        Me.GroupBox1.Controls.Add(Me.LblTitleMax)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.LblDuplicate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Browse)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 486)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(6, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Icon Image"
        '
        'PctureboxIcon
        '
        Me.PctureboxIcon.Location = New System.Drawing.Point(9, 375)
        Me.PctureboxIcon.Name = "PctureboxIcon"
        Me.PctureboxIcon.Size = New System.Drawing.Size(71, 66)
        Me.PctureboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctureboxIcon.TabIndex = 16
        Me.PctureboxIcon.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblDescriptionMax
        '
        Me.LblDescriptionMax.AutoSize = True
        Me.LblDescriptionMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescriptionMax.Location = New System.Drawing.Point(248, 228)
        Me.LblDescriptionMax.Name = "LblDescriptionMax"
        Me.LblDescriptionMax.Size = New System.Drawing.Size(62, 13)
        Me.LblDescriptionMax.TabIndex = 13
        Me.LblDescriptionMax.Text = "(4,000 max)"
        '
        'LblTitleMax
        '
        Me.LblTitleMax.AutoSize = True
        Me.LblTitleMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleMax.Location = New System.Drawing.Point(257, 59)
        Me.LblTitleMax.Name = "LblTitleMax"
        Me.LblTitleMax.Size = New System.Drawing.Size(53, 13)
        Me.LblTitleMax.TabIndex = 12
        Me.LblTitleMax.Text = "(254 max)"
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 580)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SubmitChanges)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddItem"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PctureboxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents SubmitChanges As Button
    Friend WithEvents Browse As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LblDuplicate As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblDescriptionMax As Label
    Friend WithEvents LblTitleMax As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PctureboxIcon As PictureBox
    Friend WithEvents Button1 As Button
End Class
