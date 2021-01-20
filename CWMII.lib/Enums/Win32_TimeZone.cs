namespace CWMII.lib.Enums {
	public enum Win32_TimeZone {
		Caption,
		Description,
		SettingID,
		Bias,
		DaylightBias,
		DaylightDay,
		DaylightDayOfWeek,
		DaylightHour,
		DaylightMillisecond,
		DaylightMinute,
		DaylightMonth,
		DaylightName,
		DaylightSecond,
		DaylightYear,
		StandardBias,
		StandardDay,
		StandardDayOfWeek,
		StandardHour,
		StandardMillisecond,
		StandardMinute,
		StandardMonth,
		StandardName,
		StandardSecond,
		StandardYear
	}

	public static class Win32_TimeZoneExtension {
		public static string GetWMIValue(this Win32_TimeZone enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_TimeZone", enumOption.ToString());
	}
}