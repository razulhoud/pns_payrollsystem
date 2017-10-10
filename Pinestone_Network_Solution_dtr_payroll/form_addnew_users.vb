
Public Class form_addnew_users
    Private Sub btn_signin_cancel_Click(sender As Object, e As EventArgs) Handles btn_CancelAddNewUsers.Click
        Me.Hide()
        txBx_signup_name.ResetText()
        txBx_signup_username.ResetText()
        txBx_signup_repwd.ResetText()
        txBx_signup_pwd.ResetText()
    End Sub

    Private Sub txBx_signup_repwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txBx_signup_repwd.KeyPress
        txBx_signup_repwd.isPassword = True
    End Sub

    Private Sub txBx_signup_pwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txBx_signup_pwd.KeyPress
        txBx_signup_pwd.isPassword = True
    End Sub

    Private Sub btn_showPass_pwd_MouseDown(sender As Object, e As MouseEventArgs)
        txBx_signup_pwd.isPassword = False
    End Sub

    Private Sub btn_showPass_pwd_MouseUp(sender As Object, e As MouseEventArgs)
        txBx_signup_pwd.isPassword = True
    End Sub

    Private Sub btn_showPass_repwd_MouseDown(sender As Object, e As MouseEventArgs)
        txBx_signup_repwd.isPassword = False
    End Sub

    Private Sub btn_showPass_repwd_MouseUp(sender As Object, e As MouseEventArgs)
        txBx_signup_repwd.isPassword = True
    End Sub

    Private Sub btn_loginA_signunp_Click(sender As Object, e As EventArgs) Handles btn_addUser.Click
        lbl_addUser1.Visible = False
        lbl_addUser2.Visible = False
        btn_addUser.Visible = False

        lbl_editUser1.Visible = True
        lbl_editUser2.Visible = True
        btn_updateUser.Visible = True


        txBxMgc_idUser.Clear()
        txBx_signup_name.ResetText()
        txBx_signup_username.ResetText()

        txBx_signup_pwd.Enabled = True
        txBx_signup_repwd.Enabled = True

        txBx_signup_pwd.ResetText()
        txBx_signup_repwd.ResetText()


        adduser()


    End Sub

    Private Sub btn_exit_uiadmin_Click(sender As Object, e As EventArgs) Handles btn_exit_uiadmin.Click
        Me.Hide()
    End Sub

    Private Sub btn_updateUser_Click(sender As Object, e As EventArgs) Handles btn_updateUser.Click

        updateUser()
        txBx_signup_name.ResetText()
        txBx_signup_username.ResetText()
        Me.Hide()

    End Sub
End Class