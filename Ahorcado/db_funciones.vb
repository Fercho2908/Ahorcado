Module db_funciones

    Public Conexion As OleDb.OleDbConnection

    Public Sub Conectar()

        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=ahorcado.accdb"
        Conexion.Open()
        MsgBox("Conexión exitosa", MsgBoxStyle.OkOnly)

    End Sub
End Module