using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSBackupReport;

namespace WSBackupReportTests {
	[TestClass]
	public class SettingsTest {
		[TestMethod]
		public void TestMethod1() {
			Settings settings = new WSBackupReport.Settings();
			Assert.AreEqual(1, 1);
		}
	}
}
