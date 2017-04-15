Module Module1
    Public Id_form As String
    Public ConexionPostgres As New Odbc.OdbcConnection("DSN=guarderia")
    Dim Convertido As String

    Public Sub Cargar_Datos(ByVal sql As String)

        ' si la conexion esta abierta se cierra 
        If ConexionPostgres.State = ConnectionState.Open Then
            ConexionPostgres.Close()
        End If

        ConexionPostgres.Open() ' abre la conexión   
        Dim cdo As New Odbc.OdbcCommand(sql, ConexionPostgres)
        cdo.ExecuteNonQuery() 'ejecuta la sentencia sql

        ' se cierra la conexion    
        ConexionPostgres.Close()
    End Sub
End Module
