Public Class Form7
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
        Button2.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CbRegistro.Text = "" Or CbRegistro.Text = "Elija una opción" Then

        ElseIf CbRegistro.Text = "Madre" Then
            Form5.Show()
            Me.Hide()

        ElseIf CbRegistro.Text = "Padre" Then
            Form5.Show()
            Me.Hide()

        ElseIf CbRegistro.Text = "Otro representante" Then
            Form5.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form6.Show()
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

    Private Sub NuevoUsuarioToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Form6.Show()
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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbRegistro.SelectedIndexChanged
        If CbRegistro.Text = "" Or CbRegistro.Text = "Elija una opción" Then
            Button2.Enabled = False
        ElseIf CbRegistro.Text = "Madre" Then
            Form5.CbParen.Text = Me.CbRegistro.Text
            Button2.Enabled = True
        End If
        If CbRegistro.Text = "Padre" Then
            Form5.CbParen.Text = Me.CbRegistro.Text
            Button2.Enabled = True
        End If
        If CbRegistro.Text = "Otro representante" Then
            Form5.CbParen.Text = " "
            Button2.Enabled = True
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

End Class