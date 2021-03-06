namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_HTTPServiceRequestQueues {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		ArrivalRate,
		CacheHitRate,
		CurrentQueueSize,
		MaxQueueItemAge,
		RejectedRequests,
		RejectionRate
	}

	public static class Win32_PerfRawData_Counters_HTTPServiceRequestQueuesExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_HTTPServiceRequestQueues enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_HTTPServiceRequestQueues", enumOption.ToString());
	}
}