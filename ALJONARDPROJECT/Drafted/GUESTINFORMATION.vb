Public Class GuestInformation
    Dim gender As String
    Dim genderBind As String
    Private Sub GuestInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g_id.Hide()
        guest_id.Hide()
        refresh()

    End Sub

    Private Sub radmale_CheckedChanged(sender As Object, e As EventArgs) Handles radmale.CheckedChanged
        gender = "Male"
    End Sub
    Private Sub radfemale_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub

    'ADD FUNCTION
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            create_data("INSERT INTO guest_tbl (`FNAME`,`LNAME`,`AGE`,`GENDER`,`CONTACT_NUM`,`EMAIL_ADD`) 
            VALUES('" & firstName.Text & "','" & lastName.Text & "','" & age.Text & "','" & gender & "',
            '" & contactNum.Text & "','" & emailAdd.Text & "')")

            radmale.Checked = False
            radfemale.Checked = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'UPDATE FUNCTION
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            update_data("UPDATE guest_tbl SET FNAME='" & firstName.Text & "',LNAME='" & lastName.Text & "',AGE='" & age.Text & "',
                        GENDER='" & gender & "',CONTACT_NUM='" & contactNum.Text & "',EMAIL_ADD='" & emailAdd.Text & "'    
                        WHERE GUEST_ID='" & guest_id.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'REFRESH FUNCTION
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            refresh_data("SELECT * FROM guest_tbl", DGVList)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'DELETE FUNCTION
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            delete_data("DELETE FROM guest_tbl WHERE GUEST_ID='" & guest_id.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'CLEAR FUNCTION
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
    'SEARCH FUNCTION
    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        search_data("SELECT * FROM `guest_tbl` WHERE `FNAME` LIKE '%" & searchBox.Text & "%'
        OR `LNAME` LIKE '%" & searchBox.Text & "%' OR `AGE` LIKE '%" & searchBox.Text & "%'", DGVList)
    End Sub

    Public Sub refresh()
        Try
            refresh_data("SELECT * FROM `guest_tbl`", DGVList)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'DATA GRID VIEW
    Private Sub DGVList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVList.CellDoubleClick
        guest_id.Text = DGVList.CurrentRow.Cells(0).Value
        firstName.Text = DGVList.CurrentRow.Cells(1).Value
        lastName.Text = DGVList.CurrentRow.Cells(2).Value
        age.Text = DGVList.CurrentRow.Cells(3).Value
        genderBind = DGVList.CurrentRow.Cells(4).Value
        contactNum.Text = DGVList.CurrentRow.Cells(5).Value
        emailAdd.Text = DGVList.CurrentRow.Cells(6).Value

        If genderBind = "Male" Then
            radmale.Checked = True
            radfemale.Checked = False
        ElseIf genderBind = "Female" Then
            radmale.Checked = False
            radfemale.Checked = True

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure?", "Exit form", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class
