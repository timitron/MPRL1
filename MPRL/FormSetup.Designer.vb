<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSetup))
        Me.MprlDataSet1 = New MPRL.MPRLDataSet()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.AdditionalResourcesTableAdapter1 = New MPRL.MPRLDataSetTableAdapters.AdditionalResourcesTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEditResources = New System.Windows.Forms.Button()
        Me.LstResources = New System.Windows.Forms.ListView()
        Me.LblAdditionalResources = New System.Windows.Forms.Label()
        Me.PictureOverview = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Home = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'AdditionalResourcesTableAdapter1
        '
        Me.AdditionalResourcesTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.BtnEditResources)
        Me.GroupBox1.Controls.Add(Me.LstResources)
        Me.GroupBox1.Controls.Add(Me.LblAdditionalResources)
        Me.GroupBox1.Controls.Add(Me.PictureOverview)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.LblTitle)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1292, 741)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'BtnEditResources
        '
        Me.BtnEditResources.Location = New System.Drawing.Point(614, 493)
        Me.BtnEditResources.Name = "BtnEditResources"
        Me.BtnEditResources.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditResources.TabIndex = 30
        Me.BtnEditResources.Text = "Edit"
        Me.BtnEditResources.UseVisualStyleBackColor = True
        '
        'LstResources
        '
        Me.LstResources.BackColor = System.Drawing.SystemColors.Control
        Me.LstResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstResources.Location = New System.Drawing.Point(3, 493)
        Me.LstResources.Name = "LstResources"
        Me.LstResources.Size = New System.Drawing.Size(686, 188)
        Me.LstResources.TabIndex = 28
        Me.LstResources.UseCompatibleStateImageBehavior = False
        '
        'LblAdditionalResources
        '
        Me.LblAdditionalResources.AutoSize = True
        Me.LblAdditionalResources.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdditionalResources.Location = New System.Drawing.Point(3, 469)
        Me.LblAdditionalResources.Name = "LblAdditionalResources"
        Me.LblAdditionalResources.Size = New System.Drawing.Size(101, 24)
        Me.LblAdditionalResources.TabIndex = 29
        Me.LblAdditionalResources.Text = "Resources"
        '
        'PictureOverview
        '
        Me.PictureOverview.Location = New System.Drawing.Point(3, 69)
        Me.PictureOverview.Margin = New System.Windows.Forms.Padding(60)
        Me.PictureOverview.Name = "PictureOverview"
        Me.PictureOverview.Size = New System.Drawing.Size(686, 400)
        Me.PictureOverview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureOverview.TabIndex = 27
        Me.PictureOverview.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(1092, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 53)
        Me.Panel1.TabIndex = 29
        '
        'Home
        '
        Me.Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Home.Location = New System.Drawing.Point(12, 5)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(75, 45)
        Me.Home.TabIndex = 28
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(93, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 45)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(3, 16)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(257, 53)
        Me.LblTitle.TabIndex = 26
        Me.LblTitle.Text = "Setup Here"
        '
        'FormSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1292, 741)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 726)
        Me.Name = "FormSetup"
        Me.Text = "Machine Setup"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MprlDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureOverview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents MprlDataSet1 As MPRLDataSet
    Friend WithEvents AdditionalResourcesTableAdapter1 As MPRLDataSetTableAdapters.AdditionalResourcesTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureOverview As PictureBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents LstResources As ListView
    Friend WithEvents LblAdditionalResources As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Home As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEditResources As Button
End Class
