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
        Me.lb_plus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.tb_plus1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_plus2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.tb_minus1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb_minus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_minus2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.tb_div1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_div = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_div2 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn__multi = New System.Windows.Forms.Button()
        Me.tb_multi1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lb_multi = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tb_multi2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_plus
        '
        Me.lb_plus.AutoSize = True
        Me.lb_plus.Location = New System.Drawing.Point(191, 38)
        Me.lb_plus.Name = "lb_plus"
        Me.lb_plus.Size = New System.Drawing.Size(13, 13)
        Me.lb_plus.TabIndex = 0
        Me.lb_plus.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_plus)
        Me.GroupBox1.Controls.Add(Me.tb_plus1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lb_plus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tb_plus2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 142)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "การบวก"
        '
        'btn_plus
        '
        Me.btn_plus.Location = New System.Drawing.Point(91, 83)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(75, 23)
        Me.btn_plus.TabIndex = 6
        Me.btn_plus.Text = "คำนวณ"
        Me.btn_plus.UseVisualStyleBackColor = True
        '
        'tb_plus1
        '
        Me.tb_plus1.Location = New System.Drawing.Point(6, 35)
        Me.tb_plus1.Name = "tb_plus1"
        Me.tb_plus1.Size = New System.Drawing.Size(69, 20)
        Me.tb_plus1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "+"
        '
        'tb_plus2
        '
        Me.tb_plus2.Location = New System.Drawing.Point(97, 35)
        Me.tb_plus2.Name = "tb_plus2"
        Me.tb_plus2.Size = New System.Drawing.Size(69, 20)
        Me.tb_plus2.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_minus)
        Me.GroupBox2.Controls.Add(Me.tb_minus1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lb_minus)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tb_minus2)
        Me.GroupBox2.Location = New System.Drawing.Point(285, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 142)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การลบ"
        '
        'btn_minus
        '
        Me.btn_minus.Location = New System.Drawing.Point(91, 83)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(75, 23)
        Me.btn_minus.TabIndex = 6
        Me.btn_minus.Text = "คำนวณ"
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'tb_minus1
        '
        Me.tb_minus1.Location = New System.Drawing.Point(6, 35)
        Me.tb_minus1.Name = "tb_minus1"
        Me.tb_minus1.Size = New System.Drawing.Size(69, 20)
        Me.tb_minus1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "="
        '
        'lb_minus
        '
        Me.lb_minus.AutoSize = True
        Me.lb_minus.Location = New System.Drawing.Point(191, 38)
        Me.lb_minus.Name = "lb_minus"
        Me.lb_minus.Size = New System.Drawing.Size(13, 13)
        Me.lb_minus.TabIndex = 0
        Me.lb_minus.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "-"
        '
        'tb_minus2
        '
        Me.tb_minus2.Location = New System.Drawing.Point(97, 35)
        Me.tb_minus2.Name = "tb_minus2"
        Me.tb_minus2.Size = New System.Drawing.Size(69, 20)
        Me.tb_minus2.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_div)
        Me.GroupBox3.Controls.Add(Me.tb_div1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lb_div)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.tb_div2)
        Me.GroupBox3.Location = New System.Drawing.Point(285, 175)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 142)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "การหาร"
        '
        'btn_div
        '
        Me.btn_div.Location = New System.Drawing.Point(91, 83)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(75, 23)
        Me.btn_div.TabIndex = 6
        Me.btn_div.Text = "คำนวณ"
        Me.btn_div.UseVisualStyleBackColor = True
        '
        'tb_div1
        '
        Me.tb_div1.Location = New System.Drawing.Point(6, 35)
        Me.tb_div1.Name = "tb_div1"
        Me.tb_div1.Size = New System.Drawing.Size(69, 20)
        Me.tb_div1.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(172, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "="
        '
        'lb_div
        '
        Me.lb_div.AutoSize = True
        Me.lb_div.Location = New System.Drawing.Point(191, 38)
        Me.lb_div.Name = "lb_div"
        Me.lb_div.Size = New System.Drawing.Size(13, 13)
        Me.lb_div.TabIndex = 0
        Me.lb_div.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "/"
        '
        'tb_div2
        '
        Me.tb_div2.Location = New System.Drawing.Point(97, 35)
        Me.tb_div2.Name = "tb_div2"
        Me.tb_div2.Size = New System.Drawing.Size(69, 20)
        Me.tb_div2.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn__multi)
        Me.GroupBox4.Controls.Add(Me.tb_multi1)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.lb_multi)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.tb_multi2)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 175)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 142)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "การคูณ"
        '
        'btn__multi
        '
        Me.btn__multi.Location = New System.Drawing.Point(91, 83)
        Me.btn__multi.Name = "btn__multi"
        Me.btn__multi.Size = New System.Drawing.Size(75, 23)
        Me.btn__multi.TabIndex = 6
        Me.btn__multi.Text = "คำนวณ"
        Me.btn__multi.UseVisualStyleBackColor = True
        '
        'tb_multi1
        '
        Me.tb_multi1.Location = New System.Drawing.Point(6, 35)
        Me.tb_multi1.Name = "tb_multi1"
        Me.tb_multi1.Size = New System.Drawing.Size(69, 20)
        Me.tb_multi1.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(172, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "="
        '
        'lb_multi
        '
        Me.lb_multi.AutoSize = True
        Me.lb_multi.Location = New System.Drawing.Point(191, 38)
        Me.lb_multi.Name = "lb_multi"
        Me.lb_multi.Size = New System.Drawing.Size(13, 13)
        Me.lb_multi.TabIndex = 0
        Me.lb_multi.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(81, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "*"
        '
        'tb_multi2
        '
        Me.tb_multi2.Location = New System.Drawing.Point(97, 35)
        Me.tb_multi2.Name = "tb_multi2"
        Me.tb_multi2.Size = New System.Drawing.Size(69, 20)
        Me.tb_multi2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Calculator1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lb_plus As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_plus As Button
    Friend WithEvents tb_plus1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_plus2 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_minus As Button
    Friend WithEvents tb_minus1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lb_minus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_minus2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_div As Button
    Friend WithEvents tb_div1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lb_div As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_div2 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn__multi As Button
    Friend WithEvents tb_multi1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lb_multi As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_multi2 As TextBox
End Class
