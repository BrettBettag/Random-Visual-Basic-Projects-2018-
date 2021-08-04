Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim inFile As IO.StreamReader
        Dim strInfo As String

        If IO.File.Exists("Ebooks.txt") Then
            inFile = IO.File.OpenText("Ebooks.txt")
            Do Until inFile.Peek = -1
                strInfo = inFile.ReadLine
                lstEbooks.Items.Add(strInfo)
            Loop
            inFile.Close()
            lstEbooks.SelectedIndex = 0
        Else
            MessageBox.Show("Can't find the Ebooks.txt file",
                            "eBooks", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim strTitle As String
        Dim strAuthor As String
        Dim strPrice As String
        Dim strConcatenatedInfo As String
        Dim dblPrice As Double

        strTitle = InputBox("Title:", "eBooks")
        strAuthor = InputBox("Author:", "eBooks")
        strPrice = InputBox("Price:", "eBooks")

        Double.TryParse(strPrice, dblPrice)
        strPrice = dblPrice.ToString("n2")
        strConcatenatedInfo = strTitle.PadRight(40) &
            strAuthor.PadRight(35) & strPrice.PadLeft(5)

        lstEbooks.Items.Add(strConcatenatedInfo)

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lstEbooks.SelectedIndex <> -1 Then
            lstEbooks.Items.RemoveAt(lstEbooks.SelectedIndex)
        End If
    End Sub

    Private Sub Form1_LoadClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim outFile As IO.StreamWriter

        outFile = IO.File.CreateText("Ebooks.txt")

        For intIndex As Integer = 0 To lstEbooks.Items.Count - 1
            outFile.WriteLine(lstEbooks.Items(intIndex))
        Next intIndex

        outFile.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
