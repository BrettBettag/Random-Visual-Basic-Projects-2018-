Public Class Form1
    Public Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim strAddress As String
        Dim blnIsContained As Boolean

        strAddress = txtAddress.Text.Trim
        Me.lblBoolean.Text = strAddress
        blnIsContained = strAddress.Contains("Jefferson Street")
        lblBoolean.Text = blnIsContained
    End Sub
End Class
