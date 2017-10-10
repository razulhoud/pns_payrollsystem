<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log_in
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(log_in))
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_exit_loginadmin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pnl_login = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txBx_login_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_login = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txBx_login_pwd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_exit_loginadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_login.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.BunifuGradientPanel2
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuImageButton6)
        Me.BunifuGradientPanel2.Controls.Add(Me.btn_exit_loginadmin)
        Me.BunifuGradientPanel2.Controls.Add(Me.pnl_login)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 2
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(290, 436)
        Me.BunifuGradientPanel2.TabIndex = 0
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton6.Image = CType(resources.GetObject("BunifuImageButton6.Image"), System.Drawing.Image)
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(5, 12)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(43, 33)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 16
        Me.BunifuImageButton6.TabStop = False
        Me.BunifuImageButton6.Zoom = 10
        '
        'btn_exit_loginadmin
        '
        Me.btn_exit_loginadmin.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit_loginadmin.Image = CType(resources.GetObject("btn_exit_loginadmin.Image"), System.Drawing.Image)
        Me.btn_exit_loginadmin.ImageActive = Nothing
        Me.btn_exit_loginadmin.Location = New System.Drawing.Point(247, 12)
        Me.btn_exit_loginadmin.Name = "btn_exit_loginadmin"
        Me.btn_exit_loginadmin.Size = New System.Drawing.Size(43, 33)
        Me.btn_exit_loginadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_exit_loginadmin.TabIndex = 8
        Me.btn_exit_loginadmin.TabStop = False
        Me.btn_exit_loginadmin.Zoom = 10
        '
        'pnl_login
        '
        Me.pnl_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnl_login.Controls.Add(Me.PictureBox2)
        Me.pnl_login.Controls.Add(Me.PictureBox5)
        Me.pnl_login.Controls.Add(Me.Panel2)
        Me.pnl_login.Controls.Add(Me.txBx_login_user)
        Me.pnl_login.Controls.Add(Me.btn_login)
        Me.pnl_login.Controls.Add(Me.btn_cancel)
        Me.pnl_login.Controls.Add(Me.txBx_login_pwd)
        Me.pnl_login.Location = New System.Drawing.Point(5, 48)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(274, 360)
        Me.pnl_login.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(223, 194)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(223, 141)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(61, -13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(156, 100)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(54, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " N "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "P   N   S"
        '
        'txBx_login_user
        '
        Me.txBx_login_user.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_login_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_login_user.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txBx_login_user.ForeColor = System.Drawing.Color.White
        Me.txBx_login_user.HintForeColor = System.Drawing.Color.WhiteSmoke
        Me.txBx_login_user.HintText = "Username"
        Me.txBx_login_user.isPassword = False
        Me.txBx_login_user.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_login_user.LineIdleColor = System.Drawing.Color.White
        Me.txBx_login_user.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_login_user.LineThickness = 3
        Me.txBx_login_user.Location = New System.Drawing.Point(8, 143)
        Me.txBx_login_user.Margin = New System.Windows.Forms.Padding(4)
        Me.txBx_login_user.Name = "txBx_login_user"
        Me.txBx_login_user.Size = New System.Drawing.Size(254, 33)
        Me.txBx_login_user.TabIndex = 0
        Me.txBx_login_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_login
        '
        Me.btn_login.Activecolor = System.Drawing.Color.White
        Me.btn_login.BackColor = System.Drawing.Color.White
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.BorderRadius = 0
        Me.btn_login.ButtonText = "LOGIN"
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.DisabledColor = System.Drawing.Color.Gray
        Me.btn_login.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_login.Iconimage = Nothing
        Me.btn_login.Iconimage_right = Nothing
        Me.btn_login.Iconimage_right_Selected = Nothing
        Me.btn_login.Iconimage_Selected = Nothing
        Me.btn_login.IconMarginLeft = 0
        Me.btn_login.IconMarginRight = 0
        Me.btn_login.IconRightVisible = True
        Me.btn_login.IconRightZoom = 0R
        Me.btn_login.IconVisible = True
        Me.btn_login.IconZoom = 90.0R
        Me.btn_login.IsTab = False
        Me.btn_login.Location = New System.Drawing.Point(141, 267)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Normalcolor = System.Drawing.Color.White
        Me.btn_login.OnHovercolor = System.Drawing.Color.White
        Me.btn_login.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_login.selected = False
        Me.btn_login.Size = New System.Drawing.Size(104, 48)
        Me.btn_login.TabIndex = 10
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_login.Textcolor = System.Drawing.Color.Black
        Me.btn_login.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_cancel
        '
        Me.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_cancel.BackColor = System.Drawing.Color.Black
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancel.BorderRadius = 0
        Me.btn_cancel.ButtonText = "CANCEL"
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.DisabledColor = System.Drawing.Color.Gray
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_cancel.Iconimage = Nothing
        Me.btn_cancel.Iconimage_right = Nothing
        Me.btn_cancel.Iconimage_right_Selected = Nothing
        Me.btn_cancel.Iconimage_Selected = Nothing
        Me.btn_cancel.IconMarginLeft = 0
        Me.btn_cancel.IconMarginRight = 0
        Me.btn_cancel.IconRightVisible = True
        Me.btn_cancel.IconRightZoom = 0R
        Me.btn_cancel.IconVisible = True
        Me.btn_cancel.IconZoom = 90.0R
        Me.btn_cancel.IsTab = False
        Me.btn_cancel.Location = New System.Drawing.Point(31, 267)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Normalcolor = System.Drawing.Color.Black
        Me.btn_cancel.OnHovercolor = System.Drawing.Color.Black
        Me.btn_cancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_cancel.selected = False
        Me.btn_cancel.Size = New System.Drawing.Size(104, 48)
        Me.btn_cancel.TabIndex = 9
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cancel.Textcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_cancel.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txBx_login_pwd
        '
        Me.txBx_login_pwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_login_pwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_login_pwd.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txBx_login_pwd.ForeColor = System.Drawing.Color.White
        Me.txBx_login_pwd.HintForeColor = System.Drawing.Color.White
        Me.txBx_login_pwd.HintText = "Password"
        Me.txBx_login_pwd.isPassword = True
        Me.txBx_login_pwd.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_login_pwd.LineIdleColor = System.Drawing.Color.White
        Me.txBx_login_pwd.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_login_pwd.LineThickness = 3
        Me.txBx_login_pwd.Location = New System.Drawing.Point(8, 195)
        Me.txBx_login_pwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txBx_login_pwd.Name = "txBx_login_pwd"
        Me.txBx_login_pwd.Size = New System.Drawing.Size(254, 33)
        Me.txBx_login_pwd.TabIndex = 1
        Me.txBx_login_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'log_in
        '
        Me.ClientSize = New System.Drawing.Size(290, 436)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "log_in"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pinestone Admin Login"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_exit_loginadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_login.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents txBx_login_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_exit_loginadmin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txBx_login_pwd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_login As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pnl_login As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
