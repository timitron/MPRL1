Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Imports System.Timers
Imports System.Drawing

Public Class AddItem

    Dim ds As New DataSet   'defines dataset for data table

    Dim responsetime As Integer = 0

    Private Sub AddPPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.ImageLocation = Application.StartupPath & "\Images\default\noimage.jpg"
        PctureboxIcon.ImageLocation = Application.StartupPath & "\Images\default\noimage.jpg"
        Label5.Text = "Add " & GlobalVariables.Click
        DescriptionTextBox.Text = "Description Goes Here"
        NameTextBox.Text = ""

        If GlobalVariables.Click = "PPE" Or GlobalVariables.Click = "Features" Then
            PictureBox1.Enabled = False
            Browse.Enabled = False
        End If

    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click

        'check to see if it is a duplicate link
        If LblDuplicate.Text.Equals("Duplicate Entity") Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "Duplicate Entity", ToolTipIcon.Info)
            Exit Sub
        End If


        If CustFunctions.IsValidImage(PictureBox1.ImageLocation) = False Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "Not a Valid Image", ToolTipIcon.Info)
            Exit Sub
        End If

        If CustFunctions.IsValidImage(PctureboxIcon.ImageLocation) = False Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "Not a Valid Image", ToolTipIcon.Info)
            Exit Sub
        End If

        If NameTextBox.Text = "" Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "You must enter a " & GlobalVariables.Click & " name.", ToolTipIcon.Info)
            Exit Sub
        End If

        If DescriptionTextBox.Text = "" Then
            DescriptionTextBox.Text = "Description Goes Here"
        End If




        Dim result As Integer = MessageBox.Show("Are you sure you want to add " & NameTextBox.Text & " to " & GlobalVariables.Click & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then


            'save picture if it is not inside the folder alread

            Dim folder As String

            If GlobalVariables.Click = "Machine Tools" Then
                folder = "MachineTools"
            Else
                folder = GlobalVariables.Click
            End If


            If GlobalVariables.Click <> "PPE" And GlobalVariables.Click <> "Features" Then
                Dim FileToSaveAs As String = System.IO.Path.Combine(Application.StartupPath, "Images", folder, NameTextBox.Text.ToString & ".Jpeg")
                PictureBox1.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
                PictureBox1.ImageLocation = FileToSaveAs
                PictureBox1.Refresh()
            End If

            'if this image already exists this will cause an error
            Dim FileToSaveAs1 As String = System.IO.Path.Combine(Application.StartupPath, "Images", folder, NameTextBox.Text.ToString & "-icon" & ".Jpeg")
            PctureboxIcon.Image.Save(FileToSaveAs1, System.Drawing.Imaging.ImageFormat.Jpeg)
            PctureboxIcon.ImageLocation = FileToSaveAs1
            PctureboxIcon.Refresh()


            GlobalVariables.Clicked = NameTextBox.Text
            PictureBox1.ImageLocation = Replace(PictureBox1.ImageLocation, Application.StartupPath, "")
            PctureboxIcon.ImageLocation = Replace(PctureboxIcon.ImageLocation, Application.StartupPath, "")



            Dim query As String

            If GlobalVariables.Click = "PPE" Then
                query = "insert into [PPE](Name, Description, Imageurl) values('" & NameTextBox.Text & "','" & DescriptionTextBox.Text & "', '" & PctureboxIcon.ImageLocation & "')"
            ElseIf GlobalVariables.Click = "Machines" Then
                query = "INSERT INTO [Machines] (Name, Description, ImageURL, DetailURL) VALUES ('" & NameTextBox.Text & "', '" & DescriptionTextBox.Text & "', '" & PctureboxIcon.ImageLocation & "', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.Click = "Operations" Then
                query = "INSERT INTO [Operations] (`Name`, `Description`, `ImageURL`, DetailURL) VALUES ('" & NameTextBox.Text & "', '" & DescriptionTextBox.Text & "', '" & PctureboxIcon.ImageLocation & "', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.Click = "Setups" Then
                query = "INSERT INTO [Setups] (`Name`, `Description`, `ImageURL`, DetailURL) VALUES ('" & NameTextBox.Text & "','" & DescriptionTextBox.Text & "', '" & PctureboxIcon.ImageLocation & "', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.Click = "Machine Tools" Then
                query = "INSERT INTO [MachineTools] (`Name`, `Description`, `ImageURL`, DetailURL) VALUES ('" & NameTextBox.Text & "', '" & DescriptionTextBox.Text & "', '" & PctureboxIcon.ImageLocation & "', '" & PictureBox1.ImageLocation & "')"
            ElseIf GlobalVariables.Click = "Features" Then
                query = "INSERT INTO [Features] (`Name`, `Description`, `ImageURL`) VALUES ('" & NameTextBox.Text & "','" & DescriptionTextBox.Text & "', '" & PctureboxIcon.ImageLocation & "')"
            End If

            Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
            Dim response As Integer

            GlobalVariables.cnn.Open()
            response = cmd.ExecuteNonQuery()
            GlobalVariables.cnn.Close()



            Me.Close()

            'don't hide the main form if there is no form to open
            If (GlobalVariables.Click = "PPE" Or GlobalVariables.Click = "Feature") = False Then
                FormHome.Hide()
            End If

            GlobalVariables.fromadd = True
            If GlobalVariables.Click = "Machines" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked

                Dim newform
                newform = FormMachineDetails
                newform.show()
            ElseIf GlobalVariables.Click = "Operations" Then
                Global.MPRL.GlobalVariables.Click = GlobalVariables.Clicked

                Dim newform
                newform = FormOperation
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
            Else
                FormHome.Show()
            End If
        End If
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp|All|*.*"
        OpenFileDialog1.ShowDialog()

        PictureBox1.ImageLocation = OpenFileDialog1.FileName

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        retest()
    End Sub

    Sub retest()

        Dim Table_ As String = "ExistingEntities"

        Dim query As String

        If GlobalVariables.Click = "PPE" Then
            query = "SELECT Name from [PPE] WHERE (Name = '" & NameTextBox.Text & "');"
        ElseIf GlobalVariables.Click = "Machines" Then
            query = "SELECT Name from [Machines] WHERE (Name = '" & NameTextBox.Text & "');"
        ElseIf GlobalVariables.Click = "Operations" Then
            query = "SELECT Name from [Operations] WHERE (Name = '" & NameTextBox.Text & "');"
        ElseIf GlobalVariables.Click = "Setups" Then
            query = "SELECT Name from [Setups] WHERE (Name = '" & NameTextBox.Text & "');"
        ElseIf GlobalVariables.Click = "Machine Tools" Then
            query = "SELECT Name from [MachineTools] WHERE (Name = '" & NameTextBox.Text & "');"
        ElseIf GlobalVariables.Click = "Features" Then
            query = "SELECT Name from [Features] WHERE (Name = '" & NameTextBox.Text & "');"
        End If


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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp|All|*.*"
        OpenFileDialog1.ShowDialog()

        PctureboxIcon.ImageLocation = OpenFileDialog1.FileName
    End Sub


End Class