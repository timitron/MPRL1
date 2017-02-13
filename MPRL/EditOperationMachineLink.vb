Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class FormEditMachiningMethodMachineToolLink

    Dim TargetID As String = GlobalVariables.Click


    Dim ds As New DataSet   'defines dataset for data table
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)

    Private Sub FormEditMachiningMethodMachineToolLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTitle.Text = TargetID

        update_linkedmethods_combobox()
        update_allMachiningMethods_combobox()


    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        If CmboboxRemove.SelectedItem = "" Then
            MsgBox("Select something to remove")
            Exit Sub
        End If

        Dim query As String = "DELETE FROM `MachineTool-OperationsLink` WHERE ((`MachineToolID` = '" & GlobalVariables.Click & "') AND (`OperationsID` = '" & CmboboxRemove.SelectedItem & "'))"
        Dim response As Integer
        Dim cmd As New OleDbCommand(query, cnn)

        cnn.Open()

        Try
            response = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Duplicate Required PPE")
        End Try

        cnn.Close()

        MsgBox(response & "Row(s) Modified")

        update_linkedmethods_combobox()
        update_allMachiningMethods_combobox()
        CmboboxRemove.ResetText()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If CmboboxAdd.SelectedItem = "" Then
            MsgBox("Select something to remove")
            Exit Sub
        End If

        Dim query As String = "INSERT INTO `MachineTool-OperationsLink` (`MachineToolID`, `OperationsID`) VALUES ('" & GlobalVariables.Click & "','" & CmboboxAdd.SelectedItem & "')"

        Dim cmd As New OleDbCommand(query, cnn)
        Dim response As Integer

        cnn.Open()

        Try
            response = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Duplicate Link")
        End Try

        cnn.Close()

        MsgBox(response & "Row(s) Modified")

        update_linkedmethods_combobox()
        update_allMachiningMethods_combobox()
        CmboboxAdd.ResetText()

    End Sub

    Sub update_linkedmethods_combobox()
        CmboboxRemove.Items.Clear()
        Dim Table_ As String = "LinkedOperations"
        Dim query As String = "SELECT        Operations.Name, Operations.ImageURL FROM            ((Operations INNER JOIN                         [MachineTool-OperationsLink] ON Operations.Name = [MachineTool-OperationsLink].OperationsID) INNER JOIN                         MachineTools ON [MachineTool-OperationsLink].MachineToolID = MachineTools.Name) WHERE        (MachineTools.Name = '" & GlobalVariables.Click & "')"
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

    Sub update_allMachiningMethods_combobox()
        CmboboxAdd.Items.Clear()

        Dim Table_ As String = "ClampingMethod"
        Dim query As String = "SELECT        Name FROM            Operations"

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