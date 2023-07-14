Public Class clGrupo
    Property Grupo As String

    Public Function llenarComboGrupo() As DataTable

        Dim con As New CDA.clConexion

        Return con.Leer("select GPO_CODIGO, GPO_DESCRIPCION from GRUPOS order by GPO_DESCRIPCION asc")

    End Function

End Class
