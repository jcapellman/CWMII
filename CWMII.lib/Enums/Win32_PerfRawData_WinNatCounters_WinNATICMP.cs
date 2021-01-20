namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_WinNatCounters_WinNATICMP {
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

	public static class Win32_PerfRawData_WinNatCounters_WinNATICMPExtension {
		public static string GetWMIValue(this Win32_PerfRawData_WinNatCounters_WinNATICMP enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_WinNatCounters_WinNATICMP", enumOption.ToString());
	}
}