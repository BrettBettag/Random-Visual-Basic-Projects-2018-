Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles radFamily.CheckedChanged, radSingle.CheckedChanged,
    chkGolf.CheckedChanged, chkRacquet.CheckedChanged, chkTennis.CheckedChanged
        lblBasic.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblDues.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates the monthly dues, which include a basic fee and optional charges

        Const intSINGLE_BASIC As Integer = 50
        Const intFAMILY_BASIC As Integer = 90
        Const intSINGLE_TENNIS As Integer = 30
        Const intSINGLE_GOLF As Integer = 25
        Const intSINGLE_RACQUET As Integer = 20
        Const intFAMILY_TENNIS As Integer = 50
        Const intFAMILY_GOLF As Integer = 35
        Const intFAMILY_RACQUET As Integer = 30

        Dim memberDues As New Dues

        ' determine which radio button is checked and which check boxes (if any) are checked
        Select Case True
            Case radSingle.Checked
                memberDues.Basic = intSINGLE_BASIC
                If chkGolf.Checked Then
                    memberDues.Additional = memberDues.Additional + intSINGLE_GOLF
                End If
                If chkTennis.Checked Then
                    memberDues.Additional = memberDues.Additional + intSINGLE_TENNIS
                End If
                If chkRacquet.Checked Then
                    memberDues.Additional = memberDues.Additional + intSINGLE_RACQUET
                End If
            Case radFamily.Checked
                memberDues.Basic = intFAMILY_BASIC
                If chkGolf.Checked Then
                    memberDues.Additional = memberDues.Additional + intFAMILY_GOLF
                End If
                If chkTennis.Checked Then
                    memberDues.Additional = memberDues.Additional + intFAMILY_TENNIS
                End If
                If chkRacquet.Checked Then
                    memberDues.Additional = memberDues.Additional + intFAMILY_RACQUET
                End If
        End Select

        ' display the basic, additional, and total fees
        lblBasic.Text = memberDues.Basic.ToString("N2")
        lblAdditional.Text = memberDues.Additional.ToString("N2")
        lblDues.Text = memberDues.GetDues.ToString("C2")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

2nd class Dues.vb
' Name: Dues.vb
' Programmer: <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class Dues
    Public Property Basic As Integer
    Public Property Additional As Integer

    Public Sub New()
        _Basic = 0
        _Additional = 0
    End Sub

    Public Sub New(ByVal intBase As Integer, ByVal intAdd As Integer)
        Basic = intBase
        Additional = intAdd
    End Sub

    Public Function GetDues() As Integer
        Return _Basic + _Additional
    End Function

End Class
