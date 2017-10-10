Imports System.IO
Imports MySql.Data.MySqlClient
Public Class form_empPayroll_
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub form_empPayroll__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadt_dg_payroll()
        empPay_dateFrom.Value = Date.Today.ToString("yyyy-MM-dd")
        empPay_date_TO.Value = Date.Today.ToString("yyyy-MM-dd")
        lbl_mgc_dateFROM.Text = Format(empPay_dateFrom.Value, "yyyy-MM-dd")
        lbl_mgc_dateTO.Text = Format(empPay_date_TO.Value, "yyyy-MM-dd")

    End Sub
    Private Sub btn_exit_uiadmin_Click(sender As Object, e As EventArgs) Handles btn_exit_uiadmin.Click
        Me.Hide()
    End Sub

    Private Sub txBx_empPayroll_empNum_OnValueChanged(sender As Object, e As EventArgs) Handles txBx_empPayroll_empNum.OnValueChanged

        '    Query = "Select e.first_name, e.last_name, e.status, w.name_work, p.department_name, e.photo, e.gross_pay, d.sss, d.pagibig, d.philhealth, d.tax, SUM(time_rendered), SUM(time_late), SUM(num_cuts) from tbl_employees e INNER JOIN tbl_designation w on e.id_work = w.id_work INNER JOIN tbl_deduction d on e.employee_num = d.emp_num INNER JOIN tbl_department p on e.id_department = p.id_department INNER JOIN tbl_dtr r on e.employee_num = r.employee_num WHERE (e.employee_num = '" & txBx_empPayroll_empNum.Text & "') AND (date between '" & lbl_mgc_dateFROM.Text & "' and '" & lbl_mgc_dateTO.Text & "')"
        payrollInfos()

    End Sub


    Public Sub payrollInfos()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "Select e.first_name, e.last_name, e.status, w.name_work, p.department_name, photo, e.gross_pay, d.sss, d.pagibig, d.philhealth, d.tax, COALESCE(SUM(time_rendered),0), COALESCE(SUM(time_late),0), COALESCE(SUM(num_cuts),0) from tbl_employees e INNER JOIN tbl_designation w on e.id_work = w.id_work INNER JOIN tbl_deduction d on e.employee_num = d.emp_num INNER JOIN tbl_department p on e.id_department = p.id_department INNER JOIN tbl_dtr r on e.employee_num = r.employee_num WHERE (e.employee_num = '" & txBx_empPayroll_empNum.Text & "') AND (date between '" & lbl_mgc_dateFROM.Text & "' and '" & lbl_mgc_dateTO.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                If (IsDBNull(READER("photo"))) Then

                    PictureBox1.Image = Nothing

                Else

                    Dim byteImage() As Byte = READER("photo")
                    Dim ms As New System.IO.MemoryStream(byteImage)
                    PictureBox1.Image = Image.FromStream(ms)
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

                    Dim gfName = READER.GetString("first_name")
                    Dim glName = READER.GetString("last_name")
                    Dim gWork = READER.GetString("name_work")
                    Dim gdepName = READER.GetString("department_name")
                    Dim gstat = READER.GetString("status")
                    empPay_empDETAIL.Text = (gfName & " " & glName & Environment.NewLine & gWork & Environment.NewLine & gdepName & Environment.NewLine & gstat)

                    Dim gSubTotal = READER.GetString("gross_pay")
                    empPay_txBx_SUBTOTAL.Text = gSubTotal

                    Dim gsss = READER.GetString("sss")
                    empPay_txBx_SSS.Text = gsss

                    Dim gpagibig = READER.GetString("pagibig")
                    empPay_txBx_PAGIBIG.Text = gpagibig

                    Dim ghealth = READER.GetString("philhealth")
                    empPay_txBx_PHIL.Text = ghealth

                    Dim gTax = READER.GetString("tax")
                    empPay_txBx_TAX.Text = gTax

                    Dim gTotaltime = READER.GetString("COALESCE(SUM(time_rendered),0)")
                    empPay_txBx_RENDERED.Text = gTotaltime

                    Dim gTotalLate = READER.GetString("COALESCE(SUM(time_late),0)")
                    empPay_txBx_LATE.Text = gTotalLate

                    Dim gCuts = READER.GetString("COALESCE(SUM(num_cuts),0)")
                    empPay_txBx_CUTS.Text = gCuts



                End If
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub empPay_dateFrom_onValueChanged(sender As Object, e As EventArgs) Handles empPay_dateFrom.onValueChanged
        lbl_mgc_dateFROM.Text = Format(empPay_dateFrom.Value, "yyyy-MM-dd")
        lbl_mgc_dateTO.Text = Format(empPay_date_TO.Value, "yyyy-MM-dd")
        payrollInfos()
    End Sub

    Private Sub empPay_date_TO_onValueChanged(sender As Object, e As EventArgs) Handles empPay_date_TO.onValueChanged
        lbl_mgc_dateFROM.Text = Format(empPay_dateFrom.Value, "yyyy-MM-dd")
        lbl_mgc_dateTO.Text = Format(empPay_date_TO.Value, "yyyy-MM-dd")
        payrollInfos()
    End Sub

    Private Sub btn_adddept_cancel_Click(sender As Object, e As EventArgs) Handles btn_adddept_cancel.Click
        Me.Hide()

    End Sub
End Class