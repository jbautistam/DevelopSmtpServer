using System;

namespace Bau.Libraries.LibSmtpServer.Receiver
{
	/// <summary>
	///		Clase para grabación de mensajes
	/// </summary>
	internal class MessageWriter : IDisposable
	{
		/// <summary>
		///		Crea un mensaje
		/// </summary>
		internal void Create(string strPath)
		{ string strFileName = GetFileName(strPath);

				// Crea el directorio
					System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(strFileName));
				// Abre el stream de escritura
					Writer = new System.IO.StreamWriter(strFileName, false, System.Text.ASCIIEncoding.ASCII);
				// Indica que está abierto
					IsDisposed = false;
		}

		/// <summary>
		///		Obtiene el nombre de archivo
		/// </summary>
		private string GetFileName(string strPath)
		{ string strFileName = System.IO.Path.Combine(strPath, string.Format("{0:yyyy-MM-dd}", DateTime.Now));

				// Añade el nombre de archivo
					strFileName = System.IO.Path.Combine(strFileName, Guid.NewGuid().ToString() + ".msg");
				// Devuelve el nombre de archivo
					return strFileName;
		}

		/// <summary>
		///		Escribe el correo origen
		/// </summary>
		internal void WriteFrom(string strEMail)
		{ Write("FROM: " + strEMail);
		}

		/// <summary>
		///		Escribe el correo destino
		/// </summary>
		internal void WriteTo(string strEMail)
		{ Write("TO: " + strEMail);
		}

		/// <summary>
		///		Escribe un mensaje
		/// </summary>
		internal void Write(string strMessage)
		{ if (Writer != null)
				Writer.Write(strMessage + "\r\n");
		}

		/// <summary>
		///		Cierra el stream de escritura
		/// </summary>
		private void Close()
		{ if (Writer != null)
				{ // Cierra el stream
						Writer.Flush();
						Writer.Close();
					// ... y libera el objeto
						Writer = null;
					// Indica que se ha liberado
						IsDisposed = true;
				}
		}

		/// <summary>
		///		Libera la memoria
		/// </summary>
		protected virtual void Dispose(bool blnIsDisposing)
		{	if (!IsDisposed)
				{	// Cierra el stream
						if (blnIsDisposing)
							Close();
					// Indica que se ha cerrado
						IsDisposed = true;
				}
		}

		/// <summary>
		///		Libera la memoria
		/// </summary>
		public void Dispose()
		{ // Libera la memoria
				Dispose(true);
			// Llama al destructor
				GC.SuppressFinalize(this);
		}

		/// <summary>
		///		Stream de escritura
		/// </summary>
		private System.IO.StreamWriter Writer { get; set; }

		/// <summary>
		///		Indica si se ha cerrado el stream (para evitar llamadas reentrantes)
		/// </summary>
		internal bool IsDisposed { get; private set; }

		/// <summary>
		///		Destructor. Libera la memoria
		/// </summary>
		~MessageWriter()
		{	Dispose(false);
		}
	}
}
