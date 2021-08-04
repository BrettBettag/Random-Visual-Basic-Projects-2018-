Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Private randomizer As New Random
        Private addend1 As Integer
        Private addend2 As Integer

            Public Sub StartTheQuiz()
        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)
        plusLeftLabel.Text = addend1.ToString()
        plusRightLabel.Text = addend2.ToString()

        sum.Value = 0

        Private Sub startButton_Click() Handles startButton.Click
        StartTheQuiz()
        startButton.Enabled = False

        Private randomizer As New Random

        ' These integer variables store the numbers 
        ' for the addition problem. 
        Private addend1 As Integer
        Private addend2 As Integer

        ' This integer variable keeps track of the 
        ' remaining time.
        Private timeLeft As Integer


         Private Sub Timer1_Tick() Handles Timer1.Tick

        If timeLeft > 0 Then

            ' If the user ran out of time, stop the timer, show
            ' a MessageBox, and fill in the answers.
            Timer1.Stop()
            timeLabel.Text = "Time's up!"
            MessageBox.Show("You didn't finish in time.", "Sorry!")
            sum.Value = addend1 + addend2
            startButton.Enabled = True
        End If

        End If
    End Sub
End Class
