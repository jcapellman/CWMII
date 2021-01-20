namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Spooler_PrintQueue {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AddNetworkPrinterCalls,
		BytesPrintedPersec,
		EnumerateNetworkPrinterCalls,
		JobErrors,
		Jobs,
		JobsSpooling,
		MaxJobsSpooling,
		MaxReferences,
		NotReadyErrors,
		OutofPaperErrors,
		References,
		TotalJobsPrinted,
		TotalPagesPrinted
	}

	public static class Win32_PerfRawData_Spooler_PrintQueueExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Spooler_PrintQueue enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Spooler_PrintQueue", enumOption.ToString());
	}
}