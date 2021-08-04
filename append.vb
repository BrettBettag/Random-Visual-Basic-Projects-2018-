Public Class Form1
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        'writes a name to a sequential access file

        'declare a StreamWriter variable
        Dim outFile As IO.StreamWriter

        ' open the file for append
        outFile = IO.File.AppendText("contestants.txt")

        'write the name on a separate line in the file
        outFile.Close()

        'close the file
        outFile.Close()

        'clear the list box and then set the focus
        lstContestants.Items.Clear()
        txtName.Focus
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

End Class
