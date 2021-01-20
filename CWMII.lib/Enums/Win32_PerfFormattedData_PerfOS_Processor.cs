namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_PerfOS_Processor {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		C1TransitionsPersec,
		C2TransitionsPersec,
		C3TransitionsPersec,
		DPCRate,
		DPCsQueuedPersec,
		InterruptsPersec,
		PercentC1Time,
		PercentC2Time,
		PercentC3Time,
		PercentDPCTime,
		PercentIdleTime,
		PercentInterruptTime,
		PercentPrivilegedTime,
		PercentProcessorTime,
		PercentUserTime
	}

	public static class Win32_PerfFormattedData_PerfOS_ProcessorExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_PerfOS_Processor enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor", enumOption.ToString());
	}
}