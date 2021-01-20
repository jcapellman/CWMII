namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_TermService_TerminalServicesSession {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		HandleCount,
		PageFaultsPersec,
		PageFileBytes,
		PageFileBytesPeak,
		PercentPrivilegedTime,
		PercentProcessorTime,
		PercentUserTime,
		PoolNonpagedBytes,
		PoolPagedBytes,
		PrivateBytes,
		ThreadCount,
		VirtualBytes,
		VirtualBytesPeak,
		WorkingSet,
		WorkingSetPeak
	}

	public static class Win32_PerfFormattedData_TermService_TerminalServicesSessionExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_TermService_TerminalServicesSession enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_TermService_TerminalServicesSession", enumOption.ToString());
	}
}