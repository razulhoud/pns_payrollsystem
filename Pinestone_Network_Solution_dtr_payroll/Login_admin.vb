Imports MySql.Data.MySqlClient
Public Class log_in
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub btn_exit_loginadmin_Click(sender As Object, e As EventArgs) Handles btn_exit_loginadmin.Click

        Application.Exit()

    End Sub

    Private Sub BunifuImageButton5_MouseDown(sender As Object, e As MouseEventArgs) 
        txBx_login_pwd.isPassword = False

    End Sub

    Private Sub BunifuImageButton5_MouseUp(sender As Object, e As MouseEventArgs) 
        txBx_login_pwd.isPassword = True

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=database1_final"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from aaa_pns.tbl_users where username ='" & txBx_login_user.Text & "' and password ='" & txBx_login_pwd.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
                Dim getid = READER.GetString("id")
                Dim getName = READER.GetString("name")
                Interface_admin.lbl_mgc_id.Text = getid
                Interface_admin.lbl_Name_admin.Text = getName
            End While

            If count = 1 Then

                MessageBox.Show("Username And password are correct")
                Interface_admin.lbl_mgc_username.Text = txBx_login_user.Text
                Interface_admin.lbl_mgc_password.Text = txBx_login_pwd.Text
                Interface_admin.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username And password are Duplicate")
            Else
                MessageBox.Show("Username And password are not correct")

            End If
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        txBx_login_user.ResetText()

        txBx_login_pwd.ResetText()

    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) 

    End Sub


    Private Sub txBx_login_pwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txBx_login_pwd.KeyPress
        txBx_login_pwd.isPassword = True
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        Me.Hide()
        Login_DTR.Show()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
        Login_DTR.Show()
    End Sub
End Class
