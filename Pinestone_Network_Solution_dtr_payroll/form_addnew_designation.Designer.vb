<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_addnew_designation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_addnew_designation))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_adddesignation_cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_addDesig_addnew = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lbl_addDesig2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_addDesig1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_editDesig2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbl_editDesig1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btn_addDesig_edit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_exit_addDesig = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.txBxMgc_idDesig = New System.Windows.Forms.TextBox()
        Me.txBxMgc_idDep = New System.Windows.Forms.TextBox()
        Me.cmBx_addDes_dept = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txBx_adddes_sal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txBx_adddes_name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        CType(Me.btn_exit_addDesig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(-5, -64)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(148, 23)
        Me.BunifuCustomLabel4.TabIndex = 39
        Me.BunifuCustomLabel4.Text = "Add Employee"
        '
        'btn_adddesignation_cancel
        '
        Me.btn_adddesignation_cancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_adddesignation_cancel.BackColor = System.Drawing.Color.White
        Me.btn_adddesignation_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_adddesignation_cancel.BorderRadius = 0
        Me.btn_adddesignation_cancel.ButtonText = "CANCEL"
        Me.btn_adddesignation_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_adddesignation_cancel.DisabledColor = System.Drawing.Color.Gray
        Me.btn_adddesignation_cancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_adddesignation_cancel.Iconimage = Nothing
        Me.btn_adddesignation_cancel.Iconimage_right = Nothing
        Me.btn_adddesignation_cancel.Iconimage_right_Selected = Nothing
        Me.btn_adddesignation_cancel.Iconimage_Selected = Nothing
        Me.btn_adddesignation_cancel.IconMarginLeft = 0
        Me.btn_adddesignation_cancel.IconMarginRight = 0
        Me.btn_adddesignation_cancel.IconRightVisible = True
        Me.btn_adddesignation_cancel.IconRightZoom = 0R
        Me.btn_adddesignation_cancel.IconVisible = True
        Me.btn_adddesignation_cancel.IconZoom = 90.0R
        Me.btn_adddesignation_cancel.IsTab = False
        Me.btn_adddesignation_cancel.Location = New System.Drawing.Point(262, 335)
        Me.btn_adddesignation_cancel.Name = "btn_adddesignation_cancel"
        Me.btn_adddesignation_cancel.Normalcolor = System.Drawing.Color.White
        Me.btn_adddesignation_cancel.OnHovercolor = System.Drawing.Color.White
        Me.btn_adddesignation_cancel.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_adddesignation_cancel.selected = False
        Me.btn_adddesignation_cancel.Size = New System.Drawing.Size(105, 48)
        Me.btn_adddesignation_cancel.TabIndex = 38
        Me.btn_adddesignation_cancel.Text = "CANCEL"
        Me.btn_adddesignation_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_adddesignation_cancel.Textcolor = System.Drawing.Color.Black
        Me.btn_adddesignation_cancel.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_addDesig_addnew
        '
        Me.btn_addDesig_addnew.Activecolor = System.Drawing.Color.White
        Me.btn_addDesig_addnew.BackColor = System.Drawing.Color.White
        Me.btn_addDesig_addnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addDesig_addnew.BorderRadius = 0
        Me.btn_addDesig_addnew.ButtonText = "ADD NEW"
        Me.btn_addDesig_addnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addDesig_addnew.DisabledColor = System.Drawing.Color.Gray
        Me.btn_addDesig_addnew.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_addDesig_addnew.Iconimage = Nothing
        Me.btn_addDesig_addnew.Iconimage_right = Nothing
        Me.btn_addDesig_addnew.Iconimage_right_Selected = Nothing
        Me.btn_addDesig_addnew.Iconimage_Selected = Nothing
        Me.btn_addDesig_addnew.IconMarginLeft = 0
        Me.btn_addDesig_addnew.IconMarginRight = 0
        Me.btn_addDesig_addnew.IconRightVisible = True
        Me.btn_addDesig_addnew.IconRightZoom = 0R
        Me.btn_addDesig_addnew.IconVisible = True
        Me.btn_addDesig_addnew.IconZoom = 90.0R
        Me.btn_addDesig_addnew.IsTab = False
        Me.btn_addDesig_addnew.Location = New System.Drawing.Point(373, 335)
        Me.btn_addDesig_addnew.Name = "btn_addDesig_addnew"
        Me.btn_addDesig_addnew.Normalcolor = System.Drawing.Color.White
        Me.btn_addDesig_addnew.OnHovercolor = System.Drawing.Color.White
        Me.btn_addDesig_addnew.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_addDesig_addnew.selected = False
        Me.btn_addDesig_addnew.Size = New System.Drawing.Size(104, 48)
        Me.btn_addDesig_addnew.TabIndex = 37
        Me.btn_addDesig_addnew.Text = "ADD NEW"
        Me.btn_addDesig_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_addDesig_addnew.Textcolor = System.Drawing.Color.Black
        Me.btn_addDesig_addnew.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lbl_addDesig2
        '
        Me.lbl_addDesig2.AutoSize = True
        Me.lbl_addDesig2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_addDesig2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addDesig2.ForeColor = System.Drawing.Color.White
        Me.lbl_addDesig2.Location = New System.Drawing.Point(55, 38)
        Me.lbl_addDesig2.Name = "lbl_addDesig2"
        Me.lbl_addDesig2.Size = New System.Drawing.Size(119, 23)
        Me.lbl_addDesig2.TabIndex = 43
        Me.lbl_addDesig2.Text = "Designation"
        '
        'lbl_addDesig1
        '
        Me.lbl_addDesig1.AutoSize = True
        Me.lbl_addDesig1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_addDesig1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addDesig1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_addDesig1.Location = New System.Drawing.Point(11, 38)
        Me.lbl_addDesig1.Name = "lbl_addDesig1"
        Me.lbl_addDesig1.Size = New System.Drawing.Size(50, 23)
        Me.lbl_addDesig1.TabIndex = 42
        Me.lbl_addDesig1.Text = "Add"
        '
        'lbl_editDesig2
        '
        Me.lbl_editDesig2.AutoSize = True
        Me.lbl_editDesig2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_editDesig2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editDesig2.ForeColor = System.Drawing.Color.White
        Me.lbl_editDesig2.Location = New System.Drawing.Point(53, 41)
        Me.lbl_editDesig2.Name = "lbl_editDesig2"
        Me.lbl_editDesig2.Size = New System.Drawing.Size(119, 23)
        Me.lbl_editDesig2.TabIndex = 46
        Me.lbl_editDesig2.Text = "Designation"
        Me.lbl_editDesig2.Visible = False
        '
        'lbl_editDesig1
        '
        Me.lbl_editDesig1.AutoSize = True
        Me.lbl_editDesig1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_editDesig1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_editDesig1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lbl_editDesig1.Location = New System.Drawing.Point(15, 41)
        Me.lbl_editDesig1.Name = "lbl_editDesig1"
        Me.lbl_editDesig1.Size = New System.Drawing.Size(44, 23)
        Me.lbl_editDesig1.TabIndex = 45
        Me.lbl_editDesig1.Text = "Edit"
        Me.lbl_editDesig1.Visible = False
        '
        'btn_addDesig_edit
        '
        Me.btn_addDesig_edit.Activecolor = System.Drawing.Color.White
        Me.btn_addDesig_edit.BackColor = System.Drawing.Color.White
        Me.btn_addDesig_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addDesig_edit.BorderRadius = 0
        Me.btn_addDesig_edit.ButtonText = "UPDATE"
        Me.btn_addDesig_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addDesig_edit.DisabledColor = System.Drawing.Color.Gray
        Me.btn_addDesig_edit.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_addDesig_edit.Iconimage = Nothing
        Me.btn_addDesig_edit.Iconimage_right = Nothing
        Me.btn_addDesig_edit.Iconimage_right_Selected = Nothing
        Me.btn_addDesig_edit.Iconimage_Selected = Nothing
        Me.btn_addDesig_edit.IconMarginLeft = 0
        Me.btn_addDesig_edit.IconMarginRight = 0
        Me.btn_addDesig_edit.IconRightVisible = True
        Me.btn_addDesig_edit.IconRightZoom = 0R
        Me.btn_addDesig_edit.IconVisible = True
        Me.btn_addDesig_edit.IconZoom = 90.0R
        Me.btn_addDesig_edit.IsTab = False
        Me.btn_addDesig_edit.Location = New System.Drawing.Point(373, 335)
        Me.btn_addDesig_edit.Name = "btn_addDesig_edit"
        Me.btn_addDesig_edit.Normalcolor = System.Drawing.Color.White
        Me.btn_addDesig_edit.OnHovercolor = System.Drawing.Color.White
        Me.btn_addDesig_edit.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btn_addDesig_edit.selected = False
        Me.btn_addDesig_edit.Size = New System.Drawing.Size(104, 48)
        Me.btn_addDesig_edit.TabIndex = 47
        Me.btn_addDesig_edit.Text = "UPDATE"
        Me.btn_addDesig_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_addDesig_edit.Textcolor = System.Drawing.Color.Black
        Me.btn_addDesig_edit.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addDesig_edit.Visible = False
        '
        'btn_exit_addDesig
        '
        Me.btn_exit_addDesig.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit_addDesig.Image = CType(resources.GetObject("btn_exit_addDesig.Image"), System.Drawing.Image)
        Me.btn_exit_addDesig.ImageActive = Nothing
        Me.btn_exit_addDesig.Location = New System.Drawing.Point(453, 12)
        Me.btn_exit_addDesig.Name = "btn_exit_addDesig"
        Me.btn_exit_addDesig.Size = New System.Drawing.Size(25, 25)
        Me.btn_exit_addDesig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_exit_addDesig.TabIndex = 44
        Me.btn_exit_addDesig.TabStop = False
        Me.btn_exit_addDesig.Zoom = 10
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.txBxMgc_idDesig)
        Me.BunifuGradientPanel1.Controls.Add(Me.txBxMgc_idDep)
        Me.BunifuGradientPanel1.Controls.Add(Me.cmBx_addDes_dept)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_adddes_sal)
        Me.BunifuGradientPanel1.Controls.Add(Me.txBx_adddes_name)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-2, 104)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(494, 225)
        Me.BunifuGradientPanel1.TabIndex = 36
        '
        'txBxMgc_idDesig
        '
        Me.txBxMgc_idDesig.Location = New System.Drawing.Point(14, 3)
        Me.txBxMgc_idDesig.Name = "txBxMgc_idDesig"
        Me.txBxMgc_idDesig.Size = New System.Drawing.Size(35, 20)
        Me.txBxMgc_idDesig.TabIndex = 41
        Me.txBxMgc_idDesig.TabStop = False
        '
        'txBxMgc_idDep
        '
        Me.txBxMgc_idDep.Location = New System.Drawing.Point(17, 202)
        Me.txBxMgc_idDep.Name = "txBxMgc_idDep"
        Me.txBxMgc_idDep.Size = New System.Drawing.Size(35, 20)
        Me.txBxMgc_idDep.TabIndex = 0
        Me.txBxMgc_idDep.TabStop = False
        '
        'cmBx_addDes_dept
        '
        Me.cmBx_addDes_dept.BackColor = System.Drawing.Color.Transparent
        Me.cmBx_addDes_dept.BorderRadius = 3
        Me.cmBx_addDes_dept.DisabledColor = System.Drawing.Color.Gray
        Me.cmBx_addDes_dept.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmBx_addDes_dept.ForeColor = System.Drawing.Color.White
        Me.cmBx_addDes_dept.Items = New String(-1) {}
        Me.cmBx_addDes_dept.Location = New System.Drawing.Point(14, 161)
        Me.cmBx_addDes_dept.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cmBx_addDes_dept.Name = "cmBx_addDes_dept"
        Me.cmBx_addDes_dept.NomalColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cmBx_addDes_dept.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cmBx_addDes_dept.selectedIndex = -1
        Me.cmBx_addDes_dept.Size = New System.Drawing.Size(466, 40)
        Me.cmBx_addDes_dept.TabIndex = 40
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(10, 135)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(116, 21)
        Me.BunifuCustomLabel5.TabIndex = 39
        Me.BunifuCustomLabel5.Text = "Department :"
        '
        'txBx_adddes_sal
        '
        Me.txBx_adddes_sal.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_adddes_sal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_adddes_sal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_adddes_sal.ForeColor = System.Drawing.Color.White
        Me.txBx_adddes_sal.HintForeColor = System.Drawing.Color.LightGray
        Me.txBx_adddes_sal.HintText = "Salary"
        Me.txBx_adddes_sal.isPassword = False
        Me.txBx_adddes_sal.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_adddes_sal.LineIdleColor = System.Drawing.Color.White
        Me.txBx_adddes_sal.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_adddes_sal.LineThickness = 4
        Me.txBx_adddes_sal.Location = New System.Drawing.Point(14, 89)
        Me.txBx_adddes_sal.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_adddes_sal.Name = "txBx_adddes_sal"
        Me.txBx_adddes_sal.Size = New System.Drawing.Size(466, 41)
        Me.txBx_adddes_sal.TabIndex = 26
        Me.txBx_adddes_sal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txBx_adddes_name
        '
        Me.txBx_adddes_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txBx_adddes_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txBx_adddes_name.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBx_adddes_name.ForeColor = System.Drawing.Color.White
        Me.txBx_adddes_name.HintForeColor = System.Drawing.Color.LightGray
        Me.txBx_adddes_name.HintText = "Designation"
        Me.txBx_adddes_name.isPassword = False
        Me.txBx_adddes_name.LineFocusedColor = System.Drawing.Color.White
        Me.txBx_adddes_name.LineIdleColor = System.Drawing.Color.White
        Me.txBx_adddes_name.LineMouseHoverColor = System.Drawing.Color.Black
        Me.txBx_adddes_name.LineThickness = 4
        Me.txBx_adddes_name.Location = New System.Drawing.Point(14, 29)
        Me.txBx_adddes_name.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txBx_adddes_name.Name = "txBx_adddes_name"
        Me.txBx_adddes_name.Size = New System.Drawing.Size(466, 41)
        Me.txBx_adddes_name.TabIndex = 25
        Me.txBx_adddes_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'form_addnew_designation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(489, 395)
        Me.Controls.Add(Me.lbl_editDesig2)
        Me.Controls.Add(Me.lbl_editDesig1)
        Me.Controls.Add(Me.btn_exit_addDesig)
        Me.Controls.Add(Me.lbl_addDesig2)
        Me.Controls.Add(Me.lbl_addDesig1)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.btn_adddesignation_cancel)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.btn_addDesig_addnew)
        Me.Controls.Add(Me.btn_addDesig_edit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_addnew_designation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Edit Designation"
        CType(Me.btn_exit_addDesig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_adddesignation_cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_addDesig_addnew As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents txBx_adddes_sal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txBx_adddes_name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbl_addDesig2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_addDesig1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_exit_addDesig As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txBxMgc_idDep As TextBox
    Friend WithEvents cmBx_addDes_dept As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents txBxMgc_idDesig As TextBox
    Friend WithEvents btn_addDesig_edit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lbl_editDesig2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbl_editDesig1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
