namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_EventTracingforWindows {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		TotalMemoryUsageNonPagedPool,
		TotalMemoryUsagePagedPool,
		TotalNumberofActiveSessions,
		TotalNumberofDistinctDisabledProviders,
		TotalNumberofDistinctEnabledProviders,
		TotalNumberofDistinctPreEnabledProviders
	}

	public static class Win32_PerfRawData_Counters_EventTracingforWindowsExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_EventTracingforWindows enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_EventTracingforWindows", enumOption.ToString());
	}
}