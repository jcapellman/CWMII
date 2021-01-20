namespace CWMII.lib.Enums {
	public enum Win32_PerfRawData_PerfDisk_PhysicalDisk {
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
		AvgDiskBytesPerRead_Base,
		AvgDiskBytesPerTransfer,
		AvgDiskBytesPerTransfer_Base,
		AvgDiskBytesPerWrite,
		AvgDiskBytesPerWrite_Base,
		AvgDiskQueueLength,
		AvgDiskReadQueueLength,
		AvgDisksecPerRead,
		AvgDisksecPerRead_Base,
		AvgDisksecPerTransfer,
		AvgDisksecPerTransfer_Base,
		AvgDisksecPerWrite,
		AvgDisksecPerWrite_Base,
		AvgDiskWriteQueueLength,
		CurrentDiskQueueLength,
		DiskBytesPersec,
		DiskReadBytesPersec,
		DiskReadsPersec,
		DiskTransfersPersec,
		DiskWriteBytesPersec,
		DiskWritesPersec,
		PercentDiskReadTime,
		PercentDiskReadTime_Base,
		PercentDiskTime,
		PercentDiskTime_Base,
		PercentDiskWriteTime,
		PercentDiskWriteTime_Base,
		PercentIdleTime,
		PercentIdleTime_Base,
		SplitIOPerSec
	}

	public static class Win32_PerfRawData_PerfDisk_PhysicalDiskExtension {
		public static string GetWMIValue(this Win32_PerfRawData_PerfDisk_PhysicalDisk enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfRawData_PerfDisk_PhysicalDisk", enumOption.ToString());
	}
}