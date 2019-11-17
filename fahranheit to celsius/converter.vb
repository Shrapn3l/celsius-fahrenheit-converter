Public Class Form1


    Dim celr As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double
        x = Val(TextBox1.Text)
        Dim ResultF As Double = (x - 32) * (5 / 9)
        Dim ResultC As Double = x * (9 / 5) + 32






        If celr = True Then
            Label1.Text = ResultF

        End If

        If celr = False Then
            Label1.Text = ResultC
        End If








    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CheckBox1__CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1_.CheckedChanged
        celr = True
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        celr = False
    End Sub

End Class






