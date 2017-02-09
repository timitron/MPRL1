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

    Private Sub MachiningMethod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblTitle.Text = MachiningMethod

        Dim startpoint As New Point(40, 600)
        CustFunctions.SetImage(cnn, "Operation", MachiningMethod, PictureOverview, ds)
        CustFunctions.Resources(cnn, "Operation", MachiningMethod, LstResources, ds)



    End Sub

    Private Sub BttnPrint_Click(sender As Object, e As EventArgs) Handles BttnPrint.Click

        Dim webAddress As String = Application.StartupPath & "\printfile.html"
        Process.Start(webAddress)

    End Sub


    Private Sub LstResources_DoubleClick(sender As Object, e As EventArgs) Handles LstResources.DoubleClick
        CustFunctions.ResourceDoubleClickHandler(LstResources, ds)
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
        If GlobalVariables.MethodStart = True Then
            Dim newform
            newform = FormMachiningMethodsDisplay

            newform.Show()

            GlobalVariables.CloseAll = False
            Me.Close()
            GlobalVariables.CloseAll = True
        Else
            Global.MPRL.GlobalVariables.Click = GlobalVariables.prevMachineTool

            Dim newform
            newform = FormMachineToolDetails
            newform.Show()

            GlobalVariables.CloseAll = False
            Me.Close()
            GlobalVariables.CloseAll = True
        End If
    End Sub
End Class