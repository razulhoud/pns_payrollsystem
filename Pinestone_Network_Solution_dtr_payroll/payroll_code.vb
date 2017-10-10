Imports MySql.Data.MySqlClient
Module payroll_code
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable



    Public Sub dg_buttonForEmployeePayroll_EDIT()
        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()

        btn.HeaderText = ""
        btn.Name = "btnEdit"
        btn.Text = "Edit Payroll"
        btn.FlatStyle = FlatStyle.Flat

        btn.UseColumnTextForButtonValue = True
        Interface_admin.dg_employee_emp_payroll.Columns.Add(btn)
    End Sub

    Public Sub dg_buttonForEmployeePayroll_ADD()
        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()

        btn.HeaderText = ""
        btn.Name = "btnAdd"
        btn.Text = "Add Payroll"
        btn.FlatStyle = FlatStyle.Flat

        btn.UseColumnTextForButtonValue = True
        Interface_admin.dg_employee_emp_payroll.Columns.Add(btn)
    End Sub

    Public Sub loadt_dg_payroll()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "Select e.employee_num as 'ID', e.first_name as 'First Name', e.last_name as 'Last Name', e.status as 'Status', w.name_work as 'Designation', m.department_name as 'Department', p.num_cuts as 'Cuts(Voice)', p.total_time as 'Rendered', p.subTotal as 'SubTotal', p.balance as 'Balance', p.over as 'Over', p.discrepancy as 'Discrepancy', " +
                    "p.cashadvance as 'Cash Advance', p.release as 'Release', d.sss as 'SSS', d.pagibig as 'Pagibig', d.philhealth as 'Philhealth', d.tax as 'Tax', p.total as 'Total' from tbl_employees e inner join tbl_designation w on e.id_work = w.id_work inner join " +
                    "tbl_department m on e.id_department = m.id_department inner join tbl_payroll p on e.employee_num = p.emp_num inner join tbl_deduction d on e.employee_num = d.emp_num " +
                    "order by e.employee_num ASC"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            form_empPayroll_.dg_payroll.DataSource = bSource

            SDA.Update(dbDataSet)

            MysqlConn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
