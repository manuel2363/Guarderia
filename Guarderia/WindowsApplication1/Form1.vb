Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtUsuario.Text = ""
        TxtContra.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If TxtUsuario.Text = "" Or TxtContra.Text = "" Then
                MsgBox("Por favor ingrese sus datos en todos los campos")
            Else
                Dim usu As String
                Dim clave As String
                usu = TxtUsuario.Text
                clave = TxtContra.Text
                login(usu, clave)

            End If

        Catch ex As Exception

            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prueba_net.Click

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        If ConexionPostgres.State = ConnectionState.Open Then
            MsgBox("Conexión Exitosa", MsgBoxStyle.OkOnly, "Prueba de Conexión")
        Else
            MsgBox("Conexión Fallida", MsgBoxStyle.Critical, "Prueba de Conexión")
        End If
        ConexionPostgres.Close()
    End Sub

End Class
