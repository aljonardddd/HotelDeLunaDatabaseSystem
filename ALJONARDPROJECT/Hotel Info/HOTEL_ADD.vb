Public Class HOTEL_ADD
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            create_data("INSERT INTO hotel_tbl (`HOTEL_ID`,`ADDRESS`,`CONTACT_NUM`,`CITY`,`POST_CODE`,`PROVINCE`) 
            VALUES('" & hotel_id.Text & "','" & address.Text & "','" & contactNum.Text & "','" & city.Text & "','" & post_code.Text & "',
            '" & province.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        hotel_id.Text = ""
        address.Clear()
        contactNum.Clear()
        city.Clear()
        post_code.Clear()
        province.Clear()
    End Sub
End Class