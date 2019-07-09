Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picChoice1_Click(sender As Object, e As EventArgs) Handles picChoice1.Click
        intChoice = 1
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        intChoice = 2
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        intChoice = 3
    End Sub

    Private Sub btnChoice_Click(sender As Object, e As EventArgs) Handles btnChoice.Click
        Select Case intChoice
            Case 1
                strChoice = "You have chosen COMPUTER 1"
            Case 2
                strChoice = "You have chosen COMPUTER 2"
            Case 3
                strChoice = "You have chosen COMPUTER 3"
        End Select
        btnChoice.Text = strChoice & " If this is correct click here to place your order."
    End Sub
End Class