<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_DTR
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_DTR))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lbl_login_empInfo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_login_time = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_login_date = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txBx_dtr_empNum = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_login_in = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_login_out = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_exit_loginadmin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_login_status = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_login_IS_IN = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.lbl_test_TimeIn = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_testTimeOut = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_testTotal = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_test_TimeIn2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_loginDtr_loginAdmin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_loginDtr_viewDtr = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.label_link_admin_login = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.picBx_login_empPic = New System.Windows.Forms.PictureBox()
        Me.lbl_time_late = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_callTime = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_exit_loginadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBx_login_empPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(327, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 115)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = " N "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 115)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "P   N   S"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(444, 140)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(115, 36)
        Me.BunifuCustomLabel5.TabIndex = 26
        Me.BunifuCustomLabel5.Text = "System"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(270, 140)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(183, 36)
        Me.BunifuCustomLabel6.TabIndex = 25
        Me.BunifuCustomLabel6.Text = "Attendance"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 4
        Me.BunifuSeparator3.Location = New System.Drawing.Point(6, 184)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(844, 10)
        Me.BunifuSeparator3.TabIndex = 27
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 4
        Me.BunifuSeparator1.Location = New System.Drawing.Point(233, 200)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(38, 439)
        Me.BunifuSeparator1.TabIndex = 28
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'lbl_login_empInfo
        '
        Me.lbl_login_empInfo.AutoSize = True
        Me.lbl_login_empInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_empInfo.ForeColor = System.Drawing.Color.Black
        Me.lbl_login_empInfo.Location = New System.Drawing.Point(10, 488)
        Me.lbl_login_empInfo.Name = "lbl_login_empInfo"
        Me.lbl_login_empInfo.Size = New System.Drawing.Size(138, 17)
        Me.lbl_login_empInfo.TabIndex = 30
        Me.lbl_login_empInfo.Text = "No Employee Found"
        '
        'lbl_login_time
        '
        Me.lbl_login_time.AutoSize = True
        Me.lbl_login_time.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_login_time.Location = New System.Drawing.Point(546, 229)
        Me.lbl_login_time.Name = "lbl_login_time"
        Me.lbl_login_time.Size = New System.Drawing.Size(132, 56)
        Me.lbl_login_time.TabIndex = 31
        Me.lbl_login_time.Text = "Time"
        Me.lbl_login_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_login_date
        '
        Me.lbl_login_date.AutoSize = True
        Me.lbl_login_date.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_login_date.Location = New System.Drawing.Point(592, 285)
        Me.lbl_login_date.Name = "lbl_login_date"
        Me.lbl_login_date.Size = New System.Drawing.Size(103, 42)
        Me.lbl_login_date.TabIndex = 32
        Me.lbl_login_date.Text = "Date"
        '
        'txBx_dtr_empNum
        '
        Me.txBx_dtr_empNum.BackColor = System.Drawing.Color.White
        Me.txBx_dtr_empNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_dtr_empNum.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_dtr_empNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_dtr_empNum.HintForeColor = System.Drawing.Color.IndianRed
        Me.txBx_dtr_empNum.HintText = "Your ID Number"
        Me.txBx_dtr_empNum.isPassword = False
        Me.txBx_dtr_empNum.LineFocusedColor = System.Drawing.Color.Black
        Me.txBx_dtr_empNum.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_dtr_empNum.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_dtr_empNum.LineThickness = 7
        Me.txBx_dtr_empNum.Location = New System.Drawing.Point(406, 396)
        Me.txBx_dtr_empNum.Margin = New System.Windows.Forms.Padding(7)
        Me.txBx_dtr_empNum.Name = "txBx_dtr_empNum"
        Me.txBx_dtr_empNum.Size = New System.Drawing.Size(338, 59)
        Me.txBx_dtr_empNum.TabIndex = 33
        Me.txBx_dtr_empNum.TabStop = False
        Me.txBx_dtr_empNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_login_in
        '
        Me.btn_login_in.Activecolor = System.Drawing.Color.Black
        Me.btn_login_in.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_login_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login_in.BorderRadius = 0
        Me.btn_login_in.ButtonText = "IN"
        Me.btn_login_in.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login_in.DisabledColor = System.Drawing.Color.Gray
        Me.btn_login_in.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_login_in.Iconimage = Nothing
        Me.btn_login_in.Iconimage_right = Nothing
        Me.btn_login_in.Iconimage_right_Selected = Nothing
        Me.btn_login_in.Iconimage_Selected = Nothing
        Me.btn_login_in.IconMarginLeft = 0
        Me.btn_login_in.IconMarginRight = 0
        Me.btn_login_in.IconRightVisible = True
        Me.btn_login_in.IconRightZoom = 0R
        Me.btn_login_in.IconVisible = True
        Me.btn_login_in.IconZoom = 90.0R
        Me.btn_login_in.IsTab = False
        Me.btn_login_in.Location = New System.Drawing.Point(406, 465)
        Me.btn_login_in.Name = "btn_login_in"
        Me.btn_login_in.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_login_in.OnHovercolor = System.Drawing.Color.Black
        Me.btn_login_in.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_login_in.selected = False
        Me.btn_login_in.Size = New System.Drawing.Size(338, 84)
        Me.btn_login_in.TabIndex = 34
        Me.btn_login_in.Text = "IN"
        Me.btn_login_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_login_in.Textcolor = System.Drawing.Color.White
        Me.btn_login_in.TextFont = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_login_out
        '
        Me.btn_login_out.Activecolor = System.Drawing.Color.Black
        Me.btn_login_out.BackColor = System.Drawing.Color.Black
        Me.btn_login_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login_out.BorderRadius = 0
        Me.btn_login_out.ButtonText = "OUT"
        Me.btn_login_out.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login_out.DisabledColor = System.Drawing.Color.Gray
        Me.btn_login_out.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_login_out.Iconimage = Nothing
        Me.btn_login_out.Iconimage_right = Nothing
        Me.btn_login_out.Iconimage_right_Selected = Nothing
        Me.btn_login_out.Iconimage_Selected = Nothing
        Me.btn_login_out.IconMarginLeft = 0
        Me.btn_login_out.IconMarginRight = 0
        Me.btn_login_out.IconRightVisible = True
        Me.btn_login_out.IconRightZoom = 0R
        Me.btn_login_out.IconVisible = True
        Me.btn_login_out.IconZoom = 90.0R
        Me.btn_login_out.IsTab = False
        Me.btn_login_out.Location = New System.Drawing.Point(406, 465)
        Me.btn_login_out.Name = "btn_login_out"
        Me.btn_login_out.Normalcolor = System.Drawing.Color.Black
        Me.btn_login_out.OnHovercolor = System.Drawing.Color.White
        Me.btn_login_out.OnHoverTextColor = System.Drawing.Color.Black
        Me.btn_login_out.selected = False
        Me.btn_login_out.Size = New System.Drawing.Size(338, 84)
        Me.btn_login_out.TabIndex = 35
        Me.btn_login_out.Text = "OUT"
        Me.btn_login_out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_login_out.Textcolor = System.Drawing.Color.White
        Me.btn_login_out.TextFont = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_out.Visible = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_exit_loginadmin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(858, 185)
        Me.Panel1.TabIndex = 42
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(158, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(525, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'btn_exit_loginadmin
        '
        Me.btn_exit_loginadmin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_exit_loginadmin.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit_loginadmin.Image = CType(resources.GetObject("btn_exit_loginadmin.Image"), System.Drawing.Image)
        Me.btn_exit_loginadmin.ImageActive = Nothing
        Me.btn_exit_loginadmin.Location = New System.Drawing.Point(804, 12)
        Me.btn_exit_loginadmin.Name = "btn_exit_loginadmin"
        Me.btn_exit_loginadmin.Size = New System.Drawing.Size(42, 38)
        Me.btn_exit_loginadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btn_exit_loginadmin.TabIndex = 38
        Me.btn_exit_loginadmin.TabStop = False
        Me.btn_exit_loginadmin.Zoom = 10
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 542)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(54, 17)
        Me.BunifuCustomLabel1.TabIndex = 43
        Me.BunifuCustomLabel1.Text = "Status :"
        Me.BunifuCustomLabel1.Visible = False
        '
        'lbl_login_status
        '
        Me.lbl_login_status.AutoSize = True
        Me.lbl_login_status.BackColor = System.Drawing.Color.Black
        Me.lbl_login_status.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_status.ForeColor = System.Drawing.Color.White
        Me.lbl_login_status.Location = New System.Drawing.Point(68, 542)
        Me.lbl_login_status.Name = "lbl_login_status"
        Me.lbl_login_status.Size = New System.Drawing.Size(59, 16)
        Me.lbl_login_status.TabIndex = 44
        Me.lbl_login_status.Text = "Nothing"
        Me.lbl_login_status.Visible = False
        '
        'lbl_login_IS_IN
        '
        Me.lbl_login_IS_IN.AutoSize = True
        Me.lbl_login_IS_IN.BackColor = System.Drawing.Color.Transparent
        Me.lbl_login_IS_IN.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login_IS_IN.ForeColor = System.Drawing.Color.Gainsboro
        Me.lbl_login_IS_IN.Location = New System.Drawing.Point(508, 552)
        Me.lbl_login_IS_IN.Name = "lbl_login_IS_IN"
        Me.lbl_login_IS_IN.Size = New System.Drawing.Size(0, 42)
        Me.lbl_login_IS_IN.TabIndex = 45
        Me.lbl_login_IS_IN.Visible = False
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.PictureBox1
        Me.BunifuDragControl2.Vertical = True
        '
        'lbl_test_TimeIn
        '
        Me.lbl_test_TimeIn.AutoSize = True
        Me.lbl_test_TimeIn.BackColor = System.Drawing.Color.Transparent
        Me.lbl_test_TimeIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_test_TimeIn.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_test_TimeIn.Location = New System.Drawing.Point(260, 569)
        Me.lbl_test_TimeIn.Name = "lbl_test_TimeIn"
        Me.lbl_test_TimeIn.Size = New System.Drawing.Size(68, 21)
        Me.lbl_test_TimeIn.TabIndex = 46
        Me.lbl_test_TimeIn.Text = "TIME IN"
        Me.lbl_test_TimeIn.Visible = False
        '
        'lbl_testTimeOut
        '
        Me.lbl_testTimeOut.AutoSize = True
        Me.lbl_testTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.lbl_testTimeOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_testTimeOut.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_testTimeOut.Location = New System.Drawing.Point(260, 596)
        Me.lbl_testTimeOut.Name = "lbl_testTimeOut"
        Me.lbl_testTimeOut.Size = New System.Drawing.Size(77, 21)
        Me.lbl_testTimeOut.TabIndex = 47
        Me.lbl_testTimeOut.Text = "TimeOut"
        Me.lbl_testTimeOut.Visible = False
        '
        'lbl_testTotal
        '
        Me.lbl_testTotal.AutoSize = True
        Me.lbl_testTotal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_testTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_testTotal.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_testTotal.Location = New System.Drawing.Point(260, 618)
        Me.lbl_testTotal.Name = "lbl_testTotal"
        Me.lbl_testTotal.Size = New System.Drawing.Size(49, 21)
        Me.lbl_testTotal.TabIndex = 48
        Me.lbl_testTotal.Text = "Total"
        Me.lbl_testTotal.Visible = False
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(10, 577)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(78, 17)
        Me.BunifuCustomLabel2.TabIndex = 51
        Me.BunifuCustomLabel2.Text = "Time in at :"
        Me.BunifuCustomLabel2.Visible = False
        '
        'lbl_test_TimeIn2
        '
        Me.lbl_test_TimeIn2.AutoSize = True
        Me.lbl_test_TimeIn2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_test_TimeIn2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_test_TimeIn2.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_test_TimeIn2.Location = New System.Drawing.Point(94, 577)
        Me.lbl_test_TimeIn2.Name = "lbl_test_TimeIn2"
        Me.lbl_test_TimeIn2.Size = New System.Drawing.Size(24, 17)
        Me.lbl_test_TimeIn2.TabIndex = 52
        Me.lbl_test_TimeIn2.Text = "...."
        Me.lbl_test_TimeIn2.Visible = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(702, 407)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(42, 38)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 53
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'btn_loginDtr_loginAdmin
        '
        Me.btn_loginDtr_loginAdmin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_loginDtr_loginAdmin.BackColor = System.Drawing.Color.White
        Me.btn_loginDtr_loginAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_loginDtr_loginAdmin.BorderRadius = 0
        Me.btn_loginDtr_loginAdmin.ButtonText = "Login as Admin"
        Me.btn_loginDtr_loginAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_loginDtr_loginAdmin.DisabledColor = System.Drawing.Color.Gray
        Me.btn_loginDtr_loginAdmin.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_loginDtr_loginAdmin.Iconimage = Nothing
        Me.btn_loginDtr_loginAdmin.Iconimage_right = CType(resources.GetObject("btn_loginDtr_loginAdmin.Iconimage_right"), System.Drawing.Image)
        Me.btn_loginDtr_loginAdmin.Iconimage_right_Selected = Nothing
        Me.btn_loginDtr_loginAdmin.Iconimage_Selected = Nothing
        Me.btn_loginDtr_loginAdmin.IconMarginLeft = 0
        Me.btn_loginDtr_loginAdmin.IconMarginRight = 0
        Me.btn_loginDtr_loginAdmin.IconRightVisible = True
        Me.btn_loginDtr_loginAdmin.IconRightZoom = 0R
        Me.btn_loginDtr_loginAdmin.IconVisible = True
        Me.btn_loginDtr_loginAdmin.IconZoom = 60.0R
        Me.btn_loginDtr_loginAdmin.IsTab = False
        Me.btn_loginDtr_loginAdmin.Location = New System.Drawing.Point(664, 587)
        Me.btn_loginDtr_loginAdmin.Name = "btn_loginDtr_loginAdmin"
        Me.btn_loginDtr_loginAdmin.Normalcolor = System.Drawing.Color.White
        Me.btn_loginDtr_loginAdmin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_loginDtr_loginAdmin.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_loginDtr_loginAdmin.selected = False
        Me.btn_loginDtr_loginAdmin.Size = New System.Drawing.Size(186, 52)
        Me.btn_loginDtr_loginAdmin.TabIndex = 50
        Me.btn_loginDtr_loginAdmin.Text = "Login as Admin"
        Me.btn_loginDtr_loginAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_loginDtr_loginAdmin.Textcolor = System.Drawing.Color.Black
        Me.btn_loginDtr_loginAdmin.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_loginDtr_viewDtr
        '
        Me.btn_loginDtr_viewDtr.Activecolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_loginDtr_viewDtr.BackColor = System.Drawing.Color.White
        Me.btn_loginDtr_viewDtr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_loginDtr_viewDtr.BorderRadius = 0
        Me.btn_loginDtr_viewDtr.ButtonText = "View your DTR"
        Me.btn_loginDtr_viewDtr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_loginDtr_viewDtr.DisabledColor = System.Drawing.Color.Gray
        Me.btn_loginDtr_viewDtr.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_loginDtr_viewDtr.Iconimage = Nothing
        Me.btn_loginDtr_viewDtr.Iconimage_right = CType(resources.GetObject("btn_loginDtr_viewDtr.Iconimage_right"), System.Drawing.Image)
        Me.btn_loginDtr_viewDtr.Iconimage_right_Selected = Nothing
        Me.btn_loginDtr_viewDtr.Iconimage_Selected = Nothing
        Me.btn_loginDtr_viewDtr.IconMarginLeft = 0
        Me.btn_loginDtr_viewDtr.IconMarginRight = 0
        Me.btn_loginDtr_viewDtr.IconRightVisible = True
        Me.btn_loginDtr_viewDtr.IconRightZoom = 0R
        Me.btn_loginDtr_viewDtr.IconVisible = True
        Me.btn_loginDtr_viewDtr.IconZoom = 60.0R
        Me.btn_loginDtr_viewDtr.IsTab = False
        Me.btn_loginDtr_viewDtr.Location = New System.Drawing.Point(472, 587)
        Me.btn_loginDtr_viewDtr.Name = "btn_loginDtr_viewDtr"
        Me.btn_loginDtr_viewDtr.Normalcolor = System.Drawing.Color.White
        Me.btn_loginDtr_viewDtr.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_loginDtr_viewDtr.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_loginDtr_viewDtr.selected = False
        Me.btn_loginDtr_viewDtr.Size = New System.Drawing.Size(186, 52)
        Me.btn_loginDtr_viewDtr.TabIndex = 49
        Me.btn_loginDtr_viewDtr.Text = "View your DTR"
        Me.btn_loginDtr_viewDtr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_loginDtr_viewDtr.Textcolor = System.Drawing.Color.Black
        Me.btn_loginDtr_viewDtr.TextFont = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'label_link_admin_login
        '
        Me.label_link_admin_login.AutoSize = True
        Me.label_link_admin_login.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_link_admin_login.ForeColor = System.Drawing.Color.Black
        Me.label_link_admin_login.Image = CType(resources.GetObject("label_link_admin_login.Image"), System.Drawing.Image)
        Me.label_link_admin_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.label_link_admin_login.Location = New System.Drawing.Point(688, 605)
        Me.label_link_admin_login.Margin = New System.Windows.Forms.Padding(0)
        Me.label_link_admin_login.Name = "label_link_admin_login"
        Me.label_link_admin_login.Size = New System.Drawing.Size(148, 21)
        Me.label_link_admin_login.TabIndex = 37
        Me.label_link_admin_login.Text = "Login as Admin     "
        Me.label_link_admin_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Image = CType(resources.GetObject("BunifuCustomLabel4.Image"), System.Drawing.Image)
        Me.BunifuCustomLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(527, 618)
        Me.BunifuCustomLabel4.Margin = New System.Windows.Forms.Padding(0)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(139, 21)
        Me.BunifuCustomLabel4.TabIndex = 36
        Me.BunifuCustomLabel4.Text = "View your DTR     "
        Me.BunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuCustomLabel4.Visible = False
        '
        'picBx_login_empPic
        '
        Me.picBx_login_empPic.BackColor = System.Drawing.Color.Transparent
        Me.picBx_login_empPic.Image = Global.Pinestone_Network_Solution_dtr_payroll.My.Resources.Resources.User_96px
        Me.picBx_login_empPic.Location = New System.Drawing.Point(50, 315)
        Me.picBx_login_empPic.Name = "picBx_login_empPic"
        Me.picBx_login_empPic.Size = New System.Drawing.Size(141, 140)
        Me.picBx_login_empPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBx_login_empPic.TabIndex = 29
        Me.picBx_login_empPic.TabStop = False
        '
        'lbl_time_late
        '
        Me.lbl_time_late.AutoSize = True
        Me.lbl_time_late.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time_late.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time_late.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_time_late.Location = New System.Drawing.Point(260, 542)
        Me.lbl_time_late.Name = "lbl_time_late"
        Me.lbl_time_late.Size = New System.Drawing.Size(88, 21)
        Me.lbl_time_late.TabIndex = 54
        Me.lbl_time_late.Text = "TIME LATE"
        Me.lbl_time_late.Visible = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Maroon
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(198, 569)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(51, 21)
        Me.BunifuCustomLabel3.TabIndex = 55
        Me.BunifuCustomLabel3.Text = "IN     :"
        Me.BunifuCustomLabel3.Visible = False
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Maroon
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(186, 596)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(63, 21)
        Me.BunifuCustomLabel7.TabIndex = 56
        Me.BunifuCustomLabel7.Text = "OUT    :"
        Me.BunifuCustomLabel7.Visible = False
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.Maroon
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(190, 542)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(59, 21)
        Me.BunifuCustomLabel8.TabIndex = 57
        Me.BunifuCustomLabel8.Text = "LATE  :"
        Me.BunifuCustomLabel8.Visible = False
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.Maroon
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(169, 618)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(80, 21)
        Me.BunifuCustomLabel9.TabIndex = 58
        Me.BunifuCustomLabel9.Text = "HOURS   :"
        Me.BunifuCustomLabel9.Visible = False
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.Maroon
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(177, 521)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(72, 21)
        Me.BunifuCustomLabel10.TabIndex = 59
        Me.BunifuCustomLabel10.Text = "CTIME  :"
        Me.BunifuCustomLabel10.Visible = False
        '
        'lbl_callTime
        '
        Me.lbl_callTime.AutoSize = True
        Me.lbl_callTime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_callTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_callTime.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_callTime.Location = New System.Drawing.Point(260, 521)
        Me.lbl_callTime.Name = "lbl_callTime"
        Me.lbl_callTime.Size = New System.Drawing.Size(72, 21)
        Me.lbl_callTime.TabIndex = 60
        Me.lbl_callTime.Text = "CTIME  :"
        Me.lbl_callTime.Visible = False
        '
        'Login_DTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(858, 648)
        Me.Controls.Add(Me.lbl_callTime)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.lbl_time_late)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.lbl_test_TimeIn2)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.btn_loginDtr_loginAdmin)
        Me.Controls.Add(Me.btn_loginDtr_viewDtr)
        Me.Controls.Add(Me.lbl_testTotal)
        Me.Controls.Add(Me.lbl_testTimeOut)
        Me.Controls.Add(Me.lbl_test_TimeIn)
        Me.Controls.Add(Me.lbl_login_IS_IN)
        Me.Controls.Add(Me.lbl_login_status)
        Me.Controls.Add(Me.label_link_admin_login)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.txBx_dtr_empNum)
        Me.Controls.Add(Me.lbl_login_date)
        Me.Controls.Add(Me.lbl_login_time)
        Me.Controls.Add(Me.lbl_login_empInfo)
        Me.Controls.Add(Me.picBx_login_empPic)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.BunifuSeparator3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btn_login_in)
        Me.Controls.Add(Me.btn_login_out)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login_DTR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pinestone DTR"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_exit_loginadmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBx_login_empPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents picBx_login_empPic As PictureBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lbl_login_empInfo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_login_date As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_login_time As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_login_out As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_login_in As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txBx_dtr_empNum As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents label_link_admin_login As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btn_exit_loginadmin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_login_status As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_login_IS_IN As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents lbl_testTimeOut As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_test_TimeIn As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_testTotal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_loginDtr_loginAdmin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_loginDtr_viewDtr As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_test_TimeIn2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_time_late As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_callTime As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
