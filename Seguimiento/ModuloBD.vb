Module ModuloBD
    Public CONN As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & "Seguimiento.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public ConsultaSQL As String 'va el codigo SQL para consultar
    Public SQL As String = ""



    Sub Conectarse()
        Try
            CONN.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub Consultar()
        Try
            cmd.Connection = CONN
            cmd.CommandType = CommandType.Text
            cmd.CommandText = ConsultaSQL

            dr = cmd.ExecuteReader()

        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub IngresarEnAcces()
        Try
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN

            'toma el valor sql del programa
            cmd.CommandText = SQL

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
