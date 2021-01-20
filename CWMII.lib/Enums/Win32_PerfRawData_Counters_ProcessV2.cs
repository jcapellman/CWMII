namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_ProcessV2 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		CreatingProcessID,
		ElapsedTime,
		HandleCount,
		IODataBytesPersec,
		IODataOperationsPersec,
		IOOtherBytesPersec,
		IOOtherOperationsPersec,
		IOReadBytesPersec,
		IOReadOperationsPersec,
		IOWriteBytesPersec,
		IOWriteOperationsPersec,
		PageFaultsPersec,
		PageFileBytes,
		PageFileBytesPeak,
		PercentPrivilegedTime,
		PercentProcessorTime,
		PercentUserTime,
		PoolNonpagedBytes,
		PoolPagedBytes,
		PriorityBase,
		PrivateBytes,
		ProcessID,
		ThreadCount,
		VirtualBytes,
		VirtualBytesPeak,
		WorkingSet,
		WorkingSetPeak,
		WorkingSetPrivate
	}

	public static class Win32_PerfRawData_Counters_ProcessV2Extension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_ProcessV2 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_ProcessV2", enumOption.ToString());
	}
}