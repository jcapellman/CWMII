namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_NETMemoryCache40_NETMemoryCache40 {
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
		CacheHitRatio_Base,
		CacheHits,
		CacheMisses,
		CacheTrims,
		CacheTurnoverRate
	}

	public static class Win32_PerfRawData_NETMemoryCache40_NETMemoryCache40Extension {
		public static string GetWMIValue(this Win32_PerfRawData_NETMemoryCache40_NETMemoryCache40 enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_NETMemoryCache40_NETMemoryCache40", enumOption.ToString());
	}
}