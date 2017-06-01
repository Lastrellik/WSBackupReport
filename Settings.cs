using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WSBackupReport {

	public class Settings {

		public string fileName { get; set; }
		private Dictionary<string, string> properties;

		public static void Main(string[] args) {
			Console.WriteLine("Did some stuff");
			Settings settings = new Settings("test.ini");
		}

		public Settings(string fileName) {
			if (!isValidFileName(fileName)) throw new ArgumentException(
				"The fileName doesn't end in .ini");
			this.fileName = fileName;
			this.properties = new Dictionary<string, string>();
			File.Create(fileName);
		}

		private bool isValidFileName(string fileName) {
			return (fileName.EndsWith("ini"));
		}

		public void setAttribute(string key, string value) {
			properties.Add(key, value);
		}

		public string getAttribute(string key) {
			return properties[key];
		}
	}
}
