namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryBalancer {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AvailableMemory,
		AvailableMemoryForBalancing,
		AveragePressure,
		SystemCurrentPressure
	}

	public static class Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryBalancerExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryBalancer enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_BalancerStats_HyperVDynamicMemoryBalancer", enumOption.ToString());
	}
}