Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class FormMachineToolDetails
    'Get what to open from the global click variable
    Dim Machine As String = Global.MPRL.GlobalVariables.Click
    Dim ds As New DataSet                       'defines dataset for data table

    Private Sub FormMachineToolDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.fromadd = True Then
            Button1.Hide()
        End If
        'make db connection
        connect()

        CustFunctions.SetImage(GlobalVariables.cnn, "Machine Tool", Machine, PictureMachineOverview, ds)

        'set name
        LblTitle.Text = Machine

        'Add PPE To Listviews


        fill_machining_methods()
        fill_machines()
        fill_clamping()

        CustFunctions.Resources(GlobalVariables.cnn, "Machine Tool", Machine, LstResources, ds)

        GlobalVariables.cnn.Close()

        If MPRL.GlobalVariables.AdminBuild = False Then
            BtnEditClampingLinks.Visible = False
            BtnEditMachineLinks.Visible = False
            BtnEditMachiningMethodsLink.Visible = False
            BtnEditResourcesLink.Visible = False
        End If


    End Sub
    Public Sub connect()
        'open connection to database and execute the query string
        GlobalVariables.cnn.Open()
    End Sub
    Sub fill_machining_methods()

        'define connection string and create connection object 
        Dim Table_ As String = "Operations"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT        Operations.Name, Operations.ImageURL FROM            ((Operations INNER JOIN                         [MachineTool-OperationsLink] ON Operations.Name = [MachineTool-OperationsLink].OperationsID) INNER JOIN                         MachineTools ON [MachineTool-OperationsLink].MachineToolID = MachineTools.Name) WHERE        (MachineTools.Name = '" & Machine & "')"

        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format


        'the image list for the icons to display in the list view and then sets the size of the thumbnails to create when an image is added 
        Dim ImgList As New ImageList
        ImgList.ImageSize = New Size(Global.MPRL.GlobalVariables.IconSizeWidth, Global.MPRL.GlobalVariables.IconSizeHeight)
        LstMachineMethods.View = View.LargeIcon ' defines the format of the listview

        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'connects to the image url, downloads the image from the source url and then saves it into the picture variable as a bitmap. 
            'Dim ImageInBytes() As Byte = tClient.DownloadData(ds.Tables(Table_).Rows(count)("ImageURL"))
            'Dim ImageStream As New IO.MemoryStream(ImageInBytes)
            'Dim picture As Bitmap = New System.Drawing.Bitmap(ImageStream)

            'this code loads a local image
            Dim picture As Image = Image.FromFile(Application.StartupPath & ds.Tables(Table_).Rows(count)("ImageURL"))

            'This adds the picture to the image list ImgList which is used as the icon list for the list view
            ImgList.Images.Add(picture)
            'applies an image index number to the nextlistitem object (this object uses image 'count' in the list as an icon) 
            NextListItem.ImageIndex = count

            'add the new item to the list view
            LstMachineMethods.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next

        'properties for the listview and finally an update command for the list view. 
        LstMachineMethods.LargeImageList = ImgList
        LstMachineMethods.Update()


    End Sub
    Private Sub fill_machines()

        'define connection string and create connection object 
        Dim Table_ As String = "Machines"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "Select Machines.MachineRoom, Machines.Description, Machines.EntityType, Machines.ImageURL, Machines.Name FROM(([Machine-MachineToolLink] INNER JOIN Machines On [Machine-MachineToolLink].MachineID = Machines.Name) INNER JOIN MachineTools On [Machine-MachineToolLink].MachineToolID = MachineTools.Name) WHERE(MachineTools.Name = '" & Machine & "')"

        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format


        'the image list for the icons to display in the list view and then sets the size of the thumbnails to create when an image is added 
        Dim ImgListMachine As New ImageList
        ImgListMachine.ImageSize = New Size(Global.MPRL.GlobalVariables.IconSizeWidth, Global.MPRL.GlobalVariables.IconSizeHeight)
        LstMachines.View = View.LargeIcon ' defines the format of the listview

        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(ds.Tables(Table_).Rows(count)("Name").ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'this code creates a new web client object, connects to the image url, downloads the image from the source url and then saves it into the picture variable as a bitmap. 
            'Dim ImageInBytes() As Byte = tClient.DownloadData(ds.Tables(Table_).Rows(count)("ImageURL"))
            'Dim ImageStream As New IO.MemoryStream(ImageInBytes)
            'Dim picture As Bitmap = New System.Drawing.Bitmap(ImageStream)

            'this code loads a local image
            Dim picture As Image = Image.FromFile(Application.StartupPath & ds.Tables(Table_).Rows(count)("ImageURL"))

            'This adds the picture to the image list ImgList which is used as the icon list for the list view
            ImgListMachine.Images.Add(picture)
            'applies an image index number to the nextlistitem object (this object uses image 'count' in the list as an icon) 
            NextListItem.ImageIndex = count

            'add the new item to the list view
            LstMachines.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next

        'properties for the listview and finally an update command for the list view. 
        LstMachines.LargeImageList = ImgListMachine
        LstMachines.Update()


    End Sub
    Sub fill_clamping()

        'define connection string and create connection object 
        Dim Table_ As String = "Setups"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT        Setups.Name, Setups.ImageURL FROM            ((Setups INNER JOIN                         [MachineTool-SetupLink] ON Setups.Name = [MachineTool-SetupLink].SetupID) INNER JOIN                        MachineTools ON [MachineTool-SetupLink].MachineToolID = MachineTools.Name) WHERE        (MachineTools.Name = '" & Machine & "')"

        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format


        'the image list for the icons to display in the list view and then sets the size of the thumbnails to create when an image is added 
        Dim ImgListClamp As New ImageList
        ImgListClamp.ImageSize = New Size(Global.MPRL.GlobalVariables.IconSizeWidth, Global.MPRL.GlobalVariables.IconSizeHeight)
        LstClampingMethods.View = View.LargeIcon ' defines the format of the listview

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

            'this code loads a local image
            Dim picture As Image = Image.FromFile(Application.StartupPath & ds.Tables(Table_).Rows(count)("ImageURL"))

            'This adds the picture to the image list ImgList which is used as the icon list for the list view
            ImgListClamp.Images.Add(picture)
            'applies an image index number to the nextlistitem object (this object uses image 'count' in the list as an icon) 
            NextListItem.ImageIndex = count

            'add the new item to the list view
            LstClampingMethods.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next

        'properties for the listview and finally an update command for the list view. 
        LstClampingMethods.LargeImageList = ImgListClamp
        LstClampingMethods.Update()


    End Sub
    Private Sub LstMachineMethods_DoubleClick(sender As Object, e As EventArgs) Handles LstMachineMethods.DoubleClick
        Dim index As Integer = LstMachineMethods.FocusedItem.Index
        Global.MPRL.GlobalVariables.Click = ds.Tables("Operations").Rows(index)("Name")

        Dim newform
        newform = FormOperation
        newform.Show()

        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True



    End Sub
    Private Sub LstResources_doubleclick(sender As Object, e As EventArgs) Handles LstResources.DoubleClick

        CustFunctions.ResourceDoubleClickHandler(LstResources, ds)

    End Sub
    Private Sub LstClampingMethods_DoubleClick(sender As Object, e As EventArgs) Handles LstClampingMethods.DoubleClick
        Dim index As Integer = LstClampingMethods.FocusedItem.Index
        Global.MPRL.GlobalVariables.Click = ds.Tables("Setups").Rows(index)("Name")
        Dim newform
        newform = FormSetup
        newform.Show()
        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True


    End Sub
    Private Sub LstMachines_DoubleClick(sender As Object, e As EventArgs) Handles LstMachines.DoubleClick
        Dim index As Integer = LstMachines.FocusedItem.Index
        Global.MPRL.GlobalVariables.Click = ds.Tables("Machines").Rows(index)("Name")
        Dim newform
        newform = FormMachineDetails
        newform.Show()

        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True
    End Sub

    Private Sub BtnEditReqPPE_Click(sender As Object, e As EventArgs)

        Global.MPRL.GlobalVariables.Click = Machine
        Dim newform
        newform = FormEditRequiredPPE

        newform.Show()
    End Sub

    Private Sub BtnEditOptPPE_Click(sender As Object, e As EventArgs)

        Global.MPRL.GlobalVariables.Click = Machine
        Dim newform
        newform = FormEditOptPPE

        newform.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnEditMachineLinks.Click
        Global.MPRL.GlobalVariables.Click = Machine
        Dim newform
        newform = FormEditMachineLink

        newform.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Global.MPRL.GlobalVariables.Click = Machine
        Dim newform
        newform = FormSetupLink

        newform.Show()
    End Sub

    Private Sub BtnEditMachiningMethodsLink_Click(sender As Object, e As EventArgs) Handles BtnEditMachiningMethodsLink.Click
        Global.MPRL.GlobalVariables.Click = Machine
        Dim newform
        newform = FormEditMachiningMethodMachineToolLink

        newform.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        FormHome.Show()
        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True

    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If GlobalVariables.CloseAll = True Then
            FormHome.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim newform
        newform = FormMachineToolsDisplay
        newform.Show()

        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True

    End Sub


    Private Sub BtnEditClampingLinks_Click(sender As Object, e As EventArgs) Handles BtnEditClampingLinks.Click
        Global.MPRL.GlobalVariables.Click = Machine
        Dim newform As Form
        newform = FormSetupLink

        newform.Show()
    End Sub

    Private Sub BtnEditResourcesLink_Click(sender As Object, e As EventArgs) Handles BtnEditResourcesLink.Click
        Global.MPRL.GlobalVariables.Click = Machine
        GlobalVariables.Clicked = "Machine Tool"
        Dim newform
        newform = FormAddResourceLink
        newform.Show()
    End Sub



End Class