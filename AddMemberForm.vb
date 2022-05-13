Public Class AddMemberForm
    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AllMembersDataSet)

    End Sub

    Private Sub AddMemberForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllMembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersBindingSource.AddNew()
        Date_JoinedDateTimePicker.Value = Today()
    End Sub

    Private Sub SaveAndCloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAndCloseToolStripMenuItem.Click
        Try
            Me.MembersBindingSource.EndEdit()
            Me.MembersTableAdapter.Update(AllMembersDataSet.Members)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Me, "Error: " & ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CloseWithoutSavingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseWithoutSavingToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class