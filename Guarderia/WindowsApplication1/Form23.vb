Public Class Form23

    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Form1.TxtUsuario.Text = "" Or Form1.TxtContra.Text = "" Then
                MsgBox("Por favor ingrese sus datos en todos los campos")
            Else
                Dim usu As String
                Dim clave As String
                usu = Form1.TxtUsuario.Text
                clave = Form1.TxtContra.Text
                login(usu, clave)

            End If

        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Me.Close()
    End Sub
End Class