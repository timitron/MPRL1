<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHome
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
        Me.ButtonMachineToolFlow = New System.Windows.Forms.Button()
        Me.ButtonMethodSuggestorFlow = New System.Windows.Forms.Button()
        Me.ButtonMachiningMethodsFlow = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MachinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MachineToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MachiningMethodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClampingMethodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeaturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PPE = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtboxTitle = New System.Windows.Forms.TextBox()
        Me.MprlDataSet1 = New MPRL.MPRLDataSet()
        Me.LnkAbout = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonMachineToolFlow
        '
        Me.ButtonMachineToolFlow.AutoSize = True
        Me.ButtonMachineToolFlow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonMachineToolFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMachineToolFlow.Location = New System.Drawing.Point(0, 74)
        Me.ButtonMachineToolFlow.Margin = New System.Windows.Forms.Padding(3, 300, 3, 3)
        Me.ButtonMachineToolFlow.MinimumSize = New System.Drawing.Size(600, 75)
        Me.ButtonMachineToolFlow.Name = "ButtonMachineToolFlow"
        Me.ButtonMachineToolFlow.Size = New System.Drawing.Size(721, 75)
        Me.ButtonMachineToolFlow.TabIndex = 1
        Me.ButtonMachineToolFlow.Text = "Browse Machine Tools"
        Me.ButtonMachineToolFlow.UseVisualStyleBackColor = True
        '
        'ButtonMethodSuggestorFlow
        '
        Me.ButtonMethodSuggestorFlow.AutoSize = True
        Me.ButtonMethodSuggestorFlow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonMethodSuggestorFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMethodSuggestorFlow.Location = New System.Drawing.Point(0, 149)
        Me.ButtonMethodSuggestorFlow.MinimumSize = New System.Drawing.Size(600, 75)
        Me.ButtonMethodSuggestorFlow.Name = "ButtonMethodSuggestorFlow"
        Me.ButtonMethodSuggestorFlow.Size = New System.Drawing.Size(721, 75)
        Me.ButtonMethodSuggestorFlow.TabIndex = 2
        Me.ButtonMethodSuggestorFlow.Text = "Machining Method Suggestor"
        Me.ButtonMethodSuggestorFlow.UseVisualStyleBackColor = True
        '
        'ButtonMachiningMethodsFlow
        '
        Me.ButtonMachiningMethodsFlow.AutoSize = True
        Me.ButtonMachiningMethodsFlow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonMachiningMethodsFlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMachiningMethodsFlow.Location = New System.Drawing.Point(0, 224)
        Me.ButtonMachiningMethodsFlow.MinimumSize = New System.Drawing.Size(600, 75)
        Me.ButtonMachiningMethodsFlow.Name = "ButtonMachiningMethodsFlow"
        Me.ButtonMachiningMethodsFlow.Size = New System.Drawing.Size(721, 75)
        Me.ButtonMachiningMethodsFlow.TabIndex = 3
        Me.ButtonMachiningMethodsFlow.Text = "Browse Machining Methods"
        Me.ButtonMachiningMethodsFlow.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MachinesToolStripMenuItem, Me.MachineToolsToolStripMenuItem, Me.MachiningMethodsToolStripMenuItem, Me.ClampingMethodsToolStripMenuItem, Me.FeaturesToolStripMenuItem, Me.ResourcesToolStripMenuItem, Me.PPE})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 299)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 27)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MachinesToolStripMenuItem
        '
        Me.MachinesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.RemoveToolStripMenuItem})
        Me.MachinesToolStripMenuItem.Name = "MachinesToolStripMenuItem"
        Me.MachinesToolStripMenuItem.Size = New System.Drawing.Size(79, 23)
        Me.MachinesToolStripMenuItem.Text = "Machines"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'RemoveToolStripMenuItem
        '
        Me.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem"
        Me.RemoveToolStripMenuItem.Size = New System.Drawing.Size(127, 24)
        Me.RemoveToolStripMenuItem.Text = "Remove"
        '
        'MachineToolsToolStripMenuItem
        '
        Me.MachineToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.RemoveToolStripMenuItem1})
        Me.MachineToolsToolStripMenuItem.Name = "MachineToolsToolStripMenuItem"
        Me.MachineToolsToolStripMenuItem.Size = New System.Drawing.Size(108, 23)
        Me.MachineToolsToolStripMenuItem.Text = "Machine Tools"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(127, 24)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(127, 24)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'RemoveToolStripMenuItem1
        '
        Me.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1"
        Me.RemoveToolStripMenuItem1.Size = New System.Drawing.Size(127, 24)
        Me.RemoveToolStripMenuItem1.Text = "Remove"
        '
        'MachiningMethodsToolStripMenuItem
        '
        Me.MachiningMethodsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem2, Me.EditToolStripMenuItem2, Me.RemoveToolStripMenuItem2})
        Me.MachiningMethodsToolStripMenuItem.Name = "MachiningMethodsToolStripMenuItem"
        Me.MachiningMethodsToolStripMenuItem.Size = New System.Drawing.Size(144, 23)
        Me.MachiningMethodsToolStripMenuItem.Text = "Machining Methods"
        '
        'AddToolStripMenuItem2
        '
        Me.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2"
        Me.AddToolStripMenuItem2.Size = New System.Drawing.Size(127, 24)
        Me.AddToolStripMenuItem2.Text = "Add"
        '
        'EditToolStripMenuItem2
        '
        Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        Me.EditToolStripMenuItem2.Size = New System.Drawing.Size(127, 24)
        Me.EditToolStripMenuItem2.Text = "Edit"
        '
        'RemoveToolStripMenuItem2
        '
        Me.RemoveToolStripMenuItem2.Name = "RemoveToolStripMenuItem2"
        Me.RemoveToolStripMenuItem2.Size = New System.Drawing.Size(127, 24)
        Me.RemoveToolStripMenuItem2.Text = "Remove"
        '
        'ClampingMethodsToolStripMenuItem
        '
        Me.ClampingMethodsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem3, Me.EditToolStripMenuItem3, Me.RemoveToolStripMenuItem3})
        Me.ClampingMethodsToolStripMenuItem.Name = "ClampingMethodsToolStripMenuItem"
        Me.ClampingMethodsToolStripMenuItem.Size = New System.Drawing.Size(138, 23)
        Me.ClampingMethodsToolStripMenuItem.Text = "Clamping Methods"
        '
        'AddToolStripMenuItem3
        '
        Me.AddToolStripMenuItem3.Name = "AddToolStripMenuItem3"
        Me.AddToolStripMenuItem3.Size = New System.Drawing.Size(127, 24)
        Me.AddToolStripMenuItem3.Text = "Add"
        '
        'EditToolStripMenuItem3
        '
        Me.EditToolStripMenuItem3.Name = "EditToolStripMenuItem3"
        Me.EditToolStripMenuItem3.Size = New System.Drawing.Size(127, 24)
        Me.EditToolStripMenuItem3.Text = "Edit"
        '
        'RemoveToolStripMenuItem3
        '
        Me.RemoveToolStripMenuItem3.Name = "RemoveToolStripMenuItem3"
        Me.RemoveToolStripMenuItem3.Size = New System.Drawing.Size(127, 24)
        Me.RemoveToolStripMenuItem3.Text = "Remove"
        '
        'FeaturesToolStripMenuItem
        '
        Me.FeaturesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem4, Me.EditToolStripMenuItem4, Me.RemoveToolStripMenuItem4})
        Me.FeaturesToolStripMenuItem.Name = "FeaturesToolStripMenuItem"
        Me.FeaturesToolStripMenuItem.Size = New System.Drawing.Size(73, 23)
        Me.FeaturesToolStripMenuItem.Text = "Features"
        '
        'AddToolStripMenuItem4
        '
        Me.AddToolStripMenuItem4.Name = "AddToolStripMenuItem4"
        Me.AddToolStripMenuItem4.Size = New System.Drawing.Size(127, 24)
        Me.AddToolStripMenuItem4.Text = "Add"
        '
        'EditToolStripMenuItem4
        '
        Me.EditToolStripMenuItem4.Name = "EditToolStripMenuItem4"
        Me.EditToolStripMenuItem4.Size = New System.Drawing.Size(127, 24)
        Me.EditToolStripMenuItem4.Text = "Edit"
        '
        'RemoveToolStripMenuItem4
        '
        Me.RemoveToolStripMenuItem4.Name = "RemoveToolStripMenuItem4"
        Me.RemoveToolStripMenuItem4.Size = New System.Drawing.Size(127, 24)
        Me.RemoveToolStripMenuItem4.Text = "Remove"
        '
        'ResourcesToolStripMenuItem
        '
        Me.ResourcesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem5, Me.EditToolStripMenuItem5, Me.RemoveToolStripMenuItem5})
        Me.ResourcesToolStripMenuItem.Name = "ResourcesToolStripMenuItem"
        Me.ResourcesToolStripMenuItem.Size = New System.Drawing.Size(82, 23)
        Me.ResourcesToolStripMenuItem.Text = "Resources"
        '
        'AddToolStripMenuItem5
        '
        Me.AddToolStripMenuItem5.Name = "AddToolStripMenuItem5"
        Me.AddToolStripMenuItem5.Size = New System.Drawing.Size(127, 24)
        Me.AddToolStripMenuItem5.Text = "Add"
        '
        'EditToolStripMenuItem5
        '
        Me.EditToolStripMenuItem5.Name = "EditToolStripMenuItem5"
        Me.EditToolStripMenuItem5.Size = New System.Drawing.Size(127, 24)
        Me.EditToolStripMenuItem5.Text = "Edit"
        '
        'RemoveToolStripMenuItem5
        '
        Me.RemoveToolStripMenuItem5.Name = "RemoveToolStripMenuItem5"
        Me.RemoveToolStripMenuItem5.Size = New System.Drawing.Size(127, 24)
        Me.RemoveToolStripMenuItem5.Text = "Remove"
        '
        'PPE
        '
        Me.PPE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem6, Me.EditToolStripMenuItem6, Me.RemoveToolStripMenuItem6})
        Me.PPE.Name = "PPE"
        Me.PPE.Size = New System.Drawing.Size(44, 23)
        Me.PPE.Text = "PPE"
        '
        'AddToolStripMenuItem6
        '
        Me.AddToolStripMenuItem6.Name = "AddToolStripMenuItem6"
        Me.AddToolStripMenuItem6.Size = New System.Drawing.Size(127, 24)
        Me.AddToolStripMenuItem6.Text = "Add"
        '
        'EditToolStripMenuItem6
        '
        Me.EditToolStripMenuItem6.Name = "EditToolStripMenuItem6"
        Me.EditToolStripMenuItem6.Size = New System.Drawing.Size(127, 24)
        Me.EditToolStripMenuItem6.Text = "Edit"
        '
        'RemoveToolStripMenuItem6
        '
        Me.RemoveToolStripMenuItem6.Name = "RemoveToolStripMenuItem6"
        Me.RemoveToolStripMenuItem6.Size = New System.Drawing.Size(127, 24)
        Me.RemoveToolStripMenuItem6.Text = "Remove"
        '
        'TxtboxTitle
        '
        Me.TxtboxTitle.BackColor = System.Drawing.SystemColors.Control
        Me.TxtboxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtboxTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtboxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtboxTitle.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtboxTitle.Location = New System.Drawing.Point(0, 10)
        Me.TxtboxTitle.Margin = New System.Windows.Forms.Padding(3, 300, 3, 300)
        Me.TxtboxTitle.Name = "TxtboxTitle"
        Me.TxtboxTitle.ReadOnly = True
        Me.TxtboxTitle.Size = New System.Drawing.Size(721, 37)
        Me.TxtboxTitle.TabIndex = 5
        Me.TxtboxTitle.Text = "MPRL KnowledgeBase"
        Me.TxtboxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MprlDataSet1
        '
        Me.MprlDataSet1.DataSetName = "MPRLDataSet"
        Me.MprlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LnkAbout
        '
        Me.LnkAbout.AutoSize = True
        Me.LnkAbout.Location = New System.Drawing.Point(683, 10)
        Me.LnkAbout.Name = "LnkAbout"
        Me.LnkAbout.Size = New System.Drawing.Size(35, 13)
        Me.LnkAbout.TabIndex = 9
        Me.LnkAbout.TabStop = True
        Me.LnkAbout.Text = "About"
        '
        'FormHome
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(721, 329)
        Me.Controls.Add(Me.LnkAbout)
        Me.Controls.Add(Me.ButtonMachineToolFlow)
        Me.Controls.Add(Me.ButtonMethodSuggestorFlow)
        Me.Controls.Add(Me.ButtonMachiningMethodsFlow)
        Me.Controls.Add(Me.TxtboxTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(700, 300)
        Me.Name = "FormHome"
        Me.Padding = New System.Windows.Forms.Padding(0, 10, 0, 3)
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonMachineToolFlow As Button
    Friend WithEvents ButtonMethodSuggestorFlow As Button
    Friend WithEvents ButtonMachiningMethodsFlow As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MachinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MachineToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MachiningMethodsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClampingMethodsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeaturesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ResourcesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MprlDataSet1 As MPRLDataSet
    Friend WithEvents TxtboxTitle As TextBox
    Friend WithEvents PPE As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents RemoveToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents LnkAbout As LinkLabel
End Class
