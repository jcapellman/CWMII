namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_PerfOS_PagingFile {
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
		PercentUsagePeak
	}

	public static class Win32_PerfFormattedData_PerfOS_PagingFileExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_PerfOS_PagingFile enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_PerfOS_PagingFile", enumOption.ToString());
	}
}