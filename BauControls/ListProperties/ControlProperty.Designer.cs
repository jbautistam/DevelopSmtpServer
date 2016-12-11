namespace Bau.Controls.ListProperties
{
	partial class ControlProperty
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
			this.tblValue = new System.Windows.Forms.TableLayoutPanel();
			this.lblName = new System.Windows.Forms.Label();
			this.tblValue.SuspendLayout();
			this.SuspendLayout();
			// 
			// tblValue
			// 
			this.tblValue.ColumnCount = 2;
			this.tblValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
			this.tblValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblValue.Controls.Add(this.lblName, 0, 0);
			this.tblValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblValue.Location = new System.Drawing.Point(0, 0);
			this.tblValue.Name = "tblValue";
			this.tblValue.RowCount = 1;
			this.tblValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tblValue.Size = new System.Drawing.Size(297, 23);
			this.tblValue.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.AllowDrop = true;
			this.lblName.AutoEllipsis = true;
			this.lblName.AutoSize = true;
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lblName.Location = new System.Drawing.Point(3, 0);
			this.lblName.Name = "lblName";
			this.lblName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.lblName.Size = new System.Drawing.Size(45, 18);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "lblName";
			// 
			// ctlValueResult
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.tblValue);
			this.Name = "ctlValueResult";
			this.Size = new System.Drawing.Size(297, 23);
			this.tblValue.ResumeLayout(false);
			this.tblValue.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tblValue;
		private System.Windows.Forms.Label lblName;
	}
}
