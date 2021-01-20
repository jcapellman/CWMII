namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_ThermalZoneInformation {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		HighPrecisionTemperature,
		PercentPassiveLimit,
		Temperature,
		ThrottleReasons
	}

	public static class Win32_PerfRawData_Counters_ThermalZoneInformationExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_ThermalZoneInformation enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_ThermalZoneInformation", enumOption.ToString());
	}
}