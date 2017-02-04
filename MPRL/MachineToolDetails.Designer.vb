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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblRequiredPPE = New System.Windows.Forms.Label()
        Me.LblOptionalPPE = New System.Windows.Forms.Label()
        Me.LblMachiningMethods = New System.Windows.Forms.Label()
        Me.LblMachines = New System.Windows.Forms.Label()
        Me.LblClamping = New System.Windows.Forms.Label()
        Me.PictureMachineOverview = New System.Windows.Forms.PictureBox()
        Me.LstReqPPE = New System.Windows.Forms.ListView()
        Me.LstOptPPE = New System.Windows.Forms.ListView()
        Me.LstMachineMethods = New System.Windows.Forms.ListView()
        Me.LstMachines = New System.Windows.Forms.ListView()
        Me.LstClampingMethods = New System.Windows.Forms.ListView()
        Me.LstResources = New System.Windows.Forms.ListView()
        Me.LblResources = New System.Windows.Forms.Label()
        Me.BtnEditReqPPE = New System.Windows.Forms.Button()
        Me.BtnEditOptPPE = New System.Windows.Forms.Button()
        Me.BtnEditMachineLinks = New System.Windows.Forms.Button()
        Me.BtnEditMachiningMethodsLink = New System.Windows.Forms.Button()
        Me.BtnEditClampingLinks = New System.Windows.Forms.Button()
        Me.BtnEditResourcesLink = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BttnPrint = New System.Windows.Forms.Button()
        CType(Me.PictureMachineOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        'LblRequiredPPE
        '
        Me.LblRequiredPPE.AutoSize = True
        Me.LblRequiredPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRequiredPPE.Location = New System.Drawing.Point(51, 473)
        Me.LblRequiredPPE.Name = "LblRequiredPPE"
        Me.LblRequiredPPE.Size = New System.Drawing.Size(130, 24)
        Me.LblRequiredPPE.TabIndex = 2
        Me.LblRequiredPPE.Text = "Required PPE"
        '
        'LblOptionalPPE
        '
        Me.LblOptionalPPE.AutoSize = True
        Me.LblOptionalPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOptionalPPE.Location = New System.Drawing.Point(513, 473)
        Me.LblOptionalPPE.Name = "LblOptionalPPE"
        Me.LblOptionalPPE.Size = New System.Drawing.Size(122, 24)
        Me.LblOptionalPPE.TabIndex = 3
        Me.LblOptionalPPE.Text = "Optional PPE"
        '
        'LblMachiningMethods
        '
        Me.LblMachiningMethods.AutoSize = True
        Me.LblMachiningMethods.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMachiningMethods.Location = New System.Drawing.Point(51, 638)
        Me.LblMachiningMethods.Name = "LblMachiningMethods"
        Me.LblMachiningMethods.Size = New System.Drawing.Size(176, 24)
        Me.LblMachiningMethods.TabIndex = 4
        Me.LblMachiningMethods.Text = "Machining Methods"
        Me.LblMachiningMethods.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblMachines
        '
        Me.LblMachines.AutoSize = True
        Me.LblMachines.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMachines.Location = New System.Drawing.Point(512, 638)
        Me.LblMachines.Name = "LblMachines"
        Me.LblMachines.Size = New System.Drawing.Size(92, 24)
        Me.LblMachines.TabIndex = 5
        Me.LblMachines.Text = "Machines"
        '
        'LblClamping
        '
        Me.LblClamping.AutoSize = True
        Me.LblClamping.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClamping.Location = New System.Drawing.Point(512, 803)
        Me.LblClamping.Name = "LblClamping"
        Me.LblClamping.Size = New System.Drawing.Size(168, 24)
        Me.LblClamping.TabIndex = 6
        Me.LblClamping.Text = "Clamping Methods"
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
        'LstReqPPE
        '
        Me.LstReqPPE.BackColor = System.Drawing.SystemColors.Control
        Me.LstReqPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstReqPPE.Location = New System.Drawing.Point(45, 500)
        Me.LstReqPPE.Name = "LstReqPPE"
        Me.LstReqPPE.Size = New System.Drawing.Size(437, 135)
        Me.LstReqPPE.TabIndex = 8
        Me.LstReqPPE.UseCompatibleStateImageBehavior = False
        '
        'LstOptPPE
        '
        Me.LstOptPPE.BackColor = System.Drawing.SystemColors.Control
        Me.LstOptPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOptPPE.Location = New System.Drawing.Point(508, 500)
        Me.LstOptPPE.Name = "LstOptPPE"
        Me.LstOptPPE.Size = New System.Drawing.Size(437, 135)
        Me.LstOptPPE.TabIndex = 9
        Me.LstOptPPE.UseCompatibleStateImageBehavior = False
        '
        'LstMachineMethods
        '
        Me.LstMachineMethods.BackColor = System.Drawing.SystemColors.Control
        Me.LstMachineMethods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMachineMethods.Location = New System.Drawing.Point(44, 665)
        Me.LstMachineMethods.Name = "LstMachineMethods"
        Me.LstMachineMethods.Size = New System.Drawing.Size(437, 300)
        Me.LstMachineMethods.TabIndex = 10
        Me.LstMachineMethods.TileSize = New System.Drawing.Size(100, 100)
        Me.LstMachineMethods.UseCompatibleStateImageBehavior = False
        '
        'LstMachines
        '
        Me.LstMachines.BackColor = System.Drawing.SystemColors.Control
        Me.LstMachines.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMachines.Location = New System.Drawing.Point(507, 665)
        Me.LstMachines.Name = "LstMachines"
        Me.LstMachines.Size = New System.Drawing.Size(437, 135)
        Me.LstMachines.TabIndex = 11
        Me.LstMachines.UseCompatibleStateImageBehavior = False
        '
        'LstClampingMethods
        '
        Me.LstClampingMethods.BackColor = System.Drawing.SystemColors.Control
        Me.LstClampingMethods.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstClampingMethods.Location = New System.Drawing.Point(507, 830)
        Me.LstClampingMethods.Name = "LstClampingMethods"
        Me.LstClampingMethods.Size = New System.Drawing.Size(437, 135)
        Me.LstClampingMethods.TabIndex = 12
        Me.LstClampingMethods.UseCompatibleStateImageBehavior = False
        '
        'LstResources
        '
        Me.LstResources.BackColor = System.Drawing.SystemColors.Control
        Me.LstResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstResources.Location = New System.Drawing.Point(44, 995)
        Me.LstResources.Margin = New System.Windows.Forms.Padding(3, 3, 3, 200)
        Me.LstResources.MinimumSize = New System.Drawing.Size(900, 100)
        Me.LstResources.MultiSelect = False
        Me.LstResources.Name = "LstResources"
        Me.LstResources.Size = New System.Drawing.Size(900, 135)
        Me.LstResources.TabIndex = 14
        Me.LstResources.UseCompatibleStateImageBehavior = False
        '
        'LblResources
        '
        Me.LblResources.AutoSize = True
        Me.LblResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResources.Location = New System.Drawing.Point(51, 968)
        Me.LblResources.Name = "LblResources"
        Me.LblResources.Size = New System.Drawing.Size(189, 24)
        Me.LblResources.TabIndex = 13
        Me.LblResources.Text = "Additional Resources"
        '
        'BtnEditReqPPE
        '
        Me.BtnEditReqPPE.Location = New System.Drawing.Point(406, 476)
        Me.BtnEditReqPPE.Name = "BtnEditReqPPE"
        Me.BtnEditReqPPE.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditReqPPE.TabIndex = 15
        Me.BtnEditReqPPE.Text = "Edit"
        Me.BtnEditReqPPE.UseVisualStyleBackColor = True
        '
        'BtnEditOptPPE
        '
        Me.BtnEditOptPPE.Location = New System.Drawing.Point(870, 476)
        Me.BtnEditOptPPE.Name = "BtnEditOptPPE"
        Me.BtnEditOptPPE.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditOptPPE.TabIndex = 16
        Me.BtnEditOptPPE.Text = "Edit"
        Me.BtnEditOptPPE.UseVisualStyleBackColor = True
        '
        'BtnEditMachineLinks
        '
        Me.BtnEditMachineLinks.Location = New System.Drawing.Point(869, 641)
        Me.BtnEditMachineLinks.Name = "BtnEditMachineLinks"
        Me.BtnEditMachineLinks.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditMachineLinks.TabIndex = 17
        Me.BtnEditMachineLinks.Text = "Edit"
        Me.BtnEditMachineLinks.UseVisualStyleBackColor = True
        '
        'BtnEditMachiningMethodsLink
        '
        Me.BtnEditMachiningMethodsLink.Location = New System.Drawing.Point(407, 641)
        Me.BtnEditMachiningMethodsLink.Name = "BtnEditMachiningMethodsLink"
        Me.BtnEditMachiningMethodsLink.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditMachiningMethodsLink.TabIndex = 18
        Me.BtnEditMachiningMethodsLink.Text = "Edit"
        Me.BtnEditMachiningMethodsLink.UseVisualStyleBackColor = True
        '
        'BtnEditClampingLinks
        '
        Me.BtnEditClampingLinks.Location = New System.Drawing.Point(869, 806)
        Me.BtnEditClampingLinks.Name = "BtnEditClampingLinks"
        Me.BtnEditClampingLinks.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditClampingLinks.TabIndex = 19
        Me.BtnEditClampingLinks.Text = "Edit"
        Me.BtnEditClampingLinks.UseVisualStyleBackColor = True
        '
        'BtnEditResourcesLink
        '
        Me.BtnEditResourcesLink.Location = New System.Drawing.Point(869, 971)
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
        Me.Panel1.Controls.Add(Me.BttnPrint)
        Me.Panel1.Location = New System.Drawing.Point(587, 11)
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
        'FormMachineToolDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1011, 741)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnEditResourcesLink)
        Me.Controls.Add(Me.BtnEditClampingLinks)
        Me.Controls.Add(Me.BtnEditMachiningMethodsLink)
        Me.Controls.Add(Me.BtnEditMachineLinks)
        Me.Controls.Add(Me.BtnEditOptPPE)
        Me.Controls.Add(Me.BtnEditReqPPE)
        Me.Controls.Add(Me.LstResources)
        Me.Controls.Add(Me.LblResources)
        Me.Controls.Add(Me.LstClampingMethods)
        Me.Controls.Add(Me.LstMachines)
        Me.Controls.Add(Me.LstOptPPE)
        Me.Controls.Add(Me.LstReqPPE)
        Me.Controls.Add(Me.LblClamping)
        Me.Controls.Add(Me.LblMachines)
        Me.Controls.Add(Me.LblMachiningMethods)
        Me.Controls.Add(Me.LblOptionalPPE)
        Me.Controls.Add(Me.LblRequiredPPE)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PictureMachineOverview)
        Me.Controls.Add(Me.LstMachineMethods)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "FormMachineToolDetails"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 200)
        Me.Text = "Machine Tool Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureMachineOverview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblRequiredPPE As Label
    Friend WithEvents LblOptionalPPE As Label
    Friend WithEvents LblMachiningMethods As Label
    Friend WithEvents LblMachines As Label
    Friend WithEvents LblClamping As Label
    Friend WithEvents PictureMachineOverview As PictureBox
    Friend WithEvents LstReqPPE As ListView
    Friend WithEvents LstOptPPE As ListView
    Friend WithEvents LstMachineMethods As ListView
    Friend WithEvents LstMachines As ListView
    Friend WithEvents LstClampingMethods As ListView
    Friend WithEvents LstResources As ListView
    Friend WithEvents LblResources As Label
    Friend WithEvents BtnEditReqPPE As Button
    Friend WithEvents BtnEditOptPPE As Button
    Friend WithEvents BtnEditMachineLinks As Button
    Friend WithEvents BtnEditMachiningMethodsLink As Button
    Friend WithEvents BtnEditClampingLinks As Button
    Friend WithEvents BtnEditResourcesLink As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BttnPrint As Button
End Class
