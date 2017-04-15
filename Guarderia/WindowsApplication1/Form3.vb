Public Class Form3
    Dim sexo, nivel, turno As String

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
        RdoMasculino.Checked = True
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.TxtUsuario.Text = ""
        Form1.TxtContra.Text = ""
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try
            Cargar_Datos("INSERT into niño (niño_seria, niño_nomb1, niño_nomb2, niño_apel1, niño_apel2, niño_sexo, niño_fnaci, niño_lnaci, niño_direc, niño_alerg, niño_gsang, niño_edad, repre_cedul) VALUES(nextval('niño_niño_seria_seq'), '" & txtPriNom.Text & "','" & txtSegNom.Text & "','" & txtPriApell.Text & "','" & txtSegApell.Text & "','" & sexo.ToString() & "','" & DateTimePicker1.Value & "','" & txtLuNacim.Text & "','" & txtDireccion.Text & "','" & TxtAlergEspe.Text & "','" & CbGsangui.Text & "', '" & txtEdad.Text & "', '" & Form5.Masktxtced.Text & "')")
            Cargar_Datos("INSERT into curso (curso_seria, curso_nombr, curso_turno, curso_desde, curso_hasta) VALUES(nextval('curso_curso_seria_seq'), '" & CbNivel.Text & "','" & turno.ToString() & "','" & TxtDesde.Text & "','" & TxtHasta.Text & "')")
            'Cargar_Datos("INSERT into inscripcion (inscr_seria,inscr_fecha, niño_seria) values (nextval('inscripcion_inscr_seria_seq'), '" & FechaHoy.Value.TimeOfDay.ToString & "')")
            MessageBox.Show("Niño Registrado.", "¡Registro exitoso!", MessageBoxButtons.OK, MessageBoxIcon.None)
            Inscripcion()
            Form26.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub CambioDeContrasseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub CambioDeContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeContraseñaToolStripMenuItem.Click
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.TxtUsuario.Text = ""
        Form1.TxtContra.Text = ""
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Form1.Close()
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

    Private Sub NuevoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem1.Click
        Form14.Show()
        Me.Close()
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

    Private Sub ModificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem1.Click
        Form15.Show()
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

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoMasculino.CheckedChanged
        If RdoMasculino.Checked = True Then
            sexo = "Masculino"
        ElseIf RdoFemenino.Checked = True Then
            sexo = "Femenino"
        End If
    End Sub

    Private Sub CbGsangui_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbGsangui.SelectedIndexChanged
        If CbGsangui.Text = "" Or CbGsangui.Text = "Elija una opción" Then
            btnGuardar.Enabled = False
        ElseIf CbGsangui.Text = "A+" Then
            CbGsangui.Text = "A+"
            btnGuardar.Enabled = True
        ElseIf CbGsangui.Text = "A-" Then
            CbGsangui.Text = "A-"
            btnGuardar.Enabled = True
        ElseIf CbGsangui.Text = "B+" Then
            CbGsangui.Text = "B+"
            btnGuardar.Enabled = True
        ElseIf CbGsangui.Text = "B-" Then
            CbGsangui.Text = "B-"
            btnGuardar.Enabled = True
        ElseIf CbGsangui.Text = "AB+" Then
            CbGsangui.Text = "AB+"
            btnGuardar.Enabled = True
        ElseIf CbGsangui.Text = "AB-" Then
            CbGsangui.Text = "AB-"
            btnGuardar.Enabled = True
        ElseIf CbGsangui.Text = "O+" Then
            CbGsangui.Text = "O+"
            btnGuardar.Enabled = True
        ElseIf CbGsangui.Text = "O-" Then
            CbGsangui.Text = "O-"
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub CbNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbNivel.SelectedIndexChanged
        If CbNivel.Text = "" Or CbNivel.Text = "Elija una opción" Then
            btnGuardar.Enabled = False
        ElseIf CbNivel.Text = "Lactante(0 - 1)" Then
            CbNivel.Text = "Lactante(0 - 1)"
            btnGuardar.Enabled = True
        ElseIf CbNivel.Text = "Maternal(A(1 - 2))" Then
            nivel = "Maternal(A(1 - 2))"
            btnGuardar.Enabled = True
        ElseIf CbGsangui.Text = "Maternal(B(2 - 3))" Then
            nivel = "Maternal(B(2 - 3))"
            btnGuardar.Enabled = True
        ElseIf CbNivel.Text = "Maternal(C(3 - 4))" Then
            nivel = "Maternal(C(3 - 4))"
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub CbTurno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTurno.SelectedIndexChanged
        If CbTurno.Text = "" Or CbTurno.Text = "Elija una opción" Then
            btnGuardar.Enabled = False
        ElseIf CbTurno.Text = "Mañana" Then
            turno = "Mañana"
            btnGuardar.Enabled = True
        ElseIf CbTurno.Text = "Tarde" Then
            turno = "Tarde"
            btnGuardar.Enabled = True
        End If
    End Sub

  
End Class