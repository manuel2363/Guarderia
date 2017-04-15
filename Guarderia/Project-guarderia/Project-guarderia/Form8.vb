Public Class Form8

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient

        'CONFIGURACIÓN DEL STMP
        '_SMTP.Credentials = New System.Net.NetworkCredential("cuenta de correo", "contraseña")
        _SMTP.Credentials = New System.Net.NetworkCredential("rolystar@gmail.com", "SOsobar##sagemanealujoso977plomo")
        _SMTP.Host = "smtp.gmail.com"
        _SMTP.Port = 587
        _SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        ''_Message.[To].Add(Me.txtPara.Text.ToString) 'Cuenta de Correo al que se le quiere enviar el e-mail
        _Message.From = New System.Net.Mail.MailAddress("rolystar@gmail.com", "Rolito", System.Text.Encoding.UTF8) 'Quien lo envía
        ''_Message.Subject = Me.txtAsunto.Text.ToString 'Sujeto del e-mail
        _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        ''_Message.Body = Me.txtMensaje.Text.ToString 'contenido del mail
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.Normal
        _Message.IsBodyHtml = False

        'ENVIO
        Try
            _SMTP.Send(_Message)
            MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
        End Try
    End Sub
End Class