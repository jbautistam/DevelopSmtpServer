using System;

namespace DevelopSmptServer.Events
{
	/// <summary>
	///		Argumentos de los eventos de log
	/// </summary>
	public class LogEventArgs : EventArgs
	{
		public LogEventArgs(string strMessage)
		{ Message = strMessage;
		}

		/// <summary>
		///		Mensaje del evento
		/// </summary>
		public string Message { get; private set; }
	}
}
