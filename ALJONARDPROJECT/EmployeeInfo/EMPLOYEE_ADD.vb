Public Class EMPLOYEE_ADD
    Private Sub EMPLOYEE_ADD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            create_data("INSERT INTO employee_tbl (`EMPLOYEE_ID`,`HOTEL_ID`,`FNAME`,`LNAME`,`AGE`,`GENDER`,`CONTACT_NUM`,`EMAIL_ADD`,`SALARY`) 
            VALUES('" & emp_id.Text & "','" & cmb_hotel_id.Text & "','" & firstName.Text & "','" & lastName.Text & "','" & age.Text & "','" & gender & "',
            '" & contactNum.Text & "','" & emailAdd.Text & "','" & salary.Text & "')")

            radmale.Checked = False
            radfemale.Checked = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
End Class