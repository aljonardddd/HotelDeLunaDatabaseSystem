Public Class BILL_ADD

    Private Sub BILL_ADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            create_data("INSERT INTO bill_tbl (`BILL_ID`,`GUEST_ID`,`DATE`,`AMOUNT`,`ROOM_ID`) 
            VALUES('" & bill_id.Text & "','" & cmb_guest_id.Text & "','" & date_picker.Text & "','" & amount.Text & "',
            '" & cmb_room_id.Text & "')")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        bill_id.Text = ""
        amount.Clear()

    End Sub
End Class