namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ContentionRatePersec,
		CurrentQueueLength,
		NumberofcurrentlogicalThreads,
		NumberofcurrentphysicalThreads,
		Numberofcurrentrecognizedthreads,
		Numberoftotalrecognizedthreads,
		QueueLengthPeak,
		QueueLengthPersec,
		rateofrecognizedthreadsPersec,
		TotalNumberofContentions
	}

	public static class Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreadsExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_NETFramework_NETCLRLocksAndThreads", enumOption.ToString());
	}
}