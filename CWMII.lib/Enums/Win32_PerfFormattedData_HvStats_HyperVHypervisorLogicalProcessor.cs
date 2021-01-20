namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_HvStats_HyperVHypervisorLogicalProcessor {
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
		ContextSwitchesPersec,
		Frequency,
		HardwareInterruptsPersec,
		HWPRequestMSRContextSwitchesPersec,
		HypervisorBranchPredictorFlushesPersec,
		HypervisorImmediateL1DataCacheFlushesPersec,
		HypervisorL1DataCacheFlushesPersec,
		HypervisorMicroarchitecturalBufferFlushesPersec,
		InterProcessorInterruptsPersec,
		InterProcessorInterruptsSentPersec,
		MonitorTransitionCost,
		ParkingStatus,
		PercentC1Time,
		PercentC2Time,
		PercentC3Time,
		PercentGuestRunTime,
		PercentHypervisorRunTime,
		PercentIdleTime,
		PercentofMaxFrequency,
		PercentTotalRunTime,
		PerformanceMonitoringInterruptsPersec,
		PostedInterruptNotificationsPersec,
		ProcessorStateFlags,
		ReserveGroupId,
		RootVpIndex,
		RunningPriority,
		SchedulerInterruptsPersec,
		TimerInterruptsPersec,
		TotalInterruptsPersec
	}

	public static class Win32_PerfFormattedData_HvStats_HyperVHypervisorLogicalProcessorExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_HvStats_HyperVHypervisorLogicalProcessor enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_HvStats_HyperVHypervisorLogicalProcessor", enumOption.ToString());
	}
}