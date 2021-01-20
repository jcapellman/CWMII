namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		RunningTime,
		UtilizationPercentage
	}

	public static class Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngineExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_GPUPerformanceCounters_GPUEngine", enumOption.ToString());
	}
}