Public Class Form5
    Public Parentesco, nacionalidad As String

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
        txtOtro.Enabled = False
        RdoVzl.Checked = True
        NuevoToolStripMenuItem.Enabled = False
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoVzl.CheckedChanged
        If RdoVzl.Checked = True Then
            nacionalidad = "V-"
        ElseIf RdoExtr.Checked = True Then
            nacionalidad = "E-"
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbParen.SelectedIndexChanged
      If CbParen.Text = "Madre" Then
            txtOtro.Enabled = False
            Parentesco = "Madre"
        ElseIf CbParen.Text = "Padre" Then
            txtOtro.Enabled = False
            Parentesco = "Padre"
        ElseIf CbParen.Text = "Hermano" Then
            txtOtro.Enabled = False
            Parentesco = "Hermano"
        ElseIf CbParen.Text = "Hermana" Then
            txtOtro.Enabled = False
            Parentesco = "Hermana"
        ElseIf CbParen.Text = "Tío" Then
            txtOtro.Enabled = False
            Parentesco = "Tío"
        ElseIf CbParen.Text = "Tía" Then
            txtOtro.Enabled = False
            Parentesco = "Tía"
        ElseIf CbParen.Text = "Abuelo" Then
            txtOtro.Enabled = False
            Parentesco = "Abuelo"
        ElseIf CbParen.Text = "Abuela" Then
            txtOtro.Enabled = False
            Parentesco = "Abuela"
        ElseIf CbParen.Text = "Otro" Then
            txtOtro.Enabled = True
            Parentesco = txtOtro.Text
        Else : CbParen.Text = txtOtro.Text
            txtOtro.Text = True
            Parentesco = CbParen.Text
        End If
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Cargar_Datos("INSERT into representante ( repre_cedul, repre_nomb1, repre_nomb2, repre_apel1, repre_apel2, repre_nacio, repre_fnaci, repre_lnaci, repre_direc, repre_paren, repre_tehab, repre_temov, repre_corre) VALUES('" & Masktxtced.Text & "','" & txtRePriNom.Text & "','" & txtReSegNom.Text & "','" & txtRePriApell.Text & "','" & txtReSegApell.Text & "','" & nacionalidad & "','" & DateTimePicker1.Value & "','" & txtLugnaci.Text & "','" & txtDire.Text & "','" & Parentesco & "','" & MasktxtTlfHab.Text & "', '" & MasktxtTlfMovil.Text & "', '" & txtCorreo.Text & "');")
            Form3.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message + "", "¡Ocurrio el siguiente Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


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

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Form24.Show()
        Me.Close()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Form25.Show()
        Me.Close()
    End Sub
End Class