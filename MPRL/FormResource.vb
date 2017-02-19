Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class FormResource
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)
    Dim query As String
    Dim ds As New DataSet                       'defines dataset for data table

    Dim originalText As String

    Private Sub FormResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.Click = "add" Then
            Label5.Text = "Add Resource"                                        'states what is being added
            TypeTextBox.Text = "Type"                                   'sets description to default
            NameTextBox.Text = ""
            AddressTextBox.Text = ""
            DeleteButton.Hide()

        Else
            Dim Table_ As String = "MachineTool"
            GlobalVariables.cnn.Open()
            query = "SELECT Name, Type, Hyperlink FROM AdditionalResources Where (([Name] = '" & GlobalVariables.Clicked & "'));"
            Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
            Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
            data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

            Label5.Text = "Edit " & ds.Tables(Table_).Rows(0)("Name")                                        '
            TypeTextBox.Text = ds.Tables(Table_).Rows(0)("Type")
            NameTextBox.Text = ds.Tables(Table_).Rows(0)("Name")
            AddressTextBox.Text = ds.Tables(Table_).Rows(0)("Hyperlink")

            GlobalVariables.cnn.Close()
            originalText = NameTextBox.Text
        End If

    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        '''opens file dialog to browse for image
        OpenFileDialog1.ShowDialog()
        AddressTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        ''' checks for correct info then updates databasewith added item
        If NameTextBox.Text = "" Then                                                   'checks that a name has been created
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "You must enter a resource name.", ToolTipIcon.Info)
            Exit Sub
        End If

        If AddressTextBox.Text = "" Then                                                   'checks that a name has been created
            MessageBox.Show("You must enter a resource Address.")
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "You must enter a resource name.", ToolTipIcon.Info)
            Exit Sub
        End If

        If TypeTextBox.Text = "" Then                        'sets description to default if none has been entered
            TypeTextBox.Text = "Description Goes Here"
        End If

        If TypeTextBox.Text = "" Then
            TypeTextBox.Text = "Type"
        End If

        If GlobalVariables.Click <> "add" Then
            If originalText <> NameTextBox.Text Then
                MessageBox.Show("Currently the name can Not be edited. If it must be changed Then delete thie item And add a New one With the correct name * note any relationships will have To be added again")
                NameTextBox.Text = originalText
                Exit Sub
            End If
        End If


        If AddressTextBox.Text.StartsWith(Application.StartupPath) = False Then '' check that imge comes from apllication start path
            If AddressTextBox.Text.StartsWith("www.") = False Then
                MessageBox.Show("Address Must be a web address Or a file address that Is located In debug")
                Exit Sub
            End If
        End If

        'checks to make sure item should be added
        Dim result As Integer = MessageBox.Show("Are you sure you want to add " & NameTextBox.Text & " To resources?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            If AddressTextBox.Text.StartsWith(Application.StartupPath) = False Then
                AddressTextBox.Text = Replace(AddressTextBox.Text, Application.StartupPath, "")
            End If

            If GlobalVariables.Click = "add" Then
                query = " INSERT INTO `AdditionalResources` (`Name`, `Type`, `Hyperlink`) VALUES ('" & NameTextBox.Text & "', '" & TypeTextBox.Text & "', '" & AddressTextBox.Text & "')"
            Else
                query = "UPDATE `AdditionalResources` SET `Name` = '" & NameTextBox.Text & "', `Type` = '" & TypeTextBox.Text & "', `Hyperlink` = '" & AddressTextBox.Text & "' WHERE (name= '" & NameTextBox.Text & "')"
            End If

            Dim cmd As New OleDbCommand(query, cnn)
            Dim response As Integer

            cnn.Open()

            response = cmd.ExecuteNonQuery()

            cnn.Close()

            Me.Close()                                              'closes from

            GlobalVariables.fromadd = True                          'sets form add to true to hide previous button in opened page

        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        GlobalVariables.cnn.Close()
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete " & GlobalVariables.Clicked & "?", "Delete ", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Dim NumOfRelation As Integer = 1

        Do Until NumOfRelation = 0

            If NumOfRelation = 1 Then
                query = "DELETE FROM `AdditionalResources` WHERE (`Name` = '" & GlobalVariables.Clicked & "')"
                NumOfRelation = 2
            ElseIf NumOfRelation = 2 Then
                query = "DELETE FROM `Entity-ResourceLink` WHERE (`ResourceID` ='" & GlobalVariables.Clicked & "' )"
                NumOfRelation = 0
            End If



            Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
            Dim response As Integer

            GlobalVariables.cnn.Open()

            response = cmd.ExecuteNonQuery()
            GlobalVariables.cnn.Close()
        Loop

        Me.Close()
        FormHome.Show()
    End Sub


End Class