using System;
using Microsoft.Win32.TaskScheduler;
using WSBackupReport;
using System.IO;
using NUnit.Framework;

namespace WSBackupReportTests {

	[TestFixture]
	public class TaskEditorTest {
		TaskEditor editor = new WSBackupReport.TaskEditor();
		TaskService taskService = new TaskService();
		private string EMAIL_FILE_PATH = AppDomain.CurrentDomain.BaseDirectory + "EmailAlert.exe";
		private const string TASK_NAME = "WSBackupReport Email Alert";

		[Test]
		public void TestConstructor() {
		}

		[Test]
		public void TestBuildTrigger() {
			EventTrigger testTrigger = new EventTrigger();
			testTrigger.Subscription = "<QueryList>" +
				"<Query Id=\"0\" Path=\"Microsoft-Windows-Backup\">" +
				"<Select Path=\"Microsoft-Windows-Backup\">" +
				"*[System[EventID=\"5\" or EventID=\"8\"" +
				" or EventID=\"9\" or EventID=\"17\" or EventID=\"18\"" +
				" or EventID=\"19\" or EventID=\"20\" or EventID=\"21\"" +
				" or EventID=\"22\" or EventID=\"49\" or EventID=\"52\"" +
				" or EventID=\"100\" or EventID=\"517\" or EventID=\"518\"" +
				" or EventID=\"521\" or EventID=\"527\" or EventID=\"528\"" +
				" or EventID=\"544\" or EventID=\"545\" or EventID=\"546\"" +
				" or EventID=\"561\" or EventID=\"564\" or EventID=\"612\"" +
				"]]" +
				"</Select></Query></QueryList>";
			Assert.AreEqual(testTrigger, editor.getTrigger());
		}

		[Test]
		public void TestGetTrigger() {
			EventTrigger testTrigger = new EventTrigger();
			testTrigger.Subscription = "<QueryList>" +
				"<Query Id=\"0\" Path=\"Microsoft-Windows-Backup\">" +
				"<Select Path=\"Microsoft-Windows-Backup\">" +
				"*[System[EventID=\"5\" or EventID=\"8\"" +
				" or EventID=\"9\" or EventID=\"17\" or EventID=\"18\"" +
				" or EventID=\"19\" or EventID=\"20\" or EventID=\"21\"" +
				" or EventID=\"22\" or EventID=\"49\" or EventID=\"52\"" +
				" or EventID=\"100\" or EventID=\"517\" or EventID=\"518\"" +
				" or EventID=\"521\" or EventID=\"527\" or EventID=\"528\"" +
				" or EventID=\"544\" or EventID=\"545\" or EventID=\"546\"" +
				" or EventID=\"561\" or EventID=\"564\" or EventID=\"612\"" +
				"]]" +
				"</Select></Query></QueryList>";
			Assert.AreEqual(testTrigger, editor.getTrigger());
		}

		[Test]
		public void TestBuildAction() {
			ExecAction testExecAction = new ExecAction(EMAIL_FILE_PATH);
			Assert.AreEqual(testExecAction.ToString(), editor.getAction().ToString());
		}

		[Test]
		public void TestGetAction() {
			ExecAction testExecAction = new ExecAction(EMAIL_FILE_PATH);
			Assert.AreEqual(testExecAction.ToString(), editor.getAction().ToString());
		}

		[Test]
		public void TestBuildTaskDefinition() {
			TaskDefinition testDefinition = TaskService.Instance.NewTask();
			Assert.AreEqual(testDefinition.ToString(), editor.getTaskDefinition().ToString());
		}

		[Test]
		public void TestGetTaskDefinition() {
			TaskDefinition testDefinition = TaskService.Instance.NewTask();
			Assert.AreEqual(testDefinition.ToString(), editor.getTaskDefinition().ToString());
		}

		[Test]
		public void TestBuildTaskService() {
			TaskService testTaskService = new TaskService();
			Assert.AreEqual(testTaskService.ToString(), editor.getTaskService().ToString());
		}

		[Test]
		public void TestGetTaskService() {
			TaskService testTaskService = new TaskService();
			Assert.AreEqual(testTaskService.ToString(), editor.getTaskService().ToString());
		}

		[Test]
		public void TestIsTaskCreated() {
			bool isCreated = taskService.GetTask(TASK_NAME) != null;
			Assert.AreEqual(isCreated, editor.isTaskCreated());
		}

		[Test]
		public void TestRegisterTask() {
			editor.registerTask();
			Assert.IsTrue(taskService.GetTask(TASK_NAME) != null);
		}
	}
}