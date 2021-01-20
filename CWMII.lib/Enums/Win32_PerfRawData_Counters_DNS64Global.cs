namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_DNS64Global {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AAAAqueriesFailed,
		AAAAqueriesSuccessful,
		AAAASynthesizedrecords,
		IP6ARPAqueriesMatched,
		OtherqueriesFailed,
		OtherqueriesSuccessful
	}

	public static class Win32_PerfRawData_Counters_DNS64GlobalExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_DNS64Global enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_DNS64Global", enumOption.ToString());
	}
}