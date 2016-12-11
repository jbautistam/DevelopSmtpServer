using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Bau.Libraries.LibHelper.Extensors;
using Bau.Libraries.LibSmtpServer;

namespace BauDevelopSmtpServer
{
	/// <summary>
	///		Formulario principal de la aplicación
	/// </summary>
	public partial class frmMain : Form
	{ // Delegados
			private delegate void AddEMailCallback(string strFileName, string strDate, string strFrom, string strTo, string strSubject);
			private delegate void AddLogCallback(string strText);
		// Enumerados privados
			private enum NodeType
				{ Date,
					From,
					To,
					Message
				}

		public frmMain()
		{ InitializeComponent();
		}

		/// <summary>
		///		Inicializa el formulario
		/// </summary>
		private void InitForm()
		{ // Carga los correos en la lista
				LoadEMails();
			// Arranca el servidor
				StartServer();
		}

		/// <summary>
		///		Arranca el servidor
		/// </summary>
		private void StartServer()
		{ // Inicializa el servidor si no estaba inicializado
				if (Server == null)
					{ Server = new SmtpServer(Configuration.PathBase, Configuration.Ip, Configuration.Port);

							// Asigna el manejador de log
								Server.ServerLog += (objSender, objEventArgs) =>
																				{ if (objEventArgs.Action.EqualsIgnoreCase("Received"))
																						ShowReceivedEmail(objEventArgs.Message);
																					AddLog($"{objEventArgs.Action} => {objEventArgs.Message}");
																				};
					}
			// Conecta el servidor
				try
					{ // Conecta
							Server.Connect();
						// Activa los botones
							EnableControls(true);
					}
				catch (Exception objException)
					{ EnableControls(false);
						AddLog($"Error al arrancar el servidor => {objException.Message}");
					}
		}

		/// <summary>
		///		Detiene el servidor
		/// </summary>
		private void StopServer()
		{ if (Server != null)
				try
					{ // Desconecta el servidor
							Server.Disconnect();
						// Activa los botones
							EnableControls(false);
					}
				catch (Exception objException)
					{ EnableControls(false);
						AddLog($"Error al detener el servidor => {objException.Message}");
					}
		}

		/// <summary>
		///		Habilita los controles
		/// </summary>
		private void EnableControls(bool blnConnected)
		{ cmdStart.Enabled = !blnConnected;
			cmdStop.Enabled = blnConnected;
		}

		/// <summary>
		///		Carga la lista de correos
		/// </summary>
		private void LoadEMails()
		{ string strPath = System.IO.Path.Combine(Configuration.PathBase, "EMail\\ToSend");

				// Comienza la carga
					trvEMails.SaveOpenNodes();
					trvEMails.BeginUpdate();
				// Limpia el árbol
					trvEMails.Nodes.Clear();
					trvEMails.ImageList = imlImages;
				// Añade los datos
					if (System.IO.Directory.Exists(strPath))
						foreach (string strDirectory in System.IO.Directory.EnumerateDirectories(strPath))
							trvEMails.AddNode(null, new Bau.Controls.Tree.TreeNodeKey((int) NodeType.Date, 0, strDirectory), 
																System.IO.Path.GetFileName(strDirectory), true, (int) NodeType.Date, System.Drawing.Color.Red, true);
				// Recupera los nodos
					trvEMails.RestoreOpenNodes();
					trvEMails.EndUpdate();
		}

		/// <summary>
		///		Carga los eMails hijos de un nodo
		/// </summary>
		private void LoadEMails(TreeNode trnNode)
		{ Bau.Controls.Tree.TreeNodeKey objKey = trvEMails.GetKey(trnNode);

				if (objKey != null)
					switch ((NodeType) objKey.IDType)
						{	case NodeType.Date:
									LoadNodesFrom(trnNode, objKey.Tag as string);
								break;
							case NodeType.From:
									LoadNodesTo(trnNode, objKey.Tag as string);
								break;
						}
		}

		/// <summary>
		///		Carga los nodos de remitente
		/// </summary>
		private void LoadNodesFrom(TreeNode trnParent, string strPath)
		{	foreach (string strSender in System.IO.Directory.EnumerateDirectories(strPath))
				trvEMails.AddNode(trnParent, new Bau.Controls.Tree.TreeNodeKey((int) NodeType.From, 0, strSender), 
													System.IO.Path.GetFileName(strSender), true, 
													(int) NodeType.From, System.Drawing.Color.Navy, true);
		}

		/// <summary>
		///		Carga los nodos de destinatario y mensajes
		/// </summary>
		private void LoadNodesTo(TreeNode trnParent, string strPath)
		{ if (System.IO.Directory.Exists(strPath))
				{ List<string> objColTargets = new List<string>();
					List<string> objColMessages = new List<string>();

						// Obtiene los destinatarios
							foreach (string strMessage in System.IO.Directory.EnumerateFiles(strPath))
								if (strMessage.EndsWith(".msg", StringComparison.CurrentCultureIgnoreCase))
									{ string [] arrStrMessage = System.IO.Path.GetFileName(strMessage).Split('#');

											if (arrStrMessage.Length > 1)
												{ string strTarget = arrStrMessage[1].Left(arrStrMessage[1].Length - 4);

														// Añade el destinatario
															if (!ExistsTarget(objColTargets, strTarget))
																objColTargets.Add(strTarget);
														// Añade el mensaje
															objColMessages.Add(strMessage);
												}
									}
						// Ordena los destinatarios y los mensajes
							objColTargets.Sort();
							objColMessages.Sort();
						// Añade los destinatarios al nodo
							foreach (string strTarget in objColTargets)
								{ TreeNode trnTo = trvEMails.AddNode(trnParent, new Bau.Controls.Tree.TreeNodeKey((int) NodeType.To, 0, strTarget), 
																										 strTarget, false, (int) NodeType.To, System.Drawing.Color.Black, true);
																		
										// Añade los mensajes
											foreach (string strMessage in objColMessages)
												if (strMessage.EndsWith($"#{strTarget}.msg", StringComparison.CurrentCultureIgnoreCase))
													{ string [] arrStrMessage = System.IO.Path.GetFileName(strMessage).Split('#');

															if (arrStrMessage.Length > 0 && !string.IsNullOrEmpty(arrStrMessage[0]))
																trvEMails.AddNode(trnTo, new Bau.Controls.Tree.TreeNodeKey((int) NodeType.Message, 0, strMessage), 
																									arrStrMessage[0].Replace('_', ':') + " -> " + GetSubject(strMessage), false, 
																									(int) NodeType.Message);
													}
								}
				}
		}

		/// <summary>
		///		Comprueba si existe un destinatario en una colección
		/// </summary>
		private bool ExistsTarget(List<string> objColTargets, string strTarget)
		{ // Recorre la colección
				foreach (string strTo in objColTargets)
					if (strTo.EqualsIgnoreCase(strTarget))
						return true;
			// Si ha llegado hasta aquí es porque no existía
				return false;
		}

		/// <summary>
		///		Muestra un archivo recibido
		/// </summary>
		private void ShowReceivedEmail(string strFileName)
		{ // Actualiza el árbol de correso
				LoadEMails();
			// Muestra un mensaje de recepción
				Bau.Controls.Forms.Helper.ShowMessage(this, "Se ha recibido un mensaje");
		}

		/// <summary>
		///		Carga el archivo y obtiene los datos
		/// </summary>
		private string GetSubject(string strFile)
		{ int intLine = 0;
			string strSubject = "";

				// Carga los datos
					using (System.IO.StreamReader stmFile = new System.IO.StreamReader(strFile))
						{ string strLine;

								// Recorre las líneas
									while ((strLine = stmFile.ReadLine()) != null && intLine < 20 && string.IsNullOrEmpty(strSubject))
										{ // Obtiene el valor de la línea
												if (!strLine.IsEmpty())
													strSubject = GetValue(strLine, "Subject:", strSubject);
											// Incrementa la línea
												intLine++;
										}
								// Cierra el stream
									stmFile.Close();
						}
				// Devuelve el asunto
					return strSubject;
		}

		/// <summary>
		///		Obtiene un valor de una línea
		/// </summary>
		private string GetValue(string strLine, string strTag, string strValue)
		{ if (strValue.IsEmpty() && strLine.StartsWith(strTag, StringComparison.CurrentCultureIgnoreCase))
				return strLine.Right(strLine.Length - strTag.Length);
			else
				return strValue;
		}
		
		/// <summary>
		///		Añade un texto al log
		/// </summary>
		private void AddLog(string strText)
		{ if (txtLog.InvokeRequired)
				Invoke(new AddLogCallback(AddLog), new object[] { strText });
			else
				{ txtLog.Text += strText + Environment.NewLine;
					txtLog.Text += Environment.NewLine;
				}
		}

		/// <summary>
		///		Abre el contenido de un correo
		/// </summary>
		private void OpenEMails(TreeNode trnNode)
		{ if (trnNode != null)
				{ Bau.Controls.Tree.TreeNodeKey objKey = trvEMails.GetKey(trnNode);

						if (objKey.IDType == (int) NodeType.Message)
							{	string strFileName = objKey.Tag as string;

									if (System.IO.File.Exists(strFileName))
										Bau.Libraries.LibHelper.Files.HelperFiles.OpenDocumentShell("Notepad", strFileName);
									else
										Bau.Controls.Forms.Helper.ShowMessage(this, "No se encuentra el mensaje");
							}
				}
		}

		/// <summary>
		///		Elimina los correos
		/// </summary>
		private void RemoveEmails()
		{ if (trvEMails.SelectedNode != null)
				{ Bau.Controls.Tree.TreeNodeKey objKey = trvEMails.GetKey(trvEMails.SelectedNode);

						if (objKey != null && objKey.Tag is string)
							{ string strPath = objKey.Tag as string;

									// Elimina un directorio o archivo
										if (System.IO.Directory.Exists(strPath))
											Bau.Libraries.LibHelper.Files.HelperFiles.KillPath(strPath);
										else if (System.IO.File.Exists(strPath))
											Bau.Libraries.LibHelper.Files.HelperFiles.KillFile(strPath);
									// Actualiza el árbol
										LoadEMails();
							}
				}
		}

		/// <summary>
		///		Abre el formulario de propiedades
		/// </summary>
		private void OpenFormProperties()
		{ Views.frmProperties frmNewProperties = new Views.frmProperties();

				// Muestra el formulario
					frmNewProperties.ShowDialog();
		}

		/// <summary>
		///		Servicio SMTP
		/// </summary>
		private SmtpServer Server { get; set; }

		private void frmMain_Load(object sender, EventArgs e)
		{ InitForm();
		}

		private void cmdStart_Click(object sender, EventArgs e)
		{ StartServer();
		}

		private void cmdStop_Click(object sender, EventArgs e)
		{ StopServer();
		}

		private void cmdOpenEMail_Click(object sender, EventArgs e)
		{ OpenEMails(trvEMails.SelectedNode);
		}

		private void cmdRemoveEMail_Click(object sender, EventArgs e)
		{ RemoveEmails();
		}

		private void cmdOptions_Click(object sender, EventArgs e)
		{ OpenFormProperties();
		}

		private void trvEMails_LoadChilds(object objSender, Bau.Controls.Tree.TreeViewExtendedEventArgs evnArgs)
		{ LoadEMails(evnArgs.Node);
		}

		private void trvEMails_NodeDoubleClick(object objSender, Bau.Controls.Tree.TreeViewExtendedEventArgs evnArgs)
		{ OpenEMails(evnArgs.Node);
		}
	}
}
