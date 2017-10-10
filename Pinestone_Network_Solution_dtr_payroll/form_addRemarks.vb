Imports MySql.Data.MySqlClient
Public Class form_addRemarks
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Hide()

    End Sub

    Private Sub btn_cuts_cancel_Click(sender As Object, e As EventArgs) Handles btn_cuts_cancel.Click
        Me.Hide()

    End Sub

    Private Sub btn_enter_remarks_Click(sender As Object, e As EventArgs) Handles btn_enter_remarks.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader


        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "UPDATE tbl_dtr SET remarks = '" & rchTxBx_remarks.Text & "' WHERE id_dtr = '" & lbl_passID_employee_remarks.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = Command.ExecuteReader

            MessageBox.Show("Successfully Updated!")
            loadt_dg_dtr_inside2LOADFROMHERE()
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub loadt_dg_dtr_inside2LOADFROMHERE()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT x.id_dtr as 'Entry num', x.employee_num as 'Employee ID',  first_name as 'Firstname', last_name as 'Lastname', date as 'Date', name_work as 'Designation', " +
            "time_in as 'In', time_out as 'Out', time_rendered as 'Hours', time_late as 'Late(Hour)', num_cuts as 'Cuts(Voice)', remarks as 'Remarks/Projects' " +
            "FROM tbl_dtr x inner join tbl_employees y on x.employee_num = y.employee_num inner join tbl_designation z on y.id_work = z.id_work WHERE " +
            "(date between '" & Interface_admin.x.Text & "' and '" & Interface_admin.y.Text & "') AND CONCAT( first_name, ' ', Last_name ) LIKE '%" & Interface_admin.txBx_uiAdmin_search.Text & "%' ORDER BY x.id_dtr DESC "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Interface_admin.dg_dtr_inside.DataSource = bSource

            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class