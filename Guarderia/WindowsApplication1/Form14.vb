Public Class Form14
    Dim nacionalidad As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Cargar_Datos("INSERT into pagos (pagos_seria, pagos_monti, pagos_mesap, pagos_mtota, pagos_mespa, repre_cedul) VALUES(nextval('pagos_pagos_seria_seq'), '" & MaskedTxtMonInscr.Text & "','" & CbMesAPagar.Text & "','" & MaskedTxtMontoTotal.Text & "', '" & TxtMesDePago.Text & "', '" & MaskedTxtCed.Text & "');")
            MessageBox.Show("Pago Registrado")
            Form2.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


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

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = Form1.Top
        Me.Left = Form1.Left
        Button2.Enabled = False
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

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoVzla.CheckedChanged
        If RdoVzla.Checked = True Then
            nacionalidad = "V-"
        ElseIf RdoExtr.Checked = True Then
            nacionalidad = "E-"
        End If
    End Sub

    Private Sub BtnEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmpleado.Click
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = ConexionPostgres
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "Select * from representante where repre_cedul='" + Masktxtced.Text + "'; "
        cmd.CommandText = "SELECT * FROM representante where repre_cedul='" + MaskedTxtCed.Text + "' and repre_nacio='" & nacionalidad & "';"
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
            Else
                MsgBox("Usuario no existe", MsgBoxStyle.Critical, "Error de datos")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub MaskedTxtCed_MaskInputRejected(sender As System.Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTxtCed.MaskInputRejected
        If MaskedTxtCed.Text = "" Or MaskedTxtCed.Text = "_" Then
            MaskedTxtCed.Text = ""
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub
End Class