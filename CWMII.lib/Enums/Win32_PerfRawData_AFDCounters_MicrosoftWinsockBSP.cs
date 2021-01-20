namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_AFDCounters_MicrosoftWinsockBSP {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		DroppedDatagrams,
		DroppedDatagramsPersec,
		RejectedConnections,
		RejectedConnectionsPersec
	}

	public static class Win32_PerfRawData_AFDCounters_MicrosoftWinsockBSPExtension {
		public static string GetWMIValue(this Win32_PerfRawData_AFDCounters_MicrosoftWinsockBSP enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_AFDCounters_MicrosoftWinsockBSP", enumOption.ToString());
	}
}