Imports Logica.ConexionBD
Public Class InicioSesionUI

    Private con As ConexionBD = New ConexionBD()

    Private Sub btnConfirm(sender As Object, e As EventArgs) Handles btnConfirmarSesion.Click
        Dim name As String = TextBox1.Text
        Dim pass As String = TextBox2.Text
        con.login(name, pass)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub InicioSesionUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.conexionDB()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim Msg, Style, Response, MyString
        Msg = "Seguro que desa salir ?"    ' Define message.
        Style = vbYesNo + vbCritical + vbDefaultButton2    ' Define buttons.
        ' Display message.
        Response = MsgBox(Msg, Style)
        If Response = vbYes Then    ' User chose Yes.
            MyString = "Yes"    ' Perform some action.
            Me.Close()
        Else    ' User chose No.
            MyString = "No"    ' Perform some action.
        End If
    End Sub
End Class
