using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

using Bau.Libraries.LibHelper.Extensors;
using Bau.Libraries.LibSmtpServer;

namespace TestSmtpServer
{
	/// <summary>
	///		Formulario para pruebas
	/// </summary>
	public partial class frmMain : Form
	{	// Variables privadas
			private SmtpServer objServer;
			private string strLogText = "";

		public frmMain()
		{	InitializeComponent();
		}

		/// <summary>
		///		Inicializa el formulario
		/// </summary>
		private void InitForm()
		{ // Inicializa la lista
				InitListAttachments();
			// Carga la configuración
				fnPathEMails.PathName = Properties.Settings.Default.PathEMails;
				txtIP.Text = Properties.Settings.Default.IP;
				txtPort.Text = Properties.Settings.Default.Port;
				fnApplication.FileName = Properties.Settings.Default.FileNameApplication;
			// Normaliza los datos del formulario
				if (fnPathEMails.PathName.IsEmpty())
					fnPathEMails.PathName = System.IO.Path.Combine(Application.StartupPath, "Data");
				if (txtIP.Text.IsEmpty())
					txtIP.Text = "127.0.0.1";
				if (txtPort.Text.IsEmpty())
					txtPort.Text = "25";
			// Carga la configuración del mensaje
				if (!Properties.Settings.Default.From.IsEmpty())
					txtEMailSource.Text = Properties.Settings.Default.From;
				if (!Properties.Settings.Default.To.IsEmpty())
					txtEMailTarget.Text = Properties.Settings.Default.To;
				if (!Properties.Settings.Default.Subject.IsEmpty())
					txtSubject.Text = Properties.Settings.Default.Subject;
				if (!Properties.Settings.Default.Body.IsEmpty())
					txtBody.Text = Properties.Settings.Default.Body;
				InsertAttachment(Properties.Settings.Default.Attachments);
		}

		/// <summary>
		///		Comprueba los datos antes de enviar
		/// </summary>
		private bool ValidateData()
		{ bool blnValidate = false;

				// Comprueba los datos
					if (fnPathEMails.PathName.IsEmpty())
						Bau.Controls.Forms.Helper.ShowMessage(this, "Seleccione un directorio válido");
					else if (txtIP.Text.IsEmpty())
						Bau.Controls.Forms.Helper.ShowMessage(this, "Introduzca una IP");
					else if (txtPort.Text.GetInt() == null)
						Bau.Controls.Forms.Helper.ShowMessage(this, "Introduzca el puerto");
					else
						blnValidate = true;
				// Devuelve el valor que indica si los datos son correctos
					return blnValidate;
		}

		/// <summary>
		///		Conecta al servidor
		/// </summary>
		private void Connect()
		{	if (ValidateData())
				{ // Crea el objeto de servidor si no existía
						if (objServer == null)
							{ // Crea el objeto
									objServer = new SmtpServer(fnPathEMails.PathName, txtIP.Text, txtPort.Text.GetInt(25));
								// Añade el log
									objServer.ServerLog += (objSender, objEventArgs) => AddLog($"{objEventArgs.Action} --> {objEventArgs.Action}");
							}
					// Conecta al servidor
						objServer.Connect();
				}
		}

		/// <summary>
		///		Desconecta el servidor
		/// </summary>
		private void Disconnect()
		{ if (objServer != null)
				objServer.Disconnect();
		}

		/// <summary>
		///		Envía el correo
		/// </summary>
		private void Send()
		{	if (ValidateData())
				{ // Graba la configuración
						Save();
					// Envía el mensaje
						SendMessage();
				}
		}

		/// <summary>
		///		Envía el mensaje
		/// </summary>
		private void SendMessage()
		{ SmtpClient objSmtpClient = new SmtpClient(txtIP.Text, txtPort.Text.GetInt(25));

				try
					{ MailMessage objMessage = new MailMessage();
						MailAddressCollection objColTarget = GetAccounts(txtEMailTarget.Text);

							// Crea las cuentas
								objMessage.From = GetAccount(txtEMailSource.Text);
								foreach (MailAddress objTarget in objColTarget)
									objMessage.To.Add(objTarget);
							// Asigna el título y cuerpo del mensaje
								objMessage.Subject = txtSubject.Text;
								objMessage.Body = txtBody.Text;
							// Añade los adjuntos
								foreach (ListViewItem lsiItem in lswAttachments.Items)
									{ string strFileName = lsiItem.Tag as string;

											if (!strFileName.IsEmpty() && System.IO.File.Exists(strFileName))
												objMessage.Attachments.Add(new Attachment(strFileName));
									}
							// Envía el mensaje
								objSmtpClient.Send(objMessage);
							// Cierra el cliente
								objSmtpClient.Dispose();
							// Añade el texto al log
								if (!strLogText.IsEmpty())
									txtLog.AppendText(strLogText + Environment.NewLine + new string('-', 80));
							// Mensaje al usuario
								Bau.Controls.Forms.Helper.ShowMessage(this, "Mensaje enviado");
					}
				catch (Exception objException)
					{ Bau.Controls.Forms.Helper.ShowMessage(this, "No se ha podido enviar el mensaje: " + objException.Message);
					}
		}

		/// <summary>
		///		Obtiene las cuentas
		/// </summary>
		private MailAddressCollection GetAccounts(string strAccounts)
		{ string[] arrStrAccounts = strAccounts.Split(';');
			MailAddressCollection objColAddress = new MailAddressCollection();

				// Crea la colección de cuentas
					foreach (string strAccount in arrStrAccounts)
						objColAddress.Add(GetAccount(strAccount));
				// Devuelve la colección de cuentas
					return objColAddress;
		}

		/// <summary>
		///		Obtiene una cuenta de correo
		/// </summary>
		private MailAddress GetAccount(string strAccount)
		{ string strDisplayName = "";

				// Separa el nombre de la cuenta de la dirección
					strAccount = strAccount.TrimIgnoreNull().Cut("[", out strDisplayName);
				// Quita el carácter ] al final
					strDisplayName = strDisplayName.TrimIgnoreNull();
					if (!strDisplayName.IsEmpty() && strDisplayName.EndsWith("]"))
						strDisplayName = strDisplayName.Left(strDisplayName.Length - 1);
				// Devuelve la cuenta
					return new MailAddress(strAccount.TrimIgnoreNull(), strDisplayName.TrimIgnoreNull());
		}

		/// <summary>
		///		Inicializa la lista de adjuntos
		/// </summary>
		private void InitListAttachments()
		{ lswAttachments.Clear();
			lswAttachments.AddColumn(lswAttachments.Width, "Archivo adjunto");
		}

		/// <summary>
		///		Inserta los adjuntos
		/// </summary>
		private void InsertAttachment()
		{ InsertAttachment(Bau.Controls.Forms.Helper.GetFileNameOpen("Todos los archivos (*.*)|*.*", true));
		}

		/// <summary>
		///		Inserta los adjuntos de un archivo
		/// </summary>
		private void InsertAttachment(string strFileName)
		{	if (!strFileName.IsEmpty())
				{ string [] arrStrFiles = strFileName.Split(';');

						foreach (string strFile in arrStrFiles)
							lswAttachments.AddRecord(strFile.TrimIgnoreNull(), strFile.TrimIgnoreNull());
				}
		}

		/// <summary>
		///		Borra un adjunto
		/// </summary>
		private void DeleteAttachment(string strKey)
		{ if (lswAttachments.SelectedItems.Count > 0)
				lswAttachments.Items.Remove(lswAttachments.SelectedItems[0]);
		}

		/// <summary>
		///		Ejecuta la aplicación como servicio o consola
		/// </summary>
		private void ExecuteApplication(bool blnService)
		{ if (ValidateData())
				{ if (fnApplication.FileName.IsEmpty() || !System.IO.File.Exists(fnApplication.FileName))	
						Bau.Controls.Forms.Helper.ShowMessage(this, "Introduzca el nombre del ejecutable de servidor");
					else
						{ string strArguments;

								// Asigna los argumentos
									strArguments = $"-a {txtIP.Text} -p {txtPort.Text.GetInt(25)} -d {fnPathEMails.PathName}";
									if (blnService)
										strArguments += " -service";
								// Ejecuta la aplicación
									Bau.Libraries.LibHelper.Files.HelperFiles.Execute(fnApplication.FileName, strArguments, true);
						}
				}
		}

		/// <summary>
		///		Añade un texto al log
		/// </summary>
		private void AddLog(string strText)
		{ strLogText += strText + Environment.NewLine;
		}

		/// <summary>
		///		Muestra la lista de archivos
		/// </summary>
		private void LoadFiles()
		{ List<string> objColFiles = Bau.Libraries.LibHelper.Files.HelperFiles.LoadRecursive(fnPathEMails.PathName);

				// Limpia la lista
					lswFiles.Clear();
					lswFiles.AddColumn(0, "Directorio");
					lswFiles.AddColumn(500, "Archivo");
				// Muestra los archivos
					foreach (string strFile in objColFiles)
						if (!strFile.IsEmpty() && strFile.EndsWith(".msg", StringComparison.CurrentCultureIgnoreCase))
							{ ListViewItem lsiItem = lswFiles.AddItem(strFile, System.IO.Path.GetDirectoryName(strFile).Substring(fnPathEMails.PathName.Length));

									lsiItem.SubItems.Add(System.IO.Path.GetFileName(strFile));
							}
				// Agrupa por el directorio
					lswFiles.GroupByColumn(0);
		}

		/// <summary>
		///		Borra los archivos
		/// </summary>
		private void DeleteFiles()
		{ // Borra los archivos de la lista
				foreach (ListViewItem lsiItem in lswFiles.Items)
					if (lsiItem.Tag != null && lsiItem.Tag is string)
						Bau.Libraries.LibHelper.Files.HelperFiles.KillFile(lsiItem.Tag as string);
			// Carga los archivos
				LoadFiles();
		}

		/// <summary>
		///		Abre el archivo
		/// </summary>
		private void OpenFile(string strFileName)
		{ if (!strFileName.IsEmpty() && System.IO.File.Exists(strFileName))
				Bau.Libraries.LibHelper.Files.HelperFiles.Execute("Notepad", strFileName, true);
		}

		/// <summary>
		///		Graba la configuración
		/// </summary>
		private void Save()
		{ // Guarda la configuración
				Properties.Settings.Default.PathEMails = fnPathEMails.PathName;
				Properties.Settings.Default.IP = txtIP.Text;
				Properties.Settings.Default.Port = txtPort.Text;
				Properties.Settings.Default.FileNameApplication = fnApplication.FileName;
			// Guarda los datos del mensaje
				Properties.Settings.Default.From = txtEMailSource.Text;
				Properties.Settings.Default.To = txtEMailTarget.Text;
				Properties.Settings.Default.Subject = txtSubject.Text;
				Properties.Settings.Default.Body = txtBody.Text;
				Properties.Settings.Default.Attachments = GetAttachments();
			// ... y la graba
				Properties.Settings.Default.Save();
		}

		/// <summary>
		///		Obtiene una cadena con los ajuntos
		/// </summary>
		private string GetAttachments()
		{ string strAttachments = "";

				// Obtiene los nombres de archivo de la lista
					foreach (ListViewItem lsiItem in lswAttachments.Items)
						if (lsiItem.Tag != null && lsiItem.Tag is string)
							strAttachments = strAttachments.AddWithSeparator(lsiItem.Tag as string, ";");
				// Devuelve los nombre de archivo
					return strAttachments;
		}

		private void cmdConnect_Click(object sender, EventArgs e)
		{ Connect();
		}

		private void cmdSend_Click(object sender, EventArgs e)
		{ Send();
		}

		private void cmdDisconnect_Click(object sender, EventArgs e)
		{ Disconnect();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{ InitForm();
		}

		private void cmdConsole_Click(object sender, EventArgs e)
		{ ExecuteApplication(false);
		}

		private void cmdService_Click(object sender, EventArgs e)
		{ ExecuteApplication(true);
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{ Save();
		}

		private void cmdRefreshFiles_Click(object sender, EventArgs e)
		{ LoadFiles();
		}

		private void cmdDeleteFiles_Click(object sender, EventArgs e)
		{ DeleteFiles();
		}

		private void lswFiles_ItemDoubleClick(object objSender, string strKey)
		{ OpenFile(strKey);
		}

		private void lswAttachments_OnDeleteRecord(object objSender, string strKey)
		{ DeleteAttachment(strKey);
		}

		private void lswAttachments_OnUpdateRecord(object objSender, string strKey)
		{ InsertAttachment();
		}
	}
}
	