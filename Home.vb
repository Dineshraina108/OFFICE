Public Class Home
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Dim loginobj As New Login
        loginobj.Show()
    End Sub

    Private Sub SignUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignUpToolStripMenuItem.Click
        Dim re As New Register
        re.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        Dim loginobj As New Login
        loginobj.Show()
    End Sub

    Private Sub CustomerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerDetailsToolStripMenuItem.Click
        Dim act As New Action
        act.Show()
    End Sub
End Class