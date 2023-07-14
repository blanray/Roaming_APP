Public Class fConsulta
    Private Sub bVolverConsulta_Click(sender As Object, e As EventArgs) Handles bVolverConsulta.Click

        If fPrincipal.lTipoAccesoPrincipal.Text = "Consulta" Then

            fPrincipal.activarMenu(0)

        Else

            fPrincipal.activarMenu(1)

        End If

        Me.Close()

    End Sub

    Private Sub fConsulta_Load(sender As Object, e As EventArgs) Handles Me.Load

        rbPais.Checked = True
        activarBusqueda()


    End Sub


    Public Sub llenarOperadores(ByVal pais As String, ByVal operador As String, ByVal grupo As Integer)

        Dim miOperador As New clOperador

        If rbPais.Checked Then
            dgbOperadoresPais.DataSource = miOperador.buscarPais(pais)
        End If

        If rbMNC.Checked Then
            dgbOperadoresPais.DataSource = miOperador.buscarMNC(pais, operador)
        End If

        If rbPLMN.Checked Then
            dgbOperadoresPais.DataSource = miOperador.buscarPLMN(operador)
        End If

        If rbGrupo.Checked Then
            dgbOperadoresPais.DataSource = miOperador.buscarGrupo(grupo)
        End If

        llenarLanzamientos()

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click

        Dim miDummy As New Mock

        limpiarDGV()

        If rbPais.Checked Then llenarOperadores(cbPais.SelectedValue, "", 0)

        If rbMNC.Checked Then

            If ((miDummy.validarNumeros(tbMNC.Text) Or tbMNC.Text = "") And miDummy.validarNumeros(tbMCC.Text)) Then

                llenarOperadores(tbMCC.Text, tbMNC.Text, 0)

            Else
                MsgBox("El MCC y MNC deben ser numeros o MNC vacio")
            End If

        End If


        If rbPLMN.Checked Then

            If miDummy.validarAlfanumerico(tbPLMN.Text) Then

                llenarOperadores("", tbPLMN.Text, 0)

            Else
                MsgBox("El PLMN debe ser letras y/o numeros")
            End If

        End If

        If rbGrupo.Checked Then llenarOperadores("", "", cbGrupo.SelectedValue)


    End Sub

    Public Sub activarBusqueda()

        tbMCC.Visible = False
        tbMNC.Visible = False
        tbPLMN.Visible = False
        cbGrupo.Visible = False
        cbPais.Visible = False
        Label2.Visible = False

        If rbPais.Checked Then cbPais.Visible = True

        If rbMNC.Checked Then
            tbMCC.Visible = True
            tbMNC.Visible = True
            Label2.Visible = True
        End If

        If rbPLMN.Checked Then tbPLMN.Visible = True
        If rbGrupo.Checked Then cbGrupo.Visible = True

        dgbOperadoresPais.DataSource = Nothing
        limpiarDGV()
    End Sub

    Private Sub rbPLMN_CheckedChanged(sender As Object, e As EventArgs) Handles rbPLMN.CheckedChanged
        activarBusqueda()

    End Sub

    Private Sub rbGrupo_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrupo.CheckedChanged
        activarBusqueda()

        If rbGrupo.Checked Then

            Dim miGrupo As New clGrupo

            cbGrupo.DataSource = miGrupo.llenarComboGrupo
            cbGrupo.ValueMember = "GPO_CODIGO"
            cbGrupo.DisplayMember = "GPO_DESCRIPCION"

        End If

    End Sub

    Private Sub rbMNC_CheckedChanged(sender As Object, e As EventArgs) Handles rbMNC.CheckedChanged
        activarBusqueda()

    End Sub

    Private Sub rbPais_CheckedChanged(sender As Object, e As EventArgs) Handles rbPais.CheckedChanged
        activarBusqueda()

        If rbPais.Checked Then

            Dim miPais As New clPAis

            cbPais.DataSource = miPais.llenarComboPais
            cbPais.ValueMember = "PAI_CODIGO"
            cbPais.DisplayMember = "PAI_DESCRIPCION"

        End If

    End Sub

    Private Sub dgbOperadoresPais_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgbOperadoresPais.CellClick

        limpiarDGV()

        llenarLanzamientos()

    End Sub

    Public Sub llenarLanzamientos()


        Dim miOperador As New clOperador
        Dim miPLMN As String
        Dim miTarifa As String

        miPLMN = ""

        If dgbOperadoresPais.ColumnCount > 1 Then

            miPLMN = dgbOperadoresPais.Rows(dgbOperadoresPais.CurrentRow.Index).Cells(0).Value

            dgvArgentinaOutbound.DataSource = miOperador.llenarLanzamientos(0, "ARGCM", miPLMN)
            dgvUruguayOutbound.DataSource = miOperador.llenarLanzamientos(0, "URYAM", miPLMN)
            dgvParaguayOutbound.DataSource = miOperador.llenarLanzamientos(0, "PRYHT", miPLMN)
            dgvArgemtinaInbound.DataSource = miOperador.llenarLanzamientos(1, "ARGCM", miPLMN)
            dgvUruguayInbound.DataSource = miOperador.llenarLanzamientos(1, "URYAM", miPLMN)
            dgvParaguayInbound.DataSource = miOperador.llenarLanzamientos(1, "PRYHT", miPLMN)

            miTarifa = miOperador.llenarIOT(miPLMN)

            If miTarifa = "-1" Then
                lIOT.Text = "SIN IOT"
            Else
                lIOT.Text = miTarifa
            End If


        End If

    End Sub

    Public Sub limpiarDGV()

        dgvArgentinaOutbound.Visible = False
        dgvUruguayOutbound.Visible = False
        dgvParaguayOutbound.Visible = False
        dgvArgemtinaInbound.Visible = False
        dgvUruguayInbound.Visible = False
        dgvParaguayInbound.Visible = False

        dgvArgentinaOutbound.DataSource = Nothing
        dgvUruguayOutbound.DataSource = Nothing
        dgvParaguayOutbound.DataSource = Nothing
        dgvArgemtinaInbound.DataSource = Nothing
        dgvUruguayInbound.DataSource = Nothing
        dgvParaguayInbound.DataSource = Nothing

        dgvArgentinaOutbound.Visible = True
        dgvUruguayOutbound.Visible = True
        dgvParaguayOutbound.Visible = True
        dgvArgemtinaInbound.Visible = True
        dgvUruguayInbound.Visible = True
        dgvParaguayInbound.Visible = True

    End Sub

End Class