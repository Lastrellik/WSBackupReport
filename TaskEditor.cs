using System;
using Microsoft.Win32.TaskScheduler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSBackupReport {

	public class TaskEditor {
		private EventTrigger eventTrigger;
		private ExecAction execAction;
		private TaskDefinition taskDefinition;
		private TaskService taskService;
		private string emailFilePath = AppDomain.CurrentDomain.BaseDirectory + "EmailAlert.exe";
		private const string TASK_NAME = "WSBackupReport Email Alert";
		private const string TASK_DEFINITION = "Scheduled task designed to send an email " + 
			"in the event of a backup failure in Windows Server Backup";

		public TaskEditor() {
			buildTaskService();
			buildTrigger();
			buildAction();
			buildTaskDefinition();
		}

		private void buildTaskService() {
			taskService = new TaskService();
		}

		private void buildTrigger() {
			eventTrigger = new EventTrigger();
			eventTrigger.Subscription = "<QueryList>" +
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
		}

		private void buildAction() {
			execAction = new ExecAction(emailFilePath);
		}

		private void buildTaskDefinition() {
			taskDefinition = TaskService.Instance.NewTask();
			taskDefinition.RegistrationInfo.Description = TASK_DEFINITION;
			taskDefinition.Principal.LogonType = TaskLogonType.S4U;
			taskDefinition.Principal.RunLevel = TaskRunLevel.Highest;
			taskDefinition.Triggers.Add(eventTrigger);
			taskDefinition.Actions.Add(execAction);
		}

		public bool isTaskCreated() {
			return taskService.GetTask(TASK_NAME) != null;
		}

		public void registerTask() {
			taskService.RootFolder.RegisterTaskDefinition(TASK_NAME, taskDefinition);
		}

		public EventTrigger getTrigger() {
			return eventTrigger;
		}

		public ExecAction getAction() {
			return execAction;
		}

		public TaskDefinition getTaskDefinition() {
			return taskDefinition;
		}

		public TaskService getTaskService() {
			return taskService;
		}		
	}
}