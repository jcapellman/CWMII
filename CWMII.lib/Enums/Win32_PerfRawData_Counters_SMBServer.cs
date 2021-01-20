namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_SMBServer {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ReadBytesPersec,
		ReadRequestsPersec,
		ReceiveBytesPersec,
		SendBytesPersec,
		WriteBytesPersec,
		WriteRequestsPersec
	}

	public static class Win32_PerfRawData_Counters_SMBServerExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_SMBServer enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_SMBServer", enumOption.ToString());
	}
}