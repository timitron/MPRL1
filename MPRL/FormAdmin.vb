Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class FormAdmin
    Dim ds As New DataSet                       'defines dataset for data table
    Dim query As String
    Dim Table_ As String

    Dim address As String
    Dim version As Integer
    Dim webaddress As String
    Dim display As Boolean

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GlobalVariables.cnn.Open()
        Table_ = "admin"  'defines table inside the dataset to store information recieved from data connections
        query = "Select Version, WebAddress, DisplayONStart, RequestFeedBack FROM Admin"


        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                           'This inserts the returned data into the table name defined above in a useable matrix format



        version = ds.Tables(Table_).Rows(0)("Version")
        webaddress = ds.Tables(Table_).Rows(0)("WebAddress")
        display = ds.Tables(Table_).Rows(0)("DisplayONStart")
        Dim GetFeedBack As Boolean = ds.Tables(Table_).Rows(0)("RequestFeedBack")

        GlobalVariables.cnn.Close()

        TextBox1.Text = version
        TextBox2.Text = webaddress
        If display = True Then
            CheckBox2.Checked = 1
        Else
            CheckBox2.Checked = 0
        End If





    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        webaddress = TextBox2.Text

        query = "Update `Admin` Set  `WebAddress` = '" & webaddress & "'"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
        Dim response As Integer

        GlobalVariables.cnn.Open()

        response = cmd.ExecuteNonQuery()

        GlobalVariables.cnn.Close()
        TextBox2.Text = webaddress
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            query = "Update `Admin` Set  `DisplayONStart` = 1"
        Else query = "Update `Admin` Set  `DisplayONStart` = 0"
        End If


        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
        Dim response As Integer

        GlobalVariables.cnn.Open()

        response = cmd.ExecuteNonQuery()

        GlobalVariables.cnn.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        version = version + 1

        query = " Update `Admin`  set  Version = '" & version & "'"

        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
        Dim response As Integer

        GlobalVariables.cnn.Open()

        response = cmd.ExecuteNonQuery()

        GlobalVariables.cnn.Close()
        TextBox1.Text = version
    End Sub
End Class