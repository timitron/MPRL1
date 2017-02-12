Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class FormEditRequiredPPE
    Dim TargetID As String = GlobalVariables.Click

    Dim ds As New DataSet   'defines dataset for data table
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)

    Private Sub FormEditRequiredPPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTargetName.Text = "For: " & TargetID

        update_ppe_combobox()
        update_req_combobox()



    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        If CmboboxRemove.SelectedItem = "" Then
            MsgBox("Select something to remove")
            Exit Sub
        End If

        Dim query As String
        Dim Table_ As String = "RequiredSelected"
        query = "DELETE FROM [Machine-PPELink] WHERE(MachineID = '" & GlobalVariables.Click & "') AND (PPEID = '" & CmboboxRemove.SelectedItem & "') AND (Required = 1)"
        Dim response As integer
        Dim cmd As New OleDbCommand(query, cnn)

        cnn.Open()

        Try
            response = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Duplicate Required PPE")
        End Try

        cnn.Close()

        MsgBox(response & "Row(s) Modified")

        update_req_combobox()
        update_ppe_combobox()
        CmboboxRemove.ResetText()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If CmboboxAdd.SelectedItem = "" Then
            MsgBox("Select something to remove")
            Exit Sub
        End If

        Dim query As String
        Dim Table_ As String = "RequiredSelected"
        query = "INSERT INTO [Machine-PPELink] (MachineID, PPEID, Required, Hidden) VALUES('" & GlobalVariables.Click & "', '" & CmboboxAdd.SelectedItem & "', 1, 0)"
        Dim cmd As New OleDbCommand(query, cnn)
        Dim response As Integer

        cnn.Open()

        Try
            response = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Duplicate Required PPE")
        End Try

        cnn.Close()

        MsgBox(response & "Row(s) Modified")

        update_req_combobox()
        update_ppe_combobox()
        CmboboxAdd.ResetText()

    End Sub

    Sub update_req_combobox()
        CmboboxRemove.Items.Clear()
        Dim query As String
        Dim Table_ As String = "RequiredSelected"
        query = "SELECT PPE.Name, PPE.Description, PPE.ImageURL FROM ((PPE INNER JOIN [Machine-PPELink] ON PPE.Name = [Machine-PPELink].PPEID) INNER JOIN Machines ON [Machine-PPELink].MachineID = Machines.Name) WHERE ([Machine-PPELink].Required = True) AND (Machines.Name = '" & TargetID & "')"
        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format
        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images
        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            CmboboxRemove.Items.Add(row(0).ToString)
        Next
        ds.Tables(Table_).Clear()
    End Sub

    Sub update_ppe_combobox()
        CmboboxAdd.Items.Clear()

        Dim Table_ As String = "PPE"
        Dim query As String = "SELECT        Name FROM            PPE"

        Dim cmd2 As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data2 As New OleDbDataAdapter(cmd2)                               'this executes the interpreted query on the connection object and returns it to the da object
        data2.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        Dim add = 0
        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 

        For Each row In (ds.Tables(Table_).Rows)
            CmboboxAdd.Items.Add(row(0).ToString)
        Next

        ds.Tables(Table_).Clear()

    End Sub
End Class