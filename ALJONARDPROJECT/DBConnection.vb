Imports MySql.Data.MySqlClient
Module DBConnection

    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;username=root;password=;database=hoteldeluna_database")
    End Function
    Public connect As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public dtadapter As New MySqlDataAdapter
    Public dt As New DataTable


    'INSERT/ADDING DATA
    Public Sub create_data(ByVal sql As String)
        Try
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                connect.Close()
                If result = 0 Then
                    MessageBox.Show("FAILED TO ADD DATA!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA ADDED SUCCESSFULLY IN THE DATABASE!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dtadapter.Dispose()
        End Try
    End Sub

    'FOR REFRESH FUNCTION
    Public Sub refresh_data(ByVal sql As String, ByVal DGVList As Object)
        Try
            dt = New DataTable
            With cmd
                .Connection = connect
                .CommandText = sql

            End With
            dtadapter.SelectCommand = cmd
            dtadapter.Fill(dt)
            DGVList.datasource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Close()
            dtadapter.Dispose()

        End Try
    End Sub
    'FOR UPDATE FUNCTION
    Public Sub update_data(ByVal sql As String)
        Try
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql

                cmd.ExecuteNonQuery()
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("DATA FAILED TO UPDATE!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN UPDATED IN DATABASE!", "SUCESS",
                     MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Close()
        End Try

    End Sub
    'FOR DELETE FUNCTION
    Public Sub delete_data(ByVal sql As String)
        Try
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("DATA FAILED TO DELETE!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN DELETED IN DATABASE!", "SUCESS",
                     MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Close()
        End Try
    End Sub

    'Search 

    Public Sub search_data(ByVal sql As String, ByVal DGVList As Object)
        Try
            dt = New DataTable
            connect.Open()
            With cmd
                .Connection = connect
                .CommandText = sql
            End With
            dtadapter.SelectCommand = cmd
            dtadapter.Fill(dt)
            DGVList.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connect.Close()

        End Try
    End Sub

End Module
