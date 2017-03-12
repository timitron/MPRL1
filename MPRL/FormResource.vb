Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class FormResource

    Dim query As String
    Dim ds As New DataSet                       'defines dataset for data table

    Dim originalText As String

    Private Sub FormResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If adding a resource set all fields to blanks and hide the delete button. 
        If GlobalVariables.Click = "add" Then
            Label5.Text = "Add Resource"                                        'states what is being added
            'sets description to default
            NameTextBox.Text = ""
            AddressTextBox.Text = ""
            BtnDelete.Hide()

        Else 'if editing a resource load the resource information

            Dim Table_ As String = "Resource" 'table name for use in the ds dataset 

            query = "SELECT Name, Hyperlink FROM AdditionalResources Where (([Name] = '" & GlobalVariables.Clicked & "'));"

            GlobalVariables.cnn.Open()
            Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
            Dim data As New OleDbDataAdapter(cmd)
            data.Fill(ds, Table_)

            'set the page title and text box information with the returned information 
            Label5.Text = "Edit " & ds.Tables(Table_).Rows(0)("Name")                                        '
            NameTextBox.Text = ds.Tables(Table_).Rows(0)("Name")
            AddressTextBox.Text = ds.Tables(Table_).Rows(0)("Hyperlink")

            GlobalVariables.cnn.Close()

            originalText = NameTextBox.Text 'used to track if the name of the resource has been edited

            retest()
        End If

    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        'checks for correct info then updates database with modifications or adds item to database 

        Dim updatelinks As Boolean = False 'tracks if linked resource names need to be changed as well. 

        'check for name 
        If NameTextBox.Text = "" Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "You must enter a resource name.", ToolTipIcon.Info)
            Exit Sub
        End If

        'check for resource
        If AddressTextBox.Text = "" Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "You must enter a resource URL.", ToolTipIcon.Info)
            Exit Sub
        End If

        'check for valid URL format
        If (AddressTextBox.Text.StartsWith("www.") = False) And (AddressTextBox.Text.StartsWith("http://") = False) And (AddressTextBox.Text.StartsWith("https://") = False) Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "URL not Recognized: Must start with www., http://, or https://", ToolTipIcon.Info)
            Exit Sub
        End If

        If LblDuplicate.Text = "Duplicate Entity" Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "Duplicate Resource Name", ToolTipIcon.Info)
            Exit Sub
        End If

        'if you did not click add (AKA you clicked edit) use these queries
        If GlobalVariables.Click <> "add" Then

            'If the name has changed
            If originalText <> NameTextBox.Text Then
                updatelinks = True
                query = "UPDATE `AdditionalResources` SET `Name` = '" & NameTextBox.Text & "', `Hyperlink` = '" & AddressTextBox.Text & "' WHERE (name= '" & originalText & "')"

            Else 'if the name didn't change update the URL 
                query = "UPDATE `AdditionalResources` SET `Hyperlink` = '" & AddressTextBox.Text & "' WHERE (name= '" & NameTextBox.Text & "')"
            End If

        Else 'if adding entity
            query = " INSERT INTO `AdditionalResources` (`Name`, `Hyperlink`) VALUES ('" & NameTextBox.Text & "', '" & AddressTextBox.Text & "')"
        End If

        'checks to make sure item should be added
        Dim result As Integer = MessageBox.Show("Are you sure you want to add/edit " & NameTextBox.Text & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then

            'I don't know what this is for now... 
            'If AddressTextBox.Text.StartsWith(Application.StartupPath) = False Then
            'AddressTextBox.Text = Replace(AddressTextBox.Text, Application.StartupPath, "")
            'End If

            'if links need to be updated then run this update prior to changing the entity name. 
            If updatelinks = True Then
                Dim updatequery = "UPDATE `Entity-ResourceLink` SET `ResourceID` = '" & NameTextBox.Text & "' WHERE (ResourceID = '" & originalText & "')"
                Dim updatecmd As New OleDbCommand(query, GlobalVariables.cnn)
                Dim updateresponse As Integer

                GlobalVariables.cnn.Open()
                updateresponse = updatecmd.ExecuteNonQuery()
                GlobalVariables.cnn.Close()

                NotifyIcon1.ShowBalloonTip(500, "Links Modified", updateresponse & " Links modified upon edit", ToolTipIcon.Info)
            End If

            'execute the edit / add query
            Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
            Dim response As Integer

            GlobalVariables.cnn.Open()
            response = cmd.ExecuteNonQuery()
            GlobalVariables.cnn.Close()

            NotifyIcon1.ShowBalloonTip(500, "Resource Added", response & " Resources Added", ToolTipIcon.Info)


            Me.Close()                                              'closes from

        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        GlobalVariables.cnn.Close()

        If originalText <> NameTextBox.Text Then
            MsgBox("You've changed the name of the entity, you can not delete an unknown entity")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Are you sure you want to delete " & GlobalVariables.Clicked & "?", "Delete ", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If

        query = "DELETE FROM `AdditionalResources` WHERE (`Name` = '" & GlobalVariables.Clicked & "')"
        Dim resourcecmd As New OleDbCommand(query, GlobalVariables.cnn)
        query = "DELETE FROM `Entity-ResourceLink` WHERE (`ResourceID` ='" & GlobalVariables.Clicked & "' )"
        Dim linkingcmd As New OleDbCommand(query, GlobalVariables.cnn)

        Dim response As Integer
        GlobalVariables.cnn.Open()
        Dim linkresponse = linkingcmd.ExecuteNonQuery()
        response = resourcecmd.ExecuteNonQuery
        GlobalVariables.cnn.Close()

        NotifyIcon1.ShowBalloonTip(500, "Deleted", response & " Entities and " & linkresponse & " links Deleted", ToolTipIcon.Info)

        Me.Close()
        FormHome.Show()
    End Sub

    Sub retest()

        If originalText <> NameTextBox.Text Then

            Dim Table_ As String = "ExistingEntities"

            Dim query As String

            query = "SELECT Name from [AdditionalResources] WHERE (Name = '" & NameTextBox.Text & "');"

            Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
            Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
            data.Fill(ds, Table_)

            If ds.Tables(Table_).Rows.Count = 0 Then
                LblDuplicate.Text = "New Entity"
                LblDuplicate.BackColor = Color.LightGreen
            End If
            If ds.Tables(Table_).Rows.Count = 1 Then
                LblDuplicate.Text = "Duplicate Entity"
                LblDuplicate.BackColor = Color.Red
                ds.Tables(Table_).Clear()
            End If

        Else
            LblDuplicate.Text = "NO Change"
            LblDuplicate.BackColor = Color.Yellow
        End If

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        retest()
    End Sub
End Class