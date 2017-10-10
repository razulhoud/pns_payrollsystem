Imports System.IO

Imports MySql.Data.MySqlClient
Public Class Login_DTR
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand


    Private Sub Timer_tick1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        lbl_login_time.Text = TimeOfDay
    End Sub
    Private Sub Login_DTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_login_date.Text = Format(Date.Today, "MMM dd, yyyy")
        lbl_login_time.Text = TimeOfDay




    End Sub
    Private Sub label_link_admin_login_Click(sender As Object, e As EventArgs) Handles label_link_admin_login.Click


    End Sub

    Private Sub btn_exit_loginadmin_Click(sender As Object, e As EventArgs) Handles btn_exit_loginadmin.Click
        Application.Exit()

    End Sub
    Private Sub Login_DTR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the apps", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub txBx_dtr_id_OnValueChanged(sender As Object, e As EventArgs) Handles txBx_dtr_empNum.OnValueChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;username=root;database=aaa_pns"
        Dim READER As MySqlDataReader
        picBx_login_empPic.Image = Image.FromFile("C:\Users\art\Documents\Visual Studio 2015\Projects\Pinestone_Network_Solution_dtr_payroll\Pinestone_Network_Solution_dtr_payroll\Resources\User_96px.png")
        lbl_login_empInfo.Text = "No Employee Found"

        lbl_login_status.Text = "OUT"
        lbl_login_IS_IN.Text = 0
        btn_login_out.Visible = False
        btn_login_in.Visible = True
        lbl_test_TimeIn.ResetText()
        lbl_testTimeOut.ResetText()
        lbl_test_TimeIn2.ResetText()
        lbl_callTime.ResetText()
        lbl_time_late.ResetText()
        lbl_testTotal.ResetText()

        Try
                MysqlConn.Open()
                Dim Query As String

            Query = "Select first_name, last_name, department_name, photo, is_in, call_time from tbl_employees x inner join tbl_department y on x.id_department = y.id_department where x.employee_num like '" & txBx_dtr_empNum.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                While READER.Read
                    If (IsDBNull(READER("photo"))) Then

                        picBx_login_empPic.Image = Nothing


                    Else
                        Dim byteImage() As Byte = READER("photo")
                        Dim ms As New System.IO.MemoryStream(byteImage)
                        picBx_login_empPic.Image = Image.FromStream(ms)
                        picBx_login_empPic.SizeMode = PictureBoxSizeMode.Zoom

                        Dim fName = READER.GetString("first_name")
                        Dim lName = READER.GetString("last_name")
                        Dim dName = READER.GetString("department_name")
                    Dim iName = READER.GetInt16("is_in")
                    '-------------------------------------------------------------
                    Dim gCTime = READER.GetString("call_time")
                    lbl_callTime.Text = gCTime
                    Dim callTime As DateTime = gCTime
                    Dim lateTime As DateTime = Format(TimeOfDay, "HH:mm:ss")
                    Dim totalLate As TimeSpan = lateTime.Subtract(callTime)
                    lbl_time_late.Text = totalLate.TotalHours
                    '-------------------------------------------------------------

                    lbl_login_empInfo.Text = (fName & " " & lName & Environment.NewLine & dName)
                    lbl_login_IS_IN.Text = iName
                        If lbl_login_IS_IN.Text = 1 Then
                            btn_login_out.Visible = True
                            btn_login_in.Visible = False

                            lbl_login_status.Text = "IN"

                        End If


                    End If

                End While
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try


            Try
                MysqlConn.Open()
                Dim Query As String

            Query = "Select time_in from tbl_dtr where employee_num = '" & txBx_dtr_empNum.Text & "' AND time_out = time_in"
            COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                While READER.Read
                Dim in_dtr = READER.GetString("time_in")

                lbl_test_TimeIn.Text = (in_dtr) '"yyyy, MM, dd, HH, mm, ss") '0000-00-00 00:00:00
                lbl_test_TimeIn2.Text = in_dtr


                Dim start As DateTime = in_dtr
                Dim stops As DateTime = Date.Today.ToString("yyyy-MM-dd") & " " & Format(TimeOfDay, "HH:mm:ss")
                Dim span As TimeSpan = stops.Subtract(start)
                Dim eight As Double = 8.0

                If span.TotalHours < eight Then

                    lbl_testTotal.Text = span.TotalHours
                Else
                    lbl_testTotal.Text = "8.00"

                End If

            End While
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try



    End Sub

    Private Sub txBx_dtr_empNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txBx_dtr_empNum.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    '///////////////////////BUTTON INNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
    Private Sub btn_login_in_MouseDown(sender As Object, e As EventArgs) Handles btn_login_in.MouseDown

        dtr_timeIn_emp()
    End Sub
    Private Sub btn_login_in_MouseUp(sender As Object, e As EventArgs) Handles btn_login_in.MouseUp

        dtr_timeIn_emp_IS_IN()


    End Sub
    '///////////////////////////////////////////////////////////////////

    '-----------------------------------------------------------------------------------------------------------------------

    '///////////////////////BUTTON OUTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT

    Private Sub btn_login_out_MouseDown(sender As Object, e As EventArgs) Handles btn_login_out.MouseDown

        dtr_timeOut_emp()


    End Sub

    Private Sub btn_login_out_MouseUp(sender As Object, e As EventArgs) Handles btn_login_out.MouseUp

        dtr_timeOut_emp_IS_IN()

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles btn_loginDtr_loginAdmin.Click
        txBx_dtr_empNum.ResetText()
        log_in.Show()
        Me.Hide()

    End Sub

    Private Sub btn_loginDtr_viewDtr_Click(sender As Object, e As EventArgs) Handles btn_loginDtr_viewDtr.Click
        If (txBx_dtr_empNum.Text IsNot "") Then
            loadt_dg_dtr_outside()

            form_view_empDtr.Show()
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        txBx_dtr_empNum.ResetText()
    End Sub



    '//////////////////////////////////////////////////////////////////

End Class