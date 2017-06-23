namespace WSBackupReport {
	partial class WSBackupReport {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WSBackupReport));
			this.SmtpServerLabel = new System.Windows.Forms.Label();
			this.EmailAddressLabel = new System.Windows.Forms.Label();
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.PortLabel = new System.Windows.Forms.Label();
			this.SmtpServerTextBox = new System.Windows.Forms.TextBox();
			this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.PortTextBox = new System.Windows.Forms.TextBox();
			this.TestSmtpButton = new System.Windows.Forms.Button();
			this.RecipientAddressesLabel = new System.Windows.Forms.Label();
			this.RecipientEmailTextBox = new System.Windows.Forms.TextBox();
			this.AlertWhenSuccessfulCheckbox = new System.Windows.Forms.CheckBox();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SmtpServerLabel
			// 
			resources.ApplyResources(this.SmtpServerLabel, "SmtpServerLabel");
			this.SmtpServerLabel.Name = "SmtpServerLabel";
			// 
			// EmailAddressLabel
			// 
			resources.ApplyResources(this.EmailAddressLabel, "EmailAddressLabel");
			this.EmailAddressLabel.Name = "EmailAddressLabel";
			// 
			// UsernameLabel
			// 
			resources.ApplyResources(this.UsernameLabel, "UsernameLabel");
			this.UsernameLabel.Name = "UsernameLabel";
			// 
			// PasswordLabel
			// 
			resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
			this.PasswordLabel.Name = "PasswordLabel";
			// 
			// PortLabel
			// 
			resources.ApplyResources(this.PortLabel, "PortLabel");
			this.PortLabel.Name = "PortLabel";
			// 
			// SmtpServerTextBox
			// 
			this.SmtpServerTextBox.AcceptsTab = true;
			resources.ApplyResources(this.SmtpServerTextBox, "SmtpServerTextBox");
			this.SmtpServerTextBox.Name = "SmtpServerTextBox";
			// 
			// EmailAddressTextBox
			// 
			this.EmailAddressTextBox.AcceptsTab = true;
			resources.ApplyResources(this.EmailAddressTextBox, "EmailAddressTextBox");
			this.EmailAddressTextBox.Name = "EmailAddressTextBox";
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.AcceptsTab = true;
			resources.ApplyResources(this.UsernameTextBox, "UsernameTextBox");
			this.UsernameTextBox.Name = "UsernameTextBox";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.AcceptsTab = true;
			resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.UseSystemPasswordChar = true;
			// 
			// PortTextBox
			// 
			this.PortTextBox.AcceptsTab = true;
			resources.ApplyResources(this.PortTextBox, "PortTextBox");
			this.PortTextBox.Name = "PortTextBox";
			// 
			// TestSmtpButton
			// 
			resources.ApplyResources(this.TestSmtpButton, "TestSmtpButton");
			this.TestSmtpButton.Name = "TestSmtpButton";
			this.TestSmtpButton.UseVisualStyleBackColor = true;
			// 
			// RecipientAddressesLabel
			// 
			resources.ApplyResources(this.RecipientAddressesLabel, "RecipientAddressesLabel");
			this.RecipientAddressesLabel.Name = "RecipientAddressesLabel";
			// 
			// RecipientEmailTextBox
			// 
			resources.ApplyResources(this.RecipientEmailTextBox, "RecipientEmailTextBox");
			this.RecipientEmailTextBox.Name = "RecipientEmailTextBox";
			// 
			// AlertWhenSuccessfulCheckbox
			// 
			resources.ApplyResources(this.AlertWhenSuccessfulCheckbox, "AlertWhenSuccessfulCheckbox");
			this.AlertWhenSuccessfulCheckbox.Name = "AlertWhenSuccessfulCheckbox";
			this.AlertWhenSuccessfulCheckbox.UseVisualStyleBackColor = true;
			// 
			// OkButton
			// 
			resources.ApplyResources(this.OkButton, "OkButton");
			this.OkButton.Name = "OkButton";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelButton
			// 
			resources.ApplyResources(this.CancelButton, "CancelButton");
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// WSBackupReport
			// 
			this.AcceptButton = this.OkButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.AlertWhenSuccessfulCheckbox);
			this.Controls.Add(this.RecipientEmailTextBox);
			this.Controls.Add(this.RecipientAddressesLabel);
			this.Controls.Add(this.TestSmtpButton);
			this.Controls.Add(this.PortTextBox);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.EmailAddressTextBox);
			this.Controls.Add(this.SmtpServerTextBox);
			this.Controls.Add(this.PortLabel);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.EmailAddressLabel);
			this.Controls.Add(this.SmtpServerLabel);
			this.Name = "WSBackupReport";
			this.ShowIcon = false;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label SmtpServerLabel;
		private System.Windows.Forms.Label EmailAddressLabel;
		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label PortLabel;
		private System.Windows.Forms.TextBox SmtpServerTextBox;
		private System.Windows.Forms.TextBox EmailAddressTextBox;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.TextBox PortTextBox;
		private System.Windows.Forms.Button TestSmtpButton;
		private System.Windows.Forms.Label RecipientAddressesLabel;
		private System.Windows.Forms.TextBox RecipientEmailTextBox;
		private System.Windows.Forms.CheckBox AlertWhenSuccessfulCheckbox;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
	}
}