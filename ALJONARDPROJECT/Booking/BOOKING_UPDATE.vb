Public Class BOOKING_UPDATE
    Private Sub BOOKING_UPDATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            refresh_data("SELECT `BOOKING_ID`,`ROOM_ID` FROM booking_tbl", cmb_room_id)
            refresh_data("SELECT `BOOKING_ID`,`GUEST_ID` FROM booking_tbl", cmb_guest_id)
            refresh_data("SELECT `BOOKING_ID`,`HOTEL_ID` FROM booking_tbl", cmb_hotel_id)
            refresh_data("SELECT `BOOKING_ID`,`BILL_ID` FROM booking_tbl", cmb_bill_id)
            cmb_room_id.ValueMember = "BOOKING_ID"
            cmb_room_id.DisplayMember = "ROOM_ID"
            cmb_guest_id.ValueMember = "BOOKING_ID"
            cmb_guest_id.DisplayMember = "GUEST_ID"
            cmb_hotel_id.ValueMember = "BOOKING_ID"
            cmb_hotel_id.DisplayMember = "HOTEL_ID"
            cmb_bill_id.ValueMember = "BOOKING_ID"
            cmb_bill_id.DisplayMember = "BILL_ID"

            connect.Close()
            dtadapter.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            update_data("UPDATE booking_tbl SET BOOKING_ID='" & booking_id.Text & "',GUEST_ID='" & cmb_guest_id.Text & "',
                    ROOM_ID='" & cmb_room_id.Text & "',HOTEL_ID='" & cmb_hotel_id.Text & "',BILL_ID='" & cmb_bill_id.Text & "', ARRIVAL_DATE='" & arr_dtp.Text & "', DEPARTURE_DATE='" & dep_dtp.Text & "'
                        WHERE BOOKING_ID='" & booking_id.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        booking_id.Text = ""
    End Sub
End Class