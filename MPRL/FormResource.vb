Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class FormResource
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)
    Dim query As String

    Private Sub FormResource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = "Add Resource"                                        'states what is being added
        TypeTextBox.Text = "Type"                                   'sets description to default
        NameTextBox.Text = ""
        AddressTextBox.Text = ""
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        '''opens file dialog to browse for image
        OpenFileDialog1.ShowDialog()
        AddressTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        ''' checks for correct info then updates databasewith added item
        If NameTextBox.Text = "" Then                                                   'checks that a name has been created
            MessageBox.Show("You must enter a resource name.")
            Exit Sub
        End If

        If AddressTextBox.Text = "" Then                                                   'checks that a name has been created
            MessageBox.Show("You must enter a resource Address.")
            Exit Sub
        End If

        If TypeTextBox.Text = "" Then                        'sets description to default if none has been entered
            TypeTextBox.Text = "Description Goes Here"
        End If

        If AddressTextBox.Text.StartsWith(Application.StartupPath) = False Then '' check that imge comes from apllication start path
            If AddressTextBox.Text.StartsWith("www.") = False Then
                MessageBox.Show("Address Must be a web address or a file address that is located in debug")
                Exit Sub
            End If
        End If

        'checks to make sure item should be added
        Dim result As Integer = MessageBox.Show("Are you sure you want to add " & NameTextBox.Text & " to resources?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            If AddressTextBox.Text.StartsWith(Application.StartupPath) = False Then
                AddressTextBox.Text = Replace(AddressTextBox.Text, Application.StartupPath, "") 'shortens image location to application startup path
            End If

            query = "INSERT INTO `AdditionalResources` (`Name`, `Type`, `Hyperlink`) VALUES ('" & NameTextBox.Text & "', '" & TypeTextBox.Text & "', '" & AddressTextBox.Text & "')"

            Dim cmd As New OleDbCommand(query, cnn)
            Dim response As Integer

            cnn.Open()

            response = cmd.ExecuteNonQuery()

            cnn.Close()

            Me.Close()                                              'closes from

            GlobalVariables.fromadd = True                          'sets form add to true to hide previous button in opened page

        End If
    End Sub
End Class