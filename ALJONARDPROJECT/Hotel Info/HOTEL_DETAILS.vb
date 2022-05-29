Public Class HOTEL_DETAILS
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        HOTEL_ADD.Show()


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        HOTEL_UPDATE.hotel_id.Text = DGVLIST.CurrentRow.Cells(0).Value.ToString
        HOTEL_UPDATE.address.Text = DGVLIST.CurrentRow.Cells(1).Value.ToString
        HOTEL_UPDATE.contactNum.Text = DGVLIST.CurrentRow.Cells(2).Value.ToString
        HOTEL_UPDATE.city.Text = DGVLIST.CurrentRow.Cells(4).Value.ToString
        HOTEL_UPDATE.post_code.Text = DGVLIST.CurrentRow.Cells(5).Value.ToString
        HOTEL_UPDATE.province.Text = DGVLIST.CurrentRow.Cells(6).Value.ToString
        HOTEL_UPDATE.Show()


    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            refresh_data("SELECT * FROM hotel_tbl", DGVLIST)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        search_data("SELECT * FROM `hotel_tbl` WHERE `HOTEL_ID` LIKE '%" & searchBox.Text & "%'
        OR `ADDRESS` LIKE '%" & searchBox.Text & "%' OR `CITY` LIKE '%" & searchBox.Text & "%'", DGVLIST)

    End Sub
End Class