namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_NETMemoryCache40_NETMemoryCache40 {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		CacheEntries,
		CacheHitRatio,
		CacheHits,
		CacheMisses,
		CacheTrims,
		CacheTurnoverRate
	}

	public static class Win32_PerfFormattedData_NETMemoryCache40_NETMemoryCache40Extension {
		public static string GetWMIValue(this Win32_PerfFormattedData_NETMemoryCache40_NETMemoryCache40 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_NETMemoryCache40_NETMemoryCache40", enumOption.ToString());
	}
}