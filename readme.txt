Descripción: Con el fin de resolver el presente ejercicio propuesto desarrolle una solución donde el front-end es un formulario de C# con WinForms , el back-end de compone de una solución SSIS por medio de la cual se lee el archivo y carga a la BD, en cuanto a la BD por medio de un JOB se llama a el archivo que contiene la solución SSIS, se agrega una opcion de consulta para ver la informacion cargada dentro de la aplicacion.

/***** DESPLIEGUE *****/

1) Necesitara crear las siguientes carpetas en la unidad C de su equipo, para lo cual puede ejecutar el archivo crearcarpetas.bat o digitar los siguientes comandos desde cmd.

MD C:\ArchivosTrabajados
MD C:\CargaArchivo
MD C:\DTSX
MD C:\log

2) En la herramienta MSMS deberá ejecutar los script .sql, para el SC 02 verificar que el servicio SLQ Server Agent se esté ejecutando en su servidor.

01.Creacion BD 
02.Crear Job.sql

3) En la carpeta DTSX debe pegar el archivo "CargaArchivos.dtsx"

4) Descargar el proyecto .zip desde GIT https://github.com/ncuadradola/CargaCSV, posterior a esto descomprimir la carpeta descargada.

5) Abrir el proyecto con VS, posterior a esto debe importar las librerías que están en la carpeta Dll_Krypton.

5) En el cs del Form1 debe cambiar la cadena de conexión en el DataSource debe remplazar "TEC-001" por el nombre de su máquina y para esta prueba debe cambiar el Pass del usuario SA por "123456"

/***** FUNCIONAMIENTO *****/
Nota: el separador de los archivos CSV debe ser (;)

1) En la ruta C:\CargaArchivo debe pegar los archivos que desea procesar, estos serán cargados por medio de la solución a la base de datos contactos de su servidor SQL.

2) Una vez finalizada la importación la herramienta le mostrar el siguiente mensaje Importe finalizado a base de datos.

3) Los archivos se eliminarán de esta carpeta al finalizar el proceso y los encontrara en la ruta C:\ArchivosTrabajados al final del nombre de los archivos encontrara la fecha y hora en que estos fueron cargados.

4) Consulta: debe escribir el nombre del archivo tal cual como se cargó, en la caja de texto que encontrará en la aplicación, una vez escrito el nombre debe hacer clic sobre el botón buscar y será mostrada en pantalla la información que se procesó.

Nota: En caso de cargar un archivo con él un nombre similar a uno ya procesado la información será eliminada y cargada nuevamente.


