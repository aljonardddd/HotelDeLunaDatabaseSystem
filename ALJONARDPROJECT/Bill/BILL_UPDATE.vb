Public Class BILL_UPDATE
    Private Sub BILL_UPDATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            refresh_data("SELECT `BILL_ID`,`ROOM_ID` FROM bill_tbl", cmb_room_id)
            refresh_data("SELECT `BILL_ID`,`GUEST_ID` FROM bill_tbl", cmb_guest_id)
            cmb_room_id.ValueMember = "BILL_ID"
            cmb_room_id.DisplayMember = "ROOM_ID"
            cmb_guest_id.ValueMember = "BILL_ID"
            cmb_guest_id.DisplayMember = "GUEST_ID"

            connect.Close()
            dtadapter.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            update_data("UPDATE room_tbl SET BILL_ID='" & bill_id.Text & "',GUEST_ID='" & cmb_guest_id.Text & "',
                    DATE='" & date_picker.Text & "',AMOUNT='" & amount.Text & "',ROOM_ID='" & cmb_room_id.Text & "'   
                        WHERE BILL_ID='" & bill_id.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        bill_id.Text = ""
        amount.Clear()

    End Sub
End Class