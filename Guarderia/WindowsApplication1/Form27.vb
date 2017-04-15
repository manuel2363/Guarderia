Public Class Form27

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form17.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Form12.Close()
        Me.Hide()
    End Sub
End Class