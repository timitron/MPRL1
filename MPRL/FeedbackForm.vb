Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class FeedbackForm
    Dim ds As New DataSet                       'defines dataset for data table

    Private Sub FeedbackForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'retrieve feedback data, grouped by type and entity, display the information in the list view on the form. 


        Dim Table_ As String = "Feedback"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT        EntityType, Entity, AVG(Useful) AS AvgOfUseful, COUNT(Useful) AS Expr1 FROM            Feedback GROUP BY EntityType, Entity"

        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        'add columns and names to the display
        LstviewFeedback.Columns.Add("Type")
        LstviewFeedback.Columns.Add("Name")
        LstviewFeedback.Columns.Add("Useful Ratio")
        LstviewFeedback.Columns.Add("Count")

        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow

        'add info to the display table
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            NextListItem.SubItems.Add(row(1).ToString)
            NextListItem.SubItems.Add(row(2).ToString)
            NextListItem.SubItems.Add(row(3).ToString)
            'add the new item to the list view
            LstviewFeedback.Items.Add(NextListItem)
        Next
        'resize the columns and update. 
        LstviewFeedback.Update()
        LstviewFeedback.AutoResizeColumns(1)



    End Sub



End Class