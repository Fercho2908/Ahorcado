Module conexion_db

    Public Conexion As OleDb.OleDbConnection

    Public Sub Conectar()
        Conexion = New OleDb.OleDbConnection
        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.15.0; Data Source=ahorcado.accdb;"
        Conexion.Open()
    End Sub
End Module
