using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WSBackupReport {
	public partial class WSBackupReport : Form {
		private ConfigManager configManager;

		public static void Main(string[] args) {
			WSBackupReport wsbrpt = new WSBackupReport();
			wsbrpt.loadSavedGuiData();
			var dialogResult = wsbrpt.ShowDialog();
		}

		public WSBackupReport() {
			InitializeComponent();
			configManager = new ConfigManager();
		}

		public void loadSavedGuiData() {
			if (configManager.isInitialRun()) return;
			SmtpServerTextBox.Text = configManager.getAttribute("SmtpServer");
			EmailAddressTextBox.Text = configManager.getAttribute("EmailAddress");
			UsernameTextBox.Text = configManager.getAttribute("Username");
			PasswordTextBox.Text = configManager.getAttribute("Password");
			PortTextBox.Text = configManager.getAttribute("Port");
			RecipientEmailTextBox.Text = configManager.getAttribute("RecipientEmailAddresses");
			if (configManager.getAttribute("AlertOnSuccessfulBackup") == "True") AlertWhenSuccessfulCheckbox.Checked = true;
		}

		private void OkButton_Click(object sender, EventArgs e) {
			if (isValidInput()) {
				buildConfigFile();
				configManager.close();
				Application.Exit();
			}
		}

		private bool isValidInput() {
			return SmtpServerTextBox.Text != "" &&
				EmailAddressTextBox.Text != "" &&
				UsernameTextBox.Text != "" &&
				PasswordTextBox.Text != "" &&
				PortTextBox.Text != "" &&
				RecipientEmailTextBox.Text != "";
		}

		private void buildConfigFile() {
			configManager.setAttribute("SmtpServer", SmtpServerTextBox.Text);
			configManager.setAttribute("EmailAddress", EmailAddressTextBox.Text);
			configManager.setAttribute("Username", UsernameTextBox.Text);
			configManager.setAttribute("Password", PasswordTextBox.Text);
			configManager.setAttribute("Port", PortTextBox.Text);
			configManager.setAttribute("RecipientEmailAddresses", RecipientEmailTextBox.Text);
			if (AlertWhenSuccessfulCheckbox.Checked) {
				configManager.setAttribute("AlertOnSuccessfulBackup", "True");
			} else {
				configManager.setAttribute("AlertOnSuccessfulBackup", "False");
			}
		}

		private void CancelButton_Click(object sender, EventArgs e) {
			configManager.close();
			Application.Exit();
		}
	}
}
