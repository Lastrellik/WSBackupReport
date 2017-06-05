using System;
using WSBackupReport;
using System.IO;
using NUnit.Framework;

namespace WSBackupReportTests {

	[TestFixture]
	public class ConfigManagerTest {
		private const string CONFIG_FILE_NAME = "WSBackupReport.ini";
		private ConfigManager manager;

		[SetUp]
		protected void SetUp() {
			File.Delete(CONFIG_FILE_NAME);
			manager = new ConfigManager();
		}

		[TearDown]
		public void TearDown() {
			manager = null;
			collectGarbage();
			File.Delete(CONFIG_FILE_NAME);
		}

		[Test]
		public void TestConstructor() {
			Assert.IsTrue(File.Exists(CONFIG_FILE_NAME));
		}

		[Test]
		public void TestConstructor_NotFirstTime() {
			manager = null;
			collectGarbage();
			if (!File.Exists(CONFIG_FILE_NAME)) File.Create(CONFIG_FILE_NAME);
			manager = new ConfigManager();
			Assert.IsFalse(manager.isInitialRun());
		}

		[Test]
		public void TestConstructor_ExistingData() {
			resetDataFile();
			StreamWriter writer = new StreamWriter(CONFIG_FILE_NAME);
			writer.WriteLine("KEY1=value1");
			writer.Close();
			manager = new ConfigManager();
			Assert.AreEqual("value1", manager.getAttribute("key1"));
		}

		[Test]
		public void TestConstructor_ExistingData_MultipleLines() {
			resetDataFile();
			StreamWriter writer = new StreamWriter(CONFIG_FILE_NAME);
			writer.WriteLine("KEY1=value1");
			writer.WriteLine("KEY2=value2");
			writer.WriteLine("KEY3=value3");
			writer.Close();
			manager = new ConfigManager();
			Assert.AreEqual("value3", manager.getAttribute("key3"));
		}

		[Test]
		public void TestIsInitialRun() {
			resetDataFile();
			manager = new ConfigManager();
			Assert.IsTrue(manager.isInitialRun());
		}

		[Test]
		public void TestSetAttribute() {
			manager.setAttribute("To Address", "to@emailaddress.com");
			Assert.AreEqual("to@emailaddress.com", manager.getAttribute("To Address"));
		}

		[Test]
		public void TestGetAttribute() {
			manager.setAttribute("To Address", "to@emailaddress.com");
			Assert.AreEqual("to@emailaddress.com", manager.getAttribute("To Address"));
		}

		[Test]
		public void TestClose() {
			String expectedReturn = "KEY=value";
			manager.setAttribute("key", "value");
			manager.close();
			Assert.AreEqual(expectedReturn, File.ReadAllLines(CONFIG_FILE_NAME)[0]);
		}

		[Test]
		public void TestClose_MultipleLines() {
			String expectedReturn = "KEY1=value1\r\nKEY2=value2\r\nKEY3=value3\r\n";
			manager.setAttribute("key1", "value1");
			manager.setAttribute("key2", "value2");
			manager.setAttribute("key3", "value3");
			manager.close();
			Assert.AreEqual(expectedReturn, File.ReadAllText(CONFIG_FILE_NAME));
		}

		private void resetDataFile() {
			manager = null;
			collectGarbage();
			File.Delete(CONFIG_FILE_NAME);
		}

		private void collectGarbage() {
			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();
		}
		
	}
}
