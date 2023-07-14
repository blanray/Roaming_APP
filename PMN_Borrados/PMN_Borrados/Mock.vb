Imports System.Text.RegularExpressions

Public Class Mock

    Public Function validarNumeros(cadena As String) As Boolean
        Dim temp As New Regex("[0-9]")
        If (temp.IsMatch(cadena)) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function validarCaracteres(cadena As String) As Boolean
        Dim temp As New Regex("[a-zA-Z]")
        If (temp.IsMatch(cadena)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarAlfanumerico(cadena As String) As Boolean
        Dim temp As New Regex("[a-zA-Z0-9]")
        If (temp.IsMatch(cadena)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarDouble(cadena As String) As Boolean
        Dim temp As New Regex("[0-9.]")
        If (temp.IsMatch(cadena)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function validarNivelAcceso(cadena As String) As Boolean
        Dim temp As New Regex("[1-3]")
        If (temp.IsMatch(cadena)) Then
            Return True
        Else
            Return False
        End If
    End Function



End Class
