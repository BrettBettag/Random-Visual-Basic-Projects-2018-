Name: Preston Project
' Purpose: Displays an employee's salary
' Programmer: <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Structure Employee
        Public strId As String
        Public dblSalary As Double
    End Structure

    ' declare class-level array
    Public workers(6) As Employee

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' fills the class-level array and list box

        Dim inFile As IO.StreamReader
        Dim intSub As Integer
        Dim strLine As String

        ' verify that the file exists
        If IO.File.Exists("Employees.txt") Then
            inFile = IO.File.OpenText("Employees.txt")
            ' process loop instructions until end of file or end of array
            Do Until inFile.Peek = -1 OrElse intSub = workers.Length
                ' read a line from the file
                strLine = inFile.ReadLine
                ' store the first four characters as the ID in the array
                workers(intSub).strId = strLine.Substring(0, 5)
                ' store the salary in the array
                Double.TryParse(strLine.Substring(6), workers(intSub).dblSalary)
                ' add the ID to the list box
                lstIds.Items.Add(workers(intSub).strId)
                ' move to the next array element
                intSub += 1
            Loop

            inFile.Close()
            lstIds.SelectedIndex = 0

        Else
            MessageBox.Show("Can't find the Employees.txt file",
            "Preston Enterprises", MessageBoxButtons.OK,
            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub lstIds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIds.SelectedIndexChanged
        ' displays the salary corresponding to the ID selected in the list box

        lblSalary.Text = workers(lstIds.SelectedIndex).dblSalary.ToString("c0")
    End Sub
End Class

