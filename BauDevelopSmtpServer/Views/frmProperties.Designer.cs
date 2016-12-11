namespace BauDevelopSmtpServer.Views
{
	partial class frmProperties
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
		if (disposing && (components != null))
		{
		components.Dispose();
		}
		base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.fnPathEMails = new Bau.Controls.Files.TextBoxSelectPath();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdAccept = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.fnPathEMails);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.txtIP);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.groupBox1.Location = new System.Drawing.Point(6, 11);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(674, 83);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Servidor";
			// 
			// fnPathEMails
			// 
			this.fnPathEMails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fnPathEMails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fnPathEMails.ForeColor = System.Drawing.Color.Black;
			this.fnPathEMails.Location = new System.Drawing.Point(77, 24);
			this.fnPathEMails.Margin = new System.Windows.Forms.Padding(0);
			this.fnPathEMails.MaximumSize = new System.Drawing.Size(11667, 20);
			this.fnPathEMails.MinimumSize = new System.Drawing.Size(233, 20);
			this.fnPathEMails.Name = "fnPathEMails";
			this.fnPathEMails.PathName = "";
			this.fnPathEMails.Size = new System.Drawing.Size(584, 20);
			this.fnPathEMails.TabIndex = 1;
			// 
			// txtPort
			// 
			this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPort.Location = new System.Drawing.Point(305, 50);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(31, 20);
			this.txtPort.TabIndex = 5;
			// 
			// txtIP
			// 
			this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIP.Location = new System.Drawing.Point(77, 50);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(140, 20);
			this.txtIP.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label2.Location = new System.Drawing.Point(256, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Puerto:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label7.Location = new System.Drawing.Point(18, 28);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Directorio:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(18, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "IP:";
			// 
			// cmdAccept
			// 
			this.cmdAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdAccept.Image = global::BauDevelopSmtpServer.Properties.Resources.Start;
			this.cmdAccept.Location = new System.Drawing.Point(467, 102);
			this.cmdAccept.Name = "cmdAccept";
			this.cmdAccept.Size = new System.Drawing.Size(96, 26);
			this.cmdAccept.TabIndex = 2;
			this.cmdAccept.Text = "&Aceptar";
			this.cmdAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdAccept.UseVisualStyleBackColor = true;
			this.cmdAccept.Click += new System.EventHandler(this.cmdAccept_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Image = global::BauDevelopSmtpServer.Properties.Resources.Delete;
			this.cmdCancel.Location = new System.Drawing.Point(579, 102);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(96, 26);
			this.cmdCancel.TabIndex = 3;
			this.cmdCancel.Text = "&Cancelar";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(24, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(301, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "La nueva configuración se aplica cuando reinicie la aplicación";
			// 
			// frmProperties
			// 
			this.AcceptButton = this.cmdAccept;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size(684, 138);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdAccept);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmProperties";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Propiedades";
			this.Load += new System.EventHandler(this.frmProperties_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private Bau.Controls.Files.TextBoxSelectPath fnPathEMails;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdAccept;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Label label3;
	}
}