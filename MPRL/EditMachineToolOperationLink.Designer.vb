﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditMachineLink
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditMachineLink))
        Me.LblTargetName = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GrpBoxRemoveLink = New System.Windows.Forms.GroupBox()
        Me.LstViewFeatures = New System.Windows.Forms.ListView()
        Me.BtnRemoveLink = New System.Windows.Forms.Button()
        Me.GrpBoxAdd = New System.Windows.Forms.GroupBox()
        Me.NumTolerance = New System.Windows.Forms.NumericUpDown()
        Me.LblTolerance = New System.Windows.Forms.Label()
        Me.LblDuplicate = New System.Windows.Forms.Label()
        Me.LblFilter = New System.Windows.Forms.Label()
        Me.Txtboxfilter = New System.Windows.Forms.TextBox()
        Me.LblResourceName = New System.Windows.Forms.Label()
        Me.CmboFeatureName = New System.Windows.Forms.ComboBox()
        Me.btnAddLink = New System.Windows.Forms.Button()
        Me.GrpBoxRemoveLink.SuspendLayout()
        Me.GrpBoxAdd.SuspendLayout()
        CType(Me.NumTolerance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTargetName
        '
        Me.LblTargetName.AutoSize = True
        Me.LblTargetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTargetName.Location = New System.Drawing.Point(31, 46)
        Me.LblTargetName.Name = "LblTargetName"
        Me.LblTargetName.Size = New System.Drawing.Size(229, 26)
        Me.LblTargetName.TabIndex = 15
        Me.LblTargetName.Text = "For: TargetName Here"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(12, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(446, 37)
        Me.LblTitle.TabIndex = 14
        Me.LblTitle.Text = "Machine Tool - Operation Link"
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
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'GrpBoxRemoveLink
        '
        Me.GrpBoxRemoveLink.Controls.Add(Me.LstViewFeatures)
        Me.GrpBoxRemoveLink.Controls.Add(Me.BtnRemoveLink)
        Me.GrpBoxRemoveLink.Location = New System.Drawing.Point(245, 75)
        Me.GrpBoxRemoveLink.Name = "GrpBoxRemoveLink"
        Me.GrpBoxRemoveLink.Size = New System.Drawing.Size(220, 208)
        Me.GrpBoxRemoveLink.TabIndex = 39
        Me.GrpBoxRemoveLink.TabStop = False
        Me.GrpBoxRemoveLink.Text = "Remove Link"
        '
        'LstViewFeatures
        '
        Me.LstViewFeatures.Location = New System.Drawing.Point(6, 19)
        Me.LstViewFeatures.MultiSelect = False
        Me.LstViewFeatures.Name = "LstViewFeatures"
        Me.LstViewFeatures.Size = New System.Drawing.Size(208, 130)
        Me.LstViewFeatures.TabIndex = 7
        Me.LstViewFeatures.UseCompatibleStateImageBehavior = False
        '
        'BtnRemoveLink
        '
        Me.BtnRemoveLink.Location = New System.Drawing.Point(6, 155)
        Me.BtnRemoveLink.Name = "BtnRemoveLink"
        Me.BtnRemoveLink.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRemoveLink.Size = New System.Drawing.Size(208, 47)
        Me.BtnRemoveLink.TabIndex = 6
        Me.BtnRemoveLink.Text = "Remove Link"
        Me.BtnRemoveLink.UseVisualStyleBackColor = True
        '
        'GrpBoxAdd
        '
        Me.GrpBoxAdd.Controls.Add(Me.NumTolerance)
        Me.GrpBoxAdd.Controls.Add(Me.LblTolerance)
        Me.GrpBoxAdd.Controls.Add(Me.LblDuplicate)
        Me.GrpBoxAdd.Controls.Add(Me.LblFilter)
        Me.GrpBoxAdd.Controls.Add(Me.Txtboxfilter)
        Me.GrpBoxAdd.Controls.Add(Me.LblResourceName)
        Me.GrpBoxAdd.Controls.Add(Me.CmboFeatureName)
        Me.GrpBoxAdd.Controls.Add(Me.btnAddLink)
        Me.GrpBoxAdd.Location = New System.Drawing.Point(19, 75)
        Me.GrpBoxAdd.Name = "GrpBoxAdd"
        Me.GrpBoxAdd.Size = New System.Drawing.Size(220, 208)
        Me.GrpBoxAdd.TabIndex = 38
        Me.GrpBoxAdd.TabStop = False
        Me.GrpBoxAdd.Text = "Add Link"
        '
        'NumTolerance
        '
        Me.NumTolerance.AllowDrop = True
        Me.NumTolerance.DecimalPlaces = 4
        Me.NumTolerance.Increment = New Decimal(New Integer() {1, 0, 0, 262144})
        Me.NumTolerance.Location = New System.Drawing.Point(94, 98)
        Me.NumTolerance.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumTolerance.Name = "NumTolerance"
        Me.NumTolerance.Size = New System.Drawing.Size(120, 20)
        Me.NumTolerance.TabIndex = 35
        '
        'LblTolerance
        '
        Me.LblTolerance.AutoSize = True
        Me.LblTolerance.Location = New System.Drawing.Point(32, 100)
        Me.LblTolerance.Name = "LblTolerance"
        Me.LblTolerance.Size = New System.Drawing.Size(58, 13)
        Me.LblTolerance.TabIndex = 12
        Me.LblTolerance.Text = "Tolerance:"
        '
        'LblDuplicate
        '
        Me.LblDuplicate.AutoSize = True
        Me.LblDuplicate.Location = New System.Drawing.Point(6, 136)
        Me.LblDuplicate.Name = "LblDuplicate"
        Me.LblDuplicate.Size = New System.Drawing.Size(39, 13)
        Me.LblDuplicate.TabIndex = 11
        Me.LblDuplicate.Text = "Label1"
        '
        'LblFilter
        '
        Me.LblFilter.AutoSize = True
        Me.LblFilter.Location = New System.Drawing.Point(6, 16)
        Me.LblFilter.Name = "LblFilter"
        Me.LblFilter.Size = New System.Drawing.Size(112, 13)
        Me.LblFilter.TabIndex = 9
        Me.LblFilter.Text = "Operation Name Filter:"
        '
        'Txtboxfilter
        '
        Me.Txtboxfilter.Location = New System.Drawing.Point(6, 32)
        Me.Txtboxfilter.Name = "Txtboxfilter"
        Me.Txtboxfilter.Size = New System.Drawing.Size(208, 20)
        Me.Txtboxfilter.TabIndex = 10
        '
        'LblResourceName
        '
        Me.LblResourceName.AutoSize = True
        Me.LblResourceName.Location = New System.Drawing.Point(6, 55)
        Me.LblResourceName.Name = "LblResourceName"
        Me.LblResourceName.Size = New System.Drawing.Size(84, 13)
        Me.LblResourceName.TabIndex = 4
        Me.LblResourceName.Text = "Operation Name"
        '
        'CmboFeatureName
        '
        Me.CmboFeatureName.FormattingEnabled = True
        Me.CmboFeatureName.Location = New System.Drawing.Point(6, 71)
        Me.CmboFeatureName.Name = "CmboFeatureName"
        Me.CmboFeatureName.Size = New System.Drawing.Size(208, 21)
        Me.CmboFeatureName.TabIndex = 5
        '
        'btnAddLink
        '
        Me.btnAddLink.Location = New System.Drawing.Point(6, 155)
        Me.btnAddLink.Name = "btnAddLink"
        Me.btnAddLink.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAddLink.Size = New System.Drawing.Size(208, 47)
        Me.btnAddLink.TabIndex = 6
        Me.btnAddLink.Text = "Add Link"
        Me.btnAddLink.UseVisualStyleBackColor = True
        '
        'FormEditMachineLink
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(513, 322)
        Me.Controls.Add(Me.GrpBoxRemoveLink)
        Me.Controls.Add(Me.GrpBoxAdd)
        Me.Controls.Add(Me.LblTargetName)
        Me.Controls.Add(Me.LblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormEditMachineLink"
        Me.Text = "Machine Tool - Operation Link"
        Me.GrpBoxRemoveLink.ResumeLayout(False)
        Me.GrpBoxAdd.ResumeLayout(False)
        Me.GrpBoxAdd.PerformLayout()
        CType(Me.NumTolerance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTargetName As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GrpBoxRemoveLink As GroupBox
    Friend WithEvents LstViewFeatures As ListView
    Friend WithEvents BtnRemoveLink As Button
    Friend WithEvents GrpBoxAdd As GroupBox
    Friend WithEvents LblDuplicate As Label
    Friend WithEvents LblFilter As Label
    Friend WithEvents Txtboxfilter As TextBox
    Friend WithEvents LblResourceName As Label
    Friend WithEvents CmboFeatureName As ComboBox
    Friend WithEvents btnAddLink As Button
    Friend WithEvents LblTolerance As Label
    Friend WithEvents NumTolerance As NumericUpDown
End Class