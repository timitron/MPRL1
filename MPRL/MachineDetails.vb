Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class FormMachineDetails
    'Get what to open from the global click variable
    Dim Machine As String = Global.MPRL.GlobalVariables.Click

    Dim ds As New DataSet                       'defines dataset for data table
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)

    Dim printfile As New System.IO.StreamWriter(Application.StartupPath & "\printfile.html", False)
    Dim htmlprint As String = ""
    Dim url As String = ""
    Private Sub FormMachineDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTitle.Text = Machine

        CustFunctions.SetImage(cnn, "Machine", Machine, PictureOverview, ds, htmlprint)

        CustFunctions.Resources(cnn, "Machine", Machine, LstResources, ds)

        '       fill_req_ppe()

        '       fill_opt_ppe()

        Dim startpoint = New Point(40, 900)
        CustFunctions.Instructions(cnn, "Machine", Machine, startpoint, 100, ds, htmlprint, Me)

        printfile.Write(htmlprint)
        printfile.Close()


    End Sub


    Sub fill_req_ppe()
        'define connection string and create connection object 
        Dim Table_ As String = "ReqPPE"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT PPE.Name, PPE.ImageURL FROM ((PPE INNER JOIN [MachineTool-PPELink] ON PPE.Name = [MachineTool-PPELink].PPEID) INNER JOIN MachineTools ON [MachineTool-PPELink].MachineToolID = MachineTools.Name) WHERE (MachineTools.Name = '" & Machine & "') AND ([MachineTool-PPELink].Required = true)"    'data connection querry this must be run through the oledb command interpreter before executing it on the connection

        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format


        'the image list for the icons to display in the list view and then sets the size of the thumbnails to create when an image is added 
        Dim ImgList As New ImageList
        ImgList.ImageSize = New Size(Global.MPRL.GlobalVariables.IconSizeWidth, Global.MPRL.GlobalVariables.IconSizeHeight)
        LstReqPPE.View = View.LargeIcon ' defines the format of the listview

        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'this code creates a new web client object, connects to the image url, downloads the image from the source url and then saves it into the picture variable as a bitmap. 

            'Dim ImageInBytes() As Byte = tClient.DownloadData(Application.StartupPath & ds.Tables(Table_).Rows(count)("ImageURL"))
            ' Dim ImageStream As New IO.MemoryStream(ImageInBytes)
            ' Dim picture As Bitmap = New System.Drawing.Bitmap(ImageStream)

            Dim picture As Image = Image.FromFile(Application.StartupPath & ds.Tables(Table_).Rows(count)("ImageURL"))

            'This adds the picture to the image list ImgList which is used as the icon list for the list view
            ImgList.Images.Add(picture)
            'applies an image index number to the nextlistitem object (this object uses image 'count' in the list as an icon) 
            NextListItem.ImageIndex = count

            'add the new item to the list view
            LstReqPPE.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next

        'properties for the listview and finally an update command for the list view. 
        LstReqPPE.LargeImageList = ImgList
        LstReqPPE.Update()

    End Sub

    Sub fill_opt_ppe()
        'define connection string and create connection object 
        Dim Table_ As String = "OPTPPE"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT PPE.Name, PPE.ImageURL FROM ((PPE INNER JOIN [MachineTool-PPELink] ON PPE.Name = [MachineTool-PPELink].PPEID) INNER JOIN MachineTools ON [MachineTool-PPELink].MachineToolID = MachineTools.Name) WHERE (MachineTools.Name = '" & Machine & "') AND ([MachineTool-PPELink].Required = false)"    'data connection querry this must be run through the oledb command interpreter before executing it on the connection

        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format


        'the image list for the icons to display in the list view and then sets the size of the thumbnails to create when an image is added 
        Dim ImgList As New ImageList
        ImgList.ImageSize = New Size(Global.MPRL.GlobalVariables.IconSizeWidth, Global.MPRL.GlobalVariables.IconSizeHeight)
        LstOptPPE.View = View.LargeIcon ' defines the format of the listview

        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'this code creates a new web client object, connects to the image url, downloads the image from the source url and then saves it into the picture variable as a bitmap. 

            'Dim ImageInBytes() As Byte = tClient.DownloadData(ds.Tables(Table_).Rows(count)("ImageURL"))
            'Dim ImageStream As New IO.MemoryStream(ImageInBytes)
            'Dim picture As Bitmap = New System.Drawing.Bitmap(ImageStream)

            Dim picture As Image = Image.FromFile(Application.StartupPath & ds.Tables(Table_).Rows(count)("ImageURL"))

            'This adds the picture to the image list ImgList which is used as the icon list for the list view
            ImgList.Images.Add(picture)
            'applies an image index number to the nextlistitem object (this object uses image 'count' in the list as an icon) 
            NextListItem.ImageIndex = count

            'add the new item to the list view
            LstOptPPE.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next

        'properties for the listview and finally an update command for the list view. 
        LstOptPPE.LargeImageList = ImgList
        LstOptPPE.Update()

    End Sub

    Sub create_instructions()

        'define connection string and create connection object 
        Dim Table_ As String = "Instructions"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT        Instructions.[Text], Instructions.Tool, Instructions.hazard FROM((Instructions INNER JOIN                         [Instruction-EntityLink] ON Instructions.ID = [Instruction-EntityLink].InstructionID) INNER JOIN                         Machines On [Instruction-EntityLink].EntityID = Machines.Name) WHERE(Machines.Name = '" & Machine & "') AND ([Instruction-EntityLink].EntityType = 'Machine') ORDER BY [Instruction-EntityLink].Sequence"
        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        Dim count As Integer = 1        'counter for indexing instructions

        'html header
        htmlprint &= "<table style=""width:100%""border=""1"">  <col width=""5%""><col width=""70%""><col width=""15%""><col width=""10%""><tr><th>Step</th><th>Instruction</th><th>Tool</th><th>Feed/Speeds</th></tr>"


        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows

            Dim height As Integer = 100
            Dim groupbox As New GroupBox

            With groupbox
                .Location = New Point(40, 900 + height * (count - 1))
                .Name = "GrpBox#" & count
                .Text = "Step " & count
                .Width = 900
                height = 90
            End With


            Me.Controls.Add(groupbox)

            htmlprint &= "<tr>"
            htmlprint &= "<td>" & count & "</td>"
            Dim TxtInstruction As New TextBox
            With TxtInstruction
                .Location = New Point(10, 20)
                .Text = row(0).ToString
                .Height = 60
                .Width = 615
                .Multiline = True
            End With
            htmlprint &= "<td>" & row(0).ToString & "</td>"
            Dim TxtTool As New TextBox
            With TxtTool
                .Location = New Point(630, 20)
                .Text = row(0).ToString
                .Height = 60
                .Width = 165
                .Text = row(1).ToString
                .Multiline = True
            End With
            htmlprint &= "<td>" & row(1).ToString & "</td>"
            Dim TxtRPM As New TextBox
            With TxtRPM
                .Location = New Point(800, 20)
                .Text = row(0).ToString
                .Height = 60
                .Width = 90
                .Text = row(2).ToString
                .Multiline = True
            End With
            htmlprint &= "<td>" & row(2).ToString & "</td></tr>"

            groupbox.Controls.Add(TxtInstruction)
            groupbox.Controls.Add(TxtTool)
            groupbox.Controls.Add(TxtRPM)
            'increase count to incriment index 
            count = count + 1

        Next

        htmlprint &= "</table>"
    End Sub

    Sub set_image()
        Dim Table_ As String = "ImageURL"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT * from Machines Where Name = '" & Machine & "';"    'data connection querry this must be run through the oledb command interpreter before executing it on the connection

        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        'Dim tClient As New System.Net.WebClient
        'Dim ImageInBytes() As Byte = tClient.DownloadData(ds.Tables(Table_).Rows(0)("ImageURL"))
        'Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        'Dim picture As Bitmap = New System.Drawing.Bitmap(ImageStream)

        Dim picture As Image = Image.FromFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL"))
        PictureOverview.Image = picture

        'Add info to print file" 

        htmlprint &= "<H1>" & Machine & "</H1><br>"
        url = ds.Tables(Table_).Rows(0)("ImageURL").replace("\", "/")
        htmlprint &= "<img src =""." & url & " ""><br>"
    End Sub

    Sub fill_resources()
        'define connection string and create connection object 
        Dim Table_ As String = "Resources"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT        AdditionalResources.Name, AdditionalResources.Type, AdditionalResources.Hyperlink FROM            ((AdditionalResources INNER JOIN                         [Entity-ResourceLink] ON AdditionalResources.ID = [Entity-ResourceLink].ResourceID) INNER JOIN                         Machines ON [Entity-ResourceLink].EntitiesID = Machines.Name) WHERE        ([Entity-ResourceLink].Entities = 'Machine') AND (Machines.Name = '" & Machine & "')"

        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        LstResources.View = View.List ' defines the format of the listview

        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'need to write code to make or apply pre made thumbnails to resources

            'add the new item to the list view
            LstResources.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next
        LstResources.Update()
    End Sub

    Private Sub BttnPrint_Click(sender As Object, e As EventArgs) Handles BttnPrint.Click

        Dim webAddress As String = Application.StartupPath & "\printfile.html"
        Process.Start(webAddress)

    End Sub

    Private Sub BtnEditOptionalPPE_Click(sender As Object, e As EventArgs) Handles BtnEditOptionalPPE.Click

    End Sub

    Private Sub BtnEditReqPPE_Click(sender As Object, e As EventArgs) Handles BtnEditReqPPE.Click

    End Sub

    Private Sub EBtnEditAdditionalResources_Click(sender As Object, e As EventArgs) Handles EBtnEditAdditionalResources.Click

    End Sub
End Class