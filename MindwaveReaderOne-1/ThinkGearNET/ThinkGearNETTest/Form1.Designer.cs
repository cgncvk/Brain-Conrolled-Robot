namespace ThinkGearNETTest
{
	partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblAttention = new System.Windows.Forms.Label();
            this.lblMeditation = new System.Windows.Forms.Label();
            this.btnEnableBlink = new System.Windows.Forms.Button();
            this.btnDisableBlink = new System.Windows.Forms.Button();
            this.groupFile = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGamma2 = new System.Windows.Forms.Label();
            this.lblGamma1 = new System.Windows.Forms.Label();
            this.lblBeta2 = new System.Windows.Forms.Label();
            this.lblBeta1 = new System.Windows.Forms.Label();
            this.lblTheta = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblAlpha2 = new System.Windows.Forms.Label();
            this.lblAlpha1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblAttention2 = new System.Windows.Forms.Label();
            this.lblConnected = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnPick = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupFile.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(35, 96);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(158, 177);
            this.txtState.Multiline = true;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(162, 229);
            this.txtState.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM Port:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(158, 96);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(84, 23);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblAttention
            // 
            this.lblAttention.AutoSize = true;
            this.lblAttention.Location = new System.Drawing.Point(175, 140);
            this.lblAttention.Name = "lblAttention";
            this.lblAttention.Size = new System.Drawing.Size(49, 13);
            this.lblAttention.TabIndex = 5;
            this.lblAttention.Text = "Attention";
            // 
            // lblMeditation
            // 
            this.lblMeditation.AutoSize = true;
            this.lblMeditation.Location = new System.Drawing.Point(250, 140);
            this.lblMeditation.Name = "lblMeditation";
            this.lblMeditation.Size = new System.Drawing.Size(56, 13);
            this.lblMeditation.TabIndex = 5;
            this.lblMeditation.Text = "Meditation";
            // 
            // btnEnableBlink
            // 
            this.btnEnableBlink.Location = new System.Drawing.Point(12, 340);
            this.btnEnableBlink.Name = "btnEnableBlink";
            this.btnEnableBlink.Size = new System.Drawing.Size(84, 23);
            this.btnEnableBlink.TabIndex = 6;
            this.btnEnableBlink.Text = "Enable Blink";
            this.btnEnableBlink.UseVisualStyleBackColor = true;
            this.btnEnableBlink.Click += new System.EventHandler(this.btnEnableBlink_Click);
            // 
            // btnDisableBlink
            // 
            this.btnDisableBlink.Location = new System.Drawing.Point(12, 383);
            this.btnDisableBlink.Name = "btnDisableBlink";
            this.btnDisableBlink.Size = new System.Drawing.Size(84, 23);
            this.btnDisableBlink.TabIndex = 7;
            this.btnDisableBlink.Text = "Disable Blink";
            this.btnDisableBlink.UseVisualStyleBackColor = true;
            this.btnDisableBlink.Click += new System.EventHandler(this.btnDisableBlink_Click);
            // 
            // groupFile
            // 
            this.groupFile.Controls.Add(this.label11);
            this.groupFile.Controls.Add(this.label10);
            this.groupFile.Controls.Add(this.label9);
            this.groupFile.Controls.Add(this.label8);
            this.groupFile.Controls.Add(this.label7);
            this.groupFile.Controls.Add(this.label6);
            this.groupFile.Controls.Add(this.label5);
            this.groupFile.Controls.Add(this.label4);
            this.groupFile.Controls.Add(this.label3);
            this.groupFile.Controls.Add(this.lblGamma2);
            this.groupFile.Controls.Add(this.lblGamma1);
            this.groupFile.Controls.Add(this.lblBeta2);
            this.groupFile.Controls.Add(this.lblBeta1);
            this.groupFile.Controls.Add(this.lblTheta);
            this.groupFile.Controls.Add(this.btnStop);
            this.groupFile.Controls.Add(this.lblStart);
            this.groupFile.Controls.Add(this.lblAlpha2);
            this.groupFile.Controls.Add(this.lblAlpha1);
            this.groupFile.Controls.Add(this.lblTime);
            this.groupFile.Controls.Add(this.lblDelta);
            this.groupFile.Controls.Add(this.btnFile);
            this.groupFile.Location = new System.Drawing.Point(358, 165);
            this.groupFile.Name = "groupFile";
            this.groupFile.Size = new System.Drawing.Size(322, 241);
            this.groupFile.TabIndex = 9;
            this.groupFile.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.GhostWhite;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(164, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Gamma2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.GhostWhite;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(164, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Gamma1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.GhostWhite;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(178, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Beta2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.GhostWhite;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(178, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Beta1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.GhostWhite;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(25, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Alpha2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.GhostWhite;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(25, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Alpha1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(30, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Theta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Delta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.GhostWhite;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Time:";
            // 
            // lblGamma2
            // 
            this.lblGamma2.AutoSize = true;
            this.lblGamma2.Location = new System.Drawing.Point(224, 150);
            this.lblGamma2.Name = "lblGamma2";
            this.lblGamma2.Size = new System.Drawing.Size(49, 13);
            this.lblGamma2.TabIndex = 21;
            this.lblGamma2.Text = "Gamma2";
            // 
            // lblGamma1
            // 
            this.lblGamma1.AutoSize = true;
            this.lblGamma1.Location = new System.Drawing.Point(224, 126);
            this.lblGamma1.Name = "lblGamma1";
            this.lblGamma1.Size = new System.Drawing.Size(49, 13);
            this.lblGamma1.TabIndex = 20;
            this.lblGamma1.Text = "Gamma1";
            // 
            // lblBeta2
            // 
            this.lblBeta2.AutoSize = true;
            this.lblBeta2.Location = new System.Drawing.Point(224, 104);
            this.lblBeta2.Name = "lblBeta2";
            this.lblBeta2.Size = new System.Drawing.Size(35, 13);
            this.lblBeta2.TabIndex = 19;
            this.lblBeta2.Text = "Beta2";
            // 
            // lblBeta1
            // 
            this.lblBeta1.AutoSize = true;
            this.lblBeta1.Location = new System.Drawing.Point(224, 80);
            this.lblBeta1.Name = "lblBeta1";
            this.lblBeta1.Size = new System.Drawing.Size(35, 13);
            this.lblBeta1.TabIndex = 18;
            this.lblBeta1.Text = "Beta1";
            // 
            // lblTheta
            // 
            this.lblTheta.AutoSize = true;
            this.lblTheta.Location = new System.Drawing.Point(75, 128);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(35, 13);
            this.lblTheta.TabIndex = 17;
            this.lblTheta.Text = "Theta";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(197, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(76, 39);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop - End of File";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(127, 22);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(40, 16);
            this.lblStart.TabIndex = 15;
            this.lblStart.Text = "Stop";
            // 
            // lblAlpha2
            // 
            this.lblAlpha2.AutoSize = true;
            this.lblAlpha2.Location = new System.Drawing.Point(75, 177);
            this.lblAlpha2.Name = "lblAlpha2";
            this.lblAlpha2.Size = new System.Drawing.Size(40, 13);
            this.lblAlpha2.TabIndex = 14;
            this.lblAlpha2.Text = "Alpha2";
            // 
            // lblAlpha1
            // 
            this.lblAlpha1.AutoSize = true;
            this.lblAlpha1.Location = new System.Drawing.Point(75, 150);
            this.lblAlpha1.Name = "lblAlpha1";
            this.lblAlpha1.Size = new System.Drawing.Size(40, 13);
            this.lblAlpha1.TabIndex = 10;
            this.lblAlpha1.Text = "Alpha1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(72, 80);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(73, 106);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(32, 13);
            this.lblDelta.TabIndex = 10;
            this.lblDelta.Text = "Delta";
            // 
            // btnFile
            // 
            this.btnFile.Enabled = false;
            this.btnFile.Location = new System.Drawing.Point(22, 19);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(80, 39);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Start - Save to File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblAttention2
            // 
            this.lblAttention2.AutoSize = true;
            this.lblAttention2.Location = new System.Drawing.Point(199, 161);
            this.lblAttention2.Name = "lblAttention2";
            this.lblAttention2.Size = new System.Drawing.Size(49, 13);
            this.lblAttention2.TabIndex = 11;
            this.lblAttention2.Text = "Attention";
            this.lblAttention2.Visible = false;
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.BackColor = System.Drawing.Color.White;
            this.lblConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected.Location = new System.Drawing.Point(354, 133);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(96, 20);
            this.lblConnected.TabIndex = 12;
            this.lblConnected.Text = "Connected";
            this.lblConnected.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 134);
            this.listBox1.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(44, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 20);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Mindwave Reader One";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDescription.Location = new System.Drawing.Point(64, 66);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 16);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "One Line Per Second";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFolder);
            this.groupBox1.Controls.Add(this.btnPick);
            this.groupBox1.Location = new System.Drawing.Point(275, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 92);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(19, 58);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(204, 13);
            this.lblFolder.TabIndex = 19;
            this.lblFolder.Text = "Please pick a folder to save the results to:";
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(17, 19);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(178, 23);
            this.btnPick.TabIndex = 18;
            this.btnPick.Text = "Pick Folder to Save File To";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(711, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.lblAttention2);
            this.Controls.Add(this.groupFile);
            this.Controls.Add(this.btnDisableBlink);
            this.Controls.Add(this.btnEnableBlink);
            this.Controls.Add(this.lblMeditation);
            this.Controls.Add(this.lblAttention);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mindwave Reader One";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupFile.ResumeLayout(false);
            this.groupFile.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.Label lblAttention;
		private System.Windows.Forms.Label lblMeditation;
		private System.Windows.Forms.Button btnEnableBlink;
        private System.Windows.Forms.Button btnDisableBlink;
        private System.Windows.Forms.GroupBox groupFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblAlpha1;
        private System.Windows.Forms.Label lblAlpha2;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTheta;
        private System.Windows.Forms.Label lblGamma2;
        private System.Windows.Forms.Label lblGamma1;
        private System.Windows.Forms.Label lblBeta2;
        private System.Windows.Forms.Label lblBeta1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAttention2;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

