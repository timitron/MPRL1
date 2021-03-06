﻿Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net

Public Class Edititems
    Dim ds As New DataSet                       'defines dataset for data table
    Dim query As String

    Dim originalText As String



    Private Sub edititems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Table_ As String = "EntityInfo"



        If GlobalVariables.Click = "PPE" Then
            query = "SELECT Name, Description, ImageURL From PPE Where (([Name] = '" & GlobalVariables.Clicked & "'));"
            BtnBrowse.Enabled = False
        ElseIf GlobalVariables.Click = "Machines" Then
            query = "SELECT Name,  Description, ImageURL, DetailURL From Machines Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Operations" Then
            query = "SELECT Name, Description, ImageURL, DetailURL From Operations Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Setups" Then
            query = "SELECT * From Setups Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Machine Tools" Then
            query = "SELECT Name, Description, ImageURL, DetailURL From MachineTools Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        ElseIf GlobalVariables.Click = "Features" Then
            BtnBrowse.Enabled = False
            query = "SELECT Name, Description, ImageURL From Features Where (([Name] = '" & GlobalVariables.Clicked & "'));"
        End If

        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)

        GlobalVariables.cnn.Open()
        Dim data As New OleDbDataAdapter(cmd)
        data.Fill(ds, Table_)
        GlobalVariables.cnn.Close()

        Label5.Text = "Edit " & ds.Tables(Table_).Rows(0)("Name")
        PctureboxIcon.ImageLocation = Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL")
        DescriptionTextBox.Text = ds.Tables(Table_).Rows(0)("Description")
        NameTextBox.Text = ds.Tables(Table_).Rows(0)("Name")

        'no detail image for PPE or Features 
        If GlobalVariables.Click <> "PPE" And GlobalVariables.Click <> "Features" Then
            PictureBox1.ImageLocation = Application.StartupPath & ds.Tables(Table_).Rows(0)("DetailURL")
        End If

        originalText = NameTextBox.Text
    End Sub

    Private Sub SubmitChanges_Click(sender As Object, e As EventArgs) Handles SubmitChanges.Click
        'locates changes and updates database 

        Dim Table_ As String = "EntityInfo"

        If NameTextBox.Text = "" Then
            MessageBox.Show("You must enter a " & GlobalVariables.Click & " name.")
            NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "No resource selected", ToolTipIcon.Info)
            Exit Sub
        End If

        If DescriptionTextBox.Text = "" Then
            DescriptionTextBox.Text = "Description Goes Here"
            Exit Sub
        End If

        If GlobalVariables.Click <> "PPE" And GlobalVariables.Click <> "Features" Then

            If CustFunctions.IsValidImage(PictureBox1.ImageLocation) = False Then
                NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "Not a Valid Image", ToolTipIcon.Info)
                Exit Sub
            End If
        End If


        If CustFunctions.IsValidImage(PctureboxIcon.ImageLocation) = False Then
                NotifyIcon1.ShowBalloonTip(500, "NO CHANGE", "Not a Valid Image", ToolTipIcon.Info)
                Exit Sub
            End If


        'if the icon has changed and it's not in the start up folder 
        If PctureboxIcon.ImageLocation <> Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL") Then

            'delete old picture
            Try
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL"))
            Catch ex As Exception

            End Try


            Dim folder As String
            If GlobalVariables.Click = "Machine Tools" Then
                folder = "MachineTools"
            Else
                folder = GlobalVariables.Click
            End If

            Dim FileToSaveAs As String = System.IO.Path.Combine(Application.StartupPath, "Images", folder, NameTextBox.Text.ToString & "-icon" & ".Jpeg")
            PctureboxIcon.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
            PctureboxIcon.ImageLocation = FileToSaveAs
            PctureboxIcon.Refresh()

        End If

        'if the detailed image has changed and it's not in the start up folder 
        If GlobalVariables.Click <> "PPE" And GlobalVariables.Click <> "Features" Then
            'if this picture has changed and it's not in the start up folder 
            If PictureBox1.ImageLocation <> Application.StartupPath & ds.Tables(Table_).Rows(0)("DetailURL") Then
                'delete old picture
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("DetailURL"))

                Dim folder As String
                If GlobalVariables.Click = "Machine Tools" Then
                    folder = "MachineTools"
                Else
                    folder = GlobalVariables.Click
                End If

                Dim FileToSaveAs As String = System.IO.Path.Combine(Application.StartupPath, "Images", folder, NameTextBox.Text.ToString & ".Jpeg")
                PictureBox1.Image.Save(FileToSaveAs, System.Drawing.Imaging.ImageFormat.Jpeg)
                PictureBox1.ImageLocation = FileToSaveAs
                PictureBox1.Refresh()

            End If
        End If

        'confirm changes
        Dim result As Integer = MessageBox.Show("Are you sure you want to edit " & GlobalVariables.Clicked & "?", "Submit Changes?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        ElseIf result = DialogResult.Yes Then

            'cut off application startup path from the filename 
            PictureBox1.ImageLocation = Replace(PictureBox1.ImageLocation, Application.StartupPath, "")
            PctureboxIcon.ImageLocation = Replace(PctureboxIcon.ImageLocation, Application.StartupPath, "")

            Dim query As String

            If GlobalVariables.Click = "PPE" Then
                query = "Update `PPE` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PctureboxIcon.ImageLocation & "' WHERE ((name ='" & GlobalVariables.Clicked & "'))"
            ElseIf GlobalVariables.Click = "Machines" Then
                query = "Update `Machines` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PctureboxIcon.ImageLocation & "', `DetailURL` = '" & PictureBox1.ImageLocation & "' WHERE (( name ='" & GlobalVariables.Clicked & "'))"
            ElseIf GlobalVariables.Click = "Operations" Then
                query = "Update `Operations` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PctureboxIcon.ImageLocation & "', `DetailURL` = '" & PictureBox1.ImageLocation & "' WHERE (( name = '" & GlobalVariables.Clicked & "'))"
            ElseIf GlobalVariables.Click = "Setups" Then
                query = "Update `Setups` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PctureboxIcon.ImageLocation & "', `DetailURL` = '" & PictureBox1.ImageLocation & "' WHERE ((name ='" & GlobalVariables.Clicked & "'))"
            ElseIf GlobalVariables.Click = "Machine Tools" Then
                query = "Update `MachineTools` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PctureboxIcon.ImageLocation & "', `DetailURL` = '" & PictureBox1.ImageLocation & "' WHERE ((name = '" & GlobalVariables.Clicked & "'))"
            ElseIf GlobalVariables.Click = "Features" Then
                query = "Update `Features` Set  `Description` = '" & DescriptionTextBox.Text & "', `ImageURL` = '" & PctureboxIcon.ImageLocation & "' WHERE ((name = '" & GlobalVariables.Clicked & "'))"
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



    Private Sub Delete_Entity(sender As Object, e As EventArgs) Handles BtnDelete.Click
        GlobalVariables.cnn.Close()

        Dim Table_ As String = "EntityInfo"

        Dim result As Integer = MessageBox.Show("Are you sure you want to delete " & GlobalVariables.Clicked & "?", "Delete?", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Exit Sub
        End If

        Dim imagequery As String = ""
        Dim NumOfRelation As Integer = 1

        Do Until NumOfRelation = 0
            If GlobalVariables.Click = "PPE" Then
                If NumOfRelation = 1 Then
                    query = "DELETE FROM `PPE` WHERE (name ='" & GlobalVariables.Clicked & "')"
                    Try
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL"))
                    Catch ex As Exception

                    End Try

                    NumOfRelation = 2
                ElseIf NumOfRelation = 2 Then
                    query = "DELETE FROM `Machine-PPELink` WHERE  (`PPEID` = '" & GlobalVariables.Clicked & "')"
                    NumOfRelation = 0
                End If
            ElseIf GlobalVariables.Click = "Machines" Then
                If NumOfRelation = 1 Then
                    query = "DELETE FROM `Machines` WHERE ( name ='" & GlobalVariables.Clicked & "')"
                    Try
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("DetailURL"))
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL"))
                    Catch ex As Exception

                    End Try

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
                    Try
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("DetailURL"))
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL"))
                    Catch ex As Exception

                    End Try
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
                    Try
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("DetailURL"))
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL"))
                    Catch ex As Exception

                    End Try
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
                    Try
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("DetailURL"))
                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL"))
                    Catch ex As Exception

                    End Try
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
                    Try

                        My.Computer.FileSystem.DeleteFile(Application.StartupPath & ds.Tables(Table_).Rows(0)("ImageURL"))
                    Catch ex As Exception

                    End Try
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
    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp|All|*.*"
        OpenFileDialog1.ShowDialog()

        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub
    Private Sub BrowseIcon_click(sender As Object, e As EventArgs) Handles BtnBrowseIcon.Click
        OpenFileDialog1.Filter = "JPEG|*.jpg|Bitmap|*.bmp|All|*.*"
        OpenFileDialog1.ShowDialog()

        PctureboxIcon.ImageLocation = OpenFileDialog1.FileName
    End Sub
End Class