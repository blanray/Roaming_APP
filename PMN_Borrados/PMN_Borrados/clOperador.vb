Public Class clOperador

    Property PLMN As String
    Property Nombre As String
    Property IMSI As String
    Property Pais As New clPAis
    Property Grupo As New clGrupo

    Property ServiciosLanzados As New List(Of clLanzamiento)

    Public Function buscarPais(ByVal pais As String) As DataTable

        Dim con As New CDA.clConexion
        Dim instruccion As String
        Dim miTabla As New DataTable

        instruccion = ""
        instruccion = "select OPE_PLMN as PLMN, OPE_NOMBRE as NOMBRE, OPE_ORGANIZACION as ORGANIZACION, PAI_DESCRIPCION as PAIS, OPE_IMSI as MCC_MNC, GPO_DESCRIPCION as GRUPO from OPERADORES, PAISES, GRUPOS WHERE OPE_PAI_CODIGO ='" & pais & "' And OPE_PAI_CODIGO = PAI_CODIGO And OPE_GPO_CODIGO = GPO_CODIGO"


        Try
            miTabla = con.Leer(instruccion)

            If miTabla.Rows.Count < 1 Then
                miTabla.Rows.Add("No hay operadores para ese pais")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return miTabla

    End Function

    Public Function buscarMNC(ByVal mcc As String, ByVal mnc As String) As DataTable

        Dim con As New CDA.clConexion
        Dim instruccion As String
        Dim miTabla As New DataTable

        instruccion = ""

        If mnc = "" Then

            instruccion = "select OPE_PLMN as PLMN, OPE_NOMBRE as NOMBRE, OPE_ORGANIZACION as ORGANIZACION, PAI_DESCRIPCION as PAIS, OPE_IMSI as MCC_MNC, GPO_DESCRIPCION as GRUPO from OPERADORES, PAISES, GRUPOS WHERE OPE_IMSI like'" & mcc & "%' And OPE_PAI_CODIGO = PAI_CODIGO And OPE_GPO_CODIGO = GPO_CODIGO"

        Else
            instruccion = "select OPE_PLMN as PLMN, OPE_NOMBRE as NOMBRE, OPE_ORGANIZACION as ORGANIZACION, PAI_DESCRIPCION as PAIS, OPE_IMSI as MCC_MNC, GPO_DESCRIPCION as GRUPO from OPERADORES, PAISES, GRUPOS WHERE OPE_IMSI ='" & mcc & mnc & "' And OPE_PAI_CODIGO = PAI_CODIGO And OPE_GPO_CODIGO = GPO_CODIGO"

        End If


        Try
            miTabla = con.Leer(instruccion)

            If miTabla.Rows.Count < 1 Then
                miTabla.Rows.Add("No hay operadores para ese pais")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return miTabla

    End Function

    Public Function buscarPLMN(ByVal plmn As String) As DataTable

        Dim con As New CDA.clConexion
        Dim instruccion As String
        Dim miTabla As New DataTable

        instruccion = ""
        instruccion = "select OPE_PLMN as PLMN, OPE_NOMBRE as NOMBRE, OPE_ORGANIZACION as ORGANIZACION, PAI_DESCRIPCION as PAIS, OPE_IMSI as MCC_MNC, GPO_DESCRIPCION as GRUPO from OPERADORES, PAISES, GRUPOS where OPE_PLMN ='" & plmn & "' AND OPE_PAI_CODIGO = PAI_CODIGO AND OPE_GPO_CODIGO = GPO_CODIGO"

        Try
            miTabla = con.Leer(instruccion)

            If miTabla.Rows.Count < 1 Then
                miTabla.Rows.Add("No hay operadores para ese pais")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return miTabla

    End Function

    Public Function buscarGrupo(ByVal grupo As Integer) As DataTable

        Dim con As New CDA.clConexion
        Dim instruccion As String
        Dim miTabla As New DataTable

        instruccion = ""
        instruccion = "select OPE_PLMN as PLMN, OPE_NOMBRE as NOMBRE, OPE_ORGANIZACION as ORGANIZACION, PAI_DESCRIPCION as PAIS, OPE_IMSI as MCC_MNC, GPO_DESCRIPCION as GRUPO from OPERADORES, PAISES, GRUPOS where OPE_GPO_CODIGO =" & grupo & " AND OPE_PAI_CODIGO = PAI_CODIGO AND OPE_GPO_CODIGO = GPO_CODIGO"

        Try
            miTabla = con.Leer(instruccion)

            If miTabla.Rows.Count < 1 Then
                miTabla.Rows.Add("No hay operadores para ese pais")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return miTabla

    End Function

    Public Function llenarLanzamientos(ByVal sentido As Boolean, ByVal home As String, ByVal operador As String) As DataTable

        Dim con As New CDA.clConexion
        Dim instruccion As String
        Dim miTabla As New DataTable

        instruccion = ""

        If sentido Then

            instruccion = "select SER_DESCRIPCION as SERVICIO, FECHA from LANZAMIENTOS_INBOUND, SERVICIOS where SERVICIO = SER_CODIGO and HPMN = '" & home & "' AND VPMN = '" & operador & "' order by SER_CODIGO asc"

        Else
            instruccion = "select SER_DESCRIPCION as SERVICIO, FECHA from LANZAMIENTOS_OUTBOUND, SERVICIOS where SERVICIO = SER_CODIGO and HPMN = '" & home & "' AND VPMN = '" & operador & "' order by SER_CODIGO asc"

        End If


        Try
            miTabla = con.Leer(instruccion)

            If miTabla.Rows.Count < 1 Then
                miTabla.Rows.Add("No hay lanzamientos para ese operador")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return miTabla

    End Function

    Public Function llenarIOT(ByVal plmn As String) As String

        Dim con As New CDA.clConexion
        Dim instruccion As String
        Dim miTabla As New DataTable
        Dim miTarifa As String
        Dim s As String

        s = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator

        instruccion = ""

        instruccion = "select Unit_Cost_1 as Tarifa from ACUERDOS_IOT where Network_Operator = '" & plmn & "'"

        Try

            miTabla = con.Leer(instruccion)

            If miTabla.Rows.Count < 1 Then
                miTarifa = "-1"
            Else

                miTarifa = miTabla.Rows(0)(0)


            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return miTarifa

    End Function

End Class
