Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net


Public Class FormMachiningMethod

    'Get what to open from the global click variable
    Dim MachiningMethod As String = Global.MPRL.GlobalVariables.Click
    Dim ds As New DataSet                       'defines dataset for data table

    Dim cnnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\MPRL.accdb"
    Dim cnn As OleDbConnection = New OleDbConnection(cnnString)

    Dim printfile As New System.IO.StreamWriter(Application.StartupPath & "\printfile.html", False)
    Dim htmlprint As String = ""
    Dim url As String = ""
    Private Sub MachiningMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTitle.Text = MachiningMethod

        Dim startpoint As New Point(40, 600)
        CustFunctions.SetImage(cnn, "MachiningMethod", MachiningMethod, PictureOverview, ds, htmlprint)
        CustFunctions.Resources(cnn, "MachiningMethod", MachiningMethod, LstResources, ds)
        CustFunctions.Instructions(cnn, "MachiningMethod", MachiningMethod, startpoint, 90, ds, htmlprint, Me)

        printfile.Write(htmlprint)
        printfile.Close()

    End Sub

    Private Sub BttnPrint_Click(sender As Object, e As EventArgs) Handles BttnPrint.Click

        Dim webAddress As String = Application.StartupPath & "\printfile.html"
        Process.Start(webAddress)

    End Sub


    Private Sub LstResources_DoubleClick(sender As Object, e As EventArgs) Handles LstResources.DoubleClick
        CustFunctions.ResourceDoubleClickHandler(LstResources, ds)
    End Sub


End Class