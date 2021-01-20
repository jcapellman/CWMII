namespace CWMII.lib.Enums {
	public enum Win32_UTCTime {
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

	public static class Win32_UTCTimeExtension {
		public static string GetWMIValue(this Win32_UTCTime enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_UTCTime", enumOption.ToString());
	}
}