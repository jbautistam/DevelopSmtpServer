namespace BauDevelopSmtpServer
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.trvEMails = new Bau.Controls.Tree.TreeViewExtended();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.imlImages = new System.Windows.Forms.ImageList(this.components);
			this.cmdStart = new System.Windows.Forms.ToolStripButton();
			this.cmdStop = new System.Windows.Forms.ToolStripButton();
			this.cmdOpenEMail = new System.Windows.Forms.ToolStripButton();
			this.cmdRemoveEMail = new System.Windows.Forms.ToolStripButton();
			this.cmdOptions = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdStart,
            this.cmdStop,
            this.toolStripSeparator1,
            this.cmdOpenEMail,
            this.cmdRemoveEMail,
            this.cmdOptions});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(673, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 32);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(667, 495);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.trvEMails);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(659, 469);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Correos";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// trvEMails
			// 
			this.trvEMails.CheckRecursive = false;
			this.trvEMails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.trvEMails.Location = new System.Drawing.Point(3, 3);
			this.trvEMails.Name = "trvEMails";
			this.trvEMails.ShowNodeToolTips = true;
			this.trvEMails.Size = new System.Drawing.Size(653, 463);
			this.trvEMails.TabIndex = 0;
			this.trvEMails.LoadChilds += new Bau.Controls.Tree.TreeViewExtended.LoadChildsHandler(this.trvEMails_LoadChilds);
			this.trvEMails.NodeDoubleClick += new Bau.Controls.Tree.TreeViewExtended.NodeDoubleClickHandler(this.trvEMails_NodeDoubleClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtLog);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(659, 469);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Log";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtLog
			// 
			this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLog.Location = new System.Drawing.Point(3, 3);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.Size = new System.Drawing.Size(653, 463);
			this.txtLog.TabIndex = 1;
			// 
			// imlImages
			// 
			this.imlImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlImages.ImageStream")));
			this.imlImages.TransparentColor = System.Drawing.Color.Transparent;
			this.imlImages.Images.SetKeyName(0, "calendar_view_day.png");
			this.imlImages.Images.SetKeyName(1, "user.png");
			this.imlImages.Images.SetKeyName(2, "user_edit.png");
			this.imlImages.Images.SetKeyName(3, "email.png");
			// 
			// cmdStart
			// 
			this.cmdStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cmdStart.Image = global::BauDevelopSmtpServer.Properties.Resources.Start;
			this.cmdStart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdStart.Name = "cmdStart";
			this.cmdStart.Size = new System.Drawing.Size(23, 22);
			this.cmdStart.Text = "Arrancar";
			this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
			// 
			// cmdStop
			// 
			this.cmdStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cmdStop.Image = global::BauDevelopSmtpServer.Properties.Resources.Stop;
			this.cmdStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdStop.Name = "cmdStop";
			this.cmdStop.Size = new System.Drawing.Size(23, 22);
			this.cmdStop.Text = "Detener";
			this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
			// 
			// cmdOpenEMail
			// 
			this.cmdOpenEMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cmdOpenEMail.Image = global::BauDevelopSmtpServer.Properties.Resources.Open;
			this.cmdOpenEMail.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdOpenEMail.Name = "cmdOpenEMail";
			this.cmdOpenEMail.Size = new System.Drawing.Size(23, 22);
			this.cmdOpenEMail.Text = "Abrir";
			this.cmdOpenEMail.Click += new System.EventHandler(this.cmdOpenEMail_Click);
			// 
			// cmdRemoveEMail
			// 
			this.cmdRemoveEMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cmdRemoveEMail.Image = global::BauDevelopSmtpServer.Properties.Resources.Delete;
			this.cmdRemoveEMail.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdRemoveEMail.Name = "cmdRemoveEMail";
			this.cmdRemoveEMail.Size = new System.Drawing.Size(23, 22);
			this.cmdRemoveEMail.Text = "Borrar";
			this.cmdRemoveEMail.Click += new System.EventHandler(this.cmdRemoveEMail_Click);
			// 
			// cmdOptions
			// 
			this.cmdOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.cmdOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.cmdOptions.Image = global::BauDevelopSmtpServer.Properties.Resources.Properties;
			this.cmdOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdOptions.Name = "cmdOptions";
			this.cmdOptions.Size = new System.Drawing.Size(23, 22);
			this.cmdOptions.Text = "Opciones";
			this.cmdOptions.Click += new System.EventHandler(this.cmdOptions_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 533);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BauDevelopSmtpServer";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton cmdStart;
		private System.Windows.Forms.ToolStripButton cmdStop;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton cmdOpenEMail;
		private System.Windows.Forms.ToolStripButton cmdRemoveEMail;
		private System.Windows.Forms.ToolStripButton cmdOptions;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtLog;
		private Bau.Controls.Tree.TreeViewExtended trvEMails;
		private System.Windows.Forms.ImageList imlImages;
	}
}

