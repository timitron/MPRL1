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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddResourceLink))
        Me.LblEntityType = New System.Windows.Forms.Label()
        Me.LblEntityname = New System.Windows.Forms.Label()
        Me.CmboResourceName = New System.Windows.Forms.ComboBox()
        Me.LblResourceName = New System.Windows.Forms.Label()
        Me.btnAddLink = New System.Windows.Forms.Button()
        Me.TxtBoxEntityType = New System.Windows.Forms.TextBox()
        Me.TxtBoxEntityName = New System.Windows.Forms.TextBox()
        Me.LblFilter = New System.Windows.Forms.Label()
        Me.Txtboxfilter = New System.Windows.Forms.TextBox()
        Me.GrpBoxAdd = New System.Windows.Forms.GroupBox()
        Me.LblDuplicate = New System.Windows.Forms.Label()
        Me.GrpBoxRemoveLink = New System.Windows.Forms.GroupBox()
        Me.LstViewResources = New System.Windows.Forms.ListView()
        Me.BtnRemoveLink = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GrpBoxAdd.SuspendLayout()
        Me.GrpBoxRemoveLink.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblEntityType
        '
        Me.LblEntityType.AutoSize = True
        Me.LblEntityType.Location = New System.Drawing.Point(21, 9)
        Me.LblEntityType.Name = "LblEntityType"
        Me.LblEntityType.Size = New System.Drawing.Size(63, 13)
        Me.LblEntityType.TabIndex = 0
        Me.LblEntityType.Text = "Entity Type:"
        '
        'LblEntityname
        '
        Me.LblEntityname.AutoSize = True
        Me.LblEntityname.Location = New System.Drawing.Point(244, 9)
        Me.LblEntityname.Name = "LblEntityname"
        Me.LblEntityname.Size = New System.Drawing.Size(64, 13)
        Me.LblEntityname.TabIndex = 2
        Me.LblEntityname.Text = "Entity Name"
        '
        'CmboResourceName
        '
        Me.CmboResourceName.FormattingEnabled = True
        Me.CmboResourceName.Location = New System.Drawing.Point(6, 71)
        Me.CmboResourceName.Name = "CmboResourceName"
        Me.CmboResourceName.Size = New System.Drawing.Size(208, 21)
        Me.CmboResourceName.TabIndex = 5
        '
        'LblResourceName
        '
        Me.LblResourceName.AutoSize = True
        Me.LblResourceName.Location = New System.Drawing.Point(6, 55)
        Me.LblResourceName.Name = "LblResourceName"
        Me.LblResourceName.Size = New System.Drawing.Size(84, 13)
        Me.LblResourceName.TabIndex = 4
        Me.LblResourceName.Text = "Resource Name"
        '
        'btnAddLink
        '
        Me.btnAddLink.Location = New System.Drawing.Point(6, 121)
        Me.btnAddLink.Name = "btnAddLink"
        Me.btnAddLink.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddLink.Size = New System.Drawing.Size(208, 47)
        Me.btnAddLink.TabIndex = 6
        Me.btnAddLink.Text = "Add Link"
        Me.btnAddLink.UseVisualStyleBackColor = True
        '
        'TxtBoxEntityType
        '
        Me.TxtBoxEntityType.Enabled = False
        Me.TxtBoxEntityType.Location = New System.Drawing.Point(24, 25)
        Me.TxtBoxEntityType.Name = "TxtBoxEntityType"
        Me.TxtBoxEntityType.Size = New System.Drawing.Size(193, 20)
        Me.TxtBoxEntityType.TabIndex = 7
        '
        'TxtBoxEntityName
        '
        Me.TxtBoxEntityName.Enabled = False
        Me.TxtBoxEntityName.Location = New System.Drawing.Point(247, 25)
        Me.TxtBoxEntityName.Name = "TxtBoxEntityName"
        Me.TxtBoxEntityName.Size = New System.Drawing.Size(193, 20)
        Me.TxtBoxEntityName.TabIndex = 8
        '
        'LblFilter
        '
        Me.LblFilter.AutoSize = True
        Me.LblFilter.Location = New System.Drawing.Point(6, 16)
        Me.LblFilter.Name = "LblFilter"
        Me.LblFilter.Size = New System.Drawing.Size(112, 13)
        Me.LblFilter.TabIndex = 9
        Me.LblFilter.Text = "Resource Name Filter:"
        '
        'Txtboxfilter
        '
        Me.Txtboxfilter.Location = New System.Drawing.Point(6, 32)
        Me.Txtboxfilter.Name = "Txtboxfilter"
        Me.Txtboxfilter.Size = New System.Drawing.Size(208, 20)
        Me.Txtboxfilter.TabIndex = 10
        '
        'GrpBoxAdd
        '
        Me.GrpBoxAdd.Controls.Add(Me.LblDuplicate)
        Me.GrpBoxAdd.Controls.Add(Me.LblFilter)
        Me.GrpBoxAdd.Controls.Add(Me.Txtboxfilter)
        Me.GrpBoxAdd.Controls.Add(Me.LblResourceName)
        Me.GrpBoxAdd.Controls.Add(Me.CmboResourceName)
        Me.GrpBoxAdd.Controls.Add(Me.btnAddLink)
        Me.GrpBoxAdd.Location = New System.Drawing.Point(15, 51)
        Me.GrpBoxAdd.Name = "GrpBoxAdd"
        Me.GrpBoxAdd.Size = New System.Drawing.Size(220, 174)
        Me.GrpBoxAdd.TabIndex = 11
        Me.GrpBoxAdd.TabStop = False
        Me.GrpBoxAdd.Text = "Add Link"
        '
        'LblDuplicate
        '
        Me.LblDuplicate.AutoSize = True
        Me.LblDuplicate.Location = New System.Drawing.Point(9, 99)
        Me.LblDuplicate.Name = "LblDuplicate"
        Me.LblDuplicate.Size = New System.Drawing.Size(39, 13)
        Me.LblDuplicate.TabIndex = 11
        Me.LblDuplicate.Text = "Label1"
        '
        'GrpBoxRemoveLink
        '
        Me.GrpBoxRemoveLink.Controls.Add(Me.LstViewResources)
        Me.GrpBoxRemoveLink.Controls.Add(Me.BtnRemoveLink)
        Me.GrpBoxRemoveLink.Location = New System.Drawing.Point(241, 51)
        Me.GrpBoxRemoveLink.Name = "GrpBoxRemoveLink"
        Me.GrpBoxRemoveLink.Size = New System.Drawing.Size(220, 174)
        Me.GrpBoxRemoveLink.TabIndex = 12
        Me.GrpBoxRemoveLink.TabStop = False
        Me.GrpBoxRemoveLink.Text = "Remove Link"
        '
        'LstViewResources
        '
        Me.LstViewResources.Location = New System.Drawing.Point(6, 19)
        Me.LstViewResources.MultiSelect = False
        Me.LstViewResources.Name = "LstViewResources"
        Me.LstViewResources.Size = New System.Drawing.Size(208, 97)
        Me.LstViewResources.TabIndex = 7
        Me.LstViewResources.UseCompatibleStateImageBehavior = False
        '
        'BtnRemoveLink
        '
        Me.BtnRemoveLink.Location = New System.Drawing.Point(6, 121)
        Me.BtnRemoveLink.Name = "BtnRemoveLink"
        Me.BtnRemoveLink.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRemoveLink.Size = New System.Drawing.Size(208, 47)
        Me.BtnRemoveLink.TabIndex = 6
        Me.BtnRemoveLink.Text = "Remove Link"
        Me.BtnRemoveLink.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "MPRL Knowledgebase"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FormAddResourceLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 240)
        Me.Controls.Add(Me.GrpBoxRemoveLink)
        Me.Controls.Add(Me.GrpBoxAdd)
        Me.Controls.Add(Me.TxtBoxEntityName)
        Me.Controls.Add(Me.TxtBoxEntityType)
        Me.Controls.Add(Me.LblEntityname)
        Me.Controls.Add(Me.LblEntityType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAddResourceLink"
        Me.Text = "Edit Resource Link"
        Me.GrpBoxAdd.ResumeLayout(False)
        Me.GrpBoxAdd.PerformLayout()
        Me.GrpBoxRemoveLink.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblEntityType As Label
    Friend WithEvents LblEntityname As Label
    Friend WithEvents CmboResourceName As ComboBox
    Friend WithEvents LblResourceName As Label
    Friend WithEvents btnAddLink As Button
    Friend WithEvents TxtBoxEntityType As TextBox
    Friend WithEvents TxtBoxEntityName As TextBox
    Friend WithEvents LblFilter As Label
    Friend WithEvents Txtboxfilter As TextBox
    Friend WithEvents GrpBoxAdd As GroupBox
    Friend WithEvents GrpBoxRemoveLink As GroupBox
    Friend WithEvents BtnRemoveLink As Button
    Friend WithEvents LstViewResources As ListView
    Friend WithEvents LblDuplicate As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
