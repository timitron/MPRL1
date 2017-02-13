Option Strict Off

Imports System.Data.OleDb
Imports System.IO
Imports System.Net
Public Class FormFeedback

    'Get what was open
    Dim Entity As String = GlobalVariables.FeedbackEntity
    Dim EntityType As String = GlobalVariables.FeedbackEntityType
    Dim ds As New DataSet                       'defines dataset for data table
    Dim feedback As Integer
    Private Sub FormFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        feedback = 1
        submit_feedback()
        Me.Close()
    End Sub

    Private Sub BtnNoFeedback_Click(sender As Object, e As EventArgs) Handles BtnNoFeedback.Click
        Me.Close()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        feedback = 0
        submit_feedback()
        Me.Close()
    End Sub

    Sub submit_feedback()

        Dim query As String = "INSERT INTO `Feedback` (`EntityType`, `Entity`, `Useful`) VALUES ('" & EntityType & "' , '" & Entity & "', '" & feedback & "')"
        Dim cmd As New OleDbCommand(query, GlobalVariables.cnn)


        GlobalVariables.cnn.Open()
        Try
            Dim response As Integer = cmd.ExecuteNonQuery()
            NotifyIcon1.ShowBalloonTip(500, "Recorded", "Response Recorded, Thanks! :D", ToolTipIcon.None)
        Catch
            MsgBox("There was an unanticipated error adding this link to the database ")
        End Try


        GlobalVariables.cnn.Close()

    End Sub
End Class