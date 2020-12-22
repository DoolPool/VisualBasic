<p align="center">
  <a href="https://doolpool.com" target="_blank" rel="noopener noreferrer">
    <img width="100" src="https://doolpool.github.io/DoolPool/imggg.png" alt="DoolPool logo">
  </a>
</p>
<h1 align="center">DoolPool, Inc.</h1>
<h3 align="center">Hello 👋, we are DoolPool, frontend and backend developers located in Peru.</h3>
<hr>

# Crud - Alumnos

<p style="text-align:justify;">Continuando el tema anterior de las conexiones pasamos a un tema donde varios usuarios que empiezan en el mundo de la programación les cuesta comprender y como todos hemos pasado por esto que mejor forma que devolver a la comunidad lo que se ha recibido de esta misma.</p>
<p style="text-align:justify;">Por tal motivo quiero compartir una clase creada dentro de un modulo que nos facilitara mucho las cosas, la verdad es que la hice lo mas sencilla posible que me resultara para mis propósitos, cada quien la puede adaptar a sus necesidades espero les sea de utilidad.</p>
<p style="text-align:justify;">Bueno manos a la obra&#8230;</p>
<p style="text-align:justify;">Para comenzar ya tengo creado un nuevo proyecto que he llamado &#8220;Tutorial_CRUD&#8221;, el cual contiene un formulario y este a su vez contiene los siguientes controles:</p>
<ul>
<li>5 Botones que he nombrado así:
<ul>
<li>Name: BtnConexion &#8211; Text: Conexión</li>
<li>Name: BtnLeer &#8211; Text: Leer</li>
<li>Name: BtnAgregar &#8211; Text: Agregar</li>
<li>Name: BtnActualizar &#8211; Text: Actualizar</li>
<li>Name: BtnEliminar &#8211; Text: Eliminar</li>
</ul>
</li>
<li>3 Cajas de texto que he nombrado así:
<ul>
<li>Name: TxtId</li>
<li>Name: TxtNombres</li>
<li>Name: TxtApellidos</li>
</ul>
</li>
<li>3 Labels que les asigne los siguientes textos así:
<ul>
<li>Label1.text = Id</li>
<li>Label2.text= Nombres</li>
<li>Label3.text= Apellidos</li>
</ul>
</li>
<li>1 Datagridview que he nombrado así:
<ul>
<li>Name: DGTabla</li>
</ul>
</li>
</ul>
<p>Una vez terminado nuestro formulario debe tener una apariencia como la siguiente:</p>
<p><img loading="lazy" data-attachment-id="292" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/04/clase-sencilla-para-agregar-leer-actualizar-y-eliminar-datos-en-access-mysql-y-sqlite-con-visual-basic-net/sshot-1-3/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-13.png" data-orig-size="416,426" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-1" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-13.png?w=293" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-13.png?w=416" class="size-medium wp-image-292 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-13.png?w=293&#038;h=300" alt="sshot-1" width="293" height="300" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-13.png?w=293&amp;h=300 293w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-13.png?w=146&amp;h=150 146w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-13.png 416w" sizes="(max-width: 293px) 100vw, 293px" /></p>
<p style="text-align:justify;">Paso seguido terminada la parte de agregar los controles necesarios para nuestro ejemplo, lo siguiente que necesitamos es agregar un nuevo modulo a nuestro proyecto que llamaremos &#8220;CRUD&#8221;, esto lo hacemos dando clic derecho en el explorador de soluciones a nuestro proyecto y nos ubicamos sobre el menú agregar para seleccionar la opción &#8220;Modulo&#8221; tal como se muestra en la siguiente imagen.</p>
<p style="text-align:justify;"><img loading="lazy" data-attachment-id="295" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/04/clase-sencilla-para-agregar-leer-actualizar-y-eliminar-datos-en-access-mysql-y-sqlite-con-visual-basic-net/sshot-2-3/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-22.png" data-orig-size="1020,663" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-2" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-22.png?w=300" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-22.png?w=616" class="aligncenter wp-image-295 size-large" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-22.png?w=616&#038;h=400" alt="sshot-2" width="616" height="400" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-22.png?w=616&amp;h=400 616w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-22.png?w=150&amp;h=98 150w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-22.png?w=300&amp;h=195 300w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-22.png?w=768&amp;h=499 768w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-22.png 1020w" sizes="(max-width: 616px) 100vw, 616px" /></p>
<p style="text-align:justify;">Ahora que hemos creado nuestro modulo &#8220;CRUD&#8221; procedemos abrirlo dando doble clic y borramos todo lo que ahi en el momento que solo es &#8220;Module CRUD End Module&#8221;, para proceder a crear los procedimientos necesarios para realizar las operaciones propuestas en este ejemplo, lo pimero que debemos hacer es identificar nuestra base de datos que para nuestro ejemplo es Access 2003 y que he creado en una carpeta en la ruta &#8220;C:\Tutorial_CRUD&#8221;  y la base la he nombrado &#8220;Datos.mdb&#8221; sin contraseña, nuestra ruta completa es la siguiente &#8220;C:\Tutorial_CRUD\Datos.mdb&#8221;, ahora lo que sigue es ubicar nuestra cadena de conexión en la siguiente pagina:</p>
<p style="text-align:center;"><a href="https://www.connectionstrings.com/" target="_blank">https://www.connectionstrings.com/</a></p>
<p style="text-align:justify;">Paso seguido debemos importar la libreria que nos permita manipular este tipo procedimientos la cual es &#8220;System.Data.Oledb&#8221;, lo hacemos al inicio del modulo de la siguiente forma:</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Importamos la libreria Oledb
Imports System.Data.OleDb
</pre>
<p style="text-align:justify;">Ahora que ya hemos importado correctamente nuestra librería procedemos a declarar la clase que almacenara nuestros procedimientos, el nombre que le demos a nuestra clase sera el mismo que usaremos para declararla mas adelante y la declaramos así:</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Declaramos nuestra clase de nombre CRUD
Public Class CRUD

End Class
</pre>
<p style="text-align:justify;">Terminado de declarar nuestra clase procedemos a crear la conexión a nuestra base de datos para tener acceso a la misma y realizar todos los procedimientos que sean necesario, la conexión la creamos mediante el objeto &#8220;OleDbConnection&#8221; de la librería &#8220;OleDb&#8221; al cual le asignamos nuestra cadena de conexión y lo hacemos de la siguiente forma:</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Creamos nuestra conexión a la base de Datos
Dim con As New OleDbConnection(&quot;Provider=Microsoft.Jet.OleDb.4.0; Data Source=C:\Tutorial_CRUD\Datos.mdb&quot;)
</pre>
<p style="text-align:justify;">El primer procedimiento que vamos a crear sera el que nos realice la prueba de la conexión a la base de datos y nos muestre si tenemos una conexión exitosa, para realizar este proceso utilizaremos la instrucción &#8220;Try&#8221; y declaramos nuestro nuevo procedimiento que llamaremos &#8220;conexión&#8221; de la siguiente forma:</p>
<pre class="brush: vb; title: ; notranslate" title="">
Sub conexion()
       ':::Instruccion Try para capturar errores
       Try
          ':::Abrimos nuestro conexion con la propiedad Open
          con.Open()
          MsgBox(&quot;Conexión realizada de manera exitosa&quot;, MsgBoxStyle.Information, &quot;Tutorial CRUD&quot;)
          ':::Y cerramos la conexion
          con.Close()
       Catch ex As Exception
          MsgBox(&quot;No se logro realizar la conexión debido: &quot; &amp; ex.Message, MsgBoxStyle.Critical, &quot;Tutorial CRUD&quot;)
       End Try
End Sub
</pre>
<p style="text-align:justify;">Ahora que ya tenemos nuestra conexión creada y hemos probado que se establece correctamente el siguiente procedimiento que crearemos sera para realizar consultas a nuestra base de datos, este procedimiento lo llamaremos &#8220;consulta&#8221; y tendrá los siguientes objetos:</p>
<ul>
<li style="text-align:justify;"><strong>OleDbDataAdapter</strong>: Nos permite crear una conexión entre la solicitud que realiza el usuario a la base y la respuesta que se obtiene de la base de datos, este objeto tiene la ventaja que no se necesita abrir primero la conexión a la base de datos debido a que es te objeto abre y cierra automáticamente la conexión una vez termina el proceso. Así mismo para que cumpla su función correctamente este objeto necesita que le pasemos dos parámetros muy importantes que son, el primero la instrucción que debe realizar y el segundo la conexión a la que debe realizar esa instrucción.</li>
<li style="text-align:justify;"><strong>DataTable</strong>: Este objeto sera la tabla donde se almacenaran los datos que reciba el &#8220;DataAdapter&#8221; por parte de la base de datos.</li>
</ul>
<p style="text-align:justify;">Hasta ahora hemos visto los dos objetos que necesitamos para realizar nuestro procedimiento pero también debemos mostrar el resultado en alguna forma y lo haremos mediante un &#8220;DataGridView&#8221; que ya hemos defino anteriormente.</p>
<p style="text-align:justify;">Para que nuestro proceso funcione correctamente debemos darle dos parámetros también los cuales serian, el primero seria el &#8220;DataGridView&#8221; donde mostraremos los resultados y el segundo la instrucción que necesita el &#8220;DataAdapter&#8221;, para esto al momento de crear nuestro procedimiento le indicaremos que debe solicitar mediante la propiedad &#8220;ByVal&#8221; estos dos parámetros, tal cual como se muestra a continuación:</p>
<pre class="brush: vb; title: ; notranslate" title="">
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
        MsgBox(&quot;No se logro realizar la consulta por: &quot; &amp; ex.Message, MsgBoxStyle.Critical,&quot;Tutorial CRUD&quot;)
     End Try
End Sub
</pre>
<p>Ahora ya podemos realizar consultas a nuestra base de datos, también podemos obtener una respuesta y ademas mostrar este resultado de manera ordenada.</p>
<p style="text-align:justify;">Continuamos, seguido crearemos un procedimiento que nos permita &#8220;Agregar, Actualizar y Eliminar&#8221; sin tener que crear procedimientos por separado para cada operación, para esto lo primero es crear el proceso con el nombre de &#8220;operaciones&#8221; el cual va a contener el siguiente objeto:</p>
<ul>
<li style="text-align:justify;"><strong>OleDbCommand</strong>: El cual almacenara la instrucción para la operación que se va a realizar, este objeto necesita también de dos (2) parámetros, el primero la instrucción que debe realizar y el segundo la conexión a la que debe realizar esa instrucción. A diferencia del objeto anterior (DataAdapter) el &#8220;Command&#8221; necesita que abramos y cerremos la conexión debido a que el no lo hace automáticamente.
<ul>
<li style="text-align:justify;"><strong>ExecuteNonQuery</strong>: Es una propiedad del objeto &#8220;Command&#8221; y su función es ejecutar la instrucción que se ha recibido.</li>
</ul>
</li>
</ul>
<p>Una vez teniendo claro estos conceptos nuestro procedimiento debe quedar así:</p>
<pre class="brush: vb; title: ; notranslate" title="">
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
       MsgBox(&quot;No se logro realizar la operación por: &quot; &amp; ex.Message, MsgBoxStyle.Critical, &quot;Tutorial CRUD&quot;)
    End Try
    ':::Cerramos la conexion
    con.Close()
End Sub
</pre>
<p>&nbsp;</p>
<p style="text-align:justify;">Y con esto hemos terminado la creación de nuestra clase para las operaciones CRUD, pero todavía no estamos haciendo ninguna operación recordemos que los procedimientos están a la espera de que se les de una instrucción para saber que deben hacer, para esto cerramos nuestro modulo ya que no lo vamos a utilizar y nos ubicamos en el formulario, comenzaremos con el primer botón que hemos creado y le dimos el texto &#8220;Conexión&#8221; damos doble clic en el botón para configurar.</p>
<p style="text-align:justify;">Seguido lo primero que debemos hacer es crear un objeto que nos comunique con nuestra clase que para recordar hemos llamado &#8220;CRUD&#8221;, este objeto debe ser declarado de manera global para no tener que estar repitiendo este proceso, esto lo haremos justo debajo de donde se inicia la clase del formulario.</p>
<p style="text-align:justify;">Una vez creado nuestro objeto solo necesitamos llamar al procedimiento que nombramos &#8220;conexion&#8221; de la siguiente forma:</p>
<pre class="brush: vb; title: ; notranslate" title="">
Public Class Form1
 ':::Creamos un objeto para establecer conexion con nuestra clase CRUD
Dim Obj As New CRUD

Private Sub BtnConexion_Click(sender As Object, e As EventArgs) Handles BtnConexion.Click
    ':::Mediante el objeto que creamos accedemos al procedimiento &quot;conexion&quot;
    Obj.conexion()
End Sub
End Class
</pre>
<p>Ejecutamos nuestro proyecto y damos clic en le botón &#8220;Conexión&#8221; y como vemos nos indica que la conexión fue exitosa.</p>
<p><img data-attachment-id="434" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/04/clase-sencilla-para-agregar-leer-actualizar-y-eliminar-datos-en-access-mysql-y-sqlite-con-visual-basic-net/sshot-3-3/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-32.png" data-orig-size="416,426" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-3" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-32.png?w=293" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-32.png?w=416" class=" size-full wp-image-434 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-32.png?w=616" alt="sshot-3" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-32.png 416w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-32.png?w=146 146w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-32.png?w=293 293w" sizes="(max-width: 416px) 100vw, 416px"   /></p>
<p style="text-align:justify;">Como ya probamos nuestra conexión a la base de datos seguimos con el siguiente botón que le hemos dado como texto &#8220;Leer&#8221; y damos doble clic para configurar. Ahora en la configuración del botón lo primero que debemos hacer es crear una variable de tipo &#8220;string&#8221; que para mayor facilidad la llamaremos &#8220;Sql&#8221; y que sera la encargada de guardar la instrucción que le asignaremos, dicha instrucción es una consulta SQL a nuestra base de datos que tiene una sola tabla y tres (3) campos.</p>
<figure data-shortcode="caption" id="attachment_443" aria-describedby="caption-attachment-443" style="width: 641px" class="wp-caption aligncenter"><img data-attachment-id="443" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/04/clase-sencilla-para-agregar-leer-actualizar-y-eliminar-datos-en-access-mysql-y-sqlite-con-visual-basic-net/sshot-4-3/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-42.png" data-orig-size="641,171" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-4" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-42.png?w=300" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-42.png?w=616" class=" size-full wp-image-443 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-42.png?w=616" alt="sshot-4" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-42.png?w=616 616w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-42.png?w=150 150w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-42.png?w=300 300w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-42.png 641w" sizes="(max-width: 616px) 100vw, 616px"   /><figcaption id="caption-attachment-443" class="wp-caption-text">Base de Datos en Access 2003</figcaption></figure>
<p style="text-align:justify;">La instrucción SQL que utilizaremos sera &#8220;Select * from Clientes&#8221; para que nos traiga de la base datos todos los registros que tiene la tabla &#8220;Clientes&#8221; que para nuestro ejemplo solo sera un (1) registro, recordemos que debemos usar el objeto que hemos creado de manera global para acceder al procedimiento &#8220;consulta&#8221; de nuestra clase &#8220;CRUD&#8221; y que dicho procedimiento nos va a pedir dos (2) parámetros, el primero sera el nombre del &#8220;DataGridView&#8221; donde nos mostrara el resultado y el segundo que es la instrucción que hemos almacenado en la variable que acabamos de crear, el código para el botón &#8220;Leer&#8221; nos debe quedar así.</p>
<pre class="brush: vb; title: ; notranslate" title="">
Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles BtnLeer.Click
   ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
   Dim Sql As String = &quot;Select * from Clientes&quot;
   ':::Mediante el objeto que creamos globalmente y nombramos &quot;Obj&quot;
   ':::Accedemos a nuestro procedimiento &quot;consulta&quot; y le pasamos los
   ':::dos (2) parametros (DGTabla, Sql)
   Obj.consulta(DGTabla, Sql)
End Sub
</pre>
<p style="text-align:justify;">Como vemos la clase funciona correctamente, esta solicitando los parámetros, los esta recibiendo y esta retornando un resultado de forma ordenada.</p>
<p><img data-attachment-id="459" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/04/clase-sencilla-para-agregar-leer-actualizar-y-eliminar-datos-en-access-mysql-y-sqlite-con-visual-basic-net/sshot-5-3/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-52.png" data-orig-size="416,426" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-5" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-52.png?w=293" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-52.png?w=416" class=" size-full wp-image-459 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-52.png?w=616" alt="sshot-5" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-52.png 416w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-52.png?w=146 146w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-52.png?w=293 293w" sizes="(max-width: 416px) 100vw, 416px"   /></p>
<p style="text-align:justify;">Seguimos con el siguiente botón que hemos le hemos dado el texto &#8220;Agregar&#8221;, repetimos los mismos pasos que en el botón &#8220;Leer&#8221;, en lo único que modificaremos sera en la consulta SQL y el nombre del procedimiento que en este caso es &#8220;operaciones&#8221; y nos debe quedar así.</p>
<pre class="brush: vb; title: ; notranslate" title="">
Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
    ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
    Dim Sql As String = &quot;Insert Into Clientes (Id, Nombres, Apellidos) Select &quot;&amp; TxtId.Text &amp;&quot;, '&quot;&amp; TxtNombres.Text  &amp;&quot;', '&quot;&amp; TxtApellidos.Text &amp;&quot;'&quot;
    ':::Cambiamos el nombre del procedimiento &quot;operaciones&quot;
    Obj.operaciones(DGTabla, Sql)
End Sub
</pre>
<p style="text-align:justify;">Ahora realizamos una prueba con los siguientes datos:</p>
<ul>
<li style="text-align:justify;">Id= 2</li>
<li style="text-align:justify;">Nombres= Maria</li>
<li style="text-align:justify;">Apellidos= Morales</li>
</ul>
<p style="text-align:justify;">Damos clic en el botón &#8220;Agregar&#8221; y luego en el botón &#8220;Leer&#8221;, Como vemos la clase funciona correctamente, esta solicitando los parámetros, los esta recibiendo y esta ejecutando la instrucción que le hemos dado.</p>
<p style="text-align:justify;"><img data-attachment-id="480" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/04/clase-sencilla-para-agregar-leer-actualizar-y-eliminar-datos-en-access-mysql-y-sqlite-con-visual-basic-net/sshot-6/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-6.png" data-orig-size="416,426" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-6" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-6.png?w=293" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-6.png?w=416" class=" size-full wp-image-480 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-6.png?w=616" alt="sshot-6" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-6.png 416w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-6.png?w=146 146w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-6.png?w=293 293w" sizes="(max-width: 416px) 100vw, 416px"   /></p>
<p style="text-align:justify;">Continuamos con el siguiente botón que hemos dado de texto &#8220;Actualizar&#8221;, repetimos los mismos pasos que en el botón &#8220;Agregar&#8221;, en lo único que modificaremos sera en la consulta SQL y el nombre del procedimiento sera el mismo &#8220;operaciones&#8221; y nos debe quedar así.</p>
<pre class="brush: vb; title: ; notranslate" title="">
Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
    ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
    Dim Sql As String = &quot;Update Clientes Set Nombres='&quot;&amp; TxtNombres.Text &amp;&quot;', Apellidos='&quot;&amp; TxtApellidos.Text &amp;&quot;' where Id=&quot;&amp; TxtId.Text &amp;&quot;&quot;
    Obj.operaciones(DGTabla, Sql)
End Sub
</pre>
<p style="text-align:justify;">Ahora realizamos una prueba con los siguientes datos:</p>
<ul>
<li style="text-align:justify;">Id= 2</li>
<li style="text-align:justify;">Nombres= Ana</li>
<li style="text-align:justify;">Apellidos= Rosado</li>
</ul>
<p style="text-align:justify;">Damos clic en el botón &#8220;Actualizar&#8221; y luego en el botón &#8220;Leer&#8221;, Como vemos la clase funciona correctamente, esta solicitando los parámetros, los esta recibiendo y esta ejecutando la instrucción que le hemos dado.</p>
<p style="text-align:justify;"><img data-attachment-id="488" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/04/clase-sencilla-para-agregar-leer-actualizar-y-eliminar-datos-en-access-mysql-y-sqlite-con-visual-basic-net/sshot-7/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-7.png" data-orig-size="416,426" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-7" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-7.png?w=293" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-7.png?w=416" class=" size-full wp-image-488 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-7.png?w=616" alt="sshot-7" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-7.png 416w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-7.png?w=146 146w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-7.png?w=293 293w" sizes="(max-width: 416px) 100vw, 416px"   /></p>
<p style="text-align:justify;">Por ultimo terminamos con el botón que hemos dado de texto &#8220;Eliminar&#8221;, repetimos los mismos pasos que en el botón &#8220;Agregar&#8221;, en lo único que modificaremos sera en la consulta SQL y el nombre del procedimiento sera el mismo &#8220;operaciones&#8221; y nos debe quedar así.</p>
<pre class="brush: vb; title: ; notranslate" title="">
Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
   ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
   Dim Sql As String = &quot;Delete * From Clientes Where Id=&quot;&amp; TxtId.Text &amp;&quot;&quot;
   Obj.operaciones(DGTabla, Sql)
End Sub
</pre>
<p style="text-align:justify;">Ahora realizamos una prueba con los siguientes datos:</p>
<ul>
<li style="text-align:justify;">Id= 2</li>
</ul>
<p style="text-align:justify;">Damos clic en el botón &#8220;Eliminar&#8221; y luego en el botón &#8220;Leer&#8221;, Como vemos la clase funciona correctamente, esta solicitando los parámetros, los esta recibiendo y esta ejecutando la instrucción que le hemos dado.</p>
<p style="text-align:justify;"><img data-attachment-id="500" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/04/clase-sencilla-para-agregar-leer-actualizar-y-eliminar-datos-en-access-mysql-y-sqlite-con-visual-basic-net/sshot-8/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-8.png" data-orig-size="416,426" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-8" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-8.png?w=293" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-8.png?w=416" class=" size-full wp-image-500 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-8.png?w=616" alt="sshot-8" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-8.png 416w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-8.png?w=146 146w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-8.png?w=293 293w" sizes="(max-width: 416px) 100vw, 416px"   /></p>
<hr />
<p style="text-align:justify;">Con esto hemos terminado este tutorial que se ha extendido un poco, pero la idea es explicar en detalle el funcionamiento de esta clase, que como apreciamos solo necesitamos de dos (2) lineas de código para realizar las operaciones &#8220;CRUD&#8221;, la ventaja de trabajar con esta clase viene en los proyectos donde trabajaremos con una base de datos con varias tablas y necesitaremos realizar estas mismas operaciones una y otra vez, para lo cual solo seguiremos necesitando las mismas dos (2) lineas de código ahorrándonos tiempo y trabajo. También es importante destacar que la clase funciona correctamente independientemente de la base de datos que usemos, solo basta con modificar la cadena de conexión.</p>
<p style="text-align:justify;">En este ejemplo utilizamos una base de datos en Access, pero para SQLite y MySQL solo basta con cambiar las librerías y los objetos tal como lo muestro ahora:</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Para SQLite importamos la libreria correspondiente
Imports System.Data.SQLite
':::Para MySQL importamos la libreria correspondiente
Imports MySql.Data.MySqlClient

'________________________________________________________________

':::Para el objeto de conexion usamos el objeto segun corresponda
':::SQLite conexion
Dim con as new SQLiteConnection

':::MySQL conexion
Dim con as new MySqlConnection

'_______________________________________________________________

':::Lo mismo con los otros objetos
':::SQLite
Dim Da as new SQLiteDataAdapter
Dim cmd as new SQLiteCommand

':::MySQL
Dim Da as new MySqlDataAdapter
Dim cmd as new MySqlCommand
</pre>
<p style="text-align:justify;">El proyecto y la base de datos usada para este ejemplo los dejo en &#8220;Mega&#8221; para que lo descarguen y estudien, lo puede encontrar en el siguiente link.</p>
<p style="text-align:center;"><a href="https://goo.gl/r18JJL" target="_blank">https://goo.gl/r18JJL</a></p>
<p style="text-align:justify;">Les dejo también el link al post donde les explico las conexiones a diferentes bases de datos.</p>
<p style="text-align:center;"><a href="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/">Conexión entre Visual Basic .Net y Access, MySQL y SQLite</a></p>
<p style="text-align:justify;">Cualquier duda estaré presto a colaborarles en todo lo que me este posible.</p>
<p style="text-align:justify;">Buen día para todos.</p>

<hr> 
<p align="center">
   <a alt="play doolpool" href="https://doolpool.com/play">Play DoolPool</a>
 • <a alt="red doolpool" href="https://doolpool.com/red/">Red DoolPool</a>
 • <a alt="music doolpool" href="https://doolpool.com/music">Music DoolPool</a>
</p> 
<p align="center"> © 2018-2020 DoolPool Inc. <br>All right reserved in <a href="https://doolpool.com/docs/">Documentation</a>.</p>
           
<p align="center">
  <a href="https://twitter.com/dool_pool" target="blank">
    <img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/twitter.svg" alt="dool_pool" height="15" width="15" />
  </a>
  <a href="https://fb.com/doolpool.company" target="blank">
    <img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/facebook.svg" alt="doolpool.company" height="15" width="15" />
  </a>
  <a href="https://instagram.com/doolpool.company" target="blank">
    <img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/instagram.svg" alt="doolpool.company" height="15" width="15" />
  </a>
  <a href="https://www.youtube.com/channel/uc1jwir5d3pgcdaxb2brdh3w" target="blank"> 
    <img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/youtube.svg" alt="https://www.youtube.com/channel/uc1jwir5d3pgcdaxb2brdh3w" height="15" width="15" />
  </a>
</p>

<!--**DoolPool, Inc**-->
