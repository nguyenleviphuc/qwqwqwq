<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.txtTENKH = New System.Windows.Forms.TextBox()
        Me.txtSOLUONG = New System.Windows.Forms.TextBox()
        Me.txtHOADON = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnNhaplai = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(93, 13)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(100, 20)
        Me.txtMAKH.TabIndex = 0
        '
        'txtTENKH
        '
        Me.txtTENKH.Location = New System.Drawing.Point(93, 39)
        Me.txtTENKH.Name = "txtTENKH"
        Me.txtTENKH.Size = New System.Drawing.Size(100, 20)
        Me.txtTENKH.TabIndex = 1
        '
        'txtSOLUONG
        '
        Me.txtSOLUONG.Location = New System.Drawing.Point(93, 65)
        Me.txtSOLUONG.Name = "txtSOLUONG"
        Me.txtSOLUONG.Size = New System.Drawing.Size(100, 20)
        Me.txtSOLUONG.TabIndex = 2
        '
        'txtHOADON
        '
        Me.txtHOADON.Location = New System.Drawing.Point(93, 91)
        Me.txtHOADON.Name = "txtHOADON"
        Me.txtHOADON.Size = New System.Drawing.Size(100, 20)
        Me.txtHOADON.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(472, 179)
        Me.DataGridView1.TabIndex = 3
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(263, 13)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 23)
        Me.btnLuu.TabIndex = 4
        Me.btnLuu.Text = "Luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnNhaplai
        '
        Me.btnNhaplai.Location = New System.Drawing.Point(357, 13)
        Me.btnNhaplai.Name = "btnNhaplai"
        Me.btnNhaplai.Size = New System.Drawing.Size(75, 23)
        Me.btnNhaplai.TabIndex = 4
        Me.btnNhaplai.Text = "Nhaplai"
        Me.btnNhaplai.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(263, 62)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 4
        Me.btnSua.Text = "Sua"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(357, 62)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 339)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnNhaplai)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtHOADON)
        Me.Controls.Add(Me.txtSOLUONG)
        Me.Controls.Add(Me.txtTENKH)
        Me.Controls.Add(Me.txtMAKH)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMAKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTENKH As System.Windows.Forms.TextBox
    Friend WithEvents txtSOLUONG As System.Windows.Forms.TextBox
    Friend WithEvents txtHOADON As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnNhaplai As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button

End Class
