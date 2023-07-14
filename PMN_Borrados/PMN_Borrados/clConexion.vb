Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration


Namespace CDA
    Public Class clConexion

        Protected configuracion As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("MiCadenadeCnn")
        Private cnn As New OleDb.OleDbConnection(configuracion.ConnectionString)

        Private cmd As OleDb.OleDbCommand
        Private cmd2 As OleDb.OleDbCommand
        Private cmd3 As OleDb.OleDbCommand
        Private miTransaccion As OleDb.OleDbTransaction

        Public Sub AbrirCnn()
            Try
                If cnn.State = ConnectionState.Closed Then cnn.Open()

            Catch ex As SqlException
                MsgBox("Error en al conectarse a la Base de Datos ", ex.Message)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Sub CerrarCnn()
            Try
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                    cnn.Dispose()
                    cnn = Nothing
                    GC.Collect()
                End If

            Catch ex As SqlException
                MsgBox(ex.ToString)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Sub

        Public Function Leer(ByVal consulta As String) As DataTable
            Dim tabla As New DataTable
            Try
                If cnn.State = ConnectionState.Closed Then AbrirCnn()

                Dim Da As New OleDb.OleDbDataAdapter(consulta, cnn)
                Da.Fill(tabla)

                CerrarCnn()

            Catch ex As SqlException
                MsgBox(ex.ToString)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Return tabla
        End Function

    End Class

End Namespace

