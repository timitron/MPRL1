Public Class FormHome
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Activate()

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

    Private Sub ButtonOperationsFlow_DoubleClick(sender As Object, e As EventArgs) Handles ButtonOperationsFlow.Click
        GlobalVariables.MethodStart = True

        Dim newform
        newform = FormMachiningMethodsDisplay
        newform.Show()
        Me.Hide()

    End Sub

    Private Sub AddToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem6.Click
        GlobalVariables.Click = "PPE"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        GlobalVariables.Click = "Machines"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem2.Click
        GlobalVariables.Click = "Operations"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem3.Click
        GlobalVariables.Click = "Setups"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        GlobalVariables.Click = "Machine Tools"
        Dim newform
        newform = AddItem
        newform.show()
    End Sub

    Private Sub EditToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem6.Click
        GlobalVariables.Click = "PPE"

        Dim newform
        newform = EditForm
        newform.show()

    End Sub

    Private Sub EditToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem3.Click
        GlobalVariables.Click = "Setups"

        Dim newform
        newform = EditForm
        newform.show()

    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        GlobalVariables.Click = "Machine Tools"

        Dim newform
        newform = EditForm
        newform.show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        GlobalVariables.Click = "Machines"

        Dim newform
        newform = EditForm
        newform.show()
    End Sub

    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        GlobalVariables.Click = "Operations"

        Dim newform
        newform = EditForm
        newform.show()
    End Sub

End Class

