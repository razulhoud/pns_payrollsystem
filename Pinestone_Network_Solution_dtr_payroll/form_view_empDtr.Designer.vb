<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_view_empDtr
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_view_empDtr))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuSeparator5 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dg_dtr_outside = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btn_exit_uiadmin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.dg_dtr_outside, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_exit_uiadmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuSeparator5.LineThickness = 2
        Me.BunifuSeparator5.Location = New System.Drawing.Point(-1, 48)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Size = New System.Drawing.Size(670, 19)
        Me.BunifuSeparator5.TabIndex = 28
        Me.BunifuSeparator5.Transparency = 255
        Me.BunifuSeparator5.Vertical = False
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(176, 9)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(117, 36)
        Me.BunifuCustomLabel9.TabIndex = 27
        Me.BunifuCustomLabel9.Text = "Record"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(24, 9)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(158, 36)
        Me.BunifuCustomLabel10.TabIndex = 26
        Me.BunifuCustomLabel10.Text = "Daily Time"
        '
        'dg_dtr_outside
        '
        Me.dg_dtr_outside.AllowUserToAddRows = False
        Me.dg_dtr_outside.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dg_dtr_outside.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_dtr_outside.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_dtr_outside.BackgroundColor = System.Drawing.Color.White
        Me.dg_dtr_outside.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_dtr_outside.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_dtr_outside.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_dtr_outside.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_dtr_outside.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg_dtr_outside.DoubleBuffered = True
        Me.dg_dtr_outside.EnableHeadersVisualStyles = False
        Me.dg_dtr_outside.GridColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.dg_dtr_outside.HeaderBgColor = System.Drawing.Color.Black
        Me.dg_dtr_outside.HeaderForeColor = System.Drawing.Color.White
        Me.dg_dtr_outside.Location = New System.Drawing.Point(7, 77)
        Me.dg_dtr_outside.Name = "dg_dtr_outside"
        Me.dg_dtr_outside.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_dtr_outside.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_dtr_outside.RowHeadersVisible = False
        Me.dg_dtr_outside.RowHeadersWidth = 10
        Me.dg_dtr_outside.RowTemplate.DividerHeight = 2
        Me.dg_dtr_outside.RowTemplate.Height = 60
        Me.dg_dtr_outside.RowTemplate.ReadOnly = True
        Me.dg_dtr_outside.Size = New System.Drawing.Size(662, 387)
        Me.dg_dtr_outside.TabIndex = 30
        Me.dg_dtr_outside.TabStop = False
        '
        'btn_exit_uiadmin
        '
        Me.btn_exit_uiadmin.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit_uiadmin.Image = CType(resources.GetObject("btn_exit_uiadmin.Image"), System.Drawing.Image)
        Me.btn_exit_uiadmin.ImageActive = Nothing
        Me.btn_exit_uiadmin.Location = New System.Drawing.Point(626, 9)
        Me.btn_exit_uiadmin.Name = "btn_exit_uiadmin"
        Me.btn_exit_uiadmin.Size = New System.Drawing.Size(43, 33)
        Me.btn_exit_uiadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_exit_uiadmin.TabIndex = 29
        Me.btn_exit_uiadmin.TabStop = False
        Me.btn_exit_uiadmin.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'form_view_empDtr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.dg_dtr_outside)
        Me.Controls.Add(Me.btn_exit_uiadmin)
        Me.Controls.Add(Me.BunifuSeparator5)
        Me.Controls.Add(Me.BunifuCustomLabel9)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_view_empDtr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_view_empDtr"
        CType(Me.dg_dtr_outside, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_exit_uiadmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuSeparator5 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btn_exit_uiadmin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dg_dtr_outside As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
