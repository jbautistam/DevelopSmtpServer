using System;
using System.Windows.Forms;

namespace BauDevelopSmtpServer
{
	/// <summary>
	///		Clase de configuración
	/// </summary>
	internal static class Configuration
	{
		/// <summary>
		///		Graba la configuración
		/// </summary>
		internal static void Save()
		{ Properties.Settings.Default.Save();
		}

		/// <summary>
		///		Directorio base
		/// </summary>
		internal static string PathBase
		{ get
				{ if (string.IsNullOrEmpty(Properties.Settings.Default.PathBase))
						return System.IO.Path.Combine(Application.StartupPath, "Received");
					else
						return Properties.Settings.Default.PathBase;
				}
			set { Properties.Settings.Default.PathBase = value; }
		}
		
		/// <summary>
		///		IP
		/// </summary>
		internal static string Ip
		{ get
				{ if (string.IsNullOrEmpty(Properties.Settings.Default.Ip))
						return "127.0.0.1";
					else
						return Properties.Settings.Default.Ip;
				}
			set { Properties.Settings.Default.Ip = value; }
		}
		
		/// <summary>
		///		Puerto
		/// </summary>
		internal static int Port
		{ get
				{ if (Properties.Settings.Default.Port <= 0)
						return 25;
					else
						return Properties.Settings.Default.Port;
				}
			set { Properties.Settings.Default.Port = value; }
		}
	}
}
