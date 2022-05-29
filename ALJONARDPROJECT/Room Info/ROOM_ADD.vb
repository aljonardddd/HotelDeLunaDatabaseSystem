Public Class ROOM_ADD
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            create_data("INSERT INTO room_tbl (`ROOM_ID`,`ROOM_NUMBER`,`ROOM_TYPE`,`BEDDING_TYPE`,`PRICE`) 
            VALUES('" & room_id.Text & "','" & room_num.Text & "','" & room_type.Text & "','" & bedding_type.Text & "',
            '" & price.Text & "')")

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