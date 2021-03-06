﻿Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class EditFeatureOperationLink
    Dim TargetID As String = GlobalVariables.Click

    Dim ds As New DataSet   'defines dataset for data table

    Private Sub EditFeatureOperationLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblTitle.Text = TargetID

        update_linked_features()

        update_filtered_features()

        Txtboxfilter.Focus()

    End Sub

    Sub update_linked_features()

        LstViewFeatures.Items.Clear()
        Dim Table_ As String = "LinkedFeatures"

        If IsNothing(ds.Tables(Table_)) Then

        Else
            ds.Tables(Table_).Clear()
        End If

        Dim query = "Select        Features.Name, Features.Description, Features.ImageURL FROM            ((Features INNER JOIN                         [Operation-FeatureLink] On Features.Name = [Operation-FeatureLink].FeatureID) INNER JOIN                         Operations On [Operation-FeatureLink].OperationID = Operations.Name) WHERE        (Operations.Name = '" & TargetID & "')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        LstViewFeatures.View = View.List ' defines the format of the listview

        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'need to write code to make or apply pre made thumbnails to resources

            'add the new item to the list view
            LstViewFeatures.Items.Add(NextListItem)

        Next
        LstViewFeatures.Update()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAddLink.Click

        'check to see if no resource is selected or an overly tight filter has been used
        If CmboFeatureName.SelectedItem = "" Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "No resource selected", ToolTipIcon.Info)
            Exit Sub
        End If

        If CmboFeatureName.SelectedItem = "No Resource Found" Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "No resource selected", ToolTipIcon.Info)
            Exit Sub
        End If

        'check to see if it is a duplicate link
        If LblDuplicate.Text.Equals("DUPLICATE LINK") Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "DUPLICATE LINK", ToolTipIcon.Info)
            Exit Sub
        End If

        'If it passess all of the other tests then add the link

        Dim query As String = "INSERT INTO `Operation-FeatureLink` (`OperationID`, `FeatureID`) VALUES ('" & GlobalVariables.Click & "','" & CmboFeatureName.SelectedItem & "')"
        Dim Table_ As String = "RequiredSelected"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)


        GlobalVariables.cnn.Open()
        Try
            Dim response As Integer = cmd.ExecuteNonQuery()
            NotifyIcon1.ShowBalloonTip(500, "Link Added", response & " Rows Changed", ToolTipIcon.Info)
        Catch
            MsgBox("There was an unanticipated error adding this link to the database ")
        End Try

        update_linked_features()

        retest()

        GlobalVariables.cnn.Close()

    End Sub

    Sub retest()

        Dim Table_ As String = "SelectedFeature"

        Dim query As String = "SELECT        OperationID, FeatureID FROM            [Operation-FeatureLink] WHERE        (OperationID = '" & GlobalVariables.Click & "') AND (FeatureID = '" & CmboFeatureName.SelectedItem & "')"
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


    Private Sub CmboboxAdd_SelectedIndexChanged(sender As Object, e As EventArgs)
        retest()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemoveLink.Click

        Dim index As Integer

        Try
            index = LstViewFeatures.FocusedItem.Index
        Catch ex As Exception
            Exit Sub
        End Try


        Dim query As String = "DELETE FROM [Operation-FeatureLink] WHERE(OperationID = '" & TargetID & "') And (FeatureID =  '" & ds.Tables("LinkedFeatures").Rows(index)("Name") & "')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)


        GlobalVariables.cnn.Open()
        Try
            Dim response As Integer = cmd.ExecuteNonQuery()
            NotifyIcon1.ShowBalloonTip(500, "Link Removed", response & " Rows Changed", ToolTipIcon.Info)
        Catch
            MsgBox("There was an unanticipated error removing this link from the database")
        End Try

        update_linked_features()

        retest()

        GlobalVariables.cnn.Close()

    End Sub

    Private Sub Txtboxfilter_TextChanged(sender As Object, e As EventArgs) Handles Txtboxfilter.TextChanged
        update_filtered_features()
    End Sub

    Sub update_filtered_features()

        Dim Table_ As String = "AllFeatures"

        If IsNothing(ds.Tables(Table_)) Then

        Else
            ds.Tables(Table_).Clear()
        End If

        CmboFeatureName.Items.Clear()


        Dim query As String = "SELECT Name FROM Features WHERE (Name Like '%" & Txtboxfilter.Text & "%')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        Dim row As DataRow
        Dim count As Integer = 0
        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            CmboFeatureName.Items.Add(row(0).ToString)
            count = count + 1
        Next

        If count = 0 Then
            CmboFeatureName.Items.Add("No Resource Found")
        End If

        CmboFeatureName.SelectedIndex = 0

        ds.Tables(Table_).Clear()
    End Sub

    Private Sub CmboResourceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboFeatureName.SelectedIndexChanged
        retest()
    End Sub
End Class