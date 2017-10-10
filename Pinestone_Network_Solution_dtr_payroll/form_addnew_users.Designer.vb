<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_addnew_users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_addnew_users))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn_CancelAddNewUsers = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_addUser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txBx_signup_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txBx_signup_repwd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txBx_signup_username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txBx_signup_pwd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txBxMgc_idUser = New System.Windows.Forms.TextBox()
        Me.lbl_addUser2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_addUser1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_exit_uiadmin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_updateUser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbl_editUser2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_editUser1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btn_exit_uiadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btn_CancelAddNewUsers
        '
        Me.btn_CancelAddNewUsers.Activecolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_CancelAddNewUsers.BackColor = System.Drawing.Color.White
        Me.btn_CancelAddNewUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_CancelAddNewUsers.BorderRadius = 0
        Me.btn_CancelAddNewUsers.ButtonText = "CANCEL"
        Me.btn_CancelAddNewUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_CancelAddNewUsers.DisabledColor = System.Drawing.Color.Gray
        Me.btn_CancelAddNewUsers.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_CancelAddNewUsers.Iconimage = Nothing
        Me.btn_CancelAddNewUsers.Iconimage_right = Nothing
        Me.btn_CancelAddNewUsers.Iconimage_right_Selected = Nothing
        Me.btn_CancelAddNewUsers.Iconimage_Selected = Nothing
        Me.btn_CancelAddNewUsers.IconMarginLeft = 0
        Me.btn_CancelAddNewUsers.IconMarginRight = 0
        Me.btn_CancelAddNewUsers.IconRightVisible = True
        Me.btn_CancelAddNewUsers.IconRightZoom = 0R
        Me.btn_CancelAddNewUsers.IconVisible = True
        Me.btn_CancelAddNewUsers.IconZoom = 90.0R
        Me.btn_CancelAddNewUsers.IsTab = False
        Me.btn_CancelAddNewUsers.Location = New System.Drawing.Point(322, 350)
        Me.btn_CancelAddNewUsers.Name = "btn_CancelAddNewUsers"
        Me.btn_CancelAddNewUsers.Normalcolor = System.Drawing.Color.White
        Me.btn_CancelAddNewUsers.OnHovercolor = System.Drawing.Color.White
        Me.btn_CancelAddNewUsers.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_CancelAddNewUsers.selected = False
        Me.btn_CancelAddNewUsers.Size = New System.Drawing.Size(105, 48)
        Me.btn_CancelAddNewUsers.TabIndex = 18
        Me.btn_CancelAddNewUsers.Text = "CANCEL"
        Me.btn_CancelAddNewUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_CancelAddNewUsers.Textcolor = System.Drawing.Color.Black
        Me.btn_CancelAddNewUsers.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_addUser
        '
        Me.btn_addUser.Activecolor = System.Drawing.Color.White
        Me.btn_addUser.BackColor = System.Drawing.Color.White
        Me.btn_addUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addUser.BorderRadius = 0
        Me.btn_addUser.ButtonText = "SIGNUP"
        Me.btn_addUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addUser.DisabledColor = System.Drawing.Color.Gray
        Me.btn_addUser.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_addUser.Iconimage = Nothing
        Me.btn_addUser.Iconimage_right = Nothing
        Me.btn_addUser.Iconimage_right_Selected = Nothing
        Me.btn_addUser.Iconimage_Selected = Nothing
        Me.btn_addUser.IconMarginLeft = 0
        Me.btn_addUser.IconMarginRight = 0
        Me.btn_addUser.IconRightVisible = True
        Me.btn_addUser.IconRightZoom = 0R
        Me.btn_addUser.IconVisible = True
        Me.btn_addUser.IconZoom = 90.0R
        Me.btn_addUser.IsTab = False
        Me.btn_addUser.Location = New System.Drawing.Point(433, 350)
        Me.btn_addUser.Name = "btn_addUser"
        Me.btn_addUser.Normalcolor = System.Drawing.Color.White
        Me.btn_addUser.OnHovercolor = System.Drawing.Color.White
        Me.btn_addUser.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_addUser.selected = False
        Me.btn_addUser.Size = New System.Drawing.Size(104, 48)
        Me.btn_addUser.TabIndex = 4
        Me.btn_addUser.Text = "SIGNUP"
        Me.btn_addUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_addUser.Textcolor = System.Drawing.Color.Black
        Me.btn_addUser.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addUser.Visible = False
        '
        'txBx_signup_name
        '
        Me.txBx_signup_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_signup_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_signup_name.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_signup_name.ForeColor = System.Drawing.Color.White
        Me.txBx_signup_name.HintForeColor = System.Drawing.Color.WhiteSmoke
        Me.txBx_signup_name.HintText = "Name"
        Me.txBx_signup_name.isPassword = False
        Me.txBx_signup_name.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_signup_name.LineIdleColor = System.Drawing.Color.White
        Me.txBx_signup_name.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_signup_name.LineThickness = 4
        Me.txBx_signup_name.Location = New System.Drawing.Point(5, 20)
        Me.txBx_signup_name.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_signup_name.Name = "txBx_signup_name"
        Me.txBx_signup_name.Size = New System.Drawing.Size(535, 41)
        Me.txBx_signup_name.TabIndex = 0
        Me.txBx_signup_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txBx_signup_repwd
        '
        Me.txBx_signup_repwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_signup_repwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_signup_repwd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_signup_repwd.ForeColor = System.Drawing.Color.White
        Me.txBx_signup_repwd.HintForeColor = System.Drawing.Color.White
        Me.txBx_signup_repwd.HintText = "Confirm Password"
        Me.txBx_signup_repwd.isPassword = False
        Me.txBx_signup_repwd.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_signup_repwd.LineIdleColor = System.Drawing.Color.White
        Me.txBx_signup_repwd.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_signup_repwd.LineThickness = 4
        Me.txBx_signup_repwd.Location = New System.Drawing.Point(5, 178)
        Me.txBx_signup_repwd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_signup_repwd.Name = "txBx_signup_repwd"
        Me.txBx_signup_repwd.Size = New System.Drawing.Size(535, 41)
        Me.txBx_signup_repwd.TabIndex = 3
        Me.txBx_signup_repwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txBx_signup_username
        '
        Me.txBx_signup_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_signup_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_signup_username.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_signup_username.ForeColor = System.Drawing.Color.White
        Me.txBx_signup_username.HintForeColor = System.Drawing.Color.WhiteSmoke
        Me.txBx_signup_username.HintText = "Username"
        Me.txBx_signup_username.isPassword = False
        Me.txBx_signup_username.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_signup_username.LineIdleColor = System.Drawing.Color.White
        Me.txBx_signup_username.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_signup_username.LineThickness = 4
        Me.txBx_signup_username.Location = New System.Drawing.Point(5, 76)
        Me.txBx_signup_username.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_signup_username.Name = "txBx_signup_username"
        Me.txBx_signup_username.Size = New System.Drawing.Size(535, 41)
        Me.txBx_signup_username.TabIndex = 1
        Me.txBx_signup_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txBx_signup_pwd
        '
        Me.txBx_signup_pwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_signup_pwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_signup_pwd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_signup_pwd.ForeColor = System.Drawing.Color.White
        Me.txBx_signup_pwd.HintForeColor = System.Drawing.Color.White
        Me.txBx_signup_pwd.HintText = "Password"
        Me.txBx_signup_pwd.isPassword = False
        Me.txBx_signup_pwd.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_signup_pwd.LineIdleColor = System.Drawing.Color.White
        Me.txBx_signup_pwd.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_signup_pwd.LineThickness = 4
        Me.txBx_signup_pwd.Location = New System.Drawing.Point(5, 127)
        Me.txBx_signup_pwd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_signup_pwd.Name = "txBx_signup_pwd"
        Me.txBx_signup_pwd.Size = New System.Drawing.Size(535, 41)
        Me.txBx_signup_pwd.TabIndex = 2
        Me.txBx_signup_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.txBxMgc_idUser)
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_signup_name)
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_signup_pwd)
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_signup_repwd)
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_signup_username)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-1, 94)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(545, 237)
        Me.BunifuGradientPanel1.TabIndex = 37
        '
        'txBxMgc_idUser
        '
        Me.txBxMgc_idUser.Location = New System.Drawing.Point(5, 0)
        Me.txBxMgc_idUser.Name = "txBxMgc_idUser"
        Me.txBxMgc_idUser.Size = New System.Drawing.Size(35, 20)
        Me.txBxMgc_idUser.TabIndex = 42
        Me.txBxMgc_idUser.TabStop = False
        '
        'lbl_addUser2
        '
        Me.lbl_addUser2.AutoSize = True
        Me.lbl_addUser2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_addUser2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addUser2.ForeColor = System.Drawing.Color.White
        Me.lbl_addUser2.Location = New System.Drawing.Point(49, 42)
        Me.lbl_addUser2.Name = "lbl_addUser2"
        Me.lbl_addUser2.Size = New System.Drawing.Size(57, 23)
        Me.lbl_addUser2.TabIndex = 39
        Me.lbl_addUser2.Text = "Users"
        '
        'lbl_addUser1
        '
        Me.lbl_addUser1.AutoSize = True
        Me.lbl_addUser1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_addUser1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addUser1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_addUser1.Location = New System.Drawing.Point(5, 42)
        Me.lbl_addUser1.Name = "lbl_addUser1"
        Me.lbl_addUser1.Size = New System.Drawing.Size(50, 23)
        Me.lbl_addUser1.TabIndex = 38
        Me.lbl_addUser1.Text = "Add"
        '
        'btn_exit_uiadmin
        '
        Me.btn_exit_uiadmin.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit_uiadmin.Image = CType(resources.GetObject("btn_exit_uiadmin.Image"), System.Drawing.Image)
        Me.btn_exit_uiadmin.ImageActive = Nothing
        Me.btn_exit_uiadmin.Location = New System.Drawing.Point(514, 12)
        Me.btn_exit_uiadmin.Name = "btn_exit_uiadmin"
        Me.btn_exit_uiadmin.Size = New System.Drawing.Size(25, 25)
        Me.btn_exit_uiadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_exit_uiadmin.TabIndex = 40
        Me.btn_exit_uiadmin.TabStop = False
        Me.btn_exit_uiadmin.Zoom = 10
        '
        'btn_updateUser
        '
        Me.btn_updateUser.Activecolor = System.Drawing.Color.White
        Me.btn_updateUser.BackColor = System.Drawing.Color.White
        Me.btn_updateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_updateUser.BorderRadius = 0
        Me.btn_updateUser.ButtonText = "UPDATE"
        Me.btn_updateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_updateUser.DisabledColor = System.Drawing.Color.Gray
        Me.btn_updateUser.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_updateUser.Iconimage = Nothing
        Me.btn_updateUser.Iconimage_right = Nothing
        Me.btn_updateUser.Iconimage_right_Selected = Nothing
        Me.btn_updateUser.Iconimage_Selected = Nothing
        Me.btn_updateUser.IconMarginLeft = 0
        Me.btn_updateUser.IconMarginRight = 0
        Me.btn_updateUser.IconRightVisible = True
        Me.btn_updateUser.IconRightZoom = 0R
        Me.btn_updateUser.IconVisible = True
        Me.btn_updateUser.IconZoom = 90.0R
        Me.btn_updateUser.IsTab = False
        Me.btn_updateUser.Location = New System.Drawing.Point(435, 350)
        Me.btn_updateUser.Name = "btn_updateUser"
        Me.btn_updateUser.Normalcolor = System.Drawing.Color.White
        Me.btn_updateUser.OnHovercolor = System.Drawing.Color.White
        Me.btn_updateUser.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_updateUser.selected = False
        Me.btn_updateUser.Size = New System.Drawing.Size(104, 48)
        Me.btn_updateUser.TabIndex = 41
        Me.btn_updateUser.Text = "UPDATE"
        Me.btn_updateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_updateUser.Textcolor = System.Drawing.Color.Black
        Me.btn_updateUser.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lbl_editUser2
        '
        Me.lbl_editUser2.AutoSize = True
        Me.lbl_editUser2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_editUser2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editUser2.ForeColor = System.Drawing.Color.White
        Me.lbl_editUser2.Location = New System.Drawing.Point(49, 42)
        Me.lbl_editUser2.Name = "lbl_editUser2"
        Me.lbl_editUser2.Size = New System.Drawing.Size(57, 23)
        Me.lbl_editUser2.TabIndex = 43
        Me.lbl_editUser2.Text = "Users"
        Me.lbl_editUser2.Visible = False
        '
        'lbl_editUser1
        '
        Me.lbl_editUser1.AutoSize = True
        Me.lbl_editUser1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_editUser1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editUser1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_editUser1.Location = New System.Drawing.Point(5, 42)
        Me.lbl_editUser1.Name = "lbl_editUser1"
        Me.lbl_editUser1.Size = New System.Drawing.Size(44, 23)
        Me.lbl_editUser1.TabIndex = 42
        Me.lbl_editUser1.Text = "Edit"
        Me.lbl_editUser1.Visible = False
        '
        'form_addnew_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(545, 409)
        Me.Controls.Add(Me.lbl_editUser2)
        Me.Controls.Add(Me.lbl_editUser1)
        Me.Controls.Add(Me.btn_exit_uiadmin)
        Me.Controls.Add(Me.lbl_addUser2)
        Me.Controls.Add(Me.lbl_addUser1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.btn_CancelAddNewUsers)
        Me.Controls.Add(Me.btn_updateUser)
        Me.Controls.Add(Me.btn_addUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(750, 250)
        Me.Name = "form_addnew_users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Edit User"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.btn_exit_uiadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btn_CancelAddNewUsers As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_addUser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txBx_signup_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txBx_signup_repwd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txBx_signup_pwd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txBx_signup_username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_addUser2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_addUser1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_exit_uiadmin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txBxMgc_idUser As TextBox
    Friend WithEvents btn_updateUser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lbl_editUser2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_editUser1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
