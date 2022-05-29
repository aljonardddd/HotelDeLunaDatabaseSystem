Public Class BOOKING_DETAILS
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BOOKING_ADD.Show()


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        BOOKING_UPDATE.Show()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete_data("DELETE FROM booking_tbl WHERE BOOKING_ID='" & DGVLIST.CurrentRow.Cells(0).ToString & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            refresh_data("SELECT * FROM booking_tbl", DGVLIST)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        search_data("SELECT * FROM `booking_tbl` WHERE `BOOKING_ID` LIKE '%" & searchBox.Text & "%'
        OR `GUEST_ID` LIKE '%" & searchBox.Text & "%' OR `ROOM_ID` LIKE '%" & searchBox.Text & "%'", DGVLIST)
    End Sub
End Class