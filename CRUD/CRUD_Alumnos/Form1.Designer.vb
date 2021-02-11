<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.TxtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGTabla = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.dtFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.btnCandA = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnX = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnReporte = New System.Windows.Forms.Button()
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(913, 23)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(115, 41)
        Me.BtnAgregar.TabIndex = 1
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(913, 72)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(115, 38)
        Me.BtnActualizar.TabIndex = 2
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(916, 133)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(115, 38)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(16, 56)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(143, 22)
        Me.TxtId.TabIndex = 5
        '
        'TxtPrimerNombre
        '
        Me.TxtPrimerNombre.Location = New System.Drawing.Point(16, 120)
        Me.TxtPrimerNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrimerNombre.Name = "TxtPrimerNombre"
        Me.TxtPrimerNombre.Size = New System.Drawing.Size(143, 22)
        Me.TxtPrimerNombre.TabIndex = 6
        '
        'TxtSegundoNombre
        '
        Me.TxtSegundoNombre.Location = New System.Drawing.Point(16, 183)
        Me.TxtSegundoNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSegundoNombre.Name = "TxtSegundoNombre"
        Me.TxtSegundoNombre.Size = New System.Drawing.Size(143, 22)
        Me.TxtSegundoNombre.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Identificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Primer Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Segundo Nombre"
        '
        'DGTabla
        '
        Me.DGTabla.AllowUserToAddRows = False
        Me.DGTabla.AllowUserToDeleteRows = False
        Me.DGTabla.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGTabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTabla.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGTabla.Location = New System.Drawing.Point(22, 70)
        Me.DGTabla.Margin = New System.Windows.Forms.Padding(4)
        Me.DGTabla.Name = "DGTabla"
        Me.DGTabla.ReadOnly = True
        Me.DGTabla.RowHeadersWidth = 51
        Me.DGTabla.Size = New System.Drawing.Size(1009, 283)
        Me.DGTabla.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Apellido Paterno"
        '
        'TxtApellidoPaterno
        '
        Me.TxtApellidoPaterno.Location = New System.Drawing.Point(216, 50)
        Me.TxtApellidoPaterno.Name = "TxtApellidoPaterno"
        Me.TxtApellidoPaterno.Size = New System.Drawing.Size(144, 22)
        Me.TxtApellidoPaterno.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(213, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Apellido Materno"
        '
        'TxtApellidoMaterno
        '
        Me.TxtApellidoMaterno.Location = New System.Drawing.Point(216, 115)
        Me.TxtApellidoMaterno.Name = "TxtApellidoMaterno"
        Me.TxtApellidoMaterno.Size = New System.Drawing.Size(144, 22)
        Me.TxtApellidoMaterno.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(216, 183)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(144, 22)
        Me.TxtTelefono.TabIndex = 17
        '
        'TxtCelular
        '
        Me.TxtCelular.Location = New System.Drawing.Point(409, 50)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(178, 22)
        Me.TxtCelular.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(406, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(406, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Dirección"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(409, 113)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(178, 22)
        Me.TxtDireccion.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(406, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(409, 183)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(178, 22)
        Me.TxtEmail.TabIndex = 23
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(636, 120)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(214, 98)
        Me.txtObservaciones.TabIndex = 51
        '
        'dtFechaNac
        '
        Me.dtFechaNac.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaNac.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtFechaNac.Location = New System.Drawing.Point(636, 46)
        Me.dtFechaNac.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFechaNac.Name = "dtFechaNac"
        Me.dtFechaNac.Size = New System.Drawing.Size(202, 22)
        Me.dtFechaNac.TabIndex = 49
        Me.dtFechaNac.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(633, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 17)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Fecha de Nacimiento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(633, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 17)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Observaciónes"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(828, 646)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(236, 17)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Developer by @RonaldRamosMalca"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(916, 183)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(115, 36)
        Me.BtnLimpiar.TabIndex = 55
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCandA
        '
        Me.btnCandA.Location = New System.Drawing.Point(9, 646)
        Me.btnCandA.Name = "btnCandA"
        Me.btnCandA.Size = New System.Drawing.Size(105, 28)
        Me.btnCandA.TabIndex = 56
        Me.btnCandA.Text = "Conectar db"
        Me.btnCandA.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnX)
        Me.GroupBox1.Controls.Add(Me.BtnRefresh)
        Me.GroupBox1.Controls.Add(Me.TextBoxBuscar)
        Me.GroupBox1.Controls.Add(Me.DGTabla)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1052, 372)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscador"
        '
        'BtnX
        '
        Me.BtnX.Location = New System.Drawing.Point(22, 30)
        Me.BtnX.Name = "BtnX"
        Me.BtnX.Size = New System.Drawing.Size(35, 22)
        Me.BtnX.TabIndex = 5
        Me.BtnX.Text = "X"
        Me.BtnX.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(937, 26)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(94, 31)
        Me.BtnRefresh.TabIndex = 4
        Me.BtnRefresh.Text = "Refrescar"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(63, 30)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(865, 22)
        Me.TextBoxBuscar.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtObservaciones)
        Me.GroupBox2.Controls.Add(Me.TxtDireccion)
        Me.GroupBox2.Controls.Add(Me.BtnAgregar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.BtnActualizar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtApellidoPaterno)
        Me.GroupBox2.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox2.Controls.Add(Me.TxtEmail)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtId)
        Me.GroupBox2.Controls.Add(Me.dtFechaNac)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtTelefono)
        Me.GroupBox2.Controls.Add(Me.TxtApellidoMaterno)
        Me.GroupBox2.Controls.Add(Me.TxtPrimerNombre)
        Me.GroupBox2.Controls.Add(Me.TxtSegundoNombre)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtCelular)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1052, 239)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro"
        '
        'BtnReporte
        '
        Me.BtnReporte.Location = New System.Drawing.Point(125, 646)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(133, 27)
        Me.BtnReporte.TabIndex = 59
        Me.BtnReporte.Text = "Reporte"
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1078, 677)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCandA)
        Me.Controls.Add(Me.Label12)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "I.E. Carlos Morales"
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtPrimerNombre As TextBox
    Friend WithEvents TxtSegundoNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGTabla As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApellidoPaterno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtApellidoMaterno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents dtFechaNac As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents btnCandA As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents BtnX As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnReporte As Button
End Class
