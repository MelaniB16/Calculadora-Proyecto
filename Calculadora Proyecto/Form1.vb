Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SUMASIGNO.Click

        Dim num1, num2, resultado As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        resultado = num1 + num2
        Me.RESULTADO.Text = resultado

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MENOSSIGNO.Click

        Dim num1, num2, resultado As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        resultado = num1 - num2
        Me.RESULTADO.Text = resultado



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DIVISIONSIGNO.Click

        Dim num1, num2, resultado As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        resultado = num1 / num2
        Me.RESULTADO.Text = resultado



    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles MULTIPLICACIONSIGNO.Click

        Dim num1, num2, resultado As Double
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        resultado = num1 * num2
        Me.RESULTADO.Text = resultado


    End Sub


End Class