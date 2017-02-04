Public Class FormHome
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.AdminBuild = False Then
            MenuStrip1.Visible = False
        End If

    End Sub



    Private Sub ButtonMachineToolFlow_Click(sender As Object, e As EventArgs) Handles ButtonMachineToolFlow.Click
        GlobalVariables.MethodStart = False

        Dim newform
        newform = FormMachineToolsDisplay
        newform.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonMachiningMethodsFlow_DoubleClick(sender As Object, e As EventArgs) Handles ButtonMachiningMethodsFlow.Click
        GlobalVariables.MethodStart = True

        Dim newform
        newform = FormMachiningMethodsDisplay
        newform.Show()
        Me.Hide()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

End Class
