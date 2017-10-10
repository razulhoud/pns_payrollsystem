<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_addCUTS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_addCUTS))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.mini_panel_cuts = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btn_cuts_cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_enter_cuts = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lbl_transform2_emp = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_transform1_emp = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lbl_passDate_cuts = New System.Windows.Forms.Label()
        Me.lbl_passID_cuts = New System.Windows.Forms.Label()
        Me.txBx_numOfCuts = New Bunifu.Framework.UI.BunifuTextbox()
        Me.txBx_EmpNum_cuts = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dtp_passDate_Cuts = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.mini_panel_cuts.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'mini_panel_cuts
        '
        Me.mini_panel_cuts.BackgroundImage = CType(resources.GetObject("mini_panel_cuts.BackgroundImage"), System.Drawing.Image)
        Me.mini_panel_cuts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mini_panel_cuts.Controls.Add(Me.btn_cuts_cancel)
        Me.mini_panel_cuts.Controls.Add(Me.btn_enter_cuts)
        Me.mini_panel_cuts.Controls.Add(Me.BunifuImageButton1)
        Me.mini_panel_cuts.Controls.Add(Me.lbl_transform2_emp)
        Me.mini_panel_cuts.Controls.Add(Me.lbl_transform1_emp)
        Me.mini_panel_cuts.Controls.Add(Me.BunifuGradientPanel2)
        Me.mini_panel_cuts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mini_panel_cuts.GradientBottomLeft = System.Drawing.Color.Black
        Me.mini_panel_cuts.GradientBottomRight = System.Drawing.Color.Black
        Me.mini_panel_cuts.GradientTopLeft = System.Drawing.Color.Black
        Me.mini_panel_cuts.GradientTopRight = System.Drawing.Color.Black
        Me.mini_panel_cuts.Location = New System.Drawing.Point(0, 0)
        Me.mini_panel_cuts.Name = "mini_panel_cuts"
        Me.mini_panel_cuts.Quality = 10
        Me.mini_panel_cuts.Size = New System.Drawing.Size(317, 286)
        Me.mini_panel_cuts.TabIndex = 39
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
        Me.btn_cuts_cancel.Location = New System.Drawing.Point(51, 228)
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
        'btn_enter_cuts
        '
        Me.btn_enter_cuts.Activecolor = System.Drawing.Color.White
        Me.btn_enter_cuts.BackColor = System.Drawing.Color.White
        Me.btn_enter_cuts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_enter_cuts.BorderRadius = 0
        Me.btn_enter_cuts.ButtonText = "ENTER"
        Me.btn_enter_cuts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enter_cuts.DisabledColor = System.Drawing.Color.Gray
        Me.btn_enter_cuts.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enter_cuts.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_enter_cuts.Iconimage = Nothing
        Me.btn_enter_cuts.Iconimage_right = Nothing
        Me.btn_enter_cuts.Iconimage_right_Selected = Nothing
        Me.btn_enter_cuts.Iconimage_Selected = Nothing
        Me.btn_enter_cuts.IconMarginLeft = 0
        Me.btn_enter_cuts.IconMarginRight = 0
        Me.btn_enter_cuts.IconRightVisible = True
        Me.btn_enter_cuts.IconRightZoom = 0R
        Me.btn_enter_cuts.IconVisible = True
        Me.btn_enter_cuts.IconZoom = 90.0R
        Me.btn_enter_cuts.IsTab = False
        Me.btn_enter_cuts.Location = New System.Drawing.Point(161, 228)
        Me.btn_enter_cuts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_enter_cuts.Name = "btn_enter_cuts"
        Me.btn_enter_cuts.Normalcolor = System.Drawing.Color.White
        Me.btn_enter_cuts.OnHovercolor = System.Drawing.Color.White
        Me.btn_enter_cuts.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_enter_cuts.selected = False
        Me.btn_enter_cuts.Size = New System.Drawing.Size(104, 48)
        Me.btn_enter_cuts.TabIndex = 66
        Me.btn_enter_cuts.Text = "ENTER"
        Me.btn_enter_cuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_enter_cuts.Textcolor = System.Drawing.Color.Black
        Me.btn_enter_cuts.TextFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lbl_transform2_emp.Location = New System.Drawing.Point(48, 38)
        Me.lbl_transform2_emp.Name = "lbl_transform2_emp"
        Me.lbl_transform2_emp.Size = New System.Drawing.Size(120, 18)
        Me.lbl_transform2_emp.TabIndex = 38
        Me.lbl_transform2_emp.Text = "Voice Account"
        '
        'lbl_transform1_emp
        '
        Me.lbl_transform1_emp.AutoSize = True
        Me.lbl_transform1_emp.BackColor = System.Drawing.Color.Transparent
        Me.lbl_transform1_emp.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transform1_emp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_transform1_emp.Location = New System.Drawing.Point(12, 38)
        Me.lbl_transform1_emp.Name = "lbl_transform1_emp"
        Me.lbl_transform1_emp.Size = New System.Drawing.Size(39, 18)
        Me.lbl_transform1_emp.TabIndex = 37
        Me.lbl_transform1_emp.Text = "Cuts"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.lbl_passDate_cuts)
        Me.BunifuGradientPanel2.Controls.Add(Me.lbl_passID_cuts)
        Me.BunifuGradientPanel2.Controls.Add(Me.txBx_numOfCuts)
        Me.BunifuGradientPanel2.Controls.Add(Me.txBx_EmpNum_cuts)
        Me.BunifuGradientPanel2.Controls.Add(Me.dtp_passDate_Cuts)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 91)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(317, 130)
        Me.BunifuGradientPanel2.TabIndex = 0
        '
        'lbl_passDate_cuts
        '
        Me.lbl_passDate_cuts.AutoSize = True
        Me.lbl_passDate_cuts.Location = New System.Drawing.Point(197, 117)
        Me.lbl_passDate_cuts.Name = "lbl_passDate_cuts"
        Me.lbl_passDate_cuts.Size = New System.Drawing.Size(39, 13)
        Me.lbl_passDate_cuts.TabIndex = 63
        Me.lbl_passDate_cuts.Text = "Label3"
        Me.lbl_passDate_cuts.Visible = False
        '
        'lbl_passID_cuts
        '
        Me.lbl_passID_cuts.AutoSize = True
        Me.lbl_passID_cuts.Location = New System.Drawing.Point(3, 12)
        Me.lbl_passID_cuts.Name = "lbl_passID_cuts"
        Me.lbl_passID_cuts.Size = New System.Drawing.Size(39, 13)
        Me.lbl_passID_cuts.TabIndex = 62
        Me.lbl_passID_cuts.Text = "Label3"
        Me.lbl_passID_cuts.Visible = False
        '
        'txBx_numOfCuts
        '
        Me.txBx_numOfCuts.BackColor = System.Drawing.Color.White
        Me.txBx_numOfCuts.BackgroundImage = CType(resources.GetObject("txBx_numOfCuts.BackgroundImage"), System.Drawing.Image)
        Me.txBx_numOfCuts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txBx_numOfCuts.ForeColor = System.Drawing.Color.Black
        Me.txBx_numOfCuts.Icon = CType(resources.GetObject("txBx_numOfCuts.Icon"), System.Drawing.Image)
        Me.txBx_numOfCuts.Location = New System.Drawing.Point(71, 55)
        Me.txBx_numOfCuts.Name = "txBx_numOfCuts"
        Me.txBx_numOfCuts.Size = New System.Drawing.Size(179, 42)
        Me.txBx_numOfCuts.TabIndex = 61
        Me.txBx_numOfCuts.text = ""
        '
        'txBx_EmpNum_cuts
        '
        Me.txBx_EmpNum_cuts.BackColor = System.Drawing.Color.White
        Me.txBx_EmpNum_cuts.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_EmpNum_cuts.Enabled = False
        Me.txBx_EmpNum_cuts.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_EmpNum_cuts.ForeColor = System.Drawing.Color.Black
        Me.txBx_EmpNum_cuts.HintForeColor = System.Drawing.Color.Black
        Me.txBx_EmpNum_cuts.HintText = "ID Employee"
        Me.txBx_EmpNum_cuts.isPassword = False
        Me.txBx_EmpNum_cuts.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_EmpNum_cuts.LineIdleColor = System.Drawing.Color.Black
        Me.txBx_EmpNum_cuts.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_EmpNum_cuts.LineThickness = 4
        Me.txBx_EmpNum_cuts.Location = New System.Drawing.Point(71, 12)
        Me.txBx_EmpNum_cuts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txBx_EmpNum_cuts.Name = "txBx_EmpNum_cuts"
        Me.txBx_EmpNum_cuts.Size = New System.Drawing.Size(176, 35)
        Me.txBx_EmpNum_cuts.TabIndex = 60
        Me.txBx_EmpNum_cuts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtp_passDate_Cuts
        '
        Me.dtp_passDate_Cuts.BackColor = System.Drawing.Color.White
        Me.dtp_passDate_Cuts.BorderRadius = 0
        Me.dtp_passDate_Cuts.ForeColor = System.Drawing.Color.Black
        Me.dtp_passDate_Cuts.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtp_passDate_Cuts.FormatCustom = Nothing
        Me.dtp_passDate_Cuts.Location = New System.Drawing.Point(6, 94)
        Me.dtp_passDate_Cuts.Name = "dtp_passDate_Cuts"
        Me.dtp_passDate_Cuts.Size = New System.Drawing.Size(176, 36)
        Me.dtp_passDate_Cuts.TabIndex = 64
        Me.dtp_passDate_Cuts.Value = New Date(2017, 10, 6, 16, 49, 33, 79)
        Me.dtp_passDate_Cuts.Visible = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.mini_panel_cuts
        Me.BunifuDragControl1.Vertical = True
        '
        'form_addCUTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.mini_panel_cuts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_addCUTS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuts"
        Me.mini_panel_cuts.ResumeLayout(False)
        Me.mini_panel_cuts.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents mini_panel_cuts As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btn_enter_cuts As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lbl_transform2_emp As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_transform1_emp As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents lbl_passDate_cuts As Label
    Friend WithEvents lbl_passID_cuts As Label
    Friend WithEvents txBx_numOfCuts As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents txBx_EmpNum_cuts As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dtp_passDate_Cuts As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents btn_cuts_cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
