Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class FormSetup
    'Get what to open from the global click variable
    Dim Setup As String = Global.MPRL.GlobalVariables.Click

    Dim ds As New DataSet                       'defines dataset for data table
    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)


    Private Sub FormClampingMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        Me.Padding.Left.Equals((screenWidth - GlobalVariables.FormWidth) / 2)
        Me.Padding.Right.Equals((screenWidth - GlobalVariables.FormWidth) / 2)

        GroupBox1.Width.Equals(GlobalVariables.FormWidth)

        GroupBox1.Location.X.Equals((screenWidth - GroupBox1.Width) / 2)
        GroupBox1.Location.Y.Equals(10)

        PictureOverview.Width.Equals(GlobalVariables.FormWidth - GlobalVariables.FormBuffer * 2)
        PictureOverview.Location.X.Equals(GlobalVariables.FormBuffer)

        LstResources.Width.Equals(GlobalVariables.FormWidth - GlobalVariables.FormBuffer * 2)
        LstResources.Location.X.Equals(GlobalVariables.FormBuffer)

        CustFunctions.SetImage(cnn, "Setup", Setup, PictureOverview, ds)
        CustFunctions.Resources(cnn, "Setup", Setup, LstResources, ds)

    End Sub


    Private Sub LstResources_doubleclick(sender As Object, e As EventArgs)
        Dim index As Integer = LstResources.FocusedItem.Index

        Try
            Dim webAddress As String = ds.Tables("Resources").Rows(index)("Hyperlink")
            Process.Start(webAddress)
        Catch
            MsgBox("URL not found or not formatted correctly")
        End Try



    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If GlobalVariables.CloseAll = True Then
            FormHome.Close()
        End If

    End Sub
    Private Sub BtnEditResources_Click(sender As Object, e As EventArgs) Handles BtnEditResources.Click
        Global.MPRL.GlobalVariables.Click = Setup
        GlobalVariables.Clicked = "Setup"
        Dim newform
        newform = FormAddResourceLink
        newform.Show()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        FormHome.Show()
        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Global.MPRL.GlobalVariables.Click = GlobalVariables.prevMachineTool

        Dim newform
        newform = FormMachineToolDetails
        newform.Show()

        GlobalVariables.CloseAll = False
        Me.Close()
        GlobalVariables.CloseAll = True

    End Sub
End Class