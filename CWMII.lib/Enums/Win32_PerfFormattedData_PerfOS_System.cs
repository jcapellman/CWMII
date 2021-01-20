namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_PerfOS_System {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AlignmentFixupsPersec,
		ContextSwitchesPersec,
		ExceptionDispatchesPersec,
		FileControlBytesPersec,
		FileControlOperationsPersec,
		FileDataOperationsPersec,
		FileReadBytesPersec,
		FileReadOperationsPersec,
		FileWriteBytesPersec,
		FileWriteOperationsPersec,
		FloatingEmulationsPersec,
		PercentRegistryQuotaInUse,
		Processes,
		ProcessorQueueLength,
		SystemCallsPersec,
		SystemUpTime,
		Threads
	}

	public static class Win32_PerfFormattedData_PerfOS_SystemExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_PerfOS_System enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_PerfOS_System", enumOption.ToString());
	}
}