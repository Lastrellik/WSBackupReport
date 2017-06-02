using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WSBackupReport {

	public class ConfigManager {
		private const string CONFIG_FILE_NAME = "WSBackupReport.ini";
		private bool isFirstRun = false;
		private Dictionary<string, string> attributeTable;


		public static void Main(string[] args) {
		}

		public ConfigManager() {
			if (!File.Exists(CONFIG_FILE_NAME)) initializeApp();
			parseConfigFile();
		}

		public bool isInitialRun() {
			return isFirstRun;
		}

		private void initializeApp() {
			isFirstRun = true;
			File.Create(CONFIG_FILE_NAME);
		}

		private void parseConfigFile() {
			if (isFirstRun) return;
		}

		public void setAttribute(String key, String value) {
			attributeTable.Add(key.ToUpper(), value);
		}

		public string getAttribute(string key) {
			return attributeTable[key.ToUpper()];
		}
	}
}
