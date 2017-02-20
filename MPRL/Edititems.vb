Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class Edititems
    Dim ds As New DataSet                       'defines dataset for data table
    Dim query As String

    Dim originalText As String



    Private Sub edititems_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Table_ As String = "MachineTool"

        GlobalVariables.cnn.Open()

        If GlobalVariables.Click = "PPE" Then
            query = "SELECT Name, Description, ImageURL From PPE Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Machines" Then
            query = "SELECT Name,  Description, ImageURL From Machines Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Operations" Then
            query = "SELECT Name, Description, ImageURL From Operations Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Setups" Then
            query = "SELECT Name, Description, ImageURL From Setups Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Machine Tools" Then
            query = "SELECT Name, Description, ImageURL From MachineTools Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Features" Then
            query = "SELECT Name, Description, ImageURL From Features Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        End If

        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format
        Label5.Text = "Edit " & ds.Tables(Table_).Rows(0)("Name")
        PictureBox1.ImageLocation = Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL")
        DescriptionTextBox.Text = ds.Tables(Table_).Rows(0)("Description")
        NameTextBox.Text = ds.Tables(Table_).Rows(0)("Name")

        GlobalVariables.cnn.Close()
        originalText = NameTextBox.Text
    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        If NameTextBox.Text = "" Then
            MessageBox.Show("You must enter a " & GlobalVariables.Click & " name.")
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "No resource selected", ToolTipIcon.Info)
            Exit Sub
        End If

        If DescriptionTextBox.Text = "" Then
            DescriptionTextBox.Text = "Description Goes Here"
            Exit Sub
        End If

        If PictureBox1.ImageLocation.StartsWith(Application.StartupPath) = False Then
            MessageBox.Show("Image must be in ""Debug"" folder")
            Exit Sub
        End If

        If originalText <> NameTextBox.Text Then
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "No resource selected", ToolTipIcon.Info)
            MessageBox.Show("Currently the name can not be edited. If it must be changed then delete thie item and add a new one with the correct name * note any relationships will have to be added again")
            NameTextBox.Text = originalText
            Exit Sub

        End If

        Dim result As Integer = MessageBox.Show("Are you sure you want to edit " & GlobalVariables.Clicked & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then
            PictureBox1.ImageLocation = Replace(PictureBox1.ImageLocation, Application.StartupPath, "")




            Dim query As String

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
            ElseIf GlobalVariables.Click = "Features" Then
                query = "Update `Features` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PictureBox1.ImageLocation & "' WHERE ((name = '" & GlobalVariables.Clicked & "'))"
            End If

            Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)
            Dim response As Integer

            GlobalVariables.cnn.Open()

            response = cmd.ExecuteNonQuery()

            GlobalVariables.cnn.Close()


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
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp"
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GlobalVariables.cnn.Close()
        Dim result As Integer = MessageBox.Show("Are you sure you want to delete " & GlobalVariables.Clicked & "?", "Delete?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Dim NumOfRelation As Integer = 1

        Do Until NumOfRelation = 0
            If GlobalVariables.Click = "PPE" Then
                If NumOfRelation = 1 Then
                    query = "DELETE FROM `PPE` WHERE (name ='" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 2
                ElseIf NumOfRelation = 2 Then
                    query = "DELETE FROM `Machine-PPELink` WHERE  (`PPEID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 0
                End If
            ElseIf GlobalVariables.Click = "Machines" Then
                If NumOfRelation = 1 Then
                    query = "DELETE FROM `Machines` WHERE ( name ='" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 2
                ElseIf NumOfRelation = 2 Then
                    query = "DELETE FROM `Machine-PPELink` WHERE (`MachineID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 3
                ElseIf NumOfRelation = 3 Then
                    query = "DELETE FROM `Machine-MachineToolLink` WHERE (`MachineID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 4
                ElseIf NumOfRelation = 4 Then
                    query = "DELETE FROM `Entity-ResourceLink` WHERE (`EntitiesID` ='" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 0
                End If
            ElseIf GlobalVariables.Click = "Operations" Then
                If NumOfRelation = 1 Then
                    query = "DELETE FROM `Operations` WHERE (( name = '" & GlobalVariables.Clicked & "'))"
                    NumOfRelation = 2
                ElseIf NumOfRelation = 2 Then
                    query = "DELETE FROM `MachineTool-OperationsLink` WHERE (`OperationsID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 3
                ElseIf NumOfRelation = 3 Then
                    query = "DELETE FROM `Operation-FeatureLink` WHERE (`OperationID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 4
                ElseIf NumOfRelation = 4 Then
                    query = "DELETE FROM `Entity-ResourceLink` WHERE (`EntitiesID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 0
                End If
            ElseIf GlobalVariables.Click = "Setups" Then
                If NumOfRelation = 1 Then
                    query = "DELETE FROM `Setups` WHERE (name ='" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 2
                ElseIf NumOfRelation = 2 Then
                    query = "DELETE FROM `MachineTool-SetupLink` WHERE (`SetupID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 3
                ElseIf NumOfRelation = 3 Then
                    query = "DELETE FROM `Entity-ResourceLink` WHERE (`EntitiesID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 0
                End If
            ElseIf GlobalVariables.Click = "Machine Tools" Then
                If NumOfRelation = 1 Then
                    query = "DELETE FROM `MachineTools` WHERE (name = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 2
                ElseIf NumOfRelation = 2 Then
                    query = "DELETE FROM `Machine-MachineToolLink` WHERE (`MachineToolID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 3
                ElseIf NumOfRelation = 3 Then
                    query = "DELETE FROM `MachineTool-OperationsLink` WHERE (`MachineToolID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 4
                ElseIf NumOfRelation = 4 Then
                    query = "DELETE FROM `MachineTool-SetupLink` WHERE (`MachineToolID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 5
                ElseIf NumOfRelation = 5 Then
                    query = "DELETE FROM `Entity-ResourceLink` WHERE (`EntitiesID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 0
                End If
            ElseIf GlobalVariables.Click = "Features" Then
                If NumOfRelation = 1 Then
                    query = "DELETE FROM `Features` WHERE (name = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 2
                ElseIf NumOfRelation = 2 Then
                    query = "DELETE FROM `Operation-FeatureLink` WHERE ((`FeatureID` = '" & GlobalVariables.Clicked & "'))"
                    NumOfRelation = 0
                End If
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