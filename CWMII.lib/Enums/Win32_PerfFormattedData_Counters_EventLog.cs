namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_EventLog {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		Activesubscriptions,
		ELFRPCcallsPersec,
		EnabledChannels,
		EventfilteroperationsPersec,
		EventsPersec,
		WEVTRPCcallsPersec
	}

	public static class Win32_PerfFormattedData_Counters_EventLogExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_EventLog enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_EventLog", enumOption.ToString());
	}
}