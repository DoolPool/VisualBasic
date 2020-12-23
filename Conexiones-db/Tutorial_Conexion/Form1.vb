Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Imports System.Data.SQLite
Public Class Form1
    Private Sub BtnConAccess_Click(sender As Object, e As EventArgs) Handles BtnConAccess.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=C:\Datos.mdb")
        Try
            con.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnConMySQL_Click(sender As Object, e As EventArgs) Handles BtnConMySQL.Click
        Dim con As New MySqlConnection("Server=localhost; Database=test; Uid=root; Pwd=root")
        Try
            con.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnConSQLite_Click(sender As Object, e As EventArgs) Handles BtnConSQLite.Click
        Dim con As New SQLiteConnection("Data Source=C:\Pueba SqlLite\PruebaDB.db; Version=3")
        Try
            con.Open()
            MsgBox("Conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
