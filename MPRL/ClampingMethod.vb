Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class FormClampingMethod
    'Get what to open from the global click variable
    Dim ClampingMethod As String = Global.MPRL.GlobalVariables.Click

    Dim ds As New DataSet                       'defines dataset for data table
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)

    Dim printfile As New System.IO.StreamWriter(Application.StartupPath & "\printfile.html", False)
    Dim htmlprint As String = ""

    Private Sub FormClampingMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CustFunctions.SetImage(cnn, "ClampingMethod", ClampingMethod, PictureOverview, ds, htmlprint)

        Dim startpoint = New Point(40, 610)

        CustFunctions.Resources(cnn, "ClampingMethod", ClampingMethod, LstResources, ds)
        CustFunctions.Instructions(cnn, "ClampingMethod", ClampingMethod, startpoint, 100, ds, htmlprint, Me)

        printfile.Write(htmlprint)
        printfile.Close()

    End Sub

    Sub set_image()
        Dim Table_ As String = "ImageURL"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT * from ClampingMethods Where Name = '" & ClampingMethod & "';"    'data connection querry this must be run through the oledb command interpreter before executing it on the connection
        Dim url As String = ""
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

        htmlprint &= "<H1>" & ClampingMethod & "</H1><br>"
        url = ds.Tables(Table_).Rows(0)("ImageURL").replace("\", "/")
        htmlprint &= "<img src =""." & url & " ""><br>"
    End Sub

    Sub fill_resources()
        'define connection string and create connection object 
        Dim Table_ As String = "Resources"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "Select        AdditionalResources.Name, AdditionalResources.Type, AdditionalResources.Hyperlink FROM((AdditionalResources INNER JOIN                         [Entity-ResourceLink] On AdditionalResources.ID = [Entity-ResourceLink].ResourceID) INNER JOIN                         ClampingMethods On [Entity-ResourceLink].EntitiesID = ClampingMethods.Name) WHERE([Entity-ResourceLink].Entities = 'Clamping Method') AND (ClampingMethods.Name = '" & ClampingMethod & "')"

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
    Private Sub LstResources_doubleclick(sender As Object, e As EventArgs) Handles LstResources.DoubleClick
        Dim index As Integer = LstResources.FocusedItem.Index

        Try
            Dim webAddress As String = ds.Tables("Resources").Rows(index)("Hyperlink")
            Process.Start(webAddress)
        Catch
            MsgBox("URL not found or not formatted correctly")
        End Try



    End Sub
    Private Sub BttnPrint_Click(sender As Object, e As EventArgs) Handles BttnPrint.Click

        Dim webAddress As String = Application.StartupPath & "\printfile.html"
        Process.Start(webAddress)

    End Sub

    Private Sub PictureOverview_Click(sender As Object, e As EventArgs) Handles PictureOverview.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Home.Click

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
        Global.MPRL.GlobalVariables.Click = GlobalVariables.prevMachineTool

        Dim newform
        newform = FormMachineToolDetails
        newform.Show()

        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True

    End Sub
End Class