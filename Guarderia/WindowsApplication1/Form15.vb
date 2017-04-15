Public Class Form15
    Dim nacionalidad, cedula, mespagado As String

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cedula = MaskedTxtCed.Text

        Try
            Cargar_Datos("Update pagos set pagos_monti ='" & MaskedTxtMonInscr.Text & "', pagos_mesap ='" & CbMesAPagar.Text & "', pagos_mtota = '" & MaskedTxtMontoTotal.Text & "', pagos_mespa='" & TxtMesDePago.Text & "' where repre_cedul= '" & cedula & "' ")
            Cargar_Datos("Update representante set repre_nomb1='" & TxtNomRepre.Text & "', repre_cedul= '" & MaskedTxtCed.Text & "', repre_nacio= '" & nacionalidad & "' where repre_cedul ='" & cedula & "' ")
            MessageBox.Show("Cambio exitoso", "¡Cambio exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Form24.Show()
        Me.Close()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Form25.Show()
        Me.Close()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Form1.TxtUsuario.Text = ""
        Form1.TxtContra.Text = ""
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BtnEmpleado_Click(sender As System.Object, e As System.EventArgs) Handles BtnEmpleado.Click
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "Select * from representante where repre_cedul='" + Masktxtced.Text + "'; "
        cmd.CommandText = "SELECT * FROM representante CROSS JOIN pagos where representante.repre_cedul='" + MaskedTxtCed.Text + "' and representante.repre_nacio='" & nacionalidad & "';"
        cedula = MaskedTxtCed.Text
        mespagado = TxtMesDePago.Text
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Me.MaskedTxtCed.Text = dr.Item(1).ToString()
                Me.TxtNomRepre.Text = dr.Item(2).ToString()
                If Me.RdoVzla.Checked = True Then
                    Form18.RdoVzl.Checked = True
                ElseIf Me.RdoExtr.Checked = True Then
                    Form18.RdoExtr.Checked = True
                End If
                Me.MaskedTxtMonInscr.Text = dr.Item(17).ToString()
                Me.CbMesAPagar.Text = dr.Item(18).ToString()
                Me.MaskedTxtMontoTotal.Text = dr.Item(19).ToString()
                Me.TxtMesDePago.Text = dr.Item(20).ToString()
            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub RdoVzla_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdoVzla.CheckedChanged
        If RdoVzla.Checked = True Then
            nacionalidad = "V-"
        ElseIf RdoExtr.Checked = True Then
            nacionalidad = "E-"
        End If
    End Sub
   
End Class