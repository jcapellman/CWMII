namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_ESENT_DatabaseTableClasses {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		DatabaseCacheMissAttachedAverageLatency,
		DatabaseCacheMissAttachedAverageLatency_Base,
		DatabaseCacheMissesPersec,
		DatabaseCachePercentHit,
		DatabaseCachePercentHit_Base,
		DatabaseCachePercentHitUnique,
		DatabaseCachePercentHitUnique_Base,
		DatabaseCacheRequestsPersec,
		DatabaseCacheRequestsPersecUnique,
		DatabaseCacheSize,
		DatabaseCacheSizeMB
	}

	public static class Win32_PerfRawData_ESENT_DatabaseTableClassesExtension {
		public static string GetWMIValue(this Win32_PerfRawData_ESENT_DatabaseTableClasses enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_ESENT_DatabaseTableClasses", enumOption.ToString());
	}
}