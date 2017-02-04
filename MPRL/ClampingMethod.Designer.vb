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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.BttnPrint.Location = New System.Drawing.Point(186, 2)
        Me.BttnPrint.Name = "BttnPrint"
        Me.BttnPrint.Size = New System.Drawing.Size(57, 46)
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BttnPrint)
        Me.Panel1.Location = New System.Drawing.Point(664, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 53)
        Me.Panel1.TabIndex = 27
        '
        'Home
        '
        Me.Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Home.Location = New System.Drawing.Point(12, 3)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(75, 45)
        Me.Home.TabIndex = 28
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormClampingMethod"
        Me.Text = "Clamping Method Form"
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Home As Button
    Friend WithEvents Button1 As Button
End Class
