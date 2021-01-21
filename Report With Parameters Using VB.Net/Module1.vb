Imports System.Data.SqlClient


Module Module1
    Public cn As New SqlConnection
    Public cm As New SqlCommand
    Public dr As SqlDataReader

    Sub Connection()
        With cn
            .ConnectionString = "Data Source=DESKTOP-7C2ERR0\SQLEXPRESS;Initial Catalog=rondom_db;Integrated Security=True"
            .Open()


        End With
    End Sub
End Module
