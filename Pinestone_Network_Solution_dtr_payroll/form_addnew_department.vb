Public Class form_addnew_department
    Private Sub btn_exit_adddep_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub btn_adddept_addnew_Click(sender As Object, e As EventArgs) Handles btn_adddept_addnew.Click
        add_department()
        txBx_add_Depname.ResetText()
        Me.Hide()

    End Sub


End Class