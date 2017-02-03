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
        Me.LblAdditionalResources = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PictureOverview = New System.Windows.Forms.PictureBox()
        Me.MprlDataSet1 = New MPRL.MPRLDataSet()
        Me.BttnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.LstOptPPE = New System.Windows.Forms.ListView()
        Me.LstReqPPE = New System.Windows.Forms.ListView()
        Me.LblOptionalPPE = New System.Windows.Forms.Label()
        Me.LblRequiredPPE = New System.Windows.Forms.Label()
        Me.BtnEditReqPPE = New System.Windows.Forms.Button()
        Me.BtnEditOptionalPPE = New System.Windows.Forms.Button()
        Me.EBtnEditAdditionalResources = New System.Windows.Forms.Button()
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstResources
        '
        Me.LstResources.BackColor = System.Drawing.SystemColors.Control
        Me.LstResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstResources.Location = New System.Drawing.Point(32, 695)
        Me.LstResources.Name = "LstResources"
        Me.LstResources.Size = New System.Drawing.Size(900, 100)
        Me.LstResources.TabIndex = 25
        Me.LstResources.UseCompatibleStateImageBehavior = False
        '
        'LblAdditionalResources
        '
        Me.LblAdditionalResources.AutoSize = True
        Me.LblAdditionalResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdditionalResources.Location = New System.Drawing.Point(38, 668)
        Me.LblAdditionalResources.Name = "LblAdditionalResources"
        Me.LblAdditionalResources.Size = New System.Drawing.Size(184, 24)
        Me.LblAdditionalResources.TabIndex = 23
        Me.LblAdditionalResources.Text = "AdditionalResources"
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
        Me.PictureOverview.Location = New System.Drawing.Point(32, 69)
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
        'BttnPrint
        '
        Me.BttnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnPrint.Location = New System.Drawing.Point(874, 13)
        Me.BttnPrint.Name = "BttnPrint"
        Me.BttnPrint.Size = New System.Drawing.Size(57, 49)
        Me.BttnPrint.TabIndex = 26
        Me.BttnPrint.Text = "Print"
        Me.BttnPrint.UseVisualStyleBackColor = True
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
        Me.LstOptPPE.Location = New System.Drawing.Point(495, 514)
        Me.LstOptPPE.Name = "LstOptPPE"
        Me.LstOptPPE.Size = New System.Drawing.Size(437, 135)
        Me.LstOptPPE.TabIndex = 30
        Me.LstOptPPE.UseCompatibleStateImageBehavior = False
        '
        'LstReqPPE
        '
        Me.LstReqPPE.BackColor = System.Drawing.SystemColors.Control
        Me.LstReqPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstReqPPE.Location = New System.Drawing.Point(32, 514)
        Me.LstReqPPE.Name = "LstReqPPE"
        Me.LstReqPPE.Size = New System.Drawing.Size(437, 135)
        Me.LstReqPPE.TabIndex = 29
        Me.LstReqPPE.UseCompatibleStateImageBehavior = False
        '
        'LblOptionalPPE
        '
        Me.LblOptionalPPE.AutoSize = True
        Me.LblOptionalPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOptionalPPE.Location = New System.Drawing.Point(500, 487)
        Me.LblOptionalPPE.Name = "LblOptionalPPE"
        Me.LblOptionalPPE.Size = New System.Drawing.Size(122, 24)
        Me.LblOptionalPPE.TabIndex = 28
        Me.LblOptionalPPE.Text = "Optional PPE"
        '
        'LblRequiredPPE
        '
        Me.LblRequiredPPE.AutoSize = True
        Me.LblRequiredPPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRequiredPPE.Location = New System.Drawing.Point(38, 487)
        Me.LblRequiredPPE.Name = "LblRequiredPPE"
        Me.LblRequiredPPE.Size = New System.Drawing.Size(130, 24)
        Me.LblRequiredPPE.TabIndex = 27
        Me.LblRequiredPPE.Text = "Required PPE"
        '
        'BtnEditReqPPE
        '
        Me.BtnEditReqPPE.Location = New System.Drawing.Point(394, 490)
        Me.BtnEditReqPPE.Name = "BtnEditReqPPE"
        Me.BtnEditReqPPE.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditReqPPE.TabIndex = 31
        Me.BtnEditReqPPE.Text = "Edit"
        Me.BtnEditReqPPE.UseVisualStyleBackColor = True
        '
        'BtnEditOptionalPPE
        '
        Me.BtnEditOptionalPPE.Location = New System.Drawing.Point(856, 490)
        Me.BtnEditOptionalPPE.Name = "BtnEditOptionalPPE"
        Me.BtnEditOptionalPPE.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditOptionalPPE.TabIndex = 32
        Me.BtnEditOptionalPPE.Text = "Edit"
        Me.BtnEditOptionalPPE.UseVisualStyleBackColor = True
        '
        'EBtnEditAdditionalResources
        '
        Me.EBtnEditAdditionalResources.Location = New System.Drawing.Point(857, 671)
        Me.EBtnEditAdditionalResources.Name = "EBtnEditAdditionalResources"
        Me.EBtnEditAdditionalResources.Size = New System.Drawing.Size(75, 23)
        Me.EBtnEditAdditionalResources.TabIndex = 33
        Me.EBtnEditAdditionalResources.Text = "Edit"
        Me.EBtnEditAdditionalResources.UseVisualStyleBackColor = True
        '
        'FormMachineDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(984, 1108)
        Me.Controls.Add(Me.EBtnEditAdditionalResources)
        Me.Controls.Add(Me.BtnEditOptionalPPE)
        Me.Controls.Add(Me.BtnEditReqPPE)
        Me.Controls.Add(Me.LstOptPPE)
        Me.Controls.Add(Me.LblOptionalPPE)
        Me.Controls.Add(Me.LblRequiredPPE)
        Me.Controls.Add(Me.LstResources)
        Me.Controls.Add(Me.LblAdditionalResources)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PictureOverview)
        Me.Controls.Add(Me.BttnPrint)
        Me.Controls.Add(Me.LstReqPPE)
        Me.Name = "FormMachineDetails"
        Me.Text = "Machine Details "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstResources As ListView
    Friend WithEvents LblAdditionalResources As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents PictureOverview As PictureBox
    Friend WithEvents MprlDataSet1 As MPRLDataSet
    Friend WithEvents BttnPrint As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents LstOptPPE As ListView
    Friend WithEvents LblOptionalPPE As Label
    Friend WithEvents LblRequiredPPE As Label
    Friend WithEvents LstReqPPE As ListView
    Friend WithEvents EBtnEditAdditionalResources As Button
    Friend WithEvents BtnEditOptionalPPE As Button
    Friend WithEvents BtnEditReqPPE As Button
End Class
