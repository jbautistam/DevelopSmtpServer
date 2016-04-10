using System;
using System.ServiceProcess;

using Bau.Libraries.LibSmtpServer;

namespace DevelopSmptServer
{
	/// <summary>
	///		Servicio SMTP
	/// </summary>
	partial class ServiceSmtp : ServiceBase
	{ // Eventos públicos
			public event EventHandler<Events.LogEventArgs> Log;

		internal ServiceSmtp(string strIp, int intPort, string strTargetPath)
		{	// Inicializa los componentes
				InitializeComponent();
			// Inicializa el servidor
				Server = new SmtpServer(strTargetPath, strIp, intPort);
		}

		/// <summary>
		///		Arranca el servicio desde la consola
		/// </summary>
		internal void Start()
		{ Server.ServerLog += (objSender, objEventArgs) => 
															{ Log?.Invoke(objSender, new Events.LogEventArgs($"{objEventArgs.Action} --> {objEventArgs.Message}"));
															};
			Server.Connect();
		}

		/// <summary>
		///		Arranca el servicio
		/// </summary>
		protected override void OnStart(string [] args)
		{ Server.Connect();
		}

		/// <summary>
		///		Detiene el servicio
		/// </summary>
		protected override void OnStop()
		{ Server.Disconnect();
		}

		/// <summary>
		///		Servidor
		/// </summary>
		private SmtpServer Server { get; set; }
	}
}
