<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOperation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOperation))
        Me.LstResources = New System.Windows.Forms.ListView()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PictureOverview = New System.Windows.Forms.PictureBox()
        Me.MprlDataSet1 = New MPRL.MPRLDataSet()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEditResources = New System.Windows.Forms.Button()
        Me.TbControlContent = New System.Windows.Forms.TabControl()
        Me.TabResources = New System.Windows.Forms.TabPage()
        Me.TabFeatures = New System.Windows.Forms.TabPage()
        Me.BtnEditFeatureLink = New System.Windows.Forms.Button()
        Me.LstViewFeatures = New System.Windows.Forms.ListView()
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TbControlContent.SuspendLayout()
        Me.TabResources.SuspendLayout()
        Me.TabFeatures.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstResources
        '
        Me.LstResources.BackColor = System.Drawing.SystemColors.Control
        Me.LstResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstResources.Location = New System.Drawing.Point(6, 6)
        Me.LstResources.Name = "LstResources"
        Me.LstResources.Size = New System.Drawing.Size(922, 248)
        Me.LstResources.TabIndex = 14
        Me.LstResources.UseCompatibleStateImageBehavior = False
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(21, 9)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(474, 53)
        Me.LblTitle.TabIndex = 10
        Me.LblTitle.Text = "Operation Name Here"
        '
        'PictureOverview
        '
        Me.PictureOverview.Location = New System.Drawing.Point(41, 69)
        Me.PictureOverview.Name = "PictureOverview"
        Me.PictureOverview.Size = New System.Drawing.Size(900, 376)
        Me.PictureOverview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureOverview.TabIndex = 13
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(757, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(184, 53)
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
        'BtnEditResources
        '
        Me.BtnEditResources.Location = New System.Drawing.Point(830, 6)
        Me.BtnEditResources.Name = "BtnEditResources"
        Me.BtnEditResources.Size = New System.Drawing.Size(97, 36)
        Me.BtnEditResources.TabIndex = 29
        Me.BtnEditResources.Text = "Edit"
        Me.BtnEditResources.UseVisualStyleBackColor = True
        '
        'TbControlContent
        '
        Me.TbControlContent.Controls.Add(Me.TabResources)
        Me.TbControlContent.Controls.Add(Me.TabFeatures)
        Me.TbControlContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbControlContent.Location = New System.Drawing.Point(30, 451)
        Me.TbControlContent.Name = "TbControlContent"
        Me.TbControlContent.SelectedIndex = 0
        Me.TbControlContent.Size = New System.Drawing.Size(942, 298)
        Me.TbControlContent.TabIndex = 30
        '
        'TabResources
        '
        Me.TabResources.Controls.Add(Me.BtnEditResources)
        Me.TabResources.Controls.Add(Me.LstResources)
        Me.TabResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabResources.Location = New System.Drawing.Point(4, 34)
        Me.TabResources.Name = "TabResources"
        Me.TabResources.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResources.Size = New System.Drawing.Size(934, 260)
        Me.TabResources.TabIndex = 0
        Me.TabResources.Text = "Resources"
        Me.TabResources.UseVisualStyleBackColor = True
        '
        'TabFeatures
        '
        Me.TabFeatures.Controls.Add(Me.BtnEditFeatureLink)
        Me.TabFeatures.Controls.Add(Me.LstViewFeatures)
        Me.TabFeatures.Location = New System.Drawing.Point(4, 34)
        Me.TabFeatures.Name = "TabFeatures"
        Me.TabFeatures.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFeatures.Size = New System.Drawing.Size(934, 260)
        Me.TabFeatures.TabIndex = 1
        Me.TabFeatures.Text = "Features"
        Me.TabFeatures.UseVisualStyleBackColor = True
        '
        'BtnEditFeatureLink
        '
        Me.BtnEditFeatureLink.Location = New System.Drawing.Point(830, 6)
        Me.BtnEditFeatureLink.Name = "BtnEditFeatureLink"
        Me.BtnEditFeatureLink.Size = New System.Drawing.Size(97, 36)
        Me.BtnEditFeatureLink.TabIndex = 30
        Me.BtnEditFeatureLink.Text = "Edit"
        Me.BtnEditFeatureLink.UseVisualStyleBackColor = True
        '
        'LstViewFeatures
        '
        Me.LstViewFeatures.Location = New System.Drawing.Point(6, 6)
        Me.LstViewFeatures.Name = "LstViewFeatures"
        Me.LstViewFeatures.Size = New System.Drawing.Size(921, 248)
        Me.LstViewFeatures.TabIndex = 0
        Me.LstViewFeatures.UseCompatibleStateImageBehavior = False
        '
        'FormOperation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(994, 761)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PictureOverview)
        Me.Controls.Add(Me.TbControlContent)
        Me.Name = "FormOperation"
        Me.Text = "Operation"
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TbControlContent.ResumeLayout(False)
        Me.TabResources.ResumeLayout(False)
        Me.TabFeatures.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstResources As ListView
    Friend WithEvents LblTitle As Label
    Friend WithEvents PictureOverview As PictureBox
    Friend WithEvents MprlDataSet1 As MPRLDataSet
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnEditResources As Button
    Friend WithEvents TbControlContent As TabControl
    Friend WithEvents TabResources As TabPage
    Friend WithEvents TabFeatures As TabPage
    Friend WithEvents LstViewFeatures As ListView
    Friend WithEvents BtnEditFeatureLink As Button
End Class
