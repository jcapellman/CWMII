namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_PerfOS_PagingFile {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		PercentUsage,
		PercentUsage_Base,
		PercentUsagePeak,
		PercentUsagePeak_Base
	}

	public static class Win32_PerfRawData_PerfOS_PagingFileExtension {
		public static string GetWMIValue(this Win32_PerfRawData_PerfOS_PagingFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_PerfOS_PagingFile", enumOption.ToString());
	}
}