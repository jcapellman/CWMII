namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_rdyboost_ReadyBoostCache {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		Bytescached,
		CachereadbytesPersec,
		CachereadsPersec,
		Cachespaceused,
		CompressionRatio,
		SkippedreadbytesPersec,
		SkippedreadsPersec,
		Totalcachesizebytes,
		TotalreadbytesPersec,
		TotalreadsPersec
	}

	public static class Win32_PerfFormattedData_rdyboost_ReadyBoostCacheExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_rdyboost_ReadyBoostCache enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_rdyboost_ReadyBoostCache", enumOption.ToString());
	}
}