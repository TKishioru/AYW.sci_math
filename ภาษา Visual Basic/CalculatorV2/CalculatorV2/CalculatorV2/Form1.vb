Public Class Form1
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_cal_Click(sender As Object, e As EventArgs) Handles btn_cal.Click
        Dim firstnum, secondnum, result As Single

        If IsNumeric(txt_num1.Text) And IsNumeric(txt_num2.Text) Then
            'If txtQuantity.Text Is IsNumeric() Then
            firstnum = txt_num1.Text
            secondnum = txt_num2.Text

            If rdo_plus.Checked = True Then
                result = firstnum + secondnum
            End If
            If rdo_minus.Checked = True Then
                result = firstnum - secondnum
            End If
            If rdo_multiply.Checked = True Then
                result = firstnum * secondnum
            End If
            If rdo_normaldivide.Checked = True Then
                result = firstnum / secondnum
            End If
            If rdo_abdivide.Checked = True Then
                result = firstnum \ secondnum
            End If
            If rdo_mod.Checked = True Then
                result = firstnum Mod secondnum
            End If
            If rdo_expedite.Checked = True Then
                result = firstnum ^ secondnum
            End If

            lbl_result.Text = result
        Else MessageBox.Show(" ข้อมูลต้องเป็นตัวเลขเท่ํานั้น ")
            txt1.Text = ""
            txt2.Text = ""
        End If
    End Sub
End Class
