Public Class MANAGER2
    Private precio As Integer
    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub COMPRAR1_Click(sender As Object, e As EventArgs) Handles COMPRAR1.Click
        precio = 250
        TOTAL.Text = precio.ToString("$ ##0,00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub COMPRAR2_Click(sender As Object, e As EventArgs) Handles COMPRAR2.Click
        precio = 150
        TOTAL.Text = precio.ToString("$ ##0,00")
    End Sub

    Private Sub COMPRAR3_Click(sender As Object, e As EventArgs) Handles COMPRAR3.Click
        precio = 300
        TOTAL.Text = precio.ToString("$ ##0,00")
    End Sub

    Private Sub VERINFO1_Click(sender As Object, e As EventArgs) Handles VERINFO1.Click
        NOMBRE.Text = "just the way you are"
        CANCION.Text = "Bruo Mars"
        AÑO.Text = "2014"
        Me.AxWindowsMediaPlayer1.URL = "E:\musica\bruno.mp3"


    End Sub

    Private Sub VERINFO2_Click(sender As Object, e As EventArgs) Handles VERINFO2.Click
        NOMBRE.Text = "no digas lo siento"
        CANCION.Text = "Don tetto"
        AÑO.Text = "2010"
        Me.AxWindowsMediaPlayer1.URL = "E:\musica\dontetto.mp3"
    End Sub

    Private Sub VERINFO3_Click(sender As Object, e As EventArgs) Handles VERINFO3.Click
        NOMBRE.Text = "inolvidable"
        CANCION.Text = "Reik"
        AÑO.Text = "2010"
        Me.AxWindowsMediaPlayer1.URL = "E:\musica\reik.mp3"
    End Sub
End Class