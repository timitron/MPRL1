Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class FormMachineDetails
    'Get what to open from the global click variable
    Dim Machine As String = Global.MPRL.GlobalVariables.Click
    Dim ds As New DataSet                       'defines dataset for data table

    Private Sub FormMachineDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.fromadd = True Then
            Button1.Hide()
        End If
        LblTitle.Text = Machine

        CustFunctions.SetImage(GlobalVariables.cnn, "Machine", Machine, PictureOverview, ds)

        CustFunctions.Resources(GlobalVariables.cnn, "Machine", Machine, LstResources, ds)

        CustFunctions.PPE(GlobalVariables.cnn, Machine, LstReqPPE, True, ds)
        CustFunctions.PPE(GlobalVariables.cnn, Machine, LstOptPPE, False, ds)

        Dim startpoint = New Point(40, 900)


    End Sub






    Sub fill_resources()
        'define connection string and create connection object 
        Dim Table_ As String = "Resources"   'defines table inside the dataset to store information recieved from data connections
        Dim query As String = "SELECT        AdditionalResources.Name, AdditionalResources.Type, AdditionalResources.Hyperlink FROM            ((AdditionalResources INNER JOIN                         [Entity-ResourceLink] ON AdditionalResources.ID = [Entity-ResourceLink].ResourceID) INNER JOIN                         Machines ON [Entity-ResourceLink].EntitiesID = Machines.Name) WHERE        ([Entity-ResourceLink].Entities = 'Machine') AND (Machines.Name = '" & Machine & "')"

        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)                             'this is the line to interprete the query
        Dim data As New OleDbDataAdapter(cmd)                               'this executes the interpreted query on the connection object and returns it to the da object
        data.Fill(ds, Table_)                                       'This inserts the returned data into the table name defined above in a useable matrix format

        LstResources.View = View.List ' defines the format of the listview

        Dim row As DataRow
        Dim count As Integer = 0        'counter for indexing images

        'for each result in the query creat a new list view item, get the picture from a website and then put 
        'it into a image list And apply the correct image index to the list view item. Finally add the list view item to the list view. 
        For Each row In ds.Tables(Table_).Rows
            Dim NextListItem As New ListViewItem(row(0).ToString) 'create a new list view object to add to the list view window after informatoin has been added to it

            'need to write code to make or apply pre made thumbnails to resources

            'add the new item to the list view
            LstResources.Items.Add(NextListItem)

            'increase count to incriment index 
            count = count + 1

        Next
        LstResources.Update()
    End Sub

    Private Sub BttnPrint_Click(sender As Object, e As EventArgs)

        Dim webAddress As String = Application.StartupPath & "\printfile.html"
        Process.Start(webAddress)

    End Sub

    Private Sub BtnEditOptionalPPE_Click(sender As Object, e As EventArgs) Handles BtnEditOptionalPPE.Click
        Global.MPRL.GlobalVariables.Click = Machine
        Dim newform
        newform = FormEditOptPPE

        newform.Show()
    End Sub

    Private Sub BtnEditReqPPE_Click(sender As Object, e As EventArgs) Handles BtnEditReqPPE.Click
        Global.MPRL.GlobalVariables.Click = Machine
        Dim newform
        newform = FormEditRequiredPPE
        newform.Show()
    End Sub

    Private Sub EBtnEditAdditionalResources_Click(sender As Object, e As EventArgs) Handles EBtnEditAdditionalResources.Click
        Global.MPRL.GlobalVariables.Click = Machine
        GlobalVariables.Clicked = "Machine"
        Dim newform
        newform = FormAddResourceLink
        newform.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormHome.Show()
        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True

    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If GlobalVariables.CloseAll = True Then
            FormHome.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CustFunctions.Get_feedback("Machine", Machine)

        Global.MPRL.GlobalVariables.Click = GlobalVariables.prevMachineTool
        Dim newform
        newform = FormMachineToolDetails
        newform.Show()

        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True
    End Sub
End Class