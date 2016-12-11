using System;
using System.ServiceProcess;

namespace DevelopSmtpServer
{
	/// <summary>
	///		Programa principal
	/// </summary>
	class Program
	{
		/// <summary>
		///		Método principal de la aplicación
		/// </summary>
		static void Main(string [] args)
		{ bool blnStartAtService = false;
			string strIp = "127.0.0.1";
			string strPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
			int intPort = 25;

				// Añade la rutina de tratamiento de eventos que trata las excepciones no controladas
					AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
				// Obtiene los parámetros de los argumentos
					strIp = GetArgument(args, "-a", strIp);
					intPort = ConvertToInt(GetArgument(args, "-p", intPort.ToString()), 25);
					strPath = GetArgument(args, "-d", strPath);
					blnStartAtService = ExistsArgument(args, "-service");
				// Muestra los argumentos
					Console.WriteLine($"IP: {strIp} Puerto: {intPort}");
					Console.WriteLine($"Directorio eMails: {strPath}");
					if (blnStartAtService)
						Console.WriteLine("Ejecución como servicio");
					else
						Console.WriteLine("Ejecución como consola");
				// Ejecuta el proceso como consola o como servicio
					if (blnStartAtService && !CheckIsDebug())
						StartService(CreateService(strIp, intPort, strPath));
					else
						StartConsole(CreateService(strIp, intPort, strPath));
		}

		/// <summary>
		///		Obtiene el argumento después de un prefijo
		/// </summary>
		private static string GetArgument(string [] arrStrArgs, string strPrefix, string strDefault)
		{ // Obtiene el valor del argumento que se encuentra después del prefijo
				for (int intIndex = 0; intIndex < arrStrArgs.Length - 1; intIndex++)
					if (!string.IsNullOrEmpty(arrStrArgs[intIndex]) && arrStrArgs[intIndex].Equals(strPrefix, StringComparison.CurrentCultureIgnoreCase))
						return arrStrArgs[intIndex + 1];
			// Si ha llegado hasta aquí es porque no ha encontrado el argumento
				return strDefault;
		}

		/// <summary>
		///		Comprueba si existe un argumento en la línea de comandos
		/// </summary>
		private static bool ExistsArgument(string [] arrStrArgs, string strArgument)
		{ // Comprueba si existe el argumento
				foreach (string strCommand in arrStrArgs)
					if (!string.IsNullOrEmpty(strCommand) && strCommand.Equals(strArgument, StringComparison.CurrentCultureIgnoreCase))
						return true;
			// Si ha llegado hasta aquí es porque no existe
				return false;
		}

		/// <summary>
		///		Convierte una cadena a entero
		/// </summary>
		private static int ConvertToInt(string strValue, int intDefault)
		{ int intValue;

				if (int.TryParse(strValue, out intValue))
					return intValue;
				else
					return intDefault;
		}

		/// <summary>
		///		Crea el servicio SMTP
		/// </summary>
		private static ServiceSmtp CreateService(string strIp, int intPort, string strPath)
		{	ServiceSmtp objService = new ServiceSmtp(strIp, intPort, strPath);

				// Asigna el manejador de eventos
					objService.Log +=	(objSender, objEventArgs) => Console.WriteLine(objEventArgs.Message);
				// Devuelve el objeto
					return objService;
		}

		/// <summary>
		///		Arranca el servidor como consola
		/// </summary>
		private static void StartConsole(ServiceSmtp objService)
		{	// Arranca el servicio
				objService.Start();
			// Detenemos el hilo para que la aplicación principal se detenga y se pueda depurar
				System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
		}

		/// <summary>
		///		Arranca el servidor como servicio
		/// </summary>
		private static void StartService(ServiceSmtp objService)
		{	ServiceBase.Run(new ServiceBase[] { objService });
		}

		/// <summary>
		///		Tratamiento de excepciones no tratados en la aplicación
		/// </summary>
		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) 
		{ Console.WriteLine("Error: " + (e.ExceptionObject as Exception).Message);
		}

		/// <summary>
		///		Comprueba si estamos en modo de depuración
		/// </summary>
		private static bool CheckIsDebug()
		{
			#if DEBUG
				return true;
			#else
				return false;
			#endif
		}
	}
}
