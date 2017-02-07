Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class AddItem
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)

    Private Sub AddPPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = "\Images\default\noimage.jpg"
        Label5.Text = "Add " & GlobalVariables.additem
        DescriptionTextBox.Text = "Description Goes Here"
        NameTextBox.Text = ""
    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        If NameTextBox.Text = "" Then
            MessageBox.Show("You must enter a " & GlobalVariables.additem & " name.")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Are you sure you want to add " & NameTextBox.Text & " to " & GlobalVariables.additem & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then




            Dim query As String

            If GlobalVariables.additem = "PPE" Then
                query = "insert into [PPE](Name, Description, Imageurl) values('" & NameTextBox.Text & "','" & DescriptionTextBox.Text & "', '" & PictureBox1.ImageLocation & "')"
                ' ElseIf GlobalVariables.additem = "Machine Tools" Then
            ElseIf GlobalVariables.additem = "Machines" Then
                query = "INSERT INTO [Machines] (Name, MachineRoom, MachineDescription, EntityType, ImageURL) VALUES ('" & NameTextBox.Text & "', 'Rogers118', '" & DescriptionTextBox.Text & "', 'Machines', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.additem = "Machining Method" Then
                query = "INSERT INTO [MachiningMethods] (`Name`, `Description`, `EntityType`,  `ImageURL`) VALUES ('" & NameTextBox.Text & "', '" & DescriptionTextBox.Text & "', 'Machining Method', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.additem = "Clamping Method" Then
                query = "INSERT INTO [ClampingMethods] (`Name`, `ClampingDescription`, `ImageURL`) VALUES ('" & NameTextBox.Text & "','" & DescriptionTextBox.Text & "', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.additem = "Machine Tools" Then
                query = "INSERT INTO [MachineTools] (`Name`, `Description`, `ImageURL`) VALUES ('" & NameTextBox.Text & "','" & DescriptionTextBox.Text & "', '" & PictureBox1.ImageLocation & "')"
            End If

            Dim cmd As New OleDbCommand(query, cnn)
                Dim response As Integer

                cnn.Open()


                response = cmd.ExecuteNonQuery()

                cnn.Close()


            Me.Close()

        End If
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp"
        PictureBox1.ImageLocation = OpenFileDialog1.FileName

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionTextBox.TextChanged

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub
End Class