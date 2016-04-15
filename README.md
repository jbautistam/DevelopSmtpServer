# DevelopSmtpServer

En muchas ocasiones tenemos que enviar correos electrónicos desde una aplicación pero mientras desarrollamos 
no deseamos que esos correos acaben llegando realmente a su destino.

Para evitarlo, existen los llamados Fake SMTP Server. Un servidor de este tipo, recibe los correos 
pero los almacena en un archivo en lugar de enviarlos al destinatario.

Eso nos permite comprobar que nuestra lógica de envío de correos es correcta pero no llena de correos de prueba
los buzones de nuestros clientes.

## Proyectos de la solución

La solución se divide en tres proyectos básicos:

  * LibSmtpServer: es la librería que realiza el control de conexiones y escribe los correos recibidos en un directorio.
  * DevelopSmtpServer: es una aplicación que puede utilizarse como consola o como servicio de Windows. Utiliza la librería anterior
para la lectura de los correos.
  * TestSmtpserver: es una aplicación WindowsForms para pruebas tanto de la consola como directamente de la librería

## Utilización de LibSmtpServer

Utilizar LibSmptServer en nuestras propias aplicaciones es muy sencillo. Simplemente inicializamos un objeto de servidor y 
llamamos al método Connect para que comience a escuchar los mensajes:

    // Crea el objeto de servidor
    SmtpServer objServer = new SmtpServer("C:\\Test\\", "127.0.0.1", 25);
    // Escucha los eventos de log
    objServer.ServerLog += (objSender, objEventArgs) => 
	                            { Console.WriteLine($"{objEventArgs.Action} --> {objEventArgs.Action}");
	                            }
    // Conecta al servidor
    objServer.Connect();
	
Al inicializar el objeto de servidor, además de la dirección IP y el puerto donde escucha los mensajes, debemos indicar el 
directorio donde se van a archivar los correos electrónicos.

Por último, cuando ya no necesitemos el servidor, lo desconectamos llamando al método Disconnect:

    // Desconecta el servidor
    objServer.Disconnect();
  
## Formato de los mensajes almacenados

Los archivos almacenados con los mensajes contienen una línea con la dirección de correo origen, una segunda línea
con la dirección de correo destino y el contenido del mensaje MIME tal como se ha recibido del cliente.

## Más información

Más información en http://ant2e6.webs-interesantes.es/Codigo-fuente/Servidor-SMTP/Servidor-SMTP.htm
