namespace TestSmtpServer
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.fnPathEMails = new Bau.Controls.Files.TextBoxSelectPath();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdSend = new System.Windows.Forms.Button();
			this.txtBody = new System.Windows.Forms.TextBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.txtEMailTarget = new System.Windows.Forms.TextBox();
			this.txtEMailSource = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmdService = new System.Windows.Forms.Button();
			this.cmdConnect = new System.Windows.Forms.Button();
			this.cmdDisconnect = new System.Windows.Forms.Button();
			this.cmdConsole = new System.Windows.Forms.Button();
			this.fnApplication = new Bau.Controls.Files.TextBoxSelectFile();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.lswFiles = new Bau.Controls.List.ListViewExtended();
			this.cmdRefreshFiles = new System.Windows.Forms.Button();
			this.cmdDeleteFiles = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage3.SuspendLayout();
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
			this.groupBox1.Location = new System.Drawing.Point(9, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(855, 96);
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
			this.fnPathEMails.Location = new System.Drawing.Point(77, 27);
			this.fnPathEMails.Margin = new System.Windows.Forms.Padding(0);
			this.fnPathEMails.MaximumSize = new System.Drawing.Size(11667, 20);
			this.fnPathEMails.MinimumSize = new System.Drawing.Size(233, 20);
			this.fnPathEMails.Name = "fnPathEMails";
			this.fnPathEMails.PathName = "";
			this.fnPathEMails.Size = new System.Drawing.Size(765, 20);
			this.fnPathEMails.TabIndex = 1;
			// 
			// txtPort
			// 
			this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPort.Location = new System.Drawing.Point(278, 52);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(31, 20);
			this.txtPort.TabIndex = 5;
			// 
			// txtIP
			// 
			this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIP.Location = new System.Drawing.Point(77, 53);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(140, 20);
			this.txtIP.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label2.Location = new System.Drawing.Point(229, 56);
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
			this.label7.Location = new System.Drawing.Point(18, 27);
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
			this.label1.Location = new System.Drawing.Point(18, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "IP:";
			// 
			// cmdSend
			// 
			this.cmdSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdSend.Location = new System.Drawing.Point(740, 419);
			this.cmdSend.Name = "cmdSend";
			this.cmdSend.Size = new System.Drawing.Size(96, 26);
			this.cmdSend.TabIndex = 3;
			this.cmdSend.Text = "Enviar";
			this.cmdSend.UseVisualStyleBackColor = true;
			this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
			// 
			// txtBody
			// 
			this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBody.Location = new System.Drawing.Point(17, 88);
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(821, 325);
			this.txtBody.TabIndex = 8;
			this.txtBody.Text = "Cuerpo del mensaje de prueba";
			// 
			// txtSubject
			// 
			this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubject.Location = new System.Drawing.Point(89, 60);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(749, 20);
			this.txtSubject.TabIndex = 7;
			this.txtSubject.Text = "Mensaje de prueba";
			// 
			// txtEMailTarget
			// 
			this.txtEMailTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEMailTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEMailTarget.Location = new System.Drawing.Point(89, 34);
			this.txtEMailTarget.Name = "txtEMailTarget";
			this.txtEMailTarget.Size = new System.Drawing.Size(749, 20);
			this.txtEMailTarget.TabIndex = 5;
			this.txtEMailTarget.Text = "target@micro.com";
			// 
			// txtEMailSource
			// 
			this.txtEMailSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEMailSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEMailSource.Location = new System.Drawing.Point(88, 8);
			this.txtEMailSource.Name = "txtEMailSource";
			this.txtEMailSource.Size = new System.Drawing.Size(748, 20);
			this.txtEMailSource.TabIndex = 1;
			this.txtEMailSource.Text = "jbautistam@micro.com";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label6.Location = new System.Drawing.Point(15, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Asunto:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label5.Location = new System.Drawing.Point(15, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Destinatario:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label4.Location = new System.Drawing.Point(15, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Usuario:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtLog);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
			this.tabPage2.Size = new System.Drawing.Size(770, 443);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Log";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtLog
			// 
			this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLog.Location = new System.Drawing.Point(5, 5);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.Size = new System.Drawing.Size(760, 433);
			this.txtLog.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.cmdSend);
			this.tabPage1.Controls.Add(this.txtBody);
			this.tabPage1.Controls.Add(this.txtSubject);
			this.tabPage1.Controls.Add(this.txtEMailTarget);
			this.tabPage1.Controls.Add(this.txtEMailSource);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(847, 457);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Correo";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(9, 205);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(855, 483);
			this.tabControl1.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.cmdService);
			this.groupBox2.Controls.Add(this.cmdConnect);
			this.groupBox2.Controls.Add(this.cmdDisconnect);
			this.groupBox2.Controls.Add(this.cmdConsole);
			this.groupBox2.Controls.Add(this.fnApplication);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.groupBox2.Location = new System.Drawing.Point(9, 114);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(855, 85);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ejecutable";
			// 
			// cmdService
			// 
			this.cmdService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdService.ForeColor = System.Drawing.Color.Black;
			this.cmdService.Location = new System.Drawing.Point(726, 51);
			this.cmdService.Name = "cmdService";
			this.cmdService.Size = new System.Drawing.Size(114, 23);
			this.cmdService.TabIndex = 5;
			this.cmdService.Text = "Lanzar servicio";
			this.cmdService.UseVisualStyleBackColor = true;
			this.cmdService.Click += new System.EventHandler(this.cmdService_Click);
			// 
			// cmdConnect
			// 
			this.cmdConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdConnect.ForeColor = System.Drawing.Color.Black;
			this.cmdConnect.Location = new System.Drawing.Point(89, 51);
			this.cmdConnect.Name = "cmdConnect";
			this.cmdConnect.Size = new System.Drawing.Size(114, 23);
			this.cmdConnect.TabIndex = 2;
			this.cmdConnect.Text = "Conectar librería";
			this.cmdConnect.UseVisualStyleBackColor = true;
			this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
			// 
			// cmdDisconnect
			// 
			this.cmdDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdDisconnect.ForeColor = System.Drawing.Color.Black;
			this.cmdDisconnect.Location = new System.Drawing.Point(209, 51);
			this.cmdDisconnect.Name = "cmdDisconnect";
			this.cmdDisconnect.Size = new System.Drawing.Size(114, 23);
			this.cmdDisconnect.TabIndex = 3;
			this.cmdDisconnect.Text = "Desconectar librería";
			this.cmdDisconnect.UseVisualStyleBackColor = true;
			this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
			// 
			// cmdConsole
			// 
			this.cmdConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdConsole.ForeColor = System.Drawing.Color.Black;
			this.cmdConsole.Location = new System.Drawing.Point(596, 51);
			this.cmdConsole.Name = "cmdConsole";
			this.cmdConsole.Size = new System.Drawing.Size(114, 23);
			this.cmdConsole.TabIndex = 4;
			this.cmdConsole.Text = "Lanzar consola";
			this.cmdConsole.UseVisualStyleBackColor = true;
			this.cmdConsole.Click += new System.EventHandler(this.cmdConsole_Click);
			// 
			// fnApplication
			// 
			this.fnApplication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fnApplication.BackColorEdit = System.Drawing.SystemColors.Window;
			this.fnApplication.FileName = "";
			this.fnApplication.Filter = "Archivos ejecutables|*.exe|Todos los archivos|*.*";
			this.fnApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fnApplication.ForeColor = System.Drawing.Color.Black;
			this.fnApplication.Location = new System.Drawing.Point(89, 21);
			this.fnApplication.Margin = new System.Windows.Forms.Padding(0);
			this.fnApplication.MaximumSize = new System.Drawing.Size(11667, 20);
			this.fnApplication.MinimumSize = new System.Drawing.Size(117, 20);
			this.fnApplication.Name = "fnApplication";
			this.fnApplication.Size = new System.Drawing.Size(753, 20);
			this.fnApplication.TabIndex = 1;
			this.fnApplication.Type = Bau.Controls.Files.TextBoxSelectFile.FileSelectType.Load;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label8.Location = new System.Drawing.Point(14, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Aplicación:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.lswFiles);
			this.tabPage3.Controls.Add(this.cmdDeleteFiles);
			this.tabPage3.Controls.Add(this.cmdRefreshFiles);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(763, 401);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Correos recibidos";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// lswFiles
			// 
			this.lswFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lswFiles.FullRowSelect = true;
			this.lswFiles.GroupWithColumnDoubleClick = false;
			this.lswFiles.HideSelection = false;
			this.lswFiles.Location = new System.Drawing.Point(6, 7);
			this.lswFiles.Name = "lswFiles";
			this.lswFiles.SelectedKey = null;
			this.lswFiles.Size = new System.Drawing.Size(747, 353);
			this.lswFiles.SortWithColumnClick = false;
			this.lswFiles.TabIndex = 0;
			this.lswFiles.UseCompatibleStateImageBehavior = false;
			this.lswFiles.View = System.Windows.Forms.View.Details;
			this.lswFiles.ItemDoubleClick += new Bau.Controls.List.ListViewExtended.ItemDoubleClickHandler(this.lswFiles_ItemDoubleClick);
			// 
			// cmdRefreshFiles
			// 
			this.cmdRefreshFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdRefreshFiles.Location = new System.Drawing.Point(6, 366);
			this.cmdRefreshFiles.Name = "cmdRefreshFiles";
			this.cmdRefreshFiles.Size = new System.Drawing.Size(96, 26);
			this.cmdRefreshFiles.TabIndex = 1;
			this.cmdRefreshFiles.Text = "Actualizar";
			this.cmdRefreshFiles.UseVisualStyleBackColor = true;
			this.cmdRefreshFiles.Click += new System.EventHandler(this.cmdRefreshFiles_Click);
			// 
			// cmdDeleteFiles
			// 
			this.cmdDeleteFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cmdDeleteFiles.Location = new System.Drawing.Point(108, 366);
			this.cmdDeleteFiles.Name = "cmdDeleteFiles";
			this.cmdDeleteFiles.Size = new System.Drawing.Size(96, 26);
			this.cmdDeleteFiles.TabIndex = 2;
			this.cmdDeleteFiles.Text = "Borrar";
			this.cmdDeleteFiles.UseVisualStyleBackColor = true;
			this.cmdDeleteFiles.Click += new System.EventHandler(this.cmdDeleteFiles_Click);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label9.Location = new System.Drawing.Point(223, 373);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(271, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Pulse dos veces sobre el nombre de archivo para abrirlo";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(869, 692);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(637, 711);
			this.Name = "frmMain";
			this.Text = "Pruebas del servidor SMTP";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmdSend;
		private Bau.Controls.Files.TextBoxSelectPath fnPathEMails;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBody;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.TextBox txtEMailTarget;
		private System.Windows.Forms.TextBox txtEMailSource;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.GroupBox groupBox2;
		private Bau.Controls.Files.TextBoxSelectFile fnApplication;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button cmdService;
		private System.Windows.Forms.Button cmdConsole;
		private System.Windows.Forms.Button cmdConnect;
		private System.Windows.Forms.Button cmdDisconnect;
		private System.Windows.Forms.TabPage tabPage3;
		private Bau.Controls.List.ListViewExtended lswFiles;
		private System.Windows.Forms.Button cmdDeleteFiles;
		private System.Windows.Forms.Button cmdRefreshFiles;
		private System.Windows.Forms.Label label9;
	}
}

