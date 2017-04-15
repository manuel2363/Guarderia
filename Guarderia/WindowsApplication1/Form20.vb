Public Class Form20
    Dim Parentesco, sexo, cedulaFichaNiñoCeduRepre, nacionalidad As String

    Private Sub Form20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.TxtUsuario.Text = ""
        Form1.TxtContra.Text = ""
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click

        Form1.Close()
        Me.Close()
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub CambioDeContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeContraseñaToolStripMenuItem.Click
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem1.Click
        Form14.Show()
        Me.Close()
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem1.Click
        Form15.Show()
        Me.Close()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Form12.Show()
        Me.Close()
    End Sub

    Private Sub CargoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargoToolStripMenuItem.Click
        Form13.Show()
        Me.Close()
    End Sub

    Private Sub FichaDelRepresentanteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichaDelRepresentanteToolStripMenuItem.Click
        Form21.Show()
        Me.Close()
    End Sub

    Private Sub FichaDePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichaDePagoToolStripMenuItem.Click
        Form22.Show()
        Me.Close()
    End Sub

    Private Sub AcercaDeLaGuarderíaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeLaGuarderíaToolStripMenuItem.Click
        Form23.Show()
        Me.Close()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Form24.Show()
        Me.Close()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Form25.Show()
        Me.Close()
    End Sub

    Private Sub rdoMasculino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoMasculino.CheckedChanged
        If rdoMasculino.Checked = True Then
            sexo = "Masculino"
        ElseIf rdoFemenino.Checked = True Then
            sexo = "Femenino"
        End If
    End Sub

    Private Sub BtnRepre_Click(sender As System.Object, e As System.EventArgs) Handles BtnRepre.Click

        cedulaFichaNiñoCeduRepre = MaskedTxtCed.Text
        ConsultarNiño(cedulaFichaNiñoCeduRepre)
        'Dim cmd As New Odbc.OdbcCommand
        'cmd.Connection = ConexionPostgres
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "select count(*) as count_all, niño.repre_cedul, niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria from niño where repre_cedul='" & Me.MaskedTxtCed.Text & "' group by  niño.repre_cedul, niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria;"
        'cedula = Me.MaskedTxtCed.Text

        'Try
        '    dr = cmd.ExecuteReader
        '    If dr.HasRows Then

        '        Me.MaskedTxtCed.Text = dr.Item(1).ToString()
        '        Me.LblPriNomNiño.Text = dr.Item(2).ToString()
        '        Me.LblSegNomNiño.Text = dr.Item(3).ToString()
        '        Me.LblPriApeNiño.Text = dr.Item(4).ToString()
        '        Me.LblSegApeNiño.Text = dr.Item(5).ToString()
        '        If Me.RdoVzla.Checked = True Then
        '            Me.RdoVzla.Checked = True
        '        ElseIf Me.RdoExtr.Checked = True Then
        '            Me.RdoExtr.Checked = True
        '        End If
        '        If dr.Item(6) = "Masculino" Then
        '            Me.rdoMasculino.Checked = True
        '        ElseIf dr.Item(6) = "Femenino" Then
        '            Me.rdoFemenino.Checked = True
        '        End If
        '        Me.LblFecNaci.Text = dr.Item(8).ToString()
        '        Me.LblEdad.Text = dr.Item(7).ToString()
        '        Me.LblLugNaci.Text = dr.Item(9).ToString()
        '        Me.LblDire.Text = dr.Item(10).ToString()
        '        Me.LblGruSang.Text = dr.Item(12).ToString()
        '        Me.LblAlerg.Text = dr.Item(11).ToString()
        '    Else
        '        MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub

    Private Sub RdoVzla_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdoVzla.CheckedChanged
        If RdoVzla.Checked = True Then
            nacionalidad = "V-"
        ElseIf RdoExtr.Checked = True Then
            nacionalidad = "E-"
        End If
    End Sub

    Private Sub BtnSigui_Click(sender As System.Object, e As System.EventArgs) Handles BtnSigui.Click
        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open()

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select count(*) as count_all, niño.repre_cedul, niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria from niño where repre_cedul='" & MaskedTxtCed.Text & "' group by  niño.repre_cedul, niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_edad, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_seria;"

        Try
            dr = cmd.ExecuteReader

            While dr.Read()

                Me.MaskedTxtCed.Text = dr.Item(1).ToString()
                Me.LblPriNomNiño.Text = dr.Item(2).ToString()
                Me.LblSegNomNiño.Text = dr.Item(3).ToString()
                Me.LblPriApeNiño.Text = dr.Item(4).ToString()
                Me.LblSegApeNiño.Text = dr.Item(5).ToString()
                If Me.RdoVzla.Checked = True Then
                    Me.RdoVzla.Checked = True
                ElseIf Me.RdoExtr.Checked = True Then
                    Me.RdoExtr.Checked = True
                End If
                If dr.Item(6) = "Masculino" Then
                    Me.rdoMasculino.Checked = True
                ElseIf dr.Item(6) = "Femenino" Then
                    Me.rdoFemenino.Checked = True
                End If
                Me.LblFecNaci.Text = dr.Item(8).ToString()
                Me.LblEdad.Text = dr.Item(7).ToString()
                Me.LblLugNaci.Text = dr.Item(9).ToString()
                Me.LblDire.Text = dr.Item(10).ToString()
                Me.LblGruSang.Text = dr.Item(12).ToString()
                Me.LblAlerg.Text = dr.Item(11).ToString()
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class