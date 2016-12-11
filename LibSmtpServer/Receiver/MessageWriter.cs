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
		{ Path = strPath;
		}

		/// <summary>
		///		Obtiene el nombre de archivo
		/// </summary>
		private string GetFileName(string strPath)
		{ string strFileName;
		
				// Crea el nombre de archivo: Path + From + Date + To
					strFileName = System.IO.Path.Combine(strPath, string.Format("{0:yyyy-MM-dd}", DateTime.Now));
					strFileName = System.IO.Path.Combine(strFileName, From);
				// Añade el nombre de archivo
					strFileName = System.IO.Path.Combine(strFileName, $"{DateTime.Now:HH_mm_ss_ms}#{To}.msg");
				// Devuelve el nombre de archivo
					return strFileName;
		}

		/// <summary>
		///		Borra el archivo
		/// </summary>
		public void Delete()
		{ try
				{ // Cierra el stream
						Close();
					// Borra el archivo
						System.IO.File.Delete(FileName);
				}
			catch (Exception objException)
				{ System.Diagnostics.Debug.WriteLine("Excepción de borrado: " + objException.Message);
				}
		}

		/// <summary>
		///		Escribe un mensaje
		/// </summary>
		internal void Write(string strMessage)
		{ // Abre el stream de escritura si es necesario
				if (!IsDisposed && Writer == null && !string.IsNullOrEmpty(From) && !string.IsNullOrEmpty(To))
					{ // Genera el nombre de archivo
							FileName = GetFileName(Path);
						// Crea el directorio
							System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(FileName));
						// Abre el stream de escritura
							Writer = new System.IO.StreamWriter(FileName, false, System.Text.ASCIIEncoding.ASCII);
						// Indica que está abierto
							IsDisposed = false;
					}
			// Escribe el mensaje
				if (!IsDisposed && Writer != null)
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
		private System.IO.StreamWriter Writer { get; set; } = null;

		/// <summary>
		///		Directorio inicial donde se almacenan los archivos
		/// </summary>
		internal string Path { get; private set; }

		/// <summary>
		///		Nombre de archivo
		/// </summary>
		internal string FileName { get; private set; }

		/// <summary>
		///		Dirección de correo del remitente
		/// </summary>
		internal string From { get; set; }

		/// <summary>
		///		Dirección de correo del destinatario
		/// </summary>
		internal string To { get; set; }

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
