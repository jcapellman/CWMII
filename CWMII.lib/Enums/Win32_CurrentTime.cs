namespace CWMII.lib.Enums {
	public enum Win32_CurrentTime {
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

	public static class Win32_CurrentTimeExtension {
		public static string GetWMIValue(this Win32_CurrentTime enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_CurrentTime", enumOption.ToString());
	}
}