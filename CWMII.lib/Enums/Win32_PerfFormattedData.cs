namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData {
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

	public static class Win32_PerfFormattedDataExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData", enumOption.ToString());
	}
}