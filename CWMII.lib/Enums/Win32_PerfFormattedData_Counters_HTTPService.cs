namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_HTTPService {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		CurrentUrisCached,
		TotalFlushedUris,
		TotalUrisCached,
		UriCacheFlushes,
		UriCacheHits,
		UriCacheMisses
	}

	public static class Win32_PerfFormattedData_Counters_HTTPServiceExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_HTTPService enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_HTTPService", enumOption.ToString());
	}
}