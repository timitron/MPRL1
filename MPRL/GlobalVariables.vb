Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class GlobalVariables
    Public Shared AdminBuild As Boolean = True 'Set to true and build the application for an admin .exe, set to false for a client exe. 
    Public Shared IconSizeWidth As Int16 = 90 '1-128 
    Public Shared IconSizeHeight As Int16 = 90 '1-128
    Public Shared FormWidth As Int32 = 800 'width in pixels of forms, generally 900 - 1600. 
    Public Shared FormBuffer As Int16 = 50 'distance in pixels between form obejects and groupbox walls. generallt 10 - 200 

    Public Shared GetFeedBack As Boolean
    Public Shared version As String
    Public Shared webaddress As String

    Public Shared Click As String
    Public Shared Clicked As String
    Public Shared FeedbackEntity As String
    Public Shared FeedbackEntityType As String

    Public Shared prevMachineTool As String 'stores previously selected machine tool 

    Public Shared fromadd As Boolean
    Public Shared CloseAll As Boolean = True
    Public Shared MethodStart As String

    'define connection string and create connection object 
    Public Shared cnn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Images\MPRL.accdb;")

End Class

Public Class CustFunctions

    Shared Sub PPE(cnn As OleDb.OleDbConnection, targetID As String, returnListView As ListView, required As Boolean, ds As DataSet)
        'this fills the returnlistbox with the icon list PPE for the machinetool passed to it as the targetID, it will display required PPE if required is true and optional if required is false 
        'it will accomplish this by varying the SQL query which it executes

        Dim query As String
        Dim Table_ As String
        If required = True Then
            query = "SELECT PPE.Name, PPE.Description, PPE.ImageURL FROM ((PPE INNER JOIN [Machine-PPELink] ON PPE.Name = [Machine-PPELink].PPEID) INNER JOIN Machines ON [Machine-PPELink].MachineID = Machines.Name) WHERE ([Machine-PPELink].Required = True) AND (Machines.Name = '" & targetID & "')"
            Table_ = "ReqPPE"
        End If
        If required = False Then
            query = "SELECT PPE.Name, PPE.Description, PPE.ImageURL FROM ((PPE INNER JOIN [Machine-PPELink] ON PPE.Name = [Machine-PPELink].PPEID) INNER JOIN Machines ON [Machine-PPELink].MachineID = Machines.Name) WHERE ([Machine-PPELink].Required = False) AND (Machines.Name = '" & targetID & "')"
            Table_ = "OptPPE"
        End If

        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format


        'the image list for the icons to display in the list view and then sets the size of the thumbnails to create when an image is added 
        Dim ImgList As New ImageList
        ImgList.ImageSize = New Size(Global.MPRL.GlobalVariables.IconSizeWidth, Global.MPRL.GlobalVariables.IconSizeHeight)
        returnListView.View = View.LargeIcon ' defines the format of the listview

        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            Dim picture As Image = Image.FromFile(Application.StartupPath & ds.Tables(Table_).Rows(count)("ImageURL"))

            'This adds the picture to the image list ImgList which is used as the icon list for the list view
            ImgList.Images.Add(picture)
            'applies an image index number to the nextlistitem object (this object uses image 'count' in the list as an icon) 
            NextListItem.ImageIndex = count

            'add the new item to the list view
            returnListView.Items.Add(NextListItem)

            count = count + 1

        Next

        'properties for the listview and finally an update command for the list view. 
        returnListView.LargeImageList = ImgList
        returnListView.Update()

    End Sub
    Shared Sub Instructions(cnn As OleDbConnection, type As String, targetID As String, startPoint As Point, InstructionSpacing As Integer, ds As DataSet, ByRef htmlprint As String, Form As Form)
        'this sub will also modify the sql query to return the correct instructions for whatever specified entiry and target ID are sent and then return them to the ds datatable 
        Dim query As String

        If type = "ClampingMethod" Then
            query = "SELECT Instructions.[Text], Instructions.Tool, Instructions.FeedsAndSpeeds FROM((Instructions INNER JOIN [Instruction-EntityLink] ON Instructions.ID = [Instruction-EntityLink].InstructionID) INNER JOIN ClampingMethods On [Instruction-EntityLink].EntityID = ClampingMethods.Name) WHERE(ClampingMethods.Name = '" & targetID & "') AND ([Instruction-EntityLink].EntityType = 'Clamping Method') ORDER BY [Instruction-EntityLink].Sequence"
        End If
        If type = "Machine" Then
            query = "SELECT Instructions.[Text], Instructions.Tool, Instructions.FeedsAndSpeeds FROM((Instructions INNER JOIN [Instruction-EntityLink] ON Instructions.ID = [Instruction-EntityLink].InstructionID) INNER JOIN Machines On [Instruction-EntityLink].EntityID = Machines.Name) WHERE(Machines.Name = '" & targetID & "') AND ([Instruction-EntityLink].EntityType = 'Machine') ORDER BY [Instruction-EntityLink].Sequence"
        End If
        If type = "MachiningMethod" Then
            query = "SELECT Instructions.[Text], Instructions.Tool, Instructions.FeedsAndSpeeds FROM((Instructions INNER JOIN [Instruction-EntityLink] ON Instructions.ID = [Instruction-EntityLink].InstructionID) INNER JOIN MachiningMethods On [Instruction-EntityLink].EntityID = MachiningMethods.Name) WHERE(MachiningMethods.Name = '" & targetID & "') AND ([Instruction-EntityLink].EntityType = 'Operations') ORDER BY [Instruction-EntityLink].Sequence"
        End If

        'define connection string and create connection object 
        Dim Table_ As String = "Instructions"   'defines table inside the dataset to store information recieved from data connections
        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        Dim count As Integer = 1        'counter for indexing instructions

        'html header
        htmlprint &= "<table border=""1"" style=""width:100%;"">  <col width=""5%""><col width=""70%""><col width=""15%""><col width=""10%""><tr><th>Step</th><th>Instruction</th><th>Tool</th><th>Feed/Speeds</th></tr>"


        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows

            Dim height As Integer = 100
            Dim groupbox As New GroupBox

            With groupbox
                .Location = New Point(startPoint.X, startPoint.Y + height * (count - 1))
                .Name = "GrpBox#" & count
                .Text = "Step " & count
                .Width = 900
                .Height = 90
                .Enabled = False
            End With


            Form.Controls.Add(groupbox)

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

        htmlprint &= "</table></div>"






    End Sub
    Shared Sub Resources(cnn As OleDbConnection, type As String, targetID As String, returnListView As ListView, ds As DataSet)
        'This sub will take the connection, type, and target ID and add all results returned to the dataset and listview specified. 
        Dim query As String
        Dim Table_ As String = "Resources"

        returnListView.Items.Clear()

        If type = "Setup" Then
            query = "SELECT AdditionalResources.Name, AdditionalResources.Hyperlink FROM ((AdditionalResources INNER JOIN [Entity-ResourceLink] ON AdditionalResources.Name = [Entity-ResourceLink].ResourceID) INNER JOIN Setups ON [Entity-ResourceLink].EntitiesID = Setups.Name) WHERE ([Entity-ResourceLink].Entities = 'Setup') AND (Setups.Name = '" & targetID & "');"
        End If
        If type = "Machine" Then
            query = "Select AdditionalResources.Name, AdditionalResources.Hyperlink FROM ((AdditionalResources INNER JOIN [Entity-ResourceLink] On AdditionalResources.Name = [Entity-ResourceLink].ResourceID) INNER JOIN Machines On [Entity-ResourceLink].EntitiesID = Machines.Name) WHERE ([Entity-ResourceLink].Entities = 'Machine') AND (Machines.Name = '" & targetID & "') ORDER BY AdditionalResources.Name;"
        End If
        If type = "Operations" Then
            query = "Select AdditionalResources.Name, AdditionalResources.Hyperlink FROM((AdditionalResources INNER JOIN [Entity-ResourceLink] On AdditionalResources.Name = [Entity-ResourceLink].ResourceID) INNER JOIN Operations On [Entity-ResourceLink].EntitiesID = Operations.Name) WHERE([Entity-ResourceLink].Entities = 'Operations') AND (Operations.Name = '" & targetID & "') ORDER BY AdditionalResources.Name;"
        End If
        If type = "Machine Tool" Then
            query = "SELECT AdditionalResources.Name, AdditionalResources.Hyperlink FROM((AdditionalResources INNER JOIN [Entity-ResourceLink] ON AdditionalResources.Name = [Entity-ResourceLink].ResourceID) INNER JOIN MachineTools ON [Entity-ResourceLink].EntitiesID = MachineTools.Name) WHERE([Entity-ResourceLink].Entities = 'Machine Tool') AND (MachineTools.Name = '" & targetID & "') ORDER BY AdditionalResources.Name;"
        End If

        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        returnListView.View = View.List ' defines the format of the listview

        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'need to write code to make or apply pre made thumbnails to resources

            'add the new item to the list view
            returnListView.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next
        returnListView.Update()
    End Sub
    Shared Sub SetImage(cnn As OleDbConnection, Type As String, TargetID As String, returnPictureBox As PictureBox, ds As DataSet)
        'This sub takes the inputs and applies the correct image to the speciefied page. 
        Dim query As String
        Dim Table_ As String = "Target"
        Dim url As String = ""

        If Type = "Setup" Then
            query = "SELECT * from Setups Where Name = '" & TargetID & "';"
        End If
        If Type = "Machine" Then
            query = "SELECT * from Machines Where Name = '" & TargetID & "';"
        End If
        If Type = "Operation" Then
            query = "SELECT * from Operations Where Name = '" & TargetID & "';"
        End If
        If Type = "Machine Tool" Then
            query = "SELECT * from MachineTools Where Name = '" & TargetID & "';"
        End If

        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format
        Dim picture As Image
        Using fs As New FileStream(Application.StartupPath & ds.Tables(Table_).Rows(0)("DetailURL"), FileMode.Open, FileAccess.Read)

            picture = Image.FromStream(fs)

        End Using

        returnPictureBox.Image = picture

    End Sub
    Shared Sub ResourceDoubleClickHandler(ListResource As ListView, ByRef ds As DataSet)
        Dim index As Integer = ListResource.FocusedItem.Index

        Try
            Dim webAddress As String = ds.Tables("Resources").Rows(index)("Hyperlink")
            Process.Start(webAddress)
        Catch
            MsgBox("URL not found or not formatted correctly")
        End Try

    End Sub

    Shared Sub Get_feedback(EntityType As String, Entity As String)
        'displays a messagebox to get user feedback on pages and stores it. 

        GlobalVariables.FeedbackEntity = Entity
        GlobalVariables.FeedbackEntityType = EntityType

        Dim newform As Form = FormFeedback
        newform.ShowDialog()



    End Sub

    Shared Function IsValidImage(filename As String) As Boolean
        Try
            Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
        Catch generatedExceptionName As OutOfMemoryException
            ' Image.FromFile throws an OutOfMemoryException  
            ' if the file does not have a valid image format or 
            ' GDI+ does not support the pixel format of the file. 
            ' 
            Return False
        End Try
        Return True
    End Function


End Class