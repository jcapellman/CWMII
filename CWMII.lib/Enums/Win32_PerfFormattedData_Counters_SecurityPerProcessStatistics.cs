namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_SecurityPerProcessStatistics {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ContextHandles,
		CredentialHandles
	}

	public static class Win32_PerfFormattedData_Counters_SecurityPerProcessStatisticsExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_SecurityPerProcessStatistics enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_SecurityPerProcessStatistics", enumOption.ToString());
	}
}