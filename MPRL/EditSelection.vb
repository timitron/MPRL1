Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net


Public Class EditForm

    Dim ds As New DataSet                       'defines dataset for data table
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'define connection string and create connection object 
        Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
        Dim cnn As OleDbConnection = New OleDbConnection(cnnString)
        Dim Table_ As String
        Dim query As String


        'open connection to database and execute the query string
        cnn.Open()
        Label2.Text = "Choose " & GlobalVariables.Click & " to edit."
        If GlobalVariables.Click = "PPE" Then
            Table_ = "PPE"   'defines table inside the dataset to store information recieved from data connections
            query = "SELECT Name FROM PPE;"    'data connection querry this must be run through the oledb command interpreter before executing it on the connection
        ElseIf GlobalVariables.Click = "Setups" Then
            Table_ = "Setups"
            query = "SELECT Name FROM Setups"
        ElseIf GlobalVariables.Click = "Operations" Then
            Table_ = "Operations"
            query = "SELECT Name FROM Operations"
        ElseIf GlobalVariables.Click = "Machine Tools" Then
            Table_ = "MachineTools"
            query = "Select Name FROM MachineTools"
        ElseIf GlobalVariables.Click = "Machines" Then
            Table_ = "Machines"
            query = "SELECT Name FROM Machines"
        End If

        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                               'This inserts the returned data into the table name defined above in a useable matrix format


        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            ' Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'add the new item to the list view
            editList.Items.Add(row(0).ToString) 'NextListItem)

        Next

        editList.Update()
        cnn.Close()
    End Sub


    Private Sub editList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles editList.DoubleClick
        GlobalVariables.Clicked = editList.SelectedItem
        Dim newform
        newform = Edititems
        Edititems.Show()
        Me.Close()


    End Sub
End Class