Public Class Form1
    Private Striteminfo(,) As String = (("101", "Blue", "4.99"), ("102", "Red", "4.99"), ("103", "Blue", "10.49"), ("104", "Red", "10.49"))
Private Sub btnMatchesColor_Click(sender As Object, e As EventArgs) Handles btnMatchesColor.Click
        Dim strColor As String = lstColors.SelectedIndex.ToString
        Dim dblPrice As Double
        txtItems.Text = String.Empty
        For intRow As Integer = 0 To Striteminfo.GetUpperBound(0)
            If Striteminfo(intRow, 1) = strColor Then
                dblPrice = Convert.ToDouble(Striteminfo(intRow, 2))
                txtItems.Text = txtItems.Text & Striteminfo(intRow, 0).PadRight(10) & dblPrice.ToString("n2").PadRight(0) & ControlChars.NewLine
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intid As Integer = 100 To 110
            lstIDs.Items.Add(intid.ToString)
        Next intid
        lstIDs.SelectedIndex = 0
        lstColors.Items.Add("Black")
        lstColors.Items.Add("Blue")
        lstColors.Items.Add("Red")
        lstColors.Items.Add("White")
        lstColors.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMatches_ID.Click
        Dim intIndex As Integer = lstIDs.SelectedIndex
        txtItems.Text = String.Empty
        txtItems.Text = striteminfo(intIndex, 1).PadRight(10) & striteminfo(intIndex, 2)
    End Sub
End Class
