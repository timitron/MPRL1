<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMachineDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMachineDetails))
        Me.LstResources = New System.Windows.Forms.ListView()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PictureOverview = New System.Windows.Forms.PictureBox()
        Me.MprlDataSet1 = New MPRL.MPRLDataSet()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.LstOptPPE = New System.Windows.Forms.ListView()
        Me.LstReqPPE = New System.Windows.Forms.ListView()
        Me.LblOptionalPPE = New System.Windows.Forms.Label()
        Me.LblRequiredPPE = New System.Windows.Forms.Label()
        Me.BtnEditReqPPE = New System.Windows.Forms.Button()
        Me.BtnEditOptionalPPE = New System.Windows.Forms.Button()
        Me.EBtnEditAdditionalResources = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabInfo = New System.Windows.Forms.TabControl()
        Me.TabPPE = New System.Windows.Forms.TabPage()
        Me.TabResources = New System.Windows.Forms.TabPage()
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabInfo.SuspendLayout()
        Me.TabPPE.SuspendLayout()
        Me.TabResources.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstResources
        '
        Me.LstResources.BackColor = System.Drawing.SystemColors.Control
        Me.LstResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstResources.Location = New System.Drawing.Point(6, 6)
        Me.LstResources.Name = "LstResources"
        Me.LstResources.Size = New System.Drawing.Size(888, 276)
        Me.LstResources.TabIndex = 25
        Me.LstResources.UseCompatibleStateImageBehavior = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(12, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(445, 53)
        Me.LblTitle.TabIndex = 22
        Me.LblTitle.Text = "Machine Name Here"
        '
        'PictureOverview
        '
        Me.PictureOverview.Location = New System.Drawing.Point(21, 65)
        Me.PictureOverview.Name = "PictureOverview"
        Me.PictureOverview.Size = New System.Drawing.Size(900, 400)
        Me.PictureOverview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureOverview.TabIndex = 24
        Me.PictureOverview.TabStop = False
        '
        'MprlDataSet1
        '
        Me.MprlDataSet1.DataSetName = "MPRLDataSet"
        Me.MprlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'LstOptPPE
        '
        Me.LstOptPPE.BackColor = System.Drawing.SystemColors.Control
        Me.LstOptPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstOptPPE.Location = New System.Drawing.Point(463, 33)
        Me.LstOptPPE.Name = "LstOptPPE"
        Me.LstOptPPE.Size = New System.Drawing.Size(431, 249)
        Me.LstOptPPE.TabIndex = 30
        Me.LstOptPPE.UseCompatibleStateImageBehavior = False
        '
        'LstReqPPE
        '
        Me.LstReqPPE.BackColor = System.Drawing.SystemColors.Control
        Me.LstReqPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstReqPPE.Location = New System.Drawing.Point(6, 30)
        Me.LstReqPPE.Name = "LstReqPPE"
        Me.LstReqPPE.Size = New System.Drawing.Size(437, 252)
        Me.LstReqPPE.TabIndex = 29
        Me.LstReqPPE.UseCompatibleStateImageBehavior = False
        '
        'LblOptionalPPE
        '
        Me.LblOptionalPPE.AutoSize = True
        Me.LblOptionalPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOptionalPPE.Location = New System.Drawing.Point(468, 6)
        Me.LblOptionalPPE.Name = "LblOptionalPPE"
        Me.LblOptionalPPE.Size = New System.Drawing.Size(122, 24)
        Me.LblOptionalPPE.TabIndex = 28
        Me.LblOptionalPPE.Text = "Optional PPE"
        '
        'LblRequiredPPE
        '
        Me.LblRequiredPPE.AutoSize = True
        Me.LblRequiredPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRequiredPPE.Location = New System.Drawing.Point(6, 3)
        Me.LblRequiredPPE.Name = "LblRequiredPPE"
        Me.LblRequiredPPE.Size = New System.Drawing.Size(130, 24)
        Me.LblRequiredPPE.TabIndex = 27
        Me.LblRequiredPPE.Text = "Required PPE"
        '
        'BtnEditReqPPE
        '
        Me.BtnEditReqPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnEditReqPPE.Location = New System.Drawing.Point(368, 4)
        Me.BtnEditReqPPE.Name = "BtnEditReqPPE"
        Me.BtnEditReqPPE.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditReqPPE.TabIndex = 31
        Me.BtnEditReqPPE.Text = "Edit"
        Me.BtnEditReqPPE.UseVisualStyleBackColor = True
        '
        'BtnEditOptionalPPE
        '
        Me.BtnEditOptionalPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnEditOptionalPPE.Location = New System.Drawing.Point(819, 7)
        Me.BtnEditOptionalPPE.Name = "BtnEditOptionalPPE"
        Me.BtnEditOptionalPPE.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditOptionalPPE.TabIndex = 32
        Me.BtnEditOptionalPPE.Text = "Edit"
        Me.BtnEditOptionalPPE.UseVisualStyleBackColor = True
        '
        'EBtnEditAdditionalResources
        '
        Me.EBtnEditAdditionalResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.EBtnEditAdditionalResources.Location = New System.Drawing.Point(819, 6)
        Me.EBtnEditAdditionalResources.Name = "EBtnEditAdditionalResources"
        Me.EBtnEditAdditionalResources.Size = New System.Drawing.Size(75, 23)
        Me.EBtnEditAdditionalResources.TabIndex = 33
        Me.EBtnEditAdditionalResources.Text = "Edit"
        Me.EBtnEditAdditionalResources.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(707, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 53)
        Me.Panel1.TabIndex = 34
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
        'TabInfo
        '
        Me.TabInfo.Controls.Add(Me.TabPPE)
        Me.TabInfo.Controls.Add(Me.TabResources)
        Me.TabInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.TabInfo.Location = New System.Drawing.Point(23, 471)
        Me.TabInfo.Name = "TabInfo"
        Me.TabInfo.SelectedIndex = 0
        Me.TabInfo.Size = New System.Drawing.Size(908, 314)
        Me.TabInfo.TabIndex = 35
        '
        'TabPPE
        '
        Me.TabPPE.Controls.Add(Me.LblRequiredPPE)
        Me.TabPPE.Controls.Add(Me.LstReqPPE)
        Me.TabPPE.Controls.Add(Me.BtnEditReqPPE)
        Me.TabPPE.Controls.Add(Me.BtnEditOptionalPPE)
        Me.TabPPE.Controls.Add(Me.LblOptionalPPE)
        Me.TabPPE.Controls.Add(Me.LstOptPPE)
        Me.TabPPE.Location = New System.Drawing.Point(4, 38)
        Me.TabPPE.Name = "TabPPE"
        Me.TabPPE.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPPE.Size = New System.Drawing.Size(900, 272)
        Me.TabPPE.TabIndex = 0
        Me.TabPPE.Text = "PPE"
        Me.TabPPE.UseVisualStyleBackColor = True
        '
        'TabResources
        '
        Me.TabResources.Controls.Add(Me.EBtnEditAdditionalResources)
        Me.TabResources.Controls.Add(Me.LstResources)
        Me.TabResources.Location = New System.Drawing.Point(4, 38)
        Me.TabResources.Name = "TabResources"
        Me.TabResources.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResources.Size = New System.Drawing.Size(900, 272)
        Me.TabResources.TabIndex = 1
        Me.TabResources.Text = "Resources"
        Me.TabResources.UseVisualStyleBackColor = True
        '
        'FormMachineDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(966, 741)
        Me.Controls.Add(Me.TabInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PictureOverview)
        Me.Name = "FormMachineDetails"
        Me.Text = "Machine Details "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabInfo.ResumeLayout(False)
        Me.TabPPE.ResumeLayout(False)
        Me.TabPPE.PerformLayout()
        Me.TabResources.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstResources As ListView
    Friend WithEvents LblTitle As Label
    Friend WithEvents PictureOverview As PictureBox
    Friend WithEvents MprlDataSet1 As MPRLDataSet
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents LstOptPPE As ListView
    Friend WithEvents LblOptionalPPE As Label
    Friend WithEvents LblRequiredPPE As Label
    Friend WithEvents LstReqPPE As ListView
    Friend WithEvents EBtnEditAdditionalResources As Button
    Friend WithEvents BtnEditOptionalPPE As Button
    Friend WithEvents BtnEditReqPPE As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabInfo As TabControl
    Friend WithEvents TabPPE As TabPage
    Friend WithEvents TabResources As TabPage
End Class
