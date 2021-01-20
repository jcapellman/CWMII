namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_GPUPerformanceCounters_GPUProcessMemory {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		DedicatedUsage,
		LocalUsage,
		NonLocalUsage,
		SharedUsage,
		TotalCommitted
	}

	public static class Win32_PerfRawData_GPUPerformanceCounters_GPUProcessMemoryExtension {
		public static string GetWMIValue(this Win32_PerfRawData_GPUPerformanceCounters_GPUProcessMemory enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_GPUPerformanceCounters_GPUProcessMemory", enumOption.ToString());
	}
}