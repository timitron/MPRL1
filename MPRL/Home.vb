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

    Private Sub AddToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem6.Click
        GlobalVariables.additem = "PPE"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        GlobalVariables.additem = "Machines"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem2.Click
        GlobalVariables.additem = "Machining Method"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem3.Click
        GlobalVariables.additem = "Clamping Method"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        GlobalVariables.additem = "Machine Tools"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub
End Class