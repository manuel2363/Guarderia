Public Class Form4

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.TxtUsuario.Text = ""
        Form1.TxtContra.Text = ""
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enviar.Click
        Try
            If TxtUsuario.Text = "" Or TxtCorreo.Text = "" Then
                MsgBox("Por favor ingrese sus datos en todos los campos")
            Else
                Dim Usu As String
                Dim Correo As String
                Usu = TxtUsuario.Text
                Correo = TxtCorreo.Text
                Perdida_Correo(Usu, Correo)

            End If
        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class