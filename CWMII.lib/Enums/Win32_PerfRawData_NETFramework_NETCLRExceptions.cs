namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_NETFramework_NETCLRExceptions {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		NumberofExcepsThrown,
		NumberofExcepsThrownPersec,
		NumberofFiltersPersec,
		NumberofFinallysPersec,
		ThrowToCatchDepthPersec
	}

	public static class Win32_PerfRawData_NETFramework_NETCLRExceptionsExtension {
		public static string GetWMIValue(this Win32_PerfRawData_NETFramework_NETCLRExceptions enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_NETFramework_NETCLRExceptions", enumOption.ToString());
	}
}