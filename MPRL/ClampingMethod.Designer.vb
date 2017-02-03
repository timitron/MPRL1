<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClampingMethod
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClampingMethod))
        Me.LstResources = New System.Windows.Forms.ListView()
        Me.LblAdditionalResources = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PictureOverview = New System.Windows.Forms.PictureBox()
        Me.MprlDataSet1 = New MPRL.MPRLDataSet()
        Me.BttnPrint = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstResources
        '
        Me.LstResources.BackColor = System.Drawing.SystemColors.Control
        Me.LstResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstResources.Location = New System.Drawing.Point(20, 517)
        Me.LstResources.Name = "LstResources"
        Me.LstResources.Size = New System.Drawing.Size(900, 100)
        Me.LstResources.TabIndex = 25
        Me.LstResources.UseCompatibleStateImageBehavior = False
        '
        'LblAdditionalResources
        '
        Me.LblAdditionalResources.AutoSize = True
        Me.LblAdditionalResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdditionalResources.Location = New System.Drawing.Point(26, 490)
        Me.LblAdditionalResources.Name = "LblAdditionalResources"
        Me.LblAdditionalResources.Size = New System.Drawing.Size(184, 24)
        Me.LblAdditionalResources.TabIndex = 23
        Me.LblAdditionalResources.Text = "AdditionalResources"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(0, 27)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(497, 53)
        Me.LblTitle.TabIndex = 22
        Me.LblTitle.Text = "Clamping Method Here"
        '
        'PictureOverview
        '
        Me.PictureOverview.Location = New System.Drawing.Point(20, 87)
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
        Me.BttnPrint.Location = New System.Drawing.Point(862, 31)
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
        'FormClampingMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(984, 705)
        Me.Controls.Add(Me.LstResources)
        Me.Controls.Add(Me.LblAdditionalResources)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PictureOverview)
        Me.Controls.Add(Me.BttnPrint)
        Me.Name = "FormClampingMethod"
        Me.Text = "Clamping Method Form"
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents BttnPrint As Button
    Friend WithEvents MprlDataSet1 As MPRLDataSet
    Friend WithEvents PictureOverview As PictureBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblAdditionalResources As Label
    Friend WithEvents LstResources As ListView
End Class
