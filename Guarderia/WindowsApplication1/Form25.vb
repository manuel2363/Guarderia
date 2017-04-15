Public Class Form25

    Dim nacionalidad, cedula As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub CargoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargoToolStripMenuItem.Click
        Form13.Show()
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

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Form24.Show()
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

    Private Sub NuevoUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub CambioDeContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambioDeContraseñaToolStripMenuItem.Click
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub AcercaDeLaGuarderíaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeLaGuarderíaToolStripMenuItem.Click
        Form23.Show()
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

    Private Sub Form25_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
        BtnActuEmple.Enabled = False

    End Sub

    Private Sub BtnEmpleado_Click(sender As System.Object, e As System.EventArgs) Handles BtnEmpleado.Click
        If MaskedTextBox1.Text = "" Then
            MaskedTextBox1.Text = ""
            MessageBox.Show("Por favor introduzca la cédula para iniciar la búsqueda", "Llene todos los campos", MessageBoxButtons.OK)
        End If

        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "Select * from representante where repre_cedul='" + Masktxtced.Text + "'; "
        cmd.CommandText = "SELECT * FROM representante CROSS JOIN usuario where repre_cedul='" + MaskedTextBox1.Text + "';"
        cedula = MaskedTextBox1.Text
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Me.MaskedTextBox1.Text = dr.Item(1).ToString()
                Me.TxtEmplePriNomb.Text = dr.Item(2).ToString()
                Me.TxtEmpleSegNom.Text = dr.Item(3).ToString()
                Me.TxtEmplePriApel.Text = dr.Item(4).ToString()
                Me.TxtEmpleSegApel.Text = dr.Item(5).ToString()
                If Me.RdoVzl.Checked = True Then
                    Form18.RdoVzl.Checked = True
                ElseIf Me.RdoExtr.Checked = True Then
                    Form18.RdoExtr.Checked = True
                End If
                Me.TxtEmpleDire.Text = dr.Item(9).ToString()
                Me.TxtEmpleCorreo.Text = dr.Item(13).ToString()
                Me.MaskedTxtTelHab.Text = dr.Item(11).ToString()
                Me.MaskedTxtTelMov.Text = dr.Item(12).ToString()
            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub BtnActuEmple_Click(sender As System.Object, e As System.EventArgs) Handles BtnActuEmple.Click
        Cargar_Datos("Update representante set repre_nomb1 ='" & TxtEmplePriNomb.Text & "', repre_nomb2 ='" & TxtEmpleSegNom.Text & "', repre_apel1='" & TxtEmplePriApel.Text & "', repre_apel2='" & TxtEmpleSegApel.Text & "', repre_nacio='" & nacionalidad & "', repre_direc='" & TxtEmpleDire.Text & "', repre_tehab='" & MaskedTxtTelHab.Text & "', repre_temov='" & MaskedTxtTelMov.Text & "',  repre_corre='" & TxtEmpleCorreo.Text & "'  where repre_cedul='" & MaskedTextBox1.Text & "';")
        MessageBox.Show("Cambio exitoso", "¡Cambio exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub RdoVzl_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdoVzl.CheckedChanged
        If RdoVzl.Checked = True Then
            nacionalidad = "V-"
        ElseIf RdoExtr.Checked = True Then
            nacionalidad = "E-"
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        If MaskedTextBox1.Text = "" Then
            MaskedTextBox1.Text = ""
            BtnActuEmple.Enabled = False
        Else
            BtnActuEmple.Enabled = True
        End If
    End Sub
End Class