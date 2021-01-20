namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_NETFramework_NETCLRJit {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ILBytesJittedPersec,
		NumberofILBytesJitted,
		NumberofMethodsJitted,
		PercentTimeinJit,
		PercentTimeinJit_Base,
		StandardJitFailures,
		TotalNumberofILBytesJitted
	}

	public static class Win32_PerfRawData_NETFramework_NETCLRJitExtension {
		public static string GetWMIValue(this Win32_PerfRawData_NETFramework_NETCLRJit enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_NETFramework_NETCLRJit", enumOption.ToString());
	}
}