Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class FeatureView
    Dim ds As New DataSet                       'defines dataset for data table

    Private Sub FeatureView_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'open connection to database and execute the query string
        GlobalVariables.cnn.Open()
        Dim Table_ As String = "Features"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT Name, Description, ImageURL FROM Features;"    'data connection querry this must be run through the oledb command interpreter before executing it on the connection
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)

        Dim ImgList As New ImageList
        ImgList.ImageSize = New Size((Global.MPRL.GlobalVariables.IconSizeWidth * 2), (Global.MPRL.GlobalVariables.IconSizeHeight * 2))

        LstViewFeatures.View = View.LargeIcon ' defines the format of the listview

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
            LstViewFeatures.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next

        'properties for the listview and finally an update command for the list view. 
        LstViewFeatures.LargeImageList = ImgList
        LstViewFeatures.Update()

        GlobalVariables.cnn.Close()



    End Sub
End Class