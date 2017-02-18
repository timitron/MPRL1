Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class FeedbackForm
    Dim ds As New DataSet                       'defines dataset for data table

    Private Sub FeedbackForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Table_ As String = "Feedback"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT Feedback.EntityType, Feedback.Entity, Avg(Feedback.Useful) AS AvgOfUseful FROM Feedback GROUP BY Feedback.EntityType, Feedback.Entity;"

        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        LstviewFeedback.Columns.Add("Type")
        LstviewFeedback.Columns.Add("Name")
        LstviewFeedback.Columns.Add("Useful Ratio")

        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            NextListItem.SubItems.Add(row(1).ToString)
            NextListItem.SubItems.Add(row(2).ToString)

            'add the new item to the list view
            LstviewFeedback.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next
        LstviewFeedback.AutoResizeColumns(1)
        LstviewFeedback.Update()


    End Sub



End Class