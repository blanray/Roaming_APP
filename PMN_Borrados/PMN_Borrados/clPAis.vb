Public Class clPAis

    Property codigo As String
    Property descripcion As String
    Property e164 As String
    Property mcc As String


    Public Function llenarComboPais() As DataTable

        Dim con As New CDA.clConexion

        Return con.Leer("select PAI_CODIGO, PAI_DESCRIPCION from PAISES order by PAI_DESCRIPCION asc")

    End Function

    Public Function buscarDatosPais(ByVal codigo As String)

        Dim con As New CDA.clConexion

        Return con.Leer("select PAI_CODIGO, PAI_DESCRIPCION from PAISES order by PAI_DESCRIPCION asc")

    End Function

End Class
