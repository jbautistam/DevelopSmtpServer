using System;

namespace Bau.Libraries.LibSmtpServer
{
	/// <summary>
	///		Servidor SMTP
	/// </summary>
	public class SmtpServer
	{ // Eventos públicos
			public event EventHandler<ServerEvents.SmtpServerLogEventArgs> ServerLog;

		public SmtpServer(string strPathBase, string strIP = "127.0.0.1", int intPort = 25)
		{ PathBase = System.IO.Path.Combine(strPathBase, "EMail");
			IP = strIP;
			Port = intPort;
		}

		/// <summary>
		///		Conecta el servidor
		/// </summary>
		public void Connect()
		{ // Cierra el listener
				Disconnect();
			// Crea de nuevo el listener
				Listener = new Receiver.SmtpListener(this);
				Listener.Connect();
			// Lanza el evento
				RaiseEventLog("Conexión", "Conectado");
		}

		/// <summary>
		///		Desconecta el servidor
		/// </summary>
		public void Disconnect()
		{ if (Listener != null)
				{ // Desconecta el listener
						Listener.Disconnect();
					// Log
						RaiseEventLog("Desconexión", "Desconectado");
				}
		}

		/// <summary>
		///		Lanza un evento de log
		/// </summary>
		internal void RaiseEventLog(string strAction, string strMessage)
		{	ServerLog?.Invoke(this, new ServerEvents.SmtpServerLogEventArgs(strAction, strMessage));
		}

		/// <summary>
		///		lanza el evento de recepción
		/// </summary>
		internal void RaiseEventReceived(string strFileName)
		{ ServerLog?.Invoke(this, new ServerEvents.SmtpServerLogEventArgs("Received", strFileName));
		}

		/// <summary>
		///		Directorio donde se almacenan los archivos
		/// </summary>
		public string PathBase { get; }

		/// <summary>
		///		Directorio donde se almacenan los archivos pendientes de enviar
		/// </summary>
		public string PathEMailsToSend 
		{ get { return System.IO.Path.Combine(PathBase, "ToSend"); }
		}

		/// <summary>
		///		IP de recepción
		/// </summary>
		public string IP { get; }

		/// <summary>
		///		Puerto de recepción
		/// </summary>
		public int Port { get; }

		/// <summary>
		///		Receptor de mensajes
		/// </summary>
		private Receiver.SmtpListener Listener { get; set; }
	}
}
