Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class EditFeatureOperationLink
    Dim TargetID As String = GlobalVariables.Click

    Dim ds As New DataSet   'defines dataset for data table

    Private Sub EditFeatureOperationLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblTitle.Text = TargetID

        update_features_combo()
        update_allfeatures_combobox()

        CmboboxAdd.SelectedIndex = 0

    End Sub

    Sub update_features_combo()
        CmboboxRemove.Items.Clear()
        Dim query As String
        Dim Table_ As String = "featureslinked"
        query = "Select        Features.Name, Features.Description, Features.ImageURL FROM            ((Features INNER JOIN                         [Operation-FeatureLink] On Features.Name = [Operation-FeatureLink].FeatureID) INNER JOIN                         Operations On [Operation-FeatureLink].OperationID = Operations.Name) WHERE        (Operations.Name = '" & TargetID & "')"
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

    Sub update_allfeatures_combobox()
        CmboboxAdd.Items.Clear()

        Dim Table_ As String = "AllFeatures"
        Dim query As String = "SELECT        Name FROM            Features"

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

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If CmboboxAdd.SelectedItem = "" Then
            NotifyIcon1.ShowBalloonTip(500, "Nothing Selected", "Select something to link", ToolTipIcon.Info)
            Exit Sub
        End If

        Dim query As String
        Dim Table_ As String = "RequiredSelected"
        query = "INSERT INTO `Operation-FeatureLink` (`OperationID`, `FeatureID`) VALUES ('" & GlobalVariables.Click & "','" & CmboboxAdd.SelectedItem & "')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
        Dim response As Integer

        GlobalVariables.cnn.Open()

        If LblDuplicate.Text.Equals("DUPLICATE LINK") Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "DUPLICATE LINK", ToolTipIcon.Info)
            Exit Sub
        End If

        Try
            response = cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Unexpected SQL Error")
        End Try

        GlobalVariables.cnn.Close()

        NotifyIcon1.ShowBalloonTip(500, "Change Made", response & " Row(s) Modified", ToolTipIcon.Info)


        update_features_combo()
        update_allfeatures_combobox()
        CmboboxAdd.ResetText()

    End Sub

    Sub retest()

        Dim Table_ As String = "SelectedResources"



        Dim query As String = "SELECT        OperationID, FeatureID FROM            [Operation-FeatureLink] WHERE        (OperationID = '" & GlobalVariables.Click & "') AND (FeatureID = '" & CmboboxAdd.SelectedItem & "')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)

        If ds.Tables(Table_).Rows.Count = 0 Then
            LblDuplicate.Text = "New Link"
            LblDuplicate.BackColor = Color.Green
        End If
        If ds.Tables(Table_).Rows.Count = 1 Then
            LblDuplicate.Text = "DUPLICATE LINK"
            LblDuplicate.BackColor = Color.Red
            ds.Tables(Table_).Clear()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblDuplicate.Click

    End Sub

    Private Sub CmboboxAdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboboxAdd.SelectedIndexChanged
        retest()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        If CmboboxRemove.SelectedItem = "" Then
            NotifyIcon1.ShowBalloonTip(500, "Nothing Selected", "Select something to link", ToolTipIcon.Info)
            Exit Sub
        End If

        Dim query As String
        query = "DELETE FROM [Operation-FeatureLink] WHERE(OperationID = '" & GlobalVariables.Click & "') And (FeatureID =  '" & CmboboxRemove.SelectedItem & "')"
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

        update_features_combo()
        update_allfeatures_combobox()
        CmboboxRemove.ResetText()

    End Sub
End Class