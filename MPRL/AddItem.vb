Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class AddItem
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)
    Dim query As String

    Private Sub AddPPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = Application.StartupPath & "\Images\default\noimage.jpg" 'sets image box to default image
        Label5.Text = "Add " & GlobalVariables.Click                                        'states what is being added
        DescriptionTextBox.Text = "Description Goes Here"                                   'sets description to default
        NameTextBox.Text = ""                                                               ' clears name
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        '''opens file dialog to browse for image
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp"             'limits file types that are visiable
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        ''' checks for correct info then updates databasewith added item
        If NameTextBox.Text = "" Then                                                   'checks that a name has been created
            MessageBox.Show("You must enter a " & GlobalVariables.Click & " name.")
            Exit Sub
        End If

        If DescriptionTextBox.Text = "" Then                        'sets description to default if none has been entered
            DescriptionTextBox.Text = "Description Goes Here"
        End If

        If PictureBox1.ImageLocation.StartsWith(Application.StartupPath) = False Then '' check that imge comes from apllication start path
            MessageBox.Show("Image must be in ""Debug"" folder")
            Exit Sub
        End If

        'checks to make sure item should be added
        Dim result As Integer = MessageBox.Show("Are you sure you want to add " & NameTextBox.Text & " to " & GlobalVariables.Click & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            GlobalVariables.Clicked = NameTextBox.Text 'stores item added name so it can open after add
            PictureBox1.ImageLocation = Replace(PictureBox1.ImageLocation, Application.StartupPath, "") 'shortens image location to application startup path

            ''adds the item to database based on item type
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

            Me.Close()                                              'closes from
            FormHome.Hide()

            GlobalVariables.fromadd = True                          'sets form add to true to hide previous button in opened page

            'open added item based on item type
            If GlobalVariables.Click = "Machines" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked 'changes click from type of added item to items name so it can be opened
                Dim newform = FormMachineDetails
                newform.Show()
            ElseIf GlobalVariables.Click = "Operations" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked 'changes click from type of added item to items name so it can be opened
                Dim newform = FormMachiningMethod
                newform.Show()
            ElseIf GlobalVariables.Click = "Setups" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked 'changes click from type of added item to items name so it can be opened
                Dim newform = FormSetup
                newform.Show()
            ElseIf GlobalVariables.Click = "Machine Tools" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked 'changes click from type of added item to items name so it can be opened
                Dim newform = FormMachineToolDetails
                newform.Show()
            End If
        End If
    End Sub
End Class