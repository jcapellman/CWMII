namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_aspnetstate_ASPNETStateService {
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

	public static class Win32_PerfFormattedData_aspnetstate_ASPNETStateServiceExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_aspnetstate_ASPNETStateService enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_aspnetstate_ASPNETStateService", enumOption.ToString());
	}
}