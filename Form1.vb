Public Class Form1

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles usd_btn.Click
        Dim cad_val As Double
        Dim total_con As Double
        cad_val = input_cad.Text
        total_con = cad_val * 0.7
        resultss.Text = "The total of conversion is: " & total_con
    End Sub

    Private Sub euro_btn_CheckedChanged(sender As Object, e As EventArgs) Handles euro_btn.CheckedChanged
        Dim cad_val As Double
        Dim total_con As Double
        cad_val = input_cad.Text
        total_con = cad_val * 0.6
        resultss.Text = "The total of conversion is: " & total_con
    End Sub
End Class
