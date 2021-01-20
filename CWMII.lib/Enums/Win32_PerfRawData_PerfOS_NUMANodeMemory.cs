namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_PerfOS_NUMANodeMemory {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AvailableMBytes,
		FreeAndZeroPageListMBytes,
		StandbyListMBytes,
		TotalMBytes
	}

	public static class Win32_PerfRawData_PerfOS_NUMANodeMemoryExtension {
		public static string GetWMIValue(this Win32_PerfRawData_PerfOS_NUMANodeMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_PerfOS_NUMANodeMemory", enumOption.ToString());
	}
}