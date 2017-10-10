
Imports MySql.Data.MySqlClient
Module employee_code
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    '///////////////////////////////////////////////////// Show Table employee

    Public Sub loadt_dg_employ_ADD() ''//incase of bug in adding
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT tbl_employees.photo as 'Employee', tbl_employees.employee_num as 'ID', tbl_employees.last_name as 'Lastname', tbl_employees.first_name as 'Firstname', tbl_department.department_name as 'Department', tbl_designation.name_work as 'Designation', tbl_employees.contact_number as 'Contact Number', tbl_employees.birthdate as 'Birthday', tbl_employees.gender as 'Gender', tbl_employees.status as 'Status' from tbl_employees inner join tbl_designation on tbl_employees.id_work = tbl_designation.id_work inner join tbl_department on tbl_employees.id_department = tbl_department.id_department ORDER BY id_employee ASC"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Interface_admin.dg_employee.DataSource = bSource

            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Public Sub loadt_dg_employ_SEARCHING()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT tbl_employees.photo as 'Employee', tbl_employees.employee_num as 'ID', tbl_employees.last_name as 'Lastname', tbl_employees.first_name as 'Firstname', tbl_department.department_name as 'Department', tbl_designation.name_work as 'Designation', tbl_employees.contact_number as 'Contact Number', tbl_employees.birthdate as 'Birthday', tbl_employees.gender as 'Gender', tbl_employees.status as 'Status' from tbl_employees inner join tbl_designation on tbl_employees.id_work = tbl_designation.id_work inner join tbl_department on tbl_employees.id_department = tbl_department.id_department where CONCAT( first_name, ' ', Last_name ) LIKE '%" & Interface_admin.search_employeeList.Text & "%' ORDER BY id_employee ASC"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Interface_admin.dg_employee.DataSource = bSource

            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub dg_buttonForEmployee()
        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()

        btn.HeaderText = ""
        btn.Name = "btnEdit"
        btn.Text = "Edit"
        btn.FlatStyle = FlatStyle.Flat

        btn.UseColumnTextForButtonValue = True
        Interface_admin.dg_employee.Columns.Add(btn)
    End Sub
    '///////////////////////////////////////////////Note: Adding of employees code is in form_addnew_emp due to the fact of pictures searching adding


    '//////////////////////////////////////////////////////////////Department////////////////////////////////////////
    Public Sub cmBx_addEmp_dept_Update()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "Select * from aaa_pns.tbl_department"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim sName = READER.GetString("department_name")
                form_addnew_emp.cmBx_addEmp_dept.AddItem(sName)

            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Public Sub transferDepId_txbxMgc_addEmp()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from aaa_pns.tbl_department where department_name = '" & form_addnew_emp.cmBx_addEmp_dept.selectedValue & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                form_addnew_emp.txBxMgc_addEmp_idDep.Text = READER.GetInt32("id_department")
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    '//////////////////////////////////////////////////////////////End-Department////////////////////////////////////////
    '
    '
    '
    '
    '
    '

    '//////////////////////////////////////////////////////////////Designation////////////////////////////////////////
    Public Sub cmBx_addEmp_desig_Update()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "Select * from aaa_pns.tbl_designation"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim sName = READER.GetString("name_work")
                form_addnew_emp.cmBx_addEmp_desig.AddItem(sName)

            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Public Sub transferDesigId_txbxMgc_addEmp()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from aaa_pns.tbl_designation where name_work = '" & form_addnew_emp.cmBx_addEmp_desig.selectedValue & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                form_addnew_emp.txBxMgc_addEmp_idDesig.Text = READER.GetInt32("id_work")
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    '//////////////////////////////////////////////////////////////END-Designation////////////////////////////////////////


    Public Sub clear_form_addnew_emp()
        form_addnew_emp.PictureBox1.Image = Nothing
        form_addnew_emp.txBx_addEmp_randomNum.ResetText()


        form_addnew_emp.txBx_addEmp_fname.ResetText()

        form_addnew_emp.txBx_addEmp_lname.ResetText()

        form_addnew_emp.txBx_addEmp_num.ResetText()


        form_addnew_emp.cmBx_addEmp_gender.selectedIndex = 0

        form_addnew_emp.cmBx_addEmp_status.ResetText()

        form_addnew_emp.txBx_addEmp_sss.ResetText()

        form_addnew_emp.txBx_addEmp_Pagibig.ResetText()

        form_addnew_emp.txBx_addEmp_Philhealth.ResetText()
        form_addnew_emp.txBx_addEmp_tax.ResetText()

        form_addnew_emp.txBx_addEmp_grossPay.ResetText()
    End Sub
End Module
