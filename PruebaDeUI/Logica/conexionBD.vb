Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class ConexionBD
    Private conexion As New MySqlConnection
    Private adaptador As New MySqlDataAdapter
    Private datos As DataSet

    Public Sub New()

    End Sub
    Public Sub conexionDB()
        Try
            conexion.ConnectionString = "Server=localhost;user=root;pass=;database=pruebasloginprogramacion"
            conexion.Open() 'Abrimos la base de datos
            MsgBox("conexion correcta") 'Acciones sobre la base de datos'

            'conn.Close() Cerramos la base de datos


            'esto es para MySqlConnectionStringBuilder
            'conexion.Server = "localhost" 'nombre servidor
            'conexion.UserID = "root" 'nombre del usuario de phpMyadmin
            'conexion.Password = ""
            'conexion.Database = "pruebasloginprogramacion" 'nombre de la base de 
            'Dim conn As New MySqlConnection(conexion.ToString()) 'creo el objeto con toda la informacion de conexion
        Catch ex As Exception
            MsgBox("No se puedo conectar" & ex.Message)
        End Try
    End Sub

    Public Sub login(name As String, pass As String)
        Dim consulta As String
        Dim lista As Byte

        Dim buscoNom As String
        Dim buscoPass As String

        If name <> "" And pass <> "" Then
            'consulta = "Select * from usuario where nomUser='" & name & "'"
            'adaptador = New MySqlDataAdapter(consulta, conexion)
            'datos = New DataSet
            'adaptador.Fill(datos, "Usuario")
            'lista = datos.Tables("Usuario").Rows.Count
            '''''''''''''''''''''''''''''''
            buscoNom = "Select * from usuario where nomUser='" & name & "'"
            adaptador = New MySqlDataAdapter(buscoNom, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "Usuario")
            lista = datos.Tables("Usuario").Rows.Count

            If lista <> 0 Then
                buscoPass = "Select * from usuario where passUser='" & pass & "'"
                adaptador = New MySqlDataAdapter(buscoPass, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "Usuario")
                lista = datos.Tables("Usuario").Rows.Count

                If lista <> 0 Then
                    Dim Msg, Style, Response
                    Msg = "Sesion inicida con exito"    ' Define message.
                    Style = vbInformation + vbOK   ' Define buttons.
                    ' Display message.
                    Response = MsgBox(Msg, Style)
                Else
                    Dim Msg, Style, Response
                    Msg = "Contraseña incorrectos"    ' Define message.
                    Style = vbInformation + vbOK   ' Define buttons.
                    ' Display message.
                    Response = MsgBox(Msg, Style)
                End If
            Else
                Dim Msg, Style, Response
                Msg = "usuario incorrectos"    ' Define message.
                Style = vbInformation + vbOK   ' Define buttons.
                ' Display message.
                Response = MsgBox(Msg, Style)
            End If
        End If



    End Sub

End Class
