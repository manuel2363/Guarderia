Public Class Form18
    Dim Parentescos, nacionalidadEliminar As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Form12.RdoNacionExtran.Checked = True Then
            Form12.RdoNacionExtran.Checked = False
        ElseIf Form12.RdoNacionVzla.Checked = True Then
            Form12.RdoNacionVzla.Checked = False
        End If

        If Form12.MaskedTextBox1.Text <> "" Then
            Form12.MaskedTextBox1.Text = ""
        End If
        Form12.Show()
        Me.Close()

    End Sub

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Top = Form1.Top
        Me.Left = Form1.Left
        txtEspeci.Enabled = False
        ConexionPostgres.Open()
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

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Try

            Cargar_Datos("Delete from representante where repre_cedul ='" & Masktxtced.Text & "' and repre_nacio='" & nacionalidadEliminar & "'")
            MsgBox("representante " & TxtRePriNom.Text & " eliminado.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Form2.Show()
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

    Private Sub cbParentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbParent.SelectedIndexChanged
        If cbParent.Text = "Padre" Then
            txtEspeci.Enabled = False
            Parentescos = "Padre"
        ElseIf cbParent.Text = "Madre" Then
            txtEspeci.Enabled = False
            Parentescos = "Madre"
        ElseIf cbParent.Text = "Hermano" Then
            txtEspeci.Enabled = False
            Parentescos = "Hermano"
        ElseIf cbParent.Text = "Hermana" Then
            txtEspeci.Enabled = False
            Parentescos = "Hermana"
        ElseIf cbParent.Text = "Tío" Then
            txtEspeci.Enabled = False
            Parentescos = "Tío"
        ElseIf cbParent.Text = "Tía" Then
            txtEspeci.Enabled = False
            Parentescos = "Tía"
        ElseIf cbParent.Text = "Abuelo" Then
            txtEspeci.Enabled = False
            Parentescos = "Abuelo"
        ElseIf cbParent.Text = "Abuela" Then
            txtEspeci.Enabled = False
            Parentescos = "Abuela"
        ElseIf cbParent.Text = "Otro" Then
            txtEspeci.Enabled = True
            Parentescos = txtEspeci.Text
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

    Private Sub RdoVzl_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdoVzl.CheckedChanged
        If RdoVzl.Checked = True Then
            nacionalidadEliminar = "V-"
        ElseIf RdoExtr.Checked = True Then
            nacionalidadEliminar = "E-"
        End If
    End Sub
End Class