Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class Version
    Dim ds As New DataSet                       'defines dataset for data table
    Dim query As String
    Dim Table_ As String
    Dim address As String


    Private Sub Version_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GlobalVariables.cnn.Open()
        Table_ = "admin"  'defines table inside the dataset to store information recieved from data connections
        query = "Select Version, WebAddress, DisplayONStart, RequestFeedBack FROM Admin"


        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format
        GlobalVariables.version = ds.Tables(Table_).Rows(0)("Version")
        Label1.Text = "Version: " & GlobalVariables.version

        GlobalVariables.webaddress = ds.Tables(Table_).Rows(0)("WebAddress")
        Dim display As Boolean = ds.Tables(Table_).Rows(0)("DisplayONStart")

        If GlobalVariables.AdminBuild = True Then
            GlobalVariables.GetFeedBack = False
        Else
            GlobalVariables.GetFeedBack = ds.Tables(Table_).Rows(0)("RequestFeedBack")
        End If

        If display = "False" Then
            Button1.Hide()
            TextBox1.Hide()
        End If

        GlobalVariables.cnn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(GlobalVariables.webaddress)
    End Sub
End Class
