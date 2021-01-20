namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_NETFramework_NETCLRInterop {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		NumberofCCWs,
		Numberofmarshalling,
		NumberofStubs,
		NumberofTLBexportsPersec,
		NumberofTLBimportsPersec
	}

	public static class Win32_PerfRawData_NETFramework_NETCLRInteropExtension {
		public static string GetWMIValue(this Win32_PerfRawData_NETFramework_NETCLRInterop enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_NETFramework_NETCLRInterop", enumOption.ToString());
	}
}