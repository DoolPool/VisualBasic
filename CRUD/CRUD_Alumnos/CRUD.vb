':::Importamos la libreria OleDb
Imports System.Data.OleDb

Public Class CRUD
    ':::Declaramos los objetos globales de conexion

    ':::Procedimiento para conexion a SQLite
    'Dim Con1 As New SQLiteConnection("Data source=C:\Tutoriales\Tutoriales.db3; version=3;")

    ':::Procedimiento para conexion a MySQL
    'Dim Con2 As New MySqlConnection("Server = localhost; Database = Tutoriales; Uid = root; Pwd = root")

    ':::Procedimiento para conexion a Access
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=C:\Users\DoolPool\Desktop\Tutorial_CRUD\Base de Datos\Tutorial_CRUD\Datos.mdb")

    ':::Creamos el procedimiento conexion
    Sub conexion()
        ':::Instruccion Try para capturar errores
        Try
            ':::Abrimos nuestro conexion con la propiedad Open
            con.Open()
            MsgBox("Conexión realizada de manera exitosa", MsgBoxStyle.Information, "I.E. Carlos Morales")
            ':::Y cerramos la conexion
            con.Close()
        Catch ex As Exception
            MsgBox("No se logro realizar la conexión debido: " & ex.Message, MsgBoxStyle.Critical, "I.E. Carlos Morales")
        End Try
    End Sub

    ':::Creamos el procedimiento para la consulta y le indicamos que debe pedir 2 parametros para 
    ':::ejecutarse correctamente (Tabla, Sql)
    Sub consulta(ByVal Tabla As DataGridView, ByVal Sql As String)
        ':::Instruccion Try para capturar errores
        Try
            ':::Creamos el objeto DataAdapter y le pasamos los dos parametros (Instruccion, conexión)
            Dim DA As New OleDbDataAdapter(Sql, con)
            ':::Creamos el objeto DataTable que recibe la informacion del DataAdapter
            Dim DT As New DataTable
            ':::Pasamos la informacion del DataAdapter al DataTable mediante la propiedad Fill
            DA.Fill(DT)
            ':::Ahora mostramos los datos en el DataGridView
            Tabla.DataSource = DT
        Catch ex As Exception
            MsgBox("No se logro realizar la consulta por: " & ex.Message, MsgBoxStyle.Critical, "I.E. Carlos Morales")
        End Try
    End Sub

    ':::Creamos el procedimiento para Agregar, Actualizar y Eliminar ademas le indicamos que debe pedir
    ':::2 parametros para ejecutarse correctamente (Tabla, Sql)
    Sub operaciones(ByVal Tabla As DataGridView, ByVal Sql As String)
        ':::Abrimos la conexion
        con.Open()
        ':::Instruccion Try para capturar errores
        Try
            ':::Creamos nuestro objeto de tipo Command que almacenara nuestras instrucciones
            ':::Necesita 2 parametros (Instruccion, conexion)
            Dim cmd As New OleDbCommand(Sql, con)
            ':::Ejecutamos la instruccion mediante la propiedad ExecuteNonQuery del command
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se logro realizar la operación por: " & ex.Message, MsgBoxStyle.Critical, "I.E. Carlos Morales")
        End Try
        ':::Cerramos la conexion
        con.Close()
    End Sub
End Class
