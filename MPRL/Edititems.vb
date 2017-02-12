Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class Edititems
    Dim ds As New DataSet                       'defines dataset for data table
    Dim query As String

    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)
    Dim originalText As String                   'stores original name



    Private Sub edititems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Table_ As String = "MachineTool"
        cnn.Open()

        '''loads inform for selected item based on item type
        If GlobalVariables.Click = "PPE" Then
            query = "SELECT Name, Description, ImageURL From PPE Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.click = "Machines" Then
            query = "SELECT Name,  Description, ImageURL From Machines Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Operations" Then
            query = "SELECT Name, Description, ImageURL From Operations Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Setups" Then
            query = "SELECT Name, Description, ImageURL From Setups Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.click = "Machine Tools" Then
            query = "SELECT Name, Description, ImageURL From MachineTools Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        End If

        Dim cmd As New OleDbCommand(query, cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                                'This inserts the returned data into the table name defined above in a useable matrix format

        Label5.Text = "Edit " & ds.Tables(Table_).Rows(0)("Name")           'states what item is being edited
        PictureBox1.ImageLocation = Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL") 'setes pic to item pic
        DescriptionTextBox.Text = ds.Tables(Table_).Rows(0)("Description")   'sets description to items description                       '
        NameTextBox.Text = ds.Tables(Table_).Rows(0)("Name")                  'sets name text cox to items name

        cnn.Close()
        originalText = NameTextBox.Text                                        'stores items original name
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        ''' opes a file dialog to browse for item image
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp"              ' limits file types shown
        PictureBox1.ImageLocation = OpenFileDialog1.FileName            ' sets image to browse location
    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        ''' checks for correct info then updates the databas with edited info
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

        If originalText <> NameTextBox.Text Then                    'checks to see if name has been changed
            MessageBox.Show("Currently the name can not be edited. If it must be changed then delete thie item and add a new one with the correct name * note any relationships will have to be added again")
            NameTextBox.Text = originalText                         'resets name to original name
            Exit Sub
        End If

        'checks to make sure item should be edited
        Dim result As Integer = MessageBox.Show("Are you sure you want to edit " & GlobalVariables.Clicked & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            PictureBox1.ImageLocation = Replace(PictureBox1.ImageLocation, Application.StartupPath, "") 'shortens image location to application startup path
            Dim query As String

            'updates item info based on item type
            If GlobalVariables.Click = "PPE" Then
                query = "Update `PPE` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PictureBox1.ImageLocation & "' WHERE ((name ='" & GlobalVariables.Clicked & "'))"
            ElseIf GlobalVariables.Click = "Machines" Then
                query = "Update `Machines' Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PictureBox1.ImageLocation & "' WHERE (( name ='" & GlobalVariables.Clicked & "'))"
            ElseIf GlobalVariables.Click = "Operations" Then
                query = "Update `Operations` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PictureBox1.ImageLocation & "' WHERE (( name = '" & GlobalVariables.Clicked & "'))"
            ElseIf GlobalVariables.Click = "Setups" Then
                query = "Update `Setups` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PictureBox1.ImageLocation & "' WHERE ((name ='" & GlobalVariables.Clicked & "'))"
            ElseIf GlobalVariables.Click = "Machine Tools" Then
                query = "Update `MachineTools` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PictureBox1.ImageLocation & "' WHERE ((name = '" & GlobalVariables.Clicked & "'))"
            End If

            Dim cmd As New OleDbCommand(query, cnn)
            Dim response As Integer

            cnn.Open()

            response = cmd.ExecuteNonQuery()

            cnn.Close()

            Me.Close()
            FormHome.Hide()

            GlobalVariables.fromadd = True                   'sets form add to true to hide previous button in opened page
            'open edited item based on item type
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '''deletes item from the database
        cnn.Close()
        'double checks that the item should be deleted
        Dim result As Integer = MessageBox.Show("Are you sure you want to edit " & GlobalVariables.Clicked & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If

        'deletes item based on item types
        If GlobalVariables.Click = "PPE" Then
            query = "DELETE FROM `PPE` WHERE (name ='" & GlobalVariables.Clicked & "')"
        ElseIf GlobalVariables.Click = "Machines" Then
            query = "DELETE FROM `Machines` WHERE (( name ='" & GlobalVariables.Clicked & "'))"
        ElseIf GlobalVariables.Click = "Operations" Then
            query = "DELETE FROM `Operations` WHERE (( name = '" & GlobalVariables.Clicked & "'))"
        ElseIf GlobalVariables.Click = "Setups" Then
            query = "DELETE FROM `Setups` WHERE ((name ='" & GlobalVariables.Clicked & "'))"
        ElseIf GlobalVariables.Click = "Machine Tools" Then
            query = "DELETE FROM `MachineTools` WHERE ((name = '" & GlobalVariables.Clicked & "'))"
        End If

        Dim cmd As New OleDbCommand(query, cnn)
        Dim response As Integer

        cnn.Open()

        response = cmd.ExecuteNonQuery()
        cnn.Close()
        Me.Close()
        FormHome.Show()
    End Sub
End Class