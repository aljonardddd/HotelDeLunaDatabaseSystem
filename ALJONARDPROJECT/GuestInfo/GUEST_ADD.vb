Public Class GUEST_ADD
    Dim gender As String
    Dim genderBind As String
    Private Sub radmale_CheckedChanged(sender As Object, e As EventArgs) Handles radmale.CheckedChanged
        gender = "Male"
    End Sub
    Private Sub radfemale_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            create_data("INSERT INTO guest_tbl (`GUEST_ID`,`FNAME`,`LNAME`,`AGE`,`GENDER`,`CONTACT_NUM`,`EMAIL_ADD`) 
            VALUES('" & guest_id.Text & "','" & firstName.Text & "','" & lastName.Text & "','" & age.Text & "','" & gender & "',
            '" & contactNum.Text & "','" & emailAdd.Text & "')")

            radmale.Checked = False
            radfemale.Checked = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        guest_id.Text = ""
        firstName.Clear()
        lastName.Clear()
        age.Clear()
        radmale.Checked = False
        radfemale.Checked = False
        contactNum.Clear()
        emailAdd.Clear()
    End Sub

End Class