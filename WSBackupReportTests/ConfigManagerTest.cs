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
			collectGarbage();
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
		public void TestIsInitialRun() {
			manager = null;
			collectGarbage();
			File.Delete(CONFIG_FILE_NAME);
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

		private void collectGarbage() {
			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();
		}
		
	}
}
