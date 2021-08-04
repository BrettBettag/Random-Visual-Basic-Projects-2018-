Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dblTaxRates() As Double = {5.5, 7.25, 3.4}
        Dim intHighest As Integer = dblTaxRates.Length - 1
        Dim intLast As Integer = 0

        Do While intLast <= intHighest
            ListBox1.Items.Add(dblTaxRates(intLast))
            intLast += 1
        Loop

    End Sub
End Class
