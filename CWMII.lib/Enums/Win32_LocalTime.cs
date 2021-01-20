namespace CWMII.lib.Enums {
	public enum Win32_LocalTime {
		Day,
		DayOfWeek,
		Hour,
		Milliseconds,
		Minute,
		Month,
		Quarter,
		Second,
		WeekInMonth,
		Year
	}

	public static class Win32_LocalTimeExtension {
		public static string GetWMIValue(this Win32_LocalTime enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_LocalTime", enumOption.ToString());
	}
}