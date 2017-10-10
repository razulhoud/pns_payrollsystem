Imports MySql.Data.MySqlClient

Module settings_code
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Public Sub loadt_dg_designation()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT id_work as 'ID', name_work as 'Designation', y.id_department as 'ID Department', department_name as 'Department', salary_work as 'Gross Pay' from tbl_designation x inner join tbl_department y on x.id_department = y.id_department"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Interface_admin.dg_designation.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub dg_buttonfordesignation()
        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()

        btn.HeaderText = ""
        btn.Name = "btnEdit"
        btn.Text = "Edit"
        btn.FlatStyle = FlatStyle.Flat

        btn.UseColumnTextForButtonValue = True
        Interface_admin.dg_designation.Columns.Add(btn)
    End Sub

    Public Sub loadt_dg_department()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT id_department as 'ID', department_name as 'Department' from tbl_department"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Interface_admin.dg_department.DataSource = bSource
            ' tbl_branch.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    '---------------------ADDING of Department--------------
    Public Sub add_department()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        If (form_addnew_department.txBx_add_Depname.Text IsNot "") Then

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "insert into aaa_pns.tbl_department (department_name) values ( '" & form_addnew_department.txBx_add_Depname.Text & "' )"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Data saved.")
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
            loadt_dg_department()

        Else
            MessageBox.Show("Please input the required fields")
        End If

    End Sub
    '---------------------Combo Box Load (Department)----------------------
    Public Sub cmBx_departmentUpdate()
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
                form_addnew_designation.cmBx_addDes_dept.AddItem(sName)

            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    '---------------------ADDING of Designation--------------
    Public Sub add_designation()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        If (form_addnew_designation.txBx_adddes_name.Text IsNot "") And (form_addnew_designation.txBx_adddes_sal.Text IsNot "") Then

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "insert into aaa_pns.tbl_designation (id_department, name_work, salary_work) values ( '" & form_addnew_designation.txBxMgc_idDep.Text & "', '" & form_addnew_designation.txBx_adddes_name.Text & "', '" & form_addnew_designation.txBx_adddes_sal.Text & "')"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Data saved.")
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
            loadt_dg_designation()

        Else
            MessageBox.Show("Please input the required fields")

        End If

    End Sub
    Public Sub updateDesignation()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader


        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "UPDATE tbl_designation SET name_work = '" & form_addnew_designation.txBx_adddes_name.Text & "', salary_work = '" & form_addnew_designation.txBx_adddes_sal.Text & "'  WHERE id_work = '" & form_addnew_designation.txBxMgc_idDesig.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader

            MessageBox.Show("Successfully Updated!")


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        loadt_dg_designation()

    End Sub

    Public Sub transferDepId_txbxMgc()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from aaa_pns.tbl_department where department_name = '" & form_addnew_designation.cmBx_addDes_dept.selectedValue & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                form_addnew_designation.txBxMgc_idDep.Text = READER.GetInt32("id_department")
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


End Module
