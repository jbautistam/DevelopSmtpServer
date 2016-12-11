using System;
using System.Windows.Forms;

using Bau.Libraries.LibHelper.Extensors;

namespace BauDevelopSmtpServer.Views
{
	/// <summary>
	///		Formulario para mostrar las propiedades
	/// </summary>
	public partial class frmProperties : Form
	{
		public frmProperties()
		{ InitializeComponent();
		}

		/// <summary>
		///		Inicialia el formulario
		/// </summary>
		private void InitForm()
		{ fnPathEMails.PathName = Configuration.PathBase;
			txtIP.Text = Configuration.Ip;
			txtPort.Text = Configuration.Port.ToString();
		}

		/// <summary>
		///		Comprueba los datos introducidos
		/// </summary>
		private bool ValidateData()
		{ bool blnValidate = false;

				// Comprueba los datos
					if (fnPathEMails.PathName.IsEmpty())
						Bau.Controls.Forms.Helper.ShowMessage(this, "Introduzca el directorio donde se graban los mensajes");
					else if (txtIP.Text.IsEmpty())
						Bau.Controls.Forms.Helper.ShowMessage(this, "Seleccione una dirección IP correcta");
					else if (txtPort.Text.GetInt(0) < 1 || txtPort.Text.GetInt(0) > 65535)
						Bau.Controls.Forms.Helper.ShowMessage(this, "Introduzca un puerto entre 1 y 65535");
					else
						blnValidate = true;
				// Devuelve el valor que indica si los datos son correctos
					return blnValidate;
		}

		/// <summary>
		///		Graba la nueva configuración
		/// </summary>
		private void Save()
		{ if (ValidateData())
				{ // Asigna las propiedades a la configuración
						Configuration.PathBase = fnPathEMails.PathName;
						Configuration.Ip = txtIP.Text;
						Configuration.Port = txtPort.Text.GetInt(25);
					// Graba la configuración
						Configuration.Save();
					// Cierra el formulario
						DialogResult = DialogResult.OK;
						Close();
				}
		}

		private void cmdAccept_Click(object sender, EventArgs e)
		{ Save();
		}

		private void frmProperties_Load(object sender, EventArgs e)
		{ InitForm();
		}
	}
}
