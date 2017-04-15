Public Class Form6
    Dim nacionalidad, status As String

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
        btnGuardar.Enabled = False
        RdoVzl.Checked = True
        NuevoUsuarioToolStripMenuItem.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoVzl.CheckedChanged
        If RdoVzl.Checked = True Then
            nacionalidad = "V-"
        ElseIf RdoExtr.Checked = True Then
            nacionalidad = "E-"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        status = "Activo"
        Cargar_Datos("INSERT into representante (repre_nomb1, repre_nomb2, repre_apel1, repre_apel2, repre_cedul, repre_corre, repre_nacio, repre_direc, repre_tehab, repre_temov) VALUES('" & txtPriNombre.Text & "', '" & txtSegNombre.Text & "', '" & txtPriApellido.Text & "', '" & txtSegApellido.Text & "', '" & MaskedTxtCed.Text & "','" & TxtConfirmCorreo.Text & "', '" & nacionalidad & "', '" & TxtDire.Text & "', '" & MaskedTxtTelHab.Text & "', '" & MaskedTxtTelMovil.Text & "');")
        Cargar_Datos("INSERT into usuario (usuar_log, usuar_clave,usuar_cedul,usuar_ccorr, usuar_satus,usuar_permi) VALUES ('" & txtNombreUsuario.Text & "','" & txtConfirmClave.Text & "', '" & MaskedTxtCed.Text & "', '" & TxtConfirmCorreo.Text & "', '" & status & "', '" & CbPermi.Text & "');")
        MessageBox.Show("Usuario Registrado")
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub CambioDeContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub CambioDeContraseñaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeContraseñaToolStripMenuItem.Click
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
        Me.Hide()
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

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtConfirmCorreo.TextChanged
        If TxtConfirmCorreo.Text = "" Then
            lbConfirm.Text = ""
            btnGuardar.Enabled = False
        ElseIf TxtConfirmCorreo.Text = txtCorreo.Text Then
            btnGuardar.Enabled = True
            lbConfirm.Text = ""
        ElseIf TxtConfirmCorreo.Text <> txtCorreo.Text Then
            lbConfirm.Text = "Correo no coincide."
            btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub txtConfirmClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmClave.TextChanged
        If txtConfirmClave.Text = "" Then
            lbConfirmClave.Text = ""
        ElseIf txtConfirmClave.Text = txtClave.Text Then
            lbConfirmClave.Text = ""
        ElseIf txtConfirmClave.Text <> txtClave.Text Then
            lbConfirmClave.Text = "Clave no coincide."
        End If
    End Sub

    Private Sub ParámetrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParámetrosToolStripMenuItem.Click

    End Sub
End Class