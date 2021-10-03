Imports System.Data.SqlClient

Module Conexion
    Public Connection As New SqlClient.SqlConnection
    Public Command As New SqlCommand
    Public Adapter As New SqlDataAdapter
    Public DS As DataSet
    Public DR As SqlDataReader
    Const ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=PolirubroRealDB.mdf;Integrated Security=True"


    Public QueryLibros As String = "SELECT Libro.Titulo, Autor.Nombre AS Autor, Pais.Nombre AS Pais, Idioma.Nombre AS Idioma, Libro.Precio, Libro.Cantidad " &
         "FROM (((Autor INNER JOIN Libro ON Autor.IdAutor = Libro.IdAutor) INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma) " &
         "INNER JOIN Pais ON Libro.IdPais = Pais.IdPais)"
    Public QueryLibrosBase As String = "SELECT Titulo, IdAutor, IdPais, IdIdioma, Precio, Cantidad FROM Libro"
    Public QueryPaises As String = "SELECT idpais As Id, Nombre FROM Pais"
    Public QueryAutores As String = "SELECT idautor As Id, Nombre FROM Autor"
    Public QueryIdiomas As String = "SELECT ididioma As Id, Nombre FROM Idioma"



    Public Function GetDataSet(query As String, commandType As CommandType) As DataSet
        Try
            Connection.ConnectionString = ConnectionString
            Connection.Open()

            Command.Connection = Connection
            Command.CommandType = commandType
            Command.CommandText = query

            Adapter = New SqlDataAdapter(Command)
            DS = New DataSet
            Adapter.Fill(DS)
        Catch
            MessageBox.Show(ErrorToString)
        Finally
            Connection.Close()
        End Try
        Return DS
    End Function

    Public Function GetQueryEstadisticasLibro(tabla As String) As String
        Dim query = $"Select t.Nombre As {tabla}, COUNT(*) As Cantidad FROM ({tabla} t INNER JOIN Libro l ON t.Id{tabla} = l.Id{tabla}) GROUP BY t.Nombre"
        Return query
    End Function
End Module
