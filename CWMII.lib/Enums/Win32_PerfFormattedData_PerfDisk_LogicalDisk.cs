namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_PerfDisk_LogicalDisk {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AvgDiskBytesPerRead,
		AvgDiskBytesPerTransfer,
		AvgDiskBytesPerWrite,
		AvgDiskQueueLength,
		AvgDiskReadQueueLength,
		AvgDisksecPerRead,
		AvgDisksecPerTransfer,
		AvgDisksecPerWrite,
		AvgDiskWriteQueueLength,
		CurrentDiskQueueLength,
		DiskBytesPersec,
		DiskReadBytesPersec,
		DiskReadsPersec,
		DiskTransfersPersec,
		DiskWriteBytesPersec,
		DiskWritesPersec,
		FreeMegabytes,
		PercentDiskReadTime,
		PercentDiskTime,
		PercentDiskWriteTime,
		PercentFreeSpace,
		PercentIdleTime,
		SplitIOPerSec
	}

	public static class Win32_PerfFormattedData_PerfDisk_LogicalDiskExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_PerfDisk_LogicalDisk enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_PerfDisk_LogicalDisk", enumOption.ToString());
	}
}