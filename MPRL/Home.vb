Public Class FormHome
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.AdminBuild = False Then
            MenuStrip1.Visible = False

        End If

    End Sub



    Private Sub ButtonMachineToolFlow_Click(sender As Object, e As EventArgs) Handles ButtonMachineToolFlow.Click
        Dim newform
        newform = FormMachineToolsDisplay
        newform.Show()
    End Sub

    Private Sub ButtonMachiningMethodsFlow_DoubleClick(sender As Object, e As EventArgs) Handles ButtonMachiningMethodsFlow.Click

        Dim newform
        newform = FormMachiningMethodsDisplay
        newform.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtboxTitle.TextChanged

    End Sub
End Class
