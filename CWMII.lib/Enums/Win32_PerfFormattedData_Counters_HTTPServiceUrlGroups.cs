namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_HTTPServiceUrlGroups {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AllRequests,
		BytesReceivedRate,
		BytesSentRate,
		BytesTransferredRate,
		ConnectionAttempts,
		CurrentConnections,
		GetRequests,
		HeadRequests,
		MaxConnections
	}

	public static class Win32_PerfFormattedData_Counters_HTTPServiceUrlGroupsExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_HTTPServiceUrlGroups enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_HTTPServiceUrlGroups", enumOption.ToString());
	}
}