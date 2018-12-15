Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sum, tax, net As Decimal

        sum = Val(TextBox1.Text) * 12
        tax = sum * 5 / 100
        net = sum - tax

        Label3.Text = sum
        Label2.Text = tax
        Label4.Text = net


    End Sub
End Class
