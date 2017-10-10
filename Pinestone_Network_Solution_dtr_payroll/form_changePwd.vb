Imports MySql.Data.MySqlClient
Public Class form_changePwd
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btn_accptNewPwd_Click(sender As Object, e As EventArgs) Handles btn_accptNewPwd.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader


        If (((txBx_currentPwd.Text = Interface_admin.lbl_mgc_password.Text) And (txBx_newPwd.Text = txBx_reNewPwd.Text)) And ((txBx_currentPwd.Text IsNot "") And (txBx_newPwd.Text IsNot ""))) And (txBx_reNewPwd.Text IsNot "") Then

            Try
                MysqlConn.Open()

                Dim Query As String
                Query = "UPDATE tbl_users SET  password = '" & txBx_newPwd.Text & "' WHERE id = '" & Interface_admin.lbl_mgc_id.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)

                READER = COMMAND.ExecuteReader


                Interface_admin.lbl_mgc_password.Text = txBx_newPwd.Text
                MessageBox.Show("Successfully Updated!")

                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try


        Else
            MessageBox.Show("Invalid Inputs")
        End If
    End Sub

    Private Sub btn_cancelNewPwd_Click(sender As Object, e As EventArgs) Handles btn_cancelNewPwd.Click
        txBx_currentPwd.ResetText()
        txBx_newPwd.ResetText()
        txBx_reNewPwd.ResetText()
        Me.Hide()
    End Sub

    Private Sub btn_exit_uiadmin_Click(sender As Object, e As EventArgs) Handles btn_exit_uiadmin.Click
        txBx_currentPwd.ResetText()
        txBx_newPwd.ResetText()
        txBx_reNewPwd.ResetText()
        Me.Hide()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class