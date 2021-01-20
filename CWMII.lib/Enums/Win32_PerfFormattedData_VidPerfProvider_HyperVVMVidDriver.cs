namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidDriver {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		VidPartitions
	}

	public static class Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidDriverExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidDriver enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_VidPerfProvider_HyperVVMVidDriver", enumOption.ToString());
	}
}