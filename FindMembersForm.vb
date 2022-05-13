Public Class FindMembersForm
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Perform a wildcard search for last name.
        Me.MembersTableAdapter.Fill(Me.FindMemberDataSet.Members, txtLastName.Text)
    End Sub
End Class