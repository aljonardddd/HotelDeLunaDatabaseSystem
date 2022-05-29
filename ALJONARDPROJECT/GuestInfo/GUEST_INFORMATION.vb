Public Class GUEST_INFORMATION
    Dim gender As String

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        GUEST_ADD.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        GUEST_UPDATE.guest_id.Text = DGVLIST.CurrentRow.Cells(0).Value.ToString
        GUEST_UPDATE.firstName.Text = DGVLIST.CurrentRow.Cells(1).Value.ToString
        GUEST_UPDATE.lastName.Text = DGVLIST.CurrentRow.Cells(2).Value.ToString
        GUEST_UPDATE.age.Text = DGVLIST.CurrentRow.Cells(3).Value.ToString
        gender = DGVLIST.CurrentRow.Cells(4).Value.ToString
        If gender = "Male" Then
            GUEST_UPDATE.radmale.Checked = True
            GUEST_UPDATE.radfemale.Checked = False
        ElseIf gender = "Female" Then
            GUEST_UPDATE.radmale.Checked = False
            GUEST_UPDATE.radfemale.Checked = True
        End If
        GUEST_UPDATE.contactNum.Text = DGVLIST.CurrentRow.Cells(5).Value.ToString
        GUEST_UPDATE.emailAdd.Text = DGVLIST.CurrentRow.Cells(6).Value.ToString


        GUEST_UPDATE.Show()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete_data("DELETE FROM guest_tbl WHERE GUEST_ID='" & DGVLIST.CurrentRow.Cells(1).ToString & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            refresh_data("SELECT * FROM guest_tbl", DGVLIST)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        search_data("SELECT * FROM `guest_tbl` WHERE `FNAME` LIKE '%" & searchBox.Text & "%'
        OR `LNAME` LIKE '%" & searchBox.Text & "%' OR `AGE` LIKE '%" & searchBox.Text & "%'", DGVLIST)
    End Sub


End Class