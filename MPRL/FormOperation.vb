Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net


Public Class FormOperation

    'Get what to open from the global click variable
    Dim Operation As String = Global.MPRL.GlobalVariables.Click
    Dim ds As New DataSet                       'defines dataset for data table

    Private Sub MachiningMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.fromadd = True Then
            Button1.Hide()
        End If

        LblTitle.Text = Operation

        Dim startpoint As New Point(40, 600)
        CustFunctions.SetImage(GlobalVariables.cnn, "Operation", Operation, PictureOverview, ds)
        CustFunctions.Resources(GlobalVariables.cnn, "Operations", Operation, LstResources, ds)

        load_features()


    End Sub




    Private Sub LstResources_DoubleClick(sender As Object, e As EventArgs) Handles LstResources.DoubleClick
        CustFunctions.ResourceDoubleClickHandler(LstResources, ds)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormHome.Show()
        GlobalVariables.CloseAll = False
        Me.close()
        GlobalVariables.CloseAll = True

    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If GlobalVariables.CloseAll = True Then
            FormHome.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If GlobalVariables.MethodStart = True Then
            Dim newform
            newform = FormMachiningMethodsDisplay

            newform.Show()

            GlobalVariables.CloseAll = False
            Me.close()
            GlobalVariables.CloseAll = True
        Else
            Global.MPRL.GlobalVariables.Click = GlobalVariables.prevMachineTool

            Dim newform
            newform = FormMachineToolDetails
            newform.Show()

            GlobalVariables.CloseAll = False
            Me.close()
            GlobalVariables.CloseAll = True
        End If
    End Sub

    Private Sub BtnEditResources_Click(sender As Object, e As EventArgs) Handles BtnEditResources.Click
        Global.MPRL.GlobalVariables.Click = Operation
        GlobalVariables.Clicked = "Operations"
        Dim newform
        newform = FormAddResourceLink
        newform.Show()
    End Sub

    Sub load_features()
        'define connection string and create connection object 
        Dim Table_ As String = "Features"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT        Features.Name, Features.Description, Features.ImageURL FROM            ((Features INNER JOIN                         [Operation-FeatureLink] ON Features.Name = [Operation-FeatureLink].FeatureID) INNER JOIN                         Operations ON [Operation-FeatureLink].OperationID = Operations.Name) WHERE        (Operations.Name = '" & Operation & "')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format


        'the image list for the icons to display in the list view and then sets the size of the thumbnails to create when an image is added 
        Dim ImgListMachine As New ImageList
        ImgListMachine.ImageSize = New Size(Global.MPRL.GlobalVariables.IconSizeWidth, Global.MPRL.GlobalVariables.IconSizeHeight)
        LstViewFeatures.View = View.LargeIcon ' defines the format of the listview

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
            LstViewFeatures.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next

        'properties for the listview and finally an update command for the list view. 
        LstViewFeatures.LargeImageList = ImgListMachine
        LstViewFeatures.Update()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnEditFeatureLink.Click
        Global.MPRL.GlobalVariables.Click = Operation
        GlobalVariables.Clicked = "Operations"
        Dim newform
        newform = EditFeatureOperationLink
        newform.Show()
    End Sub

    Public Sub close() Handles Me.FormClosed

        CustFunctions.Get_feedback("Operations", Operation)
    End Sub
End Class