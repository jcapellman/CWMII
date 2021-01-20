namespace CWMII.lib.Enums {
	public enum Win32_PerfFormattedData_Counters_SMBClientShares {
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
		AvgsecPerWrite,
		AvgWriteQueueLength,
		CompressedBytesSentPersec,
		CompressedRequestsPersec,
		CompressedResponsesPersec,
		CreditStallsPersec,
		CurrentDataQueueLength,
		DataBytesPersec,
		DataRequestsPersec,
		MetadataRequestsPersec,
		ReadBytesPersec,
		ReadBytestransmittedviaSMBDirectPersec,
		ReadRequestsPersec,
		ReadRequeststransmittedviaSMBDirectPersec,
		TurboIOReadsPersec,
		TurboIOWritesPersec,
		WriteBytesPersec,
		WriteBytestransmittedviaSMBDirectPersec,
		WriteRequestsPersec,
		WriteRequeststransmittedviaSMBDirectPersec
	}

	public static class Win32_PerfFormattedData_Counters_SMBClientSharesExtension {
		public static string GetWMIValue(this Win32_PerfFormattedData_Counters_SMBClientShares enumOption) => lib.CWMII.GetSingleProperty($"SELECT * FROM Win32_PerfFormattedData_Counters_SMBClientShares", enumOption.ToString());
	}
}