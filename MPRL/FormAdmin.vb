Public Class FormAdmin


    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = GlobalVariables.version
        TextBox2.Text = GlobalVariables.webaddress

    End Sub
End Class