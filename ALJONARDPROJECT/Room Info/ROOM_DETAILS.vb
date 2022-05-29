Public Class ROOM_DETAILS
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ROOM_ADD.Show()


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ROOM_UPDATE.room_id.Text = DGVLIST.CurrentRow.Cells(0).Value.ToString
        ROOM_UPDATE.room_num.Text = DGVLIST.CurrentRow.Cells(1).Value.ToString
        ROOM_UPDATE.room_type.Text = DGVLIST.CurrentRow.Cells(2).Value.ToString
        ROOM_UPDATE.bedding_type.Text = DGVLIST.CurrentRow.Cells(3).Value.ToString
        ROOM_UPDATE.price.Text = DGVLIST.CurrentRow.Cells(4).Value.ToString
        ROOM_UPDATE.Show()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete_data("DELETE FROM room_tbl WHERE ROOM_ID='" & DGVLIST.CurrentRow.Cells(0).ToString & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            refresh_data("SELECT * FROM room_tbl", DGVLIST)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        search_data("SELECT * FROM `room_tbl` WHERE `ROOM_ID` LIKE '%" & searchBox.Text & "%'
        OR `ROOM_TYPE` LIKE '%" & searchBox.Text & "%' OR `ROOM_NUM` LIKE '%" & searchBox.Text & "%'", DGVLIST)
    End Sub
End Class