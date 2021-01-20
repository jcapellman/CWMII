namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		StateServerSessionsAbandoned,
		StateServerSessionsActive,
		StateServerSessionsTimedOut,
		StateServerSessionsTotal
	}

	public static class Win32_PerfRawDataExtension {
		public static string GetWMIValue(this Win32_PerfRawData enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData", enumOption.ToString());
	}
}