using System;
using System.Net.Sockets;

namespace Bau.Libraries.LibSmtpServer.Receiver
{
	/// <summary>
	///		Clase de escucha del servidor
	/// </summary>
	internal class SmtpListener
	{ // Constantes privadas
			private const string cnstStrLineSeparator = "\r\n";
			private const string cnstStrEMailFrom = "MAIL FROM";
			private const string cnstStrEMailTo = "RCPT TO";
		// Enumerados privados
			/// <summary>
			///		Tipo de línea leída en la comunicación
			/// </summary>
			private enum LineType
				{ 
					/// <summary>Desconocido</summary>
					Unknown,
					/// <summary>Inicio de datos</summary>
					StartData,
					/// <summary>Final de datos</summary>
					EndData,
					/// <summary>Conexión</summary>
					Hello,
					/// <summary>Emisor del mensaje</summary>
					MailFrom,
					/// <summary>Destinatario del mensaje</summary>
					MailTo,
					/// <summary>Descarta el mensaje</summary>
					Reset,
					/// <summary>Fin de comunicación</summary>
					Quit,
					/// <summary>Mensaje NOOP</summary>
					Noop
				}

		internal SmtpListener(SmtpServer objServer)
		{ Server = objServer;
		}

		/// <summary>
		///		Conecta al servidor
		/// </summary>
		internal void Connect()
		{ if (!IsConnected)
				{ // Indica que está conectado
						IsConnected = true;
					// Arranca el servicio de escucha
						StartListener();
				}
		}

		/// <summary>
		///		Conecta el servicio de escucha
		/// </summary>
		private async void StartListener() 
		{ // Si no existe el objeto de escucha, lo crea
				if (Listener == null)
					Listener = new TcpListener(new System.Net.IPEndPoint(System.Net.IPAddress.Parse(Server.IP), Server.Port));
			// Inicializa el listener
				Listener.Start();
			// Mientras continúe conectado
				while (IsConnected)
					{ try
							{ TcpClient objTcpclient = await Listener.AcceptTcpClientAsync().ConfigureAwait(false);                

									// Trata el cliente
										HandleClient(objTcpclient);
							}
						catch (Exception objException)
							{ System.Diagnostics.Debug.WriteLine("Excepción: " + objException.Message);
							}
					}
		}

		/// <summary>
		///		Detiene el servicio de escucha
		/// </summary>
		private void StopListener()
		{ if (Listener != null)
				Listener.Stop();
		}

		/// <summary>
		///		Trata un cliente TCP
		/// </summary>
		private void HandleClient(TcpClient objTcpClient)
		{ string strIPClient = objTcpClient.Client.RemoteEndPoint.ToString(); // ... para poder utilizarlo al salir (cuando ya TCPClient se ha liberado)
			MessageWriter objWriter = new MessageWriter();
			bool blnReset = false;

				// Log
					AddLog("Cliente conectado", "IP cliente: " + strIPClient);
				// Carga los datos
					using (NetworkStream stmNetwork = objTcpClient.GetStream())
						{ using (System.IO.StreamReader stmReader = new System.IO.StreamReader(stmNetwork))
								{ bool blnIsEnd = false, blnIsData = false;
									string strPreviousLine = "";

										// Crea el generador de archivo
											objWriter.Create(Server.PathEMailsToSend);
										// Envía la línea de información del servidor
											Write(stmNetwork, "220 BauSMTPServer");
										// Recoge los datos
											while (!blnIsEnd)
												{ string strLine = stmReader.ReadLine(); 

														switch (GetLineType(strLine, blnIsData))
															{	case LineType.Hello:
																	// Log
																		AddLog("Conexión de cliente", strLine);
																	// Escribe el ok
																		WriteOk(stmNetwork);
																	break;
																case LineType.Quit:
																		blnIsEnd = true;
																		Write(stmNetwork, "221 DevelopSMTP Service closing transmission channel");
																	break;
																case LineType.StartData:
																		blnIsData = true;
																		Write(stmNetwork, "354 send the mail data, end with .");
																	break;
																case LineType.EndData:
																		blnIsData = false;
																		WriteOk(stmNetwork);
																	break;
																case LineType.Noop:
																		WriteOk(stmNetwork);
																	break;
																case LineType.MailFrom:
																		objWriter.From = GetEMail(cnstStrEMailFrom, strLine);
																		WriteOk(stmNetwork);
																	break;
																case LineType.MailTo:
																		objWriter.To = GetEMail(cnstStrEMailTo, strLine);
																		WriteOk(stmNetwork);
																	break;
																case LineType.Reset:
																		blnReset = true;
																		WriteOk(stmNetwork);
																	break;
																case LineType.Unknown:
																		if (blnIsData)
																			{ // Si la línea es un punto y la línea anterior es un salto de línea, termina la transmisión de datos
																					if (strLine == "." && string.IsNullOrEmpty(strPreviousLine))
																						{ // Indica que ya no hay más datos		
																								blnIsData = false;
																							// ... y envía un OK al cliente
																								WriteOk(stmNetwork);
																						}
																					else // Añade la línea al mensaje
																						objWriter.Write(strLine);
																				// Guarda la línea anterior
																					strPreviousLine = strLine;
																			}
																		else // ... cualquier mensaje que no entienda, devuelve un OK
																			WriteOk(stmNetwork);
																	break;
																default: // ... esto no debería pasar... siempre va a entrar por el LineType.Unknown
																		WriteOk(stmNetwork);
																	break;
															}
												}
										// Cierra el generador de mensajes
											objWriter.Dispose();
								}
						}
				// Si se ha hecho un Reset, se elimina el archivo
					if (blnReset)
						objWriter.Delete();
					else
						Server.RaiseEventReceived(objWriter.FileName);
				// Log
					AddLog("Cliente desconectado", "IP cliente: " + strIPClient);
		}

		/// <summary>
		///		Añade un dato al log
		/// </summary>
		private void AddLog(string strAction, string strMessage)
		{ Server?.RaiseEventLog(strAction, strMessage);
		}

		/// <summary>
		///		Obtiene el email de una línea
		/// </summary>
		private string GetEMail(string strPrefix, string strLine)
		{ string strEmail = "";

				// Obtiene la dirección de correo
					strEmail = RemovePrefix(strPrefix, strLine);
					strEmail = RemovePrefix(":", strEmail);
					strEmail = RemovePrefix("<", strEmail);
					strEmail = RemoveSufix(">", strEmail);
				// Devuelve la dirección de correo
					return strEmail;
		}

		/// <summary>
		///		Quita un prefijo del texto
		/// </summary>
		private string RemovePrefix(string strPrefix, string strText)
		{	// Quita el prefijo
				if (strText.Length > strPrefix.Length && strText.StartsWith(strPrefix, StringComparison.CurrentCultureIgnoreCase))
					strText = strText.Substring(strPrefix.Length);
			// Devuelve el texto sin prefijo
				return TrimCheck(strText);
		}

		/// <summary>
		///		Elimina un sufijo del texto
		/// </summary>
		private string RemoveSufix(string strSufix, string strText)
		{	// Quita el prefijo
				if (strText.Length > strSufix.Length && strText.EndsWith(strSufix, StringComparison.CurrentCultureIgnoreCase))
					strText = strText.Substring(0, strText.Length - strSufix.Length);
			// Devuelve el texto sin sufijo
				return TrimCheck(strText);
		}

		/// <summary>
		///		Trim de una cadena comprobando si está vacía
		/// </summary>
		private string TrimCheck(string strText)
		{	if (!string.IsNullOrEmpty(strText))
				return strText.Trim();
			else
				return strText;
		}

		/// <summary>
		///		Obtiene el tipo de línea
		/// </summary>
		private LineType GetLineType(string strLine, bool blnIsData)
		{ LineType intType = LineType.Unknown;

				// Obtiene el tipo de línea
					if (!string.IsNullOrEmpty(strLine))
						{ if (!blnIsData)
								{ if (strLine.StartsWith("HELO", StringComparison.CurrentCultureIgnoreCase) ||
											strLine.StartsWith("EHLO", StringComparison.CurrentCultureIgnoreCase))
										intType = LineType.Hello;
									else if (strLine.StartsWith("DATA", StringComparison.CurrentCultureIgnoreCase))
										intType = LineType.StartData;
									else if (strLine.StartsWith("NOOP", StringComparison.CurrentCultureIgnoreCase))
										intType = LineType.Noop;
									else if (strLine.StartsWith("QUIT", StringComparison.CurrentCultureIgnoreCase))
										intType = LineType.Quit;
									else if (strLine.StartsWith("RSET", StringComparison.CurrentCultureIgnoreCase))
										intType = LineType.Reset;
									else if (strLine.StartsWith(cnstStrEMailFrom, StringComparison.CurrentCultureIgnoreCase))
										intType = LineType.MailFrom;
									else if (strLine.StartsWith(cnstStrEMailTo, StringComparison.CurrentCultureIgnoreCase))
										intType = LineType.MailTo;
								}
						}
				// Devuelve el tipo de línea
					return intType;
		}

		/// <summary>
		///		Escribe una línea de OK
		/// </summary>
		private void WriteOk(NetworkStream stmNetwork)
		{ Write(stmNetwork, "250 OK");
		}

		/// <summary>
		///		Escribe un mensaje
		/// </summary>
		private void Write(NetworkStream stmNetwork, string strLine)
		{ System.Text.ASCIIEncoding objEncoder = new System.Text.ASCIIEncoding();
			byte[] arrBytBuffer = objEncoder.GetBytes(strLine + cnstStrLineSeparator);
    
				// Escribe la cadena codificada
					stmNetwork.Write(arrBytBuffer, 0, arrBytBuffer.Length);
				// Envía la cadena
					stmNetwork.Flush();
		}

		/// <summary>
		///		Desconecta el servidor
		/// </summary>
		internal void Disconnect()
		{ StopListener();
			IsConnected = false;
		}

		/// <summary>
		///		Servidor
		/// </summary>
		private SmtpServer Server { get; }

		/// <summary>
		///		Indica si está conectado
		/// </summary>
		private bool IsConnected { get; set; }

		/// <summary>
		///		Objeto de escucha
		/// </summary>
		private TcpListener Listener { get; set; }
	}
}