Public Class BILL_DETAILS
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BILL_ADD.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        BILL_UPDATE.bill_id.Text = DGVLIST.CurrentRow.Cells(0).Value.ToString
        BILL_UPDATE.cmb_guest_id.Text = DGVLIST.CurrentRow.Cells(1).Value.ToString
        BILL_UPDATE.date_picker.Text = DGVLIST.CurrentRow.Cells(2).Value.ToString
        BILL_UPDATE.amount.Text = DGVLIST.CurrentRow.Cells(3).Value.ToString
        BILL_UPDATE.cmb_room_id.Text = DGVLIST.CurrentRow.Cells(4).Value.ToString
        BILL_UPDATE.Show()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete_data("DELETE FROM bill_tbl WHERE BILL_ID='" & DGVLIST.CurrentRow.Cells(0).ToString & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            refresh_data("SELECT * FROM bill_tbl", DGVLIST)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        search_data("SELECT * FROM `bill_tbl` WHERE `BILL_ID` LIKE '%" & searchBox.Text & "%'
        OR `GUEST_ID` LIKE '%" & searchBox.Text & "%' OR `AMOUNT` LIKE '%" & searchBox.Text & "%'", DGVLIST)
    End Sub
End Class