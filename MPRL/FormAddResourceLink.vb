Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net



Public Class FormAddResourceLink

    Dim TargetID As String = GlobalVariables.Click
    Dim EntityType As String = GlobalVariables.Clicked

    Dim ds As New DataSet   'defines dataset for data table

    Private Sub FormAddResourceLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtBoxEntityType.Text = EntityType.ToString
        TxtBoxEntityName.Text = TargetID.ToString

        CustFunctions.Resources(GlobalVariables.cnn, EntityType, TargetID, LstViewResources, ds)

        fill_resources()

        Txtboxfilter.Focus()

    End Sub
    Sub fill_resources()
        CmboResourceName.Items.Clear()

        Dim Table_ As String = "AllResoureces"
        Dim query As String = "SELECT Name, Hyperlink FROM AdditionalResources WHERE (Name Like '%" & Txtboxfilter.Text & "%')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        Dim row As DataRow
        Dim count As Integer = 0
        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            CmboResourceName.Items.Add(row(0).ToString)
            count = count + 1
        Next

        If count = 0 Then
            CmboResourceName.Items.Add("No Resource Found")
        End If

        CmboResourceName.SelectedIndex = 0

        ds.Tables(Table_).Clear()
    End Sub

    Private Sub Txtboxfilter_TextChanged(sender As Object, e As EventArgs) Handles Txtboxfilter.TextChanged
        fill_resources()
    End Sub

    Private Sub CmboResourceName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmboResourceName.SelectedIndexChanged

        retest()

    End Sub

    Sub retest()

        Dim Table_ As String = "SelectedResources"



        Dim query As String = "SELECT Entities, EntitiesID, ResourceID FROM [Entity-ResourceLink] WHERE (Entities = '" & EntityType & "') AND (EntitiesID = '" & TargetID & "') AND (ResourceID = '" & CmboResourceName.SelectedItem.ToString & "')"
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

    Private Sub btnAddLink_Click(sender As Object, e As EventArgs) Handles btnAddLink.Click
        'check to see if no resource is selected or an overly tight filter has been used
        If CmboResourceName.SelectedItem = "" Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "No resource selected", ToolTipIcon.Info)
            Exit Sub
        End If

        If CmboResourceName.SelectedItem = "No Resource Found" Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "No resource selected", ToolTipIcon.Info)
            Exit Sub
        End If

        'check to see if it is a duplicate link
        If LblDuplicate.Text.Equals("DUPLICATE LINK") Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "DUPLICATE LINK", ToolTipIcon.Info)
            Exit Sub
        End If

        'If it passess all of the other tests then add the link

        Dim query As String = "INSERT INTO `Entity-ResourceLink` (`Entities`, `EntitiesID`, `ResourceID`) VALUES ('" & EntityType & "', '" & TargetID & "', '" & CmboResourceName.SelectedItem.ToString & "')"
        Dim Table_ As String = "RequiredSelected"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)


        GlobalVariables.cnn.Open()
        Try
            Dim response As Integer = cmd.ExecuteNonQuery()
            NotifyIcon1.ShowBalloonTip(500, "Link Added", response & " Rows Changed", ToolTipIcon.Info)
        Catch
            MsgBox("There was an unanticipated error adding this link to the database ")
        End Try

        ds.Tables("Resources").Clear()

        retest()

        CustFunctions.Resources(GlobalVariables.cnn, EntityType, TargetID, LstViewResources, ds)

        GlobalVariables.cnn.Close()

    End Sub

    Private Sub BtnRemoveLink_Click(sender As Object, e As EventArgs) Handles BtnRemoveLink.Click

        Dim index As Integer = LstViewResources.FocusedItem.Index

        Dim query As String = "DELETE FROM `Entity-ResourceLink` WHERE (Entities = '" & EntityType & "') AND (EntitiesID = '" & TargetID & "') AND (ResourceID = '" & ds.Tables("Resources").Rows(index)("Name") & "')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)


        GlobalVariables.cnn.Open()
        Try
            Dim response As Integer = cmd.ExecuteNonQuery()
            NotifyIcon1.ShowBalloonTip(500, "Link Removed", response & " Rows Changed", ToolTipIcon.Info)
        Catch
            MsgBox("There was an unanticipated error removing this link from the database")
        End Try

        LstViewResources.Items.Clear()
        ds.Tables("Resources").Clear()

        'refill our linked resources pane with the new linked resources
        CustFunctions.Resources(GlobalVariables.cnn, EntityType, TargetID, LstViewResources, ds)

        'change selected index to refresh the duplicate link label 
        CmboResourceName.SelectedIndex = 0
        retest()

        GlobalVariables.cnn.Close()

    End Sub
End Class