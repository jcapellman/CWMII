namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_EventLogSubscriptions {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		EventfilteroperationsPersec,
		EventsPersec
	}

	public static class Win32_PerfRawData_Counters_EventLogSubscriptionsExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_EventLogSubscriptions enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_EventLogSubscriptions", enumOption.ToString());
	}
}