namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_ProcessorInformation {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AverageIdleTime,
		AverageIdleTime_Base,
		C1TransitionsPersec,
		C2TransitionsPersec,
		C3TransitionsPersec,
		ClockInterruptsPersec,
		DPCRate,
		DPCsQueuedPersec,
		IdleBreakEventsPersec,
		InterruptsPersec,
		ParkingStatus,
		PercentC1Time,
		PercentC2Time,
		PercentC3Time,
		PercentDPCTime,
		PercentIdleTime,
		PercentInterruptTime,
		PercentofMaximumFrequency,
		PercentPerformanceLimit,
		PercentPriorityTime,
		PercentPrivilegedTime,
		PercentPrivilegedUtility,
		PercentPrivilegedUtility_Base,
		PercentProcessorPerformance,
		PercentProcessorPerformance_Base,
		PercentProcessorTime,
		PercentProcessorUtility,
		PercentProcessorUtility_Base,
		PercentUserTime,
		PerformanceLimitFlags,
		ProcessorFrequency,
		ProcessorStateFlags
	}

	public static class Win32_PerfRawData_Counters_ProcessorInformationExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_ProcessorInformation enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_ProcessorInformation", enumOption.ToString());
	}
}