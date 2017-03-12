<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMachineToolDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMachineToolDetails))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PictureMachineOverview = New System.Windows.Forms.PictureBox()
        Me.LstMachineMethods = New System.Windows.Forms.ListView()
        Me.LstMachines = New System.Windows.Forms.ListView()
        Me.LstResources = New System.Windows.Forms.ListView()
        Me.BtnEditMachineLinks = New System.Windows.Forms.Button()
        Me.BtnEditMachiningMethodsLink = New System.Windows.Forms.Button()
        Me.BtnEditResourcesLink = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabMachines = New System.Windows.Forms.TabControl()
        Me.TabMach = New System.Windows.Forms.TabPage()
        Me.TabOperations = New System.Windows.Forms.TabPage()
        Me.TabSetups = New System.Windows.Forms.TabPage()
        Me.BtnEditClampingLinks = New System.Windows.Forms.Button()
        Me.LstClampingMethods = New System.Windows.Forms.ListView()
        Me.TabResources = New System.Windows.Forms.TabPage()
        CType(Me.PictureMachineOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabMachines.SuspendLayout()
        Me.TabMach.SuspendLayout()
        Me.TabOperations.SuspendLayout()
        Me.TabSetups.SuspendLayout()
        Me.TabResources.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(25, 10)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(445, 53)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "Machine Name Here"
        '
        'PictureMachineOverview
        '
        Me.PictureMachineOverview.Location = New System.Drawing.Point(45, 70)
        Me.PictureMachineOverview.Name = "PictureMachineOverview"
        Me.PictureMachineOverview.Size = New System.Drawing.Size(900, 400)
        Me.PictureMachineOverview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureMachineOverview.TabIndex = 7
        Me.PictureMachineOverview.TabStop = False
        '
        'LstMachineMethods
        '
        Me.LstMachineMethods.BackColor = System.Drawing.SystemColors.Control
        Me.LstMachineMethods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMachineMethods.Location = New System.Drawing.Point(6, 6)
        Me.LstMachineMethods.Name = "LstMachineMethods"
        Me.LstMachineMethods.Size = New System.Drawing.Size(880, 310)
        Me.LstMachineMethods.TabIndex = 10
        Me.LstMachineMethods.TileSize = New System.Drawing.Size(100, 100)
        Me.LstMachineMethods.UseCompatibleStateImageBehavior = False
        '
        'LstMachines
        '
        Me.LstMachines.BackColor = System.Drawing.SystemColors.Control
        Me.LstMachines.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMachines.Location = New System.Drawing.Point(6, 6)
        Me.LstMachines.Name = "LstMachines"
        Me.LstMachines.Size = New System.Drawing.Size(880, 310)
        Me.LstMachines.TabIndex = 11
        Me.LstMachines.UseCompatibleStateImageBehavior = False
        '
        'LstResources
        '
        Me.LstResources.BackColor = System.Drawing.SystemColors.Control
        Me.LstResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstResources.FullRowSelect = True
        Me.LstResources.Location = New System.Drawing.Point(6, 6)
        Me.LstResources.Margin = New System.Windows.Forms.Padding(3, 3, 3, 200)
        Me.LstResources.MinimumSize = New System.Drawing.Size(500, 100)
        Me.LstResources.MultiSelect = False
        Me.LstResources.Name = "LstResources"
        Me.LstResources.Size = New System.Drawing.Size(880, 310)
        Me.LstResources.TabIndex = 14
        Me.LstResources.UseCompatibleStateImageBehavior = False
        '
        'BtnEditMachineLinks
        '
        Me.BtnEditMachineLinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditMachineLinks.Location = New System.Drawing.Point(811, 6)
        Me.BtnEditMachineLinks.Name = "BtnEditMachineLinks"
        Me.BtnEditMachineLinks.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditMachineLinks.TabIndex = 17
        Me.BtnEditMachineLinks.Text = "Edit"
        Me.BtnEditMachineLinks.UseVisualStyleBackColor = True
        '
        'BtnEditMachiningMethodsLink
        '
        Me.BtnEditMachiningMethodsLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditMachiningMethodsLink.Location = New System.Drawing.Point(811, 6)
        Me.BtnEditMachiningMethodsLink.Name = "BtnEditMachiningMethodsLink"
        Me.BtnEditMachiningMethodsLink.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditMachiningMethodsLink.TabIndex = 18
        Me.BtnEditMachiningMethodsLink.Text = "Edit"
        Me.BtnEditMachiningMethodsLink.UseVisualStyleBackColor = True
        '
        'BtnEditResourcesLink
        '
        Me.BtnEditResourcesLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditResourcesLink.Location = New System.Drawing.Point(811, 6)
        Me.BtnEditResourcesLink.Name = "BtnEditResourcesLink"
        Me.BtnEditResourcesLink.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditResourcesLink.TabIndex = 20
        Me.BtnEditResourcesLink.Text = "Edit"
        Me.BtnEditResourcesLink.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(749, 0)
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
        'TabMachines
        '
        Me.TabMachines.Controls.Add(Me.TabMach)
        Me.TabMachines.Controls.Add(Me.TabOperations)
        Me.TabMachines.Controls.Add(Me.TabSetups)
        Me.TabMachines.Controls.Add(Me.TabResources)
        Me.TabMachines.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMachines.Location = New System.Drawing.Point(45, 476)
        Me.TabMachines.Name = "TabMachines"
        Me.TabMachines.SelectedIndex = 0
        Me.TabMachines.Size = New System.Drawing.Size(900, 364)
        Me.TabMachines.TabIndex = 29
        '
        'TabMach
        '
        Me.TabMach.Controls.Add(Me.BtnEditMachineLinks)
        Me.TabMach.Controls.Add(Me.LstMachines)
        Me.TabMach.Location = New System.Drawing.Point(4, 38)
        Me.TabMach.Name = "TabMach"
        Me.TabMach.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMach.Size = New System.Drawing.Size(892, 322)
        Me.TabMach.TabIndex = 1
        Me.TabMach.Text = "Machines"
        Me.TabMach.UseVisualStyleBackColor = True
        '
        'TabOperations
        '
        Me.TabOperations.Controls.Add(Me.BtnEditMachiningMethodsLink)
        Me.TabOperations.Controls.Add(Me.LstMachineMethods)
        Me.TabOperations.Location = New System.Drawing.Point(4, 38)
        Me.TabOperations.Name = "TabOperations"
        Me.TabOperations.Padding = New System.Windows.Forms.Padding(3)
        Me.TabOperations.Size = New System.Drawing.Size(892, 322)
        Me.TabOperations.TabIndex = 2
        Me.TabOperations.Text = "Operations"
        Me.TabOperations.UseVisualStyleBackColor = True
        '
        'TabSetups
        '
        Me.TabSetups.Controls.Add(Me.BtnEditClampingLinks)
        Me.TabSetups.Controls.Add(Me.LstClampingMethods)
        Me.TabSetups.Location = New System.Drawing.Point(4, 38)
        Me.TabSetups.Name = "TabSetups"
        Me.TabSetups.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSetups.Size = New System.Drawing.Size(892, 322)
        Me.TabSetups.TabIndex = 3
        Me.TabSetups.Text = "Setups"
        Me.TabSetups.UseVisualStyleBackColor = True
        '
        'BtnEditClampingLinks
        '
        Me.BtnEditClampingLinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditClampingLinks.Location = New System.Drawing.Point(811, 6)
        Me.BtnEditClampingLinks.Name = "BtnEditClampingLinks"
        Me.BtnEditClampingLinks.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditClampingLinks.TabIndex = 22
        Me.BtnEditClampingLinks.Text = "Edit"
        Me.BtnEditClampingLinks.UseVisualStyleBackColor = True
        '
        'LstClampingMethods
        '
        Me.LstClampingMethods.BackColor = System.Drawing.SystemColors.Control
        Me.LstClampingMethods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstClampingMethods.Location = New System.Drawing.Point(6, 6)
        Me.LstClampingMethods.Name = "LstClampingMethods"
        Me.LstClampingMethods.Size = New System.Drawing.Size(880, 310)
        Me.LstClampingMethods.TabIndex = 21
        Me.LstClampingMethods.UseCompatibleStateImageBehavior = False
        '
        'TabResources
        '
        Me.TabResources.Controls.Add(Me.BtnEditResourcesLink)
        Me.TabResources.Controls.Add(Me.LstResources)
        Me.TabResources.Location = New System.Drawing.Point(4, 38)
        Me.TabResources.Name = "TabResources"
        Me.TabResources.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResources.Size = New System.Drawing.Size(892, 322)
        Me.TabResources.TabIndex = 4
        Me.TabResources.Text = "Resources"
        Me.TabResources.UseVisualStyleBackColor = True
        '
        'FormMachineToolDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1049, 866)
        Me.Controls.Add(Me.TabMachines)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PictureMachineOverview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "FormMachineToolDetails"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 200)
        Me.Text = "Machine Tool Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureMachineOverview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabMachines.ResumeLayout(False)
        Me.TabMach.ResumeLayout(False)
        Me.TabOperations.ResumeLayout(False)
        Me.TabSetups.ResumeLayout(False)
        Me.TabResources.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents PictureMachineOverview As PictureBox
    Friend WithEvents LstMachineMethods As ListView
    Friend WithEvents LstMachines As ListView
    Friend WithEvents LstResources As ListView
    Friend WithEvents BtnEditMachineLinks As Button
    Friend WithEvents BtnEditMachiningMethodsLink As Button
    Friend WithEvents BtnEditResourcesLink As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabMachines As TabControl
    Friend WithEvents TabMach As TabPage
    Friend WithEvents TabOperations As TabPage
    Friend WithEvents TabSetups As TabPage
    Friend WithEvents TabResources As TabPage
    Friend WithEvents LstClampingMethods As ListView
    Friend WithEvents BtnEditClampingLinks As Button
End Class
