namespace CWMII.lib.Enums {
	public enum Win32_Perf {
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

	public static class Win32_PerfExtension {
		public static string GetWMIValue(this Win32_Perf enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_Perf", enumOption.ToString());
	}
}