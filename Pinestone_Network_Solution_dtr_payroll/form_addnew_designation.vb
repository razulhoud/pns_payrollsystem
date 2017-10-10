Public Class form_addnew_designation

    Private Sub form_addnew_designation_Load(sender As Object, e As EventArgs)

    End Sub
    Private Sub xBx_adddes_sal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txBx_adddes_sal.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub btn_adddesignation_cancel_Click(sender As Object, e As EventArgs) Handles btn_adddesignation_cancel.Click
        txBxMgc_idDep.Text = 0
        txBxMgc_idDesig.Clear()
        txBx_adddes_name.ResetText()
        txBx_adddes_sal.ResetText()


        Me.Hide()

    End Sub

    Private Sub btn_exit_loginadmin_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub btn_addemp_addnew_Click(sender As Object, e As EventArgs) Handles btn_addDesig_addnew.Click
        add_designation()


    End Sub

    Private Sub btn_exit_addDesig_Click(sender As Object, e As EventArgs) Handles btn_exit_addDesig.Click
        Me.Hide()




    End Sub

    Private Sub cmBx_addDes_dept_onItemSelected(sender As Object, e As EventArgs) Handles cmBx_addDes_dept.onItemSelected
        transferDepId_txbxMgc()
    End Sub

    Private Sub btn_addDesig_edit_Click(sender As Object, e As EventArgs) Handles btn_addDesig_edit.Click
        updateDesignation()
    End Sub

End Class