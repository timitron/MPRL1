Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class FormEditMachineLink
    Dim TargetID As String = GlobalVariables.Click

    Dim ds As New DataSet   'defines dataset for data table

    Private Sub FormEditMachineLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblTitle.Text = TargetID

        update_machines_combobox()
        update_allmachines_combobox()

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        If CmboboxRemove.SelectedItem = "" Then
            MsgBox("Select something to remove")
            Exit Sub
        End If

        Dim query As String
        query = "DELETE FROM [Machine-MachineToolLink] WHERE(MachineToolID = '" & GlobalVariables.Click & "') And (MachineID =  '" & CmboboxRemove.SelectedItem & "')"
        Dim response As Integer
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)

        GlobalVariables.cnn.Open()

        Try
            response = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Duplicate Required PPE")
        End Try

        GlobalVariables.cnn.Close()

        NotifyIcon1.ShowBalloonTip(500, "Change Made", response & " Row(s) Modified", ToolTipIcon.Error)

        update_allmachines_combobox()
        update_machines_combobox()
        CmboboxRemove.ResetText()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If CmboboxAdd.SelectedItem = "" Then
            MsgBox("Select something to remove")
            Exit Sub
        End If

        Dim query As String
        Dim Table_ As String = "RequiredSelected"
        query = "INSERT INTO `Machine-MachineToolLink` (`MachineToolID`, `MachineID`) VALUES ('" & GlobalVariables.Click & "','" & CmboboxAdd.SelectedItem & "')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
        Dim response As Integer

        GlobalVariables.cnn.Open()



        Try
            response = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Duplicate Link")
        End Try

        GlobalVariables.cnn.Close()

        NotifyIcon1.ShowBalloonTip(500, "Change Made", response & " Row(s) Modified", ToolTipIcon.Info)


        update_allmachines_combobox()
        update_machines_combobox()
        CmboboxAdd.ResetText()

    End Sub

    Sub update_machines_combobox()
        CmboboxRemove.Items.Clear()
        Dim query As String
        Dim Table_ As String = "MachinesLinked"
        query = "SELECT        Machines.Name FROM            ((Machines INNER JOIN                         [Machine-MachineToolLink] ON Machines.Name = [Machine-MachineToolLink].MachineID) INNER JOIN                         MachineTools ON [Machine-MachineToolLink].MachineToolID = MachineTools.Name) WHERE        (MachineTools.Name = '" & TargetID & "')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
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

    Sub update_allmachines_combobox()
        CmboboxAdd.Items.Clear()

        Dim Table_ As String = "Machines"
        Dim query As String = "SELECT        Name FROM            Machines"

        Dim cmd2 As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
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
