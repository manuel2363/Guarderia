Public Class Form1

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtUsuario.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim usuario, clave As String
        Cargar_Datos("SELECT nombre, apellido  FROM alumno;  INSERT into dpersonales (nombre,apellido,cedula) VALUES('" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtCedula.Text & "')  ")
        If (txtUsuario = )

        End If
        Form2.Show()
        Me.Hide()
    End Sub
End Class
