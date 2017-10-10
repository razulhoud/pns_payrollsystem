<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_addRemarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_addRemarks))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.mini_panel_remarks = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_cuts_cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_enter_remarks = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbl_transform2_emp = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_transform1_emp = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.rchTxBx_remarks = New System.Windows.Forms.RichTextBox()
        Me.lbl_passID_employee_remarks = New System.Windows.Forms.Label()
        Me.txBx_EmpNum_remarks = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.mini_panel_remarks.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'mini_panel_remarks
        '
        Me.mini_panel_remarks.BackgroundImage = CType(resources.GetObject("mini_panel_remarks.BackgroundImage"), System.Drawing.Image)
        Me.mini_panel_remarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mini_panel_remarks.Controls.Add(Me.btn_cuts_cancel)
        Me.mini_panel_remarks.Controls.Add(Me.btn_enter_remarks)
        Me.mini_panel_remarks.Controls.Add(Me.BunifuImageButton1)
        Me.mini_panel_remarks.Controls.Add(Me.lbl_transform2_emp)
        Me.mini_panel_remarks.Controls.Add(Me.lbl_transform1_emp)
        Me.mini_panel_remarks.Controls.Add(Me.BunifuGradientPanel2)
        Me.mini_panel_remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mini_panel_remarks.GradientBottomLeft = System.Drawing.Color.Black
        Me.mini_panel_remarks.GradientBottomRight = System.Drawing.Color.Black
        Me.mini_panel_remarks.GradientTopLeft = System.Drawing.Color.Black
        Me.mini_panel_remarks.GradientTopRight = System.Drawing.Color.Black
        Me.mini_panel_remarks.Location = New System.Drawing.Point(0, 0)
        Me.mini_panel_remarks.Name = "mini_panel_remarks"
        Me.mini_panel_remarks.Quality = 10
        Me.mini_panel_remarks.Size = New System.Drawing.Size(317, 409)
        Me.mini_panel_remarks.TabIndex = 40
        '
        'btn_cuts_cancel
        '
        Me.btn_cuts_cancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btn_cuts_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_cuts_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cuts_cancel.BorderRadius = 0
        Me.btn_cuts_cancel.ButtonText = "CANCEL"
        Me.btn_cuts_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cuts_cancel.DisabledColor = System.Drawing.Color.Gray
        Me.btn_cuts_cancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cuts_cancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_cuts_cancel.Iconimage = Nothing
        Me.btn_cuts_cancel.Iconimage_right = Nothing
        Me.btn_cuts_cancel.Iconimage_right_Selected = Nothing
        Me.btn_cuts_cancel.Iconimage_Selected = Nothing
        Me.btn_cuts_cancel.IconMarginLeft = 0
        Me.btn_cuts_cancel.IconMarginRight = 0
        Me.btn_cuts_cancel.IconRightVisible = True
        Me.btn_cuts_cancel.IconRightZoom = 0R
        Me.btn_cuts_cancel.IconVisible = True
        Me.btn_cuts_cancel.IconZoom = 90.0R
        Me.btn_cuts_cancel.IsTab = False
        Me.btn_cuts_cancel.Location = New System.Drawing.Point(64, 357)
        Me.btn_cuts_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_cuts_cancel.Name = "btn_cuts_cancel"
        Me.btn_cuts_cancel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_cuts_cancel.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btn_cuts_cancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_cuts_cancel.selected = False
        Me.btn_cuts_cancel.Size = New System.Drawing.Size(104, 48)
        Me.btn_cuts_cancel.TabIndex = 67
        Me.btn_cuts_cancel.Text = "CANCEL"
        Me.btn_cuts_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cuts_cancel.Textcolor = System.Drawing.Color.White
        Me.btn_cuts_cancel.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_enter_remarks
        '
        Me.btn_enter_remarks.Activecolor = System.Drawing.Color.White
        Me.btn_enter_remarks.BackColor = System.Drawing.Color.White
        Me.btn_enter_remarks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_enter_remarks.BorderRadius = 0
        Me.btn_enter_remarks.ButtonText = "ENTER"
        Me.btn_enter_remarks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enter_remarks.DisabledColor = System.Drawing.Color.Gray
        Me.btn_enter_remarks.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enter_remarks.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_enter_remarks.Iconimage = Nothing
        Me.btn_enter_remarks.Iconimage_right = Nothing
        Me.btn_enter_remarks.Iconimage_right_Selected = Nothing
        Me.btn_enter_remarks.Iconimage_Selected = Nothing
        Me.btn_enter_remarks.IconMarginLeft = 0
        Me.btn_enter_remarks.IconMarginRight = 0
        Me.btn_enter_remarks.IconRightVisible = True
        Me.btn_enter_remarks.IconRightZoom = 0R
        Me.btn_enter_remarks.IconVisible = True
        Me.btn_enter_remarks.IconZoom = 90.0R
        Me.btn_enter_remarks.IsTab = False
        Me.btn_enter_remarks.Location = New System.Drawing.Point(174, 357)
        Me.btn_enter_remarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_enter_remarks.Name = "btn_enter_remarks"
        Me.btn_enter_remarks.Normalcolor = System.Drawing.Color.White
        Me.btn_enter_remarks.OnHovercolor = System.Drawing.Color.White
        Me.btn_enter_remarks.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_enter_remarks.selected = False
        Me.btn_enter_remarks.Size = New System.Drawing.Size(104, 48)
        Me.btn_enter_remarks.TabIndex = 66
        Me.btn_enter_remarks.Text = "ENTER"
        Me.btn_enter_remarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_enter_remarks.Textcolor = System.Drawing.Color.Black
        Me.btn_enter_remarks.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(289, 3)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(25, 25)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BunifuImageButton1.TabIndex = 39
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'lbl_transform2_emp
        '
        Me.lbl_transform2_emp.AutoSize = True
        Me.lbl_transform2_emp.BackColor = System.Drawing.Color.Transparent
        Me.lbl_transform2_emp.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transform2_emp.ForeColor = System.Drawing.Color.White
        Me.lbl_transform2_emp.Location = New System.Drawing.Point(80, 38)
        Me.lbl_transform2_emp.Name = "lbl_transform2_emp"
        Me.lbl_transform2_emp.Size = New System.Drawing.Size(146, 18)
        Me.lbl_transform2_emp.TabIndex = 38
        Me.lbl_transform2_emp.Text = "Web Development"
        '
        'lbl_transform1_emp
        '
        Me.lbl_transform1_emp.AutoSize = True
        Me.lbl_transform1_emp.BackColor = System.Drawing.Color.Transparent
        Me.lbl_transform1_emp.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transform1_emp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_transform1_emp.Location = New System.Drawing.Point(12, 38)
        Me.lbl_transform1_emp.Name = "lbl_transform1_emp"
        Me.lbl_transform1_emp.Size = New System.Drawing.Size(71, 18)
        Me.lbl_transform1_emp.TabIndex = 37
        Me.lbl_transform1_emp.Text = "Remarks"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.rchTxBx_remarks)
        Me.BunifuGradientPanel2.Controls.Add(Me.lbl_passID_employee_remarks)
        Me.BunifuGradientPanel2.Controls.Add(Me.txBx_EmpNum_remarks)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 91)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(317, 259)
        Me.BunifuGradientPanel2.TabIndex = 0
        '
        'rchTxBx_remarks
        '
        Me.rchTxBx_remarks.Location = New System.Drawing.Point(3, 55)
        Me.rchTxBx_remarks.Name = "rchTxBx_remarks"
        Me.rchTxBx_remarks.Size = New System.Drawing.Size(311, 201)
        Me.rchTxBx_remarks.TabIndex = 63
        Me.rchTxBx_remarks.Text = ""
        '
        'lbl_passID_employee_remarks
        '
        Me.lbl_passID_employee_remarks.AutoSize = True
        Me.lbl_passID_employee_remarks.Location = New System.Drawing.Point(142, 0)
        Me.lbl_passID_employee_remarks.Name = "lbl_passID_employee_remarks"
        Me.lbl_passID_employee_remarks.Size = New System.Drawing.Size(39, 13)
        Me.lbl_passID_employee_remarks.TabIndex = 62
        Me.lbl_passID_employee_remarks.Text = "Label3"
        Me.lbl_passID_employee_remarks.Visible = False
        '
        'txBx_EmpNum_remarks
        '
        Me.txBx_EmpNum_remarks.BackColor = System.Drawing.Color.White
        Me.txBx_EmpNum_remarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_EmpNum_remarks.Enabled = False
        Me.txBx_EmpNum_remarks.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_EmpNum_remarks.ForeColor = System.Drawing.Color.Black
        Me.txBx_EmpNum_remarks.HintForeColor = System.Drawing.Color.Black
        Me.txBx_EmpNum_remarks.HintText = "ID Employee"
        Me.txBx_EmpNum_remarks.isPassword = False
        Me.txBx_EmpNum_remarks.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_EmpNum_remarks.LineIdleColor = System.Drawing.Color.Black
        Me.txBx_EmpNum_remarks.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_EmpNum_remarks.LineThickness = 4
        Me.txBx_EmpNum_remarks.Location = New System.Drawing.Point(71, 12)
        Me.txBx_EmpNum_remarks.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txBx_EmpNum_remarks.Name = "txBx_EmpNum_remarks"
        Me.txBx_EmpNum_remarks.Size = New System.Drawing.Size(176, 35)
        Me.txBx_EmpNum_remarks.TabIndex = 60
        Me.txBx_EmpNum_remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.mini_panel_remarks
        Me.BunifuDragControl1.Vertical = True
        '
        'form_addRemarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.mini_panel_remarks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_addRemarks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remarks"
        Me.mini_panel_remarks.ResumeLayout(False)
        Me.mini_panel_remarks.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents mini_panel_remarks As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_cuts_cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_enter_remarks As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbl_transform2_emp As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_transform1_emp As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents rchTxBx_remarks As RichTextBox
    Friend WithEvents lbl_passID_employee_remarks As Label
    Friend WithEvents txBx_EmpNum_remarks As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
