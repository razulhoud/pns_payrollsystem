Imports MySql.Data.MySqlClient


Module dtr_code
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim defaultOut As String = "0000-00-00 00:00:00"
    Public Sub dtr_timeIn_emp()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader



        If (Login_DTR.lbl_login_empInfo.Text IsNot "No Employee Found") And (Login_DTR.txBx_dtr_empNum.Text IsNot "") Then

            Try
                MysqlConn.Open()

                Dim Query As String
                Query = "INSERT INTO tbl_dtr (employee_num, date, time_late, is_present) values ( '" & Login_DTR.txBx_dtr_empNum.Text & "', '" & Date.Today.ToString("yyyy-MM-dd") & "', '" & Login_DTR.lbl_time_late.Text & "', '1' )"  ' '" & Date.Today.ToString("yyyy-MM-dd") & "', '" & Date.Today.ToString("yyyy-MM-dd") & " " & Format(TimeOfDay, "HH:mm:ss") & "',
                COMMAND = New MySqlCommand(Query, MysqlConn)

                READER = COMMAND.ExecuteReader

                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

        Else
            MessageBox.Show("No Proper Employee ID")
        End If


    End Sub
    Public Sub dtr_timeIn_emp_IS_IN()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        If (Login_DTR.txBx_dtr_empNum.Text IsNot "") Then

            Try
                MysqlConn.Open()

                Dim Query As String
                Query = "UPDATE tbl_employees SET is_in = '1' WHERE employee_num = '" & Login_DTR.txBx_dtr_empNum.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)

                READER = COMMAND.ExecuteReader

                MessageBox.Show("You're IN!")


                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            Login_DTR.txBx_dtr_empNum.ResetText()
        Else
            MessageBox.Show("No Proper Employee ID")
        End If
    End Sub


    Public Sub dtr_timeOut_emp()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        If (Login_DTR.txBx_dtr_empNum.Text IsNot "") Then

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE tbl_dtr SET time_out = '" & Date.Today.ToString("yyyy-MM-dd") & " " & Format(TimeOfDay, "HH:mm:ss") & "', time_rendered = '" & Login_DTR.lbl_testTotal.Text & "' WHERE employee_num ='" & Login_DTR.txBx_dtr_empNum.Text & "' AND time_in = time_out"
                COMMAND = New MySqlCommand(Query, MysqlConn)

                READER = COMMAND.ExecuteReader

                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

        Else
            MessageBox.Show("No Proper Employee ID")
        End If

    End Sub

    Public Sub dtr_timeOut_emp_IS_IN()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader


        If (Login_DTR.txBx_dtr_empNum.Text IsNot "") Then

            Try
                MysqlConn.Open()


                Dim Query As String
                Query = "UPDATE tbl_employees SET is_in = '0' WHERE employee_num ='" & Login_DTR.txBx_dtr_empNum.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)

                'Dim Query2 As String
                'Query = "UPDATE tbl_dtr SET time_rendered = " & & " WHERE employee_num ='" & Login_DTR.txBx_dtr_empNum.Text & "'"
                'COMMAND = New MySqlCommand(Query2, MysqlConn)


                READER = COMMAND.ExecuteReader

                MessageBox.Show("Take Care!")
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            Login_DTR.txBx_dtr_empNum.ResetText()


        Else
            MessageBox.Show("No Proper Employee ID")
        End If
    End Sub

    Public Sub loadt_dg_dtr_outside()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT tbl_dtr.time_in as 'Time-in', tbl_dtr.time_out as 'Time-out', tbl_dtr.time_rendered as 'Rendered(Hour)', tbl_dtr.time_late as 'Late(Hour)' FROM tbl_dtr WHERE employee_num = '" & Login_DTR.txBx_dtr_empNum.Text & "' ORDER BY tbl_dtr.date DESC"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            form_view_empDtr.dg_dtr_outside.DataSource = bSource

            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
