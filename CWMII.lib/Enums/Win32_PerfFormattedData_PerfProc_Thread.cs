namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_PerfProc_Thread {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ContextSwitchesPersec,
		ElapsedTime,
		IDProcess,
		IDThread,
		PercentPrivilegedTime,
		PercentProcessorTime,
		PercentUserTime,
		PriorityBase,
		PriorityCurrent,
		StartAddress,
		ThreadState,
		ThreadWaitReason
	}

	public static class Win32_PerfFormattedData_PerfProc_ThreadExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_PerfProc_Thread enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_PerfProc_Thread", enumOption.ToString());
	}
}