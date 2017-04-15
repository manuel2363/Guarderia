Public Class Form12
    Public nacionalidadEliminar, cedulaFichaNiñoCeduRepre As String

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
        RdoNacionVzla.Checked = True
        'ConexionPostgres.Open()
    End Sub

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Form6.Show()
        Me.Close()

    End Sub

    Private Sub CambioDeContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeContraseñaToolStripMenuItem.Click
        Form10.Show()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'Dim sql As String
        cmd.CommandText = "Select * from representante where repre_cedul='" + MaskedTextBox1.Text + "' and repre_nacio='" & nacionalidadEliminar & "' ; "
        'MsgBox(sql)
        'cmd.CommandType = sql
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                'Form16.Show()
                'Form11.Hide()
                Form18.Masktxtced.Text = dr.Item(1).ToString()
                Form18.TxtRePriNom.Text = dr.Item(2).ToString()
                Form18.TxtReSegNom.Text = dr.Item(3).ToString()
                Form18.TxtRePriApell.Text = dr.Item(4).ToString()
                Form18.TxtReSegApell.Text = dr.Item(5).ToString()
                If Me.RdoNacionVzla.Checked = True Then
                    Form18.RdoVzl.Checked = True
                ElseIf Me.RdoNacionExtran.Checked = True Then
                    Form18.RdoExtr.Checked = True
                End If
                Form18.DateTimePicker1.Value = dr.Item(6)
                Form18.txtLugNac.Text = dr.Item(8).ToString()
                Form18.txtDire.Text = dr.Item(9).ToString()
                Form18.cbParent.Text = dr.Item(10)
                Form18.MasktxtTeleHab.Text = dr.Item(11).ToString()
                Form18.MasktxtTeleMov.Text = dr.Item(12).ToString()
                Form18.txtcorreo.Text = dr.Item(13).ToString()

                Form18.Show()
                Me.Hide()
            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
        
        'Cargar_Datos("Delete from representante where repre_cedul ='" & MaskedTextBox1.Text & "' and repre_nacio='" & nacionalidadEliminar & "'")
        'MsgBox("representante " & MaskedTextBox1.Text & " eliminado.")

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

    Private Sub RdoNacionVzla_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoNacionVzla.CheckedChanged
        If RdoNacionVzla.Checked = True Then
            nacionalidadEliminar = "V-"
        ElseIf RdoNacionExtran.Checked = True Then
            nacionalidadEliminar = "E-"
        End If
    End Sub

    Private Sub BtnSigui_Click(sender As System.Object, e As System.EventArgs) Handles BtnSigui.Click

        If MaskedTextBox1.Text = "" Then
            MsgBox("Por favor ingrese sus datos en todos los campos")
        Else
            cedulaFichaNiñoCeduRepre = MaskedTextBox1.Text
            EliminarNiño(cedulaFichaNiñoCeduRepre)
        End If

    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class