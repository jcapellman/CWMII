namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_GPUPerformanceCounters_GPULocalAdapterMemory {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		LocalUsage
	}

	public static class Win32_PerfRawData_GPUPerformanceCounters_GPULocalAdapterMemoryExtension {
		public static string GetWMIValue(this Win32_PerfRawData_GPUPerformanceCounters_GPULocalAdapterMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_GPUPerformanceCounters_GPULocalAdapterMemory", enumOption.ToString());
	}
}