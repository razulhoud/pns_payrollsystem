Imports System.IO

Imports MySql.Data.MySqlClient


Public Class form_addnew_emp
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable


    Dim a As OpenFileDialog = New OpenFileDialog

    Private Sub form_addnew_emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_calltime.CustomFormat = "HH:mm:ss"

        cmBx_addEmp_dept_Update()

        cmBx_addEmp_desig_Update()

        bday.Text = Format(date_bday.Value, "yyyy-MM-dd")
        oras.Text = Format(dtp_calltime.Value, "HH:mm:ss")
        Dim year As Integer = Today.Year


    End Sub




    Private Sub btn_addemp_cancel_Click(sender As Object, e As EventArgs) Handles btn_addemp_cancel.Click
        clear_form_addnew_emp()
        Me.Hide()

    End Sub
    '-------ADD
    Private Sub btn_addemp_addnew_Click(sender As Object, e As EventArgs) Handles btn_addemp_addnew.Click
        Dim number As Integer

        Randomize()

        number = CInt(Math.Floor((999 - 100 + 1) * Rnd())) + 100

        txBx_addEmp_randomNum.Text = txBxMgc_addEmp_idDep.Text & number


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader


        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into aaa_pns.tbl_employees (employee_num, id_work, id_department, first_name, last_name, contact_number, birthdate, gender, photo, status, call_time, gross_pay) values ('" & txBx_addEmp_randomNum.Text & "', '" & txBxMgc_addEmp_idDesig.Text & "' , '" & txBxMgc_addEmp_idDep.Text & "', '" & txBx_addEmp_fname.Text & "' , '" & txBx_addEmp_lname.Text & "', '" & txBx_addEmp_num.Text & "', '" & bday.Text & "', '" & cmBx_addEmp_gender.selectedValue & "', @Photo, '" & cmBx_addEmp_status.selectedValue & "', '" & oras.Text & "', '" & txBx_addEmp_grossPay.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.Parameters.AddWithValue("@Photo", arrImage)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data saved.")
            MysqlConn.Close()

            loadt_dg_employ_ADD()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        '-------------------------------------------------------------------
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into tbl_deduction (emp_num, sss, pagibig, philhealth, tax) values ('" & txBx_addEmp_randomNum.Text & "', '" & txBx_addEmp_sss.Text & "', '" & txBx_addEmp_Pagibig.Text & "' , '" & txBx_addEmp_Philhealth.Text & "', '" & txBx_addEmp_tax.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        '-------------------------------------------------------------

        clear_form_addnew_emp()
        loadt_dg_employ_ADD()

    End Sub

    '------UPDATE
    Private Sub btn_addemp_UPDATE_Click(sender As Object, e As EventArgs) Handles btn_addemp_UPDATE.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader


        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE tbl_employees set id_work = '" & txBxMgc_addEmp_idDesig.Text & "', id_department = '" & txBxMgc_addEmp_idDep.Text & "', first_name = '" & txBx_addEmp_fname.Text & "', last_name = '" & txBx_addEmp_lname.Text & "', contact_number = '" & txBx_addEmp_randomNum.Text & "', birthdate = '" & bday.Text & "', gender = '" & cmBx_addEmp_gender.selectedValue & "', photo = @Photo, status = '" & cmBx_addEmp_status.selectedValue & "', call_time =  '" & oras.Text & "', gross_pay = '" & txBx_addEmp_grossPay.Text & "' where tbl_employees.employee_num = " & txBx_addEmp_randomNum.Text & ""
            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.Parameters.AddWithValue("@Photo", arrImage)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Update Complete")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Me.Show()
        Finally
            MysqlConn.Dispose()
        End Try
        '-----------------------------------
        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "UPDATE tbl_deduction Set sss = '" & txBx_addEmp_sss.Text & "', pagibig = '" & txBx_addEmp_Pagibig.Text & "', philhealth = '" & txBx_addEmp_Philhealth.Text & "', tax = '" & txBx_addEmp_tax.Text & "' WHERE emp_num = '" & txBx_addEmp_randomNum.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader

            MessageBox.Show("Successfully Updated!")


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


        clear_form_addnew_emp()
        loadt_dg_employ_ADD()
    End Sub

    Private Sub btn_exit_uiadmin_Click(sender As Object, e As EventArgs) Handles btn_exit_uiadmin.Click
        clear_form_addnew_emp()
        Me.Hide()
    End Sub

    Private Sub cmBx_addEmp_dept_onItemSelected(sender As Object, e As EventArgs) Handles cmBx_addEmp_dept.onItemSelected
        transferDepId_txbxMgc_addEmp()
    End Sub

    Private Sub cmBx_addEmp_desig_onItemSelected(sender As Object, e As EventArgs) Handles cmBx_addEmp_desig.onItemSelected
        transferDesigId_txbxMgc_addEmp()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "Select id_department, salary_work from tbl_designation where id_work = '" & txBxMgc_addEmp_idDesig.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read

                Dim sGrossPay = READER.GetString("salary_work")
                Dim sId_dep = READER.GetString("id_department")

                txBx_addEmp_grossPay.Text = sGrossPay
                txBxMgc_addEmp_idDep.Text = sId_dep

            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub btn_addEmp_browse_Click(sender As Object, e As EventArgs) Handles btn_addEmp_browse.Click
        Try
            a.Filter = "Image files | *.jpg"
            If a.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(a.FileName)
                lbl_addEmp_browse.Text = a.FileName.ToString
                PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txBxMgc_addEmp_idDep_TextChanged(sender As Object, e As EventArgs) Handles txBxMgc_addEmp_idDep.TextChanged
        cmBx_addEmp_dept.selectedIndex = txBxMgc_addEmp_idDep.Text - 1

    End Sub

    Private Sub txBx_addEmp_randomNum_OnValueChanged(sender As Object, e As EventArgs) Handles txBx_addEmp_randomNum.OnValueChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "Select e.id_work, first_name, last_name, contact_number, birthdate, gender, status, call_time, photo, salary_work, sss, pagibig, philhealth, tax from tbl_employees e INNER JOIN tbl_designation w on e.id_work = w.id_work INNER JOIN tbl_deduction d on e.employee_num = d.emp_num where e.employee_num = '" & txBx_addEmp_randomNum.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim getWork = READER.GetString("id_work")
                'Dim getDep = READER.GetString("id_department")
                Dim getFname = READER.GetString("first_name")
                Dim getLname = READER.GetString("last_name")
                Dim getCnum = READER.GetString("contact_number")
                Dim getBday = READER.GetString("birthdate")
                Dim getGender = READER.GetString("gender")
                Dim getStatus = READER.GetString("status")
                Dim getCalltime = READER.GetString("call_time")

                Dim byteImage() As Byte = READER("photo")
                Dim ms As New System.IO.MemoryStream(byteImage)
                PictureBox1.Image = Image.FromStream(ms)
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

                Dim getsalary = READER.GetString("salary_work")
                Dim getsss = READER.GetString("sss")
                Dim getpagibig = READER.GetString("pagibig")
                Dim getphil = READER.GetString("philhealth")
                Dim getTax = READER.GetString("tax")

                txBx_addEmp_grossPay.Text = getsalary
                txBx_addEmp_sss.Text = getsss
                txBx_addEmp_Pagibig.Text = getpagibig
                txBx_addEmp_Philhealth.Text = getphil
                txBx_addEmp_tax.Text = getTax

                cmBx_addEmp_desig.selectedIndex = getWork - 1
                'cmBx_addEmp_dept.selectedIndex = getDep + 1
                txBx_addEmp_fname.Text = getFname

                txBx_addEmp_lname.Text = getLname

                txBx_addEmp_num.Text = getCnum
                date_bday.Value = getBday

                If getGender = "Male" Then
                    Dim sex = 1
                    cmBx_addEmp_gender.selectedIndex = sex - 1
                ElseIf getGender = "Female" Then
                    Dim sex = 2
                    cmBx_addEmp_gender.selectedIndex = sex - 1
                End If
                '''''Regular
                '''''Inactive
                '''''Provisionary
                '''''Trainee
                If getStatus = "Regular" Then
                    Dim stat = 0
                    cmBx_addEmp_status.selectedIndex = stat
                ElseIf getStatus = "Inactive" Then
                    Dim stat = 1
                    cmBx_addEmp_status.selectedIndex = stat
                ElseIf getStatus = "Provisionary" Then
                    Dim stat = 2
                    cmBx_addEmp_status.selectedIndex = stat
                ElseIf getStatus = "Trainee" Then
                    Dim stat = 3
                    cmBx_addEmp_status.selectedIndex = stat
                End If

                dtp_calltime.Text = getCalltime

            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub date_bday_onValueChanged(sender As Object, e As EventArgs) Handles date_bday.onValueChanged
        bday.Text = Format(date_bday.Value, "yyyy-MM-dd")
    End Sub

    Private Sub dtp_calltime_ValueChanged(sender As Object, e As EventArgs) Handles dtp_calltime.ValueChanged
        oras.Text = Format(dtp_calltime.Value, "HH:mm:ss")
    End Sub


End Class