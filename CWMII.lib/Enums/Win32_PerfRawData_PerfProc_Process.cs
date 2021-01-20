namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_PerfProc_Process {
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
		IDProcess,
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
		ThreadCount,
		VirtualBytes,
		VirtualBytesPeak,
		WorkingSet,
		WorkingSetPeak,
		WorkingSetPrivate
	}

	public static class Win32_PerfRawData_PerfProc_ProcessExtension {
		public static string GetWMIValue(this Win32_PerfRawData_PerfProc_Process enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_PerfProc_Process", enumOption.ToString());
	}
}