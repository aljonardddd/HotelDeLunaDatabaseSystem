Public Class EMPLOYEE_INFORMATION
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EMPLOYEE_ADD.Show()


    End Sub
    Dim gender As String
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        EMPLOYEE_UPDATE.emp_id.Text = DGVLIST.CurrentRow.Cells(0).Value.ToString
        EMPLOYEE_UPDATE.cmb_hotel_id.Text = DGVLIST.CurrentRow.Cells(1).Value.ToString
        EMPLOYEE_UPDATE.firstName.Text = DGVLIST.CurrentRow.Cells(2).Value.ToString
        EMPLOYEE_UPDATE.lastName.Text = DGVLIST.CurrentRow.Cells(3).Value.ToString
        EMPLOYEE_UPDATE.age.Text = DGVLIST.CurrentRow.Cells(4).Value.ToString
        gender = DGVLIST.CurrentRow.Cells(5).Value.ToString
        If gender = "Male" Then
            EMPLOYEE_UPDATE.radmale.Checked = True
            EMPLOYEE_UPDATE.radfemale.Checked = False
        ElseIf gender = "Female" Then
            EMPLOYEE_UPDATE.radmale.Checked = False
            EMPLOYEE_UPDATE.radfemale.Checked = True
        End If
        EMPLOYEE_UPDATE.contactNum.Text = DGVLIST.CurrentRow.Cells(6).Value.ToString
        EMPLOYEE_UPDATE.emailAdd.Text = DGVLIST.CurrentRow.Cells(7).Value.ToString
        EMPLOYEE_UPDATE.salary.Text = DGVLIST.CurrentRow.Cells(8).Value.ToString


        EMPLOYEE_UPDATE.Update()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete_data("DELETE FROM employee_tbl WHERE EMPLOYEE_ID='" & DGVLIST.CurrentRow.Cells(0).ToString & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            refresh_data("SELECT * FROM employee_tbl", DGVLIST)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        search_data("SELECT * FROM `employee_tbl` WHERE `FNAME` LIKE '%" & searchBox.Text & "%'
        OR `LNAME` LIKE '%" & searchBox.Text & "%' OR `AGE` LIKE '%" & searchBox.Text & "%'", DGVLIST)
    End Sub
End Class