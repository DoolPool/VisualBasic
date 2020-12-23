<p align="center">
  <a href="https://doolpool.com" target="_blank" rel="noopener noreferrer">
    <img width="100" src="https://doolpool.github.io/DoolPool/imggg.png" alt="DoolPool logo">
  </a>
</p>
<h1 align="center">DoolPool, Inc.</h1>
<h3 align="center">Hello 👋, we are DoolPool, frontend and backend developers located in Peru.</h3>
<hr>

# Conexión entre Visual Basic .Net y Access, MySQL y SQLite

<p style="text-align:justify;">En esta que es mi primera publicación del blog quiero empezar por compartir con ustedes un tema bien importante como es el de la conexión entre nuestra aplicación y nuestra base de datos, debido a que de ello depende la funcionalidad de nuestro programa.</p>
<p style="text-align:justify;">Para comenzar debemos tener presente que para conectarnos es necesario conocer la cadena de conexión según nuestra base de datos esta misma cambiara, esta cadena de conexión la podemos encontrar en la siguiente pagina.</p>
<p><span id="more-46"></span></p>
<p style="text-align:center;"><a href="https://www.connectionstrings.com/" target="_blank">https://www.connectionstrings.com/</a></p>
<p style="text-align:justify;">Bueno para empezar ya he creado un nuevo proyecto que he llamado Tutorial_Conexion y en el formulario he agregado tres (3) botones con los textos.</p>
<ul>
<li style="text-align:justify;">Conectar Access</li>
<li style="text-align:justify;">Conectar MySQL</li>
<li style="text-align:justify;">Conectar SQLite</li>
</ul>
<p style="text-align:justify;"><img data-attachment-id="73" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/sshot-1/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-1.png" data-orig-size="370,377" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-1" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-1.png?w=294" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-1.png?w=370" class="size-full wp-image-73 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-1.png?w=616" alt="sshot-1" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-1.png 370w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-1.png?w=147 147w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-1.png?w=294 294w" sizes="(max-width: 370px) 100vw, 370px"   /></p>
<hr />
<p style="text-align:center;"><strong>Conexión Access</strong></p>
<p style="text-align:center;"><img loading="lazy" data-attachment-id="115" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/access/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/access.jpg" data-orig-size="506,196" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="access" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/access.jpg?w=300" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/access.jpg?w=506" class="alignnone size-medium wp-image-115" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/access.jpg?w=300&#038;h=116" alt="access" width="300" height="116" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/access.jpg?w=300&amp;h=116 300w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/access.jpg?w=150&amp;h=58 150w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/access.jpg 506w" sizes="(max-width: 300px) 100vw, 300px" /></p>
<p style="text-align:justify;">Ahora la primera conexión que miraremos sera la de Access para lo cual deben tener presente la versión de Access y si la base tiene contraseña o no. Una vez que han determinado estas opciones y con la cadena de conexión seleccionada, es muy importante identificar en la cadena de conexión el apartado donde dice &#8220;Data Source&#8221; debido a que en esta parte debe ir la ruta donde tenemos guardada nuestra base de datos, para el ejemplo he creado una base en Access 2003 llamada Datos.mdb y la guarde el la ruta (C:\) para hacer mas sencillo el ejemplo no le he puesto contraseña ahora  mi cadena de conexión seria:</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Cadena de conexión para Access 2003 sin password
Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Datos.mdb
</pre>
<p style="text-align:justify;">El siguiente paso sera agregar la librería Oledb mediante el imports</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Importamos la libreria necesaria para nuestra conexión
Imports System.Data.Oledb
</pre>
<p style="text-align:justify;">Continuamos, ahora daremos doble clic en el boton &#8220;Conectar Access&#8221; para acceder a su función, aca debemos crear un nuevo objeto de la libreria Oledb de tipo OledbConnetion, el cual es el encargado de tomar la ruta donde tenemos nuestra base de datos y realizar la correspondiente conexión entre nuestro programa y la base de datos.</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Ahora creamos un objeto de nombre &quot;con&quot; de tipo OledbConnetion
':::Y le asignamos nuestra cadena de conexión y la ruta de nuestra base de datos
Dim con As New OleDbConnection(&quot;Provider=Microsoft.Jet.Oledb.4.0; Data Source=C:\Datos.mdb&quot;)
</pre>
<p style="text-align:justify;">Para evaluar si tenemos un posible error en nuestra conexión utilizaremos la instrucción &#8220;Try&#8221; para capturar este posible error quedando nuestro código así:</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Libreria importada
Imports System.Data.OleDb
Public Class Form1
    Private Sub BtnConAccess_Click(sender As Object, e As EventArgs) Handles BtnConAccess.Click
      ':::Nuestro objeto OleDbConnetion con la cadena de conexión y la ruta de la base
      Dim con As New OleDbConnection(&quot;Provider=Microsoft.Jet.Oledb.4.0; Data Source=C:\Datos.mdb&quot;)
        ':::Utilizamos el try para capturar posibles errores
        Try
           ':::Abrimos la conexión
           con.Open()
           ':::Si se estableció conexión correctamente dirá &quot;Conectado&quot;
           MsgBox(&quot;Conectado&quot;)
        Catch ex As Exception
          ':::Si no se conecta nos mostrara el posible fallo en la conexión
          MsgBox(&quot;No se conecto por: &quot; &amp; ex.Message)
        End Try
End Sub
End Class
</pre>
<p style="text-align:justify;">Como vemos la conexión se realizó correctamente.</p>
<p><img data-attachment-id="110" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/sshot-2/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-2.png" data-orig-size="370,377" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-2" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-2.png?w=294" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-2.png?w=370" class="size-full wp-image-110 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-2.png?w=616" alt="sshot-2" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-2.png 370w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-2.png?w=147 147w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-2.png?w=294 294w" sizes="(max-width: 370px) 100vw, 370px"   /></p>
<p>&nbsp;</p>
<hr />
<p style="text-align:center;"><strong>Conexión MySQL</strong></p>
<p style="text-align:center;"><img loading="lazy" data-attachment-id="119" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/mysql-svg/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/mysql-svg.png" data-orig-size="640,331" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="mysql-svg" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/mysql-svg.png?w=300" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/mysql-svg.png?w=616" class="alignnone size-medium wp-image-119" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/mysql-svg.png?w=300&#038;h=155" alt="mysql-svg" width="300" height="155" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/mysql-svg.png?w=300&amp;h=155 300w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/mysql-svg.png?w=600&amp;h=310 600w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/mysql-svg.png?w=150&amp;h=78 150w" sizes="(max-width: 300px) 100vw, 300px" /></p>
<p style="text-align:justify;">Continuamos ahora con la base de datos MySQL, para lo cual repetiremos los pasos anteriores tal cual .</p>
<p style="text-align:justify;">Para seguir debemos agregar las referencias de MySQL y SQLite que necesitaremos mas adelante, para lo cual vamos al explorador de proyectos y damos clic derecho sobre el proyecto y buscamos la opción agregar y luego referencia.</p>
<p style="text-align:justify;"><img data-attachment-id="2156" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/sshot-1-18/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-114.png" data-orig-size="960,691" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-1" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-114.png?w=300" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-114.png?w=616" class=" size-full wp-image-2156 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-114.png?w=616" alt="sshot-1" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-114.png?w=616 616w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-114.png?w=150 150w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-114.png?w=300 300w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-114.png?w=768 768w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-114.png 960w" sizes="(max-width: 616px) 100vw, 616px"   /></p>
<p style="text-align:justify;">Y en buscamos en nuestra carpeta Debug del proyecto las dos librerías como se ve en la siguiente imagen.</p>
<p style="text-align:justify;"><img data-attachment-id="2157" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/sshot-2-17/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-213.png" data-orig-size="824,551" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-2" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-213.png?w=300" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-213.png?w=616" class=" size-full wp-image-2157 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-213.png?w=616" alt="sshot-2" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-213.png?w=616 616w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-213.png?w=150 150w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-213.png?w=300 300w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-213.png?w=768 768w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-213.png 824w" sizes="(max-width: 616px) 100vw, 616px"   /></p>
<p style="text-align:justify;">Comenzaremos por importar la librería MySql.Data.MySqlClient así:</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Importamos la librería necesaria para nuestra conexión
Imports MySql.Data.MySqlClient
</pre>
<p style="text-align:justify;">Una vez importada la librería crearemos nuestra cadena de conexión que previamente hemos buscado en la pagina sugerida anteriormente, nuestra conexión sera a la base de datos &#8220;test&#8221; instalada localmente que trae como ejemplo MySQL con el usuario por defecto &#8220;root&#8221; y contraseña &#8220;root&#8221; para mayor facilidad de nuestro ejemplo, nuestra cadena de conexión debe quedar así:</p>
<ul>
<li style="text-align:justify;"><strong>Server</strong>: Hace referencia al servidor como en nuestro caso es local podemos usar el nombre reservado &#8220;localhost&#8221; o la dirección &#8220;127.0.0.1&#8221; que cualquiera de las dos formas es valida.</li>
<li style="text-align:justify;"><strong>Database</strong>: Corresponde al nombre de nuestra base datos que para nuestro caso usaremos una instalada como ejemplo por MySQL llamada &#8220;test&#8221;.</li>
<li style="text-align:justify;"><strong>Uid</strong>: Corresponde al nombre de usuario que tenemos para acceder a la base de datos, usaremos el que trae por defecto MySQL &#8220;root&#8221;.</li>
<li style="text-align:justify;"><strong>Pwd</strong>: Corresponde a la contraseña o password para acceder a nuestra base de datos que para nuestro ejemplo es &#8220;root&#8221;.</li>
</ul>
<pre class="brush: vb; title: ; notranslate" title="">
':::Cadena de conexión para MySQL
&quot;Server=localhost; Database=test; Uid=root; Pwd=root&quot;
</pre>
<p style="text-align:justify;">Una vez que tenemos nuestra cadena de conexión continuamos creando un objeto de tipo MySqlConnetion y le asignamos nuestra cadena de conexión de la siguiente manera:</p>
<p style="text-align:justify;">-Cabe aclarar que el objeto de conexión no necesariamente debe llamarse &#8220;con&#8221;-</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Ahora creamos un objeto de nombre &quot;con&quot; de tipo MySqlConnetion
':::Y le asignamos nuestra cadena de conexión con la ruta de nuestra base de datos
Dim con As New MySqlConnection(&quot;Server=localhost; Database=test; Uid=root; Pwd=root&quot;)
</pre>
<p style="text-align:justify;">Nuevamente utilizaremos la instrucción &#8220;Try&#8221; para detectar cualquier posible error y el código nos quedara así:</p>
<pre class="brush: vb; title: ; notranslate" title="">
Imports MySql.Data.MySqlClient
Public Class Form1
  Private Sub BtnConMySQL_Click(sender As Object, e As EventArgs) Handles BtnConMySQL.Click
     ':::Nuestro objeto MySqlConnection con la cadena de conexión y la ruta de la base
     Dim con As New MySqlConnection(&quot;Server=localhost; Database=test; Uid=root; Pwd=root&quot;)
     ':::Utilizamos el try para capturar posibles errores
     Try
       ':::Abrimos la conexión
       con.Open()
       ':::Si se estableció conexión correctamente dirá &quot;Conectado&quot;
       MsgBox(&quot;Conectado&quot;)
     Catch ex As Exception
       ':::Si no se conecta nos mostrara el posible fallo en la conexión
       MsgBox(&quot;No se conecto por: &quot; &amp; ex.Message)
     End Try
End Sub
End Class
</pre>
<p style="text-align:justify;">Como vemos la conexión se realizó correctamente.</p>
<p><img data-attachment-id="185" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/sshot-3/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-3.png" data-orig-size="375,406" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-3" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-3.png?w=277" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-3.png?w=375" class="size-full wp-image-185 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-3.png?w=616" alt="sshot-3" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-3.png 375w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-3.png?w=139 139w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-3.png?w=277 277w" sizes="(max-width: 375px) 100vw, 375px"   /></p>
<hr />
<p style="text-align:center;"><strong>Conexión SQLite</strong></p>
<p><img loading="lazy" data-attachment-id="187" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/sqlite-183454_640/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sqlite-183454_640.png" data-orig-size="640,320" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sqlite-183454_640" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sqlite-183454_640.png?w=300" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sqlite-183454_640.png?w=616" class="size-medium wp-image-187 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sqlite-183454_640.png?w=300&#038;h=150" alt="sqlite-183454_640" width="300" height="150" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sqlite-183454_640.png?w=300&amp;h=150 300w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sqlite-183454_640.png?w=600&amp;h=300 600w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sqlite-183454_640.png?w=150&amp;h=75 150w" sizes="(max-width: 300px) 100vw, 300px" /></p>
<p style="text-align:justify;">Para terminar con este post emplearemos la base de datos SQLite, repetiremos los pasos anteriores para la búsqueda de la cadena de conexión en la pagina sugerida e iniciaremos por importar la librería  Imports System.Data.SQLite.</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Importamos la librería necesaria para nuestra conexión
Imports System.Data.SQLite
</pre>
<p style="text-align:justify;">Ahora que hemos importado nuestra librería para SQLite y tenemos nuestra cadena de conexión procedemos a crear nuevamente nuestro objeto pero esta vez de tipo SQLiteConnetion al igual que en la conexión de Access debemos identificar el apartado &#8220;Data Source&#8221; donde asignaremos la ruta donde se encuentra nuestra base de datos ahora hecho esto le asignaremos nuestra cadena de conexión de la siguiente manera:</p>
<p style="text-align:justify;">-Esta vez he creado una carpeta llamada &#8220;Prueba SqlLite&#8221; para guarda ahí la base de datos llamada &#8220;PruebaDB.db&#8221;, por lo cual la ruta de la base quedaría de la siguiente forma: &#8220;C:\Pueba SqlLite\PruebaDB.db&#8221;</p>
<pre class="brush: vb; title: ; notranslate" title="">
':::Ahora creamos un objeto de nombre &quot;con&quot; de tipo SQLiteConnetion
':::Y le asignamos nuestra cadena de conexión con la ruta de nuestra base de datos
Dim con As New SQLiteConnetion(&quot;Data Source=C:\Pueba SqlLite\PruebaDB.db; Version=3&quot;)
</pre>
<p style="text-align:justify;">Nuevamente utilizaremos la instrucción &#8220;Try&#8221; para detectar cualquier posible error y el código nos quedara así:</p>
<pre class="brush: vb; title: ; notranslate" title="">
Imports System.Data.SQLite
Public Class Form1
    Private Sub BtnConSQLite_Click(sender As Object, e As EventArgs) Handles BtnConSQLite.Click
      ':::Nuestro objeto SQLiteConnection con la cadena de conexión y la ruta de la base
      Dim con As New SQLiteConnection(&quot;Data Source=C:\Pueba SqlLite\PruebaDB.db; Version=3&quot;)
      ':::Utilizamos el try para capturar posibles errores
      Try
        ':::Abrimos la conexión
        con.Open()
        ':::Si se estableció conexión correctamente dirá &quot;Conectado&quot;
        MsgBox(&quot;Conectado&quot;)
      Catch ex As Exception
        ':::Si no se conecta nos mostrara el posible fallo en la conexión
        MsgBox(&quot;No se conecto por: &quot; &amp; ex.Message)
      End Try
End Sub
</pre>
<p style="text-align:justify;">Como vemos la conexión se realizó correctamente.</p>
<p><img data-attachment-id="230" data-permalink="https://aprendamosdeprogramacion.wordpress.com/2016/10/03/conexion-entre-visual-basic-net-y-access-mysql-y-sqlite/sshot-4/" data-orig-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-4.png" data-orig-size="375,449" data-comments-opened="1" data-image-meta="{&quot;aperture&quot;:&quot;0&quot;,&quot;credit&quot;:&quot;&quot;,&quot;camera&quot;:&quot;&quot;,&quot;caption&quot;:&quot;&quot;,&quot;created_timestamp&quot;:&quot;0&quot;,&quot;copyright&quot;:&quot;&quot;,&quot;focal_length&quot;:&quot;0&quot;,&quot;iso&quot;:&quot;0&quot;,&quot;shutter_speed&quot;:&quot;0&quot;,&quot;title&quot;:&quot;&quot;,&quot;orientation&quot;:&quot;0&quot;}" data-image-title="sshot-4" data-image-description="" data-medium-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-4.png?w=251" data-large-file="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-4.png?w=375" class="size-full wp-image-230 aligncenter" src="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-4.png?w=616" alt="sshot-4" srcset="https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-4.png 375w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-4.png?w=125 125w, https://aprendamosdeprogramacion.files.wordpress.com/2016/10/sshot-4.png?w=251 251w" sizes="(max-width: 375px) 100vw, 375px"   /></p>
<hr />

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
