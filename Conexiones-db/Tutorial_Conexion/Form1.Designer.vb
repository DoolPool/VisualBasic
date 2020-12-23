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
        Me.BtnConAccess = New System.Windows.Forms.Button()
        Me.BtnConMySQL = New System.Windows.Forms.Button()
        Me.BtnConSQLite = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnConAccess
        '
        Me.BtnConAccess.Location = New System.Drawing.Point(82, 51)
        Me.BtnConAccess.Name = "BtnConAccess"
        Me.BtnConAccess.Size = New System.Drawing.Size(116, 23)
        Me.BtnConAccess.TabIndex = 0
        Me.BtnConAccess.Text = "Conectar Access"
        Me.BtnConAccess.UseVisualStyleBackColor = True
        '
        'BtnConMySQL
        '
        Me.BtnConMySQL.Location = New System.Drawing.Point(82, 102)
        Me.BtnConMySQL.Name = "BtnConMySQL"
        Me.BtnConMySQL.Size = New System.Drawing.Size(116, 23)
        Me.BtnConMySQL.TabIndex = 1
        Me.BtnConMySQL.Text = "Conectar MySQL"
        Me.BtnConMySQL.UseVisualStyleBackColor = True
        '
        'BtnConSQLite
        '
        Me.BtnConSQLite.Location = New System.Drawing.Point(82, 148)
        Me.BtnConSQLite.Name = "BtnConSQLite"
        Me.BtnConSQLite.Size = New System.Drawing.Size(116, 23)
        Me.BtnConSQLite.TabIndex = 2
        Me.BtnConSQLite.Text = "Conectar SQLite"
        Me.BtnConSQLite.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tutorial de Conexión por Edward Gómez"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConSQLite)
        Me.Controls.Add(Me.BtnConMySQL)
        Me.Controls.Add(Me.BtnConAccess)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorial Conexión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnConAccess As Button
    Friend WithEvents BtnConMySQL As Button
    Friend WithEvents BtnConSQLite As Button
    Friend WithEvents Label1 As Label
End Class
