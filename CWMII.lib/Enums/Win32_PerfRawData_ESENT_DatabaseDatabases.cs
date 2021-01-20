namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_ESENT_DatabaseDatabases {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		DatabaseCachePercentHitUnique,
		DatabaseCachePercentHitUnique_Base,
		DatabaseCacheRequestsPersecUnique,
		DatabaseCacheSizeMB,
		IODatabaseReadsAverageLatency,
		IODatabaseReadsAverageLatency_Base,
		IODatabaseReadsPersec,
		IODatabaseWritesAverageLatency,
		IODatabaseWritesAverageLatency_Base,
		IODatabaseWritesPersec
	}

	public static class Win32_PerfRawData_ESENT_DatabaseDatabasesExtension {
		public static string GetWMIValue(this Win32_PerfRawData_ESENT_DatabaseDatabases enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_ESENT_DatabaseDatabases", enumOption.ToString());
	}
}