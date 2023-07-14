Public Class fIngreso
    Private Sub bCancelarIngreso_Click(sender As Object, e As EventArgs) Handles bCancelarIngreso.Click
        Me.Dispose()
        GC.Collect()
        Application.Exit()
    End Sub

    Private Sub bAceptarIngreso_Click(sender As Object, e As EventArgs) Handles bAceptarIngreso.Click

        If rbConsulta.Checked = True Then

            fPrincipal.lTipoAccesoPrincipal.Text = "Consulta"
            fPrincipal.activarMenu(0)
            Me.Close()
        Else

            If tbModificacion.Text = "VOLTE22" Then

                fPrincipal.lTipoAccesoPrincipal.Text = "Modificacion"
                fPrincipal.activarMenu(1)
                Me.Close()

            Else

                MsgBox("Password Incorrecto")

            End If

        End If



    End Sub

    Private Sub rbConsulta_CheckedChanged(sender As Object, e As EventArgs) Handles rbConsulta.CheckedChanged
        If rbConsulta.Checked Then

            lModificacion.Visible = False
            tbModificacion.Enabled = False

        End If

    End Sub

    Private Sub rbModificacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbModificacion.CheckedChanged

        lModificacion.Visible = True
        tbModificacion.Enabled = True

    End Sub
End Class