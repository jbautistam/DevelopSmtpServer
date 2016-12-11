namespace Bau.Controls.ListProperties
{
	partial class ListProperties
	{
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lsrValues = new Bau.Controls.ListRepeat.ListRepeatControls();
			this.SuspendLayout();
			// 
			// lsrValues
			// 
			this.lsrValues.CurrentSelected = null;
			this.lsrValues.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsrValues.Location = new System.Drawing.Point(0, 0);
			this.lsrValues.Name = "lsrValues";
			this.lsrValues.Size = new System.Drawing.Size(433, 531);
			this.lsrValues.TabIndex = 0;
			// 
			// ctlListValueResults
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lsrValues);
			this.Name = "ctlListValueResults";
			this.Size = new System.Drawing.Size(433, 531);
			this.ResumeLayout(false);

		}

		#endregion

		private Bau.Controls.ListRepeat.ListRepeatControls lsrValues;
	}
}
