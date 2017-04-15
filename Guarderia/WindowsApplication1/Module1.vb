Module Module1
    Public Id_form As String
    Public ConexionPostgres As New Odbc.OdbcConnection("DSN=proyecto")
    Public Tabla, dr As Odbc.OdbcDataReader

    Dim Convertido As String
    'Dim cont As Integer


    Public Sub Cargar_Datos(ByVal sql As String)

        ' si la conexion esta abierta se cierra 
        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open() ' abre la conexión   
        Dim cdo As New Odbc.OdbcCommand(sql, ConexionPostgres)
        cdo.ExecuteNonQuery() 'ejecuta la sentencia sql
        'Tabla = cdo.ExecuteReader()

        ' se cierra la conexion    
        ConexionPostgres.Close()
    End Sub

    Public Sub login(ByVal Usu As String, ByVal clave As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String
        cmd.CommandText = "Select * from usuario where usuar_log='" + Usu + "' and usuar_clave='" + clave + "'; "
        'MsgBox(sql)
        'cmd.CommandType = sql
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                If dr.Item(1) = "" Then
                    Form2.Show()
                    Form1.Hide()
                    Form2.ParámetrosToolStripMenuItem.Enabled = False
                    Form2.InscripciónToolStripMenuItem.Enabled = False
                    Form2.ControlDePagoToolStripMenuItem.Enabled = False
                    Form2.ConsultasYReportesToolStripMenuItem.Enabled = False
                    Form2.SeguridadToolStripMenuItem.Enabled = False
                    Form2.SalirToolStripMenuItem1.Enabled = False
                    Form2.AyudaToolStripMenuItem.Enabled = False
                    Form2.SalirToolStripMenuItem.Enabled = True

                ElseIf dr.Item(1) = "empleado" Or dr.Item(1) = "Empleado" Then
                    Form2.Show()
                    Form1.Hide()
                    Form2.MenuStrip1.Enabled = True

                    ''----no crea nuevo usuarios en estas form
                    Form2.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form3.NuevoUsuarioToolStripMenuItem.Enabled = False
                    'Form4.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form5.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form6.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form7.NuevoUsuarioToolStripMenuItem.Enabled = False
                    'Form8.NuevoUsuarioToolStripMenuItem.Enabled = False
                    'Form9.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form10.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form11.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form12.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form13.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form14.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form15.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form16.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form17.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form18.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form19.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form20.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form21.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form22.NuevoUsuarioToolStripMenuItem.Enabled = False
                    'Form23.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form24.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form25.NuevoUsuarioToolStripMenuItem.Enabled = False
                    'Form26.NuevoUsuarioToolStripMenuItem.Enabled = False
                    'Form27.NuevoUsuarioToolStripMenuItem.Enabled = False
                    '--------------------------------------------------------------
                    ''-------------No se modifican parametros en estas form
                    Form2.ParámetrosToolStripMenuItem.Enabled = False
                    Form3.ParámetrosToolStripMenuItem.Enabled = False
                    'Form4.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form5.ParámetrosToolStripMenuItem.Enabled = False
                    Form6.ParámetrosToolStripMenuItem.Enabled = False
                    Form7.ParámetrosToolStripMenuItem.Enabled = False
                    'Form8.NuevoUsuarioToolStripMenuItem.Enabled = False
                    'Form9.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form10.ParámetrosToolStripMenuItem.Enabled = False
                    Form11.ParámetrosToolStripMenuItem.Enabled = False
                    Form12.ParámetrosToolStripMenuItem.Enabled = False
                    Form13.ParámetrosToolStripMenuItem.Enabled = False
                    Form14.ParámetrosToolStripMenuItem.Enabled = False
                    Form15.ParámetrosToolStripMenuItem.Enabled = False
                    Form16.ParámetrosToolStripMenuItem.Enabled = False
                    Form17.ParámetrosToolStripMenuItem.Enabled = False
                    Form18.ParámetrosToolStripMenuItem.Enabled = False
                    Form19.ParámetrosToolStripMenuItem.Enabled = False
                    Form20.ParámetrosToolStripMenuItem.Enabled = False
                    Form21.ParámetrosToolStripMenuItem.Enabled = False
                    Form22.ParámetrosToolStripMenuItem.Enabled = False
                    'Form23.NuevoUsuarioToolStripMenuItem.Enabled = False
                    Form24.ParámetrosToolStripMenuItem.Enabled = False
                    Form25.ParámetrosToolStripMenuItem.Enabled = False
                    'Form26.NuevoUsuarioToolStripMenuItem.Enabled = False
                    'Form27.NuevoUsuarioToolStripMenuItem.Enabled = False
                    '--------------------------------------------------------------
                    ''-------------No se modificar pagos en estas form
                    Form2.ModificarToolStripMenuItem1.Enabled = False
                    Form3.ModificarToolStripMenuItem1.Enabled = False
                    Form5.ModificarToolStripMenuItem1.Enabled = False
                    Form6.ModificarToolStripMenuItem1.Enabled = False
                    Form7.ModificarToolStripMenuItem1.Enabled = False
                    Form10.ModificarToolStripMenuItem1.Enabled = False
                    Form11.ModificarToolStripMenuItem1.Enabled = False
                    Form12.ModificarToolStripMenuItem1.Enabled = False
                    Form13.ModificarToolStripMenuItem1.Enabled = False
                    Form14.ModificarToolStripMenuItem1.Enabled = False
                    Form15.ModificarToolStripMenuItem1.Enabled = False
                    Form16.ModificarToolStripMenuItem1.Enabled = False
                    Form17.ModificarToolStripMenuItem1.Enabled = False
                    Form18.ModificarToolStripMenuItem1.Enabled = False
                    Form19.ModificarToolStripMenuItem1.Enabled = False
                    Form20.ModificarToolStripMenuItem1.Enabled = False
                    Form21.ModificarToolStripMenuItem1.Enabled = False
                    Form22.ModificarToolStripMenuItem1.Enabled = False
                    Form24.ModificarToolStripMenuItem1.Enabled = False
                    Form25.ModificarToolStripMenuItem1.Enabled = False

                ElseIf dr.Item(1) = "jefe" Or dr.Item(1) = "Jefe" Then
                    Form2.Show()
                    Form1.Hide()
                    Form24.BtnGuardar.Enabled = False

                ElseIf dr.Item(1) = "administrador" Or dr.Item(1) = "admin" Or dr.Item(1) = "Administrador" Or dr.Item(1) = "Admin" Then

                    Form2.Show()
                    Form1.Hide()

                End If

            Else
                MsgBox("Usuario no existe.", MsgBoxStyle.Critical, "¡Error de datos!")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub ActualizarRepresentante(ByVal cedulaRepresentanteModificar As String, ByVal nacion As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String
        cmd.CommandText = "Select * from representante where repre_cedul='" + cedulaRepresentanteModificar + "' and repre_nacio='" & nacion & "'; "
        'MsgBox(sql)
        'cmd.CommandType = sql
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Form16.Show()
                Form11.Close()
                Form16.Masktxtced.Text = dr.Item(1).ToString()
                Form16.txtRePriNom.Text = dr.Item(2).ToString()
                Form16.txtReSegNom.Text = dr.Item(3).ToString()
                Form16.txtRePriApell.Text = dr.Item(4).ToString()
                Form16.txtReSegApell.Text = dr.Item(5).ToString()
                If Form11.RdoVzl.Checked = True Then
                    Form16.RdoVzl.Checked = True
                ElseIf Form11.RdoExtr.Checked = True Then
                    Form16.RdoExtr.Checked = True
                End If
                Form16.DateTimePicker1.Value = dr.Item(6)
                Form16.txtLugNac.Text = dr.Item(8).ToString()
                Form16.txtDire.Text = dr.Item(9).ToString()
                Form16.cbParent.Text = dr.Item(10)
                Form16.MasktxtTeleHab.Text = dr.Item(11).ToString()
                Form16.MasktxtTeleMov.Text = dr.Item(12).ToString()
                Form16.txtcorreo.Text = dr.Item(13).ToString()

            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub ActualizarNiño(ByVal cedulaFichaNiñoCeduRepre As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        Dim cmd As New Odbc.OdbcCommand
        Dim cmd2 As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select count(*) as count_all, niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria from niño where repre_cedul='" & Form11.MasktxtModced.Text & "' group by  niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria;" 'select count(*) as count all, curso_nombr, curso_turno, curso_desde, curso_hasta from curso where niño_seria ='" & Form17.txtID.Text & "' and curso_seria ="
        'MsgBox(cmd.CommandText)
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Form17.Show()
                Form11.Hide()
                Form17.txtID.Text = dr.Item(12).ToString()
                Form17.txtPriNom.Text = dr.Item(1).ToString()
                Form17.txtSegNom.Text = dr.Item(2).ToString()
                Form17.txtPriApell.Text = dr.Item(3).ToString()
                Form17.txtSegApell.Text = dr.Item(4).ToString()
                If dr.Item(5) = "Masculino" Then
                    Form17.RdoMasculino.Checked = True
                ElseIf dr.Item(5) = "Femenino" Then
                    Form17.RdoFemenino.Checked = True
                End If
                Form17.txtEdad.Text = dr.Item(6)
                Form17.DateTimePicker1.Text = dr.GetValue(7)
                Form17.txtLuNacim.Text = dr.Item(8).ToString()
                Form17.txtDireccion.Text = dr.Item(9).ToString()
                Form17.TxtAlergEspe.Text = dr.Item(10).ToString()
                Form17.CbGsangui.Text = dr.Item(11).ToString()

            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Sub Perdida_Correo(ByVal Usu As String, ByVal Correo As String)
        Dim clave, asunto, usuario As String
        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String
        cmd.CommandText = "Select * from usuario where usuar_log='" + Usu + "' and usuar_ccorr='" + Correo + "'; "
        'MsgBox(sql)
        'cmd.CommandType = sql
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                usuario = dr.Item(0)
                clave = dr.Item(2)
                asunto = "Recuperacion de clave"
                Dim _Message As New System.Net.Mail.MailMessage()
                Dim _SMTP As New System.Net.Mail.SmtpClient

                'CONFIGURACIÓN DEL STMP
                '_SMTP.Credentials = New System.Net.NetworkCredential("cuenta de correo", "contraseña")
                _SMTP.Credentials = New System.Net.NetworkCredential("GuarderiaDulceAmor@gmail.com", "Guarderia")
                _SMTP.Host = "smtp.gmail.com"
                _SMTP.Port = 587
                _SMTP.EnableSsl = True

                ' CONFIGURACION DEL MENSAJE
                _Message.[To].Add(Form4.txtCorreo.Text.ToString) 'Cuenta de Correo al que se le quiere enviar el e-mail
                _Message.From = New System.Net.Mail.MailAddress("GuarderiaDulceAmor@gmail.com", "Guarderia Dulce Amor", System.Text.Encoding.UTF8) 'Quien lo envía
                _Message.Subject = asunto.ToString 'Sujeto del e-mail
                _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
                _Message.Body = ("Usuario: " + usuario.ToString + vbCr + "Clave: " + clave.ToString) 'contenido del mail
                ''_Message.Body = Me.txtMensaje.Text.ToString 'contenido del mail
                _Message.BodyEncoding = System.Text.Encoding.UTF8
                _Message.Priority = System.Net.Mail.MailPriority.Normal
                _Message.IsBodyHtml = False

                'ENVIO
                Try
                    _SMTP.Send(_Message)
                    MessageBox.Show("Mensaje enviado correctamene", "Exito!", MessageBoxButtons.OK)
                    Form1.Show()
                    Form4.Close()
                Catch ex As System.Net.Mail.SmtpException
                    MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
                End Try

            Else
                MsgBox("Usuario o correo incorrecto.", MsgBoxStyle.Critical, "¡Error de datos!")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub Inscripcion()

        Dim fecha, id_niño, cedul_repre, id_curso, hora, usuario, ced As String

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()
        ced = Form5.Masktxtced.Text
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String
        cmd.CommandText = "SELECT niño.niño_seria, curso.curso_seria, representante.repre_cedul, niño.repre_cedul FROM representante INNER JOIN niño ON representante.repre_cedul = niño.repre_cedul INNER JOIN curso ON curso.curso_seria = niño.niño_seria where representante.repre_cedul= '" & ced & "';"
        'MsgBox(sql)
        'cmd.CommandType = sql
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                fecha = DateTime.Now().ToShortDateString()
                hora = DateTime.Now().ToShortTimeString()
                usuario = Form1.TxtUsuario.Text
                id_niño = dr.Item(0)
                id_curso = dr.Item(1)
                cedul_repre = dr.Item(2)
                Cargar_Datos("INSERT INTO inscripcion(inscr_seria, inscr_fecha, niño_seria, curso_id, repre_cedul, usuar_log) values (nextval('inscripcion_inscr_seria_seq'), '" & fecha.ToString & "', '" & id_niño & "', '" & id_curso & "', '" & cedul_repre & "', '" & usuario & "');")
                'cmd.CommandText = "INSERT INTO inscripcion(inscr_seria, inscr_fecha, niño_seria, curso_id, repre_cedul, usuar_log) values (nextval('inscripcion_inscr_seria_seq'), '" & fecha.ToString & "', '" & id_niño & "', '" & id_curso & "', '" & cedul_repre & "', '" & usuario & "')"

            Else
                MsgBox("Usuario o correo incorrecto.", MsgBoxStyle.Critical, "¡Error de datos!")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub EliminarNiño(ByVal cedulaFichaNiñoCeduRepre As String)

        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        Dim cmd As New Odbc.OdbcCommand
        Dim cmd2 As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select count(*) as count_all, niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria from niño where repre_cedul='" & Form12.MaskedTextBox1.Text & "' group by  niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria;"

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Form19.Show()
                Form12.Hide()
                Form19.txtID.Text = dr.Item(12).ToString()
                Form19.txtPriNom.Text = dr.Item(1).ToString()
                Form19.txtSegNom.Text = dr.Item(2).ToString()
                Form19.txtPriApell.Text = dr.Item(3).ToString()
                Form19.txtSegApell.Text = dr.Item(4).ToString()
                If dr.Item(5) = "Masculino" Then
                    Form19.RdoMasculino.Checked = True
                ElseIf dr.Item(5) = "Femenino" Then
                    Form19.RdoFemenino.Checked = True
                End If
                Form19.txtEdad.Text = dr.Item(6)
                Form19.DateTimePicker1.Text = dr.GetValue(7)
                Form19.txtLuNacim.Text = dr.Item(8).ToString()
                Form19.txtDireccion.Text = dr.Item(9).ToString()
                Form19.TxtAlergEspe.Text = dr.Item(10).ToString()
                Form19.CbGsangui.Text = dr.Item(11).ToString()

            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Sub ConsultarNiño(ByVal cedulaFichaNiñoCeduRepre As String)


        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select count(*) as count_all, niño.repre_cedul, niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria from niño where repre_cedul='" & Form20.MaskedTxtCed.Text & "' group by  niño.repre_cedul, niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria;"
        'cedulaFichaNiñoCeduRepre = Form20.MaskedTxtCed.Text

        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Form20.MaskedTxtCed.Text = dr.Item(1).ToString()
                Form20.LblPriNomNiño.Text = dr.Item(2).ToString()
                Form20.LblSegNomNiño.Text = dr.Item(3).ToString()
                Form20.LblPriApeNiño.Text = dr.Item(4).ToString()
                Form20.LblSegApeNiño.Text = dr.Item(5).ToString()
                If Form20.RdoVzla.Checked = True Then
                    Form20.RdoVzla.Checked = True
                ElseIf Form20.RdoExtr.Checked = True Then
                    Form20.RdoExtr.Checked = True
                End If
                If dr.Item(6) = "Masculino" Then
                    Form20.rdoMasculino.Checked = True
                ElseIf dr.Item(6) = "Femenino" Then
                    Form20.rdoFemenino.Checked = True
                End If
                Form20.LblFecNaci.Text = dr.Item(8).ToString()
                Form20.LblEdad.Text = dr.Item(7).ToString()
                Form20.LblLugNaci.Text = dr.Item(9).ToString()
                Form20.LblDire.Text = dr.Item(10).ToString()
                Form20.LblGruSang.Text = dr.Item(12).ToString()
                Form20.LblAlerg.Text = dr.Item(11).ToString()
            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module