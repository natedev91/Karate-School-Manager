Public Class MainForm
    Private Sub mnuMembershipListAll_Click(sender As Object, e As EventArgs) Handles mnuMembershipListAll.Click
        ' Create an instance of AllMembersForm
        Dim frmAllmembers As New AllMembersForm

        ' Display the form
        frmAllmembers.ShowDialog()
    End Sub
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuMembershipAdd_Click(sender As Object, e As EventArgs) Handles mnuMembershipAdd.Click
        ' Create an instance of AddMemberForm
        Dim frmAddMember As New AddMemberForm

        ' Display the form
        frmAddMember.ShowDialog()
    End Sub

    Private Sub mnuMembershipFind_Click(sender As Object, e As EventArgs) Handles mnuMembershipFind.Click
        ' Create a new instance of FindMembeForm
        Dim frmFindMember As New FindMembersForm

        ' Display the form
        frmFindMember.ShowDialog()
    End Sub

    Private Sub mnuPaymentsAll_Click(sender As Object, e As EventArgs) Handles mnuPaymentsAll.Click
        ' Create an instance of AllPaymentsForm
        Dim frmPaymentsAll As New AllPaymentsForm

        'Display the form
        frmPaymentsAll.ShowDialog()
    End Sub
End Class