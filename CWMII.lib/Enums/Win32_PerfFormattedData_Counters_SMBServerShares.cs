namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_SMBServerShares {
		Caption,
		Description,
		Name,
		Frequency_Object,
		Frequency_PerfTime,
		Frequency_Sys100NS,
		Timestamp_Object,
		Timestamp_PerfTime,
		Timestamp_Sys100NS,
		AvgBytesPerRead,
		AvgBytesPerWrite,
		AvgDataBytesPerRequest,
		AvgDataQueueLength,
		AvgReadQueueLength,
		AvgsecPerDataRequest,
		AvgsecPerRead,
		AvgsecPerRequest,
		AvgsecPerWrite,
		AvgWriteQueueLength,
		BytesCompressedPersec,
		CompressedRequestsPersec,
		CompressedResponsesPersec,
		CurrentBypassOpenFileCount,
		CurrentDataQueueLength,
		CurrentDurableOpenFileCount,
		CurrentOpenFileCount,
		CurrentPendingRequests,
		DataBytesPersec,
		DataRequestsPersec,
		FilesOpenedPersec,
		MetadataRequestsPersec,
		PercentPersistentHandles,
		PercentResilientHandles,
		ReadBytesPersec,
		ReadBytestransmittedByPassCSVPersec,
		ReadBytestransmittedviaSMBDirectPersec,
		ReadRequestsPersec,
		ReadRequeststransmittedviaBypassCSVPersec,
		ReadRequeststransmittedviaSMBDirectPersec,
		ReceivedBytesPersec,
		RequestsPersec,
		SentBytesPersec,
		TotalDurableHandleReopenCount,
		TotalFailedDurableHandleReopenCount,
		TotalFailedPersistentHandleReopenCount,
		TotalFailedResilientHandleReopenCount,
		TotalFileOpenCount,
		TotalPersistentHandleReopenCount,
		TotalResilientHandleReopenCount,
		TransferredBytesPersec,
		TreeConnectCount,
		WriteBytesPersec,
		WriteBytestransmittedByPassCSVPersec,
		WriteBytestransmittedviaSMBDirectPersec,
		WriteRequestsPersec,
		WriteRequeststransmittedviaBypassCSVPersec,
		WriteRequeststransmittedviaSMBDirectPersec
	}

	public static class Win32_PerfFormattedData_Counters_SMBServerSharesExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_SMBServerShares enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_SMBServerShares", enumOption.ToString());
	}
}