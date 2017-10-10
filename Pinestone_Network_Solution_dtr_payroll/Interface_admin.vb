Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Interface_admin
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Dim dbDataSet As New DataTable
    Private Sub Interface_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date_from.Value = Date.Today.ToString("yyyy-MM-dd")
        date_to.Value = Date.Today.ToString("yyyy-MM-dd")




        x.Text = Format(date_from.Value, "yyyy-MM-dd")
        y.Text = Format(date_to.Value, "yyyy-MM-dd")
        '-------------
        ' loadt_dg_dtr_inside2LOADFROMHERE()
        loadt_dg_dtr_inside2()
        loadt_dg_dtr_insidePLUSBUTTON()
        loadt_dg_dtr_insidePLUSBUTTON2()
        '----------------
        loadt_dg_users()
        dg_buttonForUser()
        '-----------------------
        loadt_dg_designation()
        dg_buttonfordesignation()
        '-----------------------
        loadt_dg_employ_ADD()
        dg_buttonForEmployee()
        '--------------------

        loadt_dg_department()
        '----------------------
        loadt_dg_employ_payroll()
        dg_buttonForEmployeePayroll_EDIT()
        '--------------------
        cmBx_departmentUpdate()



        'loadt_dg_dtr_inside()


    End Sub

    Private Sub btn_uiAdmin_dash_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_dash.Click
        sprtr_intAdmin.Height = btn_uiAdmin_dash.Height
        sprtr_intAdmin.Top = btn_uiAdmin_dash.Top


        pnl_uiAdmin_payroll.Hide()

        pnl_uiAdmin_DTR.Hide()
        form_addnew_users.Hide()
        pnl_uiAdmin_employee.Hide()
        form_addnew_emp.Hide()
        pnl_uiAdmin_settings.Hide()
    End Sub

    Private Sub btn_uiAdmin_dtr_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_dtr.Click
        pnl_uiAdmin_DTR.Show()

        sprtr_intAdmin.Height = btn_uiAdmin_dtr.Height
        sprtr_intAdmin.Top = btn_uiAdmin_dtr.Top

        pnl_uiAdmin_payroll.Hide()

        form_addnew_users.Hide()
        pnl_uiAdmin_employee.Hide()
        form_addnew_emp.Hide()
        pnl_uiAdmin_settings.Hide()
    End Sub

    Private Sub btn_uiAdmin_payroll_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_payroll.Click
        sprtr_intAdmin.Height = btn_uiAdmin_payroll.Height

        sprtr_intAdmin.Top = btn_uiAdmin_payroll.Top

        pnl_uiAdmin_payroll.Show()


        form_addnew_users.Hide()
        pnl_uiAdmin_DTR.Hide()
        pnl_uiAdmin_employee.Hide()
        form_addnew_emp.Hide()
        pnl_uiAdmin_settings.Hide()
    End Sub

    Private Sub btn_uiAdmin_employee_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_employee.Click
        'Dim row As DataGridViewRow = dg_employee.Rows(0)
        'row.Height = 50

        sprtr_intAdmin.Height = btn_uiAdmin_employee.Height
        sprtr_intAdmin.Top = btn_uiAdmin_employee.Top
        pnl_uiAdmin_payroll.Hide()
        form_addnew_users.Hide()
        pnl_uiAdmin_DTR.Hide()
        pnl_uiAdmin_employee.Show()
        form_addnew_emp.Hide()
        pnl_uiAdmin_settings.Hide()


    End Sub

    Private Sub pnl_uiAdmin_settings_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_settings.Click
        sprtr_intAdmin.Height = btn_uiAdmin_settings.Height
        sprtr_intAdmin.Top = btn_uiAdmin_settings.Top
        pnl_uiAdmin_settings.Show()

        form_addnew_users.Hide()
        pnl_uiAdmin_DTR.Hide()
        pnl_uiAdmin_employee.Hide()
        form_addnew_emp.Hide()
        pnl_uiAdmin_payroll.Hide()
    End Sub

    Private Sub btn_uiAdmin_addnew_Click(sender As Object, e As EventArgs)
        form_addnew_users.Show()

    End Sub

    Private Sub btn_exit_uiadmin_Click(sender As Object, e As EventArgs) Handles btn_exit_uiadmin.Click
        Application.Exit()

    End Sub



    Private Sub btn_uiAdmin_addEmployee_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_addEmployee.Click
        form_addnew_emp.Show()
        Me.Opacity = 50%

        form_addnew_emp.Show()
        form_addnew_emp.lbl_transform1_emp.Text = "Add"
        form_addnew_emp.btn_addemp_UPDATE.Visible = False
        form_addnew_emp.btn_addemp_addnew.Visible = True

    End Sub

    Private Sub btn_uiAdmin_settings_Click(sender As Object, e As EventArgs)
        pnl_uiAdmin_settings.Show()
        sprtr_intAdmin.Height = btn_uiAdmin_settings.Height
        sprtr_intAdmin.Top = btn_uiAdmin_settings.Top

        form_addnew_users.Hide()
        pnl_uiAdmin_employee.Hide()
        form_addnew_emp.Hide()



    End Sub

    Private Sub btn_uiAdmin_addDesignation_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_addDesignation.Click
        form_addnew_designation.Show()
        form_addnew_designation.lbl_addDesig1.Visible = True
        form_addnew_designation.lbl_addDesig2.Visible = True

        form_addnew_designation.lbl_editDesig1.Visible = False
        form_addnew_designation.lbl_editDesig2.Visible = False

        form_addnew_designation.btn_addDesig_edit.Visible = False
        form_addnew_designation.btn_addDesig_addnew.Visible = True

        form_addnew_designation.txBxMgc_idDep.Clear()
        form_addnew_designation.txBxMgc_idDesig.Clear()
        form_addnew_designation.txBx_adddes_name.ResetText()
        form_addnew_designation.txBx_adddes_sal.ResetText()


    End Sub

    'Settings Admin
    Private Sub btn_uiAdmin_users_Click_1(sender As Object, e As EventArgs) Handles btn_uiAdmin_users.Click
        sprtr_admin_settings.Width = btn_uiAdmin_users.Width
        sprtr_admin_settings.Left = btn_uiAdmin_users.Left

        spnl_uiAdmin_users.Show()

        spnl_uiAdmin_designation.Hide()
        spnl_uiAdmin_department.Hide()

    End Sub
    Private Sub btn_uiAdmin_desig_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_desig.Click
        sprtr_admin_settings.Width = btn_uiAdmin_desig.Width
        sprtr_admin_settings.Left = btn_uiAdmin_desig.Left


        spnl_uiAdmin_designation.Show()
        spnl_uiAdmin_department.Hide()
        spnl_uiAdmin_users.Hide()

    End Sub

    Private Sub btn_uiAdmin_dept_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_dept.Click
        sprtr_admin_settings.Width = btn_uiAdmin_dept.Width
        sprtr_admin_settings.Left = btn_uiAdmin_dept.Left

        spnl_uiAdmin_department.Show()
        spnl_uiAdmin_designation.Hide()
        spnl_uiAdmin_users.Hide()

    End Sub

    Private Sub btn_uiAdmin_change_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_change.Click
        sprtr_admin_settings.Width = btn_uiAdmin_change.Width
        sprtr_admin_settings.Left = btn_uiAdmin_change.Left

        form_changePwd.Show()
        spnl_uiAdmin_users.Hide()
        spnl_uiAdmin_department.Hide()
        spnl_uiAdmin_designation.Hide()
    End Sub

    Private Sub btn_uiAdmin_dbase_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_dbase.Click
        sprtr_admin_settings.Width = btn_uiAdmin_dbase.Width
        sprtr_admin_settings.Left = btn_uiAdmin_dbase.Left

        spnl_uiAdmin_users.Hide()
    End Sub

    Private Sub btn_uiAdmin_addDepartment_Click(sender As Object, e As EventArgs) Handles btn_uiAdmin_addDepartment.Click
        form_addnew_department.Show()

    End Sub

    Private Sub date_from_onValueChanged(sender As Object, e As EventArgs) Handles date_from.onValueChanged
        'date_from.Value = Date.Today.ToString("yyyy-MM-dd")
        'date_to.Value = Date.Today.ToString("yyyy-MM-dd")

        x.Text = Format(date_from.Value, "yyyy-MM-dd")
        y.Text = Format(date_to.Value, "yyyy-MM-dd")


        loadt_dg_dtr_inside2()

    End Sub

    Private Sub date_to_onValueChanged(sender As Object, e As EventArgs) Handles date_to.onValueChanged
        'date_from.Value = Date.Today.ToString("yyyy-MM-dd")
        'date_to.Value = Date.Today.ToString("yyyy-MM-dd")

        x.Text = Format(date_from.Value, "yyyy-MM-dd")
        y.Text = Format(date_to.Value, "yyyy-MM-dd")


        loadt_dg_dtr_inside2()
    End Sub

    Private Sub x_TextChanged(sender As Object, e As EventArgs) Handles x.TextChanged

    End Sub


    Public Sub loadt_dg_dtr_inside2()
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
            "(date between '" & x.Text & "' and '" & y.Text & "') AND CONCAT( first_name, ' ', Last_name ) LIKE '%" & txBx_uiAdmin_search.Text & "%' ORDER BY x.id_dtr DESC "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dg_dtr_inside.DataSource = bSource

            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub txBx_uiAdmin_search_OnValueChanged(sender As Object, e As EventArgs) Handles txBx_uiAdmin_search.OnValueChanged
        loadt_dg_dtr_inside2()

    End Sub

    Public Sub dg_designation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_designation.CellClick
        'If e.ColumnIndex = 0 Then
        '    form_addnew_designation.Show()
        'End If


    End Sub

    Private Sub btn_uiAdmin_addnew_Click_1(sender As Object, e As EventArgs) Handles btn_uiAdmin_addnew.Click
        form_addnew_users.Show()
    End Sub

    Private Sub dg_users_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_users.CellContentClick

        If e.ColumnIndex = 0 Then
            If lbl_mgc_id.Text = 1 Then
                form_addnew_users.Show()
                form_addnew_users.txBx_signup_pwd.Enabled = False
                form_addnew_users.txBx_signup_repwd.Enabled = False

                form_addnew_users.lbl_addUser1.Visible = False
                form_addnew_users.lbl_addUser2.Visible = False
                form_addnew_users.btn_addUser.Visible = False

                form_addnew_users.lbl_editUser1.Visible = True
                form_addnew_users.lbl_editUser2.Visible = True
                form_addnew_users.btn_updateUser.Visible = True

                Dim row As DataGridViewRow
                row = dg_users.Rows(e.RowIndex)
                form_addnew_users.txBxMgc_idUser.Text = row.Cells("ID").Value.ToString
                form_addnew_users.txBx_signup_name.Text = row.Cells("Name").Value.ToString
                form_addnew_users.txBx_signup_username.Text = row.Cells("Username").Value.ToString
            Else
                MessageBox.Show("You don't have the required priviledge.")

            End If
        End If


    End Sub

    Private Sub btn_uIAdmin_logOut_Click(sender As Object, e As EventArgs) Handles btn_uIAdmin_logOut.Click
        Me.Hide()
        Login_DTR.Show()
    End Sub

    Private Sub dg_designation_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg_designation.CellContentClick
        If e.ColumnIndex = 0 Then
            form_addnew_designation.Show()
            form_addnew_designation.lbl_addDesig1.Visible = False
            form_addnew_designation.lbl_addDesig2.Visible = False

            form_addnew_designation.lbl_editDesig1.Visible = True
            form_addnew_designation.lbl_editDesig2.Visible = True

            form_addnew_designation.btn_addDesig_edit.Visible = True
            form_addnew_designation.btn_addDesig_addnew.Visible = False

            Dim row As DataGridViewRow
            row = dg_designation.Rows(e.RowIndex)
            form_addnew_designation.txBxMgc_idDesig.Text = row.Cells("ID").Value.ToString
            form_addnew_designation.txBx_adddes_name.Text = row.Cells("Designation").Value.ToString
            form_addnew_designation.txBxMgc_idDep.Text = row.Cells("ID Department").Value.ToString
            form_addnew_designation.cmBx_addDes_dept.selectedIndex = row.Cells("ID Department").Value.ToString - 1
            form_addnew_designation.txBx_adddes_sal.Text = row.Cells("Gross Pay").Value.ToString



        End If
    End Sub

    Private Sub dg_employee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_employee.CellContentClick
        If e.ColumnIndex = 0 Then
            clear_form_addnew_emp()
            form_addnew_emp.Show()
            form_addnew_emp.lbl_transform1_emp.Text = "Edit"
            form_addnew_emp.btn_addemp_UPDATE.Visible = True
            form_addnew_emp.btn_addemp_addnew.Visible = False

            Dim row As DataGridViewRow
            row = dg_employee.Rows(e.RowIndex)
            form_addnew_emp.txBx_addEmp_randomNum.Text = row.Cells("ID").Value.ToString

            Dim data As Byte() = row.Cells("Employee").Value
            Dim ms As New MemoryStream(data)
            form_addnew_emp.PictureBox1.Image = Image.FromStream(ms)
        End If

    End Sub

    Private Sub search_employeeList_OnValueChanged(sender As Object, e As EventArgs) Handles search_employeeList.OnValueChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT tbl_employees.photo as 'Employee', tbl_employees.employee_num as 'ID', tbl_employees.last_name as 'Lastname', tbl_employees.first_name as 'Firstname', tbl_department.department_name as 'Department', tbl_designation.name_work as 'Designation', tbl_employees.contact_number as 'Contact Number', tbl_employees.birthdate as 'Birthday', tbl_employees.gender as 'Gender', tbl_employees.status as 'Status' from tbl_employees inner join tbl_designation on tbl_employees.id_work = tbl_designation.id_work inner join tbl_department on tbl_employees.id_department = tbl_department.id_department where CONCAT( first_name, ' ', Last_name ) LIKE '%" & search_employeeList.Text & "%' ORDER BY id_employee ASC"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dg_employee.DataSource = bSource

            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dg_dtr_inside_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_dtr_inside.CellContentClick
        If e.ColumnIndex = 0 Then
            form_addCUTS.Show()

            Dim row As DataGridViewRow
            row = dg_dtr_inside.Rows(e.RowIndex)
            form_addCUTS.lbl_passID_cuts.Text = row.Cells("Entry num").Value.ToString
            form_addCUTS.txBx_EmpNum_cuts.Text = row.Cells("Employee ID").Value.ToString
            form_addCUTS.txBx_numOfCuts.text = row.Cells("Cuts(Voice)").Value.ToString
            form_addCUTS.dtp_passDate_Cuts.Value = row.Cells("Date").Value.ToString

            form_addCUTS.lbl_passDate_cuts.Text = Format(form_addCUTS.dtp_passDate_Cuts.Value, "yyyy-MM-dd")

        ElseIf e.ColumnIndex = 1 Then
            form_addRemarks.Show()

            Dim row As DataGridViewRow
            row = dg_dtr_inside.Rows(e.RowIndex)
            form_addRemarks.lbl_passID_employee_remarks.Text = row.Cells("Entry num").Value.ToString
            form_addRemarks.txBx_EmpNum_remarks.Text = row.Cells("Entry num").Value.ToString
            form_addRemarks.rchTxBx_remarks.Text = row.Cells("Remarks/Projects").Value.ToString


        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        mini_panel_cuts.Hide()

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update tbl_dtr set num_cuts = '" & txBx_numOfCuts.text & "' where employee_num = '" & txBx_mini_IDemp.Text & "' AND date = '" & transferDate.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data saved.")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        loadt_dg_dtr_inside2()

    End Sub

    Private Sub txBx_mini_IDemp_OnValueChanged(sender As Object, e As EventArgs) Handles txBx_mini_IDemp.OnValueChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "SELECT * FROM tbl_dtr"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim getDate = READER.GetDateTime("Date")
                BunifuDatepicker1.Value = getDate
                transferDate.Text = Format(BunifuDatepicker1.Value, "yyyy-MM-dd")
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub dg_employee_emp_payroll_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_employee_emp_payroll.CellContentClick
        If e.ColumnIndex = 0 Then
            form_empPayroll_.Show()

            Dim row As DataGridViewRow
            row = dg_employee_emp_payroll.Rows(e.RowIndex)
            form_empPayroll_.txBx_empPayroll_empNum.Text = row.Cells("Emp Id").Value.ToString
            ' form_empPayroll_.txBx_empPayroll_empNum.Text = row.Cells("Emp ID").Value.ToString
            'form_empPayroll_.txBx_empPayroll_FnameLname.Text = row.Cells("Firstname").Value.ToString + " " + row.Cells("Lastname").Value.ToString
            'form_addCUTS.txBx_EmpNum_cuts.Text = row.Cells("Employee ID").Value.ToString
            'form_addCUTS.txBx_numOfCuts.text = row.Cells("Cuts(Voice)").Value.ToString
            'form_addCUTS.dtp_passDate_Cuts.Value = row.Cells("Date").Value.ToString

            'form_addCUTS.lbl_passDate_cuts.Text = Format(form_addCUTS.dtp_passDate_Cuts.Value, "yyyy-MM-dd")




        End If
    End Sub
    ' --------------------------------------------SEARCHING-----------------------------------------
    Private Sub BunifuMaterialTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.OnValueChanged
        loadt_dg_employ_payroll()
    End Sub
    Public Sub loadt_dg_employ_payroll()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource


        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT e.employee_num as 'Emp ID', e.first_name as 'Firstname', e.last_name as 'Lastname', d.department_name as 'Department', " +
                    "w.name_work as 'Designation', e.status as 'Status' from tbl_employees e inner join tbl_designation w on e.id_work = w.id_work " +
                    "inner join tbl_department d on e.id_department = d.id_department WHERE " +
                    "CONCAT( first_name, ' ', Last_name ) LIKE '%" & BunifuMaterialTextbox3.Text & "%' ORDER BY e.id_employee ASC"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dg_employee_emp_payroll.DataSource = bSource

            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '------------------------------------------------------------------------------------------
End Class