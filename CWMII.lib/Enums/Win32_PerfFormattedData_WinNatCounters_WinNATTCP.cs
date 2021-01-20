namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_WinNatCounters_WinNATTCP {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		NumberOfBindings,
		NumberOfSessions,
		NumExtToIntTranslations,
		NumIntToExtTranslations,
		NumPacketsDropped,
		NumSessionsTimedOut
	}

	public static class Win32_PerfFormattedData_WinNatCounters_WinNATTCPExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_WinNatCounters_WinNATTCP enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_WinNatCounters_WinNATTCP", enumOption.ToString());
	}
}