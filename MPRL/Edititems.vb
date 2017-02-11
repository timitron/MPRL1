﻿Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class Edititems
    Dim ds As New DataSet                       'defines dataset for data table
    Dim query As String

    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)
    Dim originalText As String



    Private Sub edititems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label5.Text = "Edit " & GlobalVariables.Clicked

        Dim Table_ As String = "MachineTool"

        cnn.Open()

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
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format
        Label5.Text = "Edit " & ds.Tables(Table_).Rows(0)("Name")
        PictureBox1.ImageLocation = Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL")
        DescriptionTextBox.Text = ds.Tables(Table_).Rows(0)("Description")
        NameTextBox.Text = ds.Tables(Table_).Rows(0)("Name")

        cnn.Close()
        originalText = NameTextBox.Text
    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        If NameTextBox.Text = "" Then
            MessageBox.Show("You must enter a " & GlobalVariables.Click & " name.")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        cnn.Close()
        Dim result As Integer = MessageBox.Show("Are you sure you want to edit " & GlobalVariables.Clicked & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If

        PictureBox1.ImageLocation = Replace(PictureBox1.ImageLocation, Application.StartupPath, "")
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