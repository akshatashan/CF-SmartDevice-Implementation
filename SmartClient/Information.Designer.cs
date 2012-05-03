namespace SmartClient
{
	partial class frmInformation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MainMenu mainMenu1;

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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.cboUserId = new System.Windows.Forms.ComboBox();
			this.txtUserInformation = new System.Windows.Forms.TextBox();
			this.lblDataReceived = new System.Windows.Forms.Label();
			this.lblDataSent = new System.Windows.Forms.Label();
			this.btnServerCall = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cboUserId
			// 
			this.cboUserId.Items.Add("1");
			this.cboUserId.Items.Add("2");
			this.cboUserId.Location = new System.Drawing.Point(21, 40);
			this.cboUserId.Name = "cboUserId";
			this.cboUserId.Size = new System.Drawing.Size(100, 22);
			this.cboUserId.TabIndex = 13;
			// 
			// txtUserInformation
			// 
			this.txtUserInformation.Location = new System.Drawing.Point(21, 94);
			this.txtUserInformation.Name = "txtUserInformation";
			this.txtUserInformation.Size = new System.Drawing.Size(198, 21);
			this.txtUserInformation.TabIndex = 12;
			// 
			// lblDataReceived
			// 
			this.lblDataReceived.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblDataReceived.Location = new System.Drawing.Point(21, 73);
			this.lblDataReceived.Name = "lblDataReceived";
			this.lblDataReceived.Size = new System.Drawing.Size(160, 18);
			this.lblDataReceived.Text = "Data received from server:";
			// 
			// lblDataSent
			// 
			this.lblDataSent.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblDataSent.Location = new System.Drawing.Point(21, 19);
			this.lblDataSent.Name = "lblDataSent";
			this.lblDataSent.Size = new System.Drawing.Size(118, 18);
			this.lblDataSent.Text = "Data sent to server:";
			// 
			// btnServerCall
			// 
			this.btnServerCall.Location = new System.Drawing.Point(21, 150);
			this.btnServerCall.Name = "btnServerCall";
			this.btnServerCall.Size = new System.Drawing.Size(132, 25);
			this.btnServerCall.TabIndex = 11;
			this.btnServerCall.Text = "Call a service.";
			this.btnServerCall.Click += new System.EventHandler(this.btnServerCall_Click);
			// 
			// frmInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.cboUserId);
			this.Controls.Add(this.txtUserInformation);
			this.Controls.Add(this.lblDataReceived);
			this.Controls.Add(this.lblDataSent);
			this.Controls.Add(this.btnServerCall);
			this.Menu = this.mainMenu1;
			this.Name = "frmInformation";
			this.Text = "Information";
			this.Load += new System.EventHandler(this.frmInformation_Load);
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.ComboBox cboUserId;
		internal System.Windows.Forms.TextBox txtUserInformation;
		internal System.Windows.Forms.Label lblDataReceived;
		internal System.Windows.Forms.Label lblDataSent;
		internal System.Windows.Forms.Button btnServerCall;
	}
}

