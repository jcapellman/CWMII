namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_Counters_FileSystemDiskActivity {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		FileSystemBytesRead,
		FileSystemBytesWritten
	}

	public static class Win32_PerfRawData_Counters_FileSystemDiskActivityExtension {
		public static string GetWMIValue(this Win32_PerfRawData_Counters_FileSystemDiskActivity enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_Counters_FileSystemDiskActivity", enumOption.ToString());
	}
}