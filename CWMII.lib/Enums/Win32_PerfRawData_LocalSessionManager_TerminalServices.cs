namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_LocalSessionManager_TerminalServices {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ActiveSessions,
		InactiveSessions,
		TotalSessions
	}

	public static class Win32_PerfRawData_LocalSessionManager_TerminalServicesExtension {
		public static string GetWMIValue(this Win32_PerfRawData_LocalSessionManager_TerminalServices enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_LocalSessionManager_TerminalServices", enumOption.ToString());
	}
}