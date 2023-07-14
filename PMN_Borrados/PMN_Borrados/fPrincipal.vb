Public Class fPrincipal

    Private Sub fPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        mPrincipal.Enabled = False
        fIngreso.Show()
        fIngreso.MdiParent = Me

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
        GC.Collect()
        Application.Exit()
    End Sub

    Public Sub activarMenu(ByVal tipo As Boolean)

        mPrincipal.Enabled = True

        If Not (tipo) Then

            mPrincipal.Items(1).Enabled = False

        End If

    End Sub

    Private Sub BusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaToolStripMenuItem.Click

        Dim formularioConsulta As New fConsulta()
        formularioConsulta.Show()
        formularioConsulta.MdiParent = Me
        mPrincipal.Enabled = False

    End Sub
End Class