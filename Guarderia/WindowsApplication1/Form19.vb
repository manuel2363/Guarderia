﻿Public Class Form19
    Dim Parentescos, sanguineo, sexo, cedulaFichaNiñoCeduRepre As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form12.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Cargar_Datos("Delete from niño where repre_cedul ='" & Form18.Masktxtced.Text & "' and niño_seria='" & Me.txtID.Text & "'")
        MsgBox("Registro " & Me.txtID.Text & " eliminado.")
        'Cargar_Datos("update curso set curso_nombr='" & CbNivel.Text & "', curso_turno='" & CbTurno.Text & "', curso_desde='" & TxtDesde.Text & "', curso_hasta='" & TxtHasta.Text & "' where repre_serfk= '" & Form11.MasktxtModced.Text & "'")
        'MessageBox.Show("Registro Eliminado")
        cedulaFichaNiñoCeduRepre = Form12.cedulaFichaNiñoCeduRepre.ToString()
        EliminarNiño(cedulaFichaNiñoCeduRepre)
        Form2.Show()
        Me.Hide()
        'Form2.Show()
        'Me.Close()
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

    Private Sub CargoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargoToolStripMenuItem.Click
        Form13.Show()
        Me.Close()
    End Sub

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem2.Click
        Form20.Show()
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

    Private Sub cbSanguineo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CbGsangui.Text = "A+" Then
            sanguineo = "A+"
        ElseIf CbGsangui.Text = "A-" Then
            sanguineo = "A-"
        ElseIf CbGsangui.Text = "B+" Then
            sanguineo = "B+"
        ElseIf CbGsangui.Text = "B-" Then
            sanguineo = "B-"
        ElseIf CbGsangui.Text = "AB+" Then
            sanguineo = "AB+"
        ElseIf CbGsangui.Text = "AB-" Then
            sanguineo = "AB-"
        ElseIf CbGsangui.Text = "O+" Then
            sanguineo = "O+"
        ElseIf CbGsangui.Text = "O-" Then
            sanguineo = "O-"
        End If
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Form24.Show()
        Me.Close()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Form25.Show()
        Me.Close()
    End Sub

    Private Sub RdoMasculino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoMasculino.CheckedChanged
        If RdoMasculino.Checked = True Then
            sexo = "Masculino"
        ElseIf RdoFemenino.Checked = True Then
            sexo = "Femenino"
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
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

            While dr.Read()
                Me.txtPriNom.Text = dr.Item(1).ToString()
                Me.txtSegNom.Text = dr.Item(2).ToString()
                Me.txtPriApell.Text = dr.Item(3).ToString()
                Me.txtSegApell.Text = dr.Item(4).ToString()
                If dr.Item(5) = "Masculino" Then
                    Me.RdoMasculino.Checked = True
                ElseIf dr.Item(5) = "Femenino" Then
                    Me.RdoFemenino.Checked = True
                End If
                Me.txtEdad.Text = dr.Item(6)
                Me.DateTimePicker1.Text = dr.GetValue(7)
                Me.txtLuNacim.Text = dr.Item(8).ToString()
                Me.txtDireccion.Text = dr.Item(9).ToString()
                Me.TxtAlergEspe.Text = dr.Item(10).ToString()
                Me.CbGsangui.Text = dr.Item(11).ToString()
                Me.txtID.Text = dr.Item(12).ToString()


            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class