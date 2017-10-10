<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_addnew_department
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_addnew_department))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btn_adddept_cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_adddept_addnew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txBx_add_Depname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ToolTip_txBx_dept = New System.Windows.Forms.ToolTip(Me.components)
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_exit_uiadmin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.btn_exit_uiadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btn_adddept_cancel
        '
        Me.btn_adddept_cancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_adddept_cancel.BackColor = System.Drawing.Color.White
        Me.btn_adddept_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_adddept_cancel.BorderRadius = 0
        Me.btn_adddept_cancel.ButtonText = "CANCEL"
        Me.btn_adddept_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_adddept_cancel.DisabledColor = System.Drawing.Color.Gray
        Me.btn_adddept_cancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_adddept_cancel.Iconimage = Nothing
        Me.btn_adddept_cancel.Iconimage_right = Nothing
        Me.btn_adddept_cancel.Iconimage_right_Selected = Nothing
        Me.btn_adddept_cancel.Iconimage_Selected = Nothing
        Me.btn_adddept_cancel.IconMarginLeft = 0
        Me.btn_adddept_cancel.IconMarginRight = 0
        Me.btn_adddept_cancel.IconRightVisible = True
        Me.btn_adddept_cancel.IconRightZoom = 0R
        Me.btn_adddept_cancel.IconVisible = True
        Me.btn_adddept_cancel.IconZoom = 90.0R
        Me.btn_adddept_cancel.IsTab = False
        Me.btn_adddept_cancel.Location = New System.Drawing.Point(223, 159)
        Me.btn_adddept_cancel.Name = "btn_adddept_cancel"
        Me.btn_adddept_cancel.Normalcolor = System.Drawing.Color.White
        Me.btn_adddept_cancel.OnHovercolor = System.Drawing.Color.White
        Me.btn_adddept_cancel.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_adddept_cancel.selected = False
        Me.btn_adddept_cancel.Size = New System.Drawing.Size(105, 48)
        Me.btn_adddept_cancel.TabIndex = 43
        Me.btn_adddept_cancel.Text = "CANCEL"
        Me.btn_adddept_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_adddept_cancel.Textcolor = System.Drawing.Color.Black
        Me.btn_adddept_cancel.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_adddept_addnew
        '
        Me.btn_adddept_addnew.Activecolor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btn_adddept_addnew.BackColor = System.Drawing.Color.White
        Me.btn_adddept_addnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_adddept_addnew.BorderRadius = 0
        Me.btn_adddept_addnew.ButtonText = "ADD NEW"
        Me.btn_adddept_addnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_adddept_addnew.DisabledColor = System.Drawing.Color.Gray
        Me.btn_adddept_addnew.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_adddept_addnew.Iconimage = Nothing
        Me.btn_adddept_addnew.Iconimage_right = Nothing
        Me.btn_adddept_addnew.Iconimage_right_Selected = Nothing
        Me.btn_adddept_addnew.Iconimage_Selected = Nothing
        Me.btn_adddept_addnew.IconMarginLeft = 0
        Me.btn_adddept_addnew.IconMarginRight = 0
        Me.btn_adddept_addnew.IconRightVisible = True
        Me.btn_adddept_addnew.IconRightZoom = 0R
        Me.btn_adddept_addnew.IconVisible = True
        Me.btn_adddept_addnew.IconZoom = 90.0R
        Me.btn_adddept_addnew.IsTab = False
        Me.btn_adddept_addnew.Location = New System.Drawing.Point(334, 159)
        Me.btn_adddept_addnew.Name = "btn_adddept_addnew"
        Me.btn_adddept_addnew.Normalcolor = System.Drawing.Color.White
        Me.btn_adddept_addnew.OnHovercolor = System.Drawing.Color.White
        Me.btn_adddept_addnew.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_adddept_addnew.selected = False
        Me.btn_adddept_addnew.Size = New System.Drawing.Size(104, 48)
        Me.btn_adddept_addnew.TabIndex = 1
        Me.btn_adddept_addnew.Text = "ADD NEW"
        Me.btn_adddept_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_adddept_addnew.Textcolor = System.Drawing.Color.Black
        Me.btn_adddept_addnew.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_add_Depname)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-3, 64)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(449, 89)
        Me.BunifuGradientPanel1.TabIndex = 41
        '
        'txBx_add_Depname
        '
        Me.txBx_add_Depname.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_add_Depname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_add_Depname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_add_Depname.ForeColor = System.Drawing.Color.White
        Me.txBx_add_Depname.HintForeColor = System.Drawing.Color.Silver
        Me.txBx_add_Depname.HintText = "Department"
        Me.txBx_add_Depname.isPassword = False
        Me.txBx_add_Depname.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_add_Depname.LineIdleColor = System.Drawing.Color.White
        Me.txBx_add_Depname.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_add_Depname.LineThickness = 4
        Me.txBx_add_Depname.Location = New System.Drawing.Point(14, 24)
        Me.txBx_add_Depname.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_add_Depname.Name = "txBx_add_Depname"
        Me.txBx_add_Depname.Size = New System.Drawing.Size(407, 41)
        Me.txBx_add_Depname.TabIndex = 0
        Me.txBx_add_Depname.TabStop = False
        Me.txBx_add_Depname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ToolTip_txBx_dept.SetToolTip(Me.txBx_add_Depname, "Required Field...")
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'ToolTip_txBx_dept
        '
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(53, 33)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(120, 23)
        Me.BunifuCustomLabel7.TabIndex = 47
        Me.BunifuCustomLabel7.Text = "Department"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(9, 33)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(50, 23)
        Me.BunifuCustomLabel1.TabIndex = 46
        Me.BunifuCustomLabel1.Text = "Add"
        '
        'btn_exit_uiadmin
        '
        Me.btn_exit_uiadmin.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit_uiadmin.Image = CType(resources.GetObject("btn_exit_uiadmin.Image"), System.Drawing.Image)
        Me.btn_exit_uiadmin.ImageActive = Nothing
        Me.btn_exit_uiadmin.Location = New System.Drawing.Point(413, 4)
        Me.btn_exit_uiadmin.Name = "btn_exit_uiadmin"
        Me.btn_exit_uiadmin.Size = New System.Drawing.Size(25, 25)
        Me.btn_exit_uiadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_exit_uiadmin.TabIndex = 48
        Me.btn_exit_uiadmin.TabStop = False
        Me.btn_exit_uiadmin.Zoom = 10
        '
        'form_addnew_department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 212)
        Me.Controls.Add(Me.btn_exit_uiadmin)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btn_adddept_cancel)
        Me.Controls.Add(Me.btn_adddept_addnew)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_addnew_department"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_addnew_department"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.btn_exit_uiadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btn_adddept_cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_adddept_addnew As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents txBx_add_Depname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents ToolTip_txBx_dept As ToolTip
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_exit_uiadmin As Bunifu.Framework.UI.BunifuImageButton
End Class
