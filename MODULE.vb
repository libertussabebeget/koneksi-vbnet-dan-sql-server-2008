Imports System.Data.SqlClient
Module Module1
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public Ds As DataSet

    Public Sub Koneksi()
        Conn = New SqlConnection("Data Source=LIBERTUS; initial catalog=DB_BahanAjar; integrated security=true")
        Conn.Open()
    End Sub
End Module
