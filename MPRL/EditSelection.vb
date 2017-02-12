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


        cnn.Open()       'open connection to database and execute the query string
        Label2.Text = "Choose " & GlobalVariables.Click & " to edit." 'states what type of item is being edited

        ''' retrives the names of all items based on item type
        If GlobalVariables.Click = "PPE" Then
            Table_ = "PPE"
            query = "SELECT Name FROM PPE;"
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

        Dim row As DataRow                                                  ' Dim t1 As DataTable = ds.Tables(Table_)

        For Each row In ds.Tables(Table_).Rows
            editList.Items.Add(row(0).ToString)                             ' adds each item name to the list
        Next

        editList.Sorted = True                                              'sorts list alphabetically
        editList.Update()                                                   'updates the list
        cnn.Close()                                                         'closes the connection
    End Sub

    Private Sub editList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles editList.DoubleClick
        'opens page to edit item
        GlobalVariables.Clicked = editList.SelectedItem 'stores the name of the item that was selected

        Dim newform = Edititems
        Edititems.Show()                                                    'opens edit form
        Me.Close()                                                          'closes form
    End Sub
End Class