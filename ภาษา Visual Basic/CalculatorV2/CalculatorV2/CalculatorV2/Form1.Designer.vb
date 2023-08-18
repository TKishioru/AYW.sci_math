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
        Me.btn_cal = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.txt_num1 = New System.Windows.Forms.TextBox()
        Me.rdo_plus = New System.Windows.Forms.RadioButton()
        Me.rdo_minus = New System.Windows.Forms.RadioButton()
        Me.rdo_multiply = New System.Windows.Forms.RadioButton()
        Me.rdo_normaldivide = New System.Windows.Forms.RadioButton()
        Me.rdo_abdivide = New System.Windows.Forms.RadioButton()
        Me.rdo_mod = New System.Windows.Forms.RadioButton()
        Me.rdo_expedite = New System.Windows.Forms.RadioButton()
        Me.txt2 = New System.Windows.Forms.Label()
        Me.txt_num2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cal
        '
        Me.btn_cal.Location = New System.Drawing.Point(420, 169)
        Me.btn_cal.Name = "btn_cal"
        Me.btn_cal.Size = New System.Drawing.Size(75, 23)
        Me.btn_cal.TabIndex = 0
        Me.btn_cal.Text = "คำนวณ"
        Me.btn_cal.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(420, 195)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "ปิดโปรแกรม"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Location = New System.Drawing.Point(9, 54)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(50, 13)
        Me.txt1.TabIndex = 2
        Me.txt1.Text = "ตัวแปร 1"
        '
        'txt_num1
        '
        Me.txt_num1.Location = New System.Drawing.Point(12, 70)
        Me.txt_num1.Name = "txt_num1"
        Me.txt_num1.Size = New System.Drawing.Size(100, 20)
        Me.txt_num1.TabIndex = 3
        '
        'rdo_plus
        '
        Me.rdo_plus.AutoSize = True
        Me.rdo_plus.Location = New System.Drawing.Point(28, 29)
        Me.rdo_plus.Name = "rdo_plus"
        Me.rdo_plus.Size = New System.Drawing.Size(60, 17)
        Me.rdo_plus.TabIndex = 4
        Me.rdo_plus.TabStop = True
        Me.rdo_plus.Text = "บวก (+)"
        Me.rdo_plus.UseVisualStyleBackColor = True
        '
        'rdo_minus
        '
        Me.rdo_minus.AutoSize = True
        Me.rdo_minus.Location = New System.Drawing.Point(28, 52)
        Me.rdo_minus.Name = "rdo_minus"
        Me.rdo_minus.Size = New System.Drawing.Size(50, 17)
        Me.rdo_minus.TabIndex = 5
        Me.rdo_minus.TabStop = True
        Me.rdo_minus.Text = "ลบ (-)"
        Me.rdo_minus.UseVisualStyleBackColor = True
        '
        'rdo_multiply
        '
        Me.rdo_multiply.AutoSize = True
        Me.rdo_multiply.Location = New System.Drawing.Point(28, 75)
        Me.rdo_multiply.Name = "rdo_multiply"
        Me.rdo_multiply.Size = New System.Drawing.Size(54, 17)
        Me.rdo_multiply.TabIndex = 6
        Me.rdo_multiply.TabStop = True
        Me.rdo_multiply.Text = "คูณ (*)"
        Me.rdo_multiply.UseVisualStyleBackColor = True
        '
        'rdo_normaldivide
        '
        Me.rdo_normaldivide.AutoSize = True
        Me.rdo_normaldivide.Location = New System.Drawing.Point(28, 98)
        Me.rdo_normaldivide.Name = "rdo_normaldivide"
        Me.rdo_normaldivide.Size = New System.Drawing.Size(57, 17)
        Me.rdo_normaldivide.TabIndex = 7
        Me.rdo_normaldivide.TabStop = True
        Me.rdo_normaldivide.Text = "หาร (/)"
        Me.rdo_normaldivide.UseVisualStyleBackColor = True
        '
        'rdo_abdivide
        '
        Me.rdo_abdivide.AutoSize = True
        Me.rdo_abdivide.Location = New System.Drawing.Point(28, 121)
        Me.rdo_abdivide.Name = "rdo_abdivide"
        Me.rdo_abdivide.Size = New System.Drawing.Size(92, 17)
        Me.rdo_abdivide.TabIndex = 8
        Me.rdo_abdivide.TabStop = True
        Me.rdo_abdivide.Text = "หารตัดเศษ (\)"
        Me.rdo_abdivide.UseVisualStyleBackColor = True
        '
        'rdo_mod
        '
        Me.rdo_mod.AutoSize = True
        Me.rdo_mod.Location = New System.Drawing.Point(28, 144)
        Me.rdo_mod.Name = "rdo_mod"
        Me.rdo_mod.Size = New System.Drawing.Size(109, 17)
        Me.rdo_mod.TabIndex = 9
        Me.rdo_mod.TabStop = True
        Me.rdo_mod.Text = "หารเอาเศษ (mod)"
        Me.rdo_mod.UseVisualStyleBackColor = True
        '
        'rdo_expedite
        '
        Me.rdo_expedite.AutoSize = True
        Me.rdo_expedite.Location = New System.Drawing.Point(28, 167)
        Me.rdo_expedite.Name = "rdo_expedite"
        Me.rdo_expedite.Size = New System.Drawing.Size(77, 17)
        Me.rdo_expedite.TabIndex = 10
        Me.rdo_expedite.TabStop = True
        Me.rdo_expedite.Text = "ยกกำลัง (^)"
        Me.rdo_expedite.UseVisualStyleBackColor = True
        '
        'txt2
        '
        Me.txt2.AutoSize = True
        Me.txt2.Location = New System.Drawing.Point(9, 106)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(50, 13)
        Me.txt2.TabIndex = 11
        Me.txt2.Text = "ตัวแปร 2"
        '
        'txt_num2
        '
        Me.txt_num2.Location = New System.Drawing.Point(12, 122)
        Me.txt_num2.Name = "txt_num2"
        Me.txt_num2.Size = New System.Drawing.Size(100, 20)
        Me.txt_num2.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdo_plus)
        Me.GroupBox1.Controls.Add(Me.rdo_minus)
        Me.GroupBox1.Controls.Add(Me.rdo_multiply)
        Me.GroupBox1.Controls.Add(Me.rdo_expedite)
        Me.GroupBox1.Controls.Add(Me.rdo_normaldivide)
        Me.GroupBox1.Controls.Add(Me.rdo_mod)
        Me.GroupBox1.Controls.Add(Me.rdo_abdivide)
        Me.GroupBox1.Location = New System.Drawing.Point(156, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 193)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เงื่อนไขตัวเลือกตัวดำเนินการ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ผลลัพธ์"
        '
        'lbl_result
        '
        Me.lbl_result.AutoSize = True
        Me.lbl_result.BackColor = System.Drawing.Color.SkyBlue
        Me.lbl_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lbl_result.Location = New System.Drawing.Point(443, 106)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(20, 24)
        Me.lbl_result.TabIndex = 15
        Me.lbl_result.Text = "0"
        Me.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(580, 349)
        Me.Controls.Add(Me.lbl_result)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_num2)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt_num1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_cal)
        Me.Name = "Form1"
        Me.Text = "Calculator (Beta2) โดย นางสาวคัมภีรดา ภู่ทอง"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cal As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents txt1 As Label
    Friend WithEvents txt_num1 As TextBox
    Friend WithEvents rdo_plus As RadioButton
    Friend WithEvents rdo_minus As RadioButton
    Friend WithEvents rdo_multiply As RadioButton
    Friend WithEvents rdo_normaldivide As RadioButton
    Friend WithEvents rdo_abdivide As RadioButton
    Friend WithEvents rdo_mod As RadioButton
    Friend WithEvents rdo_expedite As RadioButton
    Friend WithEvents txt2 As Label
    Friend WithEvents txt_num2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_result As Label
End Class
