Imports MySql.Data.MySqlClient
Module dtr_inside_code
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim bSource As New BindingSource

    Public Sub loadt_dg_dtr_insidePLUSBUTTON()
        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.HeaderText = ""
        btn.Name = "btnEdit"
        btn.Text = "Cuts"
        btn.FlatStyle = FlatStyle.Flat
        btn.UseColumnTextForButtonValue = True
        Interface_admin.dg_dtr_inside.Columns.Add(btn)
    End Sub

    Public Sub loadt_dg_dtr_insidePLUSBUTTON2()
        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.HeaderText = ""
        btn.Name = "btnEdit"
        btn.Text = "Remarks"
        btn.FlatStyle = FlatStyle.Flat
        btn.UseColumnTextForButtonValue = True
        Interface_admin.dg_dtr_inside.Columns.Add(btn)
    End Sub
End Module
