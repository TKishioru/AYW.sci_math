Public Class Form1
    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        Dim num1, num2 As Double
        num1 = tb_plus1.Text
        num2 = tb_plus2.Text

        lb_plus.Text = num1 + num2

    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        Dim num1, num2 As Double
        num1 = tb_minus1.Text
        num2 = tb_minus2.Text

        lb_minus.Text = num1 - num2

    End Sub

    Private Sub btn__multi_Click(sender As Object, e As EventArgs) Handles btn__multi.Click
        Dim num1, num2 As Double
        num1 = tb_multi1.Text
        num2 = tb_multi2.Text

        lb_multi.Text = num1 * num2

    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        Dim num1, num2 As Double
        num1 = tb_div1.Text
        num2 = tb_div2.Text

        lb_div.Text = num1 / num2

    End Sub
End Class
