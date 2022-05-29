Public Class MAIN

    Public Sub addform(frm As Form)
        Try
            MAINPANEL.Controls.Clear()
            frm.TopMost = True
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            MAINPANEL.Controls.Add(frm)
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub change_form(menu As String)
        Select Case menu
            Case "HPage"
                addform(HOME)
            Case "GUEST"
                addform(GUEST_INFORMATION)
            Case "EMPLOYEE"
                addform(EMPLOYEE_INFORMATION)
            Case "BOOKING"
                addform(BOOKING_DETAILS)
            Case "HOTEL"
                addform(HOTEL_DETAILS)
            Case "ROOM"
                addform(ROOM_DETAILS)
            Case "BILL"
                addform(BILL_DETAILS)


        End Select
    End Sub

    Private Sub iconHome_Click(sender As Object, e As EventArgs) Handles iconHome.Click
        change_form("HPage")
    End Sub

    Private Sub iconGuest_Click(sender As Object, e As EventArgs) Handles iconGuest.Click
        change_form("GUEST")
    End Sub

    Private Sub iconEmp_Click(sender As Object, e As EventArgs) Handles iconEmp.Click
        change_form("EMPLOYEE")
    End Sub

    Private Sub iconBook_Click(sender As Object, e As EventArgs) Handles iconBook.Click
        change_form("BOOKING")
    End Sub

    Private Sub iconHotel_Click(sender As Object, e As EventArgs) Handles iconHotel.Click
        change_form("HOTEL")
    End Sub

    Private Sub IconRoom_Click(sender As Object, e As EventArgs) Handles IconRoom.Click
        change_form("ROOM")
    End Sub

    Private Sub iconBill_Click_1(sender As Object, e As EventArgs) Handles iconBill.Click
        change_form("BILL")
    End Sub

    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
