namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_NETFramework_NETCLRSecurity {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		NumberLinkTimeChecks,
		PercentTimeinRTchecks,
		PercentTimeinRTchecks_Base,
		PercentTimeSigAuthenticating,
		StackWalkDepth,
		TotalRuntimeChecks
	}

	public static class Win32_PerfRawData_NETFramework_NETCLRSecurityExtension {
		public static string GetWMIValue(this Win32_PerfRawData_NETFramework_NETCLRSecurity enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_NETFramework_NETCLRSecurity", enumOption.ToString());
	}
}