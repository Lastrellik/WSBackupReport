using System;
using WSBackupReport;
using System.IO;
using NUnit.Framework;

namespace WSBackupReportTests {

	[TestFixture]
	public class SettingsTest {

		[SetUp]
		protected void SetUp() {
			//File.Delete("testSettings.ini");
		}

		[TearDown]
		public void TearDown() {
			//File.Delete("testSettings.ini");
		}


		[Test]
		public void TestConstructor_FileDoesNotExist() {
			string fileName = "testSettings.ini";
			File.Delete(fileName);
			bool doesFileExistBefore = File.Exists(fileName);
			Settings settings = new WSBackupReport.Settings(fileName);
			Assert.AreNotEqual(doesFileExistBefore, File.Exists(fileName));
		}

		[Test]
		public void TestConstructor_FileDoesExist() {
			string fileName = "secondTestSettings.ini";
			var theFile = File.Create(fileName);
			theFile.Close();
			bool doesFileExist = File.Exists(fileName);
			Settings settings = new WSBackupReport.Settings(fileName);
			Assert.AreEqual(doesFileExist, File.Exists(fileName));
		}

		[Test]
		public void TestConstructor_InvalidName() {
			Settings settings;
			Assert.Throws<ArgumentException>(() => settings = new WSBackupReport.Settings("testSettings"));
		}

		[Test]
		public void TestConstructor_NullInput() {
			Settings settings;
			Assert.Throws<NullReferenceException>(() => settings = new WSBackupReport.Settings(null));
		}

		[Test]
		public void TestSetAttribute() {
			String fileName = "TestSettings1.ini";
			File.Delete(fileName);
			Settings settings = new Settings(fileName);
			settings.setAttribute("ToEmailAddress", "test@email.com");
			Assert.AreEqual("test@email.com" , settings.getAttribute("ToEmailAddress"));
		}

		[Test]
		public void TestGetAttribute() {
			String fileName = "TestSettings2.ini";
			File.Delete(fileName);
			Settings settings = new Settings(fileName);
			settings.setAttribute("ToEmailAddress", "test@email.com");
			Assert.AreEqual("test@email.com", settings.getAttribute("ToEmailAddress"));
		}
	}
}
