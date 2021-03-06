﻿Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net


Public Class EditForm

    Dim ds As New DataSet                       'defines dataset for data table
    Dim query As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'define connection string and create connection object 
        update_filtered_list()

    End Sub


    Private Sub editList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles editList.DoubleClick


        If editList.SelectedItem = Nothing Then
            Exit Sub
        End If

        GlobalVariables.Clicked = editList.SelectedItem

        If GlobalVariables.Click = "Resources" Then
            Dim newform = FormResource
            FormResource.Show()
        Else
            Dim newform = Edititems
            Edititems.Show()
        End If
        Me.Close()



    End Sub

    Sub update_filtered_list()
        Dim Table_ As String



        'open connection to database and execute the query string
        GlobalVariables.cnn.Open()
        Label2.Text = "Choose " & GlobalVariables.Click & " to edit."
        If GlobalVariables.Click = "PPE" Then
            Table_ = "PPE"   'defines table inside the dataset to store information recieved from data connections
            query = "SELECT Name FROM PPE WHERE (Name Like '%" & Txtboxfilter.Text & "%');"    'data connection querry this must be run through the oledb command interpreter before executing it on the connection
        ElseIf GlobalVariables.Click = "Setups" Then
            Table_ = "Setups"
            query = "SELECT Name FROM Setups WHERE (Name Like '%" & Txtboxfilter.Text & "%');"
        ElseIf GlobalVariables.Click = "Operations" Then
            Table_ = "Operations"
            query = "SELECT Name FROM Operations WHERE (Name Like '%" & Txtboxfilter.Text & "%');"
        ElseIf GlobalVariables.Click = "Machine Tools" Then
            Table_ = "MachineTools"
            query = "Select Name FROM MachineTools WHERE (Name Like '%" & Txtboxfilter.Text & "%');"
        ElseIf GlobalVariables.Click = "Machines" Then
            Table_ = "Machines"
            query = "SELECT Name FROM Machines WHERE (Name Like '%" & Txtboxfilter.Text & "%');"
        ElseIf GlobalVariables.Click = "Resources" Then
            Table_ = "Resources"
            query = "SELECT Name FROM AdditionalResources WHERE (Name Like '%" & Txtboxfilter.Text & "%');"
        ElseIf GlobalVariables.Click = "Features" Then
            Table_ = "Features"
            query = "SELECT Name FROM Features WHERE (Name Like '%" & Txtboxfilter.Text & "%');"
        End If

        If IsNothing(ds.Tables(Table_)) Then

        Else
            ds.Tables(Table_).Clear()
        End If

        editList.Items.Clear()




        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)



        ' Dim t1 As DataTable = ds.Tables(Table_)
        Dim row As DataRow

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            ' Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'add the new item to the list view
            editList.Items.Add(row(0).ToString) 'NextListItem)

        Next
        editList.Sorted = True
        editList.Update()
        GlobalVariables.cnn.Close()



    End Sub

    Private Sub Txtboxfilter_TextChanged(sender As Object, e As EventArgs) Handles Txtboxfilter.TextChanged
        update_filtered_list()

    End Sub


End Class