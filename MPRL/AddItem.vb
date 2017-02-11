Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class AddItem
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)

    Private Sub AddPPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.ImageLocation = Application.StartupPath & "\Images\default\noimage.jpg"
        Label5.Text = "Add " & GlobalVariables.Click
        DescriptionTextBox.Text = "Description Goes Here"
        NameTextBox.Text = ""
    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        If NameTextBox.Text = "" Then
            MessageBox.Show("You must enter a " & GlobalVariables.Click & " name.")
            Exit Sub
        End If
        If DescriptionTextBox.Text = "" Then
            DescriptionTextBox.Text = "Description Goes Here"
        End If

        If PictureBox1.ImageLocation.StartsWith(Application.StartupPath) = False Then
            MessageBox.Show("Image must be in ""Debug"" folder")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Are you sure you want to add " & NameTextBox.Text & " to " & GlobalVariables.Click & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            GlobalVariables.Clicked = NameTextBox.Text
            PictureBox1.ImageLocation = Replace(PictureBox1.ImageLocation, Application.StartupPath, "")




            Dim query As String

            If GlobalVariables.Click = "PPE" Then
                query = "insert into [PPE](Name, Description, Imageurl) values('" & NameTextBox.Text & "','" & DescriptionTextBox.Text & "', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.Click = "Machines" Then
                query = "INSERT INTO [Machines] (Name, MachineRoom, Description, EntityType, ImageURL) VALUES ('" & NameTextBox.Text & "', 'Rogers118', '" & DescriptionTextBox.Text & "', 'Machines', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.Click = "Operations" Then
                query = "INSERT INTO [Operations] (`Name`, `Description`, `EntityType`,  `ImageURL`) VALUES ('" & NameTextBox.Text & "', '" & DescriptionTextBox.Text & "', 'Operations', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.Click = "Setups" Then
                query = "INSERT INTO [Setups] (`Name`, `Description`, `ImageURL`) VALUES ('" & NameTextBox.Text & "','" & DescriptionTextBox.Text & "', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.Click = "Machine Tools" Then
                query = "INSERT INTO [MachineTools] (`Name`, `Description`, `ImageURL`) VALUES ('" & NameTextBox.Text & "','" & DescriptionTextBox.Text & "', '" & PictureBox1.ImageLocation & "')"
            End If

            Dim cmd As New OleDbCommand(query, cnn)
            Dim response As Integer

            cnn.Open()


            response = cmd.ExecuteNonQuery()

            cnn.Close()



            Me.Close()
            FormHome.Hide()
            GlobalVariables.fromadd = True
            If GlobalVariables.Click = "Machines" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked

                Dim newform
                newform = FormMachineDetails
                newform.show()
            ElseIf GlobalVariables.Click = "Operations" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked

                Dim newform
                newform = FormMachiningMethod
                newform.show()

            ElseIf GlobalVariables.Click = "Setups" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked

                Dim newform
                newform = FormSetup
                newform.show()
            ElseIf GlobalVariables.Click = "Machine Tools" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked

                Dim newform
                newform = FormMachineToolDetails
                newform.show()
            End If

        End If
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp"
        PictureBox1.ImageLocation = OpenFileDialog1.FileName

    End Sub




End Class