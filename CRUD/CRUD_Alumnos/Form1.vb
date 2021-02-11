':::Importamos la libreria OleDb
Imports System.Data.OleDb

Public Class Form1
    ':::Creamos un objeto para establecer conexion con nuestra clase CRUD
    Dim Obj As New CRUD

    Private Sub Limpiar()
        TxtId.Clear()
        TxtPrimerNombre.Clear()
        TxtSegundoNombre.Clear()
        TxtApellidoPaterno.Clear()
        TxtApellidoMaterno.Clear()
        TxtTelefono.Clear()
        TxtCelular.Clear()
        TxtDireccion.Clear()
        TxtEmail.Clear()
        Me.dtFechaNac.Text = Now.ToLongDateString
        txtObservaciones.Clear()
        TxtId.Focus()
    End Sub

    Private Sub Actualizar()
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Select * from Alumnos"
        ':::Mediante el objeto que creamos globalmente y nombramos "Obj"
        ':::Accedemos a nuestro procedimiento "consulta" y le pasamos los
        ':::dos (2) parametros (DGTabla, Sql)
        Obj.consulta(DGTabla, Sql)
    End Sub


    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        ':::Obtenemos la hora y fecha en el formato admitido por SQLite
        Dim Fecha As String = dtFechaNac.Value.ToString("yyyy-MM-dd")

        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Insert Into Alumnos (Id, PrimerNombre, SegundoNombre, ApellidoPaterno,ApellidoMaterno,Telefono,Celular,Direccion,Email,FechaNacimiento,Observaciones) Select " & TxtId.Text & ", '" & TxtPrimerNombre.Text.ToString & "', '" & TxtSegundoNombre.Text.ToString & "','" & TxtApellidoPaterno.Text.ToString & "','" & TxtApellidoMaterno.Text.ToString & "','" & TxtTelefono.Text & "','" & TxtCelular.Text & "','" & TxtDireccion.Text.ToString & "','" & TxtEmail.Text.ToString & "','" & Fecha & "','" & txtObservaciones.Text.ToString & "'  "
        ':::Cambiamos el nombre del procedimiento "operaciones"
        Obj.operaciones(DGTabla, Sql)

        MsgBox("Se a registrado correctamente", MsgBoxStyle.Information, "I.E. Carlos Morales")

        Actualizar()

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ':::Obtenemos la hora y fecha en el formato admitido por SQLite
        Dim Fecha As String = dtFechaNac.Value.ToString("yyyy-MM-dd")

        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Update Alumnos Set  PrimerNombre='" & TxtPrimerNombre.Text & "', SegundoNombre='" & TxtSegundoNombre.Text & "',ApellidoPaterno='" & TxtApellidoPaterno.Text & "',ApellidoMaterno='" & TxtApellidoMaterno.Text & "',Telefono='" & TxtTelefono.Text & "',Celular='" & TxtCelular.Text & "',Direccion='" & TxtDireccion.Text & "',Email='" & TxtEmail.Text & "',FechaNacimiento='" & Fecha & "',Observaciones='" & txtObservaciones.Text & "' where Id=" & TxtId.Text & " "
        Obj.operaciones(DGTabla, Sql)

        MsgBox("Se a actualizado correctamente", MsgBoxStyle.Information, "I.E. Carlos Morales")

        Actualizar()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        BtnActualizar.Enabled = True
        BtnAgregar.Enabled = True

        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Delete * From Alumnos Where Id=" & TxtId.Text & ""
        Obj.operaciones(DGTabla, Sql)

        MsgBox("Se a eliminado correctamente", MsgBoxStyle.Information, "I.E. Carlos Morales")

        Actualizar()

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub


    Private Sub DGTabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTabla.CellClick

        Dim i As Integer

        i = DGTabla.CurrentRow.Index

        TxtId.Text = DGTabla.Item(0, i).Value()
        TxtPrimerNombre.Text = DGTabla.Item(1, i).Value()
        TxtSegundoNombre.Text = DGTabla.Item(2, i).Value()
        TxtApellidoPaterno.Text = DGTabla.Item(3, i).Value()
        TxtApellidoMaterno.Text = DGTabla.Item(4, i).Value()
        TxtTelefono.Text = DGTabla.Item(5, i).Value()
        TxtCelular.Text = DGTabla.Item(6, i).Value()
        TxtDireccion.Text = DGTabla.Item(7, i).Value()
        TxtEmail.Text = DGTabla.Item(8, i).Value()
        dtFechaNac.Value = DGTabla.Item(9, i).Value
        txtObservaciones.Text = DGTabla.Item(10, i).Value()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ':::Actualización automatica de nuestro From1
        Actualizar()
    End Sub

    Private Sub btnCandA_Click(sender As Object, e As EventArgs) Handles btnCandA.Click
        Actualizar()

        ':::Mediante el objeto que creamos accedemos al procedimiento "conexion"
        Obj.conexion()
    End Sub


    ':::Procedimiento para cargar la base de datos SQLite
    Sub Cargar_Access(ByVal Sql As String, ByVal Tabla As DataGridView)

        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=C:\Users\DoolPool\Desktop\Tutorial_CRUD\Base de Datos\Tutorial_CRUD\Datos.mdb")

        ':::Creamos nuestro objeto SQLiteDataAdapte, el cual recibe dos parametros
        ':::La conexion y la consulta SQL
        Dim Da As New OleDbDataAdapter(Sql, con)
        ':::Creamos nuestro DataTable para almacenar el resultado
        Dim Dt As New DataTable
        ':::Llenamos nuestro DataTable con el resultado de la consulta
        Da.Fill(Dt)
        ':::Asignamos a nuestro DataGridView el DataTable para mostrar los registros
        Tabla.DataSource = Dt
        ':::Damos color a las filas y formato a la columna hora
        Tabla.RowsDefaultCellStyle.BackColor = Color.LightBlue
        Tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.White
    End Sub

    ':::Dependiendo del valor que se inserte en el buscador se realizara la búsqueda
    Public Sub buscar()

        If IsNumeric(TextBoxBuscar.Text) Then

            ':::Si es numero lo insertado buscada por id de alumno
            Filtro_Campo_Id_Caracter_Access()

        Else

            ':::Si es Texto lo insertado buscara por nombre de alumno
            Filtro_Campo_Nombre_Caracter_Access()

        End If


    End Sub

    Sub Filtro_Campo_Id_Caracter_Access()
        ':::Creamos nuestra consulta SQL
        Dim sql As String = "Select * from Alumnos where Id Like '%" & TextBoxBuscar.Text & "%'"
        Cargar_Access(sql, DGTabla)
        Text = "I.E. Carlos Morales || Buscando : " & TextBoxBuscar.Text & ""
    End Sub

    Sub Filtro_Campo_Nombre_Caracter_Access()
        ':::Creamos nuestra consulta SQL
        Dim sql As String = "Select * from Alumnos where PrimerNombre Like '%" & TextBoxBuscar.Text & "%'"
        Cargar_Access(sql, DGTabla)
        Text = "I.E. Carlos Morales || Buscando : " & TextBoxBuscar.Text & ""
    End Sub


    Private Sub TextBoxBuscarID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        buscar()

    End Sub

    Private Sub BtnX_Click(sender As Object, e As EventArgs) Handles BtnX.Click
        TextBoxBuscar.Clear()
        Text = "I.E. Carlos Morales"
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        buscar()
    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Report.Show()
    End Sub
End Class
