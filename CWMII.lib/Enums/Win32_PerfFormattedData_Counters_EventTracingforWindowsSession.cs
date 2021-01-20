namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_EventTracingforWindowsSession {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		BufferMemoryUsageNonPagedPool,
		BufferMemoryUsagePagedPool,
		EventsLoggedpersec,
		EventsLost,
		NumberofRealTimeConsumers
	}

	public static class Win32_PerfFormattedData_Counters_EventTracingforWindowsSessionExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_EventTracingforWindowsSession enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_EventTracingforWindowsSession", enumOption.ToString());
	}
}