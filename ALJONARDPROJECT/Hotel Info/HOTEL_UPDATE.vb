Public Class HOTEL_UPDATE
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        hotel_id.Text = ""
        address.Clear()
        contactNum.Clear()
        city.Clear()
        post_code.Clear()
        province.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            update_data("UPDATE hotel_tbl SET HOTEL_ID='" & hotel_id.Text & "',ADDRESS='" & address.Text & "',
                    CONTACT_NUM='" & contactNum.Text & "',CITY='" & city.Text & "',POST_CODE='" & post_code.Text & "' ,PROVINCE='" & province.Text & "'  
                        WHERE HOTEL_ID='" & hotel_id.Text & "'")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class