Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net



Public Class FormMachineToolsDisplay

    Dim ds As New DataSet                       'defines dataset for data table


    Public Sub FormMachineToolsDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'define connection string and create connection object 
        Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
        Dim cnn As OleDbConnection = New OleDbConnection(cnnString)

        'open connection to database and execute the query string
        cnn.Open()
        Dim Table_ As String = "MachineToolsList"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT Name, Description, ImageURL FROM MachineTools;"    'data connection querry this must be run through the oledb command interpreter before executing it on the connection
        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                               'This inserts the returned data into the table name defined above in a useable matrix format

        'the image list for the icons to display in the list view and then sets the size of the thumbnails to create when an image is added 
        Dim ImgList As New ImageList
        ImgList.ImageSize = New Size((Global.MPRL.GlobalVariables.IconSizeWidth * 2), (Global.MPRL.GlobalVariables.IconSizeHeight * 2))

        ListViewMachineToolDisplay.View = View.LargeIcon ' defines the format of the listview

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
            ListViewMachineToolDisplay.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next

        'properties for the listview and finally an update command for the list view. 
        ListViewMachineToolDisplay.LargeImageList = ImgList
        ListViewMachineToolDisplay.Update()

        cnn.Close()
    End Sub

    Public Sub ListViewMachineToolDisplay_DoubleClick(sender As Object, e As EventArgs) Handles ListViewMachineToolDisplay.DoubleClick
        Dim Table_ As String = "MachineToolsList"   'defines table inside the dataset to store information recieved from data connections
        Dim index As Integer = ListViewMachineToolDisplay.FocusedItem.Index
        Global.MPRL.GlobalVariables.Click = ds.Tables(Table_).Rows(index)(0)
        Dim newform
        newform = FormMachineToolDetails
        newform.Show()

        GlobalVariables.prevMachineTool = Global.MPRL.GlobalVariables.Click
        GlobalVariables.CloseAll = False    'only closes current form
        Me.Close()
        GlobalVariables.CloseAll = True


    End Sub

    Private Sub ListViewMachineToolDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewMachineToolDisplay.SelectedIndexChanged



        Try
            Dim index As Integer = ListViewMachineToolDisplay.FocusedItem.Index
            TxtBoxDescription.Text = ds.Tables("MachineToolsList").Rows(Index)("Description")
        Catch ex As Exception
            TxtBoxDescription.Text = "No Description Entered"
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
        newform = FormHome

        newform.Show()

        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True

    End Sub


End Class
