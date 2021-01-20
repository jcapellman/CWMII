namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_ESENT_DatabaseDatabases {
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
		DatabaseCacheRequestsPersecUnique,
		DatabaseCacheSizeMB,
		IODatabaseReadsAverageLatency,
		IODatabaseReadsPersec,
		IODatabaseWritesAverageLatency,
		IODatabaseWritesPersec
	}

	public static class Win32_PerfFormattedData_ESENT_DatabaseDatabasesExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_ESENT_DatabaseDatabases enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_ESENT_DatabaseDatabases", enumOption.ToString());
	}
}