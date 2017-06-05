using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WSBackupReport {

	public class ConfigManager {
		private const string CONFIG_FILE_NAME = "WSBackupReport.ini";
		private StreamWriter configFileWriter;
		private StreamReader configFileReader;
		private bool isFirstRun;
		private Dictionary<string, string> attributeTable;

		public static void Main(string[] args) {
			ConfigManager manager = new ConfigManager();
			Console.WriteLine(File.GetCreationTime(CONFIG_FILE_NAME) > DateTime.Now.AddMinutes(-10));
		}

		public ConfigManager() {
			isFirstRun = !File.Exists(CONFIG_FILE_NAME);
			attributeTable = new Dictionary<string, string>();
			parseConfigFile();
			configFileWriter = new StreamWriter(CONFIG_FILE_NAME);
		}

		public bool isInitialRun() {
			return isFirstRun;
		}

		private void parseConfigFile() {
			if (isFirstRun) return;
			configFileReader = new StreamReader(CONFIG_FILE_NAME);
			String currentString;
			while((currentString = configFileReader.ReadLine()) != null) {
				attributeTable.Add(currentString.Split('=')[0], currentString.Split('=')[1]);
			}
			configFileReader.Close();
		}

		public void setAttribute(String key, String value) {
			attributeTable.Add(key.ToUpper(), value);
		}

		public string getAttribute(string key) {
			return attributeTable[key.ToUpper()];
		}

		public void close() {
			string[] keys = attributeTable.Keys.ToArray();
			string[] values = attributeTable.Values.ToArray();
			for(int i = 0; i < keys.Length; i++) {
				configFileWriter.WriteLine(keys[i] + "=" + values[i]);
			}
			configFileWriter.Close();
		}
	}
}
