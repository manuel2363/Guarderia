Public Class Form13
    Dim nacionalidad, clave As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAtras.Click
        Form2.Show()
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

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "Select * from representante where repre_cedul='" + Masktxtced.Text + "'; "
        cmd.CommandText = "SELECT * FROM representante CROSS JOIN usuario where repre_cedul='" + Masktxtced.Text + "' and repre_nacio='" & nacionalidad & "';"
        clave = Masktxtced.Text
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then

                Me.Masktxtced.Text = dr.Item(1).ToString()
                Me.CbCargo.Text = dr.Item(17).ToString()
                Me.CbStatus.Text = dr.Item(21).ToString()
                If Me.RdoVzl.Checked = True Then
                    Me.RdoVzl.Checked = True
                ElseIf Me.RdoExtr.Checked = True Then
                    Me.RdoExtr.Checked = True
                End If

            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        

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

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Cargar_Datos("Update usuario set usuar_permi ='" & CbCargo.Text & "', usuar_satus ='" & CbStatus.Text & "' where usuar_clave='" & TxtClaveUsu.Text & "'")
        Cargar_Datos("Update representante set repre_cedul= '" & Masktxtced.Text & "', repre_nacio= '" & nacionalidad & "' where repre_cedul ='" & clave & "' ")
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

    Private Sub TxtClaveUsu_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtClaveUsu.TextChanged
        If TxtClaveUsu.Text = " " Or TxtClaveUsu.Text = "_" Then
            TxtClaveUsu.Text = ""
            Button1.Enabled = False
        Else
            Button1.Enabled = True
            'MessageBox.Show("Por favor introduzca su clave para actualizar datos", "Ingresar clave", MessageBoxButtons.OK)       
        End If
    End Sub
End Class