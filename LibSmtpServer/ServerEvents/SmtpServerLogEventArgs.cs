using System;

namespace Bau.Libraries.LibSmtpServer.ServerEvents
{
	/// <summary>
	///		Evento de log del servidor de Smtp
	/// </summary>
	public class SmtpServerLogEventArgs : EventArgs
	{
		public SmtpServerLogEventArgs(string strAction, string strMessage)
		{ Action = strAction;
			Message = strMessage;
		}

		/// <summary>
		///		Acción
		/// </summary>
		public string Action { get; private set; }

		/// <summary>
		///		Mensaje
		/// </summary>
		public string Message { get; private set; }
	}
}
