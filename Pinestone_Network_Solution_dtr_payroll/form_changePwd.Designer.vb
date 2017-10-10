<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_changePwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_changePwd))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lbl_editUser2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_editUser1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txBx_currentPwd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txBx_newPwd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txBx_reNewPwd = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_exit_uiadmin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btn_accptNewPwd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_cancelNewPwd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btn_exit_uiadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'lbl_editUser2
        '
        Me.lbl_editUser2.AutoSize = True
        Me.lbl_editUser2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_editUser2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editUser2.ForeColor = System.Drawing.Color.White
        Me.lbl_editUser2.Location = New System.Drawing.Point(91, 60)
        Me.lbl_editUser2.Name = "lbl_editUser2"
        Me.lbl_editUser2.Size = New System.Drawing.Size(96, 23)
        Me.lbl_editUser2.TabIndex = 46
        Me.lbl_editUser2.Text = "Password"
        '
        'lbl_editUser1
        '
        Me.lbl_editUser1.AutoSize = True
        Me.lbl_editUser1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_editUser1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editUser1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_editUser1.Location = New System.Drawing.Point(12, 60)
        Me.lbl_editUser1.Name = "lbl_editUser1"
        Me.lbl_editUser1.Size = New System.Drawing.Size(85, 23)
        Me.lbl_editUser1.TabIndex = 45
        Me.lbl_editUser1.Text = "Change"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_currentPwd)
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_newPwd)
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_reNewPwd)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(1, 104)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(509, 219)
        Me.BunifuGradientPanel1.TabIndex = 44
        '
        'txBx_currentPwd
        '
        Me.txBx_currentPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_currentPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_currentPwd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_currentPwd.ForeColor = System.Drawing.Color.White
        Me.txBx_currentPwd.HintForeColor = System.Drawing.Color.White
        Me.txBx_currentPwd.HintText = "Current Password"
        Me.txBx_currentPwd.isPassword = False
        Me.txBx_currentPwd.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_currentPwd.LineIdleColor = System.Drawing.Color.White
        Me.txBx_currentPwd.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_currentPwd.LineThickness = 4
        Me.txBx_currentPwd.Location = New System.Drawing.Point(5, 26)
        Me.txBx_currentPwd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_currentPwd.Name = "txBx_currentPwd"
        Me.txBx_currentPwd.Size = New System.Drawing.Size(488, 41)
        Me.txBx_currentPwd.TabIndex = 43
        Me.txBx_currentPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTip1.SetToolTip(Me.txBx_currentPwd, "Required Field")
        '
        'txBx_newPwd
        '
        Me.txBx_newPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_newPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_newPwd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_newPwd.ForeColor = System.Drawing.Color.White
        Me.txBx_newPwd.HintForeColor = System.Drawing.Color.White
        Me.txBx_newPwd.HintText = "New Password"
        Me.txBx_newPwd.isPassword = False
        Me.txBx_newPwd.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_newPwd.LineIdleColor = System.Drawing.Color.White
        Me.txBx_newPwd.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_newPwd.LineThickness = 4
        Me.txBx_newPwd.Location = New System.Drawing.Point(5, 87)
        Me.txBx_newPwd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_newPwd.Name = "txBx_newPwd"
        Me.txBx_newPwd.Size = New System.Drawing.Size(488, 41)
        Me.txBx_newPwd.TabIndex = 2
        Me.txBx_newPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txBx_reNewPwd
        '
        Me.txBx_reNewPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_reNewPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_reNewPwd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_reNewPwd.ForeColor = System.Drawing.Color.White
        Me.txBx_reNewPwd.HintForeColor = System.Drawing.Color.White
        Me.txBx_reNewPwd.HintText = "Confirm Password"
        Me.txBx_reNewPwd.isPassword = False
        Me.txBx_reNewPwd.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_reNewPwd.LineIdleColor = System.Drawing.Color.White
        Me.txBx_reNewPwd.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_reNewPwd.LineThickness = 4
        Me.txBx_reNewPwd.Location = New System.Drawing.Point(5, 147)
        Me.txBx_reNewPwd.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_reNewPwd.Name = "txBx_reNewPwd"
        Me.txBx_reNewPwd.Size = New System.Drawing.Size(488, 41)
        Me.txBx_reNewPwd.TabIndex = 3
        Me.txBx_reNewPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_exit_uiadmin
        '
        Me.btn_exit_uiadmin.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit_uiadmin.Image = CType(resources.GetObject("btn_exit_uiadmin.Image"), System.Drawing.Image)
        Me.btn_exit_uiadmin.ImageActive = Nothing
        Me.btn_exit_uiadmin.Location = New System.Drawing.Point(473, 12)
        Me.btn_exit_uiadmin.Name = "btn_exit_uiadmin"
        Me.btn_exit_uiadmin.Size = New System.Drawing.Size(25, 25)
        Me.btn_exit_uiadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_exit_uiadmin.TabIndex = 47
        Me.btn_exit_uiadmin.TabStop = False
        Me.btn_exit_uiadmin.Zoom = 10
        '
        'btn_accptNewPwd
        '
        Me.btn_accptNewPwd.Activecolor = System.Drawing.Color.White
        Me.btn_accptNewPwd.BackColor = System.Drawing.Color.White
        Me.btn_accptNewPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_accptNewPwd.BorderRadius = 0
        Me.btn_accptNewPwd.ButtonText = "ACCEPT"
        Me.btn_accptNewPwd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_accptNewPwd.DisabledColor = System.Drawing.Color.Gray
        Me.btn_accptNewPwd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_accptNewPwd.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_accptNewPwd.Iconimage = Nothing
        Me.btn_accptNewPwd.Iconimage_right = Nothing
        Me.btn_accptNewPwd.Iconimage_right_Selected = Nothing
        Me.btn_accptNewPwd.Iconimage_Selected = Nothing
        Me.btn_accptNewPwd.IconMarginLeft = 0
        Me.btn_accptNewPwd.IconMarginRight = 0
        Me.btn_accptNewPwd.IconRightVisible = True
        Me.btn_accptNewPwd.IconRightZoom = 0R
        Me.btn_accptNewPwd.IconVisible = True
        Me.btn_accptNewPwd.IconZoom = 90.0R
        Me.btn_accptNewPwd.IsTab = False
        Me.btn_accptNewPwd.Location = New System.Drawing.Point(390, 338)
        Me.btn_accptNewPwd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_accptNewPwd.Name = "btn_accptNewPwd"
        Me.btn_accptNewPwd.Normalcolor = System.Drawing.Color.White
        Me.btn_accptNewPwd.OnHovercolor = System.Drawing.Color.White
        Me.btn_accptNewPwd.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_accptNewPwd.selected = False
        Me.btn_accptNewPwd.Size = New System.Drawing.Size(104, 48)
        Me.btn_accptNewPwd.TabIndex = 49
        Me.btn_accptNewPwd.Text = "ACCEPT"
        Me.btn_accptNewPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_accptNewPwd.Textcolor = System.Drawing.Color.Black
        Me.btn_accptNewPwd.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_cancelNewPwd
        '
        Me.btn_cancelNewPwd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_cancelNewPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_cancelNewPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancelNewPwd.BorderRadius = 0
        Me.btn_cancelNewPwd.ButtonText = "CANCEL"
        Me.btn_cancelNewPwd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelNewPwd.DisabledColor = System.Drawing.Color.Gray
        Me.btn_cancelNewPwd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelNewPwd.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_cancelNewPwd.Iconimage = Nothing
        Me.btn_cancelNewPwd.Iconimage_right = Nothing
        Me.btn_cancelNewPwd.Iconimage_right_Selected = Nothing
        Me.btn_cancelNewPwd.Iconimage_Selected = Nothing
        Me.btn_cancelNewPwd.IconMarginLeft = 0
        Me.btn_cancelNewPwd.IconMarginRight = 0
        Me.btn_cancelNewPwd.IconRightVisible = True
        Me.btn_cancelNewPwd.IconRightZoom = 0R
        Me.btn_cancelNewPwd.IconVisible = True
        Me.btn_cancelNewPwd.IconZoom = 90.0R
        Me.btn_cancelNewPwd.IsTab = False
        Me.btn_cancelNewPwd.Location = New System.Drawing.Point(280, 338)
        Me.btn_cancelNewPwd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cancelNewPwd.Name = "btn_cancelNewPwd"
        Me.btn_cancelNewPwd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_cancelNewPwd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_cancelNewPwd.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_cancelNewPwd.selected = False
        Me.btn_cancelNewPwd.Size = New System.Drawing.Size(104, 48)
        Me.btn_cancelNewPwd.TabIndex = 48
        Me.btn_cancelNewPwd.Text = "CANCEL"
        Me.btn_cancelNewPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cancelNewPwd.Textcolor = System.Drawing.Color.Black
        Me.btn_cancelNewPwd.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ToolTip1
        '
        '
        'form_changePwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(510, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_accptNewPwd)
        Me.Controls.Add(Me.btn_cancelNewPwd)
        Me.Controls.Add(Me.btn_exit_uiadmin)
        Me.Controls.Add(Me.lbl_editUser2)
        Me.Controls.Add(Me.lbl_editUser1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_changePwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.btn_exit_uiadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbl_editUser2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_editUser1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents txBx_newPwd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txBx_reNewPwd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_exit_uiadmin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txBx_currentPwd As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_accptNewPwd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_cancelNewPwd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ToolTip1 As ToolTip
End Class
