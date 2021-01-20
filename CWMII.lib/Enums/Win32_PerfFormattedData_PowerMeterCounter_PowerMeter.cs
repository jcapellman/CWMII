namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_PowerMeterCounter_PowerMeter {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		Power,
		PowerBudget
	}

	public static class Win32_PerfFormattedData_PowerMeterCounter_PowerMeterExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_PowerMeterCounter_PowerMeter enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_PowerMeterCounter_PowerMeter", enumOption.ToString());
	}
}