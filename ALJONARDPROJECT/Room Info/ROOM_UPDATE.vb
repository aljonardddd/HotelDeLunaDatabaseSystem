Public Class ROOM_UPDATE
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            update_data("UPDATE room_tbl SET ROOM_ID='" & room_id.Text & "',ROOM_NUMBER='" & room_num.Text & "',
                    ROOM_TYPE='" & room_type.Text & "',BEDDING_TYPE='" & bedding_type.Text & "',PRICE='" & price.Text & "'   
                        WHERE ROOM_ID='" & room_id.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        room_id.Text = ""
        room_num.Clear()
        room_type.Clear()
        bedding_type.Clear()
        price.Clear()
    End Sub
End Class