Public Class GUEST_UPDATE
    Dim gender As String
    Dim genderBind As String
    Private Sub radmale_CheckedChanged(sender As Object, e As EventArgs) Handles radmale.CheckedChanged
        gender = "Male"
    End Sub
    Private Sub radfemale_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            update_data("UPDATE guest_tbl SET GUEST_ID='" & guest_id.Text & "',FNAME='" & firstName.Text & "',LNAME='" & lastName.Text & "',AGE='" & age.Text & "',
                        GENDER='" & gender & "',CONTACT_NUM='" & contactNum.Text & "',EMAIL_ADD='" & emailAdd.Text & "'    
                        WHERE GUEST_ID='" & guest_id.Text & "'")
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