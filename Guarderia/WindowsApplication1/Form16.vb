Public Class Form16
    Public Parentesco, cedulaFichaNiñoCeduRepre, nacionalidad, nacion As String
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form11.Show()
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

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
        TxtEspeci.Enabled = False
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

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Form12.Show()
        Me.Close()
    End Sub

    Private Sub CargoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargoToolStripMenuItem.Click
        Form13.Show()
        Me.Close()
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem1.Click
        Form15.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Cargar_Datos("update representante set repre_cedul ='" & Masktxtced.Text & "', repre_nomb1='" & txtRePriNom.Text & "', repre_nomb2='" & txtReSegNom.Text & "', repre_apel1='" & txtRePriApell.Text & "', repre_apel2='" & txtReSegApell.Text & "', repre_fnaci='" & DateTimePicker1.Value & "', repre_nacio='" & nacionalidad & "', repre_lnaci='" & txtLugNac.Text & "', repre_direc='" & txtDire.Text & "', repre_paren='" & cbParent.Text & "', repre_tehab='" & MasktxtTeleHab.Text & "', repre_temov='" & MasktxtTeleMov.Text & "', repre_corre='" & txtcorreo.Text & "' where repre_cedul= '" & Masktxtced.Text & "'")
        MessageBox.Show("Actualización exitosa.", "¡Actualización exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'cedulaFichaNiñoCeduRepre = Masktxtced.Text
        Form2.Show()
        Me.Close()



    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem2.Click
        Form20.Show()
        Me.Close()
    End Sub

    Private Sub FichaDelRepresentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichaDelRepresentaToolStripMenuItem.Click
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

    Private Sub cbParent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbParent.SelectedIndexChanged
        If cbParent.Text = "Padre" Then
            TxtEspeci.Enabled = False
            Parentesco = "Padre"
        ElseIf cbParent.Text = "Madre" Then
            TxtEspeci.Enabled = False
            Parentesco = "Madre"
        ElseIf cbParent.Text = "Hermano" Then
            TxtEspeci.Enabled = False
            Parentesco = "Hermano"
        ElseIf cbParent.Text = "Hermana" Then
            TxtEspeci.Enabled = False
            Parentesco = "Hermana"
        ElseIf cbParent.Text = "Tío" Then
            TxtEspeci.Enabled = False
            Parentesco = "Tío"
        ElseIf cbParent.Text = "Tía" Then
            TxtEspeci.Enabled = False
            Parentesco = "Tía"
        ElseIf cbParent.Text = "Abuelo" Then
            TxtEspeci.Enabled = False
            Parentesco = "Abuelo"
        ElseIf cbParent.Text = "Abuela" Then
            TxtEspeci.Enabled = False
            Parentesco = "Abuela"
        ElseIf cbParent.Text = "Otro" Then
            TxtEspeci.Enabled = True
            Parentesco = TxtEspeci.Text
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

    Private Sub RdoVzl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoVzl.CheckedChanged
        If RdoVzl.Checked = True Then
            nacionalidad = "V-"
        ElseIf RdoExtr.Checked = True Then
            nacionalidad = "E-"
        End If
    End Sub
End Class