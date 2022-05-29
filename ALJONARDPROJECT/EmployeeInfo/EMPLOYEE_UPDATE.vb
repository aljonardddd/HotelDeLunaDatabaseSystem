Public Class EMPLOYEE_UPDATE
    Private Sub EMPLOYEE_UPDATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            refresh_data("SELECT `EMPLOYEE_ID`,`HOTEL_ID` FROM employee_tbl", cmb_hotel_id)

            cmb_hotel_id.ValueMember = "EMPLOYEE_ID"
            cmb_hotel_id.DisplayMember = "HOTEL_ID"

            connect.Close()
            dtadapter.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Dim gender As String
    Dim genderBind As String
    Private Sub radmale_CheckedChanged(sender As Object, e As EventArgs) Handles radmale.CheckedChanged
        gender = "Male"
    End Sub
    Private Sub radfemale_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        emp_id.Text = ""
        firstName.Clear()
        lastName.Clear()
        age.Clear()
        radmale.Checked = False
        radfemale.Checked = False
        contactNum.Clear()
        emailAdd.Clear()
        salary.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            update_data("UPDATE employee_tbl SET EMPLOYEE_ID='" & emp_id.Text & "' ,HOTEL_ID='" & cmb_hotel_id.Text & "', FNAME='" & firstName.Text & "',LNAME='" & lastName.Text & "',AGE='" & age.Text & "',
                        GENDER='" & gender & "',CONTACT_NUM='" & contactNum.Text & "',EMAIL_ADD='" & emailAdd.Text & "',SALARY='" & salary.Text & "'    
                        WHERE EMPLOYEE_ID='" & emp_id.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class