Imports MySql.Data.MySqlClient
Module users_code
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Public Sub loadt_dg_users()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try

            MysqlConn.Open()

            Dim Query As String
            Query = "SELECT id as 'ID', name as 'Name', username as 'Username' from tbl_users"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Interface_admin.dg_users.DataSource = bSource

            SDA.Update(dbDataSet)

            MysqlConn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub dg_buttonForUser()
        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()

        btn.HeaderText = ""
        btn.Name = "btnEdit"
        btn.Text = "Edit"
        btn.FlatStyle = FlatStyle.Flat

        btn.UseColumnTextForButtonValue = True
        Interface_admin.dg_users.Columns.Add(btn)
    End Sub



    Public Sub adduser()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader
        Dim Empty As String = ""

        If (((form_addnew_users.txBx_signup_name.Text IsNot "") And (form_addnew_users.txBx_signup_name.Text IsNot "")) And ((form_addnew_users.txBx_signup_pwd.Text IsNot "") And (form_addnew_users.txBx_signup_repwd.Text IsNot ""))) And (form_addnew_users.txBx_signup_pwd.Text = form_addnew_users.txBx_signup_repwd.Text) Then
            Dim pwd As String
            pwd = form_addnew_users.txBx_signup_pwd.Text

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "insert into aaa_pns.tbl_users (name, username, password, active) values ( '" & form_addnew_users.txBx_signup_name.Text & "' , '" & form_addnew_users.txBx_signup_username.Text & "' , '" & pwd & "' , 1)"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Data saved.")
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            loadt_dg_users()

        Else
            MessageBox.Show("Password doesn't match/Fill up the text boxes.")
        End If

    End Sub
    Public Sub updateUser()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader


        Try
                MysqlConn.Open()

                Dim Query As String
            Query = "UPDATE tbl_users SET name = '" & form_addnew_users.txBx_signup_name.Text & "', username = '" & form_addnew_users.txBx_signup_username.Text & "'  WHERE id = '" & form_addnew_users.txBxMgc_idUser.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader
            Interface_admin.lbl_mgc_username.Text = form_addnew_users.txBx_signup_username.Text
            Interface_admin.lbl_Name_admin.Text = form_addnew_users.txBx_signup_name.Text
            MessageBox.Show("Successfully Updated!")


            MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

        loadt_dg_users()

    End Sub


End Module
