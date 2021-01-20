namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_GPUPerformanceCounters_GPUNonLocalAdapterMemory {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		NonLocalUsage
	}

	public static class Win32_PerfRawData_GPUPerformanceCounters_GPUNonLocalAdapterMemoryExtension {
		public static string GetWMIValue(this Win32_PerfRawData_GPUPerformanceCounters_GPUNonLocalAdapterMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_GPUPerformanceCounters_GPUNonLocalAdapterMemory", enumOption.ToString());
	}
}