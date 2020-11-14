using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace _11th_Homework
{
	class ReminderItem
	{
		public DateTimeOffset AlarmDate { get; set; }
		public string AlarmMessage { get; set; }
		public TimeSpan TimeToAlarm
		{
			get
			{
				return AlarmDate - DateTimeOffset.Now;
			}
		}
		public bool IsOutdated
		{
			get
			{
				return TimeToAlarm > TimeSpan.Zero;
			}
		}
		public ReminderItem() { }

		public ReminderItem(string alarmMessage, DateTimeOffset alarmDate)
		{
			AlarmMessage = alarmMessage;
			AlarmDate = alarmDate;
		}

		public void WriteProperties()
		{
			string outDated = IsOutdated
				? "будильник не просрочен"
				: "будильник просрочен";
			Console.WriteLine($"Дата и время будильника: {AlarmDate}, " +
				$" текст будильника: {AlarmMessage}, " +
				$"\nвремя до срабатывания будильника: {TimeToAlarm}, {outDated}");
		}

	}
}
