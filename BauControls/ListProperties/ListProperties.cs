using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bau.Controls.ListProperties
{
	/// <summary>
	///		Lista con controles
	/// </summary>
	public partial class ListProperties : UserControl
	{ 	
		/// <summary>
		///		Tipo de control
		/// </summary>
		public enum ControlType
			{
				Unknown,
				Label,
				TextBox,
				CheckBox,
				Date,
				List,
				MultiLine,
				Number
			}

		public ListProperties()
		{	InitializeComponent();
		}

		/// <summary>
		///		Limpia la lista de controles
		/// </summary>
		public void Clear()
		{ lsrValues.Clear();
			lsrValues.Spacing = 1;
		}
		
		/// <summary>
		///		Añade un control a la lista a partir de la definición del valor
		/// </summary>
		public void AddControl(string strKey, ControlType intType, string strTitle, string strValue, bool blnRequired)
		{ ControlProperty udtResult = new ControlProperty();
		
				// Carga los datos
					udtResult.LoadValue(strKey, intType, strTitle, strValue, blnRequired);
				// Añade el control a la lista
					lsrValues.Add(udtResult);
		}
		
		/// <summary>
		///		Comnprueba los datos introducidos en los controles
		/// </summary>
		public bool ValidateData(out string strError)
		{ // Inicializa el valor de salida
				strError = "";
			// Comprueba los datos
				foreach (Control ctlControl in lsrValues.ChildControls)
					if (ctlControl is ControlProperty)
						if (!(ctlControl as ControlProperty).Validate(out strError))
							return false;
			// Si ha llegado hasta aquí es porque todos los controles dieron un resultado correcto
				return true;
		}

		/// <summary>
		///		Obtiene el valor de un control
		/// </summary>
		public string GetValue(string strKey)
		{ // Obtiene el valor
				if (!string.IsNullOrEmpty(strKey))
					foreach (Control ctlControl in lsrValues.ChildControls)
						if (ctlControl is ControlProperty)
							{ ControlProperty udtControl = ctlControl as ControlProperty;

									if (udtControl != null && udtControl.Key.Equals(strKey, StringComparison.CurrentCultureIgnoreCase))
										return udtControl.Value;
							}
			// Si ha llegado hasta aquí es porque no ha encontrado el valor
				return "";
		}

		/// <summary>
		///		Cuenta el número de valores
		/// </summary>
		internal int CountValues
		{ get { return lsrValues.ChildControls.Count; }
		}
	}
}
