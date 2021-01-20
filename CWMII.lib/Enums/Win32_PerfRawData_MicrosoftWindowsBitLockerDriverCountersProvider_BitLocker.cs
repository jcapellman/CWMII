namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		MaxReadSplitSize,
		MaxWriteSplitSize,
		MinReadSplitSize,
		MinWriteSplitSize,
		ReadRequestsPersec,
		ReadSubrequestsPersec,
		WriteRequestsPersec,
		WriteSubrequestsPersec
	}

	public static class Win32_PerfRawData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLockerExtension {
		public static string GetWMIValue(this Win32_PerfRawData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_MicrosoftWindowsBitLockerDriverCountersProvider_BitLocker", enumOption.ToString());
	}
}