Public Class FormHome
    Private Function multitabs()
        Dim pleaseclose As Boolean = False
        If My.Application.OpenForms.Count = 2 Then
            MessageBox.Show("Please close open add/edit tab before continuing.")
            pleaseclose = True
            Return pleaseclose
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If GlobalVariables.AdminBuild = False Then
            MenuStrip1.Visible = False
        End If
    End Sub

    Private Sub ButtonMachineToolFlow_Click(sender As Object, e As EventArgs) Handles ButtonMachineToolFlow.Click
        GlobalVariables.MethodStart = False
        GlobalVariables.fromadd = False

        If multitabs() = True Then Exit Sub
        Dim newform = FormMachineToolsDisplay
        newform.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonOperationsFlow_DoubleClick(sender As Object, e As EventArgs) Handles ButtonOperationsFlow.Click
        GlobalVariables.MethodStart = True
        GlobalVariables.fromadd = False

        If multitabs() = True Then Exit Sub
        Dim newform = FormMachiningMethodsDisplay
        newform.Show()
        Me.Hide()

    End Sub

    Private Sub AddToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem6.Click
        GlobalVariables.Click = "PPE"
        If multitabs() = True Then Exit Sub
        Dim newform = AddItem
        newform.show()
    End Sub
    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        GlobalVariables.Click = "Machines"
        If multitabs() = True Then Exit Sub
        Dim newform = AddItem
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem2.Click
        GlobalVariables.Click = "Operations"
        If multitabs() = True Then Exit Sub
        Dim newform = AddItem
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem3.Click
        GlobalVariables.Click = "Setups"
        If multitabs() = True Then Exit Sub
        Dim newform = AddItem
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        GlobalVariables.Click = "Machine Tools"
        If multitabs() = True Then Exit Sub
        Dim newform = AddItem
        newform.show()
    End Sub

    Private Sub EditToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem6.Click
        GlobalVariables.Click = "PPE"

        If multitabs() = True Then Exit Sub
        Dim newform = EditForm
        newform.show()
    End Sub

    Private Sub EditToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem3.Click
        GlobalVariables.Click = "Setups"

        If multitabs() = True Then Exit Sub
        Dim newform = EditForm
        newform.show()

    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        GlobalVariables.Click = "Machine Tools"

        If multitabs() = True Then Exit Sub
        Dim newform = EditForm
        newform.show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        GlobalVariables.Click = "Machines"

        If multitabs() = True Then Exit Sub
        Dim newform = EditForm
        newform.show()
    End Sub

    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        GlobalVariables.Click = "Operations"

        If multitabs() = True Then Exit Sub
        Dim newform = EditForm
        newform.show()
    End Sub

    Private Sub AddToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem5.Click
        GlobalVariables.Click = "Resourcesadd"

        If multitabs() = True Then Exit Sub
        Dim newform = FormResource
        newform.Show()
    End Sub
End Class


